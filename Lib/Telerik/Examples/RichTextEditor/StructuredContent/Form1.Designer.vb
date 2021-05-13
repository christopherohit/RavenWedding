Imports Microsoft.VisualBasic
Imports System
Namespace RichTextEditor.StructuredContent
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
			Me.radPageViewRecipes = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radListControl1 = New Telerik.WinControls.UI.RadListControl()
			Me.radPageViewMain = New Telerik.WinControls.UI.RadPageView()
			Me.pageViewPageRecipe = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.pageViewPageHTML = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.pageViewPagePreview = New Telerik.WinControls.UI.RadPageViewPage()
			Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
            Me.richTextEditorRibbonBar1 = New Telerik.WinControls.UI.RichTextEditorRibbonBar()
			CType(Me.radPageViewRecipes, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewRecipes.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewMain.SuspendLayout()
			Me.pageViewPageRecipe.SuspendLayout()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pageViewPageHTML.SuspendLayout()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pageViewPagePreview.SuspendLayout()
			CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPageViewRecipes
			' 
			Me.radPageViewRecipes.Controls.Add(Me.radPageViewPage1)
			Me.radPageViewRecipes.Dock = System.Windows.Forms.DockStyle.Left
			Me.radPageViewRecipes.ItemSizeMode = (CType((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth Or Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight), Telerik.WinControls.UI.PageViewItemSizeMode))
			Me.radPageViewRecipes.Location = New System.Drawing.Point(0, 168)
			Me.radPageViewRecipes.Name = "radPageViewRecipes"
			Me.radPageViewRecipes.SelectedPage = Me.radPageViewPage1
			Me.radPageViewRecipes.Size = New System.Drawing.Size(182, 520)
			Me.radPageViewRecipes.TabIndex = 3
			Me.radPageViewRecipes.Text = "Recipes"
			Me.radPageViewRecipes.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack
			CType(Me.radPageViewRecipes.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStackElement).StackPosition = Telerik.WinControls.UI.StackViewPosition.Top
			CType(Me.radPageViewRecipes.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStackElement).ItemSizeMode = (CType((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth Or Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight), Telerik.WinControls.UI.PageViewItemSizeMode))
			CType(Me.radPageViewRecipes.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewLabelElement).Text = "Recipes"
			CType(Me.radPageViewRecipes.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewLabelElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radListControl1)
			Me.radPageViewPage1.ItemSize = New System.Drawing.SizeF(182F, 32F)
			Me.radPageViewPage1.Location = New System.Drawing.Point(5, 35)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New System.Drawing.Size(172, 480)
			Me.radPageViewPage1.Text = "Recipes"
			' 
			' radListControl1
			' 
			Me.radListControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radListControl1.Location = New System.Drawing.Point(0, 0)
			Me.radListControl1.Name = "radListControl1"
			Me.radListControl1.Size = New System.Drawing.Size(172, 480)
			Me.radListControl1.TabIndex = 0
			Me.radListControl1.Text = "radListControl1"
			' 
			' radPageViewMain
			' 
			Me.radPageViewMain.Controls.Add(Me.pageViewPageRecipe)
			Me.radPageViewMain.Controls.Add(Me.pageViewPageHTML)
			Me.radPageViewMain.Controls.Add(Me.pageViewPagePreview)
			Me.radPageViewMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPageViewMain.Location = New System.Drawing.Point(182, 168)
			Me.radPageViewMain.Name = "radPageViewMain"
			Me.radPageViewMain.Padding = New System.Windows.Forms.Padding(5)
			Me.radPageViewMain.SelectedPage = Me.pageViewPageRecipe
			Me.radPageViewMain.Size = New System.Drawing.Size(960, 520)
			Me.radPageViewMain.TabIndex = 4
			Me.radPageViewMain.Text = "radPageView2"
			' 
			' pageViewPageRecipe
			' 
			Me.pageViewPageRecipe.BackColor = System.Drawing.Color.White
			Me.pageViewPageRecipe.Controls.Add(Me.radRichTextEditor1)
			Me.pageViewPageRecipe.Controls.Add(Me.radPanel1)
			Me.pageViewPageRecipe.ItemSize = New System.Drawing.SizeF(49F, 28F)
			Me.pageViewPageRecipe.Location = New System.Drawing.Point(10, 37)
			Me.pageViewPageRecipe.Name = "pageViewPageRecipe"
			Me.pageViewPageRecipe.Padding = New System.Windows.Forms.Padding(10)
			Me.pageViewPageRecipe.Size = New System.Drawing.Size(940, 473)
			Me.pageViewPageRecipe.Text = "Recipe"
			' 
			' radRichTextEditor1
			' 
			Me.radRichTextEditor1.BorderColor = System.Drawing.Color.White
			Me.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radRichTextEditor1.Location = New System.Drawing.Point(448, 10)
			Me.radRichTextEditor1.Name = "radRichTextEditor1"
			Me.radRichTextEditor1.Size = New System.Drawing.Size(482, 428)
			Me.radRichTextEditor1.TabIndex = 1
			Me.radRichTextEditor1.Text = "radRichTextEditor1"
			' 
			' radPanel1
			' 
			Me.radPanel1.BackgroundImage = (CType(resources.GetObject("radPanel1.BackgroundImage"), System.Drawing.Image))
			Me.radPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Left
			Me.radPanel1.Location = New System.Drawing.Point(10, 10)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New System.Drawing.Size(438, 453)
			Me.radPanel1.TabIndex = 0
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = ""
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' pageViewPageHTML
			' 
			Me.pageViewPageHTML.Controls.Add(Me.radTextBox1)
			Me.pageViewPageHTML.ItemSize = New System.Drawing.SizeF(46F, 28F)
			Me.pageViewPageHTML.Location = New System.Drawing.Point(10, 37)
			Me.pageViewPageHTML.Name = "pageViewPageHTML"
			Me.pageViewPageHTML.Size = New System.Drawing.Size(939, 472)
			Me.pageViewPageHTML.Text = "HTML"
			' 
			' radTextBox1
			' 
			Me.radTextBox1.AcceptsReturn = True
			Me.radTextBox1.AcceptsTab = True
			Me.radTextBox1.AutoSize = False
			Me.radTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radTextBox1.Location = New System.Drawing.Point(0, 0)
			Me.radTextBox1.Multiline = True
			Me.radTextBox1.Name = "radTextBox1"
			Me.radTextBox1.ReadOnly = True
			Me.radTextBox1.Size = New System.Drawing.Size(939, 472)
			Me.radTextBox1.TabIndex = 0
			' 
			' pageViewPagePreview
			' 
			Me.pageViewPagePreview.Controls.Add(Me.webBrowser1)
			Me.pageViewPagePreview.ItemSize = New System.Drawing.SizeF(55F, 28F)
			Me.pageViewPagePreview.Location = New System.Drawing.Point(10, 37)
			Me.pageViewPagePreview.Name = "pageViewPagePreview"
			Me.pageViewPagePreview.Size = New System.Drawing.Size(941, 520)
			Me.pageViewPagePreview.Text = "Preview"
			' 
			' webBrowser1
			' 
			Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.webBrowser1.Location = New System.Drawing.Point(0, 0)
			Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
			Me.webBrowser1.Name = "webBrowser1"
			Me.webBrowser1.Size = New System.Drawing.Size(941, 520)
			Me.webBrowser1.TabIndex = 0
			' 
			' richTextEditorRibbonBar1
			' 
			Me.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
			Me.richTextEditorRibbonBar1.AssociatedRichTextEditor = Me.radRichTextEditor1
			Me.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013
			Me.richTextEditorRibbonBar1.Location = New System.Drawing.Point(0, 0)
			Me.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1"
			Me.richTextEditorRibbonBar1.Size = New System.Drawing.Size(1142, 168)
			Me.richTextEditorRibbonBar1.TabIndex = 0
			Me.richTextEditorRibbonBar1.TabStop = False
			Me.richTextEditorRibbonBar1.Text = "Structured Content"
			' 
			' Form1
			' 
			Me.AllowAero = False
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1142, 688)
			Me.Controls.Add(Me.radPageViewMain)
			Me.Controls.Add(Me.radPageViewRecipes)
			Me.Controls.Add(Me.richTextEditorRibbonBar1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Structured Content"
			CType(Me.radPageViewRecipes, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewRecipes.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageViewMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewMain.ResumeLayout(False)
			Me.pageViewPageRecipe.ResumeLayout(False)
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pageViewPageHTML.ResumeLayout(False)
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pageViewPagePreview.ResumeLayout(False)
			CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

        Private richTextEditorRibbonBar1 As Telerik.WinControls.UI.RichTextEditorRibbonBar
		Private radPageViewRecipes As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radListControl1 As Telerik.WinControls.UI.RadListControl
		Private radPageViewMain As Telerik.WinControls.UI.RadPageView
		Private pageViewPageRecipe As Telerik.WinControls.UI.RadPageViewPage
		Private pageViewPageHTML As Telerik.WinControls.UI.RadPageViewPage
		Private pageViewPagePreview As Telerik.WinControls.UI.RadPageViewPage
		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private webBrowser1 As System.Windows.Forms.WebBrowser
	End Class
End Namespace