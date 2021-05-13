Imports System
Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.Editors

Namespace Telerik.Examples.WinControls.VirtualKeyboard.FirstLook
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Private focusedControl As Control = Nothing

        Public Sub New()
            Me.InitializeComponent()
            Me.CenterPanel = True
            Me.radPanelDemoHolder.PanelElement.Padding = New Padding(0)
            Me.focusedControl = Me.radTextBoxTitle
        End Sub

        Protected Overrides Sub WireEvents()
            MyBase.WireEvents()
            AddHandler Me.radTextBoxTitle.GotFocus, AddressOf Me.RadTextBoxTitle_GotFocus
            AddHandler Me.radTextBoxDescription.GotFocus, AddressOf Me.RadTextBoxTitle_GotFocus
            AddHandler Me.radVirtualKeyboard1.MouseDown, AddressOf Me.RadVirtualKeyboard1_MouseDown
        End Sub

        Private Sub RadTextBoxTitle_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
            Me.focusedControl = TryCast(sender, Control)

            If Not Me.radToggleSwitchEnableKeyboard.Value Then
                Me.radToggleSwitchEnableKeyboard.Value = True
            End If
        End Sub

        Private Sub RadVirtualKeyboard1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.focusedControl.Focus()
        End Sub

        Private Sub ToggleKeyboardToggleSwitch_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radToggleSwitchEnableKeyboard.ValueChanged
            Me.radVirtualKeyboard1.Visible = Me.radToggleSwitchEnableKeyboard.Value
        End Sub

        Private Sub SubmitButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonSubmit.Click
            Me.radTextBoxTitle.Clear()
            Me.radTextBoxDescription.Clear()
            Me.radTextBoxTitle.Focus()
        End Sub
    End Class
End Namespace