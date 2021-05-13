Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RibbonBar.SimplifiedLayout
    Partial Public Class Form1
        Inherits RadForm
        Implements ISupportThemeName

        Public Sub New()
            InitializeComponent()

            Me.AllowTheming = False
            Me.radRichTextEditor1.Document.LayoutMode = WinForms.Documents.Model.DocumentLayoutMode.Paged
        End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub

        Protected Overrides Sub OnShown(e As EventArgs)
            MyBase.OnShown(e)

            Me.richTextEditorRibbonBar1.LayoutMode = RibbonLayout.Simplified
        End Sub
    End Class
End Namespace