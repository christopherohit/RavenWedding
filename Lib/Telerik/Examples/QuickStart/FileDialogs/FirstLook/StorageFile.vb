Namespace Telerik.Examples.WinControls.FileDialogs.FirstLook
    Public Class StorageFile
        Public Property Name As String
        Public Property FileSystemInfoType As String
        Public Property UploadedTime As DateTime

        Public Sub New(ByVal name As String)
            Me.Name = name
            Me.FileSystemInfoType = "File"
            Me.UploadedTime = DateTime.Now
        End Sub
    End Class
End Namespace
