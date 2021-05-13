Imports System.Linq
Imports System.Text

Namespace Telerik.Examples.WinControls.ChartView.NullValues
	Public Class FootballTeamStats
		Private _name As String
		Private _logoPath As String
		Private _season As String
		Private _wins? As Integer
		Private _draws? As Integer
		Private _losses? As Integer
		Private _goalDifference? As Integer
		Private _points? As Integer
		Private _position? As Integer

		Public Property Name() As String
			Get
				Return Me._name
			End Get
			Set(ByVal value As String)
				Me._name = value
			End Set
		End Property

		Public Property LogoPath() As String
			Get
				Return Me._logoPath
			End Get
			Set(ByVal value As String)
				Me._logoPath = value
			End Set
		End Property

		Public Property Season() As String
			Get
				Return Me._season
			End Get
			Set(ByVal value As String)
				Me._season = value
			End Set
		End Property

		Public Property Wins() As Integer?
			Get
				Return Me._wins
			End Get
			Set(ByVal value? As Integer)
				Me._wins = value
			End Set
		End Property

		Public Property Draws() As Integer?
			Get
				Return Me._draws
			End Get
			Set(ByVal value? As Integer)
				Me._draws = value
			End Set
		End Property

		Public Property Losses() As Integer?
			Get
				Return Me._losses
			End Get
			Set(ByVal value? As Integer)
				Me._losses = value
			End Set
		End Property

		Public Property GoalDifference() As Integer?
			Get
				Return Me._goalDifference
			End Get
			Set(ByVal value? As Integer)
				Me._goalDifference = value
			End Set
		End Property

		Public Property Points() As Integer?
			Get
				Return Me._points
			End Get
			Set(ByVal value? As Integer)
				Me._points = value
			End Set
		End Property

		Public Property Position() As Integer?
			Get
				Return Me._position
			End Get
			Set(ByVal value? As Integer)
				Me._position = value
			End Set
		End Property
	End Class
End Namespace
