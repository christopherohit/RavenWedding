using System;
using System.Drawing;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.SelfReference
{
    /// <summary>
    /// RadTreeView example
    /// </summary>
    public partial class Form1 : TreeExamplesControl
	{
		public Form1()
		{
			InitializeComponent();
            this.radTreeView1.AllowDragDrop = true;

			this.SelectedControl = this.radTreeView1;
		}

        public override RadTreeView TreeControl
        {
            get { return this.radTreeView1; }
        }

        public override Bitmap BottomRightImage
        {
            get { return null; }
        }

        public override string HeaderText
        {
            get { return "Employees"; }
        }

        private void ExpandNodes()
        {
            using (this.radTreeView1.DeferRefresh())
            {
                RadTreeNode root = this.radTreeView1.Nodes[0];
                root.Expand();
                int index = 0;

                foreach (RadTreeNode node in root.Nodes)
                {
                    if (index % 2 == 0)
                    {
                        node.Expand();
                    }

                    index++;
                }

                if (root.Nodes.Count > 0)
                {
                    root.Nodes[root.Nodes.Count - 1].ExpandAll();
                }
            }
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // TODO: This line of code loads data into the 'adventureLT2008DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.adventureLT2008DataSet.Employee);

            //Note: The self-reference binding properties can be setup using Visual Studio Properties Window or Smart Tag
            this.radTreeView1.TreeViewElement.AllowAlternatingRowColor = true;
            this.radTreeView1.DisplayMember = "Title";
            this.radTreeView1.ParentMember = "ManagerID";
            this.radTreeView1.ChildMember = "EmployeeID";
            this.radTreeView1.DataSource = this.employeeBindingSource;

            ExpandNodes();
        }
	}
}

