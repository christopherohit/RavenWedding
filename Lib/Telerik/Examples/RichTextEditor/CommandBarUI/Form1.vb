Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.RichTextEditor.UI
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx
Imports Telerik.WinForms.Documents.Layout
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.Documents.RichTextBoxCommands
Imports System

Namespace RichTextEditor.CommandBarUI
    Partial Public Class Form1
        Inherits RadForm
        Public Sub New()
            InitializeComponent()
            ThemeResolutionService.ApplicationThemeName = Program.ThemeName

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

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.LoadFontFamilies()
            Me.LoadFontSizes()

            Me.LoadCurrentStyle()
            Me.WireEvents()

            AddHandler Me.radRichTextEditor1.RichTextBoxElement.CurrentEditingStyleChanged, AddressOf RichTextBoxElement_CurrentEditingStyleChanged

            Me.LoadFile("overview.docx")

            Me.SetImages()
        End Sub

        Protected Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            Me.SetImages()
        End Sub

        Private Sub LoadFile(file As String)
            Dim provider As DocumentFormatProviderBase = New DocxFormatProvider()

            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(file)
                Me.radRichTextEditor1.RichTextBoxElement.Document = provider.Import(stream)
            End Using
        End Sub

        Private Sub RichTextBoxElement_CurrentEditingStyleChanged(sender As Object, e As EventArgs)
            Me.UnwireEvents()
            Me.LoadCurrentStyle()
            Me.WireEvents()
        End Sub

        Private Sub SetImages()
            If Me.toggleButtonBold Is Nothing Then
                Return
            End If

            If TelerikHelper.IsDarkTheme(Me.ThemeName) Then
                Me.toggleButtonBold.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonBold.Image, System.Drawing.Color.White)
                Me.toggleButtonItalic.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonItalic.Image, System.Drawing.Color.White)
                Me.toggleButtonUnderline.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonUnderline.Image, System.Drawing.Color.White)
                Me.toggleButtonStrikethrough.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonStrikethrough.Image, System.Drawing.Color.White)
                Me.toggleButtonAlignLeft.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonAlignLeft.Image, System.Drawing.Color.White)
                Me.toggleButtonAlignCenter.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonAlignCenter.Image, System.Drawing.Color.White)
                Me.toggleButtonAlignRight.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonAlignRight.Image, System.Drawing.Color.White)
                Me.toggleButtonJustify.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonJustify.Image, System.Drawing.Color.White)
                Me.buttonOutdent.Image = ImageHelper.ChangeImagePixels(Me.buttonOutdent.Image, System.Drawing.Color.White)
                Me.buttonIndent.Image = ImageHelper.ChangeImagePixels(Me.buttonIndent.Image, System.Drawing.Color.White)
                Me.toggleButtonBulletList.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonBulletList.Image, System.Drawing.Color.White)
                Me.toggleButtonNumberedList.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonNumberedList.Image, System.Drawing.Color.White)
                Me.toggleButtonSubscript.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonSubscript.Image, System.Drawing.Color.White)
                Me.toggleButtonSuperscript.Image = ImageHelper.ChangeImagePixels(Me.toggleButtonSuperscript.Image, System.Drawing.Color.White)
            Else
                Me.toggleButtonBold.Image = Global.Resources.bold16
                Me.toggleButtonItalic.Image = Global.Resources.italic16
                Me.toggleButtonUnderline.Image = Global.Resources.underline16
                Me.toggleButtonStrikethrough.Image = Global.Resources.Strikethrough16
                Me.toggleButtonAlignLeft.Image = Global.Resources.alignleft16
                Me.toggleButtonAlignCenter.Image = Global.Resources.aligncenter16
                Me.toggleButtonAlignRight.Image = Global.Resources.alignright16
                Me.toggleButtonJustify.Image = Global.Resources.alignjustify16
                Me.buttonOutdent.Image = Global.Resources.outdent16
                Me.buttonIndent.Image = Global.Resources.indent16
                Me.toggleButtonBulletList.Image = Global.Resources.list_bullets16
                Me.toggleButtonNumberedList.Image = Global.Resources.list_numbered16
                Me.toggleButtonSubscript.Image = Global.Resources.subscript16
                Me.toggleButtonSuperscript.Image = Global.Resources.superscript16
            End If
        End Sub

        Private Sub LoadCurrentStyle()
            Dim helper As New StyleUIHelper(Me.radRichTextEditor1.RichTextBoxElement)

            'Font
            Dim family As Telerik.WinControls.RichTextEditor.UI.FontFamily = helper.GetFontFamilyOfSpanStyle()

            If family IsNot Nothing Then
                Me.dropDownListFont.SelectedValue = family.Source
            End If

            'Font size         
            Dim fontSize As System.Nullable(Of Double) = helper.GetFontSizeOfSpanStyle()

            If fontSize.HasValue Then
                Dim size As Integer = CInt(Math.Round(Unit.DipToPoint(fontSize.Value)))

                Dim sizes As BindingList(Of Integer) = TryCast(Me.dropDownListFontSize.DataSource, BindingList(Of Integer))

                If Not sizes.Contains(size) Then
                    Dim index As Integer = 0

                    While index < sizes.Count
                        If sizes(index) > size Then
                            Exit While
                        End If

                        index += 1
                    End While

                    sizes.Insert(index, size)
                End If

                Me.dropDownListFontSize.SelectedValue = size
            End If

            'Bold
            Dim fontWeight As System.Nullable(Of FontWeight) = helper.GetFontWeightOfSpanStyle()

            If fontWeight.HasValue Then
                Me.toggleButtonBold.ToggleState = If((fontWeight.Value.ToOpenTypeWeight() > 400), ToggleState.[On], ToggleState.Off)
            End If

            'Italic
            Dim fontStyle As System.Nullable(Of Telerik.WinControls.RichTextEditor.UI.FontStyle) = helper.GetFontStyleOfSpanStyle()

            If fontStyle.HasValue Then
                Me.toggleButtonItalic.ToggleState = If((fontStyle.Value <> FontStyles.Normal), ToggleState.[On], ToggleState.Off)
            End If

            'Underline
            Dim underline As System.Nullable(Of Boolean) = helper.GetUnderline()

            If underline.HasValue Then
                Me.toggleButtonUnderline.ToggleState = If((underline.Value), ToggleState.[On], ToggleState.Off)
            End If

            'Striketrough
            Dim strikethrough As System.Nullable(Of Boolean) = helper.GetStrikeThroughOfSpanStyle()

            If strikethrough.HasValue Then
                Me.toggleButtonStrikethrough.ToggleState = If((strikethrough.Value), ToggleState.[On], ToggleState.Off)
            End If

            'Baseline alignment
            Dim baselineAlignment__1 As System.Nullable(Of BaselineAlignment) = helper.GetBaselineAlignment()

            If baselineAlignment__1.HasValue Then
                Me.toggleButtonSubscript.ToggleState = If((baselineAlignment__1.Value = BaselineAlignment.Subscript), ToggleState.[On], ToggleState.Off)
                Me.toggleButtonSuperscript.ToggleState = If((baselineAlignment__1.Value = BaselineAlignment.Superscript), ToggleState.[On], ToggleState.Off)
            End If

            'Bullets
            Me.toggleButtonBulletList.ToggleState = If((helper.GetIsBulleted()), ToggleState.[On], ToggleState.Off)
            Me.toggleButtonNumberedList.ToggleState = If((helper.GetIsNumbered()), ToggleState.[On], ToggleState.Off)

            'Text alignment
            Dim textAlignment As System.Nullable(Of Telerik.WinForms.Documents.Layout.RadTextAlignment) = helper.GetTextAlignmentOfParagraphStyle()

            If textAlignment.HasValue Then
                Me.toggleButtonAlignLeft.ToggleState = If((textAlignment.Value = RadTextAlignment.Left), ToggleState.[On], ToggleState.Off)
                Me.toggleButtonAlignCenter.ToggleState = If((textAlignment.Value = RadTextAlignment.Center), ToggleState.[On], ToggleState.Off)
                Me.toggleButtonAlignRight.ToggleState = If((textAlignment.Value = RadTextAlignment.Right), ToggleState.[On], ToggleState.Off)
                Me.toggleButtonJustify.ToggleState = If((textAlignment.Value = RadTextAlignment.Justify), ToggleState.[On], ToggleState.Off)
            End If
        End Sub

        Private Sub LoadFontFamilies()
            Dim font As New InstalledFontCollection()

            Dim families As New List(Of String)()

            For Each family As System.Drawing.FontFamily In font.Families
                If family.IsStyleAvailable(System.Drawing.FontStyle.Regular) AndAlso family.IsStyleAvailable(System.Drawing.FontStyle.Italic) AndAlso family.IsStyleAvailable(System.Drawing.FontStyle.Bold) AndAlso family.IsStyleAvailable(System.Drawing.FontStyle.Strikeout) Then
                    families.Add(family.Name)
                End If
            Next

            Me.dropDownListFont.ValueMember = "Name"
            Me.dropDownListFont.DisplayMember = "Name"
            Me.dropDownListFont.DataSource = families
        End Sub

        Private Sub LoadFontSizes()
            Dim sizes As New BindingList(Of Integer)() From { _
                8, _
                9, _
                10, _
                11, _
                12, _
                14, _
                16, _
                18, _
                20, _
                22, _
                24, _
                26, _
                28, _
                36, _
                48, _
                72 _
            }
            Me.dropDownListFontSize.DataSource = sizes
        End Sub

        Private Sub WireEvents()
            AddHandler Me.buttonInsertImage.Click, AddressOf Me.buttonInsertImage_Click
            AddHandler Me.buttonInsertHyperlink.Click, AddressOf Me.buttonInsertHyperlink_Click
            AddHandler Me.toggleButtonBold.ToggleStateChanged, AddressOf Me.toggleButtonBold_ToggleStateChanged
            AddHandler Me.toggleButtonItalic.ToggleStateChanged, AddressOf Me.toggleButtonItalic_ToggleStateChanged
            AddHandler Me.toggleButtonUnderline.ToggleStateChanged, AddressOf Me.toggleButtonUnderline_ToggleStateChanged
            AddHandler Me.toggleButtonStrikethrough.ToggleStateChanged, AddressOf Me.toggleButtonStrikethrough_ToggleStateChanged
            AddHandler Me.toggleButtonAlignLeft.ToggleStateChanged, AddressOf Me.toggleButtonAlignLeft_ToggleStateChanged
            AddHandler Me.toggleButtonAlignCenter.ToggleStateChanged, AddressOf Me.toggleButtonAlignCenter_ToggleStateChanged
            AddHandler Me.toggleButtonAlignRight.ToggleStateChanged, AddressOf Me.toggleButtonAlignRight_ToggleStateChanged
            AddHandler Me.toggleButtonJustify.ToggleStateChanged, AddressOf Me.toggleButtonJustify_ToggleStateChanged
            AddHandler Me.toggleButtonBulletList.ToggleStateChanged, AddressOf Me.toggleButtonBulletList_ToggleStateChanged
            AddHandler Me.toggleButtonNumberedList.ToggleStateChanged, AddressOf Me.toggleButtonNumberedList_ToggleStateChanged
            AddHandler Me.buttonOutdent.Click, AddressOf Me.buttonOutdent_Click
            AddHandler Me.buttonIndent.Click, AddressOf Me.buttonIndent_Click
            AddHandler Me.buttonInsertSymbol.Click, AddressOf Me.buttonInsertSymbol_Click
            AddHandler Me.buttonInsertTable.Click, AddressOf Me.buttonInsertTable_Click
            AddHandler Me.toggleButtonSubscript.ToggleStateChanged, AddressOf Me.toggleButtonSubscript_ToggleStateChanged
            AddHandler Me.toggleButtonSuperscript.ToggleStateChanged, AddressOf Me.toggleButtonSuperscript_ToggleStateChanged
            AddHandler Me.dropDownListFont.SelectedIndexChanged, AddressOf Me.dropDownListFont_SelectedIndexChanged
            AddHandler Me.dropDownListFontSize.SelectedIndexChanged, AddressOf Me.dropDownListFontSize_SelectedIndexChanged

            AddHandler Me.buttonPrint.Click, AddressOf buttonPrint_Click
            AddHandler Me.buttonSpellCheck.Click, AddressOf buttonSpellCheck_Click
            AddHandler Me.buttonFindAndReplace.Click, AddressOf buttonFindAndReplace_Click
            AddHandler Me.buttonCut.Click, AddressOf buttonCut_Click
            AddHandler Me.buttonCopy.Click, AddressOf buttonCopy_Click
            AddHandler Me.buttonPaste.Click, AddressOf buttonPaste_Click
            AddHandler Me.buttonUndo.Click, AddressOf buttonUndo_Click
            AddHandler Me.buttonRedo.Click, AddressOf buttonRedo_Click
            AddHandler Me.buttonForeColor.Click, AddressOf buttonForeColor_Click
            AddHandler Me.buttonBackColor.Click, AddressOf buttonBackColor_Click
            AddHandler Me.buttonClearFormatting.Click, AddressOf buttonClearFormatting_Click
            AddHandler Me.buttonInsertHyperlink.Click, AddressOf buttonInsertHyperlink_Click

        End Sub

        Private Sub UnwireEvents()
            RemoveHandler Me.buttonInsertImage.Click, AddressOf Me.buttonInsertImage_Click
            RemoveHandler Me.buttonInsertHyperlink.Click, AddressOf Me.buttonInsertHyperlink_Click
            RemoveHandler Me.toggleButtonBold.ToggleStateChanged, AddressOf Me.toggleButtonBold_ToggleStateChanged
            RemoveHandler Me.toggleButtonItalic.ToggleStateChanged, AddressOf Me.toggleButtonItalic_ToggleStateChanged
            RemoveHandler Me.toggleButtonUnderline.ToggleStateChanged, AddressOf Me.toggleButtonUnderline_ToggleStateChanged
            RemoveHandler Me.toggleButtonStrikethrough.ToggleStateChanged, AddressOf Me.toggleButtonStrikethrough_ToggleStateChanged
            RemoveHandler Me.toggleButtonAlignLeft.ToggleStateChanged, AddressOf Me.toggleButtonAlignLeft_ToggleStateChanged
            RemoveHandler Me.toggleButtonAlignCenter.ToggleStateChanged, AddressOf Me.toggleButtonAlignCenter_ToggleStateChanged
            RemoveHandler Me.toggleButtonAlignRight.ToggleStateChanged, AddressOf Me.toggleButtonAlignRight_ToggleStateChanged
            RemoveHandler Me.toggleButtonJustify.ToggleStateChanged, AddressOf Me.toggleButtonJustify_ToggleStateChanged
            RemoveHandler Me.toggleButtonBulletList.ToggleStateChanged, AddressOf Me.toggleButtonBulletList_ToggleStateChanged
            RemoveHandler Me.toggleButtonNumberedList.ToggleStateChanged, AddressOf Me.toggleButtonNumberedList_ToggleStateChanged
            RemoveHandler Me.buttonOutdent.Click, AddressOf Me.buttonOutdent_Click
            RemoveHandler Me.buttonIndent.Click, AddressOf Me.buttonIndent_Click
            RemoveHandler Me.buttonInsertSymbol.Click, AddressOf Me.buttonInsertSymbol_Click
            RemoveHandler Me.buttonInsertTable.Click, AddressOf Me.buttonInsertTable_Click
            RemoveHandler Me.toggleButtonSubscript.ToggleStateChanged, AddressOf Me.toggleButtonSubscript_ToggleStateChanged
            RemoveHandler Me.toggleButtonSuperscript.ToggleStateChanged, AddressOf Me.toggleButtonSuperscript_ToggleStateChanged
            RemoveHandler Me.dropDownListFont.SelectedIndexChanged, AddressOf Me.dropDownListFont_SelectedIndexChanged
            RemoveHandler Me.dropDownListFontSize.SelectedIndexChanged, AddressOf Me.dropDownListFontSize_SelectedIndexChanged

            RemoveHandler Me.buttonPrint.Click, AddressOf buttonPrint_Click
            RemoveHandler Me.buttonSpellCheck.Click, AddressOf buttonSpellCheck_Click
            RemoveHandler Me.buttonFindAndReplace.Click, AddressOf buttonFindAndReplace_Click
            RemoveHandler Me.buttonCut.Click, AddressOf buttonCut_Click
            RemoveHandler Me.buttonCopy.Click, AddressOf buttonCopy_Click
            RemoveHandler Me.buttonPaste.Click, AddressOf buttonPaste_Click
            RemoveHandler Me.buttonUndo.Click, AddressOf buttonUndo_Click
            RemoveHandler Me.buttonRedo.Click, AddressOf buttonRedo_Click
            RemoveHandler Me.buttonForeColor.Click, AddressOf buttonForeColor_Click
            RemoveHandler Me.buttonBackColor.Click, AddressOf buttonBackColor_Click
            RemoveHandler Me.buttonClearFormatting.Click, AddressOf buttonClearFormatting_Click
            RemoveHandler Me.buttonInsertHyperlink.Click, AddressOf buttonInsertHyperlink_Click
        End Sub

        Private Sub buttonPrint_Click(sender As Object, e As EventArgs)
            Dim command As New PrintCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonSpellCheck_Click(sender As Object, e As EventArgs)
            Dim command As New ShowSpellCheckingDialogCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonFindAndReplace_Click(sender As Object, e As EventArgs)
            Dim command As New ShowFindReplaceDialogCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonCut_Click(sender As Object, e As EventArgs)
            Dim command As New CutCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonCopy_Click(sender As Object, e As EventArgs)
            Dim command As New CopyCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonPaste_Click(sender As Object, e As EventArgs)
            Dim command As New PasteCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonUndo_Click(sender As Object, e As EventArgs)
            Dim command As New UndoCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonRedo_Click(sender As Object, e As EventArgs)
            Dim command As New RedoCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonForeColor_Click(sender As Object, e As EventArgs)
            Dim dialog As New RadColorDialog()

            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim command As New ChangeFontForeColorCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
                command.Execute(Telerik.WinControls.RichTextEditor.UI.Color.FromArgb(dialog.SelectedColor.A, dialog.SelectedColor.R, dialog.SelectedColor.G, dialog.SelectedColor.B))
            End If
        End Sub

        Private Sub buttonBackColor_Click(sender As Object, e As EventArgs)
            Dim dialog As New RadColorDialog()

            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim command As New ChangeFontHighlightColorCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
                command.Execute(Telerik.WinControls.RichTextEditor.UI.Color.FromArgb(dialog.SelectedColor.A, dialog.SelectedColor.R, dialog.SelectedColor.G, dialog.SelectedColor.B))
            End If
        End Sub

        Private Sub buttonClearFormatting_Click(sender As Object, e As EventArgs)
            Dim command As New ClearFormattingCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonInsertImage_Click(sender As Object, e As EventArgs)
            Dim command As New InsertPictureCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonInsertHyperlink_Click(sender As Object, e As EventArgs)
            Dim command As New ShowInsertHyperlinkDialogCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub toggleButtonBold_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Dim command As New ToggleBoldCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub toggleButtonItalic_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Dim command As New ToggleItalicCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub toggleButtonUnderline_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Dim command As New ToggleUnderlineCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub toggleButtonStrikethrough_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Dim command As New ToggleStrikethroughCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub toggleButtonAlignLeft_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            If args.ToggleState = ToggleState.[On] Then
                Dim command As New ChangeTextAlignmentCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
                command.Execute(RadTextAlignment.Left)
            End If
        End Sub

        Private Sub toggleButtonAlignCenter_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            If args.ToggleState = ToggleState.[On] Then
                Dim command As New ChangeTextAlignmentCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
                command.Execute(RadTextAlignment.Center)
            End If
        End Sub

        Private Sub toggleButtonAlignRight_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            If args.ToggleState = ToggleState.[On] Then
                Dim command As New ChangeTextAlignmentCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
                command.Execute(RadTextAlignment.Right)
            End If
        End Sub

        Private Sub toggleButtonJustify_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            If args.ToggleState = ToggleState.[On] Then
                Dim command As New ChangeTextAlignmentCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
                command.Execute(RadTextAlignment.Justify)
            End If
        End Sub

        Private Sub buttonOutdent_Click(sender As Object, e As EventArgs)
            Dim command As New DecrementParagraphLeftIndentCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonIndent_Click(sender As Object, e As EventArgs)
            Dim command As New IncrementParagraphLeftIndentCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub toggleButtonBulletList_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Dim command As New ToggleBulletsCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub toggleButtonNumberedList_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Dim command As New ToggleNumberedCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonInsertSymbol_Click(sender As Object, e As EventArgs)
            Dim command As New ShowInsertSymbolWindowCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub buttonInsertTable_Click(sender As Object, e As EventArgs)
            Dim command As New ShowInsertTableDialogCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub toggleButtonSubscript_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Dim command As New ToggleSubscriptCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub toggleButtonSuperscript_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Dim command As New ToggleSuperscriptCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute()
        End Sub

        Private Sub dropDownListFont_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Dim command As New ChangeFontFamilyCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute(Me.dropDownListFont.SelectedText)
        End Sub

        Private Sub dropDownListFontSize_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Dim command As New ChangeFontSizeCommand(Me.radRichTextEditor1.RichTextBoxElement.ActiveEditor)
            command.Execute(Me.dropDownListFontSize.SelectedText)
        End Sub
    End Class
End Namespace