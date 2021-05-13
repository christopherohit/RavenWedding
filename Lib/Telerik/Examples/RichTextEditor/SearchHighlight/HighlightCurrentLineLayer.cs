using System;
using System.Drawing;
using Telerik.WinForms.Documents.Layout;
using Telerik.WinForms.Documents.UI.Layers;

namespace RichTextEditor.SearchHighlight
{
    public class HighlightCurrentLineLayer : DecorationUILayerBase
    {
        private static readonly Brush FillBrush = new SolidBrush(Color.FromArgb(60, 60, 60, 230));

        public override string Name
        {
            get
            {
                return "HighlightCurrentLineLayer";
            }
        }

        public UILayerUpdateContext LastUpdateContext
        {
            get;
            private set;
        }

        public override void UpdateUIViewPortOverride(UILayerUpdateContext context)
        {
            this.LastUpdateContext = context;

            InlineLayoutBox currnetInline = this.Document.CaretPosition.GetCurrentInlineBox();
            ParagraphLineInfo lineInfo = this.Document.CaretPosition.GetCurrentInlineBox().LineInfo;
            float lineY = GetLineY(currnetInline);
            var paragraphRectangle = currnetInline.Parent.ControlBoundingRectangle;

            this.AddRectangle(new RectangleF(
                paragraphRectangle.X,
                lineY,
                paragraphRectangle.Width,
                lineInfo.Height));
        }

        private static float GetLineY(InlineLayoutBox box)
        {
            return box.ControlBoundingRectangle.Top - (box.LineInfo.BaselineOffset - box.BaselineOffset);
        }

        private void AddRectangle(RectangleF rect)
        {
            var rectangle = new Telerik.WinControls.RichTextEditor.UI.Rectangle();
            rectangle.Width = Math.Max(0, rect.Width);
            rectangle.Height = rect.Height;

            rectangle.Fill = FillBrush;

            Telerik.WinControls.RichTextEditor.UI.Canvas.SetTop(rectangle, rect.Top);
            Telerik.WinControls.RichTextEditor.UI.Canvas.SetLeft(rectangle, rect.Left);
            base.AddDecorationElement(rectangle);
        }

        protected override void OnDocumentChanged()
        {
            base.OnDocumentChanged();
            if (this.Document != null)
            {
                this.Document.CaretPosition.PositionChanged += CaretPosition_PositionChanged;
            }
        }

        protected override void OnDocumentChanging()
        {
            base.OnDocumentChanging();
            if (this.Document != null)
            {
                this.Document.CaretPosition.PositionChanged -= CaretPosition_PositionChanged;
            }
        }

        private void CaretPosition_PositionChanged(object sender, EventArgs e)
        {
            this.UpdateViewPort(this.LastUpdateContext);
        }
    }
}
