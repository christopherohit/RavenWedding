Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.Selection
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			SetUpCalendar()
			Me.radCalendar1.FocusedDate = Date.Now
			Me.radRadioAllowSelectEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioMultiSelectEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioEnableAllowViewSelectorEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioShowRowHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioColumnHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioAllowRowHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioAllowColumnHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

		End Sub

		Private Sub SetUpCalendar()
			Me.SelectedControl = Me.radCalendar1
			Me.radCalendar1.AllowColumnHeaderSelectors = True
			Me.radCalendar1.AllowRowHeaderSelectors = True
			Me.radCalendar1.AllowViewSelector = True
			Me.radCalendar1.AllowMultipleSelect = True
			Me.radCalendar1.ShowRowHeaders = True
		End Sub

		#Region "Event Handlers"

		Private Sub radRadioAllowSelectEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioAllowSelectEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowSelect = True
			End If

			If Me.radRadioAllowSelectDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowSelect = False
			End If
		End Sub

		Private Sub radRadioMultiSelectEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioMultiSelectEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowMultipleSelect = True
			End If

			If Me.radRadioMultiSelectDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowMultipleSelect = False
			End If
		End Sub

		Private Sub radRadioEnableAllowViewSelectorEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioEnableAllowViewSelectorEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowViewSelector = True
			End If

			If Me.radRadioEnableAllowViewSelectorDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowViewSelector = False
			End If
		End Sub

		Private Sub radRadioColumnHeaderEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioColumnHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.ShowColumnHeaders = True
			End If

			If Me.radRadioColumnHeaderDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.ShowColumnHeaders = False
			End If
		End Sub

		Private Sub radRadioRowHeaderEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioShowRowHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.ShowRowHeaders = True
			End If

			If Me.radRadioShowRowHeaderDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.ShowRowHeaders = False
			End If
		End Sub

		Private Sub radRadioAllowRowHeader_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioAllowRowHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowRowHeaderSelectors = True
			End If

			If Me.radRadioAllowRowHeaderDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowRowHeaderSelectors = False
			End If
		End Sub

		Private Sub radRadioAllowColumnHeaderEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioAllowColumnHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowColumnHeaderSelectors = True
			End If

			If Me.radRadioAllowColumnHeaderDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowColumnHeaderSelectors = False
			End If
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radCalendar1.SelectedDates.Count > 0 Then
				Me.radCalendar1.SelectedDates.Clear()
			End If
		End Sub
		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radButton1.Click, AddressOf radButton1_Click
			AddHandler radRadioAllowSelectEnable.ToggleStateChanged, AddressOf radRadioAllowSelectEnable_ToggleStateChanged
			AddHandler radRadioAllowSelectDisable.ToggleStateChanged, AddressOf radRadioAllowSelectEnable_ToggleStateChanged
			AddHandler radRadioMultiSelectEnable.ToggleStateChanged, AddressOf radRadioMultiSelectEnable_ToggleStateChanged
			AddHandler radRadioMultiSelectDisable.ToggleStateChanged, AddressOf radRadioMultiSelectEnable_ToggleStateChanged
			AddHandler radRadioShowRowHeaderEnable.ToggleStateChanged, AddressOf radRadioRowHeaderEnable_ToggleStateChanged
			AddHandler radRadioShowRowHeaderDisable.ToggleStateChanged, AddressOf radRadioRowHeaderEnable_ToggleStateChanged
			AddHandler radRadioEnableAllowViewSelectorEnable.ToggleStateChanged, AddressOf radRadioEnableAllowViewSelectorEnable_ToggleStateChanged
			AddHandler radRadioAllowRowHeaderEnable.ToggleStateChanged, AddressOf radRadioAllowRowHeader_ToggleStateChanged
			AddHandler radRadioAllowRowHeaderDisable.ToggleStateChanged, AddressOf radRadioAllowRowHeader_ToggleStateChanged
			AddHandler radRadioAllowColumnHeaderEnable.ToggleStateChanged, AddressOf radRadioAllowColumnHeaderEnable_ToggleStateChanged
			AddHandler radRadioAllowColumnHeaderDisable.ToggleStateChanged, AddressOf radRadioAllowColumnHeaderEnable_ToggleStateChanged
			AddHandler radRadioColumnHeaderEnable.ToggleStateChanged, AddressOf radRadioColumnHeaderEnable_ToggleStateChanged
			AddHandler radRadioColumnHeaderDisable.ToggleStateChanged, AddressOf radRadioColumnHeaderEnable_ToggleStateChanged
			AddHandler radRadioEnableAllowViewSelectorDisable.ToggleStateChanged, AddressOf radRadioEnableAllowViewSelectorEnable_ToggleStateChanged
		End Sub
	End Class
End Namespace