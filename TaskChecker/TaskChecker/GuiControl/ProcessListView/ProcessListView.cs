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
        private int _id = 0;//このコントロールのID(Indexに使用)
        //-----------------------------------------------------------------------------
        public bool isPressControlKey { get => _processListLayoutPanel.isPressControlKey; }//Controlキーが押されているかどうか(trueで押されている)
        public bool isPressShiftKey   { get => _processListLayoutPanel.isPressShiftKey; }//Shiftキーが押されているかどうか(trueで押されている)
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
            
            _processListLayoutPanel.Setup(new ProcessListLayoutPanel.Entity {
	            id       = 0,//このコントロールでは1個だけ配置なのでIDは固定。
	            children = pEntity.children,
            });
        }

        /// <summary>
        /// 作業工程を追加する関数
        /// </summary>
        /// <param name="pEntity">作業工程の初期設定</param>
        public void AddProcessItem( TaskListItem.Entity pEntity = null ) => _processListLayoutPanel.AddProcessItem(pEntity);

        /// <summary>
        /// 指定したIndexの作業工程を削除する関数
        /// </summary>
        /// <param name="pIndex">削除するIndex</param>
        public void RemoveProcessItem( int pIndex ) => _processListLayoutPanel.RemoveProcessItem(pIndex);

        /// <summary>
        /// 選択している作業工程を削除する関数
        /// </summary>
        public void RemoveSelectedProcessItems() => _processListLayoutPanel.RemoveSelectedProcessItems();

        /// <summary>
        /// 作業工程を初期化(クリア)する関数
        /// </summary>
        public void ClearProcessItem() => _processListLayoutPanel.ClearProcessItem();

        /// <summary>
        /// 子の作業工程の選択状態を初期化(クリア)する関数
        /// </summary>
        public void ClearChildSelections() => _processListLayoutPanel.ClearChildSelections();
		
		
        //～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
        //↓アクセサ関連

        /// <summary>
        /// 子の作業工程の選択状態を設定する関数
        /// </summary>
        /// <param name="pIndex"      >設定対象のリストIndex</param>
        /// <param name="pIsSelected" >選択状態(trueで選択中)</param>
        /// <param name="pIsIgnoreKey">キー入力を無視するかどうか(trueで無視)</param>
        public void SetChildSelected( int pIndex, bool pIsSelected, bool pIsIgnoreKey = false ) =>
	        _processListLayoutPanel.SetChildSelected(pIndex, pIsSelected, pIsIgnoreKey);
    }
}