Imports System
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Forms.TabbedForm.Settings
    Partial Public Class Form1
        Inherits ExamplesLauncherForm

        Private tabbedForm As RadTabbedForm

        Public Sub New()
            InitializeComponent()
            Me.radGroupSettings.Enabled = False
            Me.pinnedItemsDropDown.DataSource = [Enum].GetValues(GetType(PinnedItemsPosition))
            Me.dragModeDropDown.DataSource = [Enum].GetValues(GetType(TabItemDragMode))
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            If Me.tabbedForm IsNot Nothing AndAlso Me.tabbedForm.TabbedFormControl IsNot Nothing Then
                Me.SyncTheme(Me.tabbedForm)
            End If
        End Sub

        Private Sub SyncTheme(ByVal form As RadTabbedForm)
            Me.tabbedForm.ThemeName = Me.CurrentThemeName
            Me.tabbedForm.TabbedFormControl.ThemeName = Me.CurrentThemeName
            Me.UpdateSettings(Me.tabbedForm.TabbedFormControl)
        End Sub

        Protected Overrides Sub ShowForm()
            If Me.tabbedForm Is Nothing OrElse Me.tabbedForm.IsDisposed Then
                Me.tabbedForm = New RadTabbedForm()
                AddHandler Me.tabbedForm.ControlAdded, AddressOf TabbedForm_ControlAdded
                AddHandler Me.tabbedForm.FormClosed, AddressOf TabbedForm_FormClosed
                Me.tabbedForm.TopMost = True
                Me.tabbedForm.Text = "Tabbed Form"
                AddHandler Me.tabbedForm.TabbedFormControlCreating, AddressOf TabbedForm_TabbedFormControlCreating
                Me.tabbedForm.Show()
            End If
        End Sub

        Protected Overrides Sub CloseForm()
            MyBase.CloseForm()
            If Me.tabbedForm IsNot Nothing AndAlso Me.tabbedForm.Visible Then
                Me.tabbedForm.Close()
            End If
        End Sub

        Private Sub TabbedForm_ControlAdded(ByVal sender As Object, ByVal e As ControlEventArgs)
            AddHandler Me.tabbedForm.ControlAdded, AddressOf TabbedForm_ControlAdded
            Me.SyncTheme(Me.tabbedForm)
            AddHandler Me.captionHeightSpinEditor.ValueChanged, AddressOf CaptionHeightSpinEditor_ValueChanged
            AddHandler Me.tabHeightSpinEditor.ValueChanged, AddressOf TabHeightSpinEditor_ValueChanged
            AddHandler Me.tabSpacingSpinEditor.ValueChanged, AddressOf TabSpacingSpinEditor_ValueChanged
            AddHandler Me.tabWidthSpinEditor.ValueChanged, AddressOf TabWidthSpinEditor_ValueChanged
            AddHandler Me.minTabWidthSpinEditor.ValueChanged, AddressOf MinTabWidthSpinEditor_ValueChanged
            AddHandler Me.showCloseBtnCheckBox.CheckStateChanged, AddressOf ShowCloseBtnCheckBox_CheckStateChanged
            AddHandler Me.showPinBtnCheckBox.CheckStateChanged, AddressOf ShowPinBtnCheckBox_CheckStateChanged
            AddHandler Me.showNewBtnCheckBox.CheckStateChanged, AddressOf ShowNewBtnCheckBox_CheckStateChanged
            AddHandler Me.pinnedItemsDropDown.SelectedValueChanged, AddressOf PinnedItemsDropDown_SelectedValueChanged
            AddHandler Me.dragModeDropDown.SelectedValueChanged, AddressOf DragModeDropDown_SelectedValueChanged
            AddHandler Me.showIconCheckBox.CheckStateChanged, AddressOf ShowIconCheckBox_CheckStateChanged
            AddHandler Me.showTextCheckBox.CheckStateChanged, AddressOf ShowTextCheckBox_CheckStateChanged
            AddHandler Me.allowAeroCheckBox.CheckStateChanged, AddressOf AllowAeroCheckBox_CheckStateChanged
        End Sub

        Private Sub TabbedForm_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            If Me.tabbedForm IsNot Nothing Then
                AddHandler Me.tabbedForm.TabbedFormControl.TabbedFormControlElement.ItemDragService.TabbedFormShown, AddressOf ItemDragService_TabbedFormShown
            End If

            Me.radGroupSettings.Enabled = False
            AddHandler Me.captionHeightSpinEditor.ValueChanged, AddressOf CaptionHeightSpinEditor_ValueChanged
            AddHandler Me.tabHeightSpinEditor.ValueChanged, AddressOf TabHeightSpinEditor_ValueChanged
            AddHandler Me.tabSpacingSpinEditor.ValueChanged, AddressOf TabSpacingSpinEditor_ValueChanged
            AddHandler Me.tabWidthSpinEditor.ValueChanged, AddressOf TabWidthSpinEditor_ValueChanged
            AddHandler Me.minTabWidthSpinEditor.ValueChanged, AddressOf MinTabWidthSpinEditor_ValueChanged
            AddHandler Me.showCloseBtnCheckBox.CheckStateChanged, AddressOf ShowCloseBtnCheckBox_CheckStateChanged
            AddHandler Me.showPinBtnCheckBox.CheckStateChanged, AddressOf ShowPinBtnCheckBox_CheckStateChanged
            AddHandler Me.showNewBtnCheckBox.CheckStateChanged, AddressOf ShowNewBtnCheckBox_CheckStateChanged
            AddHandler Me.pinnedItemsDropDown.SelectedValueChanged, AddressOf PinnedItemsDropDown_SelectedValueChanged
            AddHandler Me.dragModeDropDown.SelectedValueChanged, AddressOf DragModeDropDown_SelectedValueChanged
            AddHandler Me.showIconCheckBox.CheckStateChanged, AddressOf ShowIconCheckBox_CheckStateChanged
            AddHandler Me.showTextCheckBox.CheckStateChanged, AddressOf ShowTextCheckBox_CheckStateChanged
            AddHandler Me.allowAeroCheckBox.CheckStateChanged, AddressOf AllowAeroCheckBox_CheckStateChanged
            AddHandler Me.tabbedForm.FormClosed, AddressOf Me.TabbedForm_FormClosed
        End Sub

        Private Sub TabbedForm_TabbedFormControlCreating(ByVal sender As Object, ByVal e As TabbedFormControlCreatingEventArgs)
            AddHandler Me.tabbedForm.TabbedFormControlCreating, AddressOf Me.TabbedForm_TabbedFormControlCreating
            Dim form As RadForm = TryCast(Me.FindForm(), RadForm)

            If form IsNot Nothing Then
                e.TabbedFormControl.Scale(form.RootElement.DpiScaleFactor)
            End If

            Me.radGroupSettings.Enabled = True
            Me.UpdateSettings(e.TabbedFormControl)
            e.TabbedFormControl.Tabs.Add(New RadTabbedFormControlTab())
            e.TabbedFormControl.Tabs.Add(New RadTabbedFormControlTab())
            AddHandler e.TabbedFormControl.TabbedFormControlElement.ItemDragService.TabbedFormShown, AddressOf ItemDragService_TabbedFormShown
        End Sub

        Private Sub ItemDragService_TabbedFormShown(ByVal sender As Object, ByVal e As TabbedFormShownEventArgs)
            e.TabbedForm.TopMost = True
        End Sub

        Private Sub ShowTextCheckBox_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.TabbedFormControl.ShowText = Me.showTextCheckBox.Checked
        End Sub

        Private Sub ShowIconCheckBox_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.ShowIcon = Me.showIconCheckBox.Checked
        End Sub

        Private Sub AllowAeroCheckBox_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.AllowAero = Me.allowAeroCheckBox.IsChecked
        End Sub

        Private Sub DragModeDropDown_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.TabbedFormControl.ItemDragMode = CType(Me.dragModeDropDown.SelectedValue, TabItemDragMode)
        End Sub

        Private Sub PinnedItemsDropDown_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.TabbedFormControl.PinnedItemsPosition = CType(Me.pinnedItemsDropDown.SelectedValue, PinnedItemsPosition)
        End Sub

        Private Sub ShowNewBtnCheckBox_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.TabbedFormControl.ShowNewTabButton = Me.showNewBtnCheckBox.IsChecked
        End Sub

        Private Sub ShowPinBtnCheckBox_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.TabbedFormControl.ShowTabPinButton = Me.showPinBtnCheckBox.IsChecked
        End Sub

        Private Sub ShowCloseBtnCheckBox_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.TabbedFormControl.ShowTabCloseButton = Me.showCloseBtnCheckBox.IsChecked
        End Sub

        Private Sub MinTabWidthSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.TabbedFormControl.MinimumTabWidth = CInt(Me.minTabWidthSpinEditor.Value)
        End Sub

        Private Sub TabWidthSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.TabbedFormControl.TabWidth = CInt(Me.tabWidthSpinEditor.Value)
        End Sub

        Private Sub TabSpacingSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.TabbedFormControl.TabSpacing = CInt(Me.tabSpacingSpinEditor.Value)
        End Sub

        Private Sub TabHeightSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.TabbedFormControl.TabHeight = CInt(Me.tabHeightSpinEditor.Value)
        End Sub

        Private Sub CaptionHeightSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tabbedForm.TabbedFormControl.CaptionHeight = CInt(Me.captionHeightSpinEditor.Value)
        End Sub

        Private Sub UpdateSettings(ByVal tabbedControl As RadTabbedFormControl)
            Dim descaleSize As SizeF = New SizeF(1 / tabbedControl.RootElement.DpiScaleFactor.Width, 1 / tabbedControl.RootElement.DpiScaleFactor.Height)
            Me.captionHeightSpinEditor.Value = TelerikDpiHelper.ScaleInt(tabbedControl.CaptionHeight, descaleSize)
            Me.tabHeightSpinEditor.Value = TelerikDpiHelper.ScaleInt(tabbedControl.TabHeight, descaleSize)
            Me.tabSpacingSpinEditor.Value = TelerikDpiHelper.ScaleInt(tabbedControl.TabSpacing, descaleSize)
            Me.tabWidthSpinEditor.Value = TelerikDpiHelper.ScaleInt(tabbedControl.TabWidth, descaleSize)
            Me.minTabWidthSpinEditor.Value = TelerikDpiHelper.ScaleInt(tabbedControl.MinimumTabWidth, descaleSize)
            Me.showCloseBtnCheckBox.Checked = tabbedControl.ShowTabCloseButton
            Me.showPinBtnCheckBox.Checked = tabbedControl.ShowTabPinButton
            Me.showNewBtnCheckBox.Checked = tabbedControl.ShowNewTabButton
            Me.pinnedItemsDropDown.SelectedValue = tabbedControl.PinnedItemsPosition
            Me.dragModeDropDown.SelectedValue = tabbedControl.ItemDragMode
        End Sub
    End Class
End Namespace
