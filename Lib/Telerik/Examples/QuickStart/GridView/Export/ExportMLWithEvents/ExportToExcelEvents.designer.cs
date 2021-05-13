using Telerik.WinControls.UI;
using System.Collections.Generic;
namespace Telerik.Examples.WinControls.GridView.Export.ExportMLWithEvents
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radComboBox1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 818);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton1.Location = new System.Drawing.Point(17, 192);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(138, 30);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "RunExport";
  
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.Name = "radGridView1";
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Size = new System.Drawing.Size(1224, 820);
            this.radGridView1.TabIndex = 1;
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Dash = false;
            this.radProgressBar1.Location = new System.Drawing.Point(17, 166);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.SeparatorColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.radProgressBar1.SeparatorColor2 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorWidth = 4;
            this.radProgressBar1.Size = new System.Drawing.Size(138, 20);
            this.radProgressBar1.StepWidth = 13;
            this.radProgressBar1.TabIndex = 2;
            this.radProgressBar1.Text = "radProgressBar1";
            this.radProgressBar1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radProgressBar1.Visible = false;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radComboBox1);
            this.radGroupBox1.Controls.Add(this.radRadioButton1);
            this.radGroupBox1.Controls.Add(this.radProgressBar1);
            this.radGroupBox1.Controls.Add(this.radRadioButton2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Export Settings";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 501);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Export Settings";
            // 
            // radComboBox1
            // 
            this.radComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboBox1.Items.AddRange(new List<RadListDataItem>(new RadListDataItem[] {
            this.radComboBoxItem1,
            this.radComboBoxItem2,
            this.radComboBoxItem3,
            this.radComboBoxItem4}));
            this.radComboBox1.Location = new System.Drawing.Point(17, 138);
            this.radComboBox1.Name = "radComboBox1";
            this.radComboBox1.NullText = "Select Row Numbers";
            // 
            // 
            // 
            this.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBox1.Size = new System.Drawing.Size(128, 20);
            this.radComboBox1.TabIndex = 7;
            this.radComboBox1.TabStop = false;
            this.radComboBox1.Text = "radComboBox1";
           
            // 
            // radComboBoxItem1
            // 
            this.radComboBoxItem1.Text = "100";
            // 
            // radComboBoxItem2
            // 
            this.radComboBoxItem2.Text = "1,000";
            // 
            // radComboBoxItem3
            // 
            this.radComboBoxItem3.Text = "10,000";
            // 
            // radComboBoxItem4
            // 
            this.radComboBoxItem4.Text = "100,000";
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Location = new System.Drawing.Point(17, 32);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(128, 29);
            this.radRadioButton1.TabIndex = 5;
            this.radRadioButton1.Text = "Max rows supported\r\nby Excel 2007";
            this.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Location = new System.Drawing.Point(17, 67);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(128, 29);
            this.radRadioButton2.TabIndex = 6;
            this.radRadioButton2.Text = "Max rows supported\r\nby prior versions";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(17, 118);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(81, 16);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Rows Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 820);

            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }





        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem1;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem2;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem3;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem4;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadDropDownList radComboBox1;

    }
}
