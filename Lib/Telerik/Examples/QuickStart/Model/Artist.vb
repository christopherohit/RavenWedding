Namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
    'Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational.Artist
    <Serializable()> _
    Public Class Artist
        'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow class members with the same name:
        Private id As Integer
        'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
        Private name As String
        'INSTANT VB NOTE: The variable albums was renamed since Visual Basic does not allow class members with the same name:
        Private albums As New List(Of Album)()

        Public Sub New()

        End Sub

        Public Sub New(ByVal id As Integer, ByVal name As String)
            Me.id = id
            Me.name = name
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

        Public ReadOnly Property Albums1() As List(Of Album)
            Get
                Return albums
            End Get
        End Property
    End Class
End Namespace
