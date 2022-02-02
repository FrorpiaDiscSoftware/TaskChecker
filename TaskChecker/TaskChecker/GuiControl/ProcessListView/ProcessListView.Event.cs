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
                onClickSelected  = value =>
                {
                    if ( _isPressControlKey ) { return; }

                    if ( _isPressShiftKey )
                    {
                        //↓Shiftキーを押しながらだった場合(前回選択した物から今回選択した物までを選択する)
                        if ( value.id - 1 < 0 ) { return; }
                        //-------------------------------------------------------------
                        for( int i = value.id - 1; i >= 0; i-- )
                        {
                            if ( _children[i].item.isSelected ) { break; }
                            _children[i].item.isSelected = true;
                        }
                    }
                    else
                    {
                        //↓Shiftキーが押されていない場合(単体選択動作)
                        for( int i = 0; i < _children.Count; i++ )
                        {
                            if ( i == value.id ) { continue; }
                            _children[i].item.isSelected = false;
                        }
                    }
                },
                onResizeRequest = ( pItem, pSize ) =>
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
            bool fIsRemoveChk = false;//削除確認をしたかどうか
            
            foreach( var value in _children )
            {
                if ( !value.item.isSelected ) { continue; }

                if ( !fIsRemoveChk )
                {
                    DialogResult fResult = MessageBox.Show("選択された作業工程を削除します。\nよろしいですか？", "削除確認", MessageBoxButtons.YesNo);
                    if ( fResult != DialogResult.Yes ) { break; }
                    fIsRemoveChk = true;
                }
                
                //TODO:多分、これだと処理位置ずれるから、一旦、削除リスト作らないとダメだけど、
                //TODO:TaskListItemの削除ボタンの仕様調整する＋こっちも同様の仕様にするので、一旦、この状態で保留。
                RemoveProcessItem(value.item.id);
            }
        }
    }
}