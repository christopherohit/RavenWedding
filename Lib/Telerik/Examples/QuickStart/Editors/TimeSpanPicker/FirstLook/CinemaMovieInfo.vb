Imports System
Imports System.Drawing

Namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
    Public Class CinemaMovieInfo
        Public Property StartTime As DateTime
        Public Property EndTime As DateTime
        Public Property Title As String
        Public Property Description As String
        Public Property Genre As String
        Public Property ReleaseDate As DateTime
        Public Property StartFilmingDate As DateTime
        Public Property GenreIcon As Bitmap

        Public ReadOnly Property FilmingDuration As TimeSpan
            Get
                Return Me.ReleaseDate.Subtract(Me.StartFilmingDate)
            End Get
        End Property

        Public ReadOnly Property Duration As TimeSpan
            Get
                Return Me.EndTime.Subtract(Me.StartTime)
            End Get
        End Property
    End Class
End Namespace