Imports Microsoft.VisualBasic
Imports System
Namespace RichTextEditor.MailMerge
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
            Me.radPanelBelowRibbon = New Telerik.WinControls.UI.RadPanel()
            Me.radListView1 = New Telerik.WinControls.UI.RadListView()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.listViewPanel = New Telerik.WinControls.UI.RadPanel()
            Me.radPanelBetweenControls = New Telerik.WinControls.UI.RadPanel()
            CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanelBelowRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.listViewPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.listViewPanel.SuspendLayout()
            CType(Me.radPanelBetweenControls, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richTextEditorRibbonBar1
            ' 
            Me.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
            Me.richTextEditorRibbonBar1.AssociatedRichTextEditor = Me.radRichTextEditor1
            Me.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013
            Me.richTextEditorRibbonBar1.Location = New System.Drawing.Point(0, 0)
            Me.richTextEditorRibbonBar1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
            Me.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1"
            Me.richTextEditorRibbonBar1.Size = New System.Drawing.Size(874, 165)
            Me.richTextEditorRibbonBar1.TabIndex = 0
            Me.richTextEditorRibbonBar1.TabStop = False
            Me.richTextEditorRibbonBar1.Text = "Mail Merge"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0), Telerik.WinControls.UI.RadRibbonBarElement).Text = "Mail Merge"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).IsSelected = True
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Home"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Insert"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Page Layout"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "References"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(5), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Review"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(5), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(6), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "View"
            CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(6), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            ' 
            ' radRichTextEditor1
            ' 
            Me.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radRichTextEditor1.Location = New System.Drawing.Point(222, 188)
            Me.radRichTextEditor1.Name = "radRichTextEditor1"
            Me.radRichTextEditor1.Size = New System.Drawing.Size(652, 382)
            Me.radRichTextEditor1.TabIndex = 1
            Me.radRichTextEditor1.Text = "radRichTextEditor1"
            ' 
            ' radPanelBelowRibbon
            ' 
            Me.radPanelBelowRibbon.Dock = System.Windows.Forms.DockStyle.Top
            Me.radPanelBelowRibbon.Location = New System.Drawing.Point(0, 165)
            Me.radPanelBelowRibbon.Name = "radPanelBelowRibbon"
            Me.radPanelBelowRibbon.Size = New System.Drawing.Size(874, 23)
            Me.radPanelBelowRibbon.TabIndex = 0
            CType(Me.radPanelBelowRibbon.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            ' 
            ' radListView1
            ' 
            Me.radListView1.AllowEdit = False
            Me.radListView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radListView1.FullRowSelect = False
            Me.radListView1.ItemSize = New System.Drawing.Size(90, 100)
            Me.radListView1.Location = New System.Drawing.Point(0, 18)
            Me.radListView1.Name = "radListView1"
            Me.radListView1.SelectLastAddedItem = False
            Me.radListView1.Size = New System.Drawing.Size(200, 364)
            Me.radListView1.TabIndex = 1
            Me.radListView1.Text = "radListView1"
            Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(49))))), (CInt(Fix((CByte(155))))), (CInt(Fix((CByte(71))))))
            Me.radLabel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radLabel1.Location = New System.Drawing.Point(0, 0)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(200, 18)
            Me.radLabel1.TabIndex = 0
            Me.radLabel1.Text = "Recepients"
            CType(Me.radLabel1.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Recepients"
            CType(Me.radLabel1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = System.Drawing.ContentAlignment.TopLeft
            CType(Me.radLabel1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(207))))))
            ' 
            ' listViewPanel
            ' 
            Me.listViewPanel.AutoSize = True
            Me.listViewPanel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(49))))), (CInt(Fix((CByte(155))))), (CInt(Fix((CByte(71))))))
            Me.listViewPanel.Controls.Add(Me.radListView1)
            Me.listViewPanel.Controls.Add(Me.radLabel1)
            Me.listViewPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.listViewPanel.Location = New System.Drawing.Point(0, 188)
            Me.listViewPanel.Name = "listViewPanel"
            Me.listViewPanel.Size = New System.Drawing.Size(200, 382)
            Me.listViewPanel.TabIndex = 0
            Me.listViewPanel.Text = "radPanel2"
            ' 
            ' radPanelBetweenControls
            ' 
            Me.radPanelBetweenControls.Dock = System.Windows.Forms.DockStyle.Left
            Me.radPanelBetweenControls.Location = New System.Drawing.Point(200, 188)
            Me.radPanelBetweenControls.Name = "radPanelBetweenControls"
            Me.radPanelBetweenControls.Size = New System.Drawing.Size(22, 382)
            Me.radPanelBetweenControls.TabIndex = 0
            CType(Me.radPanelBetweenControls.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            ' 
            ' Form1
            ' 
            Me.AllowAero = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(874, 570)
            Me.Controls.Add(Me.radRichTextEditor1)
            Me.Controls.Add(Me.radPanelBetweenControls)
            Me.Controls.Add(Me.listViewPanel)
            Me.Controls.Add(Me.radPanelBelowRibbon)
            Me.Controls.Add(Me.richTextEditorRibbonBar1)
            Me.Name = "Form1"
            ' 
            ' 
            ' 
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Mail Merge"
            CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanelBelowRibbon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.listViewPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.listViewPanel.ResumeLayout(False)
            Me.listViewPanel.PerformLayout()
            CType(Me.radPanelBetweenControls, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private richTextEditorRibbonBar1 As Telerik.WinControls.UI.RichTextEditorRibbonBar
		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
		Private radPanelBelowRibbon As Telerik.WinControls.UI.RadPanel
		Private listViewPanel As Telerik.WinControls.UI.RadPanel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private WithEvents radListView1 As Telerik.WinControls.UI.RadListView
		Private radPanelBetweenControls As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace