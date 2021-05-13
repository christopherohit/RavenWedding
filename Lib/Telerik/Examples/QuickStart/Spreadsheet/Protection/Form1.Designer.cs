namespace Telerik.Examples.WinControls.Spreadsheet.Protection
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
            this.radSpreadsheet1 = new Telerik.WinControls.UI.RadSpreadsheet();
            this.protectSheetButton = new Telerik.WinControls.UI.RadButton();
            this.saveSheetButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protectSheetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveSheetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Controls.Add(this.saveSheetButton);
            this.settingsPanel.Controls.Add(this.protectSheetButton);
            this.settingsPanel.Location = new System.Drawing.Point(1153, 112);
            this.settingsPanel.Size = new System.Drawing.Size(230, 126);
            this.settingsPanel.Controls.SetChildIndex(this.protectSheetButton, 0);
            this.settingsPanel.Controls.SetChildIndex(this.saveSheetButton, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            //
            // radSpreadsheet1
            // 
            this.radSpreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSpreadsheet1.Location = new System.Drawing.Point(0, 0);
            this.radSpreadsheet1.Name = "radSpreadsheet1";
            this.radSpreadsheet1.Size = new System.Drawing.Size(1467, 990);
            this.radSpreadsheet1.TabIndex = 2;
            this.radSpreadsheet1.Text = "radSpreadsheet1";
            // 
            // protectSheetButton
            // 
            this.protectSheetButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.protectSheetButton.Location = new System.Drawing.Point(10, 56);
            this.protectSheetButton.Name = "protectSheetButton";
            this.protectSheetButton.Size = new System.Drawing.Size(210, 24);
            this.protectSheetButton.TabIndex = 1;
            this.protectSheetButton.Text = "Protect sheet";
            this.protectSheetButton.Click += new System.EventHandler(this.protectSheetButton_Click);
            // 
            // saveSheetButton
            // 
            this.saveSheetButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveSheetButton.Location = new System.Drawing.Point(10, 86);
            this.saveSheetButton.Name = "saveSheetButton";
            this.saveSheetButton.Size = new System.Drawing.Size(210, 24);
            this.saveSheetButton.TabIndex = 2;
            this.saveSheetButton.Text = "Save File";
            this.saveSheetButton.Click += new System.EventHandler(this.saveSheetButton_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.AutoSize = false;
            this.radLabel1.Location = new System.Drawing.Point(10, 32);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(210, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Tag = "NotAutoSized";
            this.radLabel1.Text = "<html>The password is <em>telerik</em>.</html>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radSpreadsheet1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1477, 1000);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radSpreadsheet1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protectSheetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveSheetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSpreadsheet radSpreadsheet1;
        private Telerik.WinControls.UI.RadButton saveSheetButton;
        private Telerik.WinControls.UI.RadButton protectSheetButton;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}