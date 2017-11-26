using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MMindmap
{
	class MindmapNodeItem
	{
		#region ICON properities
		private string iconName;
		private int iconAlignStyle;
		#endregion
		#region Texts properities
		private Font textFontStyle;
		private string showText;
		public string Text { get { return showText; } set { showText = value; } }
		private int textAlignmentStype;
		#endregion
		#region Node properities
		private int nodeHeight;
		private int nodeWidth;
		private int nodePositionX;
		private int nodePositionY;
		private int borderStyle;
		private int borderWidth;
		#endregion

	}
}
