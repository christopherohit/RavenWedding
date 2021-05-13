Namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
    <Serializable()> _
    Public Class Album
        'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow class members with the same name:
        Private id As Integer
        'INSTANT VB NOTE: The variable artistId was renamed since Visual Basic does not allow class members with the same name:
        Private artistId As Integer
        'INSTANT VB NOTE: The variable title was renamed since Visual Basic does not allow class members with the same name:
        Private title As String
        'INSTANT VB NOTE: The variable tracks was renamed since Visual Basic does not allow class members with the same name:
        Private tracks As New List(Of Track)()

        Public Sub New()

        End Sub

        Public Sub New(ByVal id As Integer, ByVal artistId As Integer, ByVal title As String)
            Me.id = id
            Me.artistId = artistId
            Me.title = title
        End Sub

        Public Property Id1() As Integer
            Get
                Return Id
            End Get
            Set(ByVal value As Integer)
                id = value
            End Set
        End Property

        Public Property ArtistId1() As Integer
            Get
                Return artistId
            End Get
            Set(ByVal value As Integer)
                artistId = value
            End Set
        End Property

        Public Property Title1() As String
            Get
                Return title
            End Get
            Set(ByVal value As String)
                title = value
            End Set
        End Property

        Public ReadOnly Property Tracks1() As List(Of Track)
            Get
                Return Me.tracks
            End Get
        End Property
    End Class
End Namespace
