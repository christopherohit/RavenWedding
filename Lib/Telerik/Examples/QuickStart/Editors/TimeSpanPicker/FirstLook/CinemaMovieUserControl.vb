Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
    Public Partial Class CinemaMovieUserControl
        Inherits UserControl

        Private Const DefaultHeight As Integer = 100
        Private movieInfoField As CinemaMovieInfo

        Public Sub New(ByVal movieInfo As CinemaMovieInfo)
            InitializeComponent()
            Me.movieInfoField = movieInfo
            Me.SynchronizeValues()
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            Dim rect As Rectangle = Me.ClientRectangle
            rect.Width -= 1
            rect.Height -= 1
            e.Graphics.DrawRectangle(Pens.LightGray, rect)
        End Sub

        Public ReadOnly Property MovieInfo As CinemaMovieInfo
            Get
                Return Me.movieInfoField
            End Get
        End Property

        Private Sub SynchronizeValues()
            Me.imageLabel.Image = Me.MovieInfo.GenreIcon
            Me.movieNameLabel.Text = Me.MovieInfo.Title
            Me.genreLabel.Text = Me.MovieInfo.Genre
            Me.descriptionLabel.Text = Me.MovieInfo.Description
            Me.startTimeLabel.Text = String.Format("Start Time - {0:t}", Me.MovieInfo.StartTime)
            Me.durationLabel.Text = String.Format("Duration - {0:t}", Me.MovieInfo.Duration)
        End Sub

       Public Function GetDesiredSize(ByVal maximalWidth As Integer, ByVal dpiScaleFactor As SizeF) As Size
            Dim height As Integer = TelerikDpiHelper.ScaleInt(DefaultHeight, dpiScaleFactor)
            Dim labelMaxWidth As Integer = maximalWidth - Me.Padding.Horizontal - Me.imageLabel.Width
            labelMaxWidth = TelerikDpiHelper.ScaleInt(labelMaxWidth, New SizeF(1 / dpiScaleFactor.Width, 1 / dpiScaleFactor.Height))

            Me.descriptionLabel.MaximumSize = New Size(labelMaxWidth, 0)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()

            Return New Size(maximalWidth, Me.descriptionLabel.Height + height)
        End Function
    End Class
End Namespace
