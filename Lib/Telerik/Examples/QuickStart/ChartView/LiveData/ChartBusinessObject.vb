Imports System.Text
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.ChartView.LiveData
	Friend Class ChartBusinessObject
'INSTANT VB NOTE: The variable value was renamed since Visual Basic does not allow class members with the same name:
		Private value_Renamed As Double
'INSTANT VB NOTE: The variable category was renamed since Visual Basic does not allow class members with the same name:
		Private category_Renamed As Date

		Public Property Value() As Double
			Get
				Return Me.value_Renamed
			End Get
			Set(ByVal value As Double)
				Me.value_Renamed = value
			End Set
		End Property

		Public Property Category() As Date
			Get
				Return Me.category_Renamed
			End Get
			Set(ByVal value As Date)
				Me.category_Renamed = value
			End Set
		End Property
	End Class
End Namespace
