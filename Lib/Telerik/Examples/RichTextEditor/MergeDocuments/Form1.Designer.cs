namespace RichTextEditor.MergeDocuments
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
            this.commandBarDropDownButton1 = new Telerik.WinControls.UI.CommandBarDropDownButton();
            this.browseMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.loadDocument1 = new Telerik.WinControls.UI.RadMenuItem();
            this.loadDocument2 = new Telerik.WinControls.UI.RadMenuItem();
            this.commandBarButtonClear = new Telerik.WinControls.UI.CommandBarButton();
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
            this.radCommandBar1.Size = new System.Drawing.Size(743, 40);
            this.radCommandBar1.TabIndex = 0;
            this.radCommandBar1.Text = "radCommandBar1";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarDropDownButton1,
            this.commandBarButtonClear});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.StretchHorizontally = true;
            // 
            // commandBarDropDownButton1
            // 
            this.commandBarDropDownButton1.AccessibleDescription = "Insert Document";
            this.commandBarDropDownButton1.AccessibleName = "Insert Document";
            this.commandBarDropDownButton1.DisplayName = "commandBarDropDownButton1";
            this.commandBarDropDownButton1.DrawText = true;
            this.commandBarDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("commandBarDropDownButton1.Image")));
            this.commandBarDropDownButton1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.browseMenuItem,
            this.loadDocument1,
            this.loadDocument2});
            this.commandBarDropDownButton1.Name = "commandBarDropDownButton1";
            this.commandBarDropDownButton1.Text = "Insert Document";
            this.commandBarDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // browseMenuItem
            // 
            this.browseMenuItem.AccessibleDescription = "Browse for document";
            this.browseMenuItem.AccessibleName = "Browse for document";
            this.browseMenuItem.Name = "browseMenuItem";
            this.browseMenuItem.Text = "Browse for document";
            this.browseMenuItem.Click += new System.EventHandler(this.browseMenuItem_Click);
            // 
            // loadDocument1
            // 
            this.loadDocument1.AccessibleDescription = "Load predefined documen1";
            this.loadDocument1.AccessibleName = "Load predefined document 1";
            this.loadDocument1.Name = "loadDocument1";
            this.loadDocument1.Text = "Load predefined document 1";
            this.loadDocument1.Click += new System.EventHandler(this.loadDocument1_Click);
            // 
            // loadDocument2
            // 
            this.loadDocument2.AccessibleDescription = "Load predefined documen2";
            this.loadDocument2.AccessibleName = "Load predefined document 2";
            this.loadDocument2.Name = "loadDocument2";
            this.loadDocument2.Text = "Load predefined document 2";
            this.loadDocument2.Click += new System.EventHandler(this.loadDocument2_Click);
            // 
            // commandBarButtonClear
            // 
            this.commandBarButtonClear.AccessibleDescription = "Clear";
            this.commandBarButtonClear.AccessibleName = "Clear";
            this.commandBarButtonClear.DisplayName = "commandBarButton1";
            this.commandBarButtonClear.DrawText = true;
            this.commandBarButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButtonClear.Image")));
            this.commandBarButtonClear.Name = "commandBarButtonClear";
            this.commandBarButtonClear.Text = "Clear";
            this.commandBarButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButtonClear.Click += new System.EventHandler(this.clearDocument_Click);
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRichTextEditor1.Location = new System.Drawing.Point(0, 40);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            this.radRichTextEditor1.Size = new System.Drawing.Size(743, 528);
            this.radRichTextEditor1.TabIndex = 1;
            this.radRichTextEditor1.Text = "radRichTextEditor1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 568);
            this.Controls.Add(this.radRichTextEditor1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Merge Documents";
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
        private Telerik.WinControls.UI.CommandBarButton commandBarButtonClear;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;
        private Telerik.WinControls.UI.CommandBarDropDownButton commandBarDropDownButton1;
        private Telerik.WinControls.UI.RadMenuItem browseMenuItem;
        private Telerik.WinControls.UI.RadMenuItem loadDocument1;
        private Telerik.WinControls.UI.RadMenuItem loadDocument2;
    }
}