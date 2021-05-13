using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Telerik.WinForms.Documents;
using Telerik.WinForms.Documents.DocumentStructure;
using Telerik.WinForms.Documents.Layout;
using Telerik.WinForms.Documents.TextSearch;
using Telerik.WinForms.Documents.UI.Layers;

namespace RichTextEditor.SearchHighlight
{
    public class HighlightSearchedWordLayer : DecorationUILayerBase
    {
        private static readonly double StrokeThikness = 1.0;
        private static readonly Brush StrokeBrush = new SolidBrush(Color.FromArgb(140, 180, 180, 0));
        private static readonly Brush FillBrush = new SolidBrush(Color.FromArgb(50, 255, 255, 0));

        public override string Name
        {
            get
            {
                return "HighlightSearchedWordLayer";
            }
        }

        private static string word;
        public static string Word
        {
            get
            {
                return word;
            }
            set
            {
                if (word != value)
                {
                    word = Regex.Escape(value);
                }
            }
        }
        public HighlightSearchedWordLayer()
        {

        }
        public override void UpdateUIViewPortOverride(UILayerUpdateContext context)
        {
      
            if (string.IsNullOrEmpty(word))
            {
                return;
            }

            this.HighlightOccurrencesInVisibleBoxes(context.GetVisibleTextLayoutBoxes());
        }

        private void HighlightOccurrencesInVisibleBoxes(IEnumerable<SpanLayoutBox> spanList)
        {
            if (spanList.Count() == 0)
            {
                return;
            }
            SpanLayoutBox firstBox = spanList.First();
            SpanLayoutBox lastBox = spanList.Last();

            DocumentPosition searchStart = new DocumentPosition(this.Document);
            DocumentPosition searchEnd = new DocumentPosition(this.Document);
            searchStart.MoveToInline(firstBox, 0);
            searchEnd.MoveToInline(lastBox, lastBox.PositionsCountInBox - 1);

            DocumentTextSearch textSearch = new DocumentTextSearch(this.Document);

            TextRange textRange = textSearch.Find(word, searchStart, searchEnd);
            int count = 0;
            while (textRange != null)
            {
                count++;
                DocumentPosition lineStart = new DocumentPosition(textRange.StartPosition);
                DocumentPosition lineEnd = new DocumentPosition(lineStart);
                lineEnd.MoveToCurrentLineEnd();
                while (lineEnd < textRange.EndPosition)
                {
                    this.FlushBoxes(lineStart, lineEnd);
                    lineStart.MoveToCurrentLineEnd();
                    lineStart.MoveToNext();
                    lineEnd.MoveToNext();
                    lineEnd.MoveToCurrentLineEnd();
                }
                this.FlushBoxes(lineStart, textRange.EndPosition);

                searchStart.MoveToPosition(textRange.EndPosition);
                if (searchStart >= searchEnd)
                {
                    break;
                }
                textRange = textSearch.Find(word, searchStart, searchEnd);                
            }
        }

        private void FlushBoxes(DocumentPosition startPosition, DocumentPosition endPosition)
        {
            if (startPosition == endPosition)
            {
                return;
            }
            RectangleF rect = new RectangleF();

            rect.X = startPosition.Location.X;
            rect.Width = endPosition.Location.X - startPosition.Location.X;

            InlineLayoutBox startBox = startPosition.GetCurrentInlineBox();
            InlineLayoutBox endBox = endPosition.GetCurrentInlineBox();

            float top = startBox.ControlBoundingRectangle.Top;
            float bottom = startBox.ControlBoundingRectangle.Bottom;

            while (startBox != endBox)
            {
                startBox = DocumentStructureCollection.GetNextSiblingForDocumentElementOnSameLevel(startBox, startBox.AssociatedDocumentElement) as InlineLayoutBox;
                if (startBox == null)
                {
                    break;
                }
                if (startBox.ControlBoundingRectangle.Top < top)
                {
                    top = startBox.ControlBoundingRectangle.Top;
                }
                if (startBox.ControlBoundingRectangle.Bottom < bottom)
                {
                    bottom = startBox.ClippedControlBoundingRectangle.Bottom;
                }
            }
            rect.Y = top;
            rect.Height = bottom - top;

            this.AddRectangle(rect);
        }

        private void AddRectangle(RectangleF rect)
        {
            var rectangle = new Telerik.WinControls.RichTextEditor.UI.Rectangle();
            rectangle.Width = Math.Max(0, rect.Width + 2 * StrokeThikness);
            rectangle.Height = rect.Height + 2 * StrokeThikness;

            rectangle.Fill = FillBrush;
            rectangle.Stroke = StrokeBrush;
            rectangle.StrokeThickness = StrokeThikness;

            Telerik.WinControls.RichTextEditor.UI.Canvas.SetTop(rectangle, rect.Top - StrokeThikness);
            Telerik.WinControls.RichTextEditor.UI.Canvas.SetLeft(rectangle, rect.Left - StrokeThikness);
            base.AddDecorationElement(rectangle);
        }
    }
}
