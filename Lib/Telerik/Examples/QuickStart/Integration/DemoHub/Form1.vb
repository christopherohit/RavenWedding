Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Integration.DemoHub
    Partial Public Class Form1
        Inherits ExternalProcessForm
        Protected Overrides Function GetExecutablePath() As String
            Return "\..\..\DemoAppsHub\Bin\DemoAppsHub.exe"
        End Function
    End Class
End Namespace
