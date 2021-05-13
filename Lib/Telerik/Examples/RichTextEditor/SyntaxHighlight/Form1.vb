Imports Microsoft.VisualBasic
Imports RichTextEditor.Parsers
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.Model

Namespace RichTextEditor.SyntaxHighlight
	Public Partial Class Form1
		Inherits RadForm
		#Region "Constants"

		Private Shared ReadOnly XamlResource As String = "SampleXAML.txt"
		Private Shared ReadOnly CsResource As String = "SampleCS.txt"

		#End Region

		#Region "Fields"

		Private XamlDocument As RadDocument
		Private CsDocument As RadDocument

		#End Region

		Public Sub New()
			InitializeComponent()
            ThemeResolutionService.ApplicationThemeName = Program.ThemeName

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

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.commandBarDropDownList1.SelectedIndex = 0
            Me.SetImages()
        End Sub

        Protected Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()
            Me.SetImages()
        End Sub

        Private Sub commandBarDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            If e.Position = 0 Then
                Me.LoadSampleXamlDocument()
            Else
                Me.LoadSampleCsDocument()
            End If
        End Sub

        Private Sub SetImages()
            If Me.commandBarToggleButton1 Is Nothing Then
                Return
            End If

            If TelerikHelper.IsDarkTheme(Me.ThemeName) Then
                If Me.commandBarToggleButton1.Tag Is Nothing Then
                    Me.commandBarToggleButton1.Tag = Me.commandBarToggleButton1.Image
                End If

                Me.commandBarToggleButton1.Image = ImageHelper.ChangeImagePixels(Me.commandBarToggleButton1.Image, System.Drawing.Color.White)
            ElseIf Me.commandBarToggleButton1.Tag IsNot Nothing Then
                Me.commandBarToggleButton1.Image = CType(Me.commandBarToggleButton1.Tag, Image)
            End If
        End Sub


		Private Sub ToggleFormattingSymbols_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs) Handles commandBarToggleButton1.ToggleStateChanged
			Me.radRichTextEditor1.ShowFormattingSymbols = Me.commandBarToggleButton1.CheckState = CheckState.Checked
		End Sub

		Private Sub LoadSampleXamlDocument()
			If Me.XamlDocument Is Nothing Then
                Dim xamlStream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(XamlResource)

				Using reader As StreamReader = New StreamReader(xamlStream)
					Me.XamlDocument = CreateFormattedDocument(reader.ReadToEnd(), ".xaml")
				End Using
			End If

            Me.radRichTextEditor1.Document = Me.XamlDocument
		End Sub

		Private Sub LoadSampleCsDocument()
			If Me.CsDocument Is Nothing Then
                Dim csStream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(CsResource)

				Using reader As StreamReader = New StreamReader(csStream)
					Me.CsDocument = CreateFormattedDocument(reader.ReadToEnd(), ".cs")
				End Using
			End If

            Me.radRichTextEditor1.Document = Me.CsDocument
		End Sub

		Private Function CreateFormattedDocument(ByVal text As String, ByVal fileFormat As String) As RadDocument
			Dim document As RadDocument = New RadDocument()
			document.LayoutMode = DocumentLayoutMode.Flow
			document.SectionDefaultPageMargin = New Telerik.WinForms.Documents.Layout.Padding(25)

			Dim section As Section = New Section()
			document.Sections.Add(section)

			Dim tokenizer As Tokenizer = New Tokenizer()
			Dim tokens As List(Of Token) = tokenizer.TokenizeCode(text, fileFormat)

			Dim currentParagraph As Paragraph = New Paragraph()
			currentParagraph.SpacingAfter = 0
			section.Blocks.Add(currentParagraph)
			For Each token As Token In tokens
				Dim lines As String() = Regex.Split(token.Value, DocumentEnvironment.NewLine)

				Dim createParagraph As Boolean = False
				For Each line As String In lines
					If createParagraph Then
						currentParagraph = New Paragraph()
						currentParagraph.SpacingAfter = 0
						section.Blocks.Add(currentParagraph)
					End If
					createParagraph = True

					If (Not String.IsNullOrEmpty(line)) Then
						Dim span As Span = token.GetSpanStyle()
						span.Text = line
						currentParagraph.Inlines.Add(span)
					End If
				Next line
			Next token

			Return document
		End Function

		#End Region

	End Class
End Namespace
