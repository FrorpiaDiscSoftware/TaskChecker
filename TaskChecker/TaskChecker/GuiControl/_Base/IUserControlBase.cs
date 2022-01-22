using System;
using System.Windows.Forms;

namespace TaskChecker.GuiControl
{
    public interface IUserControlBase
    {
        int         id          { get; }//このコントロールのID
        UserControl thisControl { get; }//本クラスの基本コントロールインスタンス
        //-----------------------------------------------------------------------------
    }
}