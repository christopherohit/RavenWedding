
Namespace RichTextEditor.CommandBarUI
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
            Me.commandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.commandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.buttonPrint = New Telerik.WinControls.UI.CommandBarButton()
            Me.buttonSpellCheck = New Telerik.WinControls.UI.CommandBarButton()
            Me.buttonFindAndReplace = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.buttonCut = New Telerik.WinControls.UI.CommandBarButton()
            Me.buttonCopy = New Telerik.WinControls.UI.CommandBarButton()
            Me.buttonPaste = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.buttonUndo = New Telerik.WinControls.UI.CommandBarButton()
            Me.buttonRedo = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.dropDownListFont = New Telerik.WinControls.UI.CommandBarDropDownList()
            Me.dropDownListFontSize = New Telerik.WinControls.UI.CommandBarDropDownList()
            Me.commandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.buttonForeColor = New Telerik.WinControls.UI.CommandBarButton()
            Me.buttonBackColor = New Telerik.WinControls.UI.CommandBarButton()
            Me.buttonClearFormatting = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarRowElement2 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.commandBarStripElement2 = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.buttonInsertImage = New Telerik.WinControls.UI.CommandBarButton()
            Me.buttonInsertHyperlink = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.toggleButtonBold = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.toggleButtonItalic = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.toggleButtonUnderline = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.toggleButtonStrikethrough = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.commandBarSeparator6 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.toggleButtonAlignLeft = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.toggleButtonAlignCenter = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.toggleButtonAlignRight = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.toggleButtonJustify = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.commandBarSeparator7 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.buttonOutdent = New Telerik.WinControls.UI.CommandBarButton()
            Me.buttonIndent = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator8 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.toggleButtonBulletList = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.toggleButtonNumberedList = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.commandBarSeparator9 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.buttonInsertSymbol = New Telerik.WinControls.UI.CommandBarButton()
            Me.buttonInsertTable = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator10 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.toggleButtonSubscript = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.toggleButtonSuperscript = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.radRichTextEditorRuler1 = New Telerik.WinControls.UI.RadRichTextEditorRuler()
            Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
            DirectCast(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRichTextEditorRuler1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radRichTextEditorRuler1.SuspendLayout()
            DirectCast(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radCommandBar1
            ' 
            Me.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radCommandBar1.Location = New System.Drawing.Point(0, 0)
            Me.radCommandBar1.Name = "radCommandBar1"
            Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.commandBarRowElement1, Me.commandBarRowElement2})
            Me.radCommandBar1.Size = New System.Drawing.Size(769, 60)
            Me.radCommandBar1.TabIndex = 0
            Me.radCommandBar1.Text = "radCommandBar1"
            ' 
            ' commandBarRowElement1
            ' 
            Me.commandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.commandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.commandBarStripElement1})
            ' 
            ' commandBarStripElement1
            ' 
            Me.commandBarStripElement1.DisplayName = "commandBarStripElement1"
            Me.commandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.buttonPrint, Me.buttonSpellCheck, Me.buttonFindAndReplace, Me.commandBarSeparator1, Me.buttonCut, Me.buttonCopy, _
                Me.buttonPaste, Me.commandBarSeparator2, Me.buttonUndo, Me.buttonRedo, Me.commandBarSeparator3, Me.dropDownListFont, _
                Me.dropDownListFontSize, Me.commandBarSeparator4, Me.buttonForeColor, Me.buttonBackColor, Me.buttonClearFormatting})
            Me.commandBarStripElement1.Name = "commandBarStripElement1"
            ' 
            ' buttonPrint
            ' 
            Me.buttonPrint.AccessibleDescription = "Print"
            Me.buttonPrint.AccessibleName = "Print"
            Me.buttonPrint.DisplayName = "commandBarButton1"
            Me.buttonPrint.Image = Global.Resources.print16
            Me.buttonPrint.Name = "buttonPrint"
            Me.buttonPrint.Text = "Print"
            ' 
            ' buttonSpellCheck
            ' 
            Me.buttonSpellCheck.AccessibleDescription = "Spell Check"
            Me.buttonSpellCheck.AccessibleName = "Spell Check"
            Me.buttonSpellCheck.DisplayName = "commandBarButton2"
            Me.buttonSpellCheck.Image = Global.Resources.EnableSpellCheck16
            Me.buttonSpellCheck.Name = "buttonSpellCheck"
            Me.buttonSpellCheck.Text = "Spell Check"
            ' 
            ' buttonFindAndReplace
            ' 
            Me.buttonFindAndReplace.AccessibleDescription = "Find And Replace"
            Me.buttonFindAndReplace.AccessibleName = "Find And Replace"
            Me.buttonFindAndReplace.DisplayName = "commandBarButton3"
            Me.buttonFindAndReplace.Image = Global.Resources.find16
            Me.buttonFindAndReplace.Name = "buttonFindAndReplace"
            Me.buttonFindAndReplace.Text = "Find And Replace"
            ' 
            ' commandBarSeparator1
            ' 
            Me.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1"
            Me.commandBarSeparator1.AccessibleName = "commandBarSeparator1"
            Me.commandBarSeparator1.DisplayName = "commandBarSeparator1"
            Me.commandBarSeparator1.Name = "commandBarSeparator1"
            Me.commandBarSeparator1.VisibleInOverflowMenu = False
            ' 
            ' buttonCut
            ' 
            Me.buttonCut.AccessibleDescription = "Cut"
            Me.buttonCut.AccessibleName = "Cut"
            Me.buttonCut.DisplayName = "commandBarButton4"
            Me.buttonCut.Image = Global.Resources.cut16
            Me.buttonCut.Name = "buttonCut"
            Me.buttonCut.Text = "Cut"
            ' 
            ' buttonCopy
            ' 
            Me.buttonCopy.AccessibleDescription = "Copy"
            Me.buttonCopy.AccessibleName = "Copy"
            Me.buttonCopy.DisplayName = "commandBarButton5"
            Me.buttonCopy.Image = Global.Resources.copy16
            Me.buttonCopy.Name = "buttonCopy"
            Me.buttonCopy.Text = "Copy"
            ' 
            ' buttonPaste
            ' 
            Me.buttonPaste.AccessibleDescription = "Paste"
            Me.buttonPaste.AccessibleName = "Paste"
            Me.buttonPaste.DisplayName = "commandBarButton6"
            Me.buttonPaste.Image = Global.Resources.paste16
            Me.buttonPaste.Name = "buttonPaste"
            Me.buttonPaste.Text = "Paste"
            ' 
            ' commandBarSeparator2
            ' 
            Me.commandBarSeparator2.AccessibleDescription = "commandBarSeparator2"
            Me.commandBarSeparator2.AccessibleName = "commandBarSeparator2"
            Me.commandBarSeparator2.DisplayName = "commandBarSeparator2"
            Me.commandBarSeparator2.Name = "commandBarSeparator2"
            Me.commandBarSeparator2.VisibleInOverflowMenu = False
            ' 
            ' buttonUndo
            ' 
            Me.buttonUndo.AccessibleDescription = "Undo"
            Me.buttonUndo.AccessibleName = "Undo"
            Me.buttonUndo.DisplayName = "commandBarButton7"
            Me.buttonUndo.Image = Global.Resources.undo16
            Me.buttonUndo.Name = "buttonUndo"
            Me.buttonUndo.Text = "Undo"
            ' 
            ' buttonRedo
            ' 
            Me.buttonRedo.AccessibleDescription = "Redo"
            Me.buttonRedo.AccessibleName = "Redo"
            Me.buttonRedo.DisplayName = "commandBarButton8"
            Me.buttonRedo.Image = Global.Resources.redo16
            Me.buttonRedo.Name = "buttonRedo"
            Me.buttonRedo.Text = "Redo"
            ' 
            ' commandBarSeparator3
            ' 
            Me.commandBarSeparator3.AccessibleDescription = "commandBarSeparator3"
            Me.commandBarSeparator3.AccessibleName = "commandBarSeparator3"
            Me.commandBarSeparator3.DisplayName = "commandBarSeparator3"
            Me.commandBarSeparator3.Name = "commandBarSeparator3"
            Me.commandBarSeparator3.VisibleInOverflowMenu = False
            ' 
            ' dropDownListFont
            ' 
            Me.dropDownListFont.DisplayName = "commandBarDropDownList1"
            Me.dropDownListFont.DropDownAnimationEnabled = True
            Me.dropDownListFont.MaxDropDownItems = 0
            Me.dropDownListFont.Name = "dropDownListFont"
            Me.dropDownListFont.Text = ""
            ' 
            ' dropDownListFontSize
            ' 
            Me.dropDownListFontSize.DisplayName = "commandBarDropDownList2"
            Me.dropDownListFontSize.DropDownAnimationEnabled = True
            Me.dropDownListFontSize.MaxDropDownItems = 0
            Me.dropDownListFontSize.MinSize = New System.Drawing.Size(50, 22)
            Me.dropDownListFontSize.Name = "dropDownListFontSize"
            Me.dropDownListFontSize.Text = ""
            ' 
            ' commandBarSeparator4
            ' 
            Me.commandBarSeparator4.AccessibleDescription = "commandBarSeparator4"
            Me.commandBarSeparator4.AccessibleName = "commandBarSeparator4"
            Me.commandBarSeparator4.DisplayName = "commandBarSeparator4"
            Me.commandBarSeparator4.Name = "commandBarSeparator4"
            Me.commandBarSeparator4.VisibleInOverflowMenu = False
            ' 
            ' buttonForeColor
            ' 
            Me.buttonForeColor.AccessibleDescription = "Fore Color"
            Me.buttonForeColor.AccessibleName = "Fore Color"
            Me.buttonForeColor.DisplayName = "commandBarButton9"
            Me.buttonForeColor.Image = Global.Resources.fontcolor16
            Me.buttonForeColor.Name = "buttonForeColor"
            Me.buttonForeColor.Text = "Fore Color"
            ' 
            ' buttonBackColor
            ' 
            Me.buttonBackColor.AccessibleDescription = "Back Color"
            Me.buttonBackColor.AccessibleName = "Back Color"
            Me.buttonBackColor.DisplayName = "commandBarButton10"
            Me.buttonBackColor.Image = Global.Resources.highlight16
            Me.buttonBackColor.Name = "buttonBackColor"
            Me.buttonBackColor.Text = "Back Color"
            ' 
            ' buttonClearFormatting
            ' 
            Me.buttonClearFormatting.AccessibleDescription = "Clear Formatting"
            Me.buttonClearFormatting.AccessibleName = "Clear Formatting"
            Me.buttonClearFormatting.DisplayName = "commandBarButton11"
            Me.buttonClearFormatting.Image = Global.Resources.ClearFormatting16
            Me.buttonClearFormatting.Name = "buttonClearFormatting"
            Me.buttonClearFormatting.Text = "Clear Formatting"
            ' 
            ' commandBarRowElement2
            ' 
            Me.commandBarRowElement2.MinSize = New System.Drawing.Size(25, 25)
            Me.commandBarRowElement2.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.commandBarStripElement2})
            ' 
            ' commandBarStripElement2
            ' 
            Me.commandBarStripElement2.DisplayName = "commandBarStripElement2"
            Me.commandBarStripElement2.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.buttonInsertImage, Me.buttonInsertHyperlink, Me.commandBarSeparator5, Me.toggleButtonBold, Me.toggleButtonItalic, Me.toggleButtonUnderline, _
                Me.toggleButtonStrikethrough, Me.commandBarSeparator6, Me.toggleButtonAlignLeft, Me.toggleButtonAlignCenter, Me.toggleButtonAlignRight, Me.toggleButtonJustify, _
                Me.commandBarSeparator7, Me.buttonOutdent, Me.buttonIndent, Me.commandBarSeparator8, Me.toggleButtonBulletList, Me.toggleButtonNumberedList, _
                Me.commandBarSeparator9, Me.buttonInsertSymbol, Me.buttonInsertTable, Me.commandBarSeparator10, Me.toggleButtonSubscript, Me.toggleButtonSuperscript})
            Me.commandBarStripElement2.Name = "commandBarStripElement2"
            ' 
            ' buttonInsertImage
            ' 
            Me.buttonInsertImage.AccessibleDescription = "Insert Image"
            Me.buttonInsertImage.AccessibleName = "Insert Image"
            Me.buttonInsertImage.DisplayName = "commandBarButton12"
            Me.buttonInsertImage.Image = Global.Resources.picture16
            Me.buttonInsertImage.Name = "buttonInsertImage"
            Me.buttonInsertImage.Text = "Insert Image"
            ' 
            ' buttonInsertHyperlink
            ' 
            Me.buttonInsertHyperlink.AccessibleDescription = "Insert Hyperlink"
            Me.buttonInsertHyperlink.AccessibleName = "Insert Hyperlink"
            Me.buttonInsertHyperlink.DisplayName = "commandBarButton13"
            Me.buttonInsertHyperlink.Image = Global.Resources.inserthyperlink16
            Me.buttonInsertHyperlink.Name = "buttonInsertHyperlink"
            Me.buttonInsertHyperlink.Text = "Insert Hyperlink"
            ' 
            ' commandBarSeparator5
            ' 
            Me.commandBarSeparator5.AccessibleDescription = "commandBarSeparator5"
            Me.commandBarSeparator5.AccessibleName = "commandBarSeparator5"
            Me.commandBarSeparator5.DisplayName = "commandBarSeparator5"
            Me.commandBarSeparator5.Name = "commandBarSeparator5"
            Me.commandBarSeparator5.VisibleInOverflowMenu = False
            ' 
            ' toggleButtonBold
            ' 
            Me.toggleButtonBold.AccessibleDescription = "Bold"
            Me.toggleButtonBold.AccessibleName = "Bold"
            Me.toggleButtonBold.DisplayName = "commandBarToggleButton1"
            Me.toggleButtonBold.Image = Global.Resources.bold16
            Me.toggleButtonBold.Name = "toggleButtonBold"
            Me.toggleButtonBold.Text = "Bold"
            ' 
            ' toggleButtonItalic
            ' 
            Me.toggleButtonItalic.AccessibleDescription = "Italic"
            Me.toggleButtonItalic.AccessibleName = "Italic"
            Me.toggleButtonItalic.DisplayName = "commandBarToggleButton2"
            Me.toggleButtonItalic.Image = Global.Resources.italic16
            Me.toggleButtonItalic.Name = "toggleButtonItalic"
            Me.toggleButtonItalic.Text = "Italic"
            ' 
            ' toggleButtonUnderline
            ' 
            Me.toggleButtonUnderline.AccessibleDescription = "Underline"
            Me.toggleButtonUnderline.AccessibleName = "Underline"
            Me.toggleButtonUnderline.DisplayName = "commandBarToggleButton3"
            Me.toggleButtonUnderline.Image = Global.Resources.underline16
            Me.toggleButtonUnderline.Name = "toggleButtonUnderline"
            Me.toggleButtonUnderline.Text = "Underline"
            ' 
            ' toggleButtonStrikethrough
            ' 
            Me.toggleButtonStrikethrough.AccessibleDescription = "Striketrough"
            Me.toggleButtonStrikethrough.AccessibleName = "Striketrough"
            Me.toggleButtonStrikethrough.DisplayName = "commandBarToggleButton4"
            Me.toggleButtonStrikethrough.Image = Global.Resources.Strikethrough16
            Me.toggleButtonStrikethrough.Name = "toggleButtonStrikethrough"
            Me.toggleButtonStrikethrough.Text = "Striketrough"
            ' 
            ' commandBarSeparator6
            ' 
            Me.commandBarSeparator6.AccessibleDescription = "commandBarSeparator6"
            Me.commandBarSeparator6.AccessibleName = "commandBarSeparator6"
            Me.commandBarSeparator6.DisplayName = "commandBarSeparator6"
            Me.commandBarSeparator6.Name = "commandBarSeparator6"
            Me.commandBarSeparator6.VisibleInOverflowMenu = False
            ' 
            ' toggleButtonAlignLeft
            ' 
            Me.toggleButtonAlignLeft.AccessibleDescription = "Left"
            Me.toggleButtonAlignLeft.AccessibleName = "Left"
            Me.toggleButtonAlignLeft.DisplayName = "commandBarToggleButton5"
            Me.toggleButtonAlignLeft.Image = Global.Resources.alignleft16
            Me.toggleButtonAlignLeft.Name = "toggleButtonAlignLeft"
            Me.toggleButtonAlignLeft.Text = "Left"
            ' 
            ' toggleButtonAlignCenter
            ' 
            Me.toggleButtonAlignCenter.AccessibleDescription = "Center"
            Me.toggleButtonAlignCenter.AccessibleName = "Center"
            Me.toggleButtonAlignCenter.DisplayName = "commandBarToggleButton6"
            Me.toggleButtonAlignCenter.Image = Global.Resources.aligncenter16
            Me.toggleButtonAlignCenter.Name = "toggleButtonAlignCenter"
            Me.toggleButtonAlignCenter.Text = "Center"
            ' 
            ' toggleButtonAlignRight
            ' 
            Me.toggleButtonAlignRight.AccessibleDescription = "Right"
            Me.toggleButtonAlignRight.AccessibleName = "Right"
            Me.toggleButtonAlignRight.DisplayName = "commandBarToggleButton7"
            Me.toggleButtonAlignRight.Image = Global.Resources.alignright16
            Me.toggleButtonAlignRight.Name = "toggleButtonAlignRight"
            Me.toggleButtonAlignRight.Text = "Right"
            ' 
            ' toggleButtonJustify
            ' 
            Me.toggleButtonJustify.AccessibleDescription = "Justify"
            Me.toggleButtonJustify.AccessibleName = "Justify"
            Me.toggleButtonJustify.DisplayName = "commandBarToggleButton8"
            Me.toggleButtonJustify.Image = Global.Resources.alignjustify16
            Me.toggleButtonJustify.Name = "toggleButtonJustify"
            Me.toggleButtonJustify.Text = "Justify"
            ' 
            ' commandBarSeparator7
            ' 
            Me.commandBarSeparator7.AccessibleDescription = "commandBarSeparator7"
            Me.commandBarSeparator7.AccessibleName = "commandBarSeparator7"
            Me.commandBarSeparator7.DisplayName = "commandBarSeparator7"
            Me.commandBarSeparator7.Name = "commandBarSeparator7"
            Me.commandBarSeparator7.VisibleInOverflowMenu = False
            ' 
            ' buttonOutdent
            ' 
            Me.buttonOutdent.AccessibleDescription = "Outdent"
            Me.buttonOutdent.AccessibleName = "Outdent"
            Me.buttonOutdent.DisplayName = "commandBarButton14"
            Me.buttonOutdent.Image = Global.Resources.outdent16
            Me.buttonOutdent.Name = "buttonOutdent"
            Me.buttonOutdent.Text = "Outdent"
            ' 
            ' buttonIndent
            ' 
            Me.buttonIndent.AccessibleDescription = "Indent"
            Me.buttonIndent.AccessibleName = "Indent"
            Me.buttonIndent.DisplayName = "commandBarButton15"
            Me.buttonIndent.Image = Global.Resources.indent16
            Me.buttonIndent.Name = "buttonIndent"
            Me.buttonIndent.Text = "Indent"
            ' 
            ' commandBarSeparator8
            ' 
            Me.commandBarSeparator8.AccessibleDescription = "commandBarSeparator8"
            Me.commandBarSeparator8.AccessibleName = "commandBarSeparator8"
            Me.commandBarSeparator8.DisplayName = "commandBarSeparator8"
            Me.commandBarSeparator8.Name = "commandBarSeparator8"
            Me.commandBarSeparator8.VisibleInOverflowMenu = False
            ' 
            ' toggleButtonBulletList
            ' 
            Me.toggleButtonBulletList.AccessibleDescription = "Bullet list"
            Me.toggleButtonBulletList.AccessibleName = "Bullet list"
            Me.toggleButtonBulletList.DisplayName = "commandBarToggleButton9"
            Me.toggleButtonBulletList.Image = Global.Resources.list_bullets16
            Me.toggleButtonBulletList.Name = "toggleButtonBulletList"
            Me.toggleButtonBulletList.Text = "Bullet list"
            ' 
            ' toggleButtonNumberedList
            ' 
            Me.toggleButtonNumberedList.AccessibleDescription = "Numbered list"
            Me.toggleButtonNumberedList.AccessibleName = "Numbered list"
            Me.toggleButtonNumberedList.DisplayName = "commandBarToggleButton10"
            Me.toggleButtonNumberedList.Image = Global.Resources.list_numbered16
            Me.toggleButtonNumberedList.Name = "toggleButtonNumberedList"
            Me.toggleButtonNumberedList.Text = "Numbered list"
            ' 
            ' commandBarSeparator9
            ' 
            Me.commandBarSeparator9.AccessibleDescription = "commandBarSeparator9"
            Me.commandBarSeparator9.AccessibleName = "commandBarSeparator9"
            Me.commandBarSeparator9.DisplayName = "commandBarSeparator9"
            Me.commandBarSeparator9.Name = "commandBarSeparator9"
            Me.commandBarSeparator9.VisibleInOverflowMenu = False
            ' 
            ' buttonInsertSymbol
            ' 
            Me.buttonInsertSymbol.AccessibleDescription = "Insert Symbol"
            Me.buttonInsertSymbol.AccessibleName = "Insert Symbol"
            Me.buttonInsertSymbol.DisplayName = "commandBarButton16"
            Me.buttonInsertSymbol.Image = Global.Resources.symbol16
            Me.buttonInsertSymbol.Name = "buttonInsertSymbol"
            Me.buttonInsertSymbol.Text = "Insert Symbol"
            ' 
            ' buttonInsertTable
            ' 
            Me.buttonInsertTable.AccessibleDescription = "Insert Table"
            Me.buttonInsertTable.AccessibleName = "Insert Table"
            Me.buttonInsertTable.DisplayName = "commandBarButton17"
            Me.buttonInsertTable.Image = Global.Resources.InsertTable16
            Me.buttonInsertTable.Name = "buttonInsertTable"
            Me.buttonInsertTable.Text = "Insert Table"
            ' 
            ' commandBarSeparator10
            ' 
            Me.commandBarSeparator10.AccessibleDescription = "commandBarSeparator10"
            Me.commandBarSeparator10.AccessibleName = "commandBarSeparator10"
            Me.commandBarSeparator10.DisplayName = "commandBarSeparator10"
            Me.commandBarSeparator10.Name = "commandBarSeparator10"
            Me.commandBarSeparator10.VisibleInOverflowMenu = False
            ' 
            ' toggleButtonSubscript
            ' 
            Me.toggleButtonSubscript.AccessibleDescription = "Subscript"
            Me.toggleButtonSubscript.AccessibleName = "Subscript"
            Me.toggleButtonSubscript.DisplayName = "commandBarToggleButton11"
            Me.toggleButtonSubscript.Image = Global.Resources.subscript16
            Me.toggleButtonSubscript.Name = "toggleButtonSubscript"
            Me.toggleButtonSubscript.Text = "Subscript"
            ' 
            ' toggleButtonSuperscript
            ' 
            Me.toggleButtonSuperscript.AccessibleDescription = "Superscript"
            Me.toggleButtonSuperscript.AccessibleName = "Superscript"
            Me.toggleButtonSuperscript.DisplayName = "commandBarToggleButton12"
            Me.toggleButtonSuperscript.Image = Global.Resources.superscript16
            Me.toggleButtonSuperscript.Name = "toggleButtonSuperscript"
            Me.toggleButtonSuperscript.Text = "Superscript"
            ' 
            ' radRichTextEditorRuler1
            ' 
            Me.radRichTextEditorRuler1.AssociatedRichTextBox = Me.radRichTextEditor1
            Me.radRichTextEditorRuler1.Controls.Add(Me.radRichTextEditor1)
            Me.radRichTextEditorRuler1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radRichTextEditorRuler1.Location = New System.Drawing.Point(0, 60)
            Me.radRichTextEditorRuler1.Name = "radRichTextEditorRuler1"
            Me.radRichTextEditorRuler1.Size = New System.Drawing.Size(769, 593)
            Me.radRichTextEditorRuler1.TabIndex = 1
            Me.radRichTextEditorRuler1.Text = "radRichTextEditorRuler1"
            ' 
            ' radRichTextEditor1
            ' 
            Me.radRichTextEditor1.IsSelectionMiniToolBarEnabled = False
            Me.radRichTextEditor1.Location = New System.Drawing.Point(29, 29)
            Me.radRichTextEditor1.Name = "radRichTextEditor1"
            Me.radRichTextEditor1.Size = New System.Drawing.Size(739, 563)
            Me.radRichTextEditor1.TabIndex = 0
            Me.radRichTextEditor1.Text = "radRichTextEditor1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(769, 653)
            Me.Controls.Add(Me.radRichTextEditorRuler1)
            Me.Controls.Add(Me.radCommandBar1)
            Me.Name = "Form1"
            ' 
            ' 
            ' 
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "CommandBar UI"
            DirectCast(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRichTextEditorRuler1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radRichTextEditorRuler1.ResumeLayout(False)
            DirectCast(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
        Private commandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
        Private commandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
        Private buttonPrint As Telerik.WinControls.UI.CommandBarButton
        Private buttonSpellCheck As Telerik.WinControls.UI.CommandBarButton
        Private buttonFindAndReplace As Telerik.WinControls.UI.CommandBarButton
        Private commandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
        Private buttonCut As Telerik.WinControls.UI.CommandBarButton
        Private buttonCopy As Telerik.WinControls.UI.CommandBarButton
        Private buttonPaste As Telerik.WinControls.UI.CommandBarButton
        Private commandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
        Private buttonUndo As Telerik.WinControls.UI.CommandBarButton
        Private buttonRedo As Telerik.WinControls.UI.CommandBarButton
        Private commandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
        Private dropDownListFont As Telerik.WinControls.UI.CommandBarDropDownList
        Private dropDownListFontSize As Telerik.WinControls.UI.CommandBarDropDownList
        Private commandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
        Private buttonForeColor As Telerik.WinControls.UI.CommandBarButton
        Private buttonBackColor As Telerik.WinControls.UI.CommandBarButton
        Private buttonClearFormatting As Telerik.WinControls.UI.CommandBarButton
        Private commandBarRowElement2 As Telerik.WinControls.UI.CommandBarRowElement
        Private commandBarStripElement2 As Telerik.WinControls.UI.CommandBarStripElement
        Private buttonInsertImage As Telerik.WinControls.UI.CommandBarButton
        Private buttonInsertHyperlink As Telerik.WinControls.UI.CommandBarButton
        Private commandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
        Private radRichTextEditorRuler1 As Telerik.WinControls.UI.RadRichTextEditorRuler
        Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
        Private toggleButtonBold As Telerik.WinControls.UI.CommandBarToggleButton
        Private toggleButtonItalic As Telerik.WinControls.UI.CommandBarToggleButton
        Private toggleButtonUnderline As Telerik.WinControls.UI.CommandBarToggleButton
        Private toggleButtonStrikethrough As Telerik.WinControls.UI.CommandBarToggleButton
        Private commandBarSeparator6 As Telerik.WinControls.UI.CommandBarSeparator
        Private toggleButtonAlignLeft As Telerik.WinControls.UI.CommandBarToggleButton
        Private toggleButtonAlignCenter As Telerik.WinControls.UI.CommandBarToggleButton
        Private toggleButtonAlignRight As Telerik.WinControls.UI.CommandBarToggleButton
        Private toggleButtonJustify As Telerik.WinControls.UI.CommandBarToggleButton
        Private commandBarSeparator7 As Telerik.WinControls.UI.CommandBarSeparator
        Private buttonOutdent As Telerik.WinControls.UI.CommandBarButton
        Private buttonIndent As Telerik.WinControls.UI.CommandBarButton
        Private commandBarSeparator8 As Telerik.WinControls.UI.CommandBarSeparator
        Private toggleButtonBulletList As Telerik.WinControls.UI.CommandBarToggleButton
        Private toggleButtonNumberedList As Telerik.WinControls.UI.CommandBarToggleButton
        Private commandBarSeparator9 As Telerik.WinControls.UI.CommandBarSeparator
        Private buttonInsertSymbol As Telerik.WinControls.UI.CommandBarButton
        Private buttonInsertTable As Telerik.WinControls.UI.CommandBarButton
        Private commandBarSeparator10 As Telerik.WinControls.UI.CommandBarSeparator
        Private toggleButtonSubscript As Telerik.WinControls.UI.CommandBarToggleButton
        Private toggleButtonSuperscript As Telerik.WinControls.UI.CommandBarToggleButton
    End Class
End Namespace

