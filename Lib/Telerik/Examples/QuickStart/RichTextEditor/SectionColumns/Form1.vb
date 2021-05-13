Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.RichTextEditor.UI
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders.Xaml

Namespace Telerik.Examples.WinControls.RichTextEditor.SectionColumns
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			Me.StartWaiting()

			InitializeComponent()
			Me.richTextEditorRibbonBar1.CloseButton = False
			Me.richTextEditorRibbonBar1.MaximizeButton = False
			Me.richTextEditorRibbonBar1.MinimizeButton = False
			Me.richTextEditorRibbonBar1.RibbonBarElement.Text = "Section Columns"
			Me.richTextEditorRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = Me.richTextEditorRibbonBar1.RibbonBarElement.TabStripElement.Items(2)

            Dim provider As XamlFormatProvider = New XamlFormatProvider()
            radRichTextEditor1.Document = provider.Import(File.ReadAllBytes("..\RichTextEditor\SectionColumns\SampleData\SectionColumns.xaml"))

			AddHandler Me.radRichTextEditor1.ProviderUILayerInitialized, AddressOf radRichTextEditor1_ProviderUILayerInitialized
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.StopWaiting()
		End Sub

        Private Sub radRichTextEditor1_ProviderUILayerInitialized(sender As Object, e As ProviderUILayerInitilizedEventArgs)
            If e.Layer.Name = "PagesLayer" Then
                For Each element As UIElement In e.Container.Children
                    element.BackColor = Colors.White
                Next
                Dim headerFooters As List(Of RadElement) = Me.radRichTextEditor1.RichTextBoxElement.GetDescendants(Function(x As RadElement) TypeOf x Is HeaderFooterContainer, TreeTraversalMode.BreadthFirst)
                For Each container As HeaderFooterContainer In headerFooters
                    container.OverlayColor = System.Drawing.Color.White

                Next
            End If
        End Sub
    End Class
End Namespace
