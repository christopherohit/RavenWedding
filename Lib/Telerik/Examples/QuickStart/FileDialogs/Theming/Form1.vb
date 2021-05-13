Imports Telerik.Examples.WinControls.Editors

Namespace Telerik.Examples.WinControls.FileDialogs.Theming
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True
        End Sub

        Private Sub OpenFileDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radOpenFileDialog1.OpenFileDialogForm.ThemeName = Me.CurrentThemeName
            Me.radOpenFileDialog1.ShowDialog(Me)
        End Sub

        Private Sub OpenFolderDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radOpenFolderDialog1.OpenFolderDialogForm.ThemeName = Me.CurrentThemeName
            Me.radOpenFolderDialog1.ShowDialog(Me)
        End Sub

        Private Sub SaveFileDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radSaveFileDialog1.SaveFileDialogForm.ThemeName = Me.CurrentThemeName
            Me.radSaveFileDialog1.ShowDialog(Me)
        End Sub
    End Class
End Namespace