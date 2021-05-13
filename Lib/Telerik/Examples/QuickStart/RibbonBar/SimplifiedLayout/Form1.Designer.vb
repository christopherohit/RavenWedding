Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RibbonBar.SimplifiedLayout
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.richTextEditorRibbonBar1 = New Telerik.WinControls.UI.RichTextEditorRibbonBar()
            Me.radRibbonFormBehavior1 = New Telerik.WinControls.UI.RadRibbonFormBehavior()
            Me.radRichTextEditorRuler1 = New Telerik.WinControls.UI.RadRichTextEditorRuler()
            Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
            CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRichTextEditorRuler1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radRichTextEditorRuler1.SuspendLayout()
            CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
            Me.richTextEditorRibbonBar1.AssociatedRichTextEditor = Me.radRichTextEditor1
            Me.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013
            Me.richTextEditorRibbonBar1.EnableKeyMap = False
            Me.richTextEditorRibbonBar1.ExitButton.Text = "Exit"
            Me.richTextEditorRibbonBar1.Location = New System.Drawing.Point(0, 0)
            Me.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1"
            Me.richTextEditorRibbonBar1.OptionsButton.Text = "Options"
            Me.richTextEditorRibbonBar1.ShowLayoutModeButton = True
            Me.richTextEditorRibbonBar1.Size = New System.Drawing.Size(1296, 174)
            Me.richTextEditorRibbonBar1.StartButtonImage = (CType((resources.GetObject("richTextEditorRibbonBar1.StartButtonImage")), System.Drawing.Image))
            Me.richTextEditorRibbonBar1.TabIndex = 0
            Me.richTextEditorRibbonBar1.TabStop = False
            Me.richTextEditorRibbonBar1.Text = "Simplified Layout"
            Me.radRibbonFormBehavior1.Form = Me
            Me.radRichTextEditorRuler1.AssociatedRichTextBox = Me.radRichTextEditor1
            Me.radRichTextEditorRuler1.Controls.Add(Me.radRichTextEditor1)
            Me.radRichTextEditorRuler1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radRichTextEditorRuler1.Location = New System.Drawing.Point(0, 174)
            Me.radRichTextEditorRuler1.Name = "radRichTextEditorRuler1"
            Me.radRichTextEditorRuler1.Size = New System.Drawing.Size(1296, 515)
            Me.radRichTextEditorRuler1.TabIndex = 1
            Me.radRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((156)))))), (CInt(((CByte((189)))))), (CInt(((CByte((232)))))))
            Me.radRichTextEditor1.Location = New System.Drawing.Point(29, 29)
            Me.radRichTextEditor1.Name = "radRichTextEditor1"
            Me.radRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((78)))))), (CInt(((CByte((158)))))), (CInt(((CByte((255)))))))
            Me.radRichTextEditor1.Size = New System.Drawing.Size(1266, 485)
            Me.radRichTextEditor1.TabIndex = 0
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1296, 689)
            Me.Controls.Add(Me.radRichTextEditorRuler1)
            Me.Controls.Add(Me.richTextEditorRibbonBar1)
            Me.FormBehavior = Me.radRibbonFormBehavior1
            Me.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None
            Me.Name = "Form1"
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Simplified Layout"
            CType((Me.richTextEditorRibbonBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radRichTextEditorRuler1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radRichTextEditorRuler1.ResumeLayout(False)
            CType((Me.radRichTextEditor1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private richTextEditorRibbonBar1 As Telerik.WinControls.UI.RichTextEditorRibbonBar
        Private radRibbonFormBehavior1 As Telerik.WinControls.UI.RadRibbonFormBehavior
        Private radRichTextEditorRuler1 As Telerik.WinControls.UI.RadRichTextEditorRuler
        Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
    End Class
End Namespace