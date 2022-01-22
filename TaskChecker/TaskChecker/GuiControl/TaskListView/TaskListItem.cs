using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TaskChecker.Properties;

namespace TaskChecker.GuiControl
{
	public partial class TaskListItem : UserControl
	{
		private TaskState                               _processState          = TaskState.NOT_WORKING;                        //作業工程の進行状態
		private Dictionary<TaskState,ToolStripMenuItem> _processStateMenuItems = new Dictionary<TaskState,ToolStripMenuItem>();//作業工程の進行状態設定メニュー項目リスト
		private List<ListItemContainer<TaskListItem>>   _children              = new List<ListItemContainer<TaskListItem>>();  //子の作業工程リスト
		//-----------------------------------------------------------------------------
		public bool                 isExpanded                 { get => !_contentContainer.Panel2Collapsed; set => SetExpanded(value);       }//子の作業プロセスが展開表示されているかどうか
		public bool                 isProcessTitleEditMode     { get => !_processTitleContainer.Panel2Collapsed; }//作業工程タイトルテキストの編集モード状態
		public bool                 isEnableMemoArea           { get => !_contentContainer.Panel1Collapsed; set => SetEnableMemoArea(value); }//メモ書き用テキストエリアの表示が有効かどうか
		public TaskState            processState               { get => _processState; set => SetProcessState(value); }//作業工程の進行状態
		public string               processTitle               { get => _processTitle.Text; set => SetProcessTitle(value); }//作業工程のタイトルテキスト
		public Action<TaskListItem> onClickRemoveProcessButton { get; set; } = null;//この作業工程の削除ボタン押下イベント
		public string               memoContent                { get => _memoTextArea.Text; set => _memoTextArea.Text = value; }//メモ書き用テキストエリアの内容
		//-----------------------------------------------------------------------------
		
		
		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓追加定義クラス関連
		
		/// <summary>
		/// 表示内容の一括設定データクラス
		/// </summary>
		public class Entity
		{
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
			/// この作業工程の削除ボタン押下イベント
			/// </summary>
			public Action<TaskListItem> onClickRemoveProcessButton = null;

			/// <summary>
			/// メモ書き用テキストエリアの内容
			/// </summary>
			public string memoContent = "";

			/// <summary>
			/// 子の作業工程リスト
			/// </summary>
			public List<Entity> children = null;
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
		/// 表示内容の一括セットアップを行なう関数
		/// </summary>
		/// <param name="pEntity">全表示内容の設定</param>
		public void Setup( Entity pEntity )
		{
			if ( pEntity == null ) { return; }
			
			SetupProcessStateMenu();
			
			SetExpanded(pEntity.isExpanded);
			SetEnableMemoArea(pEntity.isEnableMemoArea);
			SetProcessState(pEntity.processState);
			SetProcessTitle(pEntity.processTitle);

			onClickRemoveProcessButton = pEntity.onClickRemoveProcessButton;
			_memoTextArea.Text         = pEntity.memoContent;

			if ( pEntity.children != null )
			{
				ClearProcessItem();
				pEntity.children.ForEach(value => { AddProcessItem(value); });
			}
			
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
			ListItemContainer<TaskListItem>.Entity fItemEntity = new ListItemContainer<TaskListItem>.Entity();
			
			fItemEntity.item = new TaskListItem();

			SetExpanded(true);
			Update();
			
			if ( _contentContainer.Panel2.Controls.Count <= 0 )
			{
				_children.Clear();
				_children.Add(new ListItemContainer<TaskListItem>());
				_contentContainer.Panel2.Controls.Add(_children.Last());
				_children.Last().Dock = DockStyle.Fill;
				_children.Last().Update();
				_children.Last().Setup(fItemEntity);
			}
			else
			{
				_children.Last().SetNext(fItemEntity);
				_children.Add(_children.Last().next);
			}
			
			fItemEntity.item.Setup((pEntity != null)? pEntity : new Entity());
		}

		/// <summary>
		/// 指定したIndexの作業工程を削除する関数
		/// </summary>
		/// <param name="pIndex">削除するIndex</param>
		public void RemoveProcessItem( int pIndex )
		{
			if ( _children.Count <= 0 || pIndex >= _children.Count ) { return; }

			ListItemContainer<TaskListItem> fJoinItemContainer = (pIndex + 1 < _children.Count)? _children[pIndex + 1] : null;
			
			if ( _children.Count <= 1 ) { ClearProcessItem(); return; }

			if ( pIndex == 0 )
			{
				_contentContainer.Panel2.Controls.Clear();
				_contentContainer.Panel2.Controls.Add(fJoinItemContainer);
				fJoinItemContainer.Dock = DockStyle.Fill;
				fJoinItemContainer.Update();
				_children.RemoveAt(pIndex);
			}
			else
			{
				_children[pIndex - 1].SetNext(fJoinItemContainer);
				_children.RemoveAt(pIndex);
			}
		}

		/// <summary>
		/// 作業工程を初期化(クリア)する関数
		/// </summary>
		public void ClearProcessItem()
		{
			_children.Clear();
			_contentContainer.Panel2.Controls.Clear();
		}
		
		
		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓アクセサ関連

		/// <summary>
		/// メモ書き用テキストエリアの表示状態を設定する関数
		/// </summary>
		/// <param name="pIsEnableMemoArea">メモ書きエリアが有効かどうか(trueで有効)</param>
		private void SetEnableMemoArea( bool pIsEnableMemoArea )
		{
			_contentContainer.Panel1Collapsed = !pIsEnableMemoArea;

			_memoButton.FlatStyle = (!pIsEnableMemoArea)? FlatStyle.Standard : FlatStyle.Flat;
			
			_contentContainer.Visible = (!_contentContainer.Panel1Collapsed || !_contentContainer.Panel2Collapsed);
		}
		
		/// <summary>
		/// 子の作業プロセスの展開表示状態を設定する関数
		/// </summary>
		/// <param name="pIsExpanded">展開表示するかどうか(trueで展開)</param>
		private void SetExpanded( bool pIsExpanded )
		{
			_contentContainer.Panel2Collapsed = !pIsExpanded;
			
			_expandButton.BackgroundImage = (!pIsExpanded)? Resources.arrowStateBlueRight : Resources.arrowStateBlueExpanded;
			
			_contentContainer.Visible = (!_contentContainer.Panel1Collapsed || !_contentContainer.Panel2Collapsed);
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
		public TaskListItem GetProcessItem( int pIndex )
		{
			return (pIndex < _children.Count)? _children[pIndex].item : null;
		}
	}
}