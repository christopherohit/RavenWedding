Imports System.Collections
Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Customize.ConditionalFormatting
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radGridView1.TableElement.BeginUpdate()

			Me.radGridView1.TableElement.EnableHotTracking = False
			Me.radGridView1.TableElement.RowHeight = 30

			Me.BindGrid()
			Me.SetConditions()
			Me.radGridView1.EnableHotTracking = True

			Me.radGridView1.TableElement.EndUpdate(True)
		End Sub

		Private Sub BindGrid()

			'populate and bind the datasource
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)

			Me.radGridView1.DataSource = customersBindingSource

			Me.radGridView1.Columns.Remove(Me.radGridView1.Columns("CustomerID"))
			Me.radGridView1.Columns.Remove(Me.radGridView1.Columns("Region"))
			Me.radGridView1.Columns.Remove(Me.radGridView1.Columns("Fax"))
			Me.radGridView1.Columns.Remove(Me.radGridView1.Columns("CompanyName"))

			Me.radGridView1.Columns("ContactName").HeaderText = "Last Name"
			Me.radGridView1.Columns("ContactName").HeaderTextAlignment = ContentAlignment.MiddleLeft

			Me.radGridView1.Columns("ContactTitle").HeaderText = "Contact Title"
			Me.radGridView1.Columns("ContactTitle").HeaderTextAlignment = ContentAlignment.MiddleLeft

			Me.radGridView1.Columns("PostalCode").HeaderText = "Postal Code"
			Me.radGridView1.Columns("PostalCode").HeaderTextAlignment = ContentAlignment.MiddleLeft

			Me.radGridView1.Columns("Country").HeaderTextAlignment = ContentAlignment.MiddleLeft
			Me.radGridView1.Columns("City").HeaderTextAlignment = ContentAlignment.MiddleLeft
			Me.radGridView1.Columns("Phone").HeaderTextAlignment = ContentAlignment.MiddleLeft
			Me.radGridView1.Columns("Address").HeaderTextAlignment = ContentAlignment.MiddleLeft

		End Sub

		Private Sub SetConditions()
			'add a couple of sample formatting objects
			Dim c1 As New ConditionalFormattingObject("Orange, applied to entire row", ConditionTypes.Equal, "Germany", "", True)
			c1.RowBackColor = Color.FromArgb(255, 209, 140)
            c1.CellBackColor = Color.FromArgb(255, 209, 140)
            c1.RowForeColor = Color.Black
            c1.CellForeColor = Color.Black
			radGridView1.Columns("Country").ConditionalFormattingObjectList.Add(c1)

			Dim c2 As New ConditionalFormattingObject("Green, applied to cells only", ConditionTypes.Equal, "France", "", False)
			c2.RowBackColor = Color.FromArgb(219, 251, 91)
            c2.CellBackColor = Color.FromArgb(219, 251, 91)
            c2.RowForeColor = Color.Black
            c2.CellForeColor = Color.Black
			radGridView1.Columns("Country").ConditionalFormattingObjectList.Add(c2)

			'update the grid view for the conditional formatting to take effect
			'radGridView1.TableElement.Update(false);
		End Sub

		Private Sub btnOpenCondFormatting_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim cf As New ConditionalFormattingForm(Me.radGridView1.MasterTemplate, Nothing)
			cf.Owner = Me.FindForm()
			ThemeResolutionService.ApplyThemeToControlTree(cf, Me.radGridView1.ThemeName)
			cf.Show()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler btnOpenCondFormatting.Click, AddressOf btnOpenCondFormatting_Click
		End Sub
	End Class
End Namespace
