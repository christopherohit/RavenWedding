namespace Telerik.Examples.WinControls.GridView.Hierarchy.FolderTree
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radButtonExpand = new Telerik.WinControls.UI.RadButton();
            this.radButtonCollapse = new Telerik.WinControls.UI.RadButton();
            this.radCheckBoxShowCellBorders = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radCheckBoxShowLines = new Telerik.WinControls.UI.RadCheckBox();
            this.radColorBoxBackColor = new Telerik.WinControls.UI.RadColorBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCollapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowCellBorders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radColorBoxBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radButtonCollapse);
            this.settingsPanel.Controls.Add(this.radButtonExpand);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(955, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 747);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radButtonExpand, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radButtonCollapse, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1156, 749);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_blue_open1.png");
            this.imageList1.Images.SetKeyName(1, "folder1.png");
            this.imageList1.Images.SetKeyName(2, "new1.png");
            // 
            // radButtonExpand
            // 
            this.radButtonExpand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonExpand.Location = new System.Drawing.Point(10, 52);
            this.radButtonExpand.Name = "radButtonExpand";
            this.radButtonExpand.Size = new System.Drawing.Size(180, 24);
            this.radButtonExpand.TabIndex = 2;
            this.radButtonExpand.Text = "Expand All";
       
            // 
            // radButtonCollapse
            // 
            this.radButtonCollapse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonCollapse.Location = new System.Drawing.Point(10, 82);
            this.radButtonCollapse.Name = "radButtonCollapse";
            this.radButtonCollapse.Size = new System.Drawing.Size(180, 24);
            this.radButtonCollapse.TabIndex = 3;
            this.radButtonCollapse.Text = "Collapse All";

            // 
            // radCheckBoxShowCellBorders
            // 
            this.radCheckBoxShowCellBorders.Location = new System.Drawing.Point(13, 47);
            this.radCheckBoxShowCellBorders.Name = "radCheckBoxShowCellBorders";
            // 
            // 
            // 
            this.radCheckBoxShowCellBorders.RootElement.StretchHorizontally = true;
            this.radCheckBoxShowCellBorders.RootElement.StretchVertically = true;
            this.radCheckBoxShowCellBorders.Size = new System.Drawing.Size(109, 18);
            this.radCheckBoxShowCellBorders.TabIndex = 2;
            this.radCheckBoxShowCellBorders.Text = "Show cell borders";
            this.radCheckBoxShowCellBorders.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
          
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radColorBoxBackColor);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radDropDownList1);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radCheckBoxShowLines);
            this.radGroupBox1.Controls.Add(this.radCheckBoxShowCellBorders);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Customize lines";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 128);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 189);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Customize lines";
            // 
            // radDropDownList1
            // 
            radListDataItem1.Text = "Solid";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Dash";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Dot";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "DashDot";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "DashDotDot";
            radListDataItem5.TextWrap = true;
            this.radDropDownList1.Items.Add(radListDataItem1);
            this.radDropDownList1.Items.Add(radListDataItem2);
            this.radDropDownList1.Items.Add(radListDataItem3);
            this.radDropDownList1.Items.Add(radListDataItem4);
            this.radDropDownList1.Items.Add(radListDataItem5);
            this.radDropDownList1.Location = new System.Drawing.Point(16, 96);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.ShowImageInEditorArea = true;
            this.radDropDownList1.Size = new System.Drawing.Size(151, 21);
            this.radDropDownList1.TabIndex = 5;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
           
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 72);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(55, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Line style:";
            // 
            // radCheckBoxShowLines
            // 
            this.radCheckBoxShowLines.Location = new System.Drawing.Point(13, 23);
            this.radCheckBoxShowLines.Name = "radCheckBoxShowLines";
            // 
            // 
            // 
            this.radCheckBoxShowLines.RootElement.StretchHorizontally = true;
            this.radCheckBoxShowLines.RootElement.StretchVertically = true;
            this.radCheckBoxShowLines.Size = new System.Drawing.Size(109, 18);
            this.radCheckBoxShowLines.TabIndex = 3;
            this.radCheckBoxShowLines.Text = "Show tree lines";
          
            // 
            // radColorBoxBackColor
            // 
            this.radColorBoxBackColor.Location = new System.Drawing.Point(59, 152);
            this.radColorBoxBackColor.Name = "radColorBoxBackColor";
            this.radColorBoxBackColor.Size = new System.Drawing.Size(59, 24);
            this.radColorBoxBackColor.TabIndex = 9;

            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(16, 123);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(57, 18);
            this.radLabel3.TabIndex = 10;
            this.radLabel3.Text = "Line color:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1156, 749);

            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCollapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowCellBorders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radColorBoxBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadButton radButtonCollapse;
        private Telerik.WinControls.UI.RadButton radButtonExpand;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowLines;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowCellBorders;
        private Telerik.WinControls.UI.RadColorBox radColorBoxBackColor;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
