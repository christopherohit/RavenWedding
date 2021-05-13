namespace Telerik.Examples.WinControls.PivotGrid.ExportToExcelML
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
            this.buttonExport = new Telerik.WinControls.UI.RadButton();
            this.radCheckBoxFlatData = new Telerik.WinControls.UI.RadCheckBox();
            this.radProgressBarExport = new Telerik.WinControls.UI.RadProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFlatData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBarExport)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radProgressBarExport);
            this.settingsPanel.Controls.Add(this.radCheckBoxFlatData);
            this.settingsPanel.Controls.Add(this.buttonExport);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsPanel.Location = new System.Drawing.Point(1107, 0);
            this.settingsPanel.Size = new System.Drawing.Size(286, 831);
            this.settingsPanel.Controls.SetChildIndex(this.buttonExport, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxFlatData, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radProgressBarExport, 0);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(17, 41);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(130, 24);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export";
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // radCheckBoxFlatData
            // 
            this.radCheckBoxFlatData.Location = new System.Drawing.Point(17, 89);
            this.radCheckBoxFlatData.Name = "radCheckBoxFlatData";
            this.radCheckBoxFlatData.Size = new System.Drawing.Size(100, 18);
            this.radCheckBoxFlatData.TabIndex = 3;
            this.radCheckBoxFlatData.Text = "Export Flat Data";
            this.radCheckBoxFlatData.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxFlatData.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxFlatData_ToggleStateChanged);
            // 
            // radProgressBarExport
            // 
            this.radProgressBarExport.Location = new System.Drawing.Point(17, 131);
            this.radProgressBarExport.Name = "radProgressBarExport";
            this.radProgressBarExport.Size = new System.Drawing.Size(130, 24);
            this.radProgressBarExport.TabIndex = 4;
            this.radProgressBarExport.Text = "Export Progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1403, 841);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFlatData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBarExport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton buttonExport;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxFlatData;
        private Telerik.WinControls.UI.RadProgressBar radProgressBarExport;
    }
}