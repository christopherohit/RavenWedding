Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Integration.HotelApp
    Partial Public Class Form1
        Inherits ExternalProcessForm
        Protected Overrides Function GetExecutablePath() As String
            Return "\..\..\HotelApp\HotelAppCS\Bin\HotelApp.exe"
        End Function
    End Class
End Namespace