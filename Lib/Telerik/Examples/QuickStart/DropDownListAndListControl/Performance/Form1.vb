Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.Performance
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const itemsCount As Integer = 150000
		Private items() As String

		Public Sub New()
			InitializeComponent()

			Me.CreateBindingList(100)
			Me.radListControl1.DataSource = items
			Me.radDropDownList1.DataSource = items
			Me.radSpinEditor1.Value = itemsCount
			Me.radLabelElapsed.Text = "Press Bind Button to measure binding time with " & Me.radSpinEditor1.Value & " items."
		End Sub

		Private Sub CreateBindingList(ByVal count As Integer)
			items = New String(count - 1){}
			For i As Integer = 0 To count - 1
				items(i) = "Item " & i
			Next i
		End Sub

		Private Sub button_Bind_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim stopWatch As New Stopwatch()
			stopWatch.Start()
			Me.CreateBindingList(CInt(Fix(Me.radSpinEditor1.Value)))
			stopWatch.Stop()
			Me.radLabelElapsed.Text = "Time needed to create the BindingList: " & stopWatch.ElapsedMilliseconds & " ms"
			stopWatch.Reset()
			stopWatch.Start()
			Me.radListControl1.DataSource = items
			stopWatch.Stop()
			Me.radLabelElapsedListControl.Text = "Time needed to databind RadListControl: " & stopWatch.ElapsedMilliseconds & " ms"
			stopWatch.Reset()
			stopWatch.Start()
			Me.radDropDownList1.DataSource = items
			Me.radDropDownList1.ShowDropDown()
			stopWatch.Stop()
			Me.radLabelElapsedDropDownList.Text = "Time neededto databind RadDropDownList: " & stopWatch.ElapsedMilliseconds & " ms"

			Me.button_Bind.Text = "Bind Again"
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radLabelElapsed.Text = "Press the Bind button to measure the binding time with " & Me.radSpinEditor1.Value & " items."
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler button_Bind.Click, AddressOf button_Bind_Click
			AddHandler radSpinEditor1.ValueChanged, AddressOf radSpinEditor1_ValueChanged
		End Sub
	End Class
End Namespace
