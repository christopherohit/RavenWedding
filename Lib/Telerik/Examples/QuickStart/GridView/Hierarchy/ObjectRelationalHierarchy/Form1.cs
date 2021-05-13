using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.TreeView.PopulateWithData.ObjectRelational;
using System.Collections.Generic;
using Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational;

namespace Telerik.Examples.WinControls.GridView.Hierarchy.ObjectRelationalHierarchy
{
	public partial class Form1 : ExamplesForm
	{
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            List<Artist> list = DataContext.Artists;

            this.radGridView1.DataSource = DataContext.Artists;
            this.radGridView1.AutoGenerateHierarchy = true;

            this.SetupTemplates();
           
            ///--------------------------------------------------------------------------------------------------------------
            ///
            //auto generate Object-Relational Hierarchy using Entity Framework 
            //currently can not be run in our Demo Application - we have dependency to .NET Framework 2.0
            //will be available for next 4.0 version of Demo application and Code Library project: http://www.telerik.com/support/kb/winforms

            //AWModel.AdventureWorksLT2008Entities entities = new AWModel.AdventureWorksLT2008Entities();
            //var query = from productCategory in entities.ProductCategory select productCategory;
            //this.radGridView1.DataSource = query.ToList();
            //this.radGridView1.AutoGenerateHierarchy = true;

            ///--------------------------------------------------------------------------------------------------------------


            ///--------------------------------------------------------------------------------------------------------------
            ///
            //auto generate Object-Relational Hierarchy using our OpenAccess ORM Framework
            //you can found example in our Code Library project: http://www.telerik.com/support/kb/winforms

            //using (AdventureWorksLT2008 context = new AdventureWorksLT2008())
            //{
            //    List<ProductCategory> list = context.ProductCategories.ToList();
            //    this.radGridView1.DataSource = list;
            //    this.radGridView1.AutoGenerateHierarchy = true;
            //}

            ///--------------------------------------------------------------------------------------------------------------
        }

        private void SetupTemplates()
        {
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.Columns["Id"].IsVisible = false;
            this.radGridView1.Columns["Albums"].IsVisible = false;
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.Templates[0].AllowAddNewRow = false;
            this.radGridView1.Templates[0].Columns["Id"].IsVisible = false;
            this.radGridView1.Templates[0].Columns["ArtistId"].IsVisible = false;
            this.radGridView1.Templates[0].Columns["Tracks"].IsVisible = false;
            this.radGridView1.Templates[0].AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.Templates[0].Templates[0].AllowAddNewRow = false;
            this.radGridView1.Templates[0].Templates[0].Columns["Id"].IsVisible = false;
            this.radGridView1.Templates[0].Templates[0].Columns["Size"].IsVisible = false;
            this.radGridView1.Templates[0].Templates[0].AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        protected override void WireEvents()
        {
        }
    }
}
