Imports Microsoft.VisualBasic
Imports System
Namespace RichTextEditor.SearchHighlight
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
			Me.commandBarTextBox1 = New Telerik.WinControls.UI.CommandBarTextBox()
			Me.toggleButtonSearchResults = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.toggleButtonCurrentWord = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.toggleButtonCurrentLine = New Telerik.WinControls.UI.CommandBarToggleButton()
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
			Me.radCommandBar1.Size = New System.Drawing.Size(1157, 30)
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
			Me.commandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.commandBarTextBox1, Me.toggleButtonSearchResults, Me.toggleButtonCurrentWord, Me.toggleButtonCurrentLine})
			Me.commandBarStripElement1.Name = "commandBarStripElement1"
			Me.commandBarStripElement1.StretchHorizontally = True
			' 
			' commandBarTextBox1
			' 
			Me.commandBarTextBox1.DisplayName = "commandBarTextBox1"
			Me.commandBarTextBox1.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
			Me.commandBarTextBox1.MinSize = New System.Drawing.Size(170, 0)
			Me.commandBarTextBox1.Name = "commandBarTextBox1"
			Me.commandBarTextBox1.NullText = "Find in document"
			Me.commandBarTextBox1.Text = ""
			' 
			' toggleButtonSearchResults
			' 
			Me.toggleButtonSearchResults.AccessibleDescription = "Highlight Results"
			Me.toggleButtonSearchResults.AccessibleName = "Highlight Results"
			Me.toggleButtonSearchResults.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toggleButtonSearchResults.DisplayName = "commandBarToggleButton1"
			Me.toggleButtonSearchResults.DrawImage = False
			Me.toggleButtonSearchResults.DrawText = True
			Me.toggleButtonSearchResults.Image = (CType(resources.GetObject("toggleButtonSearchResults.Image"), System.Drawing.Image))
			Me.toggleButtonSearchResults.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
			Me.toggleButtonSearchResults.Name = "toggleButtonSearchResults"
			Me.toggleButtonSearchResults.Text = "Highlight Results"
			Me.toggleButtonSearchResults.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' toggleButtonCurrentWord
			' 
			Me.toggleButtonCurrentWord.AccessibleDescription = "Highlight Current Word"
			Me.toggleButtonCurrentWord.AccessibleName = "Highlight Current Word"
			Me.toggleButtonCurrentWord.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toggleButtonCurrentWord.DisplayName = "commandBarToggleButton2"
			Me.toggleButtonCurrentWord.DrawImage = False
			Me.toggleButtonCurrentWord.DrawText = True
			Me.toggleButtonCurrentWord.Image = (CType(resources.GetObject("toggleButtonCurrentWord.Image"), System.Drawing.Image))
			Me.toggleButtonCurrentWord.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
			Me.toggleButtonCurrentWord.Name = "toggleButtonCurrentWord"
			Me.toggleButtonCurrentWord.Text = "Highlight Current Word"
			Me.toggleButtonCurrentWord.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' toggleButtonCurrentLine
			' 
			Me.toggleButtonCurrentLine.AccessibleDescription = "Highlight Current Line"
			Me.toggleButtonCurrentLine.AccessibleName = "Highlight Current Line"
			Me.toggleButtonCurrentLine.DisplayName = "commandBarToggleButton3"
			Me.toggleButtonCurrentLine.DrawImage = False
			Me.toggleButtonCurrentLine.DrawText = True
			Me.toggleButtonCurrentLine.Image = (CType(resources.GetObject("toggleButtonCurrentLine.Image"), System.Drawing.Image))
			Me.toggleButtonCurrentLine.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
			Me.toggleButtonCurrentLine.Name = "toggleButtonCurrentLine"
			Me.toggleButtonCurrentLine.Text = "Highlight Current Line"
			' 
			' radRichTextEditor1
			' 
			Me.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radRichTextEditor1.IsReadOnly = True
			Me.radRichTextEditor1.Location = New System.Drawing.Point(0, 30)
			Me.radRichTextEditor1.Name = "radRichTextEditor1"
			Me.radRichTextEditor1.Size = New System.Drawing.Size(1157, 677)
			Me.radRichTextEditor1.TabIndex = 0
			Me.radRichTextEditor1.Text = "radRichTextEditor1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1157, 707)
			Me.Controls.Add(Me.radRichTextEditor1)
			Me.Controls.Add(Me.radCommandBar1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Search Highlight"
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
		Private WithEvents commandBarTextBox1 As Telerik.WinControls.UI.CommandBarTextBox
		Private WithEvents toggleButtonSearchResults As Telerik.WinControls.UI.CommandBarToggleButton
		Private WithEvents toggleButtonCurrentWord As Telerik.WinControls.UI.CommandBarToggleButton
		Private WithEvents toggleButtonCurrentLine As Telerik.WinControls.UI.CommandBarToggleButton
		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
	End Class
End Namespace