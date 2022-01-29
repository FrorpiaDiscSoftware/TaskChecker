using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TaskChecker.GuiControl
{
    public partial class ProcessListView : UserControl
    {
        private const int TITLE_HEIGHT = 25;//作業工程タイトルの高さ
        //-----------------------------------------------------------------------------
        private int                                   _id       = 0;                                          //このコントロールのID(Indexに使用)
        private List<ListItemContainer<TaskListItem>> _children = new List<ListItemContainer<TaskListItem>>();//子の作業工程リスト
        //-----------------------------------------------------------------------------
        public int                          id              { get => _id; }//このコントロールのID(Indexに使用)
        public Action<ProcessListView,Size> onResizeRequest { get; set; } = null;//リサイズ発生とリクエストイベント※親はこのイベントに応じて自身のサイズを変える必要あり。
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
            /// リサイズ発生とリクエストイベント<br />
            /// ※親はこのイベントに応じて自身のサイズを変える必要あり。
            /// </summary>
            public Action<ProcessListView,Size> onResizeRequest = null;
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
            
            onResizeRequest = pEntity.onResizeRequest;
            
            _id = pEntity.id;
        }
		
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
            if ( Dock != DockStyle.Fill ) { Size = pSize; } else { onResizeRequest.Invoke(this, pSize); }
            Update();
        }
    }
}