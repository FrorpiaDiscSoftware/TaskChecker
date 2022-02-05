using System.ComponentModel;

namespace TaskChecker.GuiControl
{
	partial class TaskListView
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) ) {
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components             = new System.ComponentModel.Container();
			this._rootContainer         = new System.Windows.Forms.SplitContainer();
			this.splitContainer1        = new System.Windows.Forms.SplitContainer();
			this._headerStatusContainer = new System.Windows.Forms.SplitContainer();
			this._statusButton          = new System.Windows.Forms.Button();
			this._taskStateMenu         = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._taskTitleContainer    = new System.Windows.Forms.SplitContainer();
			this._taskTitle             = new System.Windows.Forms.Label();
			this._taskTitleInputBox     = new System.Windows.Forms.TextBox();
			this._processListView       = new TaskChecker.GuiControl.ProcessListView();
			((System.ComponentModel.ISupportInitialize)(this._rootContainer)).BeginInit();
			this._rootContainer.Panel1.SuspendLayout();
			this._rootContainer.Panel2.SuspendLayout();
			this._rootContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._headerStatusContainer)).BeginInit();
			this._headerStatusContainer.Panel1.SuspendLayout();
			this._headerStatusContainer.Panel2.SuspendLayout();
			this._headerStatusContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._taskTitleContainer)).BeginInit();
			this._taskTitleContainer.Panel1.SuspendLayout();
			this._taskTitleContainer.Panel2.SuspendLayout();
			this._taskTitleContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// _rootContainer
			// 
			this._rootContainer.Dock        = System.Windows.Forms.DockStyle.Fill;
			this._rootContainer.Location    = new System.Drawing.Point(0, 0);
			this._rootContainer.Name        = "_rootContainer";
			this._rootContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// _rootContainer.Panel1
			// 
			this._rootContainer.Panel1.Controls.Add(this.splitContainer1);
			// 
			// _rootContainer.Panel2
			// 
			this._rootContainer.Panel2.Controls.Add(this._processListView);
			this._rootContainer.Size             = new System.Drawing.Size(500, 450);
			this._rootContainer.SplitterDistance = 233;
			this._rootContainer.TabIndex         = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock            = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel      = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location        = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin          = new System.Windows.Forms.Padding(0);
			this.splitContainer1.Name            = "splitContainer1";
			this.splitContainer1.Orientation     = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this._headerStatusContainer);
			this.splitContainer1.Size             = new System.Drawing.Size(500, 233);
			this.splitContainer1.SplitterDistance = 25;
			this.splitContainer1.TabIndex         = 0;
			// 
			// _headerStatusContainer
			// 
			this._headerStatusContainer.Dock            = System.Windows.Forms.DockStyle.Fill;
			this._headerStatusContainer.FixedPanel      = System.Windows.Forms.FixedPanel.Panel1;
			this._headerStatusContainer.IsSplitterFixed = true;
			this._headerStatusContainer.Location        = new System.Drawing.Point(0, 0);
			this._headerStatusContainer.Name            = "_headerStatusContainer";
			// 
			// _headerStatusContainer.Panel1
			// 
			this._headerStatusContainer.Panel1.Controls.Add(this._statusButton);
			// 
			// _headerStatusContainer.Panel2
			// 
			this._headerStatusContainer.Panel2.Controls.Add(this._taskTitleContainer);
			this._headerStatusContainer.Size             = new System.Drawing.Size(500, 25);
			this._headerStatusContainer.SplitterDistance = 25;
			this._headerStatusContainer.TabIndex         = 0;
			// 
			// _statusButton
			// 
			this._statusButton.BackgroundImage         =  global::TaskChecker.Properties.Resources.taskNotWorking;
			this._statusButton.BackgroundImageLayout   =  System.Windows.Forms.ImageLayout.Stretch;
			this._statusButton.ContextMenuStrip        =  this._taskStateMenu;
			this._statusButton.Dock                    =  System.Windows.Forms.DockStyle.Fill;
			this._statusButton.FlatStyle               =  System.Windows.Forms.FlatStyle.Popup;
			this._statusButton.Location                =  new System.Drawing.Point(0, 0);
			this._statusButton.Name                    =  "_statusButton";
			this._statusButton.Size                    =  new System.Drawing.Size(25, 25);
			this._statusButton.TabIndex                =  0;
			this._statusButton.UseVisualStyleBackColor =  true;
			this._statusButton.Click                   += new System.EventHandler(this._statusButton_Click);
			// 
			// _taskStateMenu
			// 
			this._taskStateMenu.Name = "contextMenuStrip1";
			this._taskStateMenu.Size = new System.Drawing.Size(61, 4);
			// 
			// _taskTitleContainer
			// 
			this._taskTitleContainer.Dock            = System.Windows.Forms.DockStyle.Fill;
			this._taskTitleContainer.IsSplitterFixed = true;
			this._taskTitleContainer.Location        = new System.Drawing.Point(0, 0);
			this._taskTitleContainer.Margin          = new System.Windows.Forms.Padding(0);
			this._taskTitleContainer.Name            = "_taskTitleContainer";
			// 
			// _taskTitleContainer.Panel1
			// 
			this._taskTitleContainer.Panel1.Controls.Add(this._taskTitle);
			// 
			// _taskTitleContainer.Panel2
			// 
			this._taskTitleContainer.Panel2.Controls.Add(this._taskTitleInputBox);
			this._taskTitleContainer.Panel2.Padding   = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._taskTitleContainer.Size             = new System.Drawing.Size(471, 25);
			this._taskTitleContainer.SplitterDistance = 235;
			this._taskTitleContainer.TabIndex         = 0;
			// 
			// _taskTitle
			// 
			this._taskTitle.Dock        =  System.Windows.Forms.DockStyle.Fill;
			this._taskTitle.Font        =  new System.Drawing.Font("ＭＳ ゴシック", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this._taskTitle.Location    =  new System.Drawing.Point(0, 0);
			this._taskTitle.Name        =  "_taskTitle";
			this._taskTitle.Size        =  new System.Drawing.Size(235, 25);
			this._taskTitle.TabIndex    =  4;
			this._taskTitle.Text        =  "TitleText";
			this._taskTitle.TextAlign   =  System.Drawing.ContentAlignment.MiddleLeft;
			this._taskTitle.DoubleClick += new System.EventHandler(this._taskTitle_DoubleClick);
			// 
			// _taskTitleInputBox
			// 
			this._taskTitleInputBox.Dock           =  System.Windows.Forms.DockStyle.Fill;
			this._taskTitleInputBox.Location       =  new System.Drawing.Point(0, 3);
			this._taskTitleInputBox.Name           =  "_taskTitleInputBox";
			this._taskTitleInputBox.Size           =  new System.Drawing.Size(232, 19);
			this._taskTitleInputBox.TabIndex       =  1;
			this._taskTitleInputBox.Text           =  "TitleText";
			this._taskTitleInputBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this._taskTitleInputBox_PreviewKeyDown);
			// 
			// _processListView
			// 
			this._processListView.Dock     = System.Windows.Forms.DockStyle.Fill;
			this._processListView.Location = new System.Drawing.Point(0, 0);
			this._processListView.Name     = "_processListView";
			this._processListView.Size     = new System.Drawing.Size(500, 213);
			this._processListView.TabIndex = 0;
			// 
			// TaskListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._rootContainer);
			this.Name = "TaskListView";
			this.Size = new System.Drawing.Size(500, 450);
			this._rootContainer.Panel1.ResumeLayout(false);
			this._rootContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._rootContainer)).EndInit();
			this._rootContainer.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this._headerStatusContainer.Panel1.ResumeLayout(false);
			this._headerStatusContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._headerStatusContainer)).EndInit();
			this._headerStatusContainer.ResumeLayout(false);
			this._taskTitleContainer.Panel1.ResumeLayout(false);
			this._taskTitleContainer.Panel2.ResumeLayout(false);
			this._taskTitleContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._taskTitleContainer)).EndInit();
			this._taskTitleContainer.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.ContextMenuStrip _taskStateMenu;

		private TaskChecker.GuiControl.ProcessListView _processListView;

		private System.Windows.Forms.TextBox _taskTitleInputBox;

		private System.Windows.Forms.Label _taskTitle;

		private System.Windows.Forms.SplitContainer _taskTitleContainer;

		private System.Windows.Forms.Button _statusButton;

		private System.Windows.Forms.SplitContainer _headerStatusContainer;

		private System.Windows.Forms.SplitContainer splitContainer1;

		private System.Windows.Forms.SplitContainer _rootContainer;

		#endregion
	}
}