using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskChecker.GuiControl
{
	public partial class TaskListView : UserControl
	{
		private TaskState                               _taskState          = TaskState.NOT_WORKING;                        //タスクの進行状態
		private Dictionary<TaskState,ToolStripMenuItem> _taskStateMenuItems = new Dictionary<TaskState,ToolStripMenuItem>();//タスクの進行状態設定メニュー項目リスト
		//-----------------------------------------------------------------------------
		public TaskState taskState { get => _taskState; set => SetTaskState(value); }//タスクの進行状態


		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓追加定義クラス関連

		/// <summary>
		/// 表示内容の一括設定データクラス
		/// </summary>
		public class Entity
		{
			/// <summary>
			/// タスクの進行状態
			/// </summary>
			public TaskState taskState = TaskState.NOT_WORKING;
		}


		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓システム関連

		/// <summary>
		/// コンストラクタ(引数なし)
		/// </summary>
		public TaskListView()
		{
			InitializeComponent();
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="pEntity">初期設定</param>
		public TaskListView( Entity pEntity )
		{
			InitializeComponent();
			Setup(pEntity);
		}


		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓基本機能関連

		/// <summary>
		/// 表示内容の一括セットアップを行なう関数
		/// </summary>
		/// <param name="pEntity">全表示内容の設定</param>
		public void Setup( Entity pEntity )
		{
			if ( pEntity == null ) { return; }
			
			SetupTaskStateMenu();
			
			SetTaskState(pEntity.taskState);
		}

		/// <summary>
		/// タスクの進行状態設定メニューをセットアップする関数
		/// </summary>
		/// <param name="pReSetup">再セットアップを行なうかどうか(trueで行なう)</param>
		private void SetupTaskStateMenu( bool pReSetup = false )
		{
			if ( !pReSetup && _taskStateMenuItems.Count > 0 ) { return; }
			
			_taskStateMenuItems.Clear();
			_taskStateMenu.Items.Clear();
			
			foreach( TaskState value in Enum.GetValues(typeof(TaskState)) ) {
				_taskStateMenuItems.Add(value, new ToolStripMenuItem{ Name = value.ToMenuItemName() , Text = value.ToMenuItemText() });
				_taskStateMenuItems[value].Click += ( pSender , pArgs ) => { SetTaskState(value); };
				_taskStateMenu.Items.Add(_taskStateMenuItems[value]);
			}
		}
		
		
		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓アクセサ関連

		/// <summary>
		/// タスクの進行状態を設定する関数
		/// </summary>
		/// <param name="pState">タスクの状態を表す定数値</param>
		private void SetTaskState( TaskState pState )
		{
			_statusButton.BackgroundImage = pState.ToTaskStateIcon();
			
			SetupTaskStateMenu();
			
			_taskStateMenuItems[_taskState].Checked = false;
			_taskStateMenuItems[pState    ].Checked = true;
			
			_taskState = pState;
		}
	}
}