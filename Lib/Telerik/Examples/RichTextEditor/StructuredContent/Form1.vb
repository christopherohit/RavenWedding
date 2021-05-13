Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders.Xaml

Namespace RichTextEditor.StructuredContent
	Public Partial Class Form1
		Inherits RadRibbonForm
		#Region "Fields"

        Private Const FirstDocumentPath As String = "Recipe1.xaml"
        Private Const SecondDocumentPath As String = "Recipe2.xaml"
        Private Const ThirdDocumentPath As String = "Recipe3.xaml"
        Private Const ForthDocumentPath As String = "Recipe4.xaml"
		Private Const RefreshInterval As Integer = 1

		Private hasRadRichTextBoxChanged As Boolean

		#End Region

		#Region "Properties"

		Private Function GetSampleDocumentsInfos() As DocumentInfo()
			Return New DocumentInfo() { New DocumentInfo("Italian Salad", FirstDocumentPath), New DocumentInfo("Tiramisu Cake", SecondDocumentPath), New DocumentInfo("Pommes Frites", ThirdDocumentPath), New DocumentInfo("Italian Ravioli Soup", ForthDocumentPath) }
		End Function

		#End Region

		Public Sub New()
			InitializeComponent()

			ThemeResolutionService.ApplicationThemeName = Program.ThemeName

			AttachEvents()

            InitializeData()

            AddHandler Me.radRichTextEditor1.ProviderUILayerInitialized, AddressOf radRichTextEditor1_ProviderUILayerInitialized
        End Sub

        Private Sub radRichTextEditor1_ProviderUILayerInitialized(sender As Object, e As ProviderUILayerInitilizedEventArgs)
            If e.Layer.Name = "PagesLayer" Then
                For Each element As Telerik.WinControls.RichTextEditor.UI.UIElement In e.Container.Children
                    element.BackColor = Telerik.WinControls.RichTextEditor.UI.Colors.White
                Next

                Dim headerFooters As List(Of RadElement) = Me.radRichTextEditor1.RichTextBoxElement.GetDescendants(Function(x As RadElement) TypeOf x Is Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer, TreeTraversalMode.BreadthFirst)
                For Each container As Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer In headerFooters
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255)
                Next
            End If
        End Sub

		#Region "Methods"

		Private Sub InitializeData()
			Me.hasRadRichTextBoxChanged = False

			Me.radListControl1.DataSource = GetSampleDocumentsInfos()
			Me.radListControl1.DisplayMember = "Name"
			Me.radListControl1.SelectedIndex = 0

		End Sub

		Private Sub AttachEvents()
			AddHandler Me.radListControl1.SelectedIndexChanged, AddressOf listBox_documents_SelectionChanged

			AddHandler Me.radPageViewMain.SelectedPageChanged, AddressOf radPageView1_SelectedPageChanged

			AddHandler Me.radRichTextEditor1.DocumentChanged, AddressOf editor_DocumentChanged
			AddHandler Me.radRichTextEditor1.DocumentContentChanged, AddressOf Document_DocumentContentChanged
		End Sub

		Private Sub Document_DocumentContentChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.hasRadRichTextBoxChanged = True
		End Sub

		Private Sub listBox_documents_SelectionChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.hasRadRichTextBoxChanged = False

			Dim documentInfo As DocumentInfo = CType(Me.radListControl1.SelectedValue, DocumentInfo)

			Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(documentInfo.Path)
				Me.radRichTextEditor1.Document = New XamlFormatProvider().Import(stream)
			End Using

			Me.radTextBox1.Text = New HRecipeFormatProvider().ExportCustomAnnotationsToHtml(Me.radRichTextEditor1.Document)
			Me.webBrowser1.DocumentText = Me.radTextBox1.Text
		End Sub

		Private Sub editor_DocumentChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radTextBox1.Text = New HRecipeFormatProvider().ExportCustomAnnotationsToHtml(Me.radRichTextEditor1.Document)
		End Sub

		Private Sub radPageView1_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radPageViewMain.SelectedPage Is pageViewPageHTML Then
				If Me.hasRadRichTextBoxChanged Then
					Me.radTextBox1.Text = New HRecipeFormatProvider().ExportCustomAnnotationsToHtml(Me.radRichTextEditor1.Document)
				End If
			ElseIf Me.radPageViewMain.SelectedPage Is pageViewPagePreview Then
				If Me.hasRadRichTextBoxChanged = True Then
					Me.radTextBox1.Text = New HRecipeFormatProvider().ExportCustomAnnotationsToHtml(Me.radRichTextEditor1.Document)
				End If
				Me.webBrowser1.DocumentText = Me.radTextBox1.Text
			End If
		End Sub

		#End Region
	End Class
End Namespace
