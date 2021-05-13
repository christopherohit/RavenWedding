namespace RichTextEditor.SyntaxHighlight
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarToggleButton1 = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.radRichTextEditor1 = new Telerik.WinControls.UI.RadRichTextEditor();
            this.commandBarDropDownList1 = new Telerik.WinControls.UI.CommandBarDropDownList();
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
            this.radCommandBar1.Size = new System.Drawing.Size(839, 55);
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
            this.commandBarDropDownList1,
            this.commandBarToggleButton1});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.StretchHorizontally = true;
            // 
            // commandBarToggleButton1
            // 
            this.commandBarToggleButton1.AccessibleDescription = "commandBarToggleButton1";
            this.commandBarToggleButton1.AccessibleName = "commandBarToggleButton1";
            this.commandBarToggleButton1.DisplayName = "commandBarToggleButton1";
            this.commandBarToggleButton1.Image = ((System.Drawing.Image)(resources.GetObject("commandBarToggleButton1.Image")));
            this.commandBarToggleButton1.MinSize = new System.Drawing.Size(50, 0);
            this.commandBarToggleButton1.Name = "commandBarToggleButton1";
            this.commandBarToggleButton1.Text = "commandBarToggleButton1";
            this.commandBarToggleButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ToggleFormattingSymbols_Click);
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRichTextEditor1.IsReadOnly = true;
            this.radRichTextEditor1.Location = new System.Drawing.Point(0, 55);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            this.radRichTextEditor1.Size = new System.Drawing.Size(839, 558);
            this.radRichTextEditor1.TabIndex = 1;
            this.radRichTextEditor1.Text = "radRichTextEditor1";
            // 
            // commandBarDropDownList1
            // 
            this.commandBarDropDownList1.DisplayName = "commandBarDropDownList1";
            this.commandBarDropDownList1.DropDownAnimationEnabled = true;
            this.commandBarDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "XAML";
            radListDataItem2.Text = "C#";
            this.commandBarDropDownList1.Items.Add(radListDataItem1);
            this.commandBarDropDownList1.Items.Add(radListDataItem2);
            this.commandBarDropDownList1.MaxDropDownItems = 0;
            this.commandBarDropDownList1.Name = "commandBarDropDownList1";
            this.commandBarDropDownList1.Text = "";
            this.commandBarDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.commandBarDropDownList1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 613);
            this.Controls.Add(this.radRichTextEditor1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Syntax Highlight";
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
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleButton1;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;
        private Telerik.WinControls.UI.CommandBarDropDownList commandBarDropDownList1;
    }
}