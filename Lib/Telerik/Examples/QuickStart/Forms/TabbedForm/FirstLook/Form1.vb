Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Forms.TabbedForm.FirstLook
    Partial Public Class Form1
        Inherits RadTabbedForm
        Implements ISupportThemeName

        Public Sub New()
            InitializeComponent()
            Me.AllowAero = False
            AddHandler Me.TabbedFormControl.TabbedFormControlElement.ItemDragService.TabbedFormShown, AddressOf ItemDragService_TabbedFormShown
        End Sub

        Private Sub ItemDragService_TabbedFormShown(ByVal sender As Object, ByVal e As TabbedFormShownEventArgs)
            AddHandler e.TabbedForm.TabbedFormControlCreating, AddressOf TabbedForm_TabbedFormControlCreating
            AddHandler e.TabbedForm.TabbedFormControlCreating, AddressOf TabbedForm_TabbedFormControlCreating
        End Sub

        Private Sub TabbedForm_TabbedFormControlCreating(ByVal sender As Object, ByVal e As TabbedFormControlCreatingEventArgs)
            e.TabbedFormControl.Tabs(0).Controls.Clear()
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)

            If Me.radTabbedFormControl1.SelectedTab IsNot Nothing AndAlso Me.radTabbedFormControl1.SelectedTab.Controls.Count = 0 Then
                Me.AddUserControl()
            End If
        End Sub

        Private Sub SetTexts()
            SetText(Me.radButtonElement1, "")
            radButtonElement1.TextElement.CustomFontSize = 12
        End Sub

        Public Shared Sub SetText(ByVal buttonElement As RadButtonElement, ByVal text As String)
            buttonElement.TextElement.CustomFontSize = 18
            buttonElement.TextElement.CustomFont = "TelerikWebUI"
            buttonElement.Text = text
            buttonElement.TextElement.TextRenderingHint = TextRenderingHint.AntiAlias
        End Sub

        Private Sub radTabbedFormControl1_SelectedTabChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.radTabbedFormControl1.SelectedTab IsNot Nothing AndAlso Me.radTabbedFormControl1.SelectedTab.Controls.Count = 0 Then
                Me.AddUserControl()
            End If
        End Sub

        Private Sub AddUserControl()
            Dim qSFTabbedFormUserControl As QSFTabbedFormUserControl = New QSFTabbedFormUserControl()
            qSFTabbedFormUserControl.ApplyTheme(Me.ThemeName)
            Me.radTabbedFormControl1.SelectedTab.Controls.Add(qSFTabbedFormUserControl)
            qSFTabbedFormUserControl.SetupVisibility()
            qSFTabbedFormUserControl.CenterControl(Me)
        End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            Me.ThemeName = themeName
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub

        Private Sub radTabbedFormControl1_TabAdded(ByVal sender As Object, ByVal e As RadTabbedFormControlEventArgs)
            If e.Tab.Controls.Count = 0 Then
                Dim qSFTabbedFormUserControl As QSFTabbedFormUserControl = New QSFTabbedFormUserControl()
                qSFTabbedFormUserControl.ApplyTheme(Me.ThemeName)
                e.Tab.Controls.Add(qSFTabbedFormUserControl)
                e.Tab.Owner.SelectedTab = e.Tab
                qSFTabbedFormUserControl.SetupVisibility()
                qSFTabbedFormUserControl.CenterControl(Me)
            End If
        End Sub
    End Class
End Namespace
