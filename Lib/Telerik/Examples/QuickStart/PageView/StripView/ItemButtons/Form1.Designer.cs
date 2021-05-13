using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.Examples.WinControls;

namespace Telerik.Examples.WinControls.PageView.StripView.ItemButtons
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
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.closeButtonCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.addButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.addButton);
            this.settingsPanel.Controls.Add(this.closeButtonCheck);
            this.settingsPanel.Location = new System.Drawing.Point(1068, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 587);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.closeButtonCheck, 0);
            this.settingsPanel.Controls.SetChildIndex(this.addButton, 0);
            // 
            // radPageView1
            // 
            this.radPageView1.Location = new System.Drawing.Point(20, 20);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.Size = new System.Drawing.Size(472, 385);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "radPageView1";
            // 
            // closeButtonCheck
            // 
            this.closeButtonCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.closeButtonCheck.Location = new System.Drawing.Point(10, 37);
            this.closeButtonCheck.Name = "closeButtonCheck";
            this.closeButtonCheck.Size = new System.Drawing.Size(114, 18);
            this.closeButtonCheck.TabIndex = 1;
            this.closeButtonCheck.Text = "Show Close Button";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.Location = new System.Drawing.Point(10, 71);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(180, 24);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Page";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPageView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1384, 977);
            this.Controls.SetChildIndex(this.radPageView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private RadCheckBox closeButtonCheck;
        private RadButton addButton;
    }
}
