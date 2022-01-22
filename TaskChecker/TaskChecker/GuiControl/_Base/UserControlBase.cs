using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TaskChecker.GuiControl
{
    public abstract class UserControlBase<EntityT> : UserControl , IUserControlBase
        where EntityT : UserControlBase<EntityT>.EntityBase
    {
        protected int _id = 0;//このコントロールのID
        //-----------------------------------------------------------------------------
        [Browsable(true),Description("このコントロールのID")]
        public int         id          { get => _id;  }
        public UserControl thisControl { get => this; }//本クラスの基本コントロールインスタンス
        //-----------------------------------------------------------------------------
        
        
        //～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
        //↓追加定義クラス関連
        
        /// <summary>
        /// 表示内容の一括設定データ基本クラス
        /// </summary>
        public class EntityBase
        {
            /// <summary>
            /// このコントロールのID(必要に応じて設定)
            /// </summary>
            public int id = 0;
        }
		
		
        //～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
        //↓基本機能関連
		
        /// <summary>
        /// 表示内容の一括セットアップを行なう関数
        /// </summary>
        /// <param name="pEntity">全表示内容の設定</param>
        public void Setup( EntityT pEntity )
        {
            if ( pEntity == null ) { return; }

            _id = pEntity.id;
            
            OnSetup(pEntity);
        }
		
		
        //～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
        //↓派生先イベント関連
		
        /// <summary>
        /// 表示内容の一括セットアップ時イベント関数(派生先呼び出し用)
        /// </summary>
        /// <param name="pEntity">全表示内容の設定</param>
        protected abstract void OnSetup( EntityT pEntity );
    }
}