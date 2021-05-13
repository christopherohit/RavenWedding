
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Xml.Linq
Imports Telerik.WinForms.Controls
Imports Telerik.WinForms.Documents
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.Html
Imports Telerik.WinForms.Documents.FormatProviders.Xaml
Imports Telerik.WinForms.Documents.Layout
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.Documents.Selection
Imports System

Namespace RichTextEditor.StructuredContent
    Public Class HRecipeFormatProvider
        Implements ITextBasedDocumentFormatProvider
#Region "Consant Fields"

        Private Const HtmlNonBreakingSpace As String = "&nbsp;"
        Private Const UnicodeNonBreakingSpace As String = " "
        Private Const UnicodeNonBreakingSpaceChar As Char = " "c
        Private ReadOnly semanticRangeNames As String() = {"fn", "summary", "author", "ingredient", "instructions", "yield", _
            "duration"}
        Private Const ErrorMessage As String = "Invaild HTML: Unable to parse the HTML to RadDocument."

#End Region

#Region "Properties"

        Public ReadOnly Property Name() As String Implements IDocumentFormatProvider.Name
            Get
                Return "HRecipeFormatProvider"
            End Get
        End Property

        Public ReadOnly Property SupportedExtensions() As IEnumerable(Of String) Implements IDocumentFormatProvider.SupportedExtensions
            Get
                Return New String() {".html"}
            End Get
        End Property

        Public ReadOnly Property CanExport() As Boolean Implements IDocumentFormatProvider.CanExport
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property CanImport() As Boolean Implements IDocumentFormatProvider.CanImport
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property FilesDescription() As String Implements IDocumentFormatProvider.FilesDescription
            Get
                Throw New NotImplementedException()
            End Get
        End Property

#End Region

#Region "Methods"

        Private Function IDocumentFormatProvider_Export(document As RadDocument) As Byte() Implements IDocumentFormatProvider.Export
            Return Encoding.UTF8.GetBytes(Me.ExportCustomAnnotationsToHtml(document))
        End Function

        Public Sub Export(document As RadDocument, output As Stream) Implements IDocumentFormatProvider.Export
            Throw New NotImplementedException()
        End Sub

        Public Function Import(input As Byte()) As RadDocument Implements IDocumentFormatProvider.Import
            Throw New NotImplementedException()
        End Function

        Public Function Import(input As System.IO.Stream) As RadDocument Implements IDocumentFormatProvider.Import
            Throw New NotImplementedException()
        End Function

        Public Function ExportCustomAnnotationsToHtml(document As RadDocument) As String
            Dim result As New StringBuilder()
            result.AppendLine("<html>")
            result.AppendLine("<head></head>")
            result.AppendLine("<body>")
            result.AppendLine("<div class=""hrecipe"">")

            result.AppendLine()
            result.AppendLine("<h1 class=""fn"">")
            result.AppendLine(Me.ExportAnnotationRangeFragment(document, "fn"))
            result.AppendLine("</h1>")

            result.AppendLine()
            result.AppendLine("<div class=""summary"">")
            result.AppendLine(Me.ExportAnnotationRangeFragment(document, "summary"))
            result.AppendLine("</div>")

            result.AppendLine()
            result.AppendLine("<div style=""font-weight: bold;"">Author: <span class=""author"">")
            result.AppendLine(Me.ExportAnnotationRangeFragment(document, "author"))
            result.AppendLine("</span></div>")

            result.AppendLine()
            result.AppendLine("<div style=""font-weight: bold;"">Ingredients: <span class=""ingredient"">")
            result.AppendLine(Me.ExportAnnotationRangeFragment(document, "ingredient"))
            result.AppendLine("</span></div>")

            result.AppendLine()
            result.AppendLine("<div style=""font-weight: bold;"">Instructions: <span class=""instructions"">")
            result.AppendLine(Me.ExportAnnotationRangeFragment(document, "instructions"))
            result.AppendLine("</span></div>")

            result.AppendLine()
            result.AppendLine("<div style=""font-weight: bold;"">Further details: <span class=""yield"">")
            result.AppendLine(Me.ExportAnnotationRangeFragment(document, "yield"))
            result.AppendLine("</span></div>")

            result.AppendLine()
            result.AppendLine("<div style=""font-weight: bold;"">Preparation time: <span class=""duration"">")
            result.AppendLine(Me.ExportAnnotationRangeFragment(document, "duration"))
            result.AppendLine("</span></div>")

            result.AppendLine()
            result.AppendLine("</div>")
            result.AppendLine("</body>")
            result.AppendLine("</html>")

            Return result.ToString()
        End Function

        Private Function ExportAnnotationRangeFragment(document As RadDocument, semanticRangeName As String) As String
            Dim semanticRangestart As RecipeRangeStart = Nothing
            Dim semanticRangeEnd As RecipeRangeEnd = Nothing
            For Each rangeStart As RecipeRangeStart In document.GetAnnotationMarkersOfType(Of RecipeRangeStart)()
                If rangeStart.Name = semanticRangeName Then
                    semanticRangestart = rangeStart
                    semanticRangeEnd = DirectCast(rangeStart.[End], RecipeRangeEnd)
                End If
            Next

            If semanticRangestart IsNot Nothing AndAlso semanticRangeEnd IsNot Nothing Then
                Dim startPosition As New DocumentPosition(document)
                startPosition.MoveToInline(DirectCast(semanticRangestart.FirstLayoutBox, InlineLayoutBox), 0)

                Dim endPosition As New DocumentPosition(document)
                endPosition.MoveToInline(DirectCast(semanticRangeEnd.FirstLayoutBox, InlineLayoutBox), 0)

                Dim selection As New DocumentSelection(document)
                selection.SetSelectionStart(startPosition)
                selection.AddSelectionEnd(endPosition)

                Dim fragment As New DocumentFragment(selection)
                Dim fragmentDocument As RadDocument = fragment.ToDocument()

                Dim htmlFormatProvider As New HtmlFormatProvider()
                htmlFormatProvider.ExportSettings = New HtmlExportSettings()
                htmlFormatProvider.ExportSettings.DocumentExportLevel = DocumentExportLevel.Fragment
                htmlFormatProvider.ExportSettings.StylesExportMode = StylesExportMode.Inline
                htmlFormatProvider.ExportSettings.StyleRepositoryExportMode = StyleRepositoryExportMode.DontExportStyles

                Return htmlFormatProvider.Export(fragmentDocument)
            End If

            Return String.Empty
        End Function

        Public Function ImportHtmlToDocument(input As String, recipe As DocumentInfo) As RadDocument
            Dim streamResourceInfo As Stream = Me.[GetType]().Assembly.GetManifestResourceStream(recipe.Path)
            Using recipeStream As Stream = streamResourceInfo
                Try
                    Dim xamlSpaceReadyInput As String = input.Replace(HtmlNonBreakingSpace, UnicodeNonBreakingSpace)
                    Dim document As XDocument = XDocument.Parse(xamlSpaceReadyInput)

                    Dim template As RadDocument = New XamlFormatProvider().Import(recipeStream)
                    template.EnsureDocumentMeasuredAndArranged()

                    For Each semanticRangeName As String In semanticRangeNames
                        Me.ReplaceSemanticRange(template, semanticRangeName, If(Me.ImportPart(document.Root, semanticRangeName), New DocumentFragment(New RadDocument())))
                    Next
                    Return template
                Catch
                    Telerik.WinControls.RadMessageBox.Show(ErrorMessage, "Error", System.Windows.Forms.MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.[Error])

                    Dim template As RadDocument = New XamlFormatProvider().Import(recipeStream)
                    Return template
                End Try
            End Using
        End Function

        Private Sub ReplaceSemanticRange(document As RadDocument, semanticRangeName As String, replacement As DocumentFragment)
            Dim start As RecipeRangeStart = Nothing
            Dim [end] As RecipeRangeEnd = Nothing
            For Each rangeStart As RecipeRangeStart In document.GetAnnotationMarkersOfType(Of RecipeRangeStart)()
                If rangeStart.Name = semanticRangeName Then
                    start = rangeStart
                    [end] = DirectCast(rangeStart.[End], RecipeRangeEnd)
                End If
            Next

            If start IsNot Nothing AndAlso [end] IsNot Nothing Then
                Dim startPosition As New DocumentPosition(document)
                startPosition.MoveToInline(DirectCast(start.FirstLayoutBox, InlineLayoutBox), 0)
                startPosition.MoveToNext()
                Dim endPosition As New DocumentPosition(document)
                endPosition.MoveToInline(DirectCast([end].FirstLayoutBox, InlineLayoutBox), 0)
                document.DeleteRange(startPosition, endPosition)

                document.CaretPosition.MoveToInline(DirectCast(start.FirstLayoutBox, InlineLayoutBox), 0)
                If semanticRangeName <> "fn" Then
                    document.CaretPosition.MoveToNext()
                End If
                document.InsertFragment(replacement)
            End If
        End Sub

        Private Function ImportPart(root As XElement, className As String) As DocumentFragment
            Dim target As XElement = Me.FindElementByClass(root, className)
            If target Is Nothing Then
                Return Nothing
            End If

            Dim radDocument As RadDocument = New HtmlFormatProvider().Import(target.ToString())

            RemoveEmptySpans(radDocument)
            radDocument.Selection.SelectAll()

            Return New DocumentFragment(radDocument.Selection)
        End Function

        Private Shared Sub RemoveEmptySpans(document As RadDocument)
            Dim paragraphsToRemove As New List(Of Paragraph)()

            For Each section As Section In document.Sections
                For Each block As Block In section.Blocks
                    Dim para As Paragraph = TryCast(block, Paragraph)
                    If para IsNot Nothing Then
                        Dim isOnlyContainingWhiteSpaces As Boolean = True
                        For Each inline As Inline In para.Inlines
                            Dim span As Span = TryCast(inline, Span)
                            If span IsNot Nothing Then
                                If String.IsNullOrWhiteSpace(span.Text) = False Then
                                    isOnlyContainingWhiteSpaces = False
                                    Exit For
                                End If
                            End If
                        Next

                        If isOnlyContainingWhiteSpaces Then
                            paragraphsToRemove.Add(para)
                        End If
                    End If
                Next

                For Each paragraph As Paragraph In paragraphsToRemove
                    section.Blocks.Remove(paragraph)
                Next
            Next

            For Each section As Section In document.Sections
                For Each block As Block In section.Blocks
                    Dim para As Paragraph = TryCast(block, Paragraph)
                    If para IsNot Nothing Then
                        For Each inline As Inline In para.Inlines.ToArray()
                            Dim span As Span = TryCast(inline, Span)
                            If span IsNot Nothing Then
                                If String.IsNullOrWhiteSpace(span.Text) Then
                                    para.Inlines.Remove(span)
                                ElseIf span.Text.All(Function(c) c = UnicodeNonBreakingSpaceChar) Then
                                    para.Inlines.Remove(span)
                                Else
                                    Exit For
                                End If
                            End If
                        Next

                        For Each inline As Inline In para.Inlines.ToArray().Reverse()
                            Dim span As Span = TryCast(inline, Span)
                            If span IsNot Nothing Then
                                If String.IsNullOrWhiteSpace(span.Text) Then
                                    para.Inlines.Remove(span)
                                ElseIf span.Text.All(Function(c) c = UnicodeNonBreakingSpaceChar) Then
                                    para.Inlines.Remove(span)
                                Else
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                Next
            Next
        End Sub

        Private Function FindElementByClass(element As XElement, className As String) As XElement
            Dim classAttr As XAttribute = element.Attribute("class")
            If classAttr IsNot Nothing AndAlso (classAttr.Value = className OrElse classAttr.Value.Contains(Convert.ToString(" ") & className) OrElse classAttr.Value.Contains(className & Convert.ToString(" "))) Then
                Return element
            End If

            For Each child As XElement In element.Elements()
                Dim found As XElement = Me.FindElementByClass(child, className)
                If found IsNot Nothing Then
                    Return found
                End If
            Next
            Return Nothing
        End Function

        Public Function Import(input As String) As RadDocument Implements ITextBasedDocumentFormatProvider.Import
            Throw New NotImplementedException()
        End Function

        Private Function ITextBasedDocumentFormatProvider_Export(document As RadDocument) As String Implements ITextBasedDocumentFormatProvider.Export
            Throw New NotImplementedException()
        End Function

#End Region
    End Class
End Namespace
