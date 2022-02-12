using System;
using System.Windows.Forms;

namespace TaskChecker.GuiControl
{
    public partial class TaskListView
    {
        /// <summary>
        /// タスク-進行状態ボタンのクリックイベント
        /// </summary>
        private void _statusButton_Click( object pSender, EventArgs pEventArgs )
        {
            SetTaskState(_taskState.NextState());
        }

        /// <summary>
        /// タスク-タイトルテキストのダブルクリックイベント
        /// </summary>
        private void _taskTitle_DoubleClick( object pSender, EventArgs pEventArgs )
        {
            SetTaskTitleEditMode(true);
        }

        /// <summary>
        /// タスク-タイトル入力ボックスにフォーカスがある時のキー押下イベント
        /// </summary>
        private void _taskTitleInputBox_PreviewKeyDown( object pSender, PreviewKeyDownEventArgs pEventArgs )
        {
            if ( (pEventArgs.KeyData & Keys.Enter) == 0 ) { return; }
            SetTaskTitle(_taskTitleInputBox.Text);
            SetTaskTitleEditMode(false);
            _taskTitle.Focus();
        }
    }
}