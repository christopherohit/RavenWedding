Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Integration.ERP
    Public Class Form1
        Inherits ExternalProcessForm
        Protected Overrides Function GetExecutablePath() As String
            Return "\..\..\ERP\ERP.Client\bin\ERP.Client.exe"
        End Function
    End Class
End Namespace
