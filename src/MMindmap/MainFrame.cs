using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MMindmap
{
	public partial class MainFrame : Form
	{
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		private List<ChildFrame> childs = new List<ChildFrame>();
		public MainFrame()
		{
			InitializeComponent();
			InitialMenu();
		}

		public void AddTabPage(TabPage page)
		{
			this.tabControlMainFrame.TabPages.Add(page);
		}

		private void MainFrame_Load(object sender, EventArgs e)
		{
			ChildFrame child = new ChildFrame(this);
			childs.Add(child);
		}

		private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void MainFrame_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		private void InitialMenu()
		{
			this.SuspendLayout();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			// fileToolStripMenuItem
			//
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			//
			this.menuStripMainFrame.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem
			});
			this.ResumeLayout(false);
		}
	}
}
