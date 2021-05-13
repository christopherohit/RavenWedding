namespace BookShelf
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.upperPanel = new Telerik.WinControls.UI.RadPanel();
            this.bookShelfLabel = new Telerik.WinControls.UI.RadLabel();
            this.logoLabel = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.selectCategoryLabel = new Telerik.WinControls.UI.RadLabel();
            this.searchBtn = new Telerik.WinControls.UI.RadButton();
            this.bottomPanel = new Telerik.WinControls.UI.RadPanel();
            this.showAllItemsButton = new Telerik.WinControls.UI.RadButton();
            this.allCategoriesBtn = new BookShelf.Custom_Elements.ImageButton();
            this.homeBtn = new BookShelf.Custom_Elements.ImageButton();
            this.backBtn = new BookShelf.Custom_Elements.ImageButton();
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.searchPanel = new Telerik.WinControls.UI.RadPanel();
            this.searchTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.searchForLabel = new Telerik.WinControls.UI.RadLabel();
            this.customTitleBar1 = new BookShelf.Custom_Elements.CustomTitleBar();
            ((System.ComponentModel.ISupportInitialize)(this.upperPanel)).BeginInit();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookShelfLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCategoryLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllItemsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCategoriesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPanel)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchForLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.Controls.Add(this.bookShelfLabel);
            this.upperPanel.Controls.Add(this.logoLabel);
            this.upperPanel.Controls.Add(this.radDropDownList1);
            this.upperPanel.Controls.Add(this.selectCategoryLabel);
            this.upperPanel.Controls.Add(this.searchBtn);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 35);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1192, 115);
            this.upperPanel.TabIndex = 4;
            // 
            // bookShelfLabel
            // 
            this.bookShelfLabel.Image = global::BookShelf.Properties.Resources.logo_typo;
            this.bookShelfLabel.Location = new System.Drawing.Point(104, 34);
            this.bookShelfLabel.Name = "bookShelfLabel";
            this.bookShelfLabel.Size = new System.Drawing.Size(203, 29);
            this.bookShelfLabel.TabIndex = 5;
            // 
            // logoLabel
            // 
            this.logoLabel.Image = global::BookShelf.Properties.Resources.logo_sign_home;
            this.logoLabel.Location = new System.Drawing.Point(12, 6);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(86, 86);
            this.logoLabel.TabIndex = 4;
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownAnimationEnabled = true;
            this.radDropDownList1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropDownList1.Location = new System.Drawing.Point(587, 37);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.ShowImageInEditorArea = true;
            this.radDropDownList1.Size = new System.Drawing.Size(302, 27);
            this.radDropDownList1.TabIndex = 3;
            // 
            // selectCategoryLabel
            // 
            this.selectCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectCategoryLabel.Location = new System.Drawing.Point(433, 37);
            this.selectCategoryLabel.Name = "selectCategoryLabel";
            this.selectCategoryLabel.Size = new System.Drawing.Size(148, 25);
            this.selectCategoryLabel.TabIndex = 2;
            this.selectCategoryLabel.Text = "SELECT CATEGORY:";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(345, 23);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(45, 44);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "radButton2";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.showAllItemsButton);
            this.bottomPanel.Controls.Add(this.allCategoriesBtn);
            this.bottomPanel.Controls.Add(this.homeBtn);
            this.bottomPanel.Controls.Add(this.backBtn);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 634);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1192, 82);
            this.bottomPanel.TabIndex = 5;
            // 
            // showAllItemsButton
            // 
            this.showAllItemsButton.AutoSize = true;
            this.showAllItemsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.showAllItemsButton.Image = global::BookShelf.Properties.Resources.show_all_items;
            this.showAllItemsButton.Location = new System.Drawing.Point(746, 0);
            this.showAllItemsButton.Name = "showAllItemsButton";
            this.showAllItemsButton.Size = new System.Drawing.Size(446, 42);
            this.showAllItemsButton.TabIndex = 3;
            // 
            // allCategoriesBtn
            // 
            this.allCategoriesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.allCategoriesBtn.AutoSize = true;
            this.allCategoriesBtn.Image = global::BookShelf.Properties.Resources.all_categories;
            this.allCategoriesBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.allCategoriesBtn.Location = new System.Drawing.Point(150, 11);
            this.allCategoriesBtn.Name = "allCategoriesBtn";
            this.allCategoriesBtn.Size = new System.Drawing.Size(74, 58);
            this.allCategoriesBtn.TabIndex = 2;
            this.allCategoriesBtn.Text = "All categories";
            this.allCategoriesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.homeBtn.AutoSize = true;
            this.homeBtn.Image = global::BookShelf.Properties.Resources.home;
            this.homeBtn.Location = new System.Drawing.Point(97, 11);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(42, 58);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.AutoSize = true;
            this.backBtn.Image = global::BookShelf.Properties.Resources.back;
            this.backBtn.Location = new System.Drawing.Point(31, 11);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(42, 58);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // radPanorama1
            // 
            this.radPanorama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanorama1.Location = new System.Drawing.Point(0, 209);
            this.radPanorama1.Name = "radPanorama1";
            this.radPanorama1.PanelImage = ((System.Drawing.Image)(resources.GetObject("radPanorama1.PanelImage")));
            this.radPanorama1.Size = new System.Drawing.Size(1192, 425);
            this.radPanorama1.TabIndex = 0;
            this.radPanorama1.Text = "radPanorama1";
            // 
            // radListView1
            // 
            this.radListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListView1.GroupItemSize = new System.Drawing.Size(200, 20);
            this.radListView1.ItemSize = new System.Drawing.Size(200, 20);
            this.radListView1.Location = new System.Drawing.Point(0, 209);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(1192, 425);
            this.radListView1.TabIndex = 0;
            this.radListView1.Text = "radListView1";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchForLabel);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 150);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1192, 59);
            this.searchPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.searchTextBox.Location = new System.Drawing.Point(271, 14);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(611, 34);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TabStop = false;
            // 
            // searchForLabel
            // 
            this.searchForLabel.Font = new System.Drawing.Font("Segoe UI Light", 27F);
            this.searchForLabel.Location = new System.Drawing.Point(93, 3);
            this.searchForLabel.Name = "searchForLabel";
            this.searchForLabel.Size = new System.Drawing.Size(172, 54);
            this.searchForLabel.TabIndex = 0;
            this.searchForLabel.Text = "Search for";
            // 
            // customTitleBar1
            // 
            this.customTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.customTitleBar1.MinimumSize = new System.Drawing.Size(0, 35);
            this.customTitleBar1.Name = "customTitleBar1";
            // 
            // 
            // 
            this.customTitleBar1.RootElement.MinSize = new System.Drawing.Size(0, 35);
            this.customTitleBar1.Size = new System.Drawing.Size(1192, 35);
            this.customTitleBar1.TabIndex = 0;
            this.customTitleBar1.TabStop = false;
            this.customTitleBar1.Text = "RadForm";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 716);
            this.Controls.Add(this.radListView1);
            this.Controls.Add(this.radPanorama1);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.customTitleBar1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.upperPanel)).EndInit();
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookShelfLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCategoryLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllItemsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCategoriesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPanel)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchForLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BookShelf.Custom_Elements.CustomTitleBar customTitleBar1;
        private Telerik.WinControls.UI.RadPanel upperPanel;
        private Telerik.WinControls.UI.RadPanel bottomPanel;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadLabel selectCategoryLabel;
        private Telerik.WinControls.UI.RadButton searchBtn;
        private BookShelf.Custom_Elements.ImageButton allCategoriesBtn;
        private BookShelf.Custom_Elements.ImageButton homeBtn;
        private BookShelf.Custom_Elements.ImageButton backBtn;
        private Telerik.WinControls.UI.RadButton showAllItemsButton;
        private Telerik.WinControls.UI.RadLabel bookShelfLabel;
        private Telerik.WinControls.UI.RadLabel logoLabel;
        private Telerik.WinControls.UI.RadPanorama radPanorama1;
        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadPanel searchPanel;
        private Telerik.WinControls.UI.RadLabel searchForLabel;
        private Telerik.WinControls.UI.RadTextBox searchTextBox;
    }
}