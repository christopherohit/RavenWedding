namespace RichTextEditor.DocumentAPI
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
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarToggleButtonBold = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarToggleButtonItalic = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarToggleButtonUnderline = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.radRichTextEditor1 = new Telerik.WinControls.UI.RadRichTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(725, 55);
            this.radCommandBar1.TabIndex = 0;
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Name = "commandBarRowElement1";
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarToggleButtonBold,
            this.commandBarToggleButtonItalic,
            this.commandBarToggleButtonUnderline});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            // 
            // commandBarToggleButtonBold
            // 
            this.commandBarToggleButtonBold.DisplayName = "commandBarToggleButton1";
            this.commandBarToggleButtonBold.Image = ((System.Drawing.Image)(resources.GetObject("commandBarToggleButtonBold.Image")));
            this.commandBarToggleButtonBold.Name = "commandBarToggleButtonBold";
            this.commandBarToggleButtonBold.Text = "commandBarToggleButton1";
            this.commandBarToggleButtonBold.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.BoldButton_ToggleStateChanged);
            // 
            // commandBarToggleButtonItalic
            // 
            this.commandBarToggleButtonItalic.DisplayName = "commandBarToggleButton2";
            this.commandBarToggleButtonItalic.Image = ((System.Drawing.Image)(resources.GetObject("commandBarToggleButtonItalic.Image")));
            this.commandBarToggleButtonItalic.Name = "commandBarToggleButtonItalic";
            this.commandBarToggleButtonItalic.Text = "commandBarToggleButton2";
            this.commandBarToggleButtonItalic.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ItalicButton_ToggleStateChanged);
            // 
            // commandBarToggleButtonUnderline
            // 
            this.commandBarToggleButtonUnderline.DisplayName = "commandBarToggleButton3";
            this.commandBarToggleButtonUnderline.Image = ((System.Drawing.Image)(resources.GetObject("commandBarToggleButtonUnderline.Image")));
            this.commandBarToggleButtonUnderline.Name = "commandBarToggleButtonUnderline";
            this.commandBarToggleButtonUnderline.Text = "commandBarToggleButton3";
            this.commandBarToggleButtonUnderline.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.UnderlineButton_ToggleStateChanged);
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRichTextEditor1.Location = new System.Drawing.Point(0, 55);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            this.radRichTextEditor1.Size = new System.Drawing.Size(725, 471);
            this.radRichTextEditor1.TabIndex = 1;
            this.radRichTextEditor1.Text = "radRichTextEditor1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 526);
            this.Controls.Add(this.radRichTextEditor1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Document API";
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleButtonBold;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleButtonItalic;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleButtonUnderline;
    }
}