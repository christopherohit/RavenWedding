Imports Microsoft.VisualBasic
Imports System
Namespace RichTextEditor.FirstLook
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
            Me.richTextEditorRibbonBar1 = New Telerik.WinControls.UI.RichTextEditorRibbonBar()
            Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
            Me.documentRuler1 = New Telerik.WinControls.UI.RadRichTextEditorRuler()
            CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentRuler1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.documentRuler1.SuspendLayout()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richTextEditorRibbonBar1
            ' 
            Me.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
            Me.richTextEditorRibbonBar1.AssociatedRichTextEditor = Me.radRichTextEditor1
            Me.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013
            Me.richTextEditorRibbonBar1.Location = New System.Drawing.Point(0, 0)
            Me.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1"
            Me.richTextEditorRibbonBar1.Size = New System.Drawing.Size(1139, 168)
            Me.richTextEditorRibbonBar1.TabIndex = 0
            Me.richTextEditorRibbonBar1.TabStop = False
            Me.richTextEditorRibbonBar1.Text = "Drag Drop"
            ' 
            ' radRichTextEditor1
            ' 
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
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1139, 796)
            Me.Controls.Add(Me.documentRuler1)
            Me.Controls.Add(Me.richTextEditorRibbonBar1)
            Me.Name = "Form1"
            ' 
            ' 
            ' 
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "First Look"
            CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentRuler1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.documentRuler1.ResumeLayout(False)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private richTextEditorRibbonBar1 As Telerik.WinControls.UI.RichTextEditorRibbonBar
		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
		Private documentRuler1 As Telerik.WinControls.UI.RadRichTextEditorRuler
	End Class
End Namespace

