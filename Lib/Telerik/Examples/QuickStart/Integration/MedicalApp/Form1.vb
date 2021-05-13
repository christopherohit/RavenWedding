Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Integration.MedicalApp
    Partial Public Class Form1
        Inherits ExternalProcessForm
        Protected Overrides Function GetExecutablePath() As String
            Return "\..\..\MedicalApp\MedicalAppCS\Bin\MedicalAppCS.exe"
        End Function
    End Class
End Namespace