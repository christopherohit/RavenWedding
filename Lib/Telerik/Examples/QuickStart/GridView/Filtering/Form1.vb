Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data

Namespace Telerik.Examples.WinControls.GridView.Filtering
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radGridView1

			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.EnableHotTracking = True
			Me.radGridView1.MasterTemplate.AllowEditRow = False
			Me.radGridView1.Size = New Size(Me.radGridView1.Width, 690)
			AddHandler radGridView1.CellBeginEdit, AddressOf radGridView1_CellBeginEdit

			Me.radGridView1.TableElement.EnableHotTracking = False
			Me.radGridView1.TableElement.RowHeight = 80
			Me.radGridView1.TableElement.FilterRowHeight = 40
			Me.radGridView1.TableElement.Text = "No Data to display"
			Me.radGridView1.LoadElementTree()

			Me.BindGrid()
		End Sub

		Private Sub radGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As GridViewCellCancelEventArgs)
			Dim editor As RadDateTimeEditor = TryCast(Me.radGridView1.ActiveEditor, RadDateTimeEditor)

			If editor IsNot Nothing Then
				CType(editor.EditorElement, RadItem).ToolTipText = "Modify the date to filter the rows in the grid"
				editor.CustomFormat = "MMMM d, yyyy"
			End If
		End Sub

		Private Sub BindGrid()
			Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)

			Me.radGridView1.DataSource = Me.northwindDataSet.Employees

			Me.radGridView1.TableElement.BeginUpdate()

			Me.radGridView1.Columns("EmployeeID").IsVisible = False
			Me.radGridView1.Columns("Title").IsVisible = False
			Me.radGridView1.Columns("TitleOfCourtesy").IsVisible = False
			Me.radGridView1.Columns("BirthDate").IsVisible = False
			Me.radGridView1.Columns("Address").IsVisible = False
			Me.radGridView1.Columns("PostalCode").IsVisible = False
			Me.radGridView1.Columns("Extension").IsVisible = False
			Me.radGridView1.Columns("ReportsTo").IsVisible = False
			Me.radGridView1.Columns("Region").IsVisible = False
			Me.radGridView1.Columns("City").IsVisible = False
			Me.radGridView1.Columns("Country").IsVisible = False

			Dim columnWidth As Integer = 100
			Me.radGridView1.Columns("LastName").HeaderText = "Last Name"
			Me.radGridView1.Columns("LastName").HeaderTextAlignment = ContentAlignment.MiddleCenter
			Me.radGridView1.Columns("LastName").Width = columnWidth

			Me.radGridView1.Columns("FirstName").HeaderText = "First Name"
			Me.radGridView1.Columns("FirstName").HeaderTextAlignment = ContentAlignment.MiddleCenter
			Me.radGridView1.Columns("FirstName").Width = columnWidth

			columnWidth = 150
			Me.radGridView1.Columns("HireDate").HeaderText = "Hire Date"
			Me.radGridView1.Columns("HireDate").HeaderTextAlignment = ContentAlignment.MiddleCenter
			Me.radGridView1.Columns("HireDate").TextAlignment = ContentAlignment.MiddleRight
			Me.radGridView1.Columns("HireDate").FormatString = "{0:MMMM d, yyyy}"
			Me.radGridView1.Columns("HireDate").Width = columnWidth

			Me.radGridView1.Columns("HomePhone").HeaderText = "Home Phone"
			Me.radGridView1.Columns("HomePhone").HeaderTextAlignment = ContentAlignment.MiddleCenter
			Me.radGridView1.Columns("HomePhone").Width = columnWidth

			Me.radGridView1.Columns("Notes").HeaderTextAlignment = ContentAlignment.MiddleCenter
			Me.radGridView1.Columns("Notes").WrapText = True
			Me.radGridView1.Columns("Notes").Width = 380

			Me.radGridView1.Columns("Photo").HeaderTextAlignment = ContentAlignment.MiddleCenter
			Me.radGridView1.Columns("Photo").Width = 69
			Me.radGridView1.Columns("Photo").MinWidth = 69
			Me.radGridView1.Columns("Photo").MaxWidth = 69

			radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Dim imageColumn As GridViewImageColumn = TryCast(Me.radGridView1.Columns("Photo"), GridViewImageColumn)
			Me.radGridView1.Columns.Move(imageColumn.Index, 0)
			imageColumn.ImageLayout = ImageLayout.Zoom

			Me.radGridView1.Columns.Move(Me.radGridView1.Columns("FirstName").Index, 1)
			Me.radGridView1.TableElement.EndUpdate()
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
