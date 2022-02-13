using System.ComponentModel;

namespace TaskChecker.GuiControl
{
    partial class ProcessListView
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
            if ( disposing && (components != null) )
            {
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
            this._rootContainer          = new System.Windows.Forms.SplitContainer();
            this._toolBar                = new System.Windows.Forms.ToolStrip();
            this._addToolButton          = new System.Windows.Forms.ToolStripButton();
            this._removeToolButton       = new System.Windows.Forms.ToolStripButton();
            this._processListLayoutPanel = new TaskChecker.GuiControl.ProcessListLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._rootContainer)).BeginInit();
            this._rootContainer.Panel1.SuspendLayout();
            this._rootContainer.Panel2.SuspendLayout();
            this._rootContainer.SuspendLayout();
            this._toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _rootContainer
            // 
            this._rootContainer.Dock            = System.Windows.Forms.DockStyle.Fill;
            this._rootContainer.FixedPanel      = System.Windows.Forms.FixedPanel.Panel1;
            this._rootContainer.IsSplitterFixed = true;
            this._rootContainer.Location        = new System.Drawing.Point(0, 0);
            this._rootContainer.Margin          = new System.Windows.Forms.Padding(0);
            this._rootContainer.Name            = "_rootContainer";
            this._rootContainer.Orientation     = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _rootContainer.Panel1
            // 
            this._rootContainer.Panel1.Controls.Add(this._toolBar);
            // 
            // _rootContainer.Panel2
            // 
            this._rootContainer.Panel2.AutoScroll = true;
            this._rootContainer.Panel2.Controls.Add(this._processListLayoutPanel);
            this._rootContainer.Size             = new System.Drawing.Size(500, 300);
            this._rootContainer.SplitterDistance = 25;
            this._rootContainer.TabIndex         = 1;
            // 
            // _toolBar
            // 
            this._toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this._addToolButton, this._removeToolButton });
            this._toolBar.Location = new System.Drawing.Point(0, 0);
            this._toolBar.Name     = "_toolBar";
            this._toolBar.Size     = new System.Drawing.Size(500, 25);
            this._toolBar.TabIndex = 0;
            this._toolBar.Text     = "toolStrip1";
            // 
            // _addToolButton
            // 
            this._addToolButton.DisplayStyle          =  System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addToolButton.Image                 =  global::TaskChecker.Properties.Resources.add;
            this._addToolButton.ImageTransparentColor =  System.Drawing.Color.Magenta;
            this._addToolButton.Name                  =  "_addToolButton";
            this._addToolButton.Size                  =  new System.Drawing.Size(23, 22);
            this._addToolButton.Text                  =  "toolStripButton1";
            this._addToolButton.Click                 += new System.EventHandler(this._addToolButton_Click);
            // 
            // _removeToolButton
            // 
            this._removeToolButton.DisplayStyle          =  System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._removeToolButton.Image                 =  global::TaskChecker.Properties.Resources.remove;
            this._removeToolButton.ImageTransparentColor =  System.Drawing.Color.Magenta;
            this._removeToolButton.Name                  =  "_removeToolButton";
            this._removeToolButton.Size                  =  new System.Drawing.Size(23, 22);
            this._removeToolButton.Text                  =  "toolStripButton2";
            this._removeToolButton.Click                 += new System.EventHandler(this._removeToolButton_Click);
            // 
            // _processListLayoutPanel
            // 
            this._processListLayoutPanel.Dock     = System.Windows.Forms.DockStyle.Fill;
            this._processListLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._processListLayoutPanel.Margin   = new System.Windows.Forms.Padding(0);
            this._processListLayoutPanel.Name     = "_processListLayoutPanel";
            this._processListLayoutPanel.Size     = new System.Drawing.Size(500, 271);
            this._processListLayoutPanel.TabIndex = 1;
            // 
            // ProcessListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._rootContainer);
            this.Name = "ProcessListView";
            this.Size = new System.Drawing.Size(500, 300);
            this._rootContainer.Panel1.ResumeLayout(false);
            this._rootContainer.Panel1.PerformLayout();
            this._rootContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._rootContainer)).EndInit();
            this._rootContainer.ResumeLayout(false);
            this._toolBar.ResumeLayout(false);
            this._toolBar.PerformLayout();
            this.ResumeLayout(false);
        }

        private TaskChecker.GuiControl.ProcessListLayoutPanel _processListLayoutPanel;

        private System.Windows.Forms.SplitContainer _rootContainer;

        private System.Windows.Forms.ToolStrip       _toolBar;
        private System.Windows.Forms.ToolStripButton _addToolButton;
        private System.Windows.Forms.ToolStripButton _removeToolButton;

        #endregion
    }
}