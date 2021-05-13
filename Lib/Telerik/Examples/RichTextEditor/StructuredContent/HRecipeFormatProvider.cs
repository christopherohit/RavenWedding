using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Telerik.WinForms.Controls;
using Telerik.WinForms.Documents;
using Telerik.WinForms.Documents.FormatProviders;
using Telerik.WinForms.Documents.FormatProviders.Html;
using Telerik.WinForms.Documents.FormatProviders.Xaml;
using Telerik.WinForms.Documents.Layout;
using Telerik.WinForms.Documents.Model;
using Telerik.WinForms.Documents.Selection;

namespace RichTextEditor.StructuredContent
{
    public class HRecipeFormatProvider : ITextBasedDocumentFormatProvider
    {
        #region Consant Fields

        private const string HtmlNonBreakingSpace = "&nbsp;";
        private const string UnicodeNonBreakingSpace = "\x00A0";
        private const char UnicodeNonBreakingSpaceChar = '\x00A0';
        private readonly string[] semanticRangeNames = { "fn", "summary", "author", "ingredient", "instructions", "yield", "duration" };
        private const string ErrorMessage = "Invaild HTML: Unable to parse the HTML to RadDocument.";

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return "HRecipeFormatProvider";
            }
        }

        public IEnumerable<string> SupportedExtensions
        {
            get
            {
                return new string[] { ".html" };
            }
        }

        public bool CanExport
        {
            get
            {
                return true;
            }
        }

        public bool CanImport
        {
            get
            {
                return true;
            }
        }

        public string FilesDescription
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Methods

        byte[] IDocumentFormatProvider.Export(RadDocument document)
        {
            return Encoding.UTF8.GetBytes(this.ExportCustomAnnotationsToHtml(document));
        }

        public void Export(RadDocument document, Stream output)
        {
            throw new NotImplementedException();
        }

        public RadDocument Import(byte[] input)
        {
            throw new NotImplementedException();
        }

        public RadDocument Import(System.IO.Stream input)
        {
            throw new NotImplementedException();
        }

        public string ExportCustomAnnotationsToHtml(RadDocument document)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("<html>");
            result.AppendLine("<head></head>");
            result.AppendLine("<body>");
            result.AppendLine("<div class=\"hrecipe\">");

            result.AppendLine();
            result.AppendLine("<h1 class=\"fn\">");
            result.AppendLine(this.ExportAnnotationRangeFragment(document, "fn"));
            result.AppendLine("</h1>");

            result.AppendLine();
            result.AppendLine("<div class=\"summary\">");
            result.AppendLine(this.ExportAnnotationRangeFragment(document, "summary"));
            result.AppendLine("</div>");

            result.AppendLine();
            result.AppendLine("<div style=\"font-weight: bold;\">Author: <span class=\"author\">");
            result.AppendLine(this.ExportAnnotationRangeFragment(document, "author"));
            result.AppendLine("</span></div>");

            result.AppendLine();
            result.AppendLine("<div style=\"font-weight: bold;\">Ingredients: <span class=\"ingredient\">");
            result.AppendLine(this.ExportAnnotationRangeFragment(document, "ingredient"));
            result.AppendLine("</span></div>");

            result.AppendLine();
            result.AppendLine("<div style=\"font-weight: bold;\">Instructions: <span class=\"instructions\">");
            result.AppendLine(this.ExportAnnotationRangeFragment(document, "instructions"));
            result.AppendLine("</span></div>");

            result.AppendLine();
            result.AppendLine("<div style=\"font-weight: bold;\">Further details: <span class=\"yield\">");
            result.AppendLine(this.ExportAnnotationRangeFragment(document, "yield"));
            result.AppendLine("</span></div>");

            result.AppendLine();
            result.AppendLine("<div style=\"font-weight: bold;\">Preparation time: <span class=\"duration\">");
            result.AppendLine(this.ExportAnnotationRangeFragment(document, "duration"));
            result.AppendLine("</span></div>");

            result.AppendLine();
            result.AppendLine("</div>");
            result.AppendLine("</body>");
            result.AppendLine("</html>");

            return result.ToString();
        }

        private string ExportAnnotationRangeFragment(RadDocument document, string semanticRangeName)
        {
            RecipeRangeStart semanticRangestart = null;
            RecipeRangeEnd semanticRangeEnd = null;
            foreach (RecipeRangeStart rangeStart in document.GetAnnotationMarkersOfType<RecipeRangeStart>())
            {
                if (rangeStart.Name == semanticRangeName)
                {
                    semanticRangestart = rangeStart;
                    semanticRangeEnd = (RecipeRangeEnd)rangeStart.End;
                }
            }

            if (semanticRangestart != null && semanticRangeEnd != null)
            {
                DocumentPosition startPosition = new DocumentPosition(document);
                startPosition.MoveToInline((InlineLayoutBox)semanticRangestart.FirstLayoutBox, 0);

                DocumentPosition endPosition = new DocumentPosition(document);
                endPosition.MoveToInline((InlineLayoutBox)semanticRangeEnd.FirstLayoutBox, 0);

                DocumentSelection selection = new DocumentSelection(document);
                selection.SetSelectionStart(startPosition);
                selection.AddSelectionEnd(endPosition);

                DocumentFragment fragment = new DocumentFragment(selection);
                RadDocument fragmentDocument = fragment.ToDocument();

                HtmlFormatProvider htmlFormatProvider = new HtmlFormatProvider();
                htmlFormatProvider.ExportSettings = new HtmlExportSettings();
                htmlFormatProvider.ExportSettings.DocumentExportLevel = DocumentExportLevel.Fragment;
                htmlFormatProvider.ExportSettings.StylesExportMode = StylesExportMode.Inline;
                htmlFormatProvider.ExportSettings.StyleRepositoryExportMode = StyleRepositoryExportMode.DontExportStyles;

                return htmlFormatProvider.Export(fragmentDocument);
            }

            return string.Empty;
        }

        public RadDocument ImportHtmlToDocument(string input, DocumentInfo recipe)
        {
            Stream streamResourceInfo = this.GetType().Assembly.GetManifestResourceStream(recipe.Path);
            using (Stream recipeStream = streamResourceInfo)
            {
                try
                {
                    string xamlSpaceReadyInput = input.Replace(HtmlNonBreakingSpace, UnicodeNonBreakingSpace);
                    XDocument document = XDocument.Parse(xamlSpaceReadyInput);

                    RadDocument template = new XamlFormatProvider().Import(recipeStream);
                    template.EnsureDocumentMeasuredAndArranged();

                    foreach (string semanticRangeName in semanticRangeNames)
                    {
                        this.ReplaceSemanticRange(template, semanticRangeName, this.ImportPart(document.Root, semanticRangeName) ?? new DocumentFragment(new RadDocument()));
                    }
                    return template;
                }
                catch
                {
                    Telerik.WinControls.RadMessageBox.Show(ErrorMessage,"Error", System.Windows.Forms.MessageBoxButtons.OK,Telerik.WinControls.RadMessageIcon.Error);
                    
                    RadDocument template = new XamlFormatProvider().Import(recipeStream);
                    return template;
                }
            }
        }

        private void ReplaceSemanticRange(RadDocument document, string semanticRangeName, DocumentFragment replacement)
        {
            RecipeRangeStart start = null;
            RecipeRangeEnd end = null;
            foreach (RecipeRangeStart rangeStart in document.GetAnnotationMarkersOfType<RecipeRangeStart>())
            {
                if (rangeStart.Name == semanticRangeName)
                {
                    start = rangeStart;
                    end = (RecipeRangeEnd)rangeStart.End;
                }
            }

            if (start != null && end != null)
            {
                DocumentPosition startPosition = new DocumentPosition(document);
                startPosition.MoveToInline((InlineLayoutBox)start.FirstLayoutBox, 0);
                startPosition.MoveToNext();
                DocumentPosition endPosition = new DocumentPosition(document);
                endPosition.MoveToInline((InlineLayoutBox)end.FirstLayoutBox, 0);
#pragma warning disable 0618 
                document.DeleteRange(startPosition, endPosition);

                document.CaretPosition.MoveToInline((InlineLayoutBox)start.FirstLayoutBox, 0);
                if(semanticRangeName != "fn")
                    document.CaretPosition.MoveToNext();
                document.InsertFragment(replacement);
#pragma warning restore 0618
            }
        }

        private DocumentFragment ImportPart(XElement root, string className)
        {
            XElement target = this.FindElementByClass(root, className);
            if (target == null)
            {
                return null;
            }

            RadDocument radDocument = new HtmlFormatProvider().Import(target.ToString());

            RemoveEmptySpans(radDocument);
            radDocument.Selection.SelectAll();

            return new DocumentFragment(radDocument.Selection);
        }

        private static void RemoveEmptySpans(RadDocument document)
        {
            List<Paragraph> paragraphsToRemove = new List<Paragraph>();

            foreach (Section section in document.Sections)
            {
                foreach (Block block in section.Blocks)
                {
                    Paragraph para = block as Paragraph;
                    if (para != null)
                    {
                        bool isOnlyContainingWhiteSpaces = true;
                        foreach (Inline inline in para.Inlines)
                        {
                            Span span = inline as Span;
                            if (span != null)
                            {
                                if (string.IsNullOrWhiteSpace(span.Text) == false)
                                {
                                    isOnlyContainingWhiteSpaces = false;
                                    break;
                                }
                            }
                        }

                        if (isOnlyContainingWhiteSpaces)
                        {
                            paragraphsToRemove.Add(para);
                        }
                    }
                }

                foreach (var paragraph in paragraphsToRemove)
                {
                    section.Blocks.Remove(paragraph);
                }
            }

            foreach (Section section in document.Sections)
            {
                foreach (Block block in section.Blocks)
                {
                    Paragraph para = block as Paragraph;
                    if (para != null)
                    {
                        foreach (Inline inline in para.Inlines.ToArray())
                        {
                            Span span = inline as Span;
                            if (span != null)
                            {
                                if (string.IsNullOrWhiteSpace(span.Text))
                                {
                                    para.Inlines.Remove(span);
                                }
                                else if (span.Text.All(c => c == UnicodeNonBreakingSpaceChar))
                                {
                                    para.Inlines.Remove(span);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }

                        foreach (Inline inline in para.Inlines.ToArray().Reverse())
                        {
                            Span span = inline as Span;
                            if (span != null)
                            {
                                if (string.IsNullOrWhiteSpace(span.Text))
                                {
                                    para.Inlines.Remove(span);
                                }
                                else if (span.Text.All(c => c == UnicodeNonBreakingSpaceChar))
                                {
                                    para.Inlines.Remove(span);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private XElement FindElementByClass(XElement element, string className)
        {
            XAttribute classAttr = element.Attribute("class");
            if (classAttr != null && (classAttr.Value == className || classAttr.Value.Contains(" " + className) || classAttr.Value.Contains(className + " ")))
            {
                return element;
            }

            foreach (XElement child in element.Elements())
            {
                XElement found = this.FindElementByClass(child, className);
                if (found != null)
                {
                    return found;
                }
            }
            return null;
        }

        public RadDocument Import(string input)
        {
            throw new NotImplementedException();
        }

        string ITextBasedDocumentFormatProvider.Export(RadDocument document)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
