namespace RichTextEditor.StructuredContent
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radPageViewRecipes = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.radPageViewMain = new Telerik.WinControls.UI.RadPageView();
            this.pageViewPageRecipe = new Telerik.WinControls.UI.RadPageViewPage();
            this.radRichTextEditor1 = new Telerik.WinControls.UI.RadRichTextEditor();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.pageViewPageHTML = new Telerik.WinControls.UI.RadPageViewPage();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.pageViewPagePreview = new Telerik.WinControls.UI.RadPageViewPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.richTextEditorRibbonBar1 = new Telerik.WinControls.UI.RichTextEditorRibbonBar();
            ((System.ComponentModel.ISupportInitialize)(this.radPageViewRecipes)).BeginInit();
            this.radPageViewRecipes.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageViewMain)).BeginInit();
            this.radPageViewMain.SuspendLayout();
            this.pageViewPageRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.pageViewPageHTML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            this.pageViewPagePreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.richTextEditorRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageViewRecipes
            // 
            this.radPageViewRecipes.Controls.Add(this.radPageViewPage1);
            this.radPageViewRecipes.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPageViewRecipes.ItemSizeMode = ((Telerik.WinControls.UI.PageViewItemSizeMode)((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth | Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight)));
            this.radPageViewRecipes.Location = new System.Drawing.Point(0, 174);
            this.radPageViewRecipes.Name = "radPageViewRecipes";
            this.radPageViewRecipes.SelectedPage = this.radPageViewPage1;
            this.radPageViewRecipes.Size = new System.Drawing.Size(182, 514);
            this.radPageViewRecipes.TabIndex = 3;
            this.radPageViewRecipes.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack;
            ((Telerik.WinControls.UI.RadPageViewStackElement)(this.radPageViewRecipes.GetChildAt(0))).StackPosition = Telerik.WinControls.UI.StackViewPosition.Top;
            ((Telerik.WinControls.UI.RadPageViewStackElement)(this.radPageViewRecipes.GetChildAt(0))).ItemSizeMode = ((Telerik.WinControls.UI.PageViewItemSizeMode)((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth | Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight)));
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageViewRecipes.GetChildAt(0).GetChildAt(1))).Text = "Recipes";
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageViewRecipes.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.radListControl1);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(182F, 32F);
            this.radPageViewPage1.Location = new System.Drawing.Point(5, 35);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(172, 474);
            this.radPageViewPage1.Text = "Recipes";
            // 
            // radListControl1
            // 
            this.radListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListControl1.Location = new System.Drawing.Point(0, 0);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(172, 474);
            this.radListControl1.TabIndex = 0;
            // 
            // radPageViewMain
            // 
            this.radPageViewMain.Controls.Add(this.pageViewPageRecipe);
            this.radPageViewMain.Controls.Add(this.pageViewPageHTML);
            this.radPageViewMain.Controls.Add(this.pageViewPagePreview);
            this.radPageViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageViewMain.Location = new System.Drawing.Point(182, 174);
            this.radPageViewMain.Name = "radPageViewMain";
            this.radPageViewMain.Padding = new System.Windows.Forms.Padding(5);
            this.radPageViewMain.SelectedPage = this.pageViewPageRecipe;
            this.radPageViewMain.Size = new System.Drawing.Size(960, 514);
            this.radPageViewMain.TabIndex = 4;
            // 
            // pageViewPageRecipe
            // 
            this.pageViewPageRecipe.Controls.Add(this.radRichTextEditor1);
            this.pageViewPageRecipe.Controls.Add(this.radPanel1);
            this.pageViewPageRecipe.ItemSize = new System.Drawing.SizeF(49F, 28F);
            this.pageViewPageRecipe.Location = new System.Drawing.Point(10, 37);
            this.pageViewPageRecipe.Name = "pageViewPageRecipe";
            this.pageViewPageRecipe.Padding = new System.Windows.Forms.Padding(10);
            this.pageViewPageRecipe.Size = new System.Drawing.Size(940, 467);
            this.pageViewPageRecipe.Text = "Recipe";
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radRichTextEditor1.Location = new System.Drawing.Point(448, 10);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            this.radRichTextEditor1.Size = new System.Drawing.Size(482, 428);
            this.radRichTextEditor1.TabIndex = 1;
            this.radRichTextEditor1.Text = "radRichTextEditor1";
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.Transparent;
            this.radPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radPanel1.BackgroundImage")));
            this.radPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPanel1.Location = new System.Drawing.Point(10, 10);
            this.radPanel1.Name = "radPanel1";
            // 
            // 
            // 
            this.radPanel1.RootElement.EnableElementShadow = false;
            this.radPanel1.Size = new System.Drawing.Size(438, 447);
            this.radPanel1.TabIndex = 0;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // pageViewPageHTML
            // 
            this.pageViewPageHTML.Controls.Add(this.radTextBox1);
            this.pageViewPageHTML.ItemSize = new System.Drawing.SizeF(46F, 28F);
            this.pageViewPageHTML.Location = new System.Drawing.Point(10, 37);
            this.pageViewPageHTML.Name = "pageViewPageHTML";
            this.pageViewPageHTML.Size = new System.Drawing.Size(940, 467);
            this.pageViewPageHTML.Text = "HTML";
            // 
            // radTextBox1
            // 
            this.radTextBox1.AcceptsReturn = true;
            this.radTextBox1.AcceptsTab = true;
            this.radTextBox1.AutoSize = false;
            this.radTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTextBox1.Location = new System.Drawing.Point(0, 0);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.ReadOnly = true;
            this.radTextBox1.Size = new System.Drawing.Size(940, 467);
            this.radTextBox1.TabIndex = 0;
            // 
            // pageViewPagePreview
            // 
            this.pageViewPagePreview.Controls.Add(this.webBrowser1);
            this.pageViewPagePreview.ItemSize = new System.Drawing.SizeF(55F, 28F);
            this.pageViewPagePreview.Location = new System.Drawing.Point(10, 37);
            this.pageViewPagePreview.Name = "pageViewPagePreview";
            this.pageViewPagePreview.Size = new System.Drawing.Size(940, 467);
            this.pageViewPagePreview.Text = "Preview";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(940, 467);
            this.webBrowser1.TabIndex = 0;
            // 
            // richTextEditorRibbonBar1
            // 
            this.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView;
            this.richTextEditorRibbonBar1.AssociatedRichTextEditor = this.radRichTextEditor1;
            this.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013;
            this.richTextEditorRibbonBar1.EnableKeyMap = false;
            // 
            // 
            // 
            this.richTextEditorRibbonBar1.ExitButton.Text = "Exit";
            this.richTextEditorRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1";
            // 
            // 
            // 
            this.richTextEditorRibbonBar1.OptionsButton.Text = "Options";
            this.richTextEditorRibbonBar1.Size = new System.Drawing.Size(1142, 174);
            this.richTextEditorRibbonBar1.TabIndex = 0;
            this.richTextEditorRibbonBar1.TabStop = false;
            this.richTextEditorRibbonBar1.Text = "Structured Content";
            // 
            // Form1
            // 
            this.AllowAero = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 688);
            this.Controls.Add(this.radPageViewMain);
            this.Controls.Add(this.radPageViewRecipes);
            this.Controls.Add(this.richTextEditorRibbonBar1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Structured Content";
            ((System.ComponentModel.ISupportInitialize)(this.radPageViewRecipes)).EndInit();
            this.radPageViewRecipes.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageViewMain)).EndInit();
            this.radPageViewMain.ResumeLayout(false);
            this.pageViewPageRecipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.pageViewPageHTML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            this.pageViewPagePreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.richTextEditorRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RichTextEditorRibbonBar richTextEditorRibbonBar1;
        private Telerik.WinControls.UI.RadPageView radPageViewRecipes;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Telerik.WinControls.UI.RadPageView radPageViewMain;
        private Telerik.WinControls.UI.RadPageViewPage pageViewPageRecipe;
        private Telerik.WinControls.UI.RadPageViewPage pageViewPageHTML;
        private Telerik.WinControls.UI.RadPageViewPage pageViewPagePreview;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}