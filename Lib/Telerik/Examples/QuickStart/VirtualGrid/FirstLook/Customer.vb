

Namespace Telerik.Examples.WinControls.VirtualGrid.FirstLook
    Public Class Customer
        Public Property CustomerId() As String
            Get
                Return m_CustomerId
            End Get
            Set(value As String)
                m_CustomerId = Value
            End Set
        End Property
        Private m_CustomerId As String
        Public Property CompanyName() As String
            Get
                Return m_CompanyName
            End Get
            Set(value As String)
                m_CompanyName = Value
            End Set
        End Property
        Private m_CompanyName As String
        Public Property ContactName() As String
            Get
                Return m_ContactName
            End Get
            Set(value As String)
                m_ContactName = Value
            End Set
        End Property
        Private m_ContactName As String
        Public Property ContactTitle() As String
            Get
                Return m_ContactTitle
            End Get
            Set(value As String)
                m_ContactTitle = Value
            End Set
        End Property
        Private m_ContactTitle As String
        Public Property Address() As String
            Get
                Return m_Address
            End Get
            Set(value As String)
                m_Address = Value
            End Set
        End Property
        Private m_Address As String
        Public Property PostalCode() As String
            Get
                Return m_PostalCode
            End Get
            Set(value As String)
                m_PostalCode = Value
            End Set
        End Property
        Private m_PostalCode As String

        Public Sub New(customerId As String, companyName As String, contactName As String, contactTitle As String, address As String, postalCode As String)
            Me.CustomerId = customerId
            Me.CompanyName = companyName
            Me.ContactName = contactName
            Me.ContactTitle = contactTitle
            Me.Address = address
            Me.PostalCode = postalCode
        End Sub

        Default Public ReadOnly Property Item(i As Integer) As String
            Get
                Select Case i
                    Case 0
                        Return CompanyName
                    Case 1
                        Return ContactName
                    Case 2
                        Return ContactTitle
                    Case 3
                        Return Address
                    Case 4
                        Return PostalCode
                    Case Else
                        Return [String].Empty
                End Select
            End Get
        End Property
    End Class
End Namespace


