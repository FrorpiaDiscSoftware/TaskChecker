using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskChecker.GuiControl
{
	public partial class TaskListItem
	{
		/// <summary>
		/// 展開ボタンのクリックイベント
		/// </summary>
		private void _expandButton_Click( object pSender , EventArgs pEventArgs )
		{
			if ( _processListLayoutPanel.childrenCount <= 0 ) { return; }
			SetExpanded(!isExpanded);
		}
		
		/// <summary>
		/// 作業工程-進行状態ボタンのクリックイベント
		/// </summary>
		private void _statusButton_Click( object pSender , EventArgs pEventArgs )
		{
			SetProcessState(_processState.NextState());
		}
		
		/// <summary>
		/// 作業工程-タイトルテキストのクリックイベント
		/// </summary>
		private void _processTitle_Click( object pSender, EventArgs pEventArgs )
		{
			SetSelected(true);
			onClickSelected?.Invoke(this);
		}
		
		/// <summary>
		/// 作業工程-タイトルテキストのダブルクリックイベント
		/// </summary>
		private void _processTitle_DoubleClick( object pSender, EventArgs pEventArgs )
		{
			SetProcessTitleEditMode(true);
		}
		
		/// <summary>
		/// 作業工程-タイトル入力ボックスにフォーカスがある時のキー押下イベント
		/// </summary>
		private void _processTitleInputBox_PreviewKeyDown( object pSender, PreviewKeyDownEventArgs pEventArgs )
		{
			if ( (pEventArgs.KeyData & Keys.Enter) == 0 ) { return; }
			SetProcessTitle(_processTitleInputBox.Text);
			SetProcessTitleEditMode(false);
			_processTitle.Focus();
		}
		
		/// <summary>
		/// 作業工程-追加ボタンのクリックイベント
		/// </summary>
		private void _addProcessButton_Click( object pSender, EventArgs pEventArgs )
		{
			AddProcessItem(new Entity {
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
					_processListLayoutPanel.layoutPanelSize                        = fNewLayoutPanelSize;
                    
					pItem.Size = pSize;
					
					ReSize(new Size( Size.Width , Size.Height + (_processListLayoutPanel.layoutPanelSize.Height - _processListLayoutPanel.Size.Height) ));
				},
			});
		}

		/// <summary>
		/// 作業工程-削除ボタンのクリックイベント
		/// </summary>
		private void _removeProcessButton_Click( object pSender , EventArgs pEventArgs )
		{
			if ( _processListLayoutPanel.selectionCount <= 0 ) { return; }
			
			DialogResult fResult = MessageBox.Show("選択された作業工程を削除します。\nよろしいですか？", "削除確認", MessageBoxButtons.YesNo);
			
			if ( fResult != DialogResult.Yes ) { return; }
			RemoveSelectedProcessItems();
		}
		
		/// <summary>
		/// メモ書き表示/非表示ボタンのクリックイベント
		/// </summary>
		private void _memoButton_Click( object pSender , EventArgs pEventArgs )
		{
			SetEnableMemoArea(!isEnableMemoArea);
		}
	}
}