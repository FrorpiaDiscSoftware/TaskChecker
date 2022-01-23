using System.ComponentModel;

namespace TaskChecker.GuiControl
{
	partial class TaskListItem
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskListItem));
			this._rootContainer          = new System.Windows.Forms.SplitContainer();
			this._headerContainer        = new System.Windows.Forms.SplitContainer();
			this._expandButton           = new System.Windows.Forms.Button();
			this._headerStatusContainer  = new System.Windows.Forms.SplitContainer();
			this._statusButton           = new System.Windows.Forms.Button();
			this._processStateMenu       = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._headerContentContainer = new System.Windows.Forms.SplitContainer();
			this._processTitleContainer  = new System.Windows.Forms.SplitContainer();
			this._processTitle           = new System.Windows.Forms.Label();
			this._processTitleInputBox   = new System.Windows.Forms.TextBox();
			this._addProcessButton       = new System.Windows.Forms.Button();
			this._memoButton             = new System.Windows.Forms.Button();
			this._removeProcessButton    = new System.Windows.Forms.Button();
			this._contentContainer       = new System.Windows.Forms.SplitContainer();
			this._memoTextArea           = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this._rootContainer)).BeginInit();
			this._rootContainer.Panel1.SuspendLayout();
			this._rootContainer.Panel2.SuspendLayout();
			this._rootContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._headerContainer)).BeginInit();
			this._headerContainer.Panel1.SuspendLayout();
			this._headerContainer.Panel2.SuspendLayout();
			this._headerContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._headerStatusContainer)).BeginInit();
			this._headerStatusContainer.Panel1.SuspendLayout();
			this._headerStatusContainer.Panel2.SuspendLayout();
			this._headerStatusContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._headerContentContainer)).BeginInit();
			this._headerContentContainer.Panel1.SuspendLayout();
			this._headerContentContainer.Panel2.SuspendLayout();
			this._headerContentContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._processTitleContainer)).BeginInit();
			this._processTitleContainer.Panel1.SuspendLayout();
			this._processTitleContainer.Panel2.SuspendLayout();
			this._processTitleContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._contentContainer)).BeginInit();
			this._contentContainer.Panel1.SuspendLayout();
			this._contentContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// _rootContainer
			// 
			this._rootContainer.Dock        = System.Windows.Forms.DockStyle.Fill;
			this._rootContainer.FixedPanel  = System.Windows.Forms.FixedPanel.Panel1;
			this._rootContainer.Location    = new System.Drawing.Point(0, 0);
			this._rootContainer.Name        = "_rootContainer";
			this._rootContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// _rootContainer.Panel1
			// 
			this._rootContainer.Panel1.Controls.Add(this._headerContainer);
			this._rootContainer.Panel1MinSize = 20;
			// 
			// _rootContainer.Panel2
			// 
			this._rootContainer.Panel2.Controls.Add(this._contentContainer);
			this._rootContainer.Size             = new System.Drawing.Size(500, 300);
			this._rootContainer.SplitterDistance = 25;
			this._rootContainer.TabIndex         = 0;
			// 
			// _headerContainer
			// 
			this._headerContainer.Dock       = System.Windows.Forms.DockStyle.Fill;
			this._headerContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this._headerContainer.Location   = new System.Drawing.Point(0, 0);
			this._headerContainer.Margin     = new System.Windows.Forms.Padding(0);
			this._headerContainer.Name       = "_headerContainer";
			// 
			// _headerContainer.Panel1
			// 
			this._headerContainer.Panel1.Controls.Add(this._expandButton);
			this._headerContainer.Panel1MinSize = 20;
			// 
			// _headerContainer.Panel2
			// 
			this._headerContainer.Panel2.Controls.Add(this._headerStatusContainer);
			this._headerContainer.Size             = new System.Drawing.Size(500, 25);
			this._headerContainer.SplitterDistance = 25;
			this._headerContainer.TabIndex         = 0;
			// 
			// _expandButton
			// 
			this._expandButton.BackgroundImage         =  global::TaskChecker.Properties.Resources.arrowStateBlueExpanded;
			this._expandButton.BackgroundImageLayout   =  System.Windows.Forms.ImageLayout.Stretch;
			this._expandButton.Cursor                  =  System.Windows.Forms.Cursors.Hand;
			this._expandButton.Dock                    =  System.Windows.Forms.DockStyle.Fill;
			this._expandButton.FlatStyle               =  System.Windows.Forms.FlatStyle.Popup;
			this._expandButton.Location                =  new System.Drawing.Point(0, 0);
			this._expandButton.Name                    =  "_expandButton";
			this._expandButton.Size                    =  new System.Drawing.Size(25, 25);
			this._expandButton.TabIndex                =  0;
			this._expandButton.UseVisualStyleBackColor =  true;
			this._expandButton.Click                   += new System.EventHandler(this._expandButton_Click);
			// 
			// _headerStatusContainer
			// 
			this._headerStatusContainer.Dock       = System.Windows.Forms.DockStyle.Fill;
			this._headerStatusContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this._headerStatusContainer.Location   = new System.Drawing.Point(0, 0);
			this._headerStatusContainer.Margin     = new System.Windows.Forms.Padding(0);
			this._headerStatusContainer.Name       = "_headerStatusContainer";
			// 
			// _headerStatusContainer.Panel1
			// 
			this._headerStatusContainer.Panel1.Controls.Add(this._statusButton);
			this._headerStatusContainer.Panel1MinSize = 10;
			// 
			// _headerStatusContainer.Panel2
			// 
			this._headerStatusContainer.Panel2.Controls.Add(this._headerContentContainer);
			this._headerStatusContainer.Size             = new System.Drawing.Size(471, 25);
			this._headerStatusContainer.SplitterDistance = 25;
			this._headerStatusContainer.TabIndex         = 0;
			// 
			// _statusButton
			// 
			this._statusButton.BackgroundImage         =  global::TaskChecker.Properties.Resources.taskNotWorking;
			this._statusButton.BackgroundImageLayout   =  System.Windows.Forms.ImageLayout.Stretch;
			this._statusButton.ContextMenuStrip        =  this._processStateMenu;
			this._statusButton.Dock                    =  System.Windows.Forms.DockStyle.Fill;
			this._statusButton.FlatStyle               =  System.Windows.Forms.FlatStyle.Popup;
			this._statusButton.Font                    =  new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this._statusButton.Location                =  new System.Drawing.Point(0, 0);
			this._statusButton.Name                    =  "_statusButton";
			this._statusButton.RightToLeft             =  System.Windows.Forms.RightToLeft.Yes;
			this._statusButton.Size                    =  new System.Drawing.Size(25, 25);
			this._statusButton.TabIndex                =  0;
			this._statusButton.UseVisualStyleBackColor =  true;
			this._statusButton.Click                   += new System.EventHandler(this._statusButton_Click);
			// 
			// _processStateMenu
			// 
			this._processStateMenu.Name = "contextMenuStrip1";
			this._processStateMenu.Size = new System.Drawing.Size(61, 4);
			// 
			// _headerContentContainer
			// 
			this._headerContentContainer.Dock       = System.Windows.Forms.DockStyle.Fill;
			this._headerContentContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this._headerContentContainer.Location   = new System.Drawing.Point(0, 0);
			this._headerContentContainer.Margin     = new System.Windows.Forms.Padding(0);
			this._headerContentContainer.Name       = "_headerContentContainer";
			// 
			// _headerContentContainer.Panel1
			// 
			this._headerContentContainer.Panel1.Controls.Add(this._processTitleContainer);
			// 
			// _headerContentContainer.Panel2
			// 
			this._headerContentContainer.Panel2.Controls.Add(this._addProcessButton);
			this._headerContentContainer.Panel2.Controls.Add(this._memoButton);
			this._headerContentContainer.Panel2.Controls.Add(this._removeProcessButton);
			this._headerContentContainer.Panel2.Padding   = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this._headerContentContainer.Size             = new System.Drawing.Size(442, 25);
			this._headerContentContainer.SplitterDistance = 359;
			this._headerContentContainer.TabIndex         = 1;
			// 
			// _processTitleContainer
			// 
			this._processTitleContainer.Dock            = System.Windows.Forms.DockStyle.Fill;
			this._processTitleContainer.IsSplitterFixed = true;
			this._processTitleContainer.Location        = new System.Drawing.Point(0, 0);
			this._processTitleContainer.Margin          = new System.Windows.Forms.Padding(0);
			this._processTitleContainer.Name            = "_processTitleContainer";
			// 
			// _processTitleContainer.Panel1
			// 
			this._processTitleContainer.Panel1.Controls.Add(this._processTitle);
			// 
			// _processTitleContainer.Panel2
			// 
			this._processTitleContainer.Panel2.Controls.Add(this._processTitleInputBox);
			this._processTitleContainer.Panel2.Padding   = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._processTitleContainer.Size             = new System.Drawing.Size(359, 25);
			this._processTitleContainer.SplitterDistance = 170;
			this._processTitleContainer.TabIndex         = 0;
			// 
			// _processTitle
			// 
			this._processTitle.Dock        =  System.Windows.Forms.DockStyle.Fill;
			this._processTitle.Font        =  new System.Drawing.Font("ＭＳ ゴシック", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this._processTitle.Location    =  new System.Drawing.Point(0, 0);
			this._processTitle.Name        =  "_processTitle";
			this._processTitle.Size        =  new System.Drawing.Size(170, 25);
			this._processTitle.TabIndex    =  3;
			this._processTitle.Text        =  "TitleText";
			this._processTitle.TextAlign   =  System.Drawing.ContentAlignment.MiddleLeft;
			this._processTitle.Click       += new System.EventHandler(this._processTitle_Click);
			this._processTitle.DoubleClick += new System.EventHandler(this._processTitle_DoubleClick);
			// 
			// _processTitleInputBox
			// 
			this._processTitleInputBox.Dock           =  System.Windows.Forms.DockStyle.Fill;
			this._processTitleInputBox.Location       =  new System.Drawing.Point(0, 3);
			this._processTitleInputBox.Name           =  "_processTitleInputBox";
			this._processTitleInputBox.Size           =  new System.Drawing.Size(185, 19);
			this._processTitleInputBox.TabIndex       =  0;
			this._processTitleInputBox.Text           =  "TitleText";
			this._processTitleInputBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this._processTitleInputBox_PreviewKeyDown);
			// 
			// _addProcessButton
			// 
			this._addProcessButton.BackgroundImage         =  global::TaskChecker.Properties.Resources.add;
			this._addProcessButton.BackgroundImageLayout   =  System.Windows.Forms.ImageLayout.Center;
			this._addProcessButton.Location                =  new System.Drawing.Point(2, 0);
			this._addProcessButton.Margin                  =  new System.Windows.Forms.Padding(0);
			this._addProcessButton.Name                    =  "_addProcessButton";
			this._addProcessButton.Size                    =  new System.Drawing.Size(25, 25);
			this._addProcessButton.TabIndex                =  2;
			this._addProcessButton.UseVisualStyleBackColor =  true;
			this._addProcessButton.Click                   += new System.EventHandler(this._addProcessButton_Click);
			// 
			// _memoButton
			// 
			this._memoButton.BackgroundImage         =  global::TaskChecker.Properties.Resources.viewMoreText;
			this._memoButton.BackgroundImageLayout   =  System.Windows.Forms.ImageLayout.Center;
			this._memoButton.FlatStyle               =  System.Windows.Forms.FlatStyle.Flat;
			this._memoButton.Location                =  new System.Drawing.Point(52, 0);
			this._memoButton.Margin                  =  new System.Windows.Forms.Padding(0);
			this._memoButton.Name                    =  "_memoButton";
			this._memoButton.Size                    =  new System.Drawing.Size(25, 25);
			this._memoButton.TabIndex                =  2;
			this._memoButton.UseVisualStyleBackColor =  true;
			this._memoButton.Click                   += new System.EventHandler(this._memoButton_Click);
			// 
			// _removeProcessButton
			// 
			this._removeProcessButton.BackgroundImage         =  ((System.Drawing.Image)(resources.GetObject("_removeProcessButton.BackgroundImage")));
			this._removeProcessButton.BackgroundImageLayout   =  System.Windows.Forms.ImageLayout.Center;
			this._removeProcessButton.Location                =  new System.Drawing.Point(27, 0);
			this._removeProcessButton.Margin                  =  new System.Windows.Forms.Padding(0);
			this._removeProcessButton.Name                    =  "_removeProcessButton";
			this._removeProcessButton.Size                    =  new System.Drawing.Size(25, 25);
			this._removeProcessButton.TabIndex                =  1;
			this._removeProcessButton.UseVisualStyleBackColor =  true;
			this._removeProcessButton.Click                   += new System.EventHandler(this._removeProcessButton_Click);
			// 
			// _contentContainer
			// 
			this._contentContainer.Dock        = System.Windows.Forms.DockStyle.Fill;
			this._contentContainer.Location    = new System.Drawing.Point(0, 0);
			this._contentContainer.Name        = "_contentContainer";
			this._contentContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// _contentContainer.Panel1
			// 
			this._contentContainer.Panel1.Controls.Add(this._memoTextArea);
			this._contentContainer.Panel1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
			// 
			// _contentContainer.Panel2
			// 
			this._contentContainer.Panel2.Padding   = new System.Windows.Forms.Padding(25, 0, 0, 0);
			this._contentContainer.Size             = new System.Drawing.Size(500, 271);
			this._contentContainer.SplitterDistance = 203;
			this._contentContainer.TabIndex         = 0;
			// 
			// _memoTextArea
			// 
			this._memoTextArea.AutoWordSelection = true;
			this._memoTextArea.Dock              = System.Windows.Forms.DockStyle.Fill;
			this._memoTextArea.Location          = new System.Drawing.Point(25, 0);
			this._memoTextArea.Name              = "_memoTextArea";
			this._memoTextArea.Size              = new System.Drawing.Size(475, 203);
			this._memoTextArea.TabIndex          = 1;
			this._memoTextArea.Text              = "";
			// 
			// TaskListItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._rootContainer);
			this.Name = "TaskListItem";
			this.Size = new System.Drawing.Size(500, 300);
			this._rootContainer.Panel1.ResumeLayout(false);
			this._rootContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._rootContainer)).EndInit();
			this._rootContainer.ResumeLayout(false);
			this._headerContainer.Panel1.ResumeLayout(false);
			this._headerContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._headerContainer)).EndInit();
			this._headerContainer.ResumeLayout(false);
			this._headerStatusContainer.Panel1.ResumeLayout(false);
			this._headerStatusContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._headerStatusContainer)).EndInit();
			this._headerStatusContainer.ResumeLayout(false);
			this._headerContentContainer.Panel1.ResumeLayout(false);
			this._headerContentContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._headerContentContainer)).EndInit();
			this._headerContentContainer.ResumeLayout(false);
			this._processTitleContainer.Panel1.ResumeLayout(false);
			this._processTitleContainer.Panel2.ResumeLayout(false);
			this._processTitleContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._processTitleContainer)).EndInit();
			this._processTitleContainer.ResumeLayout(false);
			this._contentContainer.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._contentContainer)).EndInit();
			this._contentContainer.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.TextBox _processTitleInputBox;

		private System.Windows.Forms.SplitContainer _processTitleContainer;

		private System.Windows.Forms.ContextMenuStrip _processStateMenu;

		private System.Windows.Forms.Label _processTitle;

		private System.Windows.Forms.Button _memoButton;

		private System.Windows.Forms.Button _statusButton;

		private System.Windows.Forms.Button _removeProcessButton;

		private System.Windows.Forms.Button _addProcessButton;

		private System.Windows.Forms.SplitContainer _headerContentContainer;

		private System.Windows.Forms.RichTextBox _memoTextArea;

		private System.Windows.Forms.SplitContainer _contentContainer;

		private System.Windows.Forms.SplitContainer _headerStatusContainer;

		private System.Windows.Forms.SplitContainer _headerContainer;

		private System.Windows.Forms.Button _expandButton;

		private System.Windows.Forms.SplitContainer _rootContainer;

		#endregion
	}
}