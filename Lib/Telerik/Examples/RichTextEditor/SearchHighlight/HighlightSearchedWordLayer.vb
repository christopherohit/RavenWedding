Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports Telerik.WinForms.Documents
Imports Telerik.WinForms.Documents.DocumentStructure
Imports Telerik.WinForms.Documents.Layout
Imports Telerik.WinForms.Documents.TextSearch
Imports Telerik.WinForms.Documents.UI.Layers

Namespace RichTextEditor.SearchHighlight
	Public Class HighlightSearchedWordLayer
		Inherits DecorationUILayerBase
		Private Shared ReadOnly StrokeThikness As Double = 1.0
		Private Shared ReadOnly StrokeBrush As Brush = New SolidBrush(Color.FromArgb(140, 180, 180, 0))
		Private Shared ReadOnly FillBrush As Brush = New SolidBrush(Color.FromArgb(50, 255, 255, 0))

		Public Overrides ReadOnly Property Name() As String
			Get
				Return "HighlightSearchedWordLayer"
			End Get
		End Property

		Private Shared word_Renamed As String
		Public Shared Property Word() As String
			Get
				Return word_Renamed
			End Get
			Set
				If word_Renamed <> Value Then
					word_Renamed = Regex.Escape(Value)
				End If
			End Set
		End Property
		Public Sub New()

		End Sub
		Public Overrides Sub UpdateUIViewPortOverride(ByVal context As UILayerUpdateContext)

			If String.IsNullOrEmpty(word_Renamed) Then
				Return
			End If

			Me.HighlightOccurrencesInVisibleBoxes(context.GetVisibleTextLayoutBoxes())
		End Sub

		Private Sub HighlightOccurrencesInVisibleBoxes(ByVal spanList As IEnumerable(Of SpanLayoutBox))
			If spanList.Count() = 0 Then
				Return
			End If
			Dim firstBox As SpanLayoutBox = spanList.First()
			Dim lastBox As SpanLayoutBox = spanList.Last()

			Dim searchStart As DocumentPosition = New DocumentPosition(Me.Document)
			Dim searchEnd As DocumentPosition = New DocumentPosition(Me.Document)
			searchStart.MoveToInline(firstBox, 0)
			searchEnd.MoveToInline(lastBox, lastBox.PositionsCountInBox - 1)

			Dim textSearch As DocumentTextSearch = New DocumentTextSearch(Me.Document)

			Dim textRange As TextRange = textSearch.Find(word_Renamed, searchStart, searchEnd)
			Dim count As Integer = 0
			Do While Not textRange Is Nothing
				count += 1
				Dim lineStart As DocumentPosition = New DocumentPosition(textRange.StartPosition)
				Dim lineEnd As DocumentPosition = New DocumentPosition(lineStart)
				lineEnd.MoveToCurrentLineEnd()
				Do While lineEnd < textRange.EndPosition
					Me.FlushBoxes(lineStart, lineEnd)
					lineStart.MoveToCurrentLineEnd()
					lineStart.MoveToNext()
					lineEnd.MoveToNext()
					lineEnd.MoveToCurrentLineEnd()
				Loop
				Me.FlushBoxes(lineStart, textRange.EndPosition)

				searchStart.MoveToPosition(textRange.EndPosition)
				If searchStart >= searchEnd Then
					Exit Do
				End If
				textRange = textSearch.Find(word_Renamed, searchStart, searchEnd)
			Loop
		End Sub

		Private Sub FlushBoxes(ByVal startPosition As DocumentPosition, ByVal endPosition As DocumentPosition)
			If startPosition Is endPosition Then
				Return
			End If
			Dim rect As RectangleF = New RectangleF()

			rect.X = startPosition.Location.X
			rect.Width = endPosition.Location.X - startPosition.Location.X

			Dim startBox As InlineLayoutBox = startPosition.GetCurrentInlineBox()
			Dim endBox As InlineLayoutBox = endPosition.GetCurrentInlineBox()

			Dim top As Single = startBox.ControlBoundingRectangle.Top
			Dim bottom As Single = startBox.ControlBoundingRectangle.Bottom

			Do While Not startBox Is endBox
				startBox = TryCast(DocumentStructureCollection.GetNextSiblingForDocumentElementOnSameLevel(startBox, startBox.AssociatedDocumentElement), InlineLayoutBox)
				If startBox Is Nothing Then
					Exit Do
				End If
				If startBox.ControlBoundingRectangle.Top < top Then
					top = startBox.ControlBoundingRectangle.Top
				End If
				If startBox.ControlBoundingRectangle.Bottom < bottom Then
					bottom = startBox.ClippedControlBoundingRectangle.Bottom
				End If
			Loop
			rect.Y = top
			rect.Height = bottom - top

			Me.AddRectangle(rect)
		End Sub

		Private Sub AddRectangle(ByVal rect As RectangleF)
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
	End Class
End Namespace
