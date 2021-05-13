Imports System.Text
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.IndicateErrors
	Public Enum EmployeePosition
		VicePresident
		SalesManager
		SalesRepresentative
		Coordinator
	End Enum

	Public Class Employee
		Implements IDataErrorInfo
'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow class members with the same name:
		Private id_Renamed As Integer
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
		Private name_Renamed As String
'INSTANT VB NOTE: The variable email was renamed since Visual Basic does not allow class members with the same name:
		Private email_Renamed As String
'INSTANT VB NOTE: The variable phone was renamed since Visual Basic does not allow class members with the same name:
		Private phone_Renamed As String
'INSTANT VB NOTE: The variable city was renamed since Visual Basic does not allow class members with the same name:
		Private city_Renamed As String
'INSTANT VB NOTE: The variable position was renamed since Visual Basic does not allow class members with the same name:
		Private position_Renamed As EmployeePosition

		Public Sub New()
		End Sub

		Public Sub New(ByVal id As Integer, ByVal name As String, ByVal city As String, ByVal email As String, ByVal phone As String, ByVal position As EmployeePosition)
			Me.id_Renamed = id
			Me.name_Renamed = name
			Me.city_Renamed = city
			Me.email_Renamed = email
			Me.phone_Renamed = phone
			Me.position_Renamed = position
		End Sub

		Public Property ID() As Integer
			Get
				Return Me.id_Renamed
			End Get
			Set(ByVal value As Integer)
				Me.id_Renamed = value
			End Set
		End Property

		Public Property Name() As String
			Get
				Return Me.name_Renamed
			End Get
			Set(ByVal value As String)
				Me.name_Renamed = value
			End Set
		End Property

		Public Property Position() As EmployeePosition
			Get
				Return Me.position_Renamed
			End Get
			Set(ByVal value As EmployeePosition)
				position_Renamed = value
			End Set
		End Property

		Public Property City() As String
			Get
				Return Me.city_Renamed
			End Get
			Set(ByVal value As String)
				Me.city_Renamed = value
			End Set
		End Property

		Public Property Email() As String
			Get
				Return Me.email_Renamed
			End Get
			Set(ByVal value As String)
				Me.email_Renamed = value
			End Set
		End Property

		Public Property Phone() As String
			Get
				Return Me.phone_Renamed
			End Get
			Set(ByVal value As String)
				Me.phone_Renamed = value
			End Set
		End Property

		#Region "IDataErrorInfo Members"

        <Browsable(False)> _
        Public ReadOnly Property [Error]() As String Implements IDataErrorInfo.Error
            Get
                If (Not IsEmailValid()) OrElse (Not IsNameValid()) OrElse (Not IsPhoneValid()) Then
                    Return "Please enter valid data in this row!"
                End If
                Return String.Empty
            End Get
        End Property

        Default Public ReadOnly Property Item(ByVal columnName As String) As String Implements IDataErrorInfo.Item

            Get
                If columnName = "Email" AndAlso (Not IsEmailValid()) Then
                    Return "This is not a valid email!"
                End If
                If columnName = "Phone" AndAlso (Not IsPhoneValid()) Then
                    Return "This is not a valid phone!"
                End If
                If columnName = "Name" AndAlso (Not IsNameValid()) Then
                    Return "This is not a valid name!"
                End If
                Return String.Empty
            End Get
        End Property

		Private Function IsEmailValid() As Boolean
			Dim strRegex As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
			Dim re As New Regex(strRegex)
			Return (Not String.IsNullOrEmpty(email_Renamed)) AndAlso re.IsMatch(email_Renamed)
		End Function

		Private Function IsNameValid() As Boolean
			Return (Not String.IsNullOrEmpty(name_Renamed)) AndAlso Char.IsLetter(name_Renamed.Chars(0)) AndAlso name_Renamed.Length > 3
		End Function

		Private Function IsPhoneValid() As Boolean
			Dim strRegex As String = "^[1-9]\d{2}-[1-9]\d{2}-\d{4}$"
			Dim re As New Regex(strRegex)
			Return (Not String.IsNullOrEmpty(phone_Renamed)) AndAlso re.IsMatch(phone_Renamed)
		End Function

		#End Region
	End Class
End Namespace
