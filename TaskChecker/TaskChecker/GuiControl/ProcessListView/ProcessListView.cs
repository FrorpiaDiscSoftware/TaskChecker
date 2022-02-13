using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TaskChecker.GuiControl
{
    public partial class ProcessListView : UserControl
    {
        private bool                            _isPressControlKey = false;                                //Controlキーが押されているかどうか(trueで押されている)
        private bool                            _isPressShiftKey   = false;                                //Shiftキーが押されているかどうか(trueで押されている)
        private int                             _id                = 0;                                    //このコントロールのID(Indexに使用)
        private List<TaskListItem>              _children          = new List<TaskListItem>();             //子の作業工程リスト
        private Dictionary<string,TaskListItem> _selections        = new Dictionary<string,TaskListItem>();//現在選択している作業工程リスト(キー：GUID)
        private TaskListItem                    _lastSelectedItem  = null;                                 //最後に選択した作業工程項目
        //-----------------------------------------------------------------------------
        public bool isPressControlKey { get => _isPressControlKey; }//Controlキーが押されているかどうか(trueで押されている)
        public bool isPressShiftKey   { get => _isPressShiftKey; }//Shiftキーが押されているかどうか(trueで押されている)
        public int  id                { get => _id; }//このコントロールのID(Indexに使用)
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
            /// 子の作業工程リスト
            /// </summary>
            public List<TaskListItem.Entity> children = null;
        }


        //～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
        //↓システム関連

        /// <summary>
        /// コンストラクタ(引数なし)
        /// </summary>
        public ProcessListView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="pEntity">初期設定</param>
        public ProcessListView( Entity pEntity )
        {
            InitializeComponent();
            Setup(pEntity);
        }


        //～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
        //↓基本機能関連

        /// <summary>
        /// 表示内容の一括セットアップを行なう関数
        /// </summary>
        /// <param name="pEntity">全表示内容の設定</param>
        public void Setup( Entity pEntity )
        {
            if ( pEntity == null ) { return; }
			
            ClearChildSelections();
            
            _id = pEntity.id;

            if ( pEntity.children != null )
            {
                ClearProcessItem();
                pEntity.children.ForEach(value => { AddProcessItem(value); });
            }

            KeyDown += ( pSender, pArgs ) =>
            {
                if ( pArgs.Control ) { _isPressControlKey = true; }
                if ( pArgs.Shift   ) { _isPressShiftKey   = true; }
            };
			
            KeyUp += ( pSender, pArgs ) =>
            {
                if ( pArgs.Control ) { _isPressControlKey = false; }
                if ( pArgs.Shift   ) { _isPressShiftKey   = false; }
            };
        }

        /// <summary>
        /// 作業工程を追加する関数
        /// </summary>
        /// <param name="pEntity">作業工程の初期設定</param>
        public void AddProcessItem( TaskListItem.Entity pEntity = null )
        {
	        if ( pEntity == null ) { pEntity = new TaskListItem.Entity(); }

	        Size fNewLayoutPanelSize = _listItemLayoutPanel.Size;//新たに設定するLayoutPanelのサイズ
	        
	        if ( _children.Count <= 0 ) { _listItemLayoutPanel.RowStyles.Clear(); }

	        pEntity.id = _children.Count;
	        
	        _children.Add(new TaskListItem(pEntity));

	        fNewLayoutPanelSize.Height = _children.Last().Size.Height;
	        if ( _listItemLayoutPanel.RowStyles.Count > 0 ) { fNewLayoutPanelSize.Height += _listItemLayoutPanel.Size.Height; }

	        _listItemLayoutPanel.Size = fNewLayoutPanelSize;
	        _listItemLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, _children.Last().Size.Height));
	        _listItemLayoutPanel.Controls.Add(_children.Last(), 0, _children.Count - 1);
	        
	        _children.Last().Dock = DockStyle.Top;
        }

        /// <summary>
        /// 指定したIndexの作業工程を削除する関数
        /// </summary>
        /// <param name="pIndex">削除するIndex</param>
        public void RemoveProcessItem( int pIndex )
        {
            if ( _children.Count <= 0 || pIndex < 0 || pIndex >= _children.Count ) { return; }

            if ( _children.Count <= 1 ) { ClearProcessItem(); return; }
			
            SetChildSelected(pIndex, false, true);
            
            //▽削除処理１
            _listItemLayoutPanel.Controls.Remove(_children[pIndex]);

            //▽ID調整+テーブルレイアウトの登録位置調整
            if ( pIndex + 1 < _children.Count )
            {
                for( int i = pIndex + 1; i < _children.Count; i++ )
                {
                    _children[i].id--;
                    _listItemLayoutPanel.Controls.Remove(_children[i]);
                    _listItemLayoutPanel.RowStyles[_children[i].id].Height = _children[i].Size.Height;
                    _listItemLayoutPanel.Controls.Add(_children[i], 0, _children[i].id);
                }
            }

            //▽削除処理２
            _listItemLayoutPanel.RowStyles.RemoveAt(_listItemLayoutPanel.RowStyles.Count - 1);
            _listItemLayoutPanel.Size = new Size(_listItemLayoutPanel.Size.Width, _listItemLayoutPanel.Size.Height - _children[pIndex].Size.Height);
            _children.RemoveAt(pIndex);
        }

        /// <summary>
        /// 選択している作業工程を削除する関数
        /// </summary>
        public void RemoveSelectedProcessItems()
        {
            if ( _selections.Count <= 0 ) { return; }

            while( _selections.Count > 0 )
            {
                RemoveProcessItem(_selections.First().Value.id);
            }
        }

        /// <summary>
        /// 作業工程を初期化(クリア)する関数
        /// </summary>
        public void ClearProcessItem()
        {
	        ClearChildSelections();
	        
	        _listItemLayoutPanel.Size = new Size(_listItemLayoutPanel.Size.Width, 0);
	        
            _listItemLayoutPanel.Controls.Clear();
            _listItemLayoutPanel.RowStyles.Clear();
            _children.Clear();
        }

        /// <summary>
        /// 子の作業工程の選択状態を初期化(クリア)する関数
        /// </summary>
        public void ClearChildSelections()
        {
            if ( _selections.Count <= 0 ) { return; }
			
            foreach( var value in _selections )
            {
                value.Value.isSelected = false;
            }
			
            _selections.Clear();
        }
		
		
        //～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
        //↓アクセサ関連

		/// <summary>
		/// 子の作業工程の選択状態を設定する関数
		/// </summary>
		/// <param name="pIndex"      >設定対象のリストIndex</param>
		/// <param name="pIsSelected" >選択状態(trueで選択中)</param>
		/// <param name="pIsIgnoreKey">キー入力を無視するかどうか(trueで無視)</param>
		public void SetChildSelected( int pIndex , bool pIsSelected , bool pIsIgnoreKey = false )
		{
			if ( _children.Count <= 0 || pIndex < 0 || pIndex >= _children.Count ) { return; }
			
			_children[pIndex].isSelected = pIsSelected;
			
			if ( !pIsSelected ){ if ( _selections.ContainsKey(_children[pIndex].guid) ) { _selections.Remove(_children[pIndex].guid); } return; }
			
			if ( !_selections.ContainsKey(_children[pIndex].guid) ) { _selections.Add(_children[pIndex].guid, _children[pIndex]); }
			
			if ( pIsIgnoreKey ) { _lastSelectedItem = _children[pIndex]; return; }

			if ( !_isPressControlKey )
			{
				//↓Controlキーが押されていない場合(単体選択動作を行なう)
				for( int i = 0; i < _children.Count; i++ )
				{
					if ( i == _children[pIndex].id ) { continue; }
					_children[i].isSelected = false;
					if ( _selections.ContainsKey(_children[i].guid) ) { _selections.Remove(_children[i].guid); }
				}
			}
			
			if ( _isPressShiftKey )
			{
				//↓Shiftキーを押しながらだった場合(前回選択した物から今回選択した物までを選択する)
				Pair<int,int> fSelectIdxArea = new Pair<int,int>((_lastSelectedItem != null)? _lastSelectedItem.id : 0, _children[pIndex].id);
				//-------------------------------------------------------------
				if ( fSelectIdxArea.first > fSelectIdxArea.second ) { (fSelectIdxArea.first, fSelectIdxArea.second) = (fSelectIdxArea.second, fSelectIdxArea.first); }
				//-------------------------------------------------------------
				for( int i = fSelectIdxArea.first; i <= fSelectIdxArea.second; i++ )
				{
					_children[i].isSelected = true;
					if ( !_selections.ContainsKey(_children[i].guid) ) { _selections.Add(_children[i].guid, _children[i]); }
				}
			}
			
			_lastSelectedItem = _children[pIndex];
		}
    }
}