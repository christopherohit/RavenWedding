Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TrackStatusControls.WaitingBar.Conventional
    Partial Public Class Form1
        Inherits ExamplesForm
        Private [step] As Integer

        Public Sub New()
            InitializeComponent()

            Me.FillDropDownList()
            AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
        End Sub

        Private Sub FillDropDownList()
            Dim oldStyles As WaitingBarStyles() = New WaitingBarStyles(2) {}
            oldStyles(0) = WaitingBarStyles.Indeterminate
            oldStyles(1) = WaitingBarStyles.Throbber
            oldStyles(2) = WaitingBarStyles.Dash
            For Each style As WaitingBarStyles In oldStyles
                Dim item As New RadListDataItem(style.ToString(), style)
                Me.radDropDownList1.Items.Add(item)
            Next

            Me.radDropDownList1.SelectedIndex = 0
        End Sub

        Private Sub ShowWarningBox()

            If Object.Equals(Me.radDropDownList1.SelectedItem.Value, WaitingBarStyles.Dash) Then
                [step] = CInt((radWaitingBar1.WaitingBarElement.SeparatorElement.StepWidth + Me.radWaitingBar1.WaitingBarElement.SeparatorElement.SeparatorWidth) / 2)
                If Me.radSpinEditor1.Value >= [step] Then
                    RadMessageBox.Show(Me, "The selected Waiting Step value is not meaningful in Dash style! Please input a value less than " & [step].ToString() & ".", "Change Waiting Step Value")
                End If
                If Me.radSpinEditor1.Value >= [step] Then
                    Me.radSpinEditor1.Value = [step] - 1
                End If
            End If
        End Sub

        Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Dim style As WaitingBarStyles = CType(Me.radDropDownList1.SelectedItem.Value, WaitingBarStyles)
            Me.radWaitingBar1.WaitingStyle = style
            Me.radWaitingBar2.WaitingStyle = style
            Me.radWaitingBar3.WaitingStyle = style
            Me.radWaitingBar4.WaitingStyle = style
            ShowWarningBox()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Me.radWaitingBar1.StartWaiting()
            Me.radWaitingBar2.StartWaiting()
            Me.radWaitingBar3.StartWaiting()
            Me.radWaitingBar4.StartWaiting()
        End Sub

        Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radWaitingBar1.StartWaiting()
            Me.radWaitingBar2.StartWaiting()
            Me.radWaitingBar3.StartWaiting()
            Me.radWaitingBar4.StartWaiting()
        End Sub

        Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radWaitingBar1.StopWaiting()
            Me.radWaitingBar2.StopWaiting()
            Me.radWaitingBar3.StopWaiting()
            Me.radWaitingBar4.StopWaiting()
        End Sub

        Private Sub radButton3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radWaitingBar1.ResetWaiting()
            Me.radWaitingBar2.ResetWaiting()
            Me.radWaitingBar3.ResetWaiting()
            Me.radWaitingBar4.ResetWaiting()
        End Sub

        Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim [step] As Integer = Convert.ToInt32(Me.radSpinEditor1.Value)
            Me.radWaitingBar1.WaitingStep = [step]
            Me.radWaitingBar2.WaitingStep = [step]
            Me.radWaitingBar3.WaitingStep = [step]
            Me.radWaitingBar4.WaitingStep = [step]
            ShowWarningBox()
        End Sub

        Private Sub radSpinEditor2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim speed As Integer = Convert.ToInt32(Me.radSpinEditor2.Value)
            Me.radWaitingBar1.WaitingSpeed = speed
            Me.radWaitingBar2.WaitingSpeed = speed
            Me.radWaitingBar3.WaitingSpeed = speed
            Me.radWaitingBar4.WaitingSpeed = speed
        End Sub

        Private Sub radToggleButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Me.radWaitingBar1.ShowText = True
                Me.radWaitingBar2.ShowText = True
                Me.radWaitingBar3.ShowText = True
                Me.radWaitingBar4.ShowText = True
            Else
                Me.radWaitingBar1.ShowText = False
                Me.radWaitingBar2.ShowText = False
                Me.radWaitingBar3.ShowText = False
                Me.radWaitingBar4.ShowText = False
            End If
        End Sub

        Private Sub radToggleButton2_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Me.radWaitingBar1.RightToLeft = RightToLeft.Yes
                Me.radWaitingBar2.RightToLeft = RightToLeft.Yes
                Me.radWaitingBar3.RightToLeft = RightToLeft.Yes
                Me.radWaitingBar4.RightToLeft = RightToLeft.Yes
            Else
                Me.radWaitingBar1.RightToLeft = RightToLeft.No
                Me.radWaitingBar2.RightToLeft = RightToLeft.No
                Me.radWaitingBar3.RightToLeft = RightToLeft.No
                Me.radWaitingBar4.RightToLeft = RightToLeft.No
            End If
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler radToggleButton2.ToggleStateChanged, AddressOf radToggleButton2_ToggleStateChanged
            AddHandler radToggleButton1.ToggleStateChanged, AddressOf radToggleButton1_ToggleStateChanged
            AddHandler radSpinEditor2.ValueChanged, AddressOf radSpinEditor2_ValueChanged
            AddHandler radSpinEditor1.ValueChanged, AddressOf radSpinEditor1_ValueChanged
            AddHandler radButton3.Click, AddressOf radButton3_Click
            AddHandler radButton2.Click, AddressOf radButton2_Click
            AddHandler radButton1.Click, AddressOf radButton1_Click

        End Sub
    End Class
End Namespace
