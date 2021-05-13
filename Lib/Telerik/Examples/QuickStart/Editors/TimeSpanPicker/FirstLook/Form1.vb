Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
    Public Partial Class Form1
        Inherits EditorExampleBaseForm

        Private moviesUserControlsField As IDictionary(Of CinemaMovieInfo, CinemaMovieUserControl)

        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.cinemaProgramLabel.Text += DateTime.Now.ToShortDateString()
            Me.UpdateLabels()
            Me.FilterMovies()
            Me.CreatePopupClearButton(Me.durationTimeSpanPicker)
            Me.CreatePopupClearButton(Me.minStartTimeTimeSpanPicker)
        End Sub

        Private Sub CreatePopupClearButton(ByVal timeSpanPicker As RadTimeSpanPicker)
            Dim buttonPanel As TimeSpanPickerDoneButtonElement = (TryCast(timeSpanPicker.PopupContentElement, RadTimeSpanPickerContentElement)).FooterPanel
            Dim clearButton As RadButtonElement = New RadButtonElement("Clear")
            AddHandler clearButton.Click, AddressOf ClearButton_Click
            buttonPanel.LayoutPanel.Children.Add(clearButton)
        End Sub

        Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim button As RadButtonElement = CType(sender, RadButtonElement)
            Dim buttonPanel As TimeSpanPickerDoneButtonElement = button.FindAncestor(Of TimeSpanPickerDoneButtonElement)()
            buttonPanel.Owner.SetValueAndClose(Nothing)
        End Sub

        Protected Overrides Sub WireEvents()
            MyBase.WireEvents()
            AddHandler Me.durationTimeSpanPicker.PopupContentElement.ComponentsCreated, AddressOf PopupContentElement_ComponentsCreated
        End Sub

        Public Sub SetupMovies()
            Me.moviesUserControlsField = New Dictionary(Of CinemaMovieInfo, CinemaMovieUserControl)()
            Dim movies As IList(Of CinemaMovieInfo) = CinemaMovieRepository.LoadMovies()

            For Each movieInfo As CinemaMovieInfo In movies
                Dim userControl As CinemaMovieUserControl = New CinemaMovieUserControl(movieInfo)
                Me.moviesUserControlsField.Add(movieInfo, userControl)
            Next
        End Sub

        Public ReadOnly Property MoviesUserControls As IDictionary(Of CinemaMovieInfo, CinemaMovieUserControl)
            Get

                If Me.moviesUserControlsField Is Nothing Then
                    Me.SetupMovies()
                End If

                Return Me.moviesUserControlsField
            End Get
        End Property

        Private Sub MoviesScrollablePanel_RootElement_DpiScaleFactorChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ArrangeMovieUserControls()
        End Sub

        Private Sub PopupContentElement_ComponentsCreated(ByVal sender As Object, ByVal e As EventArgs)
            Dim contentElement As ITimeSpanPickerContentElement = TryCast(sender, ITimeSpanPickerContentElement)
            contentElement.Components.Clear()
            Dim durationComponent As MovieDurationTimeSpanPickerComponent = New MovieDurationTimeSpanPickerComponent(contentElement)
            contentElement.Components.Add(durationComponent)
        End Sub

        Private Sub MovieFilterTimeSpanPicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.FilterMovies()
            Me.UpdateLabels()
        End Sub

        Private Sub UpdateLabels()
            Dim selectedDuration As TimeSpan? = Me.durationTimeSpanPicker.Value
            Dim selectedMinStartTime As TimeSpan? = Me.minStartTimeTimeSpanPicker.Value
            Dim cinemaProgramHeader As String = String.Empty

            If selectedMinStartTime Is Nothing AndAlso selectedDuration Is Nothing Then
                cinemaProgramHeader = "All movies screening today"
            Else

                If selectedMinStartTime IsNot Nothing AndAlso selectedDuration Is Nothing Then

                    If DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).Date.CompareTo(DateTime.Now.Date) = 0 Then
                        cinemaProgramHeader = "Movies starting today after " & DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).ToShortTimeString()
                    Else
                        cinemaProgramHeader = "The program for " & DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).ToString("d") & " is not available yet!"
                    End If
                Else

                    If selectedMinStartTime Is Nothing Then
                        cinemaProgramHeader = "Movies with minimum duration of " & selectedDuration.Value.TotalMinutes & " minutes"
                    Else

                        If DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).Date.CompareTo(DateTime.Now.Date) = 0 Then
                            cinemaProgramHeader = "Movies starting today after " & DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).ToShortTimeString() & " with minimum duration " & selectedDuration.Value.TotalMinutes & " minutes"
                        Else
                            cinemaProgramHeader = "The program for " & DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).ToString("d") & " is not available yet!"
                        End If
                    End If
                End If
            End If

            Me.moviesStartingAfterLabel.Text = cinemaProgramHeader
        End Sub

        Private Sub FilterMovies()
            Dim filteredMovies As IList(Of CinemaMovieInfo) = New List(Of CinemaMovieInfo)()

            For Each movieInfo As CinemaMovieInfo In Me.MoviesUserControls.Keys
                Dim shouldAdd As Boolean = False
                Dim selectedDuration As TimeSpan? = Me.durationTimeSpanPicker.Value
                Dim selectedMinStartTime As TimeSpan? = Me.minStartTimeTimeSpanPicker.Value

                If selectedMinStartTime IsNot Nothing Then
                    shouldAdd = (DateTime.Now + selectedMinStartTime.Value) <= movieInfo.StartTime AndAlso (selectedDuration Is Nothing OrElse selectedDuration.Value <= movieInfo.Duration)
                Else
                    shouldAdd = selectedDuration Is Nothing OrElse selectedDuration.Value <= movieInfo.Duration
                End If

                If shouldAdd Then
                    filteredMovies.Add(movieInfo)
                End If
            Next

            Me.UpdateMovies(filteredMovies)
        End Sub

        Private Sub UpdateMovies(ByVal filteredMovies As IList(Of CinemaMovieInfo))
            For Each control As CinemaMovieUserControl In Me.MoviesUserControls.Values
                control.Visible = False
            Next

            For Each movieInfo As CinemaMovieInfo In filteredMovies
                Dim movieUserControl As CinemaMovieUserControl = Me.MoviesUserControls(movieInfo)
                movieUserControl.Visible = True

                If Not Me.moviesScrollablePanel.PanelContainer.Controls.Contains(movieUserControl) Then
                    Me.moviesScrollablePanel.PanelContainer.Controls.Add(movieUserControl)
                End If
            Next

            Me.ArrangeMovieUserControls()
        End Sub

        Private Sub ArrangeMovieUserControls()
            Me.moviesScrollablePanel.VerticalScrollbar.Value = 0
            Dim userControls As IOrderedEnumerable(Of CinemaMovieUserControl) = Me.moviesScrollablePanel.PanelContainer.Controls.OfType(Of CinemaMovieUserControl)().Where(Function(c) c.Visible = True).OrderBy(Function(c) c.MovieInfo.StartTime)
            Dim currentLocation As Point = New Point(5, 5)
            Dim width As Integer = Me.moviesScrollablePanel.PanelContainer.Width
            Dim dpiScaleFactor As SizeF = New SizeF(1.0F, 1.0F)

            If Me.moviesScrollablePanel IsNot Nothing AndAlso Me.moviesScrollablePanel.RootElement IsNot Nothing Then
                dpiScaleFactor = Me.moviesScrollablePanel.RootElement.DpiScaleFactor
            End If

            width -= TelerikDpiHelper.ScaleInt(SystemInformation.VerticalScrollBarWidth, dpiScaleFactor)

            For Each movieUserControl As CinemaMovieUserControl In userControls
                currentLocation.Y += movieUserControl.Margin.Top
                movieUserControl.Location = currentLocation
                Dim controlWidth As Integer = width - movieUserControl.Margin.Horizontal
                movieUserControl.Size = movieUserControl.GetDesiredSize(controlWidth, dpiScaleFactor)
                currentLocation.Y += movieUserControl.Height + movieUserControl.Margin.Bottom
            Next
        End Sub
    End Class
End Namespace
