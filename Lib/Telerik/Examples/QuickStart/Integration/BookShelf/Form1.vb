Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Integration.BookShelf
	Partial Public Class Form1
		Inherits ExternalProcessForm
		Protected Overrides Function GetExecutablePath() As String
			Return "\..\..\BookShelf\Bin\BookShelf.exe"
		End Function
	End Class
End Namespace
