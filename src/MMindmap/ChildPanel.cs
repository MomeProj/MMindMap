using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMindmap
{
	public partial class ChildPanel : Panel
	{
		private int drawCount = 0;
		public ChildPanel()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			drawCount++;
			Debug.Print("Draw {0}", drawCount);
			base.OnPaint(e);
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
		}
	}
}
