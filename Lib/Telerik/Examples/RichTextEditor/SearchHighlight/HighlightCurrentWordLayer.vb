Imports System.Collections.Generic
Imports System.Drawing
'using System.Drawing;
Imports System.Linq
Imports System.Text
Imports Telerik.WinForms.Documents
Imports Telerik.WinForms.Documents.Layout
Imports Telerik.WinForms.Documents.Selection
Imports Telerik.WinForms.Documents.UI.Layers
Imports System

Namespace RichTextEditor.SearchHighlight
    Public Class HighlightCurrentWordLayer
        Inherits DecorationUILayerBase
        Private Shared ReadOnly StrokeThikness As Double = 1.0
        Private Shared ReadOnly StrokeBrush As Brush = New SolidBrush(Color.FromArgb(140, 60, 60, 60))
        Private Shared ReadOnly FillBrush As Brush = New SolidBrush(Color.FromArgb(60, 140, 140, 140))

        Public Overrides ReadOnly Property Name() As String
            Get
                Return "HighlightCurrentWordLayer"
            End Get
        End Property

        Public Property LastUpdateContext() As UILayerUpdateContext
            Get
                Return m_LastUpdateContext
            End Get
            Private Set(value As UILayerUpdateContext)
                m_LastUpdateContext = value
            End Set
        End Property
        Private m_LastUpdateContext As UILayerUpdateContext

        Public Overrides Sub UpdateUIViewPortOverride(context As UILayerUpdateContext)
            Me.LastUpdateContext = context

            Dim currentWord As String = Me.GetCurrentWord()
            If String.IsNullOrEmpty(currentWord) Then
                Return
            End If

            Dim list As New List(Of SpanLayoutBox)()
            Dim currentParagraphBox As LayoutBox = Nothing
            For Each spanBox As SpanLayoutBox In context.GetVisibleTextLayoutBoxes()
                If spanBox.IsFormattingSymbol Then
                    Me.FlushBoxes(list, currentWord)
                ElseIf currentParagraphBox IsNot Nothing AndAlso Not currentParagraphBox.Equals(spanBox.Parent) Then
                    Me.FlushBoxes(list, currentWord)
                    list.Add(spanBox)
                Else
                    list.Add(spanBox)
                End If

                currentParagraphBox = spanBox.Parent
            Next
            Me.FlushBoxes(list, currentWord)

        End Sub

        Private Sub FlushBoxes(spanList As List(Of SpanLayoutBox), word As String)
            If spanList.Count = 0 Then
                Return
            End If

            Dim builder As New StringBuilder()
            spanList.ForEach(Function(spanBox As SpanLayoutBox) builder.Append(spanBox.Text))

            If builder.ToString() = word Then
                Dim rect As New RectangleF()
                rect.X = spanList(0).ControlBoundingRectangle.Left
                rect.Width = spanList(spanList.Count - 1).ControlBoundingRectangle.Right - rect.X

                rect.Y = spanList.Min(Function(s As SpanLayoutBox) s.ControlBoundingRectangle.Top)
                rect.Height = spanList.Min(Function(s As SpanLayoutBox) s.ControlBoundingRectangle.Bottom) - rect.Y

                Me.AddRectangle(rect)
            End If

            spanList.Clear()
        End Sub

        Private Sub AddRectangle(rect As RectangleF)
            Dim rectangle = New Telerik.WinControls.RichTextEditor.UI.Rectangle()
            rectangle.Width = Math.Max(0, rect.Width + 2 * StrokeThikness)
            rectangle.Height = rect.Height + 2 * StrokeThikness

            rectangle.Fill = FillBrush
            rectangle.Stroke = StrokeBrush
            rectangle.StrokeThickness = StrokeThikness

            Telerik.WinControls.RichTextEditor.UI.Canvas.SetTop(rectangle, rect.Top - StrokeThikness)
            Telerik.WinControls.RichTextEditor.UI.Canvas.SetLeft(rectangle, rect.Left - StrokeThikness)
            MyBase.AddDecorationElement(rectangle)
        End Sub

        Private Function GetCurrentWord() As String
            Dim pos As New DocumentPosition(Me.Document.CaretPosition)
            pos.MoveToCurrentWordStart()

            Dim selection As New DocumentSelection(Me.Document)
            selection.AddSelectionStart(pos)

            pos.MoveToCurrentWordEnd()
            selection.AddSelectionEnd(pos)

            Return selection.GetSelectedText().Trim()
        End Function

        Protected Overrides Sub OnDocumentChanged()
            MyBase.OnDocumentChanged()
            If Me.Document IsNot Nothing Then
                AddHandler Me.Document.CaretPosition.PositionChanged, AddressOf CaretPosition_PositionChanged
            End If
        End Sub

        Protected Overrides Sub OnDocumentChanging()
            MyBase.OnDocumentChanging()
            If Me.Document IsNot Nothing Then
                RemoveHandler Me.Document.CaretPosition.PositionChanged, AddressOf CaretPosition_PositionChanged
            End If
        End Sub

        Private Sub CaretPosition_PositionChanged(sender As Object, e As EventArgs)
            Me.UpdateViewPort(Me.LastUpdateContext)
        End Sub
    End Class
End Namespace