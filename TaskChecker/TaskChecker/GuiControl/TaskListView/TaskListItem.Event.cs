using System;
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
			int fAddItemIdx = _children.Count;//TODO:ListItem内にちゃんとIndex入れて、Remove時に管理する必要あり。
			
			AddProcessItem(new Entity {
				isEnableMemoArea           = false,
				isExpanded                 = false,
				processState               = TaskState.NOT_WORKING,
				onClickRemoveProcessButton = value => { RemoveProcessItem(fAddItemIdx); },
				onClickSelected            = value =>
				{
					if ( _isPressControlKey ) { return; }

					if ( _isPressShiftKey )
					{
						//↓Shiftキーを押しながらだった場合(前回選択した物から今回選択した物までを選択する)
						if ( (fAddItemIdx - 1) < 0 ) { return; }
						//-------------------------------------------------------------
						for( int i = fAddItemIdx - 1; i >= 0; i-- )
						{
							if ( _children[i].item.isSelected ) { break; }
							_children[i].item.SetSelected(true);
						}
					}
					else
					{
						//↓Shiftキーが押されていない場合(単体選択動作)
						for( int i = 0; i < _children.Count; i++ )
						{
							if ( i == fAddItemIdx ) { continue; }
							_children[i].item.SetSelected(false);
						}
					}
				},
			});
		}

		/// <summary>
		/// 作業工程-削除ボタンのクリックイベント
		/// </summary>
		private void _removeProcessButton_Click( object pSender , EventArgs pEventArgs )
		{
			onClickRemoveProcessButton?.Invoke(this);
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