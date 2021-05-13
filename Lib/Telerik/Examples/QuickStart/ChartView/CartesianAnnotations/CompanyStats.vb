Imports System.Linq
Imports System.Text

Namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
	Public Class CompanyStats
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
		Private name_Renamed As String
'INSTANT VB NOTE: The variable date was renamed since Visual Basic does not allow class members with the same name:
		Private date_Renamed As Date
'INSTANT VB NOTE: The variable value was renamed since Visual Basic does not allow class members with the same name:
		Private value_Renamed As Double

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property

		Public Property [Date]() As Date
			Get
				Return date_Renamed
			End Get
			Set(ByVal value As Date)
				date_Renamed = value
			End Set
		End Property

		Public Property Value() As Double
			Get
				Return Me.value_Renamed
			End Get
			Set(ByVal value As Double)
				Me.value_Renamed = value
			End Set
		End Property
	End Class
End Namespace
