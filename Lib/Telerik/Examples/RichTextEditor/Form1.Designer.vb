
Namespace RichTextEditor
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

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richTextEditorRibbonBar1 = New RichTextEditorRibbonUI.RichTextEditorRibbonBar()
			Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
			Me.documentRuler1 = New Telerik.WinControls.UI.DocumentRuler()
			DirectCast(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.documentRuler1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentRuler1.SuspendLayout()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richTextEditorRibbonBar1
			' 
			Me.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
			Me.richTextEditorRibbonBar1.AssociatedRichTextEditor = Me.radRichTextEditor1
			Me.richTextEditorRibbonBar1.Location = New System.Drawing.Point(0, 0)
			Me.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1"
			Me.richTextEditorRibbonBar1.Size = New System.Drawing.Size(1139, 168)
			Me.richTextEditorRibbonBar1.TabIndex = 0
			Me.richTextEditorRibbonBar1.Text = "Telerik RichTextEditor"
			' 
			' radRichTextEditor1
			' 
			Me.radRichTextEditor1.CaretColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(0)), CInt(CByte(0)))
			Me.radRichTextEditor1.Location = New System.Drawing.Point(29, 29)
			Me.radRichTextEditor1.Name = "radRichTextEditor1"
			Me.radRichTextEditor1.Size = New System.Drawing.Size(1109, 598)
			Me.radRichTextEditor1.TabIndex = 0
			Me.radRichTextEditor1.Text = "radRichTextEditor1"
			' 
			' documentRuler1
			' 
			Me.documentRuler1.AssociatedRichTextBox = Me.radRichTextEditor1
			Me.documentRuler1.Controls.Add(Me.radRichTextEditor1)
			Me.documentRuler1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.documentRuler1.Location = New System.Drawing.Point(0, 168)
			Me.documentRuler1.Name = "documentRuler1"
			Me.documentRuler1.Size = New System.Drawing.Size(1139, 628)
			Me.documentRuler1.TabIndex = 1
			Me.documentRuler1.Text = "documentRuler1"
			' 
			' Form1
			' 
			Me.AllowAero = False
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1139, 796)
			Me.Controls.Add(Me.documentRuler1)
			Me.Controls.Add(Me.richTextEditorRibbonBar1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Form1"
			DirectCast(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.documentRuler1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentRuler1.ResumeLayout(False)
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		Private richTextEditorRibbonBar1 As RichTextEditorRibbonUI.RichTextEditorRibbonBar
		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
		Private documentRuler1 As Telerik.WinControls.UI.DocumentRuler
	End Class
End Namespace
