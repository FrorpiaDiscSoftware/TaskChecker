using System;
using System.Diagnostics;
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
                id               = _processListLayoutPanel.childrenCount,
                isEnableMemoArea = false,
                isExpanded       = false,
                processState     = TaskState.NOT_WORKING,
                onClickSelected  = value => { SetChildSelected(value.id, true); },
                onResizeRequest  = ( pItem, pSize ) =>
                {
                    if ( pItem.id >= _processListLayoutPanel.childrenCount ) { pItem.Size = pSize; return; }
                    
                    Size fNewLayoutPanelSize = _processListLayoutPanel.layoutPanelSize;//新たに設定するLayoutPanelのサイズ

                    fNewLayoutPanelSize.Height -= pItem.Size.Height;
                    fNewLayoutPanelSize.Height += pSize.Height;
                    
                    _processListLayoutPanel.layoutPanelLineStyles[pItem.id].Height = pSize.Height;
                    _processListLayoutPanel.layoutPanelSize = fNewLayoutPanelSize;
                    
                    pItem.Size = pSize;
                },
            });
        }

        /// <summary>
        /// ツールバー-作業工程削除ボタンのクリックイベント
        /// </summary>
        private void _removeToolButton_Click( object pSender, EventArgs pEventArgs )
        {
            if ( _processListLayoutPanel.selectionCount <= 0 ) { return; }
			
            DialogResult fResult = MessageBox.Show("選択された作業工程を削除します。\nよろしいですか？", "削除確認", MessageBoxButtons.YesNo);
			
            if ( fResult != DialogResult.Yes ) { return; }
            RemoveSelectedProcessItems();
        }
    }
}