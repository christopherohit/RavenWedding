Imports System.ComponentModel
Namespace Telerik.Examples.WinControls.MenuStrip.ApplicationMenu
	Partial Public Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radAppMenuDemo = New Telerik.WinControls.UI.RadApplicationMenu()
			Me.radMenuButtonItem1 = New Telerik.WinControls.UI.RadMenuButtonItem()
			Me.radMenuButtonItem2 = New Telerik.WinControls.UI.RadMenuButtonItem()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuHeaderItem2 = New Telerik.WinControls.UI.RadMenuHeaderItem()
			Me.radMenuItem13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem14 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem15 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem16 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuHeaderItem3 = New Telerik.WinControls.UI.RadMenuHeaderItem()
			Me.radMenuItem17 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem18 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem19 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuHeaderItem1 = New Telerik.WinControls.UI.RadMenuHeaderItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem11 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radAppMenuDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 818)
			' 
			' radAppMenuDemo
			' 
			Me.radAppMenuDemo.ButtonItems.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuButtonItem1, Me.radMenuButtonItem2})
			Me.radAppMenuDemo.ImageAlignment = ContentAlignment.MiddleCenter
			Me.radAppMenuDemo.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3, Me.radMenuItem4, Me.radMenuSeparatorItem1, Me.radMenuItem5, Me.radMenuSeparatorItem2, Me.radMenuItem9})
			Me.radAppMenuDemo.Location = New Point(2, 2)
			Me.radAppMenuDemo.Margin = New Padding(0)
			Me.radAppMenuDemo.Name = "radAppMenuDemo"
			Me.radAppMenuDemo.RightColumnItems.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuHeaderItem1, Me.radMenuItem10, Me.radMenuItem11, Me.radMenuItem12})
			Me.radAppMenuDemo.Size = New Size(45, 45)
			Me.radAppMenuDemo.TabIndex = 0
			Me.radAppMenuDemo.Text = "radApplicationMenu1"
			Me.radAppMenuDemo.DropDownButtonElement.ArrowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			' 
			' radMenuButtonItem1
			' 
			Me.radMenuButtonItem1.AccessibleDescription = "Options"
			Me.radMenuButtonItem1.AccessibleName = "Options"
			' 
			' 
			' 
			Me.radMenuButtonItem1.ButtonElement.AccessibleDescription = "Options"
			Me.radMenuButtonItem1.ButtonElement.AccessibleName = "Options"
			Me.radMenuButtonItem1.ButtonElement.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuButtonItem1.Name = "radMenuButtonItem1"
			Me.radMenuButtonItem1.Text = "Options"
			Me.radMenuButtonItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radMenuButtonItem1.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuButtonItem2
			' 
			Me.radMenuButtonItem2.AccessibleDescription = "Exit"
			Me.radMenuButtonItem2.AccessibleName = "Exit"
			' 
			' 
			' 
			Me.radMenuButtonItem2.ButtonElement.AccessibleDescription = "Exit"
			Me.radMenuButtonItem2.ButtonElement.AccessibleName = "Exit"
			Me.radMenuButtonItem2.ButtonElement.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuButtonItem2.Name = "radMenuButtonItem2"
			Me.radMenuButtonItem2.Text = "Exit"
			Me.radMenuButtonItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radMenuButtonItem2.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.AccessibleDescription = "New"
			Me.radMenuItem1.AccessibleName = "New"
			Me.radMenuItem1.Image = My.Resources.RibbonMenuNewMagenta
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "New"
			Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.AccessibleDescription = "Open"
			Me.radMenuItem2.AccessibleName = "Open"
			Me.radMenuItem2.Image = My.Resources.RibbonMenuOpenMagenta
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Open"
			Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.AccessibleDescription = "Save"
			Me.radMenuItem3.AccessibleName = "Save"
			Me.radMenuItem3.Image = My.Resources.RibbonMenuSaveMagenta
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "Save"
			Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.AccessibleDescription = "Save As"
			Me.radMenuItem4.AccessibleName = "Save As"
			Me.radMenuItem4.Image = My.Resources.RibbonMenuSaveAsMagenta
			Me.radMenuItem4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuHeaderItem2, Me.radMenuItem13, Me.radMenuItem14, Me.radMenuItem15, Me.radMenuItem16})
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "Save As"
			Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuHeaderItem2
			' 
			Me.radMenuHeaderItem2.AccessibleDescription = "Save a copy of the document"
			Me.radMenuHeaderItem2.AccessibleName = "Save a copy of the document"
			Me.radMenuHeaderItem2.Name = "radMenuHeaderItem2"
			Me.radMenuHeaderItem2.Text = "Save a copy of the document"
			Me.radMenuHeaderItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem13
			' 
			Me.radMenuItem13.AccessibleDescription = "Word Document"
			Me.radMenuItem13.AccessibleName = "Word Document"
			Me.radMenuItem13.DescriptionText = "Save the document in the default file format."
			Me.radMenuItem13.Image = My.Resources.RibbonMenuSaveMagenta
			Me.radMenuItem13.Name = "radMenuItem13"
			Me.radMenuItem13.Text = "Word Document"
			Me.radMenuItem13.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem14
			' 
			Me.radMenuItem14.AccessibleDescription = "Word Template"
			Me.radMenuItem14.AccessibleName = "Word Template"
			Me.radMenuItem14.DescriptionText = "Save the document as a template that can be" & vbLf & " used to format future documents."
			Me.radMenuItem14.Image = My.Resources.RibbonMenuSaveMagenta
			Me.radMenuItem14.Name = "radMenuItem14"
			Me.radMenuItem14.Text = "Word Template"
			Me.radMenuItem14.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem15
			' 
			Me.radMenuItem15.AccessibleDescription = "Word 97-2003 Document"
			Me.radMenuItem15.AccessibleName = "Word 97-2003 Document"
			Me.radMenuItem15.DescriptionText = "Save a copy of the document that is fully" & vbLf & " compatible with Word97-2003"
			Me.radMenuItem15.Image = My.Resources.RibbonMenuSaveMagenta
			Me.radMenuItem15.Name = "radMenuItem15"
			Me.radMenuItem15.Text = "Word 97-2003 Document"
			Me.radMenuItem15.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem16
			' 
			Me.radMenuItem16.AccessibleDescription = "Other Formats"
			Me.radMenuItem16.AccessibleName = "Other Formats"
			Me.radMenuItem16.DescriptionText = "Open the Save As dialog box to select from" & vbLf & " all possible file types."
			Me.radMenuItem16.Image = My.Resources.RibbonMenuSaveMagenta
			Me.radMenuItem16.Name = "radMenuItem16"
			Me.radMenuItem16.Text = "Other Formats"
			Me.radMenuItem16.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.AccessibleDescription = "New item"
			Me.radMenuSeparatorItem1.AccessibleName = "New item"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "New item"
			Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.AccessibleDescription = "Print"
			Me.radMenuItem5.AccessibleName = "Print"
			Me.radMenuItem5.Image = My.Resources._5RibbonbarMenuPrintMagenta
			Me.radMenuItem5.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuHeaderItem3, Me.radMenuItem17, Me.radMenuItem18, Me.radMenuItem19})
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "Print"
			Me.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuHeaderItem3
			' 
			Me.radMenuHeaderItem3.AccessibleDescription = "Preview and print the document"
			Me.radMenuHeaderItem3.AccessibleName = "Preview and print the document"
			Me.radMenuHeaderItem3.Name = "radMenuHeaderItem3"
			Me.radMenuHeaderItem3.Text = "Preview and print the document"
			Me.radMenuHeaderItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem17
			' 
			Me.radMenuItem17.AccessibleDescription = "Print"
			Me.radMenuItem17.AccessibleName = "Print"
			Me.radMenuItem17.DescriptionText = "Select a printer, number of copies, and" & vbLf & " other printing options before printing."
			Me.radMenuItem17.Image = My.Resources._5RibbonbarMenuPrintMagenta
			Me.radMenuItem17.Name = "radMenuItem17"
			Me.radMenuItem17.Text = "Print"
			Me.radMenuItem17.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem18
			' 
			Me.radMenuItem18.AccessibleDescription = "Quick Print"
			Me.radMenuItem18.AccessibleName = "Quick Print"
			Me.radMenuItem18.DescriptionText = "Send the document directly to the printer," & vbLf & " without making changes."
			Me.radMenuItem18.Image = My.Resources._5RibbonbarMenuPrintMagenta
			Me.radMenuItem18.Name = "radMenuItem18"
			Me.radMenuItem18.Text = "Quick Print"
			Me.radMenuItem18.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem19
			' 
			Me.radMenuItem19.AccessibleDescription = "Print Preview"
			Me.radMenuItem19.AccessibleName = "Print Preview"
			Me.radMenuItem19.DescriptionText = "Preview and make changes to pages before" & vbLf & " printing."
			Me.radMenuItem19.Image = My.Resources._5RibbonbarMenuPrintMagenta
			Me.radMenuItem19.Name = "radMenuItem19"
			Me.radMenuItem19.Text = "Print Preview"
			Me.radMenuItem19.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.AccessibleDescription = "New item"
			Me.radMenuSeparatorItem2.AccessibleName = "New item"
			Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Text = "New item"
			Me.radMenuSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.AccessibleDescription = "Close"
			Me.radMenuItem9.AccessibleName = "Close"
			Me.radMenuItem9.Image = My.Resources._9RibbonMenuCloseMagenta
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "Close"
			Me.radMenuItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuHeaderItem1
			' 
			Me.radMenuHeaderItem1.AccessibleDescription = "Recent Documents"
			Me.radMenuHeaderItem1.AccessibleName = "Recent Documents"
			Me.radMenuHeaderItem1.Name = "radMenuHeaderItem1"
			Me.radMenuHeaderItem1.Text = "Recent Documents"
			Me.radMenuHeaderItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.AccessibleDescription = "Document 1.txt"
			Me.radMenuItem10.AccessibleName = "Document 1.txt"
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Text = "Document 1.txt"
			Me.radMenuItem10.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem11
			' 
			Me.radMenuItem11.AccessibleDescription = "Document 2.txt"
			Me.radMenuItem11.AccessibleName = "Document 2.txt"
			Me.radMenuItem11.Name = "radMenuItem11"
			Me.radMenuItem11.Text = "Document 2.txt"
			Me.radMenuItem11.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem12
			' 
			Me.radMenuItem12.AccessibleDescription = "Document 3.txt"
			Me.radMenuItem12.AccessibleName = "Document 3.txt"
			Me.radMenuItem12.Name = "radMenuItem12"
			Me.radMenuItem12.Text = "Document 3.txt"
			Me.radMenuItem12.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radAppMenuDemo)
            Me.radPanel1.Location = New Point(20, 20)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(500, 350)
			Me.radPanel1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1258, 754)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radAppMenuDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radAppMenuDemo As Telerik.WinControls.UI.RadApplicationMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuButtonItem1 As Telerik.WinControls.UI.RadMenuButtonItem
		Private radMenuButtonItem2 As Telerik.WinControls.UI.RadMenuButtonItem
		Private radMenuHeaderItem1 As Telerik.WinControls.UI.RadMenuHeaderItem
		Private radMenuItem10 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem11 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem12 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuHeaderItem2 As Telerik.WinControls.UI.RadMenuHeaderItem
		Private radMenuItem13 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem14 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem15 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem16 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuHeaderItem3 As Telerik.WinControls.UI.RadMenuHeaderItem
		Private radMenuItem17 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem18 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem19 As Telerik.WinControls.UI.RadMenuItem
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace
