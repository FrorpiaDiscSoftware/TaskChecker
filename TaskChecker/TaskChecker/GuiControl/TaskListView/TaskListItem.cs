using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TaskChecker.Properties;

namespace TaskChecker.GuiControl
{
	public partial class TaskListItem : UserControl
	{
		private const int TITLE_HEIGHT = 25;//作業工程タイトルの高さ
		//-----------------------------------------------------------------------------
		private bool                                    _isSelected            = false;                                        //選択されているかどうかのフラグ(trueで選択中)
		private int                                     _id                    = 0;                                            //このコントロールのID(Indexに使用)
		private string                                  _guid                  = Guid.NewGuid().ToString("N");          //このコントロールのGUID※ユニークなID。インスタンス化後は変更不可。
		private TaskState                               _processState          = TaskState.NOT_WORKING;                        //作業工程の進行状態
		private Dictionary<TaskState,ToolStripMenuItem> _processStateMenuItems = new Dictionary<TaskState,ToolStripMenuItem>();//作業工程の進行状態設定メニュー項目リスト
		//-----------------------------------------------------------------------------
		public bool                      isSelected                 { get => _isSelected; set => SetSelected(value); }//選択されているかどうかのフラグ(trueで選択中)
		public bool                      isPressControlKey          { get => _processListLayoutPanel.isPressControlKey; }//Controlキーが押されているかどうか(trueで押されている)
		public bool                      isPressShiftKey            { get => _processListLayoutPanel.isPressShiftKey; }//Shiftキーが押されているかどうか(trueで押されている)
		public bool                      isExpanded                 { get => !_contentContainer.Panel2Collapsed; set => SetExpanded(value);       }//子の作業プロセスが展開表示されているかどうか
		public bool                      isEnableMemoArea           { get => !_contentContainer.Panel1Collapsed; set => SetEnableMemoArea(value); }//メモ書き用テキストエリアの表示が有効かどうか
		public bool                      isProcessTitleEditMode     { get => !_processTitleContainer.Panel2Collapsed; }//作業工程タイトルテキストの編集モード状態
		public int                       id                         { get => _id; set => _id = value; }//このコントロールのID(Indexに使用)
		public string                    guid                       { get => _guid; }//このコントロールのGUID
		public TaskState                 processState               { get => _processState; set => SetProcessState(value); }//作業工程の進行状態
		public string                    processTitle               { get => _processTitle.Text; set => SetProcessTitle(value); }//作業工程のタイトルテキスト
		public string                    memoContent                { get => _memoTextArea.Text; set => _memoTextArea.Text = value; }//メモ書き用テキストエリアの内容
		public Action<TaskListItem>      onClickSelected            { get; set; } = null;//クリック操作による選択イベント
		public Action<TaskListItem,Size> onResizeRequest            { get; set; } = null;//リサイズ発生とリクエストイベント※親はこのイベントに応じて自身のサイズを変える必要あり。
		//-----------------------------------------------------------------------------
		
		
		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓追加定義クラス関連
		
		/// <summary>
		/// 表示内容の一括設定データクラス
		/// </summary>
		public class Entity
		{
			/// <summary>
			/// このコントロールのID(Indexに使用)
			/// </summary>
			public int id = 0;
			
			/// <summary>
			/// 子の作業プロセスを展開するかどうか<br />
			/// ※trueで展開。
			/// </summary>
			public bool isExpanded = false;
			
			/// <summary>
			/// メモ書き用テキストエリアの表示が有効かどうか<br />
			/// ※trueで有効。
			/// </summary>
			public bool isEnableMemoArea = false;

			/// <summary>
			/// 作業工程の進行状態
			/// </summary>
			public TaskState processState = TaskState.NOT_WORKING;
			
			/// <summary>
			/// 作業工程のタイトルテキスト
			/// </summary>
			public string processTitle = "";

			/// <summary>
			/// メモ書き用テキストエリアの内容
			/// </summary>
			public string memoContent = "";

			/// <summary>
			/// 子の作業工程リスト
			/// </summary>
			public List<Entity> children = null;

			/// <summary>
			/// クリック操作による選択イベント
			/// </summary>
			public Action<TaskListItem> onClickSelected = null;

			/// <summary>
			/// リサイズ発生とリクエストイベント<br />
			/// ※親はこのイベントに応じて自身のサイズを変える必要あり。
			/// </summary>
			public Action<TaskListItem,Size> onResizeRequest = null;
		}
		
		
		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓システム関連
		
		/// <summary>
		/// コンストラクタ(引数なし)
		/// </summary>
		public TaskListItem()
		{
			InitializeComponent();
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="pEntity">初期設定</param>
		public TaskListItem( Entity pEntity )
		{
			InitializeComponent();
			Setup(pEntity);
		}

		/// <summary>
		/// 表示内容の一括セットアップを行なう関数
		/// </summary>
		/// <param name="pEntity">全表示内容の設定</param>
		public void Setup( Entity pEntity )
		{
			if ( pEntity == null ) { return; }
			
			SetupProcessStateMenu();

			_id                = pEntity.id;
			_memoTextArea.Text = pEntity.memoContent;
			
			onClickSelected = pEntity.onClickSelected;
			onResizeRequest = pEntity.onResizeRequest;
			
			_processListLayoutPanel.Setup(new ProcessListLayoutPanel.Entity {
				id       = 0,
				children = pEntity.children,
			});
			
			SetExpanded(pEntity.isExpanded);
			SetEnableMemoArea(pEntity.isEnableMemoArea);
			SetProcessState(pEntity.processState);
			SetProcessTitle(pEntity.processTitle);
			SetProcessTitleEditMode(false);
		}

		/// <summary>
		/// 作業工程の進行状態設定メニューをセットアップする関数
		/// </summary>
		/// <param name="pReSetup">再セットアップを行なうかどうか(trueで行なう)</param>
		private void SetupProcessStateMenu( bool pReSetup = false )
		{
			if ( !pReSetup && _processStateMenuItems.Count > 0 ) { return; }
			
			_processStateMenuItems.Clear();
			_processStateMenu.Items.Clear();
			
			foreach( TaskState value in Enum.GetValues(typeof(TaskState)) ) {
				_processStateMenuItems.Add(value, new ToolStripMenuItem{ Name = value.ToMenuItemName() , Text = value.ToMenuItemText() });
				_processStateMenuItems[value].Click += ( pSender , pArgs ) => { SetProcessState(value); };
				_processStateMenu.Items.Add(_processStateMenuItems[value]);
			}
		}

		/// <summary>
		/// 作業工程を追加する関数
		/// </summary>
		/// <param name="pEntity">作業工程の初期設定</param>
		public void AddProcessItem( Entity pEntity = null )
		{
			SetExpanded(true);

			_processListLayoutPanel.AddProcessItem(pEntity);

			ReSize(new Size( Size.Width , Size.Height + (_processListLayoutPanel.layoutPanelSize.Height - _processListLayoutPanel.Size.Height) ));
		}

		/// <summary>
		/// 指定したIndexの作業工程を削除する関数
		/// </summary>
		/// <param name="pIndex">削除するIndex</param>
		public void RemoveProcessItem( int pIndex )
		{
			if ( _processListLayoutPanel.childrenCount <= 0 || pIndex < 0 || pIndex >= _processListLayoutPanel.childrenCount ) { return; }
			
			_processListLayoutPanel.RemoveProcessItem(pIndex);
			
			ReSize(new Size( Size.Width , Size.Height + (_processListLayoutPanel.layoutPanelSize.Height - _processListLayoutPanel.Size.Height) ));
			
			if ( _processListLayoutPanel.childrenCount <= 0 ) { SetExpanded(false); }
		}

		/// <summary>
		/// 選択している作業工程を削除する関数
		/// </summary>
		public void RemoveSelectedProcessItems()
		{
			if ( _processListLayoutPanel.selectionCount <= 0 ) { return; }

			_processListLayoutPanel.RemoveSelectedProcessItems();
			
			ReSize(new Size( Size.Width , Size.Height + (_processListLayoutPanel.layoutPanelSize.Height - _processListLayoutPanel.Size.Height) ));
			
			if ( _processListLayoutPanel.childrenCount <= 0 ) { SetExpanded(false); }
		}

		/// <summary>
		/// 作業工程を初期化(クリア)する関数
		/// </summary>
		public void ClearProcessItem()
		{
			_processListLayoutPanel.ClearProcessItem();
			ReSize(new Size( Size.Width , Size.Height + (_processListLayoutPanel.layoutPanelSize.Height - _processListLayoutPanel.Size.Height) ));
			SetExpanded(false);
		}

		/// <summary>
		/// 子の作業工程の選択状態を初期化(クリア)する関数
		/// </summary>
		public void ClearChildSelections() => _processListLayoutPanel.ClearChildSelections();
		
		/// <summary>
		/// このコントロールのリサイズを行なう関数<br />
		/// ※Dock状態に応じて対応方法を調整します。<br />
		/// ※自身でサイズ変更を行なう場合は本関数を必ず使用してください。
		/// </summary>
		/// <param name="pSize">新しいサイズ</param>
		private void ReSize( Size pSize )
		{
			if ( pSize == Size ) { return; }
			if ( pSize.Height < TITLE_HEIGHT ) { pSize.Height = TITLE_HEIGHT; }
			if ( Dock != DockStyle.Fill && onResizeRequest == null ) { Size = pSize; } else { onResizeRequest.Invoke(this,pSize); }
			Update();
		}
		
		
		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓アクセサ関連

		/// <summary>
		/// 選択状態を設定する関数
		/// </summary>
		/// <param name="pIsSelected">選択状態(trueで選択中)</param>
		private void SetSelected( bool pIsSelected )
		{
			_processTitle.BackColor = (pIsSelected)? SystemColors.Highlight         : SystemColors.Control;
			_processTitle.ForeColor = (pIsSelected)? SystemColors.ControlLightLight : SystemColors.ControlText;

			BackColor = _processTitle.BackColor;
			_rootContainer         .BackColor = _rootContainer         .Panel1.BackColor = _rootContainer         .Panel2.BackColor = _processTitle.BackColor;
			_headerContainer       .BackColor = _headerContainer       .Panel1.BackColor = _headerContainer       .Panel2.BackColor = _processTitle.BackColor;
			_headerStatusContainer .BackColor = _headerStatusContainer .Panel1.BackColor = _headerStatusContainer .Panel2.BackColor = _processTitle.BackColor;
			_headerContentContainer.BackColor = _headerContentContainer.Panel1.BackColor = _headerContentContainer.Panel2.BackColor = _processTitle.BackColor;
			_contentContainer      .BackColor = _contentContainer      .Panel1.BackColor = _contentContainer      .Panel2.BackColor = _processTitle.BackColor;
			
			_isSelected = pIsSelected;
		}

		/// <summary>
		/// 子の作業工程の選択状態を設定する関数
		/// </summary>
		/// <param name="pIndex"      >設定対象のリストIndex</param>
		/// <param name="pIsSelected" >選択状態(trueで選択中)</param>
		/// <param name="pIsIgnoreKey">キー入力を無視するかどうか(trueで無視)</param>
		public void SetChildSelected( int pIndex, bool pIsSelected, bool pIsIgnoreKey = false ) =>
			_processListLayoutPanel.SetChildSelected(pIndex, pIsSelected, pIsIgnoreKey);
		
		/// <summary>
		/// 子の作業プロセスの展開表示状態を設定する関数
		/// </summary>
		/// <param name="pIsExpanded">展開表示するかどうか(trueで展開)</param>
		private void SetExpanded( bool pIsExpanded )
		{
			bool fIsNoChange = pIsExpanded == isExpanded;//展開状態に変化が無いかどうか(trueで変化なし)
			Size fPanel2Size = (_contentContainer.Panel2.Controls.Count > 0)? _contentContainer.Panel2.Controls[0].Size : Size.Empty;
			
			_contentContainer.Panel2Collapsed = !pIsExpanded;
			
			_expandButton.BackgroundImage = (!pIsExpanded)? Resources.arrowStateBlueRight : Resources.arrowStateBlueExpanded;
			
			_contentContainer.Visible = (!_contentContainer.Panel1Collapsed || !_contentContainer.Panel2Collapsed);
			
			if ( !fIsNoChange ) { ReSize(new Size(Size.Width, (pIsExpanded)? Size.Height + fPanel2Size.Height : Size.Height - fPanel2Size.Height)); }
		}

		/// <summary>
		/// メモ書き用テキストエリアの表示状態を設定する関数
		/// </summary>
		/// <param name="pIsEnableMemoArea">メモ書きエリアが有効かどうか(trueで有効)</param>
		private void SetEnableMemoArea( bool pIsEnableMemoArea )
		{
			bool fIsNoChange = pIsEnableMemoArea == isEnableMemoArea;//メモ書きテキストエリアの展開状態に変化が無いかどうか(trueで変化なし)
			Size fPanel1Size = _memoTextArea.Size;//※Panel1にはテキストエリアしかないので、テキストエリアを見るだけでOK。
			
			_contentContainer.Panel1Collapsed = !pIsEnableMemoArea;

			_memoButton.FlatStyle = (!pIsEnableMemoArea)? FlatStyle.Standard : FlatStyle.Flat;
			
			_contentContainer.Visible = (!_contentContainer.Panel1Collapsed || !_contentContainer.Panel2Collapsed);
			
			if ( !fIsNoChange ) { ReSize(new Size(Size.Width, (pIsEnableMemoArea)? Size.Height + fPanel1Size.Height : Size.Height - fPanel1Size.Height)); }
		}

		/// <summary>
		/// 作業工程の進行状態を設定する関数
		/// </summary>
		/// <param name="pState">作業工程の状態を表す定数値</param>
		private void SetProcessState( TaskState pState )
		{
			_statusButton.BackgroundImage = pState.ToTaskStateIcon();
			
			SetupProcessStateMenu();
			
			_processStateMenuItems[_processState].Checked = false;
			_processStateMenuItems[pState       ].Checked = true;
			
			_processState = pState;
		}

		/// <summary>
		/// 作業工程タイトルテキストを設定する関数
		/// </summary>
		/// <param name="pTitleText">設定する新しいタイトルテキスト</param>
		private void SetProcessTitle( string pTitleText )
		{
			if ( pTitleText == null ) { return; }

			_processTitleInputBox.Text = _processTitle.Text = pTitleText;
		}

		/// <summary>
		/// 作業工程タイトルテキストの編集モード状態を設定する関数
		/// </summary>
		/// <param name="pIsEditMode">編集モードかどうか(trueで編集モード)</param>
		private void SetProcessTitleEditMode( bool pIsEditMode )
		{
			_processTitleContainer.Panel1Collapsed = pIsEditMode;
			_processTitleContainer.Panel2Collapsed = !pIsEditMode;
		}

		/// <summary>
		/// 指定したIndexの作業工程を返す関数
		/// </summary>
		/// <param name="pIndex"></param>
		/// <returns></returns>
		public TaskListItem GetProcessItem( int pIndex ) => _processListLayoutPanel.GetProcessItem(pIndex);
	}
}