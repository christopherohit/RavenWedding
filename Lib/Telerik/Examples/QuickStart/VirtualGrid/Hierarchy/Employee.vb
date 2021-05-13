Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text

Namespace Telerik.Examples.WinControls.VirtualGrid.Hierarchy
    Public Class Employee
        Public Shared ReadOnly FieldNames As String() = {"Photo", "Name", "Salary", "HireDate", "Title"}

        Private m_Photo As Image
        Private m_Name As String
        Private m_Salary As Decimal
        Private m_HireDate As DateTime
        Private m_Title As String
        Private m_Customers As List(Of Customer)

        Public Property Photo() As Image
            Get
                Return m_Photo
            End Get
            Set(value As Image)
                m_Photo = Value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = Value
            End Set
        End Property

        Public Property Salary() As Decimal
            Get
                Return m_Salary
            End Get
            Set(value As Decimal)
                m_Salary = Value
            End Set
        End Property

        Public Property HireDate() As DateTime
            Get
                Return m_HireDate
            End Get
            Set(value As DateTime)
                m_HireDate = Value
            End Set
        End Property

        Public Property Title() As String
            Get
                Return m_Title
            End Get
            Set(value As String)
                m_Title = Value
            End Set
        End Property

        Public Property Customers() As List(Of Customer)
            Get
                Return m_Customers
            End Get
            Private Set(value As List(Of Customer))
                m_Customers = Value
            End Set
        End Property

        Default Public ReadOnly Property Item(index As Integer) As Object
            Get
                Select Case index
                    Case 0
                        Return Photo
                    Case 1
                        Return Name
                    Case 2
                        Return Salary
                    Case 3
                        Return HireDate
                    Case 4
                        Return Title
                    Case Else
                        Return Nothing
                End Select
            End Get
        End Property

        Public Sub New()
            Me.Customers = New List(Of Customer)()
        End Sub
    End Class
End Namespace