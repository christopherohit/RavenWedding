namespace DiagramOrganizationChart
{
    partial class OrgChartForm
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
            this.radDiagram1 = new Telerik.WinControls.UI.RadDiagram();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // radDiagram1
            // 
            this.radDiagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDiagram1.Location = new System.Drawing.Point(0, 0);
            this.radDiagram1.Name = "radDiagram1";
            this.radDiagram1.Size = new System.Drawing.Size(1201, 734);
            this.radDiagram1.TabIndex = 0;
            this.radDiagram1.Text = "radDiagram1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1201, 734);
            this.Controls.Add(this.radDiagram1);
            this.Name = "Form1";
            this.Text = "Organization Chart";
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDiagram radDiagram1;
    }
}

