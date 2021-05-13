Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Editors.DateTimePicker.FirstLook

    Partial Public Class Form1
        Inherits EditorExampleBaseForm
        Public Sub New()
            InitializeComponent()

            Me.SelectedControl = Me.radDateTimePicker1

            Me.radDateTimePicker3.DateTimePickerElement.ShowCurrentTime = False
            Me.radDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Custom]
            Me.radDateTimePicker3.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radDateTimePicker3.CustomFormat = "hh:mm:ss tt"
            Me.radRadio12Hours.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

            ' by default en-CA culture has AM/PM time format, so the timepicker can have correct hour scales
            Me.radDateTimePicker4.Culture = New System.Globalization.CultureInfo("en-CA")
            Me.radDateTimePicker4.Format = DateTimePickerFormat.[Custom]
            Me.radDateTimePicker4.CustomFormat = "MMM - dd - yyyy hh:mm tt"
            TryCast(Me.radDateTimePicker4.DateTimePickerElement.CurrentBehavior, RadDateTimePickerCalendar).ShowTimePicker = True
            TryCast(Me.radDateTimePicker4.DateTimePickerElement.CurrentBehavior, RadDateTimePickerCalendar).DropDownMinSize = New Size(330, 250)

            Me.radDateTimePicker6.Culture = PersianCultureHelper.GetFixedPersianCulture()

            For Each control As Control In Me.doubleBufferedTableLayoutPanel1.Controls
                If TypeOf control Is RadLabel Then
                    control.Anchor = AnchorStyles.Right
                Else
                    control.Anchor = AnchorStyles.Left
                End If

            Next control
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler Me.radBtnClearAll.Click, AddressOf Me.radButton1_Click
            AddHandler Me.radRadio24Hours.ToggleStateChanged, AddressOf Me.OnRadRadioHourFormat_ToggleStateChanged
            AddHandler Me.radRadio12Hours.ToggleStateChanged, AddressOf Me.OnRadRadioHourFormat_ToggleStateChanged
        End Sub

        Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radDateTimePicker1.SetToNullValue()
            Me.radDateTimePicker2.SetToNullValue()
            Me.radDateTimePicker3.SetToNullValue()
            Me.radDateTimePicker4.SetToNullValue()
            Me.radDateTimePicker5.SetToNullValue()
            Me.radDateTimePicker6.SetToNullValue()
            Me.radDateTimePicker7.SetToNullValue()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Me.radDateTimePicker1.Value = DateTime.Now
            Me.radDateTimePicker2.Value = DateTime.Now
            Me.radDateTimePicker3.Value = DateTime.Now
            Me.radDateTimePicker4.Value = DateTime.Now
            Me.radDateTimePicker5.Value = DateTime.Now
            Me.radDateTimePicker6.Value = DateTime.Now
            Me.radDateTimePicker7.Value = DateTime.Now
        End Sub

        Private Sub OnRadRadioHourFormat_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Dim culture As New System.Globalization.CultureInfo("en-CA")
            If Me.radRadio12Hours.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Me.radDateTimePicker3.CustomFormat = "hh:mm:ss  tt"
                Me.radDateTimePicker4.CustomFormat = "MMM - dd - yyyy hh:mm tt"
                TryCast(Me.radDateTimePicker4.DateTimePickerElement.CurrentBehavior, RadDateTimePickerCalendar).DropDownMinSize = New Size(330, 250)
                TryCast(Me.radDateTimePicker4.DateTimePickerElement.CurrentBehavior, RadDateTimePickerCalendar).DropDownMaxSize = New Size(330, 250)
            Else
                Dim dateTimeFormat As New System.Globalization.DateTimeFormatInfo()
                dateTimeFormat.AMDesignator = String.Empty
                dateTimeFormat.PMDesignator = String.Empty
                culture.DateTimeFormat = dateTimeFormat
                TryCast(Me.radDateTimePicker4.DateTimePickerElement.CurrentBehavior, RadDateTimePickerCalendar).DropDownMinSize = New Size(330, 320)
                TryCast(Me.radDateTimePicker4.DateTimePickerElement.CurrentBehavior, RadDateTimePickerCalendar).DropDownMaxSize = New Size(330, 320)
                Me.radDateTimePicker3.CustomFormat = "HH:mm:ss"
                Me.radDateTimePicker4.CustomFormat = "MMM - dd - yyyy HH:mm"
            End If

            Me.radDateTimePicker4.Culture = culture
        End Sub
    End Class
End Namespace