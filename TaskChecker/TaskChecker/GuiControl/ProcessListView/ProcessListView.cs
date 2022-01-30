using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TaskChecker.GuiControl
{
    public partial class ProcessListView : UserControl
    {
        private bool                                  _isPressControlKey = false;                                      //Controlキーが押されているかどうか(trueで押されている)
        private bool                                  _isPressShiftKey   = false;                                      //Shiftキーが押されているかどうか(trueで押されている)
        private int                                   _id                = 0;                                          //このコントロールのID(Indexに使用)
        private List<ListItemContainer<TaskListItem>> _children          = new List<ListItemContainer<TaskListItem>>();//子の作業工程リスト
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
            ListItemContainer<TaskListItem>.Entity fItemEntity = new ListItemContainer<TaskListItem>.Entity();
			
            fItemEntity.item = new TaskListItem();

            Update();
			
            if ( _rootContainer.Panel2.Controls.Count <= 0 )
            {
                _children.Clear();
                _children.Add(new ListItemContainer<TaskListItem>());
                _rootContainer.Panel2.Controls.Add(_children.Last());
                _children.Last().Dock = DockStyle.Top;
                _children.Last().Update();
                _children.Last().Setup(fItemEntity);
                _rootContainer.Panel2.Controls[0].Size = new Size(Size.Width, fItemEntity.item.Size.Height);
                _rootContainer.Panel2.Controls[0].Update();
            }
            else
            {
                _children.Last().SetNext(fItemEntity);
                _children.Add(_children.Last().next);
                _rootContainer.Panel2.Controls[0].Size = new Size(Size.Width, _rootContainer.Panel2.Controls[0].Size.Height + fItemEntity.item.Size.Height);
                _rootContainer.Panel2.Controls[0].Update();
            }
			
            fItemEntity.item.Setup((pEntity != null)? pEntity : new TaskListItem.Entity { id = _children.Count - 1 });
        }

        /// <summary>
        /// 指定したIndexの作業工程を削除する関数
        /// </summary>
        /// <param name="pIndex">削除するIndex</param>
        public void RemoveProcessItem( int pIndex )
        {
            if ( _children.Count <= 0 || pIndex < 0 || pIndex >= _children.Count ) { return; }

            ListItemContainer<TaskListItem> fJoinItemContainer = (pIndex + 1 < _children.Count)? _children[pIndex + 1] : null;
            Size                            fRemoveItemSize    = _children[pIndex].item.Size;
			
            if ( _children.Count <= 1 ) { ClearProcessItem(); return; }

            //▽ID調整
            if ( pIndex + 1 < _children.Count )
            {
                for( int i = pIndex + 1; i < _children.Count; i++ )
                {
                    _children[i].item.id--;
                }
            }

            //▽削除処理
            if ( pIndex == 0 )
            {
                fJoinItemContainer.Dock = DockStyle.Top;
                fJoinItemContainer.Update();
                _rootContainer.Panel2.Controls.Clear();
                _rootContainer.Panel2.Controls.Add(fJoinItemContainer);
                _children.RemoveAt(pIndex);
            }
            else
            {
                _children[pIndex - 1].SetNext(fJoinItemContainer);
                _children.RemoveAt(pIndex);
                _rootContainer.Panel2.Controls[0].Size = new Size(Size.Width, _rootContainer.Panel2.Controls[0].Size.Height - fRemoveItemSize.Height);
                _rootContainer.Panel2.Controls[0].Update();
            }
        }

        /// <summary>
        /// 作業工程を初期化(クリア)する関数
        /// </summary>
        public void ClearProcessItem()
        {
            _children.Clear();
            _rootContainer.Panel2.Controls.Clear();
        }
    }
}