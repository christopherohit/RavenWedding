namespace RichTextEditor.FirstLook
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
            this.richTextEditorRibbonBar1 = new Telerik.WinControls.UI.RichTextEditorRibbonBar();
            this.radRichTextEditor1 = new Telerik.WinControls.UI.RadRichTextEditor();
            this.documentRuler1 = new Telerik.WinControls.UI.RadRichTextEditorRuler();
            ((System.ComponentModel.ISupportInitialize)(this.richTextEditorRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRuler1)).BeginInit();
            this.documentRuler1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextEditorRibbonBar1
            // 
            this.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView;
            this.richTextEditorRibbonBar1.AssociatedRichTextEditor = this.radRichTextEditor1;
            this.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013;
            this.richTextEditorRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1";
            this.richTextEditorRibbonBar1.Size = new System.Drawing.Size(1139, 168);
            this.richTextEditorRibbonBar1.TabIndex = 0;
            this.richTextEditorRibbonBar1.TabStop = false;
            this.richTextEditorRibbonBar1.Text = "";
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.Location = new System.Drawing.Point(29, 29);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            this.radRichTextEditor1.Size = new System.Drawing.Size(1109, 598);
            this.radRichTextEditor1.TabIndex = 0;
            this.radRichTextEditor1.Text = "radRichTextEditor1";
            // 
            // documentRuler1
            // 
            this.documentRuler1.AssociatedRichTextBox = this.radRichTextEditor1;
            this.documentRuler1.Controls.Add(this.radRichTextEditor1);
            this.documentRuler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentRuler1.Location = new System.Drawing.Point(0, 168);
            this.documentRuler1.Name = "documentRuler1";
            this.documentRuler1.Size = new System.Drawing.Size(1139, 628);
            this.documentRuler1.TabIndex = 1;
            this.documentRuler1.Text = "documentRuler1";
            // 
            // Form1
            // 
            this.AllowAero = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 796);
            this.Controls.Add(this.documentRuler1);
            this.Controls.Add(this.richTextEditorRibbonBar1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "First Look";
            ((System.ComponentModel.ISupportInitialize)(this.richTextEditorRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRuler1)).EndInit();
            this.documentRuler1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RichTextEditorRibbonBar richTextEditorRibbonBar1;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;
        private Telerik.WinControls.UI.RadRichTextEditorRuler documentRuler1;
    }
}

