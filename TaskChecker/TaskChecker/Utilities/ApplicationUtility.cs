using System;
using System.Drawing;
using TaskChecker.Properties;

namespace TaskChecker
{
	public static partial class ApplicationUtility
	{
		/// <summary>
		/// タスクの進行状態に対応するアイコン画像を返す関数
		/// </summary>
		/// <param name="pState">タスクの状態</param>
		/// <returns>タスクの進行状態に対応するアイコン画像</returns>
		public static Bitmap ToTaskStateIcon( this TaskState pState )
		{
			switch( pState ) {
				case TaskState.WORKING:
					return Resources.taskWorking;
				case TaskState.WAIT:
					return Resources.taskWait;
				case TaskState.CANNOT_PROCEED:
					return Resources.taskCannotProceed;
				case TaskState.COMPLETED:
					return Resources.taskCompleted;
				default:
					return Resources.taskNotWorking;
			}
		}
		
		/// <summary>
		/// タスクの進行状態に対応するメニュー項目-英名を返す関数
		/// </summary>
		/// <param name="pState">タスクの状態</param>
		/// <returns>タスクの進行状態に対応する英名</returns>
		public static string ToMenuItemName( this TaskState pState )
		{
			switch( pState ) {
				case TaskState.WORKING:
					return "Working";
				case TaskState.WAIT:
					return "Wait";
				case TaskState.CANNOT_PROCEED:
					return "CannotProceed";
				case TaskState.COMPLETED:
					return "Completed";
				default:
					return "NotWorking";
			}
		}
		
		/// <summary>
		/// タスクの進行状態に対応するメニュー項目テキストを返す関数
		/// </summary>
		/// <param name="pState">タスクの状態</param>
		/// <returns>タスクの進行状態に対応するメニュー項目テキスト(日本名)</returns>
		public static string ToMenuItemText( this TaskState pState )
		{
			switch( pState ) {
				case TaskState.WORKING:
					return "作業中";
				case TaskState.WAIT:
					return "待機中";
				case TaskState.CANNOT_PROCEED:
					return "進行不可";
				case TaskState.COMPLETED:
					return "完了";
				default:
					return "未着手";
			}
		}

		/// <summary>
		/// タスクの次の状態を返す関数
		/// </summary>
		/// <param name="pState"   >タスクの状態</param>
		/// <param name="pIsRepeat">「完了」まで行ったら「未着手」に戻すかどうか(trueで戻す)</param>
		/// <returns>次の状態</returns>
		public static TaskState NextState( this TaskState pState , bool pIsRepeat = false )
		{
			switch( pState ) {
				case TaskState.WORKING:
					return TaskState.COMPLETED;
				case TaskState.WAIT:
					return TaskState.WORKING;
				case TaskState.CANNOT_PROCEED:
					return TaskState.WAIT;
				case TaskState.COMPLETED:
					return (!pIsRepeat)? TaskState.COMPLETED : TaskState.NOT_WORKING;
				default:
					return TaskState.WORKING;
			}
		}
	}
}