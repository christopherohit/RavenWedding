Imports Microsoft.VisualBasic
Imports System
Namespace RichTextEditor.MergeDocuments
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
			Me.commandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
			Me.commandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
			Me.commandBarDropDownButton1 = New Telerik.WinControls.UI.CommandBarDropDownButton()
			Me.browseMenuItem = New Telerik.WinControls.UI.RadMenuItem()
			Me.loadDocument1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.loadDocument2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.commandBarButtonClear = New Telerik.WinControls.UI.CommandBarButton()
			Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radCommandBar1
			' 
			Me.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radCommandBar1.Location = New System.Drawing.Point(0, 0)
			Me.radCommandBar1.Name = "radCommandBar1"
			Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() { Me.commandBarRowElement1})
			Me.radCommandBar1.Size = New System.Drawing.Size(743, 40)
			Me.radCommandBar1.TabIndex = 0
			Me.radCommandBar1.Text = "radCommandBar1"
			' 
			' commandBarRowElement1
			' 
			Me.commandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
			Me.commandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() { Me.commandBarStripElement1})
			' 
			' commandBarStripElement1
			' 
			Me.commandBarStripElement1.DisplayName = "commandBarStripElement1"
			Me.commandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.commandBarDropDownButton1, Me.commandBarButtonClear})
			Me.commandBarStripElement1.Name = "commandBarStripElement1"
			Me.commandBarStripElement1.StretchHorizontally = True
			' 
			' commandBarDropDownButton1
			' 
			Me.commandBarDropDownButton1.AccessibleDescription = "Insert Document"
			Me.commandBarDropDownButton1.AccessibleName = "Insert Document"
			Me.commandBarDropDownButton1.DisplayName = "commandBarDropDownButton1"
			Me.commandBarDropDownButton1.DrawText = True
			Me.commandBarDropDownButton1.Image = (CType(resources.GetObject("commandBarDropDownButton1.Image"), System.Drawing.Image))
			Me.commandBarDropDownButton1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.browseMenuItem, Me.loadDocument1, Me.loadDocument2})
			Me.commandBarDropDownButton1.Name = "commandBarDropDownButton1"
			Me.commandBarDropDownButton1.Text = "Insert Document"
			Me.commandBarDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' browseMenuItem
			' 
			Me.browseMenuItem.AccessibleDescription = "Browse for document"
			Me.browseMenuItem.AccessibleName = "Browse for document"
			Me.browseMenuItem.Name = "browseMenuItem"
			Me.browseMenuItem.Text = "Browse for document"
			' 
			' loadDocument1
			' 
			Me.loadDocument1.AccessibleDescription = "Load predefined documen1"
			Me.loadDocument1.AccessibleName = "Load predefined document 1"
			Me.loadDocument1.Name = "loadDocument1"
			Me.loadDocument1.Text = "Load predefined document 1"
			' 
			' loadDocument2
			' 
			Me.loadDocument2.AccessibleDescription = "Load predefined documen2"
			Me.loadDocument2.AccessibleName = "Load predefined document 2"
			Me.loadDocument2.Name = "loadDocument2"
			Me.loadDocument2.Text = "Load predefined document 2"
			' 
			' commandBarButtonClear
			' 
			Me.commandBarButtonClear.AccessibleDescription = "Clear"
			Me.commandBarButtonClear.AccessibleName = "Clear"
			Me.commandBarButtonClear.DisplayName = "commandBarButton1"
			Me.commandBarButtonClear.DrawText = True
			Me.commandBarButtonClear.Image = (CType(resources.GetObject("commandBarButtonClear.Image"), System.Drawing.Image))
			Me.commandBarButtonClear.Name = "commandBarButtonClear"
			Me.commandBarButtonClear.Text = "Clear"
			Me.commandBarButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radRichTextEditor1
			' 
			Me.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radRichTextEditor1.Location = New System.Drawing.Point(0, 40)
			Me.radRichTextEditor1.Name = "radRichTextEditor1"
			Me.radRichTextEditor1.Size = New System.Drawing.Size(743, 528)
			Me.radRichTextEditor1.TabIndex = 1
			Me.radRichTextEditor1.Text = "radRichTextEditor1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(743, 568)
			Me.Controls.Add(Me.radRichTextEditor1)
			Me.Controls.Add(Me.radCommandBar1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Merge Documents"
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
		Private commandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
		Private commandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
		Private WithEvents commandBarButtonClear As Telerik.WinControls.UI.CommandBarButton
		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
		Private commandBarDropDownButton1 As Telerik.WinControls.UI.CommandBarDropDownButton
		Private WithEvents browseMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents loadDocument1 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents loadDocument2 As Telerik.WinControls.UI.RadMenuItem
	End Class
End Namespace