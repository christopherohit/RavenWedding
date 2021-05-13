﻿namespace BugTracker
{
    partial class RadAboutBox1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadAboutBox1));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.radLabelProductName = new Telerik.WinControls.UI.RadLabel();
            this.radLabelVersion = new Telerik.WinControls.UI.RadLabel();
            this.radLabelCopyright = new Telerik.WinControls.UI.RadLabel();
            this.radLabelCompanyName = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxDescription = new Telerik.WinControls.UI.RadTextBox();
            this.okRadButton = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCopyright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.radLabelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.radLabelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.radLabelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.radLabelCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.radTextBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okRadButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(388, 265);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(122, 259);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // radLabelProductName
            // 
            this.radLabelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabelProductName.Location = new System.Drawing.Point(134, 0);
            this.radLabelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.radLabelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.radLabelProductName.Name = "radLabelProductName";
            // 
            // 
            // 
            this.radLabelProductName.RootElement.MaxSize = new System.Drawing.Size(0, 17);
            this.radLabelProductName.Size = new System.Drawing.Size(78, 17);
            this.radLabelProductName.TabIndex = 19;
            this.radLabelProductName.Text = "Product Name";
            this.radLabelProductName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radLabelVersion
            // 
            this.radLabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabelVersion.Location = new System.Drawing.Point(134, 26);
            this.radLabelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.radLabelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.radLabelVersion.Name = "radLabelVersion";
            // 
            // 
            // 
            this.radLabelVersion.RootElement.MaxSize = new System.Drawing.Size(0, 17);
            this.radLabelVersion.Size = new System.Drawing.Size(44, 17);
            this.radLabelVersion.TabIndex = 0;
            this.radLabelVersion.Text = "Version";
            this.radLabelVersion.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radLabelCopyright
            // 
            this.radLabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabelCopyright.Location = new System.Drawing.Point(134, 52);
            this.radLabelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.radLabelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.radLabelCopyright.Name = "radLabelCopyright";
            // 
            // 
            // 
            this.radLabelCopyright.RootElement.MaxSize = new System.Drawing.Size(0, 17);
            this.radLabelCopyright.Size = new System.Drawing.Size(56, 17);
            this.radLabelCopyright.TabIndex = 21;
            this.radLabelCopyright.Text = "Copyright";
            this.radLabelCopyright.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radLabelCompanyName
            // 
            this.radLabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabelCompanyName.Location = new System.Drawing.Point(134, 78);
            this.radLabelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.radLabelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.radLabelCompanyName.Name = "radLabelCompanyName";
            // 
            // 
            // 
            this.radLabelCompanyName.RootElement.MaxSize = new System.Drawing.Size(0, 17);
            this.radLabelCompanyName.Size = new System.Drawing.Size(87, 17);
            this.radLabelCompanyName.TabIndex = 22;
            this.radLabelCompanyName.Text = "Company Name";
            this.radLabelCompanyName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radTextBoxDescription
            // 
            this.radTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTextBoxDescription.Location = new System.Drawing.Point(134, 107);
            this.radTextBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radTextBoxDescription.Multiline = true;
            this.radTextBoxDescription.Name = "radTextBoxDescription";
            this.radTextBoxDescription.ReadOnly = true;
            // 
            // 
            // 
            this.radTextBoxDescription.RootElement.StretchVertically = true;
            this.radTextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.radTextBoxDescription.Size = new System.Drawing.Size(251, 126);
            this.radTextBoxDescription.TabIndex = 23;
            this.radTextBoxDescription.TabStop = false;
            this.radTextBoxDescription.Text = "Description";
            // 
            // okRadButton
            // 
            this.okRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okRadButton.Location = new System.Drawing.Point(310, 239);
            this.okRadButton.Name = "okRadButton";
            this.okRadButton.Size = new System.Drawing.Size(75, 23);
            this.okRadButton.TabIndex = 24;
            this.okRadButton.Text = "&OK";
            // 
            // RadAboutBox1
            // 
            this.AcceptButton = this.okRadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 283);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadAboutBox1";
            this.Padding = new System.Windows.Forms.Padding(9);
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RadAboutBox1";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCopyright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private Telerik.WinControls.UI.RadLabel radLabelProductName;
        private Telerik.WinControls.UI.RadLabel radLabelVersion;
        private Telerik.WinControls.UI.RadLabel radLabelCopyright;
        private Telerik.WinControls.UI.RadLabel radLabelCompanyName;
        private Telerik.WinControls.UI.RadTextBox radTextBoxDescription;
        private Telerik.WinControls.UI.RadButton okRadButton;
    }
}
