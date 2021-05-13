using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.Examples.WinControls;

namespace Telerik.Examples.WinControls.PageView.StripView.HTMLItemText
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
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1097, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 490);

            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 21);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Controls.Add(this.radPageViewPage3);
            this.radPageView1.Location = new System.Drawing.Point(20, 20);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(400, 300);
            this.radPageView1.TabIndex = 9;
            this.radPageView1.Text = "radPageView1";
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 51);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(379, 238);
            this.radPageViewPage1.Text = "<html><b><color=Red>Purchases</b><br><i><color=Blue>(By Ship Date)";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Location = new System.Drawing.Point(10, 51);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(379, 238);
            this.radPageViewPage2.Text = "<html><b><color=Navy>Purchases</b><br><i><color=Violet>(By Order Date)";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.Location = new System.Drawing.Point(10, 51);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(379, 238);
            this.radPageViewPage3.Text = "<html><b><color=Brown>Purchases</b><br><i><color=Green>(By Client ID)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radPageView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1298, 492);
            this.Controls.SetChildIndex(this.radPageView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        protected System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private RadPageViewPage radPageViewPage1;
        private RadPageViewPage radPageViewPage2;
        private RadPageViewPage radPageViewPage3;
    }
}