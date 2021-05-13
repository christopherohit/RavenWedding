using System.Collections.Generic;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.SyntaxEditor.FirstLook
{
    public static class ExampleHelper
    {
        private const string ProjectsFolder = "Telerik.Examples.WinControls.SyntaxEditor.FirstLook.ProjectFiles.";

        public static void PopulateTreeView(RadTreeView treeView)
        {
            List<DirectoryInfo> data = new List<DirectoryInfo>();
            DirectoryInfo d = new DirectoryInfo("Scripts", "Scripts");
            d.Children.Add(new FileInfo("create-table.sql", "create-table.sql"));
            d.Children.Add(new FileInfo("download.js", "download.js"));
            data.Add(d);

            d = new DirectoryInfo("StyleSelectors", "StyleSelectors");
            d.Children.Add(new FileInfo("RowStyleSelector.cs", "RowStyleSelector.cs"));
            d.Children.Add(new FileInfo("RowStyleSelector.vb", "RowStyleSelector.vb"));
            data.Add(d);

            d = new DirectoryInfo("Views", "Views");
            d.Children.Add(new FileInfo("OrdersView.xaml.cs", "OrdersView.xaml.cs"));
            d.Children.Add(new FileInfo("PerformanceChart.xaml.cs", "PerformanceChart.xaml.cs"));
            d.Children.Add(new FileInfo("OrdersView.xaml", "OrdersView.xaml"));
            d.Children.Add(new FileInfo("PerformanceChart.xaml", "PerformanceChart.xaml"));
            data.Add(d);

            d = new DirectoryInfo("App.xaml", "App.xaml");
            data.Add(d);

            d = new DirectoryInfo("App.xaml.cs", "App.xaml.cs");
            data.Add(d);

            d = new DirectoryInfo("Employees.xml", "Employees.xml");
            data.Add(d);

            d = new DirectoryInfo("Example.xaml", "Example.xaml");
            data.Add(d);

            d = new DirectoryInfo("Example.xaml.cs", "Example.xaml.cs");
            data.Add(d);

            treeView.ChildMember = @"Name\Children";
            treeView.DisplayMember = @"Name\Name";
            treeView.DataSource = data;
        }
    }
}
