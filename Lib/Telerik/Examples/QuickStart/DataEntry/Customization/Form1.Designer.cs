namespace Telerik.Examples.WinControls.DataEntry.Customization
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
            this.radDataEntry1 = new Telerik.WinControls.UI.RadDataEntry();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataEntry1)).BeginInit();
            this.radDataEntry1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(571, 3);
            // 
            // radDataEntry1
            // 
            this.radDataEntry1.AutoSize = false;
            this.radDataEntry1.FlowDirection =  System.Windows.Forms.FlowDirection.LeftToRight;
            this.radDataEntry1.ItemDefaultSize = new System.Drawing.Size(460, 25);
            this.radDataEntry1.ItemSpace = 10;
            this.radDataEntry1.Location = new System.Drawing.Point(0, 0);
            this.radDataEntry1.Name = "radDataEntry1";
            this.radDataEntry1.ShowValidationPanel = true;
            // 
            // radDataEntry1.PanelContainer
            // 
            this.radDataEntry1.PanelContainer.Size = new System.Drawing.Size(487, 362);
            this.radDataEntry1.ShowValidationPanel = false;
            this.radDataEntry1.Size = new System.Drawing.Size(489, 364);
            this.radDataEntry1.TabIndex = 2;
            this.radDataEntry1.Text = "radDataEntry1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radDataEntry1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1243, 775);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radDataEntry1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataEntry1)).EndInit();
            this.radDataEntry1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDataEntry radDataEntry1;
    }
}