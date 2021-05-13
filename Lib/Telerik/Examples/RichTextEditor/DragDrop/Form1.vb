Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.RichTextEditor.UI
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.RichTextEditor

Namespace RichTextEditor.DragDrop
	Public Partial Class Form1
		Inherits RadForm
		Public Sub New()
			InitializeComponent()

			ThemeResolutionService.ApplicationThemeName = Program.ThemeName

			AddHandler Me.radListView1.ListViewElement.DragDropService.PreviewDragOver, AddressOf DragDropService_PreviewDragOver
			AddHandler Me.radListView1.ListViewElement.DragDropService.PreviewDropTarget, AddressOf DragDropService_PreviewDropTarget
            AddHandler Me.radListView1.ListViewElement.DragDropService.PreviewDragDrop, AddressOf DragDropService_PreviewDragDrop

            AddHandler Me.radRichTextEditor1.ProviderUILayerInitialized, AddressOf radRichTextEditor1_ProviderUILayerInitialized
        End Sub

        Private Sub radRichTextEditor1_ProviderUILayerInitialized(sender As Object, e As ProviderUILayerInitilizedEventArgs)
            If e.Layer.Name = "PagesLayer" Then
                For Each element As Telerik.WinControls.RichTextEditor.UI.UIElement In e.Container.Children
                    element.BackColor = Colors.White
                Next

                Dim headerFooters As List(Of RadElement) = Me.radRichTextEditor1.RichTextBoxElement.GetDescendants(Function(x As RadElement) TypeOf x Is HeaderFooterContainer, TreeTraversalMode.BreadthFirst)
                For Each container As HeaderFooterContainer In headerFooters
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255)
                Next
            End If
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)

            MyBase.OnLoad(e)

            Dim document As RadDocument = New RadDocument()
            Dim randomText As String = "On the Insert tab, the galleries include items that are designed to coordinate with the overall look of your document. You can use these galleries to insert tables, headers, footers, lists, cover pages, and other document building blocks. When you create pictures, charts, or diagrams, they also coordinate with your current document look"

            Dim documentEditor As RadDocumentEditor = New RadDocumentEditor(document)
            documentEditor.Insert(randomText)

            Me.radRichTextEditor1.Document = CType(document.CreateDeepCopy(), RadDocument)
            Me.radRichTextEditor1.Document.Sections.First.Headers.Default.Body = document
        End Sub

		Private Sub DragDropService_PreviewDragDrop(ByVal sender As Object, ByVal e As Telerik.WinControls.RadDropEventArgs)
			Dim payloadData As String = (TryCast(e.DragInstance, BaseListViewVisualItem)).Text

			If String.IsNullOrEmpty(payloadData) Then
				Return
			End If

			Dim richTextBox As RadRichTextBox = TryCast(Me.radRichTextEditor1.RichTextBoxElement.ActiveDocumentEditor, RadRichTextBox)

			richTextBox.CurrentEditingStyle.SpanProperties.ForeColor = Colors.Red
			Me.radRichTextEditor1.Focus()
			richTextBox.Insert(payloadData)
		End Sub

		Private Sub DragDropService_PreviewDropTarget(ByVal sender As Object, ByVal e As Telerik.WinControls.PreviewDropTargetEventArgs)
			Dim mousePos As System.Drawing.Point = Me.PointToClient(Control.MousePosition)
			If Me.radRichTextEditor1.Bounds.Contains(mousePos) Then
				e.DropTarget = Me.radRichTextEditor1.RichTextBoxElement
			End If
		End Sub

		Private Sub DragDropService_PreviewDragOver(ByVal sender As Object, ByVal e As Telerik.WinControls.RadDragOverEventArgs)
            If e.HitTarget.Equals(Me.radRichTextEditor1.RichTextBoxElement) Then
                Dim richTextBox As RadRichTextBox = TryCast(Me.radRichTextEditor1.RichTextBoxElement.ActiveDocumentEditor, RadRichTextBox)

                Dim point As System.Drawing.Point = Me.radRichTextEditor1.PointToClient(Control.MousePosition)
                Dim pos As DocumentPosition = richTextBox.ActiveEditorPresenter.GetDocumentPositionFromViewPoint(point)

                Me.radRichTextEditor1.Focus()
                richTextBox.Document.CaretPosition.MoveToPosition(pos)

                e.CanDrop = True
            End If
		End Sub
	End Class
End Namespace
