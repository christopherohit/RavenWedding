Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Integration.FileExplorer
	Partial Public Class Form1
		Inherits ExternalProcessForm
		Protected Overrides Function GetExecutablePath() As String
			Return "\..\..\FileExplorer\Bin\FileExplorer.exe"
		End Function
	End Class
End Namespace
