using System.ComponentModel;

namespace TaskChecker.GuiControl
{
	partial class ListItemContainer<ListItemT>
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
			this._container = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this._container)).BeginInit();
			this._container.SuspendLayout();
			this.SuspendLayout();
			// 
			// _container
			// 
			this._container.Dock             = System.Windows.Forms.DockStyle.Fill;
			this._container.Location         = new System.Drawing.Point(0, 0);
			this._container.Name             = "_container";
			this._container.Orientation      = System.Windows.Forms.Orientation.Horizontal;
			this._container.Size             = new System.Drawing.Size(480, 480);
			this._container.SplitterDistance = 240;
			this._container.TabIndex         = 0;
			// 
			// ListItemContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._container);
			this.Name = "ListItemContainer";
			this.Size = new System.Drawing.Size(480, 480);
			((System.ComponentModel.ISupportInitialize)(this._container)).EndInit();
			this._container.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.SplitContainer _container;

		#endregion
	}
}