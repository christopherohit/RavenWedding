Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Events
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private showDropDownTimeout As Timer

		Public Sub New()
			InitializeComponent()
			AddHandler Me.radComboDropDownStyle.SelectedIndexChanged, AddressOf comboDropDownStyle_SelectedIndexChanged
			AddHandler Me.radComboSort.SelectedIndexChanged, AddressOf radComboSort_SelectedIndexChanged

			AddHandler Me.radComboDemo.PopupClosing, AddressOf radComboDemo_DropDownClosing
			AddHandler Me.radComboDemo.PopupClosed, AddressOf radComboDemo_DropDownClosed
			AddHandler Me.radComboDemo.PopupOpening, AddressOf radComboDemo_DropDownOpening
			AddHandler Me.radComboDemo.PopupOpened, AddressOf radComboDemo_DropDownOpened
			AddHandler Me.radComboDemo.SelectedIndexChanged, AddressOf radComboDemo_SelectedIndexChanged
			AddHandler Me.radComboDemo.SortStyleChanged, AddressOf radComboDemo_SortedChanged
			AddHandler Me.radComboDemo.TextChanged, AddressOf radComboDemo_TextChanged
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radComboSort.SelectedText = "None"
			Me.radComboDropDownStyle.SelectedIndex = 0
			Me.SelectedControl = Me.radComboDemo

			Me.showDropDownTimeout = New Timer(Me.components)
			AddHandler showDropDownTimeout.Tick, AddressOf showDropDownTimeout_Tick
			Me.showDropDownTimeout.Interval = 1000
			Me.showDropDownTimeout.Start()
		End Sub

		Private Sub showDropDownTimeout_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radComboDemo.Focus()
			Me.radComboDemo.ShowDropDown()
			Me.showDropDownTimeout.Stop()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckCase.ToggleStateChanged, AddressOf chBoxCaseSensitive_CheckedChanged
		End Sub

		Private Sub comboDropDownStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			If e.Position = -1 Then
				Return
			End If

			Me.radComboDemo.DropDownStyle = CType(System.Enum.Parse(GetType(RadDropDownStyle), Me.radComboDropDownStyle.SelectedItem.Text), RadDropDownStyle)
		End Sub

		Private Sub radComboSort_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			If e.Position = -1 Then
				Return
			End If

			Me.radComboDemo.SortStyle = CType(System.Enum.Parse(GetType(SortStyle), Me.radComboSort.SelectedItem.Text), SortStyle)
		End Sub

		Private Sub radComboDemo_DropDownOpened(ByVal sender As Object, ByVal e As EventArgs)
			ShowEventMessage("DropDownOpened")
		End Sub

		Private Sub radComboDemo_DropDownClosed(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RadPopupClosedEventArgs)
			ShowEventMessage("DropDownClosed")
		End Sub

		Private Sub radComboDemo_DropDownClosing(ByVal sender As Object, ByVal args As RadPopupClosingEventArgs)
			ShowEventMessage("DropDownClosing")
		End Sub

		Private Sub radComboDemo_DropDownOpening(ByVal sender As Object, ByVal args As CancelEventArgs)
			ShowEventMessage("DropDownOpening")
		End Sub

		Private Sub radComboDemo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			ShowEventMessage("SelectedIndexChanged")
		End Sub

		Private Sub radComboDemo_SortedChanged(ByVal sender As Object, ByVal e As EventArgs)
			ShowEventMessage("SortedChanged")
		End Sub

		Private Sub radComboDemo_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			ShowEventMessage("TextChanged")
		End Sub

		Private Sub ShowEventMessage(ByVal eventName As String)
			Me.radTxtEvents.Text += String.Format("{0} fired" & Environment.NewLine, eventName)
			Me.radTxtEvents.SelectionStart = Me.radTxtEvents.Text.Length
			Me.radTxtEvents.ScrollToCaret()
		End Sub

		Private Sub chBoxCaseSensitive_CheckedChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			radComboDemo.CaseSensitive = Me.radCheckCase.Checked
		End Sub
	End Class
End Namespace