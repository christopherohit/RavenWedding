Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.Settings
    Public Partial Class Form1
        Inherits EditorExampleBaseForm

        Public Sub New()
            InitializeComponent()

            Me.CenterPanel = True
            ExamplesForm.FillComboFromEnum(Me.editModeDropDownList, GetType(TimeSpanEditMode), TimeSpanEditMode.Combined)
            AddHandler Me.exampleTimeSpanPicker.PopupContentElement.ComponentsCreated, AddressOf PopupContentElement_ComponentsCreated
            AddHandler Me.exampleTimeSpanPicker.PopupOpened, AddressOf ExampleTimeSpanPicker_PopupOpened
        End Sub

        Private Sub ExampleTimeSpanPicker_PopupOpened(ByVal sender As Object, ByVal e As EventArgs)
            For Each component As ITimeSpanPickerComponent In Me.exampleTimeSpanPicker.PopupContentElement.Components
                Dim listUiCompoinent As ListTimeSpanPickerUIComponent = TryCast(component.TimeSpanPickerUIComponent, ListTimeSpanPickerUIComponent)

                If Me.changeStylesCheckBox.IsChecked Then
                    listUiCompoinent.Header.DrawFill = True
                    listUiCompoinent.Header.GradientStyle = GradientStyles.Solid
                    listUiCompoinent.Header.ForeColor = Color.OliveDrab
                    listUiCompoinent.Header.BackColor = Color.LightGoldenrodYellow
                Else
                    listUiCompoinent.Header.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                    listUiCompoinent.Header.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                    listUiCompoinent.Header.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                    listUiCompoinent.Header.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                End If
            Next

            Dim buttonPanel As TimeSpanPickerDoneButtonElement = (TryCast(Me.exampleTimeSpanPicker.PopupContentElement, RadTimeSpanPickerContentElement)).FooterPanel

            If Me.changeStylesCheckBox.IsChecked Then
                buttonPanel.DrawFill = True
                buttonPanel.GradientStyle = GradientStyles.Solid
                buttonPanel.BackColor = Color.OliveDrab
                buttonPanel.ButtonElement.ButtonFillElement.Visibility = ElementVisibility.Visible
                buttonPanel.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid
                buttonPanel.ButtonElement.ButtonFillElement.BackColor = Color.LightGoldenrodYellow
                buttonPanel.ButtonElement.ForeColor = Color.OliveDrab
            Else
                buttonPanel.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                buttonPanel.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                buttonPanel.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                buttonPanel.ResetValue(Telerik.WinControls.Primitives.FillPrimitive.VisibilityProperty, ValueResetFlags.Local)
                buttonPanel.ResetValue(Telerik.WinControls.Primitives.FillPrimitive.GradientStyleProperty, ValueResetFlags.Local)
                buttonPanel.ResetValue(Telerik.WinControls.Primitives.FillPrimitive.BackColorProperty, ValueResetFlags.Local)
                buttonPanel.ResetValue(RadButtonElement.ForeColorProperty, ValueResetFlags.Local)
            End If
        End Sub

        Private Sub PopupContentElement_ComponentsCreated(ByVal sender As Object, ByVal e As EventArgs)
            For Each component As ITimeSpanPickerComponent In Me.exampleTimeSpanPicker.PopupContentElement.Components
                Dim listUiCompoinent As ListTimeSpanPickerUIComponent = TryCast(component.TimeSpanPickerUIComponent, ListTimeSpanPickerUIComponent)
                listUiCompoinent.ListElement.Tag = Me.exampleTimeSpanPicker.PopupContentElement.Components.IndexOf(TryCast(component, RadItem))
                AddHandler listUiCompoinent.ListElement.VisualItemFormatting, AddressOf ListElement_VisualItemFormatting
            Next
        End Sub

        Private Sub ListElement_VisualItemFormatting(ByVal sender As Object, ByVal args As VisualItemFormattingEventArgs)
            Dim componentIndex As Integer = CInt(args.VisualItem.Data.Owner.Tag)

            If Me.changeStylesCheckBox.IsChecked AndAlso (args.VisualItem.Data.RowIndex + componentIndex) Mod 3 = 0 Then
                Dim backColor As Color = Color.LemonChiffon
                Dim foreColor As Color = Color.HotPink

                If componentIndex Mod 2 = 0 Then
                    backColor = Color.YellowGreen
                    foreColor = Color.LightGoldenrodYellow
                End If

                args.VisualItem.BackColor = backColor
                args.VisualItem.GradientStyle = GradientStyles.Solid
                args.VisualItem.ForeColor = foreColor
            Else
                args.VisualItem.ResetValue(RadListVisualItem.BackColorProperty, ValueResetFlags.Local)
                args.VisualItem.ResetValue(RadListVisualItem.GradientStyleProperty, ValueResetFlags.Local)
                args.VisualItem.ResetValue(RadListVisualItem.ForeColorProperty, ValueResetFlags.Local)
            End If
        End Sub

        Private Sub EditModeDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            If Me.editModeDropDownList.SelectedValue IsNot Nothing Then
                Me.exampleTimeSpanPicker.EditMode = CType(Me.editModeDropDownList.SelectedValue, TimeSpanEditMode)
            End If
        End Sub

        Private Sub SetFormatButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = Me.formatTextBox.Text

            If String.IsNullOrWhiteSpace(text) Then
                RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
                RadMessageBox.Show("Format String must be a non empty string.")
                Me.formatTextBox.Text = Me.exampleTimeSpanPicker.Format
                Return
            End If

            Me.exampleTimeSpanPicker.Format = text
        End Sub

        Private Sub spinButtonsCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.exampleTimeSpanPicker.ShowSpinButtons = Me.spinButtonsCheckBox.IsChecked
        End Sub

        Private Sub MinValueTimeSpanPicker_ValueChanging(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim args As ValueChangingEventArgs = TryCast(e, ValueChangingEventArgs)

            If args IsNot Nothing Then
                Dim newValue As TimeSpan = CType(args.NewValue, TimeSpan)

                If Me.exampleTimeSpanPicker.MaxValue < newValue Then
                    args.Cancel = True
                    RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
                    RadMessageBox.Show("Minimum value must be lower than Maximum.")
                End If
            End If
        End Sub

        Private Sub MinValueTimeSpanPicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.exampleTimeSpanPicker.MinValue = Me.minValueTimeSpanPicker.Value.Value
        End Sub

        Private Sub MaxValueTimeSpanPicker_ValueChanging(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim args As ValueChangingEventArgs = TryCast(e, ValueChangingEventArgs)

            If args IsNot Nothing Then
                Dim newValue As TimeSpan = CType(args.NewValue, TimeSpan)

                If Me.exampleTimeSpanPicker.MinValue > newValue Then
                    args.Cancel = True
                    RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
                    RadMessageBox.Show("Maximum value must be greater than Minimum.")
                End If
            End If
        End Sub

        Private Sub MaxValueTimeSpanPicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.exampleTimeSpanPicker.MaxValue = Me.maxValueTimeSpanPicker.Value.Value
        End Sub

        Private Sub DaysStepSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.exampleTimeSpanPicker.DaysStep = CInt(Me.daysStepSpinEditor.Value)
        End Sub

        Private Sub HoursStepSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.exampleTimeSpanPicker.HoursStep = CInt(Me.hoursStepSpinEditor.Value)
        End Sub

        Private Sub MinutesStepSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.exampleTimeSpanPicker.MinutesStep = CInt(Me.minutesStepSpinEditor.Value)
        End Sub

        Private Sub SecondsStepSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.exampleTimeSpanPicker.SecondsStep = CInt(Me.secondsStepSpinEditor.Value)
        End Sub

        Private Sub MillisecondsStepSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.exampleTimeSpanPicker.MillisecondsStep = CInt(Me.millisecondsStepSpinEditor.Value)
        End Sub

        Private Sub EnablNullValueCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.exampleTimeSpanPicker.EnableNullValueInput = Me.enableNullValueCheckBox.IsChecked
            Me.nullTextTextBox.Enabled = Me.enableNullValueCheckBox.IsChecked
        End Sub

        Private Sub NullTextTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.exampleTimeSpanPicker.NullText = Me.nullTextTextBox.Text
        End Sub
    End Class
End Namespace
