namespace TaskChecker {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.TreeNode                  treeNode1 = new System.Windows.Forms.TreeNode("ノード0");
			this.mainMenu                   = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1        = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem     = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem    = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2        = new System.Windows.Forms.ToolStripSeparator();
			this.allSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem    = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
			this.mainToolBar                = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1           = new System.Windows.Forms.ToolStripButton();
			this.mainStatusBar              = new System.Windows.Forms.StatusStrip();
			this.splitContainer1            = new System.Windows.Forms.SplitContainer();
			this.mainTreeView               = new System.Windows.Forms.TreeView();
			this.mainTabControl             = new System.Windows.Forms.TabControl();
			this.tabPage1                   = new System.Windows.Forms.TabPage();
			this.tabPage2                   = new System.Windows.Forms.TabPage();
			this.mainMenu.SuspendLayout();
			this.mainToolBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.mainTabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem , this.editToolStripMenuItem , this.searchToolStripMenuItem , this.viewToolStripMenuItem });
			this.mainMenu.Location = new System.Drawing.Point(0 , 0);
			this.mainMenu.Name     = "mainMenu";
			this.mainMenu.Size     = new System.Drawing.Size(800 , 26);
			this.mainMenu.TabIndex = 0;
			this.mainMenu.Text     = "mainMenu";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.exitToolStripMenuItem });
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(85 , 22);
			this.fileToolStripMenuItem.Text = "ファイル(&F)";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name         = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size         = new System.Drawing.Size(166 , 22);
			this.exitToolStripMenuItem.Text         = "終了(&X)";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.undoToolStripMenuItem , this.redoToolStripMenuItem , this.toolStripSeparator1 , this.cutToolStripMenuItem , this.copyToolStripMenuItem , this.pasteToolStripMenuItem , this.deleteToolStripMenuItem , this.toolStripSeparator2 , this.allSelectToolStripMenuItem });
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(61 , 22);
			this.editToolStripMenuItem.Text = "編集(&E)";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name         = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size         = new System.Drawing.Size(201 , 22);
			this.undoToolStripMenuItem.Text         = "元に戻す(&U)";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name         = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.redoToolStripMenuItem.Size         = new System.Drawing.Size(201 , 22);
			this.redoToolStripMenuItem.Text         = "やり直し(&R)";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(198 , 6);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Name         = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size         = new System.Drawing.Size(201 , 22);
			this.cutToolStripMenuItem.Text         = "切り取り(&T)";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name         = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size         = new System.Drawing.Size(201 , 22);
			this.copyToolStripMenuItem.Text         = "コピー(&C)";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name         = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size         = new System.Drawing.Size(201 , 22);
			this.pasteToolStripMenuItem.Text         = "貼り付け(&P)";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name         = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteToolStripMenuItem.Size         = new System.Drawing.Size(201 , 22);
			this.deleteToolStripMenuItem.Text         = "削除(&L)";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(198 , 6);
			// 
			// allSelectToolStripMenuItem
			// 
			this.allSelectToolStripMenuItem.Name         = "allSelectToolStripMenuItem";
			this.allSelectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.allSelectToolStripMenuItem.Size         = new System.Drawing.Size(201 , 22);
			this.allSelectToolStripMenuItem.Text         = "すべて選択(&A)";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(62 , 22);
			this.searchToolStripMenuItem.Text = "検索(&S)";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(62 , 22);
			this.viewToolStripMenuItem.Text = "表示(&V)";
			// 
			// mainToolBar
			// 
			this.mainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripButton1 });
			this.mainToolBar.Location = new System.Drawing.Point(0 , 26);
			this.mainToolBar.Name     = "mainToolBar";
			this.mainToolBar.Size     = new System.Drawing.Size(800 , 25);
			this.mainToolBar.TabIndex = 1;
			this.mainToolBar.Text     = "mainToolBar";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle          = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image                 = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name                  = "toolStripButton1";
			this.toolStripButton1.Size                  = new System.Drawing.Size(23 , 22);
			this.toolStripButton1.Text                  = "toolStripButton1";
			// 
			// mainStatusBar
			// 
			this.mainStatusBar.Location = new System.Drawing.Point(0 , 428);
			this.mainStatusBar.Name     = "mainStatusBar";
			this.mainStatusBar.Size     = new System.Drawing.Size(800 , 22);
			this.mainStatusBar.TabIndex = 2;
			this.mainStatusBar.Text     = "mainStatusBar";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock     = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0 , 51);
			this.splitContainer1.Name     = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.mainTreeView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.mainTabControl);
			this.splitContainer1.Size             = new System.Drawing.Size(800 , 377);
			this.splitContainer1.SplitterDistance = 266;
			this.splitContainer1.TabIndex         = 3;
			// 
			// mainTreeView
			// 
			this.mainTreeView.Dock     = System.Windows.Forms.DockStyle.Fill;
			this.mainTreeView.Location = new System.Drawing.Point(0 , 0);
			this.mainTreeView.Name     = "mainTreeView";
			treeNode1.Name             = "ノード0";
			treeNode1.Text             = "ノード0";
			this.mainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode1 });
			this.mainTreeView.Size     = new System.Drawing.Size(266 , 377);
			this.mainTreeView.TabIndex = 0;
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.tabPage1);
			this.mainTabControl.Controls.Add(this.tabPage2);
			this.mainTabControl.Dock          = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Location      = new System.Drawing.Point(0 , 0);
			this.mainTabControl.Name          = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size          = new System.Drawing.Size(530 , 377);
			this.mainTabControl.TabIndex      = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Location                = new System.Drawing.Point(4 , 22);
			this.tabPage1.Name                    = "tabPage1";
			this.tabPage1.Padding                 = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size                    = new System.Drawing.Size(522 , 351);
			this.tabPage1.TabIndex                = 0;
			this.tabPage1.Text                    = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location                = new System.Drawing.Point(4 , 22);
			this.tabPage2.Name                    = "tabPage2";
			this.tabPage2.Padding                 = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size                    = new System.Drawing.Size(522 , 351);
			this.tabPage2.TabIndex                = 1;
			this.tabPage2.Text                    = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F , 12F);
			this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize          = new System.Drawing.Size(800 , 450);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.mainStatusBar);
			this.Controls.Add(this.mainToolBar);
			this.Controls.Add(this.mainMenu);
			this.MainMenuStrip = this.mainMenu;
			this.Name          = "MainForm";
			this.Text          = "TaskChecker";
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.mainToolBar.ResumeLayout(false);
			this.mainToolBar.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.mainTabControl.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage    tabPage1;
		private System.Windows.Forms.TabPage    tabPage2;

		private System.Windows.Forms.TreeView mainTreeView;

		private System.Windows.Forms.SplitContainer splitContainer1;

		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem allSelectToolStripMenuItem;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.StatusStrip     mainStatusBar;

		private System.Windows.Forms.ToolStrip mainToolBar;

		private System.Windows.Forms.MenuStrip         mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		#endregion
	}
}