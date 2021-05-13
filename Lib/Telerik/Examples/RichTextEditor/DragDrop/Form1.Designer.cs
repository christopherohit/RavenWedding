namespace RichTextEditor.DragDrop
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
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 1");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem2 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 2");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem3 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 3");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem4 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 4");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem5 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 5");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem6 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 6");
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radRichTextEditor1 = new Telerik.WinControls.UI.RadRichTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListView1
            // 
            this.radListView1.AllowDragDrop = true;
            this.radListView1.AllowEdit = false;
            this.radListView1.AllowRemove = false;
            this.radListView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radListView1.FullRowSelect = false;
            listViewDataItem1.Text = "Some predefined text";
            listViewDataItem2.Text = "Firstname Lastname";
            listViewDataItem3.Text = "firstname.lastname@telerik.com";
            listViewDataItem4.Text = "Company Name";
            listViewDataItem5.Text = "Signature";
            listViewDataItem6.Text = "Date";
            this.radListView1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem1,
            listViewDataItem2,
            listViewDataItem3,
            listViewDataItem4,
            listViewDataItem5,
            listViewDataItem6});
            this.radListView1.ItemSize = new System.Drawing.Size(185, 64);
            this.radListView1.ItemSpacing = 5;
            this.radListView1.Location = new System.Drawing.Point(0, 0);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(198, 587);
            this.radListView1.TabIndex = 1;
            this.radListView1.Text = "radListView1";
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            ((Telerik.WinControls.UI.IconListViewElement)(this.radListView1.GetChildAt(0).GetChildAt(0))).ItemSize = new System.Drawing.Size(185, 64);
            ((Telerik.WinControls.UI.IconListViewElement)(this.radListView1.GetChildAt(0).GetChildAt(0))).Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radSeparator1.Location = new System.Drawing.Point(198, 0);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator1.Size = new System.Drawing.Size(16, 587);
            this.radSeparator1.TabIndex = 2;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRichTextEditor1.LayoutMode = Telerik.WinForms.Documents.Model.DocumentLayoutMode.Paged;
            this.radRichTextEditor1.Location = new System.Drawing.Point(214, 0);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            this.radRichTextEditor1.Size = new System.Drawing.Size(888, 587);
            this.radRichTextEditor1.TabIndex = 3;
            this.radRichTextEditor1.Text = "radRichTextEditor1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 587);
            this.Controls.Add(this.radRichTextEditor1);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.radListView1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Drag Drop";
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;

    }
}