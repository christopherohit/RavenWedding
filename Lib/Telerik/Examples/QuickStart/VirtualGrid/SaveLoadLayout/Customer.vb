

Namespace Telerik.Examples.WinControls.VirtualGrid.SaveLoadLayout
	Public Class Customer
		Public Property CustomerId() As String
			Get
				Return m_CustomerId
			End Get
			Set
				m_CustomerId = Value
			End Set
		End Property
		Private m_CustomerId As String
		Public Property CompanyName() As String
			Get
				Return m_CompanyName
			End Get
			Set
				m_CompanyName = Value
			End Set
		End Property
		Private m_CompanyName As String
		Public Property ContactName() As String
			Get
				Return m_ContactName
			End Get
			Set
				m_ContactName = Value
			End Set
		End Property
		Private m_ContactName As String
		Public Property Country() As String
			Get
				Return m_Country
			End Get
			Set
				m_Country = Value
			End Set
		End Property
		Private m_Country As String
		Public Property City() As String
			Get
				Return m_City
			End Get
			Set
				m_City = Value
			End Set
		End Property
		Private m_City As String

		Public Sub New(customerId As String, companyName As String, contactName As String, country As String, city As String)

			Me.CustomerId = customerId
			Me.CompanyName = companyName
			Me.ContactName = contactName
			Me.Country = country
			Me.City = city
		End Sub

		Public Default ReadOnly Property Item(i As Integer) As String
			Get
                Select Case i
                    Case 0
                        Return CustomerId
                    Case 1
                        Return CompanyName
                    Case 2
                        Return ContactName
                    Case 3
                        Return Country
                    Case 4
                        Return City
                    Case Else
                        Return [String].Empty
                End Select
			End Get
		End Property
	End Class
End Namespace