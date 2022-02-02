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
			if ( _children.Count <= 0 ) { return; }
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
				id                         = _children.Count,
				isEnableMemoArea           = false,
				isExpanded                 = false,
				processState               = TaskState.NOT_WORKING,
				onClickRemoveProcessButton = value => { RemoveProcessItem(value.id); },
				onClickSelected            = value => { SetChildSelected(value.id,true); },
				onResizeRequest = ( pItem, pSize ) =>
				{
					if ( pItem._id - 1 >= 0 ) { _children[pItem._id - 1].containerFixedPanel = FixedPanel.Panel1; }
					_children[pItem._id].containerFixedPanel = FixedPanel.Panel2;
					ReSize(new Size(Size.Width, Size.Height + (pSize.Height - pItem.Size.Height)));
					_children[pItem._id].containerFixedPanel = FixedPanel.None;
					if ( pItem._id - 1 >= 0 ) { _children[pItem._id - 1].containerFixedPanel = FixedPanel.None; }
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