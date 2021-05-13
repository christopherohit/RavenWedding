Imports System
Imports System.Linq

Namespace Telerik.Examples.WinControls.PdfProcessing.PdfChartIntegration
    Public Class Product
        Public Sub New(ByVal name As String, ParamArray q As Double())
            Me.Name = name
            Me.Q = q
        End Sub

        Public Property Name As String
        Public Property Q As Double()

        Public Shared Function GetProducts() As Product()
            Return New Product() {New Product("Product1", 25000, 30000, 15000, 25000), New Product("Product2", 20000, 28000, 12000, 20000), New Product("Product3", 14000, 28000, 8400, 14000), New Product("Product4", 7000, 14000, 4200, 7000), New Product("Product5", 7700, 15400, 4620, 7700), New Product("Product6", 13090, 26180, 7854, 13090)}
        End Function
    End Class
End Namespace
