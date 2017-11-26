using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MMindmap
{
	public partial class ChildView : TabPage
	{
		private ChildFrame childFrame;

		private Point startPoint;
		public ChildView(string name, string text, ChildFrame parent)
		{
			childFrame = parent;
			this.Name = name;
			this.Text = text;
			InitializeComponent();
		}

		private void OnPanelMouseEnter(object sender, EventArgs e)
		{
			//this.panel.Focus();
		}

		private void OnPanelPaint(object sender, PaintEventArgs e)
		{
			// Create string to draw.
			String drawString = "Sample Text";
			// Create font and brush.
			Font drawFont = new Font("Arial", 16);
			SolidBrush drawBrush = new SolidBrush(Color.Black);
			// Create rectangle for drawing.
			float x = 150.0F;
			float y = 150.0F;
			float width = 200.0F;
			float height = 50.0F;
			RectangleF drawRect = new RectangleF(x, y, width, height);
			// Draw rectangle to screen.
			Pen blackPen = new Pen(Color.Black);
			e.Graphics.DrawRectangle(blackPen, x, y, width, height);
			e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), drawRect);
			// Set format of string.
			StringFormat drawFormat = new StringFormat();
			drawFormat.Alignment = StringAlignment.Center;
			// Draw string to screen.
			e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
		}

		private void OnPanelMouseUp(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
				case MouseButtons.Left:
					{
						Debug.Print("Left");
					}
					break;

				case MouseButtons.Right:
					{
						Debug.Print("right");
					}
					break;

				case MouseButtons.Middle:
					{
						Debug.Print("Middle");
					}
					break;
			}
		}

		private void OnPanelMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				startPoint = e.Location;
			}
		}

		private void OnPanelMouseMove(object sender, MouseEventArgs e)
		{
			Win32Ctrl.ReleaseCapture();

			if (e.Button == MouseButtons.Left)
			{
				//Debug.Print("start:({0}.{1}) current:({2},{3})", startPoint.X, startPoint.Y, e.Location.X, e.Location.Y);
				if (e.Location.X - startPoint.X != 0 || e.Location.Y - startPoint.Y != 0)
				{
					// 因為scrollbar變動，所以會引發 panel 重繪。
					Point changePoint = new Point(e.Location.X - startPoint.X, e.Location.Y - startPoint.Y);
					this.AutoScrollPosition = new Point(-this.AutoScrollPosition.X - changePoint.X, -this.AutoScrollPosition.Y - changePoint.Y);
					// Erase Background
					this.childPanel.Refresh();
					//this.panel.Invalidate();
				}
			}
		}
	}
}
