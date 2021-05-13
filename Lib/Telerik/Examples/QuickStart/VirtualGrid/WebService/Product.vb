
Imports System.Drawing

Namespace Telerik.Examples.WinControls.VirtualGrid.WebService
    Public Class Product
        Public Property ProductID() As Integer
            Get
                Return m_ProductID
            End Get
            Set(value As Integer)
                m_ProductID = Value
            End Set
        End Property
        Private m_ProductID As Integer
        Public Property Image() As Image
            Get
                Return m_Image
            End Get
            Set(value As Image)
                m_Image = Value
            End Set
        End Property
        Private m_Image As Image
        Public Property ProductName() As String
            Get
                Return m_ProductName
            End Get
            Set(value As String)
                m_ProductName = Value
            End Set
        End Property
        Private m_ProductName As String
        Public Property UnitPrice() As Decimal
            Get
                Return m_UnitPrice
            End Get
            Set(value As Decimal)
                m_UnitPrice = Value
            End Set
        End Property
        Private m_UnitPrice As Decimal
        Public Property UnitsInStock() As Integer
            Get
                Return m_UnitsInStock
            End Get
            Set(value As Integer)
                m_UnitsInStock = Value
            End Set
        End Property
        Private m_UnitsInStock As Integer
        Public Property Discontinued() As Boolean
            Get
                Return m_Discontinued
            End Get
            Set(value As Boolean)
                m_Discontinued = Value
            End Set
        End Property
        Private m_Discontinued As Boolean

        Default Public ReadOnly Property Item(index As Integer) As Object
            Get
                Select Case index
                    Case 0
                        Return Image
                    Case 1
                        Return ProductName
                    Case 2
                        Return UnitPrice
                    Case 3
                        Return UnitsInStock
                    Case 4
                        Return Discontinued
                    Case Else
                        Return Nothing
                End Select
            End Get
        End Property
    End Class
End Namespace

