
Namespace RichTextEditor.SampleData
    Public Class Employee
        Public Property JobTitle() As String
            Get
                Return m_JobTitle
            End Get
            Set(value As String)
                m_JobTitle = Value
            End Set
        End Property
        Private m_JobTitle As String

        Public Property FirstName() As String
            Get
                Return m_FirstName
            End Get
            Set(value As String)
                m_FirstName = Value
            End Set
        End Property
        Private m_FirstName As String

        Public Property LastName() As String
            Get
                Return m_LastName
            End Get
            Set(value As String)
                m_LastName = Value
            End Set
        End Property
        Private m_LastName As String
    End Class
End Namespace