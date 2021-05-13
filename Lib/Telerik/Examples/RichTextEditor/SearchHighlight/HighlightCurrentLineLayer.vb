Imports System.Drawing
Imports Telerik.WinForms.Documents.Layout
Imports Telerik.WinForms.Documents.UI.Layers
Imports System

Namespace RichTextEditor.SearchHighlight
    Public Class HighlightCurrentLineLayer
        Inherits DecorationUILayerBase
        Private Shared ReadOnly FillBrush As Brush = New SolidBrush(Color.FromArgb(60, 60, 60, 230))

        Public Overrides ReadOnly Property Name() As String
            Get
                Return "HighlightCurrentLineLayer"
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

            Dim currnetInline As InlineLayoutBox = Me.Document.CaretPosition.GetCurrentInlineBox()
            Dim lineInfo As ParagraphLineInfo = Me.Document.CaretPosition.GetCurrentInlineBox().LineInfo
            Dim lineY As Single = GetLineY(currnetInline)
            Dim paragraphRectangle = currnetInline.Parent.ControlBoundingRectangle

            Me.AddRectangle(New RectangleF(paragraphRectangle.X, lineY, paragraphRectangle.Width, lineInfo.Height))
        End Sub

        Private Shared Function GetLineY(box As InlineLayoutBox) As Single
            Return box.ControlBoundingRectangle.Top - (box.LineInfo.BaselineOffset - box.BaselineOffset)
        End Function

        Private Sub AddRectangle(rect As RectangleF)
            Dim rectangle = New Telerik.WinControls.RichTextEditor.UI.Rectangle()
            rectangle.Width = Math.Max(0, rect.Width)
            rectangle.Height = rect.Height

            rectangle.Fill = FillBrush

            Telerik.WinControls.RichTextEditor.UI.Canvas.SetTop(rectangle, rect.Top)
            Telerik.WinControls.RichTextEditor.UI.Canvas.SetLeft(rectangle, rect.Left)
            MyBase.AddDecorationElement(rectangle)
        End Sub

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
