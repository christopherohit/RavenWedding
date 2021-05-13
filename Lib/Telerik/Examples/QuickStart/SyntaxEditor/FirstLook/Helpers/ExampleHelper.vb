Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.SyntaxEditor.FirstLook
    Module ExampleHelper
        Private Const ProjectsFolder As String = "Telerik.Examples.WinControls.SyntaxEditor.FirstLook.ProjectFiles."

        Sub PopulateTreeView(ByVal treeView As RadTreeView)
            Dim data As List(Of DirectoryInfo) = New List(Of DirectoryInfo)()
            Dim d As DirectoryInfo = New DirectoryInfo("Scripts", "Scripts")
            d.Children.Add(New FileInfo("create-table.sql", "create-table.sql"))
            d.Children.Add(New FileInfo("download.js", "download.js"))
            data.Add(d)
            d = New DirectoryInfo("StyleSelectors", "StyleSelectors")
            d.Children.Add(New FileInfo("RowStyleSelector.cs", "RowStyleSelector.cs"))
            d.Children.Add(New FileInfo("RowStyleSelector.vb", "RowStyleSelector.vb"))
            data.Add(d)
            d = New DirectoryInfo("Views", "Views")
            d.Children.Add(New FileInfo("OrdersView.xaml.cs", "OrdersView.xaml.cs"))
            d.Children.Add(New FileInfo("PerformanceChart.xaml.cs", "PerformanceChart.xaml.cs"))
            d.Children.Add(New FileInfo("OrdersView.xaml", "OrdersView.xaml"))
            d.Children.Add(New FileInfo("PerformanceChart.xaml", "PerformanceChart.xaml"))
            data.Add(d)
            d = New DirectoryInfo("App.xaml", "App.xaml")
            data.Add(d)
            d = New DirectoryInfo("App.xaml.cs", "App.xaml.cs")
            data.Add(d)
            d = New DirectoryInfo("Employees.xml", "Employees.xml")
            data.Add(d)
            d = New DirectoryInfo("Example.xaml", "Example.xaml")
            data.Add(d)
            d = New DirectoryInfo("Example.xaml.cs", "Example.xaml.cs")
            data.Add(d)
            treeView.ChildMember = "Name\Children"
            treeView.DisplayMember = "Name\Name"
            treeView.DataSource = data
        End Sub
    End Module
End Namespace
