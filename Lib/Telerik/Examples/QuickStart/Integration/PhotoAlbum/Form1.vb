Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Integration.PhotoAlbum
	Partial Public Class Form1
		Inherits ExternalProcessForm
		Protected Overrides Function GetExecutablePath() As String
			Return "\..\..\PhotoAlbum\Bin\PhotoAlbum.exe"
		End Function
	End Class
End Namespace