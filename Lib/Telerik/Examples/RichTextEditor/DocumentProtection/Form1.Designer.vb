Imports Microsoft.VisualBasic
Imports System
Namespace RichTextEditor.DocumentProtection
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
			CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.richTextEditorRibbonBar1.Size = New System.Drawing.Size(891, 165)
			Me.richTextEditorRibbonBar1.TabIndex = 0
			Me.richTextEditorRibbonBar1.TabStop = False
			Me.richTextEditorRibbonBar1.Text = "Document Protection"
			CType(Me.richTextEditorRibbonBar1.GetChildAt(0), Telerik.WinControls.UI.RadRibbonBarElement).Text = "Document Protection"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).IsSelected = True
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Home"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Insert"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Page Layout"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "References"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Mailings"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(6), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "View"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(6), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			' 
			' radRichTextEditor1
			' 
			Me.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radRichTextEditor1.Location = New System.Drawing.Point(0, 165)
			Me.radRichTextEditor1.Name = "radRichTextEditor1"
			Me.radRichTextEditor1.Size = New System.Drawing.Size(891, 561)
			Me.radRichTextEditor1.TabIndex = 1
			Me.radRichTextEditor1.Text = "radRichTextEditor1"
			' 
			' Form1
			' 
			Me.AllowAero = False
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(891, 726)
			Me.Controls.Add(Me.radRichTextEditor1)
			Me.Controls.Add(Me.richTextEditorRibbonBar1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Document Protection"
			CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

        Private richTextEditorRibbonBar1 As Telerik.WinControls.UI.RichTextEditorRibbonBar
		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
	End Class
End Namespace