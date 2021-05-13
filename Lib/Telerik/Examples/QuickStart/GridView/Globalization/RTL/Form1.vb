Imports System.Collections
Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.GridView.Globalization.RTL
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)

			Me.radGridView1.MasterTemplate.Columns(0).VisibleInColumnChooser = False
			Me.radGridView1.MasterTemplate.Columns(1).AllowGroup = False

			Me.radToggleButton1.ToggleState = ToggleState.On
		End Sub

		Private Sub radToggleButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radToggleButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.RightToLeft = RightToLeft.Yes
			Else
				Me.radGridView1.RightToLeft = RightToLeft.No
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radToggleButton1.ToggleStateChanged, AddressOf radToggleButton1_ToggleStateChanged
		End Sub
	End Class
End Namespace
