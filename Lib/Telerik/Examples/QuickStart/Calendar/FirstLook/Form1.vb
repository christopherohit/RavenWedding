Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.FirstLook
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()
            Me.radCalendar1.HeaderNavigationMode = Telerik.WinControls.UI.HeaderNavigationMode.Zoom
            Me.SelectedControl = Me.radCalendar1
            Me.radioButton16.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            Me.radCalendar1.ShowFooter = False
        End Sub

#Region "Event Handlers"

        Private Sub chRowHeader_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCalendar1.ShowRowHeaders = Not (Me.chRowHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        End Sub

        Private Sub chColumnHeader_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCalendar1.ShowColumnHeaders = Not (Me.chColumnHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        End Sub

        Private Sub chShowSelector_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCalendar1.ShowViewSelector = Not (Me.chShowSelector.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        End Sub

        Private Sub chNavigationButtons_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCalendar1.ShowNavigationButtons = Not (Me.chNavigationButtons.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        End Sub

        Private Sub chFastNavigationButtons_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCalendar1.ShowFastNavigationButtons = Not (Me.chFastNavigationButtons.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        End Sub

        Private Sub chViewHeader_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCalendar1.ShowViewHeader = Not (Me.chViewHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        End Sub

        Private Sub chAllowFishEye_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCalendar1.AllowFishEye = Not (Me.chAllowFishEye.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        End Sub

        Private Sub nudHeaderWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCalendar1.HeaderWidth = CInt(Fix(Me.nudHeaderWidth.Value))
        End Sub

        Private Sub nudHeaderHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCalendar1.HeaderHeight = CInt(Fix(Me.nudHeaderHeight.Value))
        End Sub

        Private Sub cbTitleFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radCalendar1.TitleFormat = Me.cbTitleFormat.Items(Me.cbTitleFormat.SelectedIndex).Text
        End Sub

        Private Sub radCheckBox2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCalendar1.ShowHeader = Not (Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        End Sub

        Private Sub radCheckBox3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim rightToLeft As Boolean = Not (Me.radCheckBox3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)

            If rightToLeft Then
                Me.radCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Else
                Me.radCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.No
            End If
        End Sub

        Private Sub radioButton16_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            If Me.radioButton16.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Me.radCalendar1.Orientation = Orientation.Horizontal
            End If
        End Sub

        Private Sub radioButton15_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            If Me.radioButton15.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Me.radCalendar1.Orientation = Orientation.Vertical
            End If
        End Sub
#End Region

        Protected Overrides Sub WireEvents()
            AddHandler radCheckBox2.Click, AddressOf radCheckBox2_Click
            AddHandler cbTitleFormat.SelectedIndexChanged, AddressOf cbTitleFormat_SelectedIndexChanged
            AddHandler radCheckBox3.Click, AddressOf radCheckBox3_Click
            AddHandler chShowSelector.Click, AddressOf chShowSelector_Click
            AddHandler chRowHeader.Click, AddressOf chRowHeader_Click
            AddHandler chColumnHeader.Click, AddressOf chColumnHeader_Click
            AddHandler chNavigationButtons.Click, AddressOf chNavigationButtons_Click
            AddHandler chFastNavigationButtons.Click, AddressOf chFastNavigationButtons_Click
            AddHandler chViewHeader.Click, AddressOf chViewHeader_Click
            AddHandler chAllowFishEye.Click, AddressOf chAllowFishEye_Click
            AddHandler nudHeaderHeight.ValueChanged, AddressOf nudHeaderHeight_ValueChanged
            AddHandler nudHeaderWidth.ValueChanged, AddressOf nudHeaderWidth_ValueChanged
            AddHandler radioButton16.ToggleStateChanged, AddressOf radioButton16_ToggleStateChanged
            AddHandler radioButton15.ToggleStateChanged, AddressOf radioButton15_ToggleStateChanged
        End Sub
    End Class
End Namespace