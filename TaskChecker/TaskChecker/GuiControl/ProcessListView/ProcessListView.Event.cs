using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskChecker.GuiControl
{
    public partial class ProcessListView
    {
        /// <summary>
        /// ツールバー-作業工程追加ボタンのクリックイベント
        /// </summary>
        private void _addToolButton_Click( object pSender, EventArgs pEventArgs )
        {
            AddProcessItem(new TaskListItem.Entity {
                id               = _children.Count,
                isEnableMemoArea = false,
                isExpanded       = false,
                processState     = TaskState.NOT_WORKING,
                onClickSelected  = value => { SetChildSelected(value.id, true); },
                onResizeRequest  = ( pItem, pSize ) =>
                {
                    if ( pItem.id - 1 >= 0 ) { _children[pItem.id - 1].containerFixedPanel = FixedPanel.Panel1; }
                    _children[pItem.id].containerFixedPanel = FixedPanel.Panel2;
                    _rootContainer.Panel2.Controls[0].Size = new Size(Size.Width, _rootContainer.Panel2.Controls[0].Size.Height + (pSize.Height - pItem.Size.Height));
                    _rootContainer.Panel2.Controls[0].Update();
                    _children[pItem.id].containerFixedPanel = FixedPanel.None;
                    if ( pItem.id - 1 >= 0 ) { _children[pItem.id - 1].containerFixedPanel = FixedPanel.None; }
                },
            });
        }

        /// <summary>
        /// ツールバー-作業工程削除ボタンのクリックイベント
        /// </summary>
        private void _removeToolButton_Click( object pSender, EventArgs pEventArgs )
        {
            if ( _selections.Count <= 0 ) { return; }
			
            DialogResult fResult = MessageBox.Show("選択された作業工程を削除します。\nよろしいですか？", "削除確認", MessageBoxButtons.YesNo);
			
            if ( fResult != DialogResult.Yes ) { return; }
            RemoveSelectedProcessItems();
        }
    }
}