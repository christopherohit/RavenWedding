using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents;
using Telerik.WinForms.Documents.Model;
using Telerik.WinForms.RichTextEditor;

namespace RichTextEditor.DragDrop
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = Program.ThemeName;

            this.radListView1.ListViewElement.DragDropService.PreviewDragOver += DragDropService_PreviewDragOver;
            this.radListView1.ListViewElement.DragDropService.PreviewDropTarget += DragDropService_PreviewDropTarget;
            this.radListView1.ListViewElement.DragDropService.PreviewDragDrop += DragDropService_PreviewDragDrop;

            this.radRichTextEditor1.ProviderUILayerInitialized += radRichTextEditor1_ProviderUILayerInitialized;
        }

        void radRichTextEditor1_ProviderUILayerInitialized(object sender, ProviderUILayerInitilizedEventArgs e)
        {
            if (e.Layer.Name == "PagesLayer")
            {
                foreach (Telerik.WinControls.RichTextEditor.UI.UIElement element in e.Container.Children)
                {
                    element.BackColor = Colors.White;
                }

                List<RadElement> headerFooters = this.radRichTextEditor1.RichTextBoxElement.GetDescendants(delegate(RadElement x) { return x is HeaderFooterContainer; }, TreeTraversalMode.BreadthFirst);
                foreach (HeaderFooterContainer container in headerFooters)
                {
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255);
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RadDocument document = new RadDocument();
            string randomText = @"On the Insert tab, the galleries include items that are designed to coordinate with the overall look of your document. You can use these galleries to insert tables, headers, footers, lists, cover pages, and other document building blocks. When you create pictures, charts, or diagrams, they also coordinate with your current document look";

            RadDocumentEditor documentEditor = new RadDocumentEditor(document);
            documentEditor.Insert(randomText);

            this.radRichTextEditor1.Document = (RadDocument)document.CreateDeepCopy();
            this.radRichTextEditor1.Document.Sections.First.Headers.Default.Body = document;
        }

        void DragDropService_PreviewDragDrop(object sender, Telerik.WinControls.RadDropEventArgs e)
        {
            string payloadData = (e.DragInstance as BaseListViewVisualItem).Text;

            if (string.IsNullOrEmpty(payloadData))
            {
                return;
            }

            RadRichTextBox richTextBox = this.radRichTextEditor1.RichTextBoxElement.ActiveDocumentEditor as RadRichTextBox;

            richTextBox.CurrentEditingStyle.SpanProperties.ForeColor = Colors.Red;
            this.radRichTextEditor1.Focus();
            richTextBox.Insert(payloadData);
        }

        void DragDropService_PreviewDropTarget(object sender, Telerik.WinControls.PreviewDropTargetEventArgs e)
        {
            System.Drawing.Point mousePos = this.PointToClient(Control.MousePosition);
            if (this.radRichTextEditor1.Bounds.Contains(mousePos))
            {
                e.DropTarget = this.radRichTextEditor1.RichTextBoxElement;
            }
        }

        void DragDropService_PreviewDragOver(object sender, Telerik.WinControls.RadDragOverEventArgs e)
        {
            Console.WriteLine(e.HitTarget);
            if (e.HitTarget == this.radRichTextEditor1.RichTextBoxElement)
            {
                RadRichTextBox richTextBox = this.radRichTextEditor1.RichTextBoxElement.ActiveDocumentEditor as RadRichTextBox;

                System.Drawing.Point point = this.radRichTextEditor1.PointToClient(Control.MousePosition);
                DocumentPosition pos = richTextBox.ActiveEditorPresenter.GetDocumentPositionFromViewPoint(point);

                this.radRichTextEditor1.Focus();
                richTextBox.Document.CaretPosition.MoveToPosition(pos);

                e.CanDrop = true;
            }
        }
    }
}
