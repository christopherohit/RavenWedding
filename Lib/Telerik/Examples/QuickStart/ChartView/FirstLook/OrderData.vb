Namespace Telerik.Examples.WinControls.ChartView.FirstLook
	Public Class OrderData
'INSTANT VB NOTE: The variable amount was renamed since Visual Basic does not allow class members with the same name:
		Private amount_Renamed As Double
'INSTANT VB NOTE: The variable country was renamed since Visual Basic does not allow class members with the same name:
		Private country_Renamed As String
'INSTANT VB NOTE: The variable date was renamed since Visual Basic does not allow class members with the same name:
		Private date_Renamed As Date
		Private productName As String
'INSTANT VB NOTE: The variable region was renamed since Visual Basic does not allow class members with the same name:
		Private region_Renamed As String
'INSTANT VB NOTE: The variable target was renamed since Visual Basic does not allow class members with the same name:
		Private target_Renamed As Double

		Public Property Amount() As Double
			Get
				Return amount_Renamed
			End Get
			Set(ByVal value As Double)
				amount_Renamed = value
			End Set
		End Property

		Public Property Country() As String
			Get
				Return country_Renamed
			End Get
			Set(ByVal value As String)
				country_Renamed = value
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

		Public ReadOnly Property PercentTarget() As Double
			Get
				Return Me.Amount / Me.Target
			End Get
		End Property

		Public Property Product() As String
			Get
				Return productName
			End Get
			Set(ByVal value As String)
				productName = value
			End Set
		End Property

		Public Property Region() As String
			Get
				Return region_Renamed
			End Get
			Set(ByVal value As String)
				region_Renamed = value
			End Set
		End Property

		Public Property Target() As Double
			Get
				Return target_Renamed
			End Get
			Set(ByVal value As Double)
				target_Renamed = value
			End Set
		End Property
	End Class

	Public MustInherit Class OrderView
'INSTANT VB NOTE: The variable data was renamed since Visual Basic does not allow class members with the same name:
		Private data_Renamed As List(Of OrderData)

		Public Sub New()
			data_Renamed = New List(Of OrderData)()
		End Sub

		Public Overridable ReadOnly Property Value() As Double
			Get
'INSTANT VB NOTE: The local variable Value was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
				Dim Value_Renamed As Double = 0
				For Each order As OrderData In data_Renamed
					Value_Renamed += order.Amount
				Next order
				Return Value_Renamed
			End Get
		End Property

		Public ReadOnly Property Data() As List(Of OrderData)
			Get
				Return Me.data_Renamed
			End Get
		End Property

	End Class

	Public Class OrderByMonth
		Inherits OrderView
'INSTANT VB NOTE: The variable month was renamed since Visual Basic does not allow class members with the same name:
		Private month_Renamed As String

		Public Sub New(ByVal month As String)
			MyBase.New()
			Me.month_Renamed = month
		End Sub

		Public ReadOnly Property Month() As String
			Get
				Return Me.month_Renamed
			End Get
		End Property
	End Class

	Public Class OrderByMonthTotalRange
		Inherits OrderByMonth
		Public Sub New(ByVal month As String)
			MyBase.New(month)
		End Sub

		Public Overrides ReadOnly Property Value() As Double
			Get
'INSTANT VB NOTE: The local variable value was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
				Dim value_Renamed As Double = 0
				For Each order As OrderData In Data
					value_Renamed += order.PercentTarget
				Next order
				Return value_Renamed
			End Get
		End Property
	End Class

	Public Class OrdersByRegion
		Inherits OrderView
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
		Private name_Renamed As String

		Public Sub New(ByVal name As String)
			MyBase.New()
			Me.name_Renamed = name
		End Sub

		Public ReadOnly Property Name() As String
			Get
				Return Me.name_Renamed
			End Get
		End Property
	End Class
End Namespace
