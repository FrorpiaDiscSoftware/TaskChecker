using System;
using System.Windows.Forms;

namespace TaskChecker.GuiControl
{
    public partial class TaskListView
    {
        /// <summary>
        /// 作業工程-進行状態ボタンのクリックイベント
        /// </summary>
        private void _statusButton_Click( object pSender, EventArgs pEventArgs )
        {
            SetTaskState(_taskState.NextState());
        }
    }
}