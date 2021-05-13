Imports System.Collections
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters

Namespace Telerik.Examples.WinControls.GridView.Rows.AddNewRow
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private productAdapter As New ProductsTableAdapter()
		Private productSource As New BindingSource()
		Private ProductID As Integer = 100000

		#End Region

		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radGridView1
			Me.radGridView1.EnableHotTracking = True
		End Sub

		Private Sub FillGrid()
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)
			Me.productAdapter.Fill(Me.nwindRadGridView.Products)

			Me.productSource.DataSource = Me.nwindRadGridView.Products
			Me.radGridView1.DataSource = productSource
		End Sub

		Private Sub SetPreferences()
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.MasterTemplate.AllowAddNewRow = True
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.Columns("ProductID").IsVisible = False
			Me.radGridView1.Columns("SupplierID").IsVisible = False
			Me.radGridView1.Columns("CategoryID").IsVisible = False
			Me.radGridView1.Columns("UnitsOnOrder").IsVisible = False
			Me.radGridView1.Columns("ReorderLevel").IsVisible = False

			Me.radGridView1.Columns("ProductName").HeaderText = "Product Name"
			Me.radGridView1.Columns("UnitsInStock").HeaderText = "In Stock"
			Me.radGridView1.Columns("UnitPrice").HeaderText = "Price"
			Me.radGridView1.Columns("UnitPrice").FormatString = "${0:###,###0.00}"
			Me.radGridView1.Columns("QuantityPerUnit").HeaderText = "Quantity Per Unit"
			Me.radGridView1.Columns("QuantityPerUnit").TextAlignment = ContentAlignment.MiddleCenter

			AddHandler radGridView1.DefaultValuesNeeded, AddressOf radGridView1_DefaultValuesNeeded
		End Sub

		Private Sub radGridView1_DefaultValuesNeeded(ByVal sender As Object, ByVal e As GridViewRowEventArgs)
			'ProductID cannot be null and has to be unique as there are constrains in the data base.
			'Therefore its value has to be set in DefaultValuesNeeded event handler:
			e.Row.Cells("ProductID").Value = ProductID
			ProductID += 1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			FillGrid()
			SetPreferences()
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
