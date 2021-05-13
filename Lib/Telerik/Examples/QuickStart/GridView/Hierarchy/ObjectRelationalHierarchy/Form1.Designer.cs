namespace Telerik.Examples.WinControls.GridView.Hierarchy.ObjectRelationalHierarchy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.settingsPanel = new Telerik.WinControls.UI.RadPanel();
            this.btnSpy = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupHierarchyOptions = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioHierarchyFromDataSet = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioManuallyUnbound = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupHierarchyOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioHierarchyFromDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioManuallyUnbound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsPanel.Controls.Add(this.radCheckBox1);
            this.settingsPanel.Controls.Add(this.radGroupHierarchyOptions);
            this.settingsPanel.Controls.Add(this.btnSpy);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1446, 1);
            this.settingsPanel.Name = "settingsPanel";
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 770);
            this.settingsPanel.TabIndex = 0;
            // 
            // btnSpy
            // 
            this.btnSpy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpy.Image = ((System.Drawing.Image)(resources.GetObject("btnSpy.Image")));
            this.btnSpy.Location = new System.Drawing.Point(10, 7);
            this.btnSpy.Name = "btnSpy";
            this.btnSpy.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            // 
            // 
            // 
            this.btnSpy.RootElement.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSpy.Size = new System.Drawing.Size(180, 24);
            this.btnSpy.TabIndex = 0;
            this.btnSpy.Text = "RadControl Spy ";
            this.btnSpy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1647, 772);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // radGroupHierarchyOptions
            // 
            this.radGroupHierarchyOptions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupHierarchyOptions.Controls.Add(this.radRadioHierarchyFromDataSet);
            this.radGroupHierarchyOptions.Controls.Add(this.radRadioManuallyUnbound);
            this.radGroupHierarchyOptions.Controls.Add(this.radRadioButton2);
            this.radGroupHierarchyOptions.FooterImageIndex = -1;
            this.radGroupHierarchyOptions.FooterImageKey = "";
            this.radGroupHierarchyOptions.HeaderImageIndex = -1;
            this.radGroupHierarchyOptions.HeaderImageKey = "";
            this.radGroupHierarchyOptions.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupHierarchyOptions.HeaderText = " Scenarios ";
            this.radGroupHierarchyOptions.Location = new System.Drawing.Point(10, 6);
            this.radGroupHierarchyOptions.Name = "radGroupHierarchyOptions";
            this.radGroupHierarchyOptions.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupHierarchyOptions.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupHierarchyOptions.Size = new System.Drawing.Size(180, 141);
            this.radGroupHierarchyOptions.TabIndex = 0;
            this.radGroupHierarchyOptions.Text = " Scenarios ";
            // 
            // radRadioHierarchyFromDataSet
            // 
            this.radRadioHierarchyFromDataSet.Location = new System.Drawing.Point(15, 94);
            this.radRadioHierarchyFromDataSet.Name = "radRadioHierarchyFromDataSet";
            this.radRadioHierarchyFromDataSet.Size = new System.Drawing.Size(133, 29);
            this.radRadioHierarchyFromDataSet.TabIndex = 0;
            this.radRadioHierarchyFromDataSet.Text = "Auto-Generated from\r\nDataSet";
            // 
            // radRadioManuallyUnbound
            // 
            this.radRadioManuallyUnbound.Location = new System.Drawing.Point(15, 24);
            this.radRadioManuallyUnbound.Name = "radRadioManuallyUnbound";
            this.radRadioManuallyUnbound.Size = new System.Drawing.Size(128, 29);
            this.radRadioManuallyUnbound.TabIndex = 0;
            this.radRadioManuallyUnbound.Text = "Manually Generated\r\nfor Unbound Mode";
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Location = new System.Drawing.Point(15, 59);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(128, 29);
            this.radRadioButton2.TabIndex = 0;
            this.radRadioButton2.Text = "Manually Generated\r\nfor Bound Mode";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBox1.Location = new System.Drawing.Point(10, 153);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(136, 19);
            this.radCheckBox1.TabIndex = 1;
            this.radCheckBox1.Text = "Use nested scrollbars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1647, 772);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupHierarchyOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioHierarchyFromDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioManuallyUnbound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
		
        private Telerik.WinControls.UI.RadGroupBox radGroupHierarchyOptions;
        private Telerik.WinControls.UI.RadRadioButton radRadioManuallyUnbound;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioHierarchyFromDataSet;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private new Telerik.WinControls.UI.RadPanel settingsPanel;
        private Telerik.WinControls.UI.RadButton btnSpy;
        
	}
}
