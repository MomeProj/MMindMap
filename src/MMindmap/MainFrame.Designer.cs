namespace MMindmap
{
	partial class MainFrame
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStripMainFrame = new System.Windows.Forms.MenuStrip();
			this.statusStripMainFrame = new System.Windows.Forms.StatusStrip();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.tabControlMainFrame = new System.Windows.Forms.TabControl();
			this.toolStripMainFrame = new System.Windows.Forms.ToolStrip();
			this.menuStripMainFrame.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			//
			// menuStripMainFrame
			//
			this.menuStripMainFrame.Location = new System.Drawing.Point(0, 0);
			this.menuStripMainFrame.Name = "menuStripMainFrame";
			this.menuStripMainFrame.Size = new System.Drawing.Size(784, 28);
			this.menuStripMainFrame.TabIndex = 0;
			this.menuStripMainFrame.Text = "menuStripMainFrame";
			//
			// statusStripMainFrame
			//
			this.statusStripMainFrame.Location = new System.Drawing.Point(0, 539);
			this.statusStripMainFrame.Name = "statusStripMainFrame";
			this.statusStripMainFrame.Size = new System.Drawing.Size(784, 22);
			this.statusStripMainFrame.TabIndex = 1;
			this.statusStripMainFrame.Text = "statusStripMainFrame";
			//
			// toolStripContainer1
			//
			//
			// toolStripContainer1.ContentPanel
			//
			this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControlMainFrame);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 486);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 28);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(784, 511);
			this.toolStripContainer1.TabIndex = 2;
			this.toolStripContainer1.Text = "toolStripContainer1";
			//
			// toolStripContainer1.TopToolStripPanel
			//
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripMainFrame);
			//
			// tabControlMainFrame
			//
			this.tabControlMainFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMainFrame.Location = new System.Drawing.Point(0, 0);
			this.tabControlMainFrame.Name = "tabControlMainFrame";
			this.tabControlMainFrame.SelectedIndex = 0;
			this.tabControlMainFrame.Size = new System.Drawing.Size(784, 486);
			this.tabControlMainFrame.TabIndex = 0;
			//
			// toolStripMainFrame
			//
			this.toolStripMainFrame.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripMainFrame.Location = new System.Drawing.Point(3, 0);
			this.toolStripMainFrame.Name = "toolStripMainFrame";
			this.toolStripMainFrame.Size = new System.Drawing.Size(111, 25);
			this.toolStripMainFrame.TabIndex = 0;
			//
			// MainFrame
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.statusStripMainFrame);
			this.Controls.Add(this.menuStripMainFrame);
			this.MainMenuStrip = this.menuStripMainFrame;
			this.Name = "MainFrame";
			this.Text = "MMindmap";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrame_FormClosed);
			this.Load += new System.EventHandler(this.MainFrame_Load);
			this.menuStripMainFrame.ResumeLayout(false);
			this.menuStripMainFrame.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripMainFrame;
		private System.Windows.Forms.StatusStrip statusStripMainFrame;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStrip toolStripMainFrame;
		private System.Windows.Forms.TabControl tabControlMainFrame;

	}
}

