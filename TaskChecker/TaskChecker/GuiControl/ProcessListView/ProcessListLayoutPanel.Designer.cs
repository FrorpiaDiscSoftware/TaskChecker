using System.ComponentModel;

namespace TaskChecker.GuiControl
{
    partial class ProcessListLayoutPanel
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
            this._listItemLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // _listItemLayoutPanel
            // 
            this._listItemLayoutPanel.ColumnCount = 1;
            this._listItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._listItemLayoutPanel.Dock     = System.Windows.Forms.DockStyle.Top;
            this._listItemLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._listItemLayoutPanel.Margin   = new System.Windows.Forms.Padding(0);
            this._listItemLayoutPanel.Name     = "_listItemLayoutPanel";
            this._listItemLayoutPanel.RowCount = 1;
            this._listItemLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._listItemLayoutPanel.Size     = new System.Drawing.Size(150, 50);
            this._listItemLayoutPanel.TabIndex = 1;
            // 
            // ProcessListLayoutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._listItemLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name   = "ProcessListLayoutPanel";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel _listItemLayoutPanel;

        #endregion
    }
}