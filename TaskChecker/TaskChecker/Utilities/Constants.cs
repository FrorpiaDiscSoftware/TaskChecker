namespace TaskChecker
{
	/// <summary>
	/// タスクの状態を表す定数値
	/// </summary>
	public enum TaskState
	{
		NOT_WORKING,   //未着手
		WORKING,       //作業中
		WAIT,          //待機中
		CANNOT_PROCEED,//進行不可
		COMPLETED,     //完了
	}
}