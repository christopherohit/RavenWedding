Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text

Namespace Telerik.Examples.WinControls.VirtualGrid.Settings
    Public Class Employee
        Public Shared ReadOnly FieldNames As String() = {"Photo", "Name", "Salary", "HireDate", "Title"}

        Private m_Photo As Image
        Private m_Name As String
        Private m_Salary As Decimal
        Private m_HireDate As DateTime
        Private m_Title As String

        Public Property Photo() As Image
            Get
                Return m_Photo
            End Get
            Set(value As Image)
                m_Photo = value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = value
            End Set
        End Property

        Public Property Salary() As Decimal
            Get
                Return m_Salary
            End Get
            Set(value As Decimal)
                m_Salary = value
            End Set
        End Property

        Public Property HireDate() As DateTime
            Get
                Return m_HireDate
            End Get
            Set(value As DateTime)
                m_HireDate = value
            End Set
        End Property

        Public Property Title() As String
            Get
                Return m_Title
            End Get
            Set(value As String)
                m_Title = value
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
    End Class
End Namespace