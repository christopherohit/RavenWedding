namespace Telerik.Examples.WinControls.GridView.Rows.RowsDragDrop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.gbProducts = new Telerik.WinControls.UI.RadGroupBox();
            this.gridViewProducts = new Telerik.WinControls.UI.RadGridView();
            this.gbBasket = new Telerik.WinControls.UI.RadGroupBox();
            this.gridBasket = new Telerik.WinControls.UI.RadGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCheckoutSelectedProducts = new Telerik.WinControls.UI.RadButton();
            this.btnCheckoutAllProducts = new Telerik.WinControls.UI.RadButton();
            this.btnReturnSelectedProducts = new Telerik.WinControls.UI.RadButton();
            this.btnReturnAllProducts = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbProducts)).BeginInit();
            this.gbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbBasket)).BeginInit();
            this.gbBasket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBasket.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckoutSelectedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckoutAllProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnSelectedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.btnCheckoutSelectedProducts);
            this.settingsPanel.Controls.Add(this.btnReturnAllProducts);
            this.settingsPanel.Controls.Add(this.btnReturnSelectedProducts);
            this.settingsPanel.Controls.Add(this.btnCheckoutAllProducts);
            this.settingsPanel.Location = new System.Drawing.Point(744, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 723);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.btnCheckoutAllProducts, 0);
            this.settingsPanel.Controls.SetChildIndex(this.btnReturnSelectedProducts, 0);
            this.settingsPanel.Controls.SetChildIndex(this.btnReturnAllProducts, 0);
            this.settingsPanel.Controls.SetChildIndex(this.btnCheckoutSelectedProducts, 0);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.gbProducts);
            this.radPanel1.Controls.Add(this.gbBasket);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Padding = new System.Windows.Forms.Padding(100);
            // 
            // 
            // 
            this.radPanel1.RootElement.Padding = new System.Windows.Forms.Padding(100);
            this.radPanel1.Size = new System.Drawing.Size(1029, 519);
            this.radPanel1.TabIndex = 1;

            // 
            // gbProducts
            // 
            this.gbProducts.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbProducts.Controls.Add(this.gridViewProducts);
            this.gbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducts.HeaderText = "Products";
            this.gbProducts.Location = new System.Drawing.Point(103, 97);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Padding = new System.Windows.Forms.Padding(10, 25, 10, 10);
            // 
            // 
            // 
            this.gbProducts.RootElement.Padding = new System.Windows.Forms.Padding(10, 25, 10, 10);
            this.gbProducts.Size = new System.Drawing.Size(200, 319);
            this.gbProducts.TabIndex = 0;
            this.gbProducts.Text = "Products";
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewProducts.Location = new System.Drawing.Point(10, 25);
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.MasterTemplate.AllowAddNewRow = false;
            this.gridViewProducts.MasterTemplate.EnableGrouping = false;
            this.gridViewProducts.Name = "gridViewProducts";
            // 
            // 
            // 
            this.gridViewProducts.ShowGroupPanel = false;
            this.gridViewProducts.Size = new System.Drawing.Size(180, 284);
            this.gridViewProducts.TabIndex = 0;
            this.gridViewProducts.Text = "radGridView1";
            // 
            // gbBasket
            // 
            this.gbBasket.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbBasket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbBasket.Controls.Add(this.gridBasket);
            this.gbBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBasket.HeaderText = "Basket";
            this.gbBasket.Location = new System.Drawing.Point(330, 97);
            this.gbBasket.Name = "gbBasket";
            this.gbBasket.Padding = new System.Windows.Forms.Padding(10, 25, 10, 10);
            // 
            // 
            // 
            this.gbBasket.RootElement.Padding = new System.Windows.Forms.Padding(10, 25, 10, 10);
            this.gbBasket.Size = new System.Drawing.Size(200, 319);
            this.gbBasket.TabIndex = 1;
            this.gbBasket.Text = "Basket";
            // 
            // gridBasket
            // 
            this.gridBasket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBasket.Location = new System.Drawing.Point(10, 25);
            // 
            // gridBasket
            // 
            this.gridBasket.MasterTemplate.AllowAddNewRow = false;
            this.gridBasket.MasterTemplate.EnableGrouping = false;
            this.gridBasket.Name = "gridBasket";
            // 
            // 
            // 
            this.gridBasket.ShowGroupPanel = false;
            this.gridBasket.Size = new System.Drawing.Size(180, 284);
            this.gridBasket.TabIndex = 0;
            this.gridBasket.Text = "radGridView2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Banana.png");
            this.imageList1.Images.SetKeyName(1, "Eggplant.png");
            this.imageList1.Images.SetKeyName(2, "Mushroom.png");
            this.imageList1.Images.SetKeyName(3, "Onion.png");
            this.imageList1.Images.SetKeyName(4, "Pear.png");
            this.imageList1.Images.SetKeyName(5, "Watermelon.png");
            this.imageList1.Images.SetKeyName(6, "full-basket-icon.png");
            // 
            // btnCheckoutSelectedProducts
            // 
            this.btnCheckoutSelectedProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckoutSelectedProducts.Location = new System.Drawing.Point(10, 66);
            this.btnCheckoutSelectedProducts.Name = "btnCheckoutSelectedProducts";
            this.btnCheckoutSelectedProducts.Size = new System.Drawing.Size(180, 24);
            this.btnCheckoutSelectedProducts.TabIndex = 1;
            this.btnCheckoutSelectedProducts.Text = "Checkout Selected Products";

            // 
            // btnCheckoutAllProducts
            // 
            this.btnCheckoutAllProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckoutAllProducts.Location = new System.Drawing.Point(10, 96);
            this.btnCheckoutAllProducts.Name = "btnCheckoutAllProducts";
            this.btnCheckoutAllProducts.Size = new System.Drawing.Size(180, 24);
            this.btnCheckoutAllProducts.TabIndex = 2;
            this.btnCheckoutAllProducts.Text = "Checkout All Products";

            // 
            // btnReturnSelectedProducts
            // 
            this.btnReturnSelectedProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturnSelectedProducts.Location = new System.Drawing.Point(10, 126);
            this.btnReturnSelectedProducts.Name = "btnReturnSelectedProducts";
            this.btnReturnSelectedProducts.Size = new System.Drawing.Size(180, 24);
            this.btnReturnSelectedProducts.TabIndex = 3;
            this.btnReturnSelectedProducts.Text = "Return Selected Products ";
      
            // 
            // btnReturnAllProducts
            // 
            this.btnReturnAllProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturnAllProducts.Location = new System.Drawing.Point(10, 156);
            this.btnReturnAllProducts.Name = "btnReturnAllProducts";
            this.btnReturnAllProducts.Size = new System.Drawing.Size(180, 24);
            this.btnReturnAllProducts.TabIndex = 4;
            this.btnReturnAllProducts.Text = "Return All Products";
       
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1029, 519);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbProducts)).EndInit();
            this.gbProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbBasket)).EndInit();
            this.gbBasket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBasket.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckoutSelectedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckoutAllProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnSelectedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnAllProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGroupBox gbProducts;
        private Telerik.WinControls.UI.RadGroupBox gbBasket;
        private Telerik.WinControls.UI.RadGridView gridViewProducts;
        private Telerik.WinControls.UI.RadGridView gridBasket;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadButton btnReturnSelectedProducts;
        private Telerik.WinControls.UI.RadButton btnCheckoutAllProducts;
        private Telerik.WinControls.UI.RadButton btnCheckoutSelectedProducts;
        private Telerik.WinControls.UI.RadButton btnReturnAllProducts;
    }
}
