using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMindmap
{
	class ChildDocument
	{
		private string fileName;
		private Dictionary<int, MindmapNodeItem> nodeItems = new Dictionary<int, MindmapNodeItem>();
		private MindmapNodeItem root;
		public ChildDocument()
		{
			root = new MindmapNodeItem();
			root.Text = "My Text";
		}

		public ChildDocument(string root_text)
		{
			root = new MindmapNodeItem();
			root.Text = root_text;
		}

		public void InsertRoot()
		{
		}

		public void InsertNode(MindmapNodeItem parent, MindmapNodeItem node)
		{
		}

		public void DeleteNode()
		{
		}

		public void Save()
		{
		}

		public void SaveAs()
		{
		}
	}
}
