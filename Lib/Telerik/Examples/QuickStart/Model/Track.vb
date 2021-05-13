Namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
    <Serializable()> _
    Public Class Track
        'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow class members with the same name:
        Private id As Integer
        'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
        Private name As String
        'INSTANT VB NOTE: The variable mediaType was renamed since Visual Basic does not allow class members with the same name:
        Private mediaType As String
        'INSTANT VB NOTE: The variable genre was renamed since Visual Basic does not allow class members with the same name:
        Private genre As String
        'INSTANT VB NOTE: The variable size was renamed since Visual Basic does not allow class members with the same name:
        Private size As String

        Public Sub New()

        End Sub

        Public Sub New(ByVal id As Integer, ByVal name As String, ByVal mediaType As String, ByVal genre As String, ByVal size As String)
            Me.id = id
            Me.name = name
            Me.mediaType = mediaType
            Me.genre = genre
            Me.size = size
        End Sub

        Public Property Id1() As Integer
            Get
                Return id
            End Get
            Set(ByVal value As Integer)
                id = value
            End Set
        End Property

        Public Property Name1() As String
            Get
                Return name
            End Get
            Set(ByVal value As String)
                name = value
            End Set
        End Property

        Public Property MediaType1() As String
            Get
                Return mediaType
            End Get
            Set(ByVal value As String)
                mediaType = value
            End Set
        End Property

        Public Property Genre1() As String
            Get
                Return genre
            End Get
            Set(ByVal value As String)
                genre = value
            End Set
        End Property

        Public Property Size1() As String
            Get
                Return size
            End Get
            Set(ByVal value As String)
                size = value
            End Set
        End Property
    End Class
End Namespace
