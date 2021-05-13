using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.Customize.CustomNodes
{
    public partial class Form1 : TreeExamplesControl
    {
        public Form1()
        {
            InitializeComponent();
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
            get { return "Organizational chart"; }
        }

        //protected override int CalculateTreeWidth(int clientWidth)
        //{
        //    return this.radTreeView1.Width;
        //}

        //protected override int CalculateOffset(int clientWidth)
        //{
        //    return (clientWidth - this.radTreeView1.Width) / 2;
        //}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.AutoScroll = false;

            // TODO: This line of code loads data into the 'nwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);

            this.radTreeView1.TreeViewElement.CreateNodeElement += new CreateTreeNodeElementEventHandler(TreeViewElement_CreateNodeElement);
            this.radTreeView1.TreeViewElement.AutoSizeItems = true;
            this.radTreeView1.ShowLines = false;
            this.radTreeView1.ShowRootLines = false;
            this.radTreeView1.TreeViewElement.ViewElement.Margin = new Padding(4);
            this.radTreeView1.ShowExpandCollapse = true;
            this.radTreeView1.TreeIndent = 50;
            this.radTreeView1.FullRowSelect = false;
            this.radTreeView1.ShowLines = true;
            this.radTreeView1.LineStyle = TreeLineStyle.Solid;
            this.radTreeView1.LineColor = Color.FromArgb(110, 153, 210);
            this.radTreeView1.ExpandAnimation = ExpandAnimation.None;
            this.radTreeView1.AllowEdit = false;

            this.northwindDataSet.Employees.Columns.Add("ParentID", typeof(int));

            this.northwindDataSet.Employees.Rows[0]["ParentID"] = 5;
            this.northwindDataSet.Employees.Rows[1]["ParentID"] = DBNull.Value;
            this.northwindDataSet.Employees.Rows[2]["ParentID"] = 5;
            this.northwindDataSet.Employees.Rows[3]["ParentID"] = 5;
            this.northwindDataSet.Employees.Rows[4]["ParentID"] = 2;
            this.northwindDataSet.Employees.Rows[5]["ParentID"] = 5;
            this.northwindDataSet.Employees.Rows[6]["ParentID"] = 5;
            this.northwindDataSet.Employees.Rows[7]["ParentID"] = 2;
            this.northwindDataSet.Employees.Rows[8]["ParentID"] = 5;

            this.radTreeView1.DisplayMember = "LastName";
            this.radTreeView1.ChildMember = "EmployeeID";
            this.radTreeView1.ParentMember = "ParentID";
            this.radTreeView1.DataSource = this.northwindDataSet.Employees;
            this.radTreeView1.ExpandAll();

            this.radTreeView1.Size = new System.Drawing.Size(768, 479);
        }

        void TreeViewElement_CreateNodeElement(object sender, CreateTreeNodeElementEventArgs args)
        {
            args.NodeElement = new CustomTreeNodeElement();
        }
    }
}
