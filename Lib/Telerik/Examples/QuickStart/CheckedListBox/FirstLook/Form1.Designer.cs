namespace Telerik.Examples.WinControls.CheckedListBox.FirstLook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 1");
            this.radCheckedListBox1 = new Telerik.WinControls.UI.RadCheckedListBox();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.radOrderButton = new Telerik.WinControls.UI.RadButton();
            this.radClearAllButton = new Telerik.WinControls.UI.RadButton();
            this.radCheckAllButton = new Telerik.WinControls.UI.RadButton();
            this.radCheckSelectedButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radListView2 = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radOrderButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClearAllButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckAllButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckSelectedButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1226, 32);
            // 
            // radCheckedListBox1
            // 
            this.radCheckedListBox1.CheckBoxesAlignment = Telerik.WinControls.UI.CheckBoxesAlignment.Near;
            this.radCheckedListBox1.ItemSize = new System.Drawing.Size(0, 92);
            this.radCheckedListBox1.Location = new System.Drawing.Point(6, 42);
            this.radCheckedListBox1.Margin = new System.Windows.Forms.Padding(5);
            this.radCheckedListBox1.MultiSelect = true;
            this.radCheckedListBox1.Name = "radCheckedListBox1";
            this.radCheckedListBox1.Size = new System.Drawing.Size(370, 420);
            this.radCheckedListBox1.TabIndex = 2;
            this.radCheckedListBox1.Text = "radCheckedListBox1";
            this.radCheckedListBox1.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.radCheckedListBox1_ItemCheckedChanged);
            // 
            // radListView1
            // 
            this.radListView1.AllowEdit = false;
            this.radListView1.ItemSpacing = -1;
            this.radListView1.Location = new System.Drawing.Point(386, 42);
            this.radListView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.radListView1.MultiSelect = true;
            this.radListView1.Name = "radListView1";
            this.radListView1.ShowColumnHeaders = false;
            this.radListView1.ShowGridLines = true;
            this.radListView1.Size = new System.Drawing.Size(193, 212);
            this.radListView1.TabIndex = 3;
            this.radListView1.Text = "radListView1";
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // radOrderButton
            // 
            this.radOrderButton.Location = new System.Drawing.Point(386, 286);
            this.radOrderButton.Margin = new System.Windows.Forms.Padding(5);
            this.radOrderButton.Name = "radOrderButton";
            this.radOrderButton.Size = new System.Drawing.Size(193, 24);
            this.radOrderButton.TabIndex = 5;
            this.radOrderButton.Text = "Finish order";
            this.radOrderButton.Click += new System.EventHandler(this.radOrderButton_Click);
            // 
            // radClearAllButton
            // 
            this.radClearAllButton.Location = new System.Drawing.Point(386, 320);
            this.radClearAllButton.Margin = new System.Windows.Forms.Padding(5);
            this.radClearAllButton.Name = "radClearAllButton";
            this.radClearAllButton.Size = new System.Drawing.Size(193, 24);
            this.radClearAllButton.TabIndex = 6;
            this.radClearAllButton.Text = "Clear all";
            this.radClearAllButton.Click += new System.EventHandler(this.radClearAllButton_Click);
            // 
            // radCheckAllButton
            // 
            this.radCheckAllButton.Location = new System.Drawing.Point(8, 472);
            this.radCheckAllButton.Margin = new System.Windows.Forms.Padding(5);
            this.radCheckAllButton.Name = "radCheckAllButton";
            this.radCheckAllButton.Size = new System.Drawing.Size(126, 24);
            this.radCheckAllButton.TabIndex = 8;
            this.radCheckAllButton.Text = "Check all";
            this.radCheckAllButton.Click += new System.EventHandler(this.radCheckAllButton_Click);
            // 
            // radCheckSelectedButton
            // 
            this.radCheckSelectedButton.Location = new System.Drawing.Point(144, 472);
            this.radCheckSelectedButton.Margin = new System.Windows.Forms.Padding(5);
            this.radCheckSelectedButton.Name = "radCheckSelectedButton";
            this.radCheckSelectedButton.Size = new System.Drawing.Size(126, 24);
            this.radCheckSelectedButton.TabIndex = 9;
            this.radCheckSelectedButton.Text = "Check selected";
            this.radCheckSelectedButton.Click += new System.EventHandler(this.radCheckSelectedButton_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.radLabel2.Location = new System.Drawing.Point(8, 8);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(267, 30);
            this.radLabel2.TabIndex = 11;
            this.radLabel2.Text = "What would you like to order?";
            // 
            // radListView2
            // 
            this.radListView2.AllowEdit = false;
            listViewDataItem1.Key = "{ Total = \"Total:\", Price = $0.00}";
            listViewDataItem1.Tag = "{ Total = \"Total:\", Price = $0.00}";
            listViewDataItem1.Text = "ListViewItem 1";
            this.radListView2.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem1});
            this.radListView2.ItemSize = new System.Drawing.Size(201, 20);
            this.radListView2.ItemSpacing = -1;
            this.radListView2.Location = new System.Drawing.Point(386, 254);
            this.radListView2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.radListView2.Name = "radListView2";
            this.radListView2.ShowColumnHeaders = false;
            this.radListView2.ShowGridLines = true;
            this.radListView2.Size = new System.Drawing.Size(193, 22);
            this.radListView2.TabIndex = 15;
            this.radListView2.Text = "radListView2";
            this.radListView2.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.radListView2.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.radListView2);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radCheckedListBox1);
            this.Controls.Add(this.radCheckSelectedButton);
            this.Controls.Add(this.radCheckAllButton);
            this.Controls.Add(this.radClearAllButton);
            this.Controls.Add(this.radOrderButton);
            this.Controls.Add(this.radListView1);
            this.MinimumSize = new System.Drawing.Size(370, 420);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1540, 1000);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.radListView1, 0);
            this.Controls.SetChildIndex(this.radOrderButton, 0);
            this.Controls.SetChildIndex(this.radClearAllButton, 0);
            this.Controls.SetChildIndex(this.radCheckAllButton, 0);
            this.Controls.SetChildIndex(this.radCheckSelectedButton, 0);
            this.Controls.SetChildIndex(this.radCheckedListBox1, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radListView2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radOrderButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClearAllButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckAllButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckSelectedButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCheckedListBox radCheckedListBox1;
        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadButton radOrderButton;
        private Telerik.WinControls.UI.RadButton radClearAllButton;
        private Telerik.WinControls.UI.RadButton radCheckAllButton;
        private Telerik.WinControls.UI.RadButton radCheckSelectedButton;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadListView radListView2;
    }
}
