namespace Telerik.Examples.WinControls.Breadcrumb.FirstLook
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
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radBreadCrumb1 = new Telerik.WinControls.UI.RadBreadCrumb();
            this.textModeCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.autoCompleteCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.histroyCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.selectTreeNodeCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBreadCrumb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textModeCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histroyCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTreeNodeCheckBox)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radTreeView1);
            this.radPanelDemoHolder.Controls.Add(this.radBreadCrumb1);
            this.radPanelDemoHolder.Padding = new System.Windows.Forms.Padding(15);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(1634, 923);
            // 
            // settingsPanel
            // 
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1111, 1);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.selectTreeNodeCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.histroyCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.textModeCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.autoCompleteCheckBox);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(200, 668);
            this.settingsPanel.Size = new System.Drawing.Size(200, 668);
            // 
            // optionsLabel
            // 
            this.optionsLabel.Location = new System.Drawing.Point(46, 304);
            // 
            // radTreeView1
            // 
            this.radTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTreeView1.ImageIndex = 5;
            this.radTreeView1.ImageList = this.imageList1;
            this.radTreeView1.Location = new System.Drawing.Point(15, 45);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(1604, 863);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "computer");
            this.imageList1.Images.SetKeyName(1, "desktop");
            this.imageList1.Images.SetKeyName(2, "documents");
            this.imageList1.Images.SetKeyName(3, "downloads");
            this.imageList1.Images.SetKeyName(4, "favorites");
            this.imageList1.Images.SetKeyName(5, "folder");
            this.imageList1.Images.SetKeyName(6, "hdd");
            this.imageList1.Images.SetKeyName(7, "libraries");
            this.imageList1.Images.SetKeyName(8, "music");
            this.imageList1.Images.SetKeyName(9, "network drive");
            this.imageList1.Images.SetKeyName(10, "network");
            this.imageList1.Images.SetKeyName(11, "pictures");
            this.imageList1.Images.SetKeyName(12, "video");
            this.imageList1.Images.SetKeyName(13, "virtual machines");
            this.imageList1.Images.SetKeyName(14, "work");
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel3.Location = new System.Drawing.Point(8, 2);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(89, 24);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "File Browser";
            // 
            // radBreadCrumb1
            // 
            this.radBreadCrumb1.ChildMember = null;
            this.radBreadCrumb1.DataMember = null;
            this.radBreadCrumb1.DefaultTreeView = this.radTreeView1;
            this.radBreadCrumb1.DisplayMember = null;
            this.radBreadCrumb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radBreadCrumb1.Location = new System.Drawing.Point(15, 15);
            this.radBreadCrumb1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.radBreadCrumb1.Name = "radBreadCrumb1";
            this.radBreadCrumb1.ParentMember = null;
            this.radBreadCrumb1.Size = new System.Drawing.Size(1604, 22);
            this.radBreadCrumb1.TabIndex = 2;
            this.radBreadCrumb1.Text = "radBreadCrumb1";
            this.radBreadCrumb1.ValueMember = null;
            // 
            // textModeCheckBox
            // 
            this.textModeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.textModeCheckBox.Location = new System.Drawing.Point(3, 51);
            this.textModeCheckBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textModeCheckBox.Name = "textModeCheckBox";
            this.textModeCheckBox.Size = new System.Drawing.Size(124, 18);
            this.textModeCheckBox.TabIndex = 6;
            this.textModeCheckBox.Text = "Is TextMode Enabled";
            this.textModeCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.textModeCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.TextModeCheckBox_ToggleStateChanged);
            // 
            // autoCompleteCheckBox
            // 
            this.autoCompleteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoCompleteCheckBox.Location = new System.Drawing.Point(3, 20);
            this.autoCompleteCheckBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.autoCompleteCheckBox.Name = "autoCompleteCheckBox";
            this.autoCompleteCheckBox.Size = new System.Drawing.Size(147, 18);
            this.autoCompleteCheckBox.TabIndex = 5;
            this.autoCompleteCheckBox.Text = "Is AutoComplete Enabled";
            this.autoCompleteCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.autoCompleteCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.AutoCompleteCheckBox_ToggleStateChanged);
            // 
            // histroyCheckBox
            // 
            this.histroyCheckBox.Location = new System.Drawing.Point(3, 82);
            this.histroyCheckBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.histroyCheckBox.Name = "histroyCheckBox";
            this.histroyCheckBox.Size = new System.Drawing.Size(110, 18);
            this.histroyCheckBox.TabIndex = 7;
            this.histroyCheckBox.Text = "Is History Enabled";
            this.histroyCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.HistroyCheckBox_ToggleStateChanged);
            // 
            // selectTreeNodeCheckBox
            // 
            this.selectTreeNodeCheckBox.Location = new System.Drawing.Point(3, 113);
            this.selectTreeNodeCheckBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.selectTreeNodeCheckBox.Name = "selectTreeNodeCheckBox";
            this.selectTreeNodeCheckBox.Size = new System.Drawing.Size(147, 18);
            this.selectTreeNodeCheckBox.TabIndex = 8;
            this.selectTreeNodeCheckBox.Text = "Select TreeNode On Click";
            this.selectTreeNodeCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.SelectTreeNodeCheckBox_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1634, 923);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBreadCrumb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textModeCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histroyCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTreeNodeCheckBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadBreadCrumb radBreadCrumb1;
        private Telerik.WinControls.UI.RadCheckBox textModeCheckBox;
        private Telerik.WinControls.UI.RadCheckBox autoCompleteCheckBox;
        private Telerik.WinControls.UI.RadCheckBox selectTreeNodeCheckBox;
        private Telerik.WinControls.UI.RadCheckBox histroyCheckBox;
    }
}