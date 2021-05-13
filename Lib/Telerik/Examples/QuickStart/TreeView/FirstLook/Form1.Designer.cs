using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.FirstLook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radDropDownButton1 = new Telerik.WinControls.UI.RadDropDownButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.doubleBufferedTableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            this.doubleBufferedTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(982, 1);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(200, 747);
            this.settingsPanel.Size = new System.Drawing.Size(200, 747);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_feed.png");
            this.imageList1.Images.SetKeyName(1, "feed.png");
            // 
            // radTreeView1
            // 
            this.radTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doubleBufferedTableLayoutPanel1.SetColumnSpan(this.radTreeView1, 3);
            this.radTreeView1.ImageIndex = 0;
            this.radTreeView1.ImageList = this.imageList1;
            this.radTreeView1.Location = new System.Drawing.Point(3, 75);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(470, 522);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 3;
            // 
            // radDropDownButton1
            // 
            this.radDropDownButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radDropDownButton1.Location = new System.Drawing.Point(296, 9);
            this.radDropDownButton1.Name = "radDropDownButton1";
            this.radDropDownButton1.Size = new System.Drawing.Size(140, 24);
            this.radDropDownButton1.TabIndex = 4;
            this.radDropDownButton1.Text = "None";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel1.Location = new System.Drawing.Point(251, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(29, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Sort:";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radTextBox1.Location = new System.Drawing.Point(3, 11);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "Type here to filter";
            this.radTextBox1.Size = new System.Drawing.Size(232, 20);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.TabStop = false;
            // 
            // doubleBufferedTableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.doubleBufferedTableLayoutPanel1.ColumnCount = 3;
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radTreeView1, 0, 2);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radDropDownButton1, 2, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLabel2, 0, 1);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLabel1, 1, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radTextBox1, 0, 0);
            this.doubleBufferedTableLayoutPanel1.Location = new System.Drawing.Point(450, 20);
            this.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1";
            this.doubleBufferedTableLayoutPanel1.RowCount = 3;
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.doubleBufferedTableLayoutPanel1.Size = new System.Drawing.Size(476, 600);
            this.doubleBufferedTableLayoutPanel1.TabIndex = 3;
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.doubleBufferedTableLayoutPanel1.SetColumnSpan(this.radLabel2, 3);
            this.radLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabel2.Location = new System.Drawing.Point(3, 45);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(470, 24);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Subscriptions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.doubleBufferedTableLayoutPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1423, 817);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.doubleBufferedTableLayoutPanel1, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            this.doubleBufferedTableLayoutPanel1.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.ImageList imageList1;
        private RadTreeView radTreeView1;
        private RadLabel radLabel1;
        private RadTextBox radTextBox1;
        private RadDropDownButton radDropDownButton1;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel1;
        private RadLabel radLabel2;
	}
}
