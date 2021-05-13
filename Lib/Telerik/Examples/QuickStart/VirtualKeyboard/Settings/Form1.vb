Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.VirtualKeyboard

Namespace Telerik.Examples.WinControls.VirtualKeyboard.Settings
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Public Sub New()
            Me.InitializeComponent()
            Me.AddDropDownItems()
            Me.CenterPanel = True
            Me.radVirtualKeyboard1.Focusable = True
            Me.radRadioButtonDvorak.IsChecked = True
            Me.radCheckBoxScaleFont.ButtonElement.ToolTipText = "Determines whether the Font of keys will be scaled when the keyboard control is resized to a different from the default key size."
        End Sub

        Private Sub AddDropDownItems()
            Dim i As Single = 0.75F

            While i <= 2.0F
                Dim item As RadListDataItem = New RadListDataItem(i.ToString(), i)
                Me.radDropDownListScaleFactor.Items.Add(item)
                i += 0.25F
            End While

            Me.radDropDownListScaleFactor.SelectedValue = 1.0F
        End Sub

        Private Sub RadCheckBoxScaleFont_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxScaleFont.ToggleStateChanged
            Me.radVirtualKeyboard1.ScaleFontOnResize = Me.radCheckBoxScaleFont.IsChecked
            Me.AutoSizeKeyboard()
        End Sub

        Private Sub RadCheckBoxSyncWithSystem_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxSyncWithSystem.ToggleStateChanged
            Me.radVirtualKeyboard1.SynchronizeCultureWithSystem = Me.radCheckBoxSyncWithSystem.IsChecked
        End Sub

        Private Sub RadButtonClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonClear.Click
            Me.radListControlSentKeys.Items.Clear()
        End Sub

        Private Sub RadVirtualKeyboard1_KeySending(ByVal sender As Object, ByVal e As VirtualKeyboardKeySendingEventArgs) Handles radVirtualKeyboard1.KeySending
            Dim item As RadListDataItem = New RadListDataItem()
            Dim text As String = (TryCast(e.Key, RadItem)).Text
            item.Text = String.Format("Key sending: Key: {0} | Code:{1}", text, e.VirtualKey)
            Me.radListControlSentKeys.Items.Add(item)
            Me.radListControlSentKeys.ScrollToItem(item)

            If e.VirtualKey = CInt(Keys.Enter) Then
                e.Cancel = True
                item = New RadListDataItem()
                item.Text = String.Format("Key {0} cancelled.", text)
                Me.radListControlSentKeys.Items.Add(item)
                Me.radListControlSentKeys.ScrollToItem(item)
            End If
        End Sub

        Private Sub RadVirtualKeyboard1_KeySent(ByVal sender As Object, ByVal e As VirtualKeyboardKeySentEventArgs) Handles radVirtualKeyboard1.KeySent
            Dim item As RadListDataItem = New RadListDataItem()
            item.Text = String.Format("Key sent: Key: {0} | Code:{1}", (TryCast(e.Key, RadItem)).Text, e.VirtualKey)
            Me.radListControlSentKeys.Items.Add(item)
            Me.radListControlSentKeys.ScrollToItem(item)
        End Sub

        Private checkedButton As RadRadioButton = Nothing

        Private Sub RadRadioButtonDvorak_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButtonDvorak.ToggleStateChanged
            If Not Me.radRadioButtonDvorak.IsChecked Then
                Return
            End If

            Dim file As String = "dvorak-layout.xml"

            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(file)
                Me.radVirtualKeyboard1.LoadLayout(stream)
                Me.radVirtualKeyboard1.ScaleFontOnResize = Me.radCheckBoxScaleFont.IsChecked
                Me.AutoSizeKeyboard()
            End Using

            Me.radLabelLayoutType.Text = "Dvorak Layout"
            Me.checkedButton = TryCast(sender, RadRadioButton)
        End Sub

        Private Sub RadRadioButtonColemak_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButtonColemak.ToggleStateChanged
            If Not Me.radRadioButtonColemak.IsChecked Then
                Return
            End If

            Dim file As String = "colemak-layout.xml"

            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(file)
                Me.radVirtualKeyboard1.LoadLayout(stream)
                Me.radVirtualKeyboard1.ScaleFontOnResize = Me.radCheckBoxScaleFont.IsChecked
                Me.AutoSizeKeyboard()
            End Using

            Me.radLabelLayoutType.Text = "Colemak Layout"
            Me.checkedButton = TryCast(sender, RadRadioButton)
        End Sub

        Private Sub RadRadioButtonExtended_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButtonExtended.ToggleStateChanged
            If Not Me.radRadioButtonExtended.IsChecked Then
                Return
            End If

            Me.radVirtualKeyboard1.LayoutType = KeyboardLayoutType.Extended
            Me.AutoSizeKeyboard()
            Me.radLabelLayoutType.Text = "Extended Layout"
            Me.checkedButton = TryCast(sender, RadRadioButton)
        End Sub

        Private Sub RadRadioButtonSimplified_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButtonSimplified.ToggleStateChanged
            If Not Me.radRadioButtonSimplified.IsChecked Then
                Return
            End If

            Me.radVirtualKeyboard1.LayoutType = KeyboardLayoutType.Simplified
            Me.AutoSizeKeyboard()
            Me.radLabelLayoutType.Text = "Simplified Layout"
            Me.checkedButton = TryCast(sender, RadRadioButton)
        End Sub

        Private Sub RadRadioButtonNumpad_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButtonNumpad.ToggleStateChanged
            If Not Me.radRadioButtonNumpad.IsChecked Then
                Return
            End If

            Me.radVirtualKeyboard1.LayoutType = KeyboardLayoutType.Numpad
            Me.AutoSizeKeyboard()
            Me.radLabelLayoutType.Text = "Numpad Layout"
            Me.checkedButton = TryCast(sender, RadRadioButton)
        End Sub

        Private Sub RadButtonSaveLayout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonSaveLayout.Click
            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.Filter = "XML Files | *.xml"
            dialog.DefaultExt = "xml"

            If dialog.ShowDialog() = DialogResult.OK Then
                Me.radVirtualKeyboard1.SaveLayout(dialog.FileName)
            End If
        End Sub

        Private Sub RadButtonLoadLayout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonLoadLayout.Click
            Dim dialog As OpenFileDialog = New OpenFileDialog()
            dialog.Filter = "XML Files | *.xml"
            dialog.DefaultExt = "xml"

            If dialog.ShowDialog() = DialogResult.OK Then
                Me.radVirtualKeyboard1.LoadLayout(dialog.FileName)
                Me.radVirtualKeyboard1.ScaleFontOnResize = Me.radCheckBoxScaleFont.IsChecked
                Me.AutoSizeKeyboard()

                If Me.checkedButton IsNot Nothing Then
                    Me.checkedButton.IsChecked = False
                    Me.checkedButton = Nothing
                End If

                Me.radLabelLayoutType.Text = "Custom Layout"
            End If
        End Sub

        Private Sub AutoSizeKeyboard()
            Dim newSize As Size = Me.radVirtualKeyboard1.CalculateDesiredSize().ToSize()
            Dim scaleFactor As Single = CSng(Me.radDropDownListScaleFactor.SelectedValue)
            newSize = New SizeF(newSize.Width * scaleFactor, newSize.Height * scaleFactor).ToSize()
            newSize.Height += Me.radLabelLayoutType.Height
            Me.radPanelDemoHolder.Size = newSize
            Me.CenterControl()
        End Sub

        Private Sub RadDropDownListScaleFactor_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownListScaleFactor.SelectedIndexChanged
            Me.AutoSizeKeyboard()
        End Sub
    End Class
End Namespace
