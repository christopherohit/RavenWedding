using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinForms.RichTextEditor;
using Telerik.WinForms.Documents.Layout;
using Telerik.WinForms.Documents.Model;
using Telerik.WinForms.Documents.Model.Styles;
using Telerik.WinForms.Documents.UI.TextDecorations.DecorationProviders;

namespace RichTextEditorRibbonUI
{
    public class StyleUIHelper
    {
        private Span spanStyle;
        private Paragraph paragraphStyle;
        private RadDocument document;

        public StyleUIHelper(RadRichTextBox owner)
        {
            this.spanStyle = owner != null ? owner.CurrentSpanStyle : new Span();
            this.paragraphStyle = owner != null ? owner.CurrentParagraphStyle : new Paragraph();
            this.document = owner.Document;
        }

        public bool GetIsBulleted()
        {
            return this.paragraphStyle.IsInBulletedList(this.document);
        }

        public bool GetIsNumbered()
        {
            return this.paragraphStyle.IsInNumberedList(this.document);
        }

        public FontWeight? GetFontWeightOfSpanStyle()
        {
            FontWeight? fontWeight = this.spanStyle.FontWeight;
            if (this.spanStyle.GetPropertyValueSource(Span.FontWeightProperty) == RadValueSource.Default)
            {
                fontWeight = null;
            }
            return fontWeight;
        }

        public FontStyle? GetFontStyleOfSpanStyle()
        {
            FontStyle? fontStyle = this.spanStyle.FontStyle;
            if (this.spanStyle.GetPropertyValueSource(Span.FontWeightProperty) == RadValueSource.Default)
            {
                fontStyle = null;
            }
            return fontStyle;
        }

        public FontFamily GetFontFamilyOfSpanStyle()
        {
            FontFamily fontFamily = this.spanStyle.FontFamily;
            if (this.spanStyle.GetPropertyValueSource(Span.FontFamilyProperty) == RadValueSource.Default)
            {
                fontFamily = default(FontFamily);
            }
            return fontFamily;
        }

        public double? GetFontSizeOfSpanStyle()
        {
            double? fontSize = this.spanStyle.FontSize;
            if (this.spanStyle.GetPropertyValueSource(Span.FontSizeProperty) == RadValueSource.Default)
            {
                fontSize = null;
            }
            return fontSize;
        }

        public RadTextAlignment? GetTextAlignmentOfParagraphStyle()
        {
            RadTextAlignment? textAlignment = this.paragraphStyle.TextAlignment;
            if (this.paragraphStyle.GetPropertyValueSource(Paragraph.TextAlignmentProperty) == RadValueSource.Default)
            {
                textAlignment = null;
            }
            return textAlignment;
        }

        public Color? GetForeColorOfSpanStyle()
        {
            Color? foreColor = this.spanStyle.ForeColor;
            if (this.spanStyle.GetPropertyValueSource(Span.ForeColorProperty) == RadValueSource.Default)
            {
                foreColor = null;
            }
            return foreColor;
        }

        public Color? GetHighlightColorOfSpanStyle()
        {
            Color? highlightColor = this.spanStyle.HighlightColor;
            if (this.spanStyle.GetPropertyValueSource(Span.HighlightColorProperty) == RadValueSource.Default)
            {
                highlightColor = null;
            }
            return highlightColor;
        }

        public IUnderlineUIDecorationProvider GetUnderlineDecoration()
        {
            IUnderlineUIDecorationProvider underlineProvider = this.spanStyle.UnderlineDecoration;
            if (this.spanStyle.GetPropertyValueSource(Span.UnderlineDecorationProperty) == RadValueSource.Default)
            {
                underlineProvider = null;
            }
            return underlineProvider;
        }

        public Telerik.WinForms.Documents.Model.BaselineAlignment? GetBaselineAlignment()
        {
            Telerik.WinForms.Documents.Model.BaselineAlignment? alignment = this.spanStyle.BaselineAlignment;
            if (this.spanStyle.GetPropertyValueSource(Span.BaselineAlignmentProperty) == RadValueSource.Default)
            {
                alignment = null;
            }
            return alignment;
        }

        public bool? GetStrikeThroughOfSpanStyle()
        {
            bool? strikeThrough = this.spanStyle.Strikethrough;
            if (this.spanStyle.GetPropertyValueSource(Span.StrikethroughProperty) == RadValueSource.Default)
            {
                strikeThrough = null;
            }
            return strikeThrough;
        }

        public bool? GetUnderline()
        {
            bool? underline = this.spanStyle.Underline;
            if (this.spanStyle.GetPropertyValueSource(Span.UnderlineDecorationProperty) == RadValueSource.Default)
            {
                underline = null;
            }
            return underline;
        }

        public FlowDirection? GetParagraphTextFlowDirection()
        {
            FlowDirection? flowDirection = this.paragraphStyle.FlowDirection;

            if (this.paragraphStyle.GetPropertyValueSource(Span.FlowDirectionProperty) == RadValueSource.Default)
            {
                flowDirection = null;
            }

            return flowDirection;
        }
    }
}
