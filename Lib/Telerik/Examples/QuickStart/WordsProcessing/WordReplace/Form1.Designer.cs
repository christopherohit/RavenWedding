using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.WordsProcessing.WordReplace
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openSampleDoc = new Telerik.WinControls.UI.RadButton();
            this.loadcustomDoc = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.docName = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.selectOption = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.findWhat = new Telerik.WinControls.UI.RadTextBox();
            this.replaceWith = new Telerik.WinControls.UI.RadTextBox();
            this.matchCase = new Telerik.WinControls.UI.RadCheckBox();
            this.matchWholeWord = new Telerik.WinControls.UI.RadCheckBox();
            this.useRegex = new Telerik.WinControls.UI.RadCheckBox();
            this.replaceAndSave = new Telerik.WinControls.UI.RadButton();
            this.doubleBufferedTableLayoutPanel2 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.doubleBufferedTableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openSampleDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadcustomDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findWhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceWith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchWholeWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useRegex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceAndSave)).BeginInit();
            this.doubleBufferedTableLayoutPanel2.SuspendLayout();
            this.doubleBufferedTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(832, 13);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openSampleDoc
            // 
            this.openSampleDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openSampleDoc.Location = new System.Drawing.Point(178, 12);
            this.openSampleDoc.Name = "openSampleDoc";
            this.openSampleDoc.Size = new System.Drawing.Size(213, 24);
            this.openSampleDoc.TabIndex = 1;
            this.openSampleDoc.Text = "Load Sample Document";
            this.openSampleDoc.Click += new System.EventHandler(this.LoadSampleDoc_Click);
            // 
            // loadcustomDoc
            // 
            this.loadcustomDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadcustomDoc.Location = new System.Drawing.Point(178, 86);
            this.loadcustomDoc.Name = "loadcustomDoc";
            this.loadcustomDoc.Size = new System.Drawing.Size(213, 24);
            this.loadcustomDoc.TabIndex = 2;
            this.loadcustomDoc.Text = "Load Custom Document";
            this.loadcustomDoc.Click += new System.EventHandler(this.LoadCustomDoc_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel1.Location = new System.Drawing.Point(266, 52);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(37, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "- OR -";
            // 
            // docName
            // 
            this.docName.Location = new System.Drawing.Point(70, 417);
            this.docName.Name = "docName";
            this.docName.Size = new System.Drawing.Size(55, 18);
            this.docName.TabIndex = 5;
            this.docName.Text = "radLabel2";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(20, 417);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(34, 18);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "FILE: ";
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel4.Location = new System.Drawing.Point(3, 24);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(48, 18);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "Method:";
            // 
            // selectOption
            // 
            this.selectOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectOption.DropDownAnimationEnabled = false;
            this.selectOption.Location = new System.Drawing.Point(3, 48);
            this.selectOption.Name = "selectOption";
            this.selectOption.Size = new System.Drawing.Size(184, 20);
            this.selectOption.TabIndex = 8;
            this.selectOption.Text = "radDropDownList1";
            this.selectOption.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.SelectOption_SelectedIndexChanged);
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel5.Location = new System.Drawing.Point(193, 24);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(57, 18);
            this.radLabel5.TabIndex = 9;
            this.radLabel5.Text = "Find what:";
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel6.Location = new System.Drawing.Point(383, 24);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(72, 18);
            this.radLabel6.TabIndex = 10;
            this.radLabel6.Text = "Replace with:";
            // 
            // findWhat
            // 
            this.findWhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findWhat.Location = new System.Drawing.Point(193, 48);
            this.findWhat.Name = "findWhat";
            this.findWhat.Size = new System.Drawing.Size(184, 20);
            this.findWhat.TabIndex = 11;
            // 
            // replaceWith
            // 
            this.replaceWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceWith.Location = new System.Drawing.Point(383, 48);
            this.replaceWith.Name = "replaceWith";
            this.replaceWith.Size = new System.Drawing.Size(184, 20);
            this.replaceWith.TabIndex = 12;
            // 
            // matchCase
            // 
            this.matchCase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.matchCase.Location = new System.Drawing.Point(3, 103);
            this.matchCase.Name = "matchCase";
            this.matchCase.Size = new System.Drawing.Size(78, 18);
            this.matchCase.TabIndex = 13;
            this.matchCase.Text = "Match Case";
            // 
            // matchWholeWord
            // 
            this.matchWholeWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.matchWholeWord.Location = new System.Drawing.Point(193, 103);
            this.matchWholeWord.Name = "matchWholeWord";
            this.matchWholeWord.Size = new System.Drawing.Size(118, 18);
            this.matchWholeWord.TabIndex = 14;
            this.matchWholeWord.Text = "Match Whole Word";
            // 
            // useRegex
            // 
            this.useRegex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.useRegex.Location = new System.Drawing.Point(383, 103);
            this.useRegex.Name = "useRegex";
            this.useRegex.Size = new System.Drawing.Size(136, 18);
            this.useRegex.TabIndex = 15;
            this.useRegex.Text = "Use Regular Expression";
            // 
            // replaceAndSave
            // 
            this.replaceAndSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doubleBufferedTableLayoutPanel2.SetColumnSpan(this.replaceAndSave, 3);
            this.replaceAndSave.Location = new System.Drawing.Point(6, 141);
            this.replaceAndSave.Margin = new System.Windows.Forms.Padding(6);
            this.replaceAndSave.Name = "replaceAndSave";
            this.replaceAndSave.Size = new System.Drawing.Size(558, 33);
            this.replaceAndSave.TabIndex = 16;
            this.replaceAndSave.Text = "Replace and Save";
            this.replaceAndSave.Click += new System.EventHandler(this.ReplaceAndSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel2.ColumnCount = 3;
            this.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.doubleBufferedTableLayoutPanel2.Controls.Add(this.radLabel4, 0, 0);
            this.doubleBufferedTableLayoutPanel2.Controls.Add(this.radLabel5, 1, 0);
            this.doubleBufferedTableLayoutPanel2.Controls.Add(this.replaceAndSave, 0, 3);
            this.doubleBufferedTableLayoutPanel2.Controls.Add(this.radLabel6, 2, 0);
            this.doubleBufferedTableLayoutPanel2.Controls.Add(this.useRegex, 2, 2);
            this.doubleBufferedTableLayoutPanel2.Controls.Add(this.selectOption, 0, 1);
            this.doubleBufferedTableLayoutPanel2.Controls.Add(this.matchWholeWord, 1, 2);
            this.doubleBufferedTableLayoutPanel2.Controls.Add(this.findWhat, 1, 1);
            this.doubleBufferedTableLayoutPanel2.Controls.Add(this.matchCase, 0, 2);
            this.doubleBufferedTableLayoutPanel2.Controls.Add(this.replaceWith, 2, 1);
            this.doubleBufferedTableLayoutPanel2.Location = new System.Drawing.Point(20, 452);
            this.doubleBufferedTableLayoutPanel2.Name = "doubleBufferedTableLayoutPanel2";
            this.doubleBufferedTableLayoutPanel2.RowCount = 4;
            this.doubleBufferedTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.doubleBufferedTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.doubleBufferedTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.doubleBufferedTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.doubleBufferedTableLayoutPanel2.Size = new System.Drawing.Size(570, 180);
            this.doubleBufferedTableLayoutPanel2.TabIndex = 17;
            // 
            // doubleBufferedTableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel1.ColumnCount = 1;
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.openSampleDoc, 0, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.loadcustomDoc, 0, 2);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLabel1, 0, 1);
            this.doubleBufferedTableLayoutPanel1.Location = new System.Drawing.Point(20, 275);
            this.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1";
            this.doubleBufferedTableLayoutPanel1.RowCount = 3;
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.doubleBufferedTableLayoutPanel1.Size = new System.Drawing.Size(570, 124);
            this.doubleBufferedTableLayoutPanel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doubleBufferedTableLayoutPanel1);
            this.Controls.Add(this.doubleBufferedTableLayoutPanel2);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.docName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2011, 1157);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.docName, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.doubleBufferedTableLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.doubleBufferedTableLayoutPanel1, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openSampleDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadcustomDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findWhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceWith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchWholeWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useRegex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceAndSave)).EndInit();
            this.doubleBufferedTableLayoutPanel2.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel2.PerformLayout();
            this.doubleBufferedTableLayoutPanel1.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadButton openSampleDoc;
        private Telerik.WinControls.UI.RadButton loadcustomDoc;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel docName;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList selectOption;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox findWhat;
        private Telerik.WinControls.UI.RadTextBox replaceWith;
        private Telerik.WinControls.UI.RadCheckBox matchCase;
        private Telerik.WinControls.UI.RadCheckBox matchWholeWord;
        private Telerik.WinControls.UI.RadCheckBox useRegex;
        private Telerik.WinControls.UI.RadButton replaceAndSave;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel2;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel1;
    }
}