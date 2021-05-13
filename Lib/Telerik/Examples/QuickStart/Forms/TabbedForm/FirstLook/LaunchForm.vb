Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Forms.TabbedForm.FirstLook
    Public Class LaunchForm
        Inherits ExamplesLauncherForm

        Private ReadOnly Property TabbedForm As RadTabbedForm
            Get
                Return TryCast(Me.Form, RadTabbedForm)
            End Get
        End Property

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            If Me.TabbedForm IsNot Nothing AndAlso Me.TabbedForm.TabbedFormControl IsNot Nothing Then
                Me.SyncTheme(Me.TabbedForm)
            End If
        End Sub

        Private Sub SyncTheme(ByVal form As RadTabbedForm)
            Me.TabbedForm.ThemeName = Me.CurrentThemeName
            Me.TabbedForm.TabbedFormControl.ThemeName = Me.CurrentThemeName
        End Sub
    End Class
End Namespace
