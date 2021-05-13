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
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.RichTextEditor.UI
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.Model
Imports Size = Telerik.WinControls.RichTextEditor.UI.Size
Namespace RichTextEditor.DocumentAPI
	Public Partial Class Form1
		Inherits RadForm
		Public Sub New()
			InitializeComponent()

			ThemeResolutionService.ApplicationThemeName = Program.ThemeName

			CreateDocument()

            AddHandler radRichTextEditor1.Commands.ToggleBoldCommand.ToggleStateChanged, AddressOf ToggleBoldCommand_ToggleStateChanged
            AddHandler radRichTextEditor1.Commands.ToggleItalicCommand.ToggleStateChanged, AddressOf ToggleItalicCommand_ToggleStateChanged
            AddHandler radRichTextEditor1.Commands.ToggleUnderlineCommand.ToggleStateChanged, AddressOf ToggleUnderlineCommand_ToggleStateChanged

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

		Private Sub CreateDocument()
			Dim document As RadDocument = New RadDocument()
			Dim section As Section = New Section()

			Dim paragraph1 As Paragraph = New Paragraph()
			Dim stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream("winforms.png")
            Dim size As Size = New Size(375, 37)
			Dim imageInline As ImageInline = New ImageInline(stream, size, "png")
			paragraph1.Inlines.Add(imageInline)
			section.Blocks.Add(paragraph1)

			Dim paragraph2 As Paragraph = New Paragraph()
			paragraph2.TextAlignment = Telerik.WinForms.Documents.Layout.RadTextAlignment.Center
			Dim span1 As Span = New Span("Thank you for choosing Telerik")
			paragraph2.Inlines.Add(span1)

			Dim span2 As Span = New Span()
			span2.Text = " RadRichTextBox!"
			span2.FontWeight = FontWeights.Bold
			paragraph2.Inlines.Add(span2)
			section.Blocks.Add(paragraph2)

			Dim paragraph3 As Paragraph = New Paragraph()
			Dim span3 As Span = New Span("RadRichTextBox")
			span3.FontWeight = FontWeights.Bold
			paragraph3.Inlines.Add(span3)

			Dim span4 As Span = New Span(" is a control that is able to display and edit rich-text content including formatted text arranged in pages, paragraphs, spans (runs) etc.")
			paragraph3.Inlines.Add(span4)
			section.Blocks.Add(paragraph3)

			Dim table As Table = New Table()
			table.LayoutMode = TableLayoutMode.AutoFit
			table.StyleName = RadDocumentDefaultStyles.DefaultTableGridStyleName

			Dim row1 As TableRow = New TableRow()

			Dim cell1 As TableCell = New TableCell()
			Dim p1 As Paragraph = New Paragraph()
			Dim s1 As Span = New Span()
			s1.Text = "Cell 1"
			p1.Inlines.Add(s1)
			cell1.Blocks.Add(p1)
			row1.Cells.Add(cell1)

			Dim cell2 As TableCell = New TableCell()
			Dim p2 As Paragraph = New Paragraph()
			Dim s2 As Span = New Span()
			s2.Text = "Cell 2"
			p2.Inlines.Add(s2)
			cell2.Blocks.Add(p2)
			row1.Cells.Add(cell2)
			table.Rows.Add(row1)

			Dim row2 As TableRow = New TableRow()

			Dim cell3 As TableCell = New TableCell()
			cell3.ColumnSpan = 2
			Dim p3 As Paragraph = New Paragraph()
			Dim s3 As Span = New Span()
			s3.Text = "Cell 3"
			p3.Inlines.Add(s3)
			cell3.Blocks.Add(p3)
			row2.Cells.Add(cell3)
			table.Rows.Add(row2)

			section.Blocks.Add(table)
			section.Blocks.Add(New Paragraph())
			document.Sections.Add(section)

            Me.radRichTextEditor1.Document = document
        End Sub

        Protected Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()
            Me.SetImages()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.SetImages()
        End Sub

        Private Sub SetImages()
            If Me.commandBarToggleButtonBold Is Nothing Then
                Return
            End If

            If TelerikHelper.IsDarkTheme(Me.ThemeName) Then
                If Me.commandBarToggleButtonBold.Tag Is Nothing Then
                    Me.commandBarToggleButtonBold.Tag = Me.commandBarToggleButtonBold.Image
                    Me.commandBarToggleButtonItalic.Tag = Me.commandBarToggleButtonItalic.Image
                    Me.commandBarToggleButtonUnderline.Tag = Me.commandBarToggleButtonUnderline.Image
                End If

                Me.commandBarToggleButtonBold.Image = ImageHelper.ChangeImagePixels(Me.commandBarToggleButtonBold.Image, System.Drawing.Color.White)
                Me.commandBarToggleButtonItalic.Image = ImageHelper.ChangeImagePixels(Me.commandBarToggleButtonItalic.Image, System.Drawing.Color.White)
                Me.commandBarToggleButtonUnderline.Image = ImageHelper.ChangeImagePixels(Me.commandBarToggleButtonUnderline.Image, System.Drawing.Color.White)
            ElseIf Me.commandBarToggleButtonBold.Tag IsNot Nothing Then
                Me.commandBarToggleButtonBold.Image = CType((Me.commandBarToggleButtonBold.Tag), System.Drawing.Image)
                Me.commandBarToggleButtonItalic.Image = CType((Me.commandBarToggleButtonItalic.Tag), System.Drawing.Image)
                Me.commandBarToggleButtonUnderline.Image = CType((Me.commandBarToggleButtonUnderline.Tag), System.Drawing.Image)
            End If
        End Sub

		Private suspendToggleEvents As Boolean = False

        Private Sub BoldButton_ToggleStateChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.StateChangedEventArgs) Handles commandBarToggleButtonBold.ToggleStateChanged
            If suspendToggleEvents Then
                Return
            End If

            Me.radRichTextEditor1.ToggleBold()
            Me.radRichTextEditor1.Focus()
        End Sub

        Private Sub ItalicButton_ToggleStateChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.StateChangedEventArgs) Handles commandBarToggleButtonItalic.ToggleStateChanged
            If suspendToggleEvents Then
                Return
            End If

            Me.radRichTextEditor1.ToggleItalic()
            Me.radRichTextEditor1.Focus()
        End Sub

        Private Sub UnderlineButton_ToggleStateChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.StateChangedEventArgs) Handles commandBarToggleButtonUnderline.ToggleStateChanged
            If suspendToggleEvents Then
                Return
            End If

            Me.radRichTextEditor1.ToggleUnderline()
            Me.radRichTextEditor1.Focus()
        End Sub

        Private Sub ToggleBoldCommand_ToggleStateChanged(ByVal sender As Object, ByVal e As Telerik.WinForms.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs(Of Boolean))
            suspendToggleEvents = True
            If e.NewValue Then
                commandBarToggleButtonBold.ToggleState = ToggleState.On
            Else
                commandBarToggleButtonBold.ToggleState = ToggleState.Off
            End If
            suspendToggleEvents = False
        End Sub

        Private Sub ToggleUnderlineCommand_ToggleStateChanged(ByVal sender As Object, ByVal e As Telerik.WinForms.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs(Of Boolean))
            suspendToggleEvents = True
            If e.NewValue Then
                commandBarToggleButtonUnderline.ToggleState = ToggleState.On
            Else
                commandBarToggleButtonUnderline.ToggleState = ToggleState.Off
            End If
            suspendToggleEvents = False
        End Sub

        Private Sub ToggleItalicCommand_ToggleStateChanged(ByVal sender As Object, ByVal e As Telerik.WinForms.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs(Of Boolean))
            suspendToggleEvents = True
            If e.NewValue Then
                commandBarToggleButtonItalic.ToggleState = ToggleState.On
            Else
                commandBarToggleButtonItalic.ToggleState = ToggleState.Off
            End If
            suspendToggleEvents = False
        End Sub
	End Class
End Namespace
