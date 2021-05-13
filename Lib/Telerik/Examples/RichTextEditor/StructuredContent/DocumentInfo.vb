Namespace RichTextEditor.StructuredContent
    Public Class DocumentInfo
#Region "Properties"

        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = Value
            End Set
        End Property
        Private m_Name As String
        Public Property Path() As String
            Get
                Return m_Path
            End Get
            Set(value As String)
                m_Path = Value
            End Set
        End Property
        Private m_Path As String

#End Region

#Region "Constructors"

        Public Sub New(name As String, path As String)
            Me.Name = name
            Me.Path = path
        End Sub

#End Region

#Region "Methods"

        Public Overrides Function ToString() As String
            Return Me.Name
        End Function

#End Region
    End Class
End Namespace
