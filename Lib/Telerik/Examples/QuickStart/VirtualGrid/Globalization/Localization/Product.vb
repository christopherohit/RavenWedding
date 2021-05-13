
Imports System.Collections.Generic
Imports System.Text

Namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.Localization
    Public Class Product
        Public Property ProductName() As String
            Get
                Return m_ProductName
            End Get
            Set(value As String)
                m_ProductName = Value
            End Set
        End Property
        Private m_ProductName As String
        Public Property UnitQuantity() As String
            Get
                Return m_UnitQuantity
            End Get
            Set(value As String)
                m_UnitQuantity = Value
            End Set
        End Property
        Private m_UnitQuantity As String
        Public Property UnitPrice() As String
            Get
                Return m_UnitPrice
            End Get
            Set(value As String)
                m_UnitPrice = Value
            End Set
        End Property
        Private m_UnitPrice As String
        Public Property InStock() As String
            Get
                Return m_InStock
            End Get
            Set(value As String)
                m_InStock = Value
            End Set
        End Property
        Private m_InStock As String
        Public Property OrderUnits() As String
            Get
                Return m_OrderUnits
            End Get
            Set(value As String)
                m_OrderUnits = Value
            End Set
        End Property
        Private m_OrderUnits As String

        Public Sub New(productName As String, unitQuantity As String, unitPrice As String, inStock As String, orderUnits As String)

            Me.ProductName = productName
            Me.UnitQuantity = unitQuantity
            Me.UnitPrice = unitPrice
            Me.InStock = inStock
            Me.OrderUnits = orderUnits
        End Sub

        Default Public ReadOnly Property Item(i As Integer) As String
            Get
                Select Case i
                    Case 0
                        Return ProductName
                    Case 1
                        Return UnitQuantity
                    Case 2
                        Return UnitPrice
                    Case 3
                        Return InStock
                    Case 4
                        Return OrderUnits
                    Case Else
                        Return [String].Empty
                End Select
            End Get
        End Property
    End Class
End Namespace