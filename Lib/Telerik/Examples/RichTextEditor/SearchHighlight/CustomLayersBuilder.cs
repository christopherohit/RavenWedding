using Telerik.WinForms.Documents.UI;
using Telerik.WinForms.Documents.UI.Layers;

namespace RichTextEditor.SearchHighlight
{
    public class CustomLayersBuilder : UILayersBuilder
    {
        public bool HighlightCurrentWord { get; set; }
        public bool HighlightCurrentLine { get; set; }
        public bool HighlightSearchResult { get; set; }

        protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
        {
            if (this.HighlightCurrentWord)
            {
                uiLayerContainer.UILayers.AddAfter(DefaultUILayers.HighlightDecoration, new HighlightCurrentWordLayer());
            }

            if (this.HighlightCurrentLine)
            {
                uiLayerContainer.UILayers.AddAfter(DefaultUILayers.HighlightDecoration, new HighlightCurrentLineLayer());
            }

            if (this.HighlightSearchResult)
            {
                uiLayerContainer.UILayers.AddAfter(DefaultUILayers.HighlightDecoration, new HighlightSearchedWordLayer());
            }
        }
    }
}
