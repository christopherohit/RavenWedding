Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Integration.RssReader
	Partial Public Class Form1
		Inherits ExternalProcessForm
		Protected Overrides Function GetExecutablePath() As String
			Return "\..\..\RssReader\Bin\RssReader.exe"
		End Function
	End Class
End Namespace
