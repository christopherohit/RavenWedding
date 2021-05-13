Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.LayoutCustomization
	Partial Public Class Form1
		Inherits ExamplesForm
        Private defaultSize1 As Size

        Public Sub New()
			InitializeComponent()

            Me.defaultSize1 = Me.radCalendar1.Size
            Me.radRadio7Cols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		#Region "Event Handlers"
		Private Sub radRadioButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If Me.radRadio7Cols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_7columns_x_6rows
				Me.radCalendar1.Size = Me.defaultSize
			End If

			If Me.radRadio14Cols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_14columns_x_3rows
				Me.radCalendar1.Size = New Size(Me.defaultSize.Width * 2, Me.defaultSize.Height \ 2 + 20)
			End If

			If Me.radRadio21Cols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_21columns_x_2rows
				Me.radCalendar1.Size = New Size(Me.defaultSize.Width * 3-20, Me.defaultSize.Height \ 2 + 10)
			End If
		End Sub
		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radRadio7Cols.ToggleStateChanged, AddressOf radRadioButton1_ToggleStateChanged
			AddHandler radRadio21Cols.ToggleStateChanged, AddressOf radRadioButton1_ToggleStateChanged
			AddHandler radRadio14Cols.ToggleStateChanged, AddressOf radRadioButton1_ToggleStateChanged
		End Sub
	End Class
End Namespace