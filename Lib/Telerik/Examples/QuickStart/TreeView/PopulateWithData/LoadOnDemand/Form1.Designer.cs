﻿namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.LoadOnDemand
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
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1111, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 668);

            // 
            // radTreeView1
            // 
            this.radTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radTreeView1.ImageIndex = 5;
            this.radTreeView1.ImageList = this.imageList1;
            this.radTreeView1.Location = new System.Drawing.Point(6, 38);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(368, 584);
            this.radTreeView1.TabIndex = 1;
            this.radTreeView1.Text = "radTreeView1";
  
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radTreeView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1312, 670);
            this.Controls.SetChildIndex(this.radTreeView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.ImageList imageList1;
	}
}