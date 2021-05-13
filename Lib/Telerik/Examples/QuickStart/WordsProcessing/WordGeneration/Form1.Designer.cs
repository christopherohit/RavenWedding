namespace Telerik.Examples.WinControls.WordsProcessing.WordGeneration
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.exportFormatDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.exportButton = new Telerik.WinControls.UI.RadButton();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportFormatDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(418, 42);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(44, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Format:";
            // 
            // exportFormatDropDownList
            // 
            this.exportFormatDropDownList.DropDownAnimationEnabled = false;
            this.exportFormatDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.exportFormatDropDownList.Location = new System.Drawing.Point(511, 40);
            this.exportFormatDropDownList.Name = "exportFormatDropDownList";
            this.exportFormatDropDownList.Size = new System.Drawing.Size(125, 20);
            this.exportFormatDropDownList.TabIndex = 2;
            this.exportFormatDropDownList.Text = "radDropDownList1";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(422, 210);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(105, 24);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Generate";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox1.Location = new System.Drawing.Point(422, 98);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(96, 18);
            this.radCheckBox1.TabIndex = 4;
            this.radCheckBox1.Text = "Include Header";
            this.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBox1.CheckStateChanged += new System.EventHandler(this.radCheckBox1_CheckStateChanged);
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox2.Location = new System.Drawing.Point(422, 151);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.Size = new System.Drawing.Size(92, 18);
            this.radCheckBox2.TabIndex = 5;
            this.radCheckBox2.Text = "Include Footer";
            this.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBox2.CheckStateChanged += new System.EventHandler(this.radCheckBox2_CheckStateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(20, 20);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(83, 18);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Email Template";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 566);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radCheckBox2);
            this.Controls.Add(this.radCheckBox1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.exportFormatDropDownList);
            this.Controls.Add(this.radLabel1);
            this.Name = "Form1";
            this.Text = "Generate Documents";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportFormatDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList exportFormatDropDownList;
        private Telerik.WinControls.UI.RadButton exportButton;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}

