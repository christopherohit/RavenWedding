Imports Telerik.WinForms.Documents.UI
Imports Telerik.WinForms.Documents.UI.Layers

Namespace RichTextEditor.SearchHighlight
    Public Class CustomLayersBuilder
        Inherits UILayersBuilder
        Public Property HighlightCurrentWord() As Boolean
            Get
                Return m_HighlightCurrentWord
            End Get
            Set(value As Boolean)
                m_HighlightCurrentWord = Value
            End Set
        End Property
        Private m_HighlightCurrentWord As Boolean
        Public Property HighlightCurrentLine() As Boolean
            Get
                Return m_HighlightCurrentLine
            End Get
            Set(value As Boolean)
                m_HighlightCurrentLine = Value
            End Set
        End Property
        Private m_HighlightCurrentLine As Boolean
        Public Property HighlightSearchResult() As Boolean
            Get
                Return m_HighlightSearchResult
            End Get
            Set(value As Boolean)
                m_HighlightSearchResult = Value
            End Set
        End Property
        Private m_HighlightSearchResult As Boolean

        Protected Overrides Sub BuildUILayersOverride(uiLayerContainer As IUILayerContainer)
            If Me.HighlightCurrentWord Then
                uiLayerContainer.UILayers.AddAfter(DefaultUILayers.HighlightDecoration, New HighlightCurrentWordLayer())
            End If

            If Me.HighlightCurrentLine Then
                uiLayerContainer.UILayers.AddAfter(DefaultUILayers.HighlightDecoration, New HighlightCurrentLineLayer())
            End If

            If Me.HighlightSearchResult Then
                uiLayerContainer.UILayers.AddAfter(DefaultUILayers.HighlightDecoration, New HighlightSearchedWordLayer())
            End If
        End Sub
    End Class
End Namespace