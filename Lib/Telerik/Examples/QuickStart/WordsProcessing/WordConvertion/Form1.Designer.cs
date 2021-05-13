namespace Telerik.Examples.WinControls.WordsProcessing.WordConvertion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.loadCustomDocumentButton = new Telerik.WinControls.UI.RadButton();
            this.loadSampleDocumentButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.fileNameLabel = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.fileExtensionsDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.saveButton = new Telerik.WinControls.UI.RadButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadCustomDocumentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSampleDocumentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileExtensionsDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(215, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "- OR - ";
            // 
            // loadCustomDocumentButton
            // 
            this.loadCustomDocumentButton.Location = new System.Drawing.Point(20, 284);
            this.loadCustomDocumentButton.Name = "loadCustomDocumentButton";
            this.loadCustomDocumentButton.Size = new System.Drawing.Size(184, 24);
            this.loadCustomDocumentButton.TabIndex = 3;
            this.loadCustomDocumentButton.Text = "Load Custom Document";
            this.loadCustomDocumentButton.Click += new System.EventHandler(this.loadCustomDocumentButton_Click);
            // 
            // loadSampleDocumentButton
            // 
            this.loadSampleDocumentButton.Location = new System.Drawing.Point(269, 284);
            this.loadSampleDocumentButton.Name = "loadSampleDocumentButton";
            this.loadSampleDocumentButton.Size = new System.Drawing.Size(183, 24);
            this.loadSampleDocumentButton.TabIndex = 4;
            this.loadSampleDocumentButton.Text = "Load Sample Document";
            this.loadSampleDocumentButton.Click += new System.EventHandler(this.loadSampleDocumentButton_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(19, 345);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(31, 18);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "File: ";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Location = new System.Drawing.Point(45, 345);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(2, 2);
            this.fileNameLabel.TabIndex = 6;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(19, 391);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(64, 18);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Extension: ";
            // 
            // fileExtensionsDropDownList
            // 
            this.fileExtensionsDropDownList.DropDownAnimationEnabled = false;
            this.fileExtensionsDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.fileExtensionsDropDownList.Location = new System.Drawing.Point(112, 388);
            this.fileExtensionsDropDownList.Name = "fileExtensionsDropDownList";
            this.fileExtensionsDropDownList.Size = new System.Drawing.Size(107, 20);
            this.fileExtensionsDropDownList.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(20, 443);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(432, 24);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(269, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 500);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.fileExtensionsDropDownList);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.loadSampleDocumentButton);
            this.Controls.Add(this.loadCustomDocumentButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Convert Documents";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadCustomDocumentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSampleDocumentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileExtensionsDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Telerik.WinControls.UI.RadButton loadCustomDocumentButton;
        private Telerik.WinControls.UI.RadButton loadSampleDocumentButton;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel fileNameLabel;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList fileExtensionsDropDownList;
        private Telerik.WinControls.UI.RadButton saveButton;
    }
}

