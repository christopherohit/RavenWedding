namespace RichTextEditor.SearchHighlight
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
            this.commandBarTextBox1 = new Telerik.WinControls.UI.CommandBarTextBox();
            this.toggleButtonSearchResults = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.toggleButtonCurrentWord = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.toggleButtonCurrentLine = new Telerik.WinControls.UI.CommandBarToggleButton();
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
            this.radCommandBar1.Size = new System.Drawing.Size(1157, 30);
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
            this.commandBarTextBox1,
            this.toggleButtonSearchResults,
            this.toggleButtonCurrentWord,
            this.toggleButtonCurrentLine});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.StretchHorizontally = true;
            // 
            // commandBarTextBox1
            // 
            this.commandBarTextBox1.DisplayName = "commandBarTextBox1";
            this.commandBarTextBox1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.commandBarTextBox1.MinSize = new System.Drawing.Size(170, 0);
            this.commandBarTextBox1.Name = "commandBarTextBox1";
            this.commandBarTextBox1.NullText = "Find in document";
            this.commandBarTextBox1.Text = "";
            this.commandBarTextBox1.TextChanged += new System.EventHandler(this.textToSearch_TextChanged);
            // 
            // toggleButtonSearchResults
            // 
            this.toggleButtonSearchResults.AccessibleDescription = "Highlight Results";
            this.toggleButtonSearchResults.AccessibleName = "Highlight Results";
            this.toggleButtonSearchResults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButtonSearchResults.DisplayName = "commandBarToggleButton1";
            this.toggleButtonSearchResults.DrawImage = false;
            this.toggleButtonSearchResults.DrawText = true;
            this.toggleButtonSearchResults.Image = ((System.Drawing.Image)(resources.GetObject("toggleButtonSearchResults.Image")));
            this.toggleButtonSearchResults.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toggleButtonSearchResults.Name = "toggleButtonSearchResults";
            this.toggleButtonSearchResults.Text = "Highlight Results";
            this.toggleButtonSearchResults.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.toggleButtonSearchResults.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.toggleButtonSearchResults_ToggleStateChanged);
            // 
            // toggleButtonCurrentWord
            // 
            this.toggleButtonCurrentWord.AccessibleDescription = "Highlight Current Word";
            this.toggleButtonCurrentWord.AccessibleName = "Highlight Current Word";
            this.toggleButtonCurrentWord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButtonCurrentWord.DisplayName = "commandBarToggleButton2";
            this.toggleButtonCurrentWord.DrawImage = false;
            this.toggleButtonCurrentWord.DrawText = true;
            this.toggleButtonCurrentWord.Image = ((System.Drawing.Image)(resources.GetObject("toggleButtonCurrentWord.Image")));
            this.toggleButtonCurrentWord.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toggleButtonCurrentWord.Name = "toggleButtonCurrentWord";
            this.toggleButtonCurrentWord.Text = "Highlight Current Word";
            this.toggleButtonCurrentWord.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.toggleButtonCurrentWord.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.toggleButtonCurrentWord_ToggleStateChanged);
            // 
            // toggleButtonCurrentLine
            // 
            this.toggleButtonCurrentLine.AccessibleDescription = "Highlight Current Line";
            this.toggleButtonCurrentLine.AccessibleName = "Highlight Current Line";
            this.toggleButtonCurrentLine.DisplayName = "commandBarToggleButton3";
            this.toggleButtonCurrentLine.DrawImage = false;
            this.toggleButtonCurrentLine.DrawText = true;
            this.toggleButtonCurrentLine.Image = ((System.Drawing.Image)(resources.GetObject("toggleButtonCurrentLine.Image")));
            this.toggleButtonCurrentLine.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toggleButtonCurrentLine.Name = "toggleButtonCurrentLine";
            this.toggleButtonCurrentLine.Tag = "1";
            this.toggleButtonCurrentLine.Text = "Highlight Current Line";
            this.toggleButtonCurrentLine.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.toggleButtonCurrentLine_ToggleStateChanged);
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRichTextEditor1.IsReadOnly = true;
            this.radRichTextEditor1.Location = new System.Drawing.Point(0, 30);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            this.radRichTextEditor1.Size = new System.Drawing.Size(1157, 677);
            this.radRichTextEditor1.TabIndex = 0;
            this.radRichTextEditor1.Text = "radRichTextEditor1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 707);
            this.Controls.Add(this.radRichTextEditor1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Search Highlight";
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
        private Telerik.WinControls.UI.CommandBarTextBox commandBarTextBox1;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonSearchResults;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonCurrentWord;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonCurrentLine;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;
    }
}