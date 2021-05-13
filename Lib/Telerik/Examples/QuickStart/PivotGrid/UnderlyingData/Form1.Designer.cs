namespace Telerik.Examples.WinControls.PivotGrid.UnderlyingData
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
            this.radPivotGrid1 = new Telerik.WinControls.UI.RadPivotGrid();
            this.radPivotFieldList1 = new Telerik.WinControls.UI.RadPivotFieldList();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPivotGrid1
            // 
            this.radPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPivotGrid1.Location = new System.Drawing.Point(0, 0);
            this.radPivotGrid1.Name = "radPivotGrid1";
            this.radPivotGrid1.Size = new System.Drawing.Size(1232, 1006);
            this.radPivotGrid1.TabIndex = 0;
            this.radPivotGrid1.Text = "radPivotGrid1";
            // 
            // radPivotFieldList1
            // 
            this.radPivotFieldList1.AssociatedPivotGrid = this.radPivotGrid1;
            this.radPivotFieldList1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPivotFieldList1.Location = new System.Drawing.Point(1232, 0);
            this.radPivotFieldList1.MinimumSize = new System.Drawing.Size(225, 305);
            this.radPivotFieldList1.Name = "radPivotFieldList1";
            this.radPivotFieldList1.Size = new System.Drawing.Size(258, 1006);
            this.radPivotFieldList1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPivotGrid1);
            this.Controls.Add(this.radPivotFieldList1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1500, 1016);
            this.Controls.SetChildIndex(this.radPivotFieldList1, 0);
            this.Controls.SetChildIndex(this.radPivotGrid1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPivotGrid radPivotGrid1;
        private Telerik.WinControls.UI.RadPivotFieldList radPivotFieldList1;
    }
}
