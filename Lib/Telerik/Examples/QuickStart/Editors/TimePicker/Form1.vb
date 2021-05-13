Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls.UI
Imports Microsoft.Win32

Namespace Telerik.Examples.WinControls.Editors.TimePicker
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private timer As New Timer()

		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radTimePicker1
			Me.radTimePicker2.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 4, 20, 0)
			Me.radTimePicker3.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 20, 45, 0)
			Me.radTimePicker1.TimePickerElement.MinValue = CDate(Me.radTimePicker2.Value)
			Me.radTimePicker1.TimePickerElement.MaxValue = CDate(Me.radTimePicker3.Value)

			AddHandler radTimePicker1.Validated, AddressOf radTimePicker1_Validated
			Me.radClock1.ShowSystemTime = False

			AddHandler timer.Tick, AddressOf timer_Tick
			timer.Interval = 1000
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radTimePicker1.ValueChanged, AddressOf radTimePicker1_ValueChanged
			AddHandler TablesDropDownList.SelectedIndexChanged, AddressOf TablesDropDownList_SelectedIndexChanged
			AddHandler ClockPossitionDropDownList.SelectedIndexChanged, AddressOf ClockPossitionDropDownList_SelectedIndexChanged
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
			AddHandler Disposed, AddressOf Form1_Disposed
			AddHandler radPageView1.SelectedPageChanging, AddressOf radPageView1_SelectedPageChanging
			AddHandler radTimePicker2.ValueChanged, AddressOf radTimePicker2_ValueChanged
			AddHandler radTimePicker3.ValueChanged, AddressOf radTimePicker3_ValueChanged
		End Sub

		Private Sub radTimePicker2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radTimePicker1.TimePickerElement.MinValue = CDate(Me.radTimePicker2.Value)
		End Sub

		Private Sub radTimePicker3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radTimePicker1.TimePickerElement.MaxValue = CDate(Me.radTimePicker3.Value)
		End Sub

		Private Sub SynchronizeTime()
			If Me.radClock1.Value Is Nothing Then
				Me.radClock1.Value = Date.Now
			End If

			Dim currentTime As Date = Me.radClock1.Value.Value
			currentTime = currentTime.AddSeconds(1)
			Me.radLabelDate.Text = currentTime.ToLongDateString()
			Me.radClock1.Value = currentTime
			If Me.radTimePicker1.Value Is Nothing Then
				Me.radTimePicker1.Value = Date.Now
			End If
			If Me.radTimePicker1.Value < Me.radTimePicker1.TimePickerElement.MinValue OrElse Me.radTimePicker1.Value > Me.radTimePicker1.TimePickerElement.MinValue Then
				Return
			End If
			If Me.radTimePicker1.Value.Value.Minute <> currentTime.Minute OrElse Me.radTimePicker1.Value.Value.Hour <> currentTime.Hour Then
				Me.radTimePicker1.Value = currentTime
			End If
		End Sub

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			SynchronizeTime()
		End Sub

		Private Sub radPageView1_SelectedPageChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RadPageViewCancelEventArgs)
			e.Cancel = True
		End Sub

		Private Sub radTimePicker1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radTimePicker1.Value >= Me.radTimePicker1.TimePickerElement.MinValue AndAlso Me.radTimePicker1.Value <= Me.radTimePicker1.TimePickerElement.MinValue Then
				Me.radClock1.Value = Me.radTimePicker1.Value
			End If
		End Sub

		Private Sub radTimePicker1_Validated(ByVal sender As Object, ByVal e As EventArgs)
			Me.radClock1.Value = Me.radTimePicker1.Value
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTimePicker1.ReadOnly = Me.radCheckBox1.IsChecked
		End Sub

		Private Sub TablesDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radTimePicker1.TimeTables = CType(e.Position, TimeTables)
		End Sub

		Private Sub ClockPossitionDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radTimePicker1.ClockPosition = CType(e.Position, ClockPosition)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			TablesDropDownList.SelectedIndex = 1
			ClockPossitionDropDownList.SelectedIndex = 0

			Dim currentTime As Date = Date.Now
			Me.radTimePicker1.Value = currentTime

			SynchronizeTime()
			timer.Start()

			Try
				Dim timeZoneInfoKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\TimeZoneInformation")
				If timeZoneInfoKey IsNot Nothing Then
					Dim timeZoneKeyName As Object = timeZoneInfoKey.GetValue("TimeZoneKeyName")
					If timeZoneKeyName IsNot Nothing Then
                        Dim timeZoneNameKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Time Zones\" & timeZoneKeyName.ToString())
						If timeZoneKeyName IsNot Nothing Then
							Dim displayName As Object = timeZoneNameKey.GetValue("Display")
							If displayName IsNot Nothing Then
								radLabelTimeZone.Text = displayName.ToString()
								Return
							End If
						End If
					End If
				End If

				Dim localZone As TimeZone = TimeZone.CurrentTimeZone
				Dim hours As Integer = localZone.GetUtcOffset(currentTime).Hours
				radLabelTimeZone.Text = "UTC" & (If(hours > 0, "+", "-")) + Math.Abs(hours).ToString()
			Catch
			End Try
			Me.radTimePicker1.Value = Nothing
		End Sub

		Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As EventArgs)
			timer.Stop()
			timer.Dispose()
		End Sub
	End Class
End Namespace
