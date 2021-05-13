Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.Examples.WinControls.Editors

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.AutoComplete
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private dropDownShowTimeOut As Timer

		Public Sub New()
			InitializeComponent()

			Me.dropDownShowTimeOut = New Timer(Me.components)
			Me.dropDownShowTimeOut.Interval = 1000
			AddHandler dropDownShowTimeOut.Tick, AddressOf dropDownShowTimeOut_Tick
			Me.components.Add(Me.dropDownShowTimeOut)
			Me.SelectedControl = radComboDemo
			Me.radComboAutoCompl.SelectedText = Me.radComboDemo.AutoCompleteMode.ToString()
			Me.radComboDemo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.radComboDemo.DropDownListElement.AutoCompleteAppend.LimitToList = True
			AddHandler radComboDemo.SelectedIndexChanged, AddressOf radComboDemo_SelectedIndexChanged
		End Sub

		Private Sub radComboDemo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			UpdateDropDown(sender, e)
		End Sub

		#Region "Event handling"

		Private Sub OnAutoCompleteMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim selectedItem As RadListDataItem = Me.radComboAutoCompl.SelectedItem

			If selectedItem Is Nothing Then
				Return
			End If

			Select Case selectedItem.Text
				Case "None"
					Me.radComboDemo.AutoCompleteMode = AutoCompleteMode.None
				Case "Suggest"
					Me.radComboDemo.AutoCompleteMode = AutoCompleteMode.Suggest
				Case "Append"
					Me.radComboDemo.AutoCompleteMode = AutoCompleteMode.Append
				Case "SuggestAppend"
					Me.radComboDemo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
			End Select
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radComboAutoCompl.SelectedIndex = 3
			Me.dropDownShowTimeOut.Start()
			Me.radComboDemo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.radComboDemo.DropDownListElement.AutoCompleteAppend.LimitToList = True
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radBtnAdd.Click, AddressOf btnAdd_Click
			AddHandler radBtnRemove.Click, AddressOf btnRemove_Click
			AddHandler radTxtText.TextChanged, AddressOf radTxtText_TextChanged
			AddHandler radCheckCaseSens.ToggleStateChanged, AddressOf chBoxCaseSensitive_CheckedChanged
			AddHandler radComboAutoCompl.SelectedIndexChanged, AddressOf OnAutoCompleteMode_SelectedIndexChanged
		End Sub

		Private Sub radComboAutoCompleteMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			radComboDemo.AutoCompleteMode = CType(radComboAutoCompl.SelectedIndex, AutoCompleteMode)
		End Sub

		Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim element As New RadListDataItem()
			Dim num As Integer = radComboDemo.Items.Count + 1
			element.Text = "New item " & num.ToString()
			radComboDemo.Items.Add(element)
			radComboDemo.SelectedItem = element
			UpdateDropDown(radComboDemo, EventArgs.Empty)
		End Sub

		Private Sub dropDownShowTimeOut_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radComboDemo.Focus()
			Me.radComboDemo.ShowDropDown()
			Me.dropDownShowTimeOut.Stop()

		End Sub

		Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
			If radComboDemo.SelectedIndex <> -1 Then
				radComboDemo.Items.Remove(radComboDemo.Items(radComboDemo.SelectedIndex))
				UpdateDropDown(radComboDemo, EventArgs.Empty)
			End If
		End Sub

		Private Sub radTxtText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadListDataItem = radComboDemo.SelectedItem
			If (item IsNot Nothing) AndAlso (item.Text <> radTxtText.Text) Then
				radComboDemo.SelectedItem.Text = radTxtText.Text
			End If
		End Sub

		Private Sub chBoxCaseSensitive_CheckedChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			radComboDemo.CaseSensitive = radCheckCaseSens.Checked
		End Sub

		Private Sub UpdateDropDown(ByVal sender As Object, ByVal e As EventArgs)
			If radComboDemo.SelectedIndex <> -1 Then
				radTxtIndex.Text = radComboDemo.SelectedIndex.ToString()
				Dim item As RadListDataItem = radComboDemo.SelectedItem
				radTxtText.Text = item.Text
			Else
				radTxtIndex.Text = radComboDemo.SelectedIndex.ToString()
				radTxtText.Text = ""
			End If
		End Sub
		#End Region
	End Class
End Namespace
