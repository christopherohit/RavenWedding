Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Calendar.Navigation
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radCalendar1.MultiViewColumns = 1
			Me.radCalendar1.MultiViewColumns = 2

			Me.SelectedControl = Me.radCalendar1

			Me.radCalendar1.RangeMinDate = Me.radDateTimePicker1.Value
			Me.radCalendar1.RangeMaxDate = Me.radDateTimePicker2.Value
			Me.radDateTimePicker3.Value = Date.Now

			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			ExamplesForm.FillComboFromEnum(Me.radDropDownList1, GetType(HeaderNavigationMode), Me.radCalendar1.HeaderNavigationMode)
			Me.radDropDownList1.SelectedIndex = 2
			Me.radCalendar1.HeaderNavigationMode = HeaderNavigationMode.Zoom
			Me.radSpinEditor1.Enabled = False
		End Sub

		Private Sub radCheckBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCalendar1.ShowNavigationButtons = Not(Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub radCheckBox2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCalendar1.ShowFastNavigationButtons = Not(Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub radCheckBox3_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCalendar1.ShowHeader = Not(Me.radCheckBox3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub radDateTimePicker1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCalendar1.RangeMinDate = Me.radDateTimePicker1.Value
		End Sub

		Private Sub radDateTimePicker2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCalendar1.RangeMaxDate = Me.radDateTimePicker2.Value
		End Sub

		Private Sub radDateTimePicker3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCalendar1.FocusedDate = Me.radDateTimePicker3.Value
		End Sub

		Private Sub radSpinNavigationStep_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCalendar1.FastNavigationStep = CInt(Fix(Me.radSpinNavigationStep.Value))
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radCalendar1.HeaderNavigationMode = CType(Me.radDropDownList1.SelectedItem.Value, HeaderNavigationMode)
			If Me.radCalendar1.HeaderNavigationMode = HeaderNavigationMode.Popup Then
				Me.radSpinEditor1.Enabled = True
			Else
				Me.radSpinEditor1.Enabled = False
			End If
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCalendar1.CalendarElement.MonthStep = CInt(Fix(Me.radSpinEditor1.Value))
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radCalendar1.RangeMinDate = Me.radDateTimePicker1.Value
			Me.radCalendar1.RangeMaxDate = Me.radDateTimePicker2.Value
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckBox1.Click, AddressOf radCheckBox1_Click
			AddHandler radCheckBox2.Click, AddressOf radCheckBox2_Click
			AddHandler radCheckBox3.Click, AddressOf radCheckBox3_Click
			AddHandler radDateTimePicker3.ValueChanged, AddressOf radDateTimePicker3_ValueChanged
			AddHandler radDateTimePicker2.ValueChanged, AddressOf radDateTimePicker2_ValueChanged
			AddHandler radSpinNavigationStep.ValueChanged, AddressOf radSpinNavigationStep_ValueChanged
			AddHandler radDateTimePicker1.ValueChanged, AddressOf radDateTimePicker1_ValueChanged
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
			AddHandler radSpinEditor1.ValueChanged, AddressOf radSpinEditor1_ValueChanged
		End Sub


	End Class
End Namespace