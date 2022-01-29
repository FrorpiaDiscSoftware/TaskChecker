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
			this._rootContainer           = new System.Windows.Forms.SplitContainer();
			this.splitContainer1          = new System.Windows.Forms.SplitContainer();
			this._headerStatusContainer   = new System.Windows.Forms.SplitContainer();
			this._statusButton            = new System.Windows.Forms.Button();
			this._taskTitleContainer      = new System.Windows.Forms.SplitContainer();
			this._taskTitle               = new System.Windows.Forms.Label();
			this._taskTitleInputBox       = new System.Windows.Forms.TextBox();
			this._processContainer        = new System.Windows.Forms.SplitContainer();
			this._processToolBar          = new System.Windows.Forms.ToolStrip();
			this._addProcessToolButton    = new System.Windows.Forms.ToolStripButton();
			this._removeProcessToolButton = new System.Windows.Forms.ToolStripButton();
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
			((System.ComponentModel.ISupportInitialize)(this._processContainer)).BeginInit();
			this._processContainer.Panel1.SuspendLayout();
			this._processContainer.SuspendLayout();
			this._processToolBar.SuspendLayout();
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
			this._rootContainer.Panel2.AutoScroll = true;
			this._rootContainer.Panel2.Controls.Add(this._processContainer);
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
			this._statusButton.BackgroundImage         = global::TaskChecker.Properties.Resources.taskNotWorking;
			this._statusButton.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
			this._statusButton.Dock                    = System.Windows.Forms.DockStyle.Fill;
			this._statusButton.FlatStyle               = System.Windows.Forms.FlatStyle.Popup;
			this._statusButton.Location                = new System.Drawing.Point(0, 0);
			this._statusButton.Name                    = "_statusButton";
			this._statusButton.Size                    = new System.Drawing.Size(25, 25);
			this._statusButton.TabIndex                = 0;
			this._statusButton.UseVisualStyleBackColor = true;
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
			this._taskTitle.Dock      = System.Windows.Forms.DockStyle.Fill;
			this._taskTitle.Font      = new System.Drawing.Font("ＭＳ ゴシック", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this._taskTitle.Location  = new System.Drawing.Point(0, 0);
			this._taskTitle.Name      = "_taskTitle";
			this._taskTitle.Size      = new System.Drawing.Size(235, 25);
			this._taskTitle.TabIndex  = 4;
			this._taskTitle.Text      = "TitleText";
			this._taskTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _taskTitleInputBox
			// 
			this._taskTitleInputBox.Dock     = System.Windows.Forms.DockStyle.Fill;
			this._taskTitleInputBox.Location = new System.Drawing.Point(0, 3);
			this._taskTitleInputBox.Name     = "_taskTitleInputBox";
			this._taskTitleInputBox.Size     = new System.Drawing.Size(232, 19);
			this._taskTitleInputBox.TabIndex = 1;
			this._taskTitleInputBox.Text     = "TitleText";
			// 
			// _processContainer
			// 
			this._processContainer.Dock            = System.Windows.Forms.DockStyle.Fill;
			this._processContainer.FixedPanel      = System.Windows.Forms.FixedPanel.Panel1;
			this._processContainer.IsSplitterFixed = true;
			this._processContainer.Location        = new System.Drawing.Point(0, 0);
			this._processContainer.Margin          = new System.Windows.Forms.Padding(0);
			this._processContainer.Name            = "_processContainer";
			this._processContainer.Orientation     = System.Windows.Forms.Orientation.Horizontal;
			// 
			// _processContainer.Panel1
			// 
			this._processContainer.Panel1.Controls.Add(this._processToolBar);
			// 
			// _processContainer.Panel2
			// 
			this._processContainer.Panel2.Padding   = new System.Windows.Forms.Padding(25, 0, 0, 0);
			this._processContainer.Size             = new System.Drawing.Size(500, 213);
			this._processContainer.SplitterDistance = 25;
			this._processContainer.TabIndex         = 0;
			// 
			// _processToolBar
			// 
			this._processToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this._addProcessToolButton, this._removeProcessToolButton });
			this._processToolBar.Location = new System.Drawing.Point(0, 0);
			this._processToolBar.Name     = "_processToolBar";
			this._processToolBar.Size     = new System.Drawing.Size(500, 25);
			this._processToolBar.TabIndex = 0;
			this._processToolBar.Text     = "toolStrip1";
			// 
			// _addProcessToolButton
			// 
			this._addProcessToolButton.DisplayStyle          = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._addProcessToolButton.Image                 = global::TaskChecker.Properties.Resources.add;
			this._addProcessToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._addProcessToolButton.Name                  = "_addProcessToolButton";
			this._addProcessToolButton.Size                  = new System.Drawing.Size(23, 22);
			this._addProcessToolButton.Text                  = "toolStripButton1";
			// 
			// _removeProcessToolButton
			// 
			this._removeProcessToolButton.DisplayStyle          = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._removeProcessToolButton.Image                 = global::TaskChecker.Properties.Resources.remove;
			this._removeProcessToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._removeProcessToolButton.Name                  = "_removeProcessToolButton";
			this._removeProcessToolButton.Size                  = new System.Drawing.Size(23, 22);
			this._removeProcessToolButton.Text                  = "toolStripButton2";
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
			this._processContainer.Panel1.ResumeLayout(false);
			this._processContainer.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._processContainer)).EndInit();
			this._processContainer.ResumeLayout(false);
			this._processToolBar.ResumeLayout(false);
			this._processToolBar.PerformLayout();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.ToolStripButton _addProcessToolButton;

		private System.Windows.Forms.ToolStrip _processToolBar;

		private System.Windows.Forms.ToolStripButton _removeProcessToolButton;

		private System.Windows.Forms.SplitContainer _processContainer;

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