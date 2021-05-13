Imports Microsoft.VisualBasic
Imports System
Namespace RichTextEditor.DocumentAPI
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
			Me.commandBarToggleButtonBold = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.commandBarToggleButtonItalic = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.commandBarToggleButtonUnderline = New Telerik.WinControls.UI.CommandBarToggleButton()
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
			Me.radCommandBar1.Size = New System.Drawing.Size(725, 30)
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
			Me.commandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.commandBarToggleButtonBold, Me.commandBarToggleButtonItalic, Me.commandBarToggleButtonUnderline})
			Me.commandBarStripElement1.Name = "commandBarStripElement1"
			' 
			' commandBarToggleButtonBold
			' 
			Me.commandBarToggleButtonBold.AccessibleDescription = "commandBarToggleButton1"
			Me.commandBarToggleButtonBold.AccessibleName = "commandBarToggleButton1"
			Me.commandBarToggleButtonBold.DisplayName = "commandBarToggleButton1"
			Me.commandBarToggleButtonBold.Image = (CType(resources.GetObject("commandBarToggleButtonBold.Image"), System.Drawing.Image))
			Me.commandBarToggleButtonBold.Name = "commandBarToggleButtonBold"
			Me.commandBarToggleButtonBold.Text = "commandBarToggleButton1"
			' 
			' commandBarToggleButtonItalic
			' 
			Me.commandBarToggleButtonItalic.AccessibleDescription = "commandBarToggleButton2"
			Me.commandBarToggleButtonItalic.AccessibleName = "commandBarToggleButton2"
			Me.commandBarToggleButtonItalic.DisplayName = "commandBarToggleButton2"
			Me.commandBarToggleButtonItalic.Image = (CType(resources.GetObject("commandBarToggleButtonItalic.Image"), System.Drawing.Image))
			Me.commandBarToggleButtonItalic.Name = "commandBarToggleButtonItalic"
			Me.commandBarToggleButtonItalic.Text = "commandBarToggleButton2"
			' 
			' commandBarToggleButtonUnderline
			' 
			Me.commandBarToggleButtonUnderline.AccessibleDescription = "commandBarToggleButton3"
			Me.commandBarToggleButtonUnderline.AccessibleName = "commandBarToggleButton3"
			Me.commandBarToggleButtonUnderline.DisplayName = "commandBarToggleButton3"
			Me.commandBarToggleButtonUnderline.Image = (CType(resources.GetObject("commandBarToggleButtonUnderline.Image"), System.Drawing.Image))
			Me.commandBarToggleButtonUnderline.Name = "commandBarToggleButtonUnderline"
			Me.commandBarToggleButtonUnderline.Text = "commandBarToggleButton3"
			' 
			' radRichTextEditor1
			' 
			Me.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radRichTextEditor1.Location = New System.Drawing.Point(0, 30)
			Me.radRichTextEditor1.Name = "radRichTextEditor1"
			Me.radRichTextEditor1.Size = New System.Drawing.Size(725, 496)
			Me.radRichTextEditor1.TabIndex = 1
			Me.radRichTextEditor1.Text = "radRichTextEditor1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(725, 526)
			Me.Controls.Add(Me.radRichTextEditor1)
			Me.Controls.Add(Me.radCommandBar1)
			Me.Name = "Form1"
			' 
			' 
			' 
            Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Document API"
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
		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
		Private WithEvents commandBarToggleButtonBold As Telerik.WinControls.UI.CommandBarToggleButton
		Private WithEvents commandBarToggleButtonItalic As Telerik.WinControls.UI.CommandBarToggleButton
		Private WithEvents commandBarToggleButtonUnderline As Telerik.WinControls.UI.CommandBarToggleButton
	End Class
End Namespace