Imports System.Text

Namespace Telerik.Examples.WinControls.PivotGrid
	Public Class Order2
'INSTANT VB NOTE: The variable net was renamed since Visual Basic does not allow class members with the same name:
		Private net_Renamed As Double

		Public Sub New()
		End Sub

		Public Property [Date]() As Date
		Public Property Product() As String
		Public Property Quantity() As Integer

		Public Property Net() As Double
			Get
				If Me.net_Renamed = 1025.64 Then
					' throw new Exception("Example for error value");
				End If
				Return Me.net_Renamed
			End Get
			Set(ByVal value As Double)
				Me.net_Renamed = value
			End Set
		End Property

		Public Property Promotion() As String
		Public Property Advertisement() As String

		Public Overrides Function ToString() As String
			Return Me.Product & Me.Promotion & Me.Quantity
		End Function
	End Class
End Namespace
