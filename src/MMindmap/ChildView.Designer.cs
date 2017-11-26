using System.Drawing;
using System.Windows.Forms;

namespace MMindmap
{
	partial class ChildView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
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
			this.childPanel = new MMindmap.ChildPanel();
			this.SuspendLayout();
			//
			// ChildPanel
			//
			this.childPanel.BackColor = System.Drawing.Color.Transparent;
			this.childPanel.Location = new System.Drawing.Point(0, 0);
			this.childPanel.Name = "childPanel";
			this.childPanel.Size = new System.Drawing.Size(4096, 2048);
			this.childPanel.TabIndex = 0;
			this.childPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPanelPaint);
			this.childPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseDown);
			this.childPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseMove);
			this.childPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseUp);
			//
			// ChildView
			//
			this.AutoScroll = true;
			this.Controls.Add(this.childPanel);
			this.ResumeLayout(false);
		}
		#endregion

		private ChildPanel childPanel;
	}
}