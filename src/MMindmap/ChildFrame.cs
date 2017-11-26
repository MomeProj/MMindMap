using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MMindmap
{
	public partial class ChildFrame: Form
	{

		private string name = "noname";
		private MainFrame mainFrame;
		private ChildView childView;
		private ChildDocument childDoc;
		public ChildFrame(MainFrame parent)
		{
			InitializeComponent();
			this.Name = name;
			mainFrame = parent;
			childView = new ChildView("childView", name, this);
			childDoc = new ChildDocument();
			mainFrame.AddTabPage(childView);
		}

		public void FileSave()
		{
			childDoc.Save();
		}

		public void FileSaveAs()
		{
			childDoc.SaveAs();
		}

		public void FileClose()
		{
		}
	}
}
