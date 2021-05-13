Imports System.Collections.Generic
Imports System.Text

Namespace Telerik.Examples.WinControls.VirtualGrid.Hierarchy
    Public Class Customer
        Public Shared ReadOnly FieldNames As String() = {"CompanyName", "Country", "City", "ContactName"}

        Private m_CompanyName As String
        Private m_Country As String
        Private m_City As String
        Private m_ContactName As String
        Private m_Sales As List(Of Sale)

        Public Property CompanyName() As String
            Get
                Return m_CompanyName
            End Get
            Set(value As String)
                m_CompanyName = Value
            End Set
        End Property

        Public Property Country() As String
            Get
                Return m_Country
            End Get
            Set(value As String)
                m_Country = Value
            End Set
        End Property

        Public Property City() As String
            Get
                Return m_City
            End Get
            Set(value As String)
                m_City = Value
            End Set
        End Property

        Public Property ContactName() As String
            Get
                Return m_ContactName
            End Get
            Set(value As String)
                m_ContactName = Value
            End Set
        End Property

        Public Property Sales() As List(Of Sale)
            Get
                Return m_Sales
            End Get
            Private Set(value As List(Of Sale))
                m_Sales = Value
            End Set
        End Property

        Default Public ReadOnly Property Item(index As Integer) As Object
            Get
                Select Case index
                    Case 0
                        Return CompanyName
                    Case 1
                        Return Country
                    Case 2
                        Return City
                    Case 3
                        Return ContactName
                    Case Else
                        Return Nothing
                End Select
            End Get
        End Property

        Public Sub New()
            Me.Sales = New List(Of Sale)()
        End Sub
    End Class
End Namespace