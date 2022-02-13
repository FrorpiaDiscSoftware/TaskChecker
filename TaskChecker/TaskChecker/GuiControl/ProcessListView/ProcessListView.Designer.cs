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
            this._toolBar                = new System.Windows.Forms.ToolStrip();
            this._addToolButton          = new System.Windows.Forms.ToolStripButton();
            this._removeToolButton       = new System.Windows.Forms.ToolStripButton();
            this._processListLayoutPanel = new TaskChecker.GuiControl.ProcessListLayoutPanel();
            this._rootLayoutPanel        = new System.Windows.Forms.TableLayoutPanel();
            this._toolBar.SuspendLayout();
            this._rootLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            this._processListLayoutPanel.AutoScroll      = true;
            this._processListLayoutPanel.Dock            = System.Windows.Forms.DockStyle.Fill;
            this._processListLayoutPanel.layoutPanelSize = new System.Drawing.Size(500, 50);
            this._processListLayoutPanel.Location        = new System.Drawing.Point(0, 25);
            this._processListLayoutPanel.Margin          = new System.Windows.Forms.Padding(0);
            this._processListLayoutPanel.Name            = "_processListLayoutPanel";
            this._processListLayoutPanel.Size            = new System.Drawing.Size(500, 275);
            this._processListLayoutPanel.TabIndex        = 1;
            // 
            // _rootLayoutPanel
            // 
            this._rootLayoutPanel.ColumnCount = 1;
            this._rootLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._rootLayoutPanel.Controls.Add(this._processListLayoutPanel, 0, 1);
            this._rootLayoutPanel.Controls.Add(this._toolBar,                0, 0);
            this._rootLayoutPanel.Dock     = System.Windows.Forms.DockStyle.Fill;
            this._rootLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._rootLayoutPanel.Margin   = new System.Windows.Forms.Padding(0);
            this._rootLayoutPanel.Name     = "_rootLayoutPanel";
            this._rootLayoutPanel.RowCount = 2;
            this._rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,  100F));
            this._rootLayoutPanel.Size     = new System.Drawing.Size(500, 300);
            this._rootLayoutPanel.TabIndex = 2;
            // 
            // ProcessListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._rootLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name   = "ProcessListView";
            this.Size   = new System.Drawing.Size(500, 300);
            this._toolBar.ResumeLayout(false);
            this._toolBar.PerformLayout();
            this._rootLayoutPanel.ResumeLayout(false);
            this._rootLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel _rootLayoutPanel;

        private TaskChecker.GuiControl.ProcessListLayoutPanel _processListLayoutPanel;

        private System.Windows.Forms.ToolStrip       _toolBar;
        private System.Windows.Forms.ToolStripButton _addToolButton;
        private System.Windows.Forms.ToolStripButton _removeToolButton;

        #endregion
    }
}