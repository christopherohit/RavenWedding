Namespace Telerik.Examples.WinControls.RichTextEditor.SectionColumns
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
			Me.richTextEditorRibbonBar1 = New Telerik.WinControls.UI.RichTextEditorRibbonBar()
			Me.radRichTextEditorRuler1 = New Telerik.WinControls.UI.RadRichTextEditorRuler()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRichTextEditorRuler1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radRichTextEditorRuler1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' radRichTextEditor1
			' 
			Me.radRichTextEditor1.Location = New Point(29, 29)
			Me.radRichTextEditor1.Name = "radRichTextEditor1"
			Me.radRichTextEditor1.Size = New Size(1472, 785)
			Me.radRichTextEditor1.TabIndex = 0
			' 
			' richTextEditorRibbonBar1
			' 
			Me.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
			Me.richTextEditorRibbonBar1.AssociatedRichTextEditor = Me.radRichTextEditor1
			Me.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013
			' 
			' 
			' 
			Me.richTextEditorRibbonBar1.ExitButton.Text = "Exit"
			Me.richTextEditorRibbonBar1.Location = New Point(0, 0)
			Me.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1"
			' 
			' 
			' 
			Me.richTextEditorRibbonBar1.OptionsButton.Text = "Options"
			Me.richTextEditorRibbonBar1.Size = New Size(1502, 174)
			Me.richTextEditorRibbonBar1.TabIndex = 1
			Me.richTextEditorRibbonBar1.TabStop = False
			Me.richTextEditorRibbonBar1.Text = "richTextEditorRibbonBar1"
			' 
			' radRichTextEditorRuler1
			' 
			Me.radRichTextEditorRuler1.AssociatedRichTextBox = Me.radRichTextEditor1
			Me.radRichTextEditorRuler1.Controls.Add(Me.radRichTextEditor1)
			Me.radRichTextEditorRuler1.Dock = DockStyle.Fill
			Me.radRichTextEditorRuler1.Location = New Point(0, 174)
			Me.radRichTextEditorRuler1.Name = "radRichTextEditorRuler1"
			Me.radRichTextEditorRuler1.Size = New Size(1502, 815)
			Me.radRichTextEditorRuler1.TabIndex = 2
			Me.radRichTextEditorRuler1.Text = "radRichTextEditorRuler1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radRichTextEditorRuler1)
			Me.Controls.Add(Me.richTextEditorRibbonBar1)
			Me.Name = "Form1"
			Me.Size = New Size(1512, 999)
			Me.Controls.SetChildIndex(Me.richTextEditorRibbonBar1, 0)
			Me.Controls.SetChildIndex(Me.radRichTextEditorRuler1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRichTextEditorRuler1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radRichTextEditorRuler1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
		Private richTextEditorRibbonBar1 As Telerik.WinControls.UI.RichTextEditorRibbonBar
		Private radRichTextEditorRuler1 As Telerik.WinControls.UI.RadRichTextEditorRuler
	End Class
End Namespace