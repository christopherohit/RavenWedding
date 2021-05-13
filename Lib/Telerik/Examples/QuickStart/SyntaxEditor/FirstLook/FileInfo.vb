Namespace Telerik.Examples.WinControls.SyntaxEditor.FirstLook
    Public Class FileInfo
        Public Sub New(ByVal fullPath As String, ByVal name As String)
            Me.FullPath = fullPath
            Me.Name = name
        End Sub

        Public Property FullPath As String
        Public Property Name As String
    End Class
End Namespace