Imports System.Collections
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Customize.FormatValues
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub SetPreferences()
			Me.radGridView1.EnableHotTracking = True
			Me.radGridView1.EnableGrouping = False
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.SelectedControl = Me.radGridView1
		End Sub

		#Region "Event Handlers"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			SetPreferences()

			Me.order_DetailsTableAdapter1.Fill(Me.nwindDataSet1.Order_Details)
		End Sub

		Private Sub radButtonAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
			CType(Me.radGridView1.Columns("UnitPrice"), GridViewDataColumn).FormatString = radTextBox1.Text
			CType(Me.radGridView1.Columns("Discount"), GridViewDataColumn).FormatString = radTextBox1.Text
			CType(Me.radGridView1.Columns("OrderID"), GridViewDataColumn).FormatString = radTextBox1.Text
		End Sub

		Private Sub checkBoxFormatting_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Dim discount As GridViewDataColumn = CType(Me.radGridView1.Columns("Discount"), GridViewDataColumn)
			Dim orderId As GridViewDataColumn = CType(Me.radGridView1.Columns("OrderID"), GridViewDataColumn)
			Dim unitPrice As GridViewDataColumn = CType(Me.radGridView1.Columns("UnitPrice"), GridViewDataColumn)

			If Me.radCheckPercent.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				discount.FormatString = "{0:0.00%;0.00%;none}"
			Else
				discount.FormatString = ""
			End If

			If Me.radCheckID.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				orderId.FormatString = "#{0}"
			Else
				orderId.FormatString = ""
			End If

			If Me.radCheckPrice.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				unitPrice.FormatString = "${0}"
			Else
				unitPrice.FormatString = ""
			End If
		End Sub
		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radButtonAdd.Click, AddressOf radButtonAdd_Click
			AddHandler radCheckPrice.ToggleStateChanged, AddressOf checkBoxFormatting_ToggleStateChanged
			AddHandler radCheckID.ToggleStateChanged, AddressOf checkBoxFormatting_ToggleStateChanged
			AddHandler radCheckPercent.ToggleStateChanged, AddressOf checkBoxFormatting_ToggleStateChanged
		End Sub
	End Class
End Namespace
