Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.SplitContainer.CollapsingPanels
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radSplitContainer1.EnableCollapsing = True
			Me.radCheckBox1.IsChecked = True

			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			ExamplesForm.FillComboFromEnum(Me.radDropDownList1, GetType(Orientation), Me.radSplitContainer1.Orientation)
			Me.radSplitContainer1.UseSplitterButtons = True
			Me.radCheckBox2.Checked = True

		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
			AddHandler radCheckBox2.ToggleStateChanged, AddressOf radCheckBox2_ToggleStateChanged
		End Sub


		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radSplitContainer1.Orientation = CType(Me.radDropDownList1.SelectedItem.Value, Orientation)
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radSplitContainer1.EnableCollapsing = Me.radCheckBox1.IsChecked
			If Me.radCheckBox1.IsChecked AndAlso Me.radCheckBox2.IsChecked Then
				Me.radSplitContainer1.UseSplitterButtons = True
			End If
		End Sub

		Private Sub radCheckBox2_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radSplitContainer1.UseSplitterButtons = Me.radCheckBox2.IsChecked
		End Sub
	End Class
End Namespace
