using System;
using System.Drawing;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls.UI;
using System.IO;
using Telerik.Examples.WinControls.TreeView.PopulateWithData.ObjectRelational;
using Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational;

namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.ObjectRelational
{
	/// <summary>
	/// Form code
	/// </summary>
    public partial class Form1 : TreeExamplesControl
	{
        Bitmap bottomRightBitmap = Resources.TV_music; 
        
        public Form1()
		{
			InitializeComponent();
			this.SelectedControl = this.radTreeView1;
		}

        public override RadTreeView TreeControl
        {
            get { return this.radTreeView1; }
        }

        public override Bitmap BottomRightImage
        {
            get { return bottomRightBitmap; }
        }

        public override string HeaderText
        {
            get { return "Music Collection"; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radTreeView1.AllowDragDrop = true;
            this.radTreeView1.ChildMember = @"Artist\Albums\Tracks";
            this.radTreeView1.DisplayMember = @"Name\Title\Name";
            this.radTreeView1.DataSource = DataContext.TopArtists;
            this.radTreeView1.AllowEdit = false;
          

            ///--------------------------------------------------------------------------------------------------------------
            ///
            //auto generate Object-Relational Hierarchy using Entity Framework 
            //currently can not be run in our Demo Application - we have dependency to .NET Framework 2.0
            //will be available for next 4.0 version of Demo application and Code Library project: http://www.telerik.com/support/kb/winforms

            //AWModel.AdventureWorksLT2008Entities entities = new AWModel.AdventureWorksLT2008Entities();
            //var query = from productCategory in entities.ProductCategory select productCategory;
            //this.radTreeView1.DataSource = query.ToList();
            //this.radTreeView1.ValueMember = @"ProductCategory\Products";
            //this.radTreeView1.DisplayMember = @"CategoryName\ProductName";

            ///--------------------------------------------------------------------------------------------------------------


            ///--------------------------------------------------------------------------------------------------------------
            ///
            //auto generate Object-Relational Hierarchy using our OpenAccess ORM Framework
            //you can found example in our Code Library project: http://www.telerik.com/support/kb/winforms

            //using (AdventureWorksLT2008 context = new AdventureWorksLT2008())
            //{
            //    List<ProductCategory> list = context.ProductCategories.ToList();
            //    this.radTreeView1.DataSource = list;
            //    this.radTreeView1.ValueMember = @"ProductCategory\Products";
            //    this.radTreeView1.DisplayMember = @"CategoryName\ProductName";
            //}

            ///--------------------------------------------------------------------------------------------------------------
        }

        private void radTreeView1_NodeExpandedChanging(object sender, RadTreeViewCancelEventArgs e)
        {
            RadTreeNodeCollection nodes = e.Node.Nodes;
            foreach (RadTreeNode node in nodes)
            {
                node.ImageIndex = node.Level;
            }
        }
	}
}

