Imports System.Collections.ObjectModel
Imports System.IO

Namespace Telerik.Examples.WinControls.SyntaxEditor.FirstLook
    Public Class DirectoryInfo
        Inherits FileInfo

        Public Sub New(ByVal fullPath As String, ByVal name As String)
            MyBase.New(fullPath, name)
            Me.Children = New ObservableCollection(Of FileInfo)()
        End Sub

        Public Property Children As ObservableCollection(Of FileInfo)

        Public Sub LoadChildren()
            Try
                Dim dirs As String() = Directory.GetDirectories(Me.FullPath)
                For Each directory As String In dirs
                    Dim directoryInfo As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(directory)
                    Me.Children.Add(New DirectoryInfo(directory, directoryInfo.Name))
                Next

                Dim files As String() = Directory.GetFiles(Me.FullPath)
                For Each file As String In files
                    Dim fileInfo As System.IO.FileInfo = New System.IO.FileInfo(file)
                    Me.Children.Add(New FileInfo(file, fileInfo.Name))
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
