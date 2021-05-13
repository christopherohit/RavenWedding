Imports System.Text
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.PropertyGrid.Validation
	Public Enum Gender
		Male
		Female
	End Enum

	Public Class PersonInfo
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
		Private name_Renamed As String
'INSTANT VB NOTE: The variable family was renamed since Visual Basic does not allow class members with the same name:
		Private family_Renamed As String
'INSTANT VB NOTE: The variable gender was renamed since Visual Basic does not allow class members with the same name:
		Private gender_Renamed As Gender
'INSTANT VB NOTE: The variable age was renamed since Visual Basic does not allow class members with the same name:
		Private age_Renamed As Integer
'INSTANT VB NOTE: The variable city was renamed since Visual Basic does not allow class members with the same name:
		Private city_Renamed As String
'INSTANT VB NOTE: The variable country was renamed since Visual Basic does not allow class members with the same name:
		Private country_Renamed As String
'INSTANT VB NOTE: The variable email was renamed since Visual Basic does not allow class members with the same name:
		Private email_Renamed As String
'INSTANT VB NOTE: The variable phone was renamed since Visual Basic does not allow class members with the same name:
		Private phone_Renamed As String

		<Category("Personal Information"), Description("Employee name cannot be blank!")>
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property

		<Category("Personal Information"), Description("Employee family cannot be blank!")>
		Public Property Family() As String
			Get
				Return family_Renamed
			End Get
			Set(ByVal value As String)
				family_Renamed = value
			End Set
		End Property

		<Category("Personal Information")>
		Public Property Gender() As Gender
			Get
				Return gender_Renamed
			End Get
			Set(ByVal value As Gender)
				gender_Renamed = value
			End Set
		End Property

		<Category("Personal Information"), Description("Employee age can be between 18 and 56 years.")>
		Public Property Age() As Integer
			Get
				Return age_Renamed
			End Get
			Set(ByVal value As Integer)
				age_Renamed = value
			End Set
		End Property

		<Category("Address"), Description("This field represents the city where the employee lives and cannot be blank.")>
		Public Property City() As String
			Get
				Return city_Renamed
			End Get
			Set(ByVal value As String)
				city_Renamed = value
			End Set
		End Property

		<Category("Address"), Description("This field represents the country where the employee lives and cannot be blank.")>
		Public Property Country() As String
			Get
				Return country_Renamed
			End Get
			Set(ByVal value As String)
				country_Renamed = value
			End Set
		End Property

		<Category("Address"), Description("The EMail field should contain a valid email.")>
		Public Property EMail() As String
			Get
				Return email_Renamed
			End Get
			Set(ByVal value As String)
				email_Renamed = value
			End Set
		End Property

		<Category("Address"), Description("The Phone field should contain a valid us style phone number.")>
		Public Property Phone() As String
			Get
				Return phone_Renamed
			End Get
			Set(ByVal value As String)
				phone_Renamed = value
			End Set
		End Property
	End Class
End Namespace
