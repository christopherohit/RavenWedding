Imports System.Collections.Generic
Imports System.Text

Namespace Telerik.Examples.WinControls.VirtualGrid.Hierarchy
    Public Class Sale
        Public Shared ReadOnly FieldNames As String() = {"ProductNumber", "Quantity", "Discount", "Total"}

        Private m_ProductNumber As Integer
        Private m_Quantity As Integer
        Private m_Discount As Integer
        Private m_Total As Integer

        Public Property ProductNumber() As Integer
            Get
                Return m_ProductNumber
            End Get
            Set(value As Integer)
                m_ProductNumber = Value
            End Set
        End Property

        Public Property Quantity() As Integer
            Get
                Return m_Quantity
            End Get
            Set(value As Integer)
                m_Quantity = Value
            End Set
        End Property

        Public Property Discount() As Integer
            Get
                Return m_Discount
            End Get
            Set(value As Integer)
                m_Discount = Value
            End Set
        End Property

        Public Property Total() As Integer
            Get
                Return m_Total
            End Get
            Set(value As Integer)
                m_Total = Value
            End Set
        End Property

        Default Public ReadOnly Property Item(index As Integer) As Object
            Get
                Select Case index
                    Case 0
                        Return ProductNumber
                    Case 1
                        Return Quantity
                    Case 2
                        Return Discount
                    Case 3
                        Return Total
                    Case Else
                        Return Nothing
                End Select
            End Get
        End Property
    End Class
End Namespace