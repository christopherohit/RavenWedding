namespace Telerik.Examples.WinControls.ImageEditor.FirstLook
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
            this.radImageEditor1 = new Telerik.WinControls.UI.RadImageEditor();

            ((System.ComponentModel.ISupportInitialize)(this.radImageEditor1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGanttView1
            // 
            this.radImageEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radImageEditor1.Location = new System.Drawing.Point(0, 0);
            this.radImageEditor1.Name = "radImageEditor1";
            this.radImageEditor1.Size = new System.Drawing.Size(1004, 600);
            this.radImageEditor1.TabIndex = 0;
            this.radImageEditor1.Text = "radImageEditor1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1016, 651);
            this.Controls.Add(this.radImageEditor1);
            this.Name = "Form1";
            this.Text = "ImageEditor";
            // 
            // 
            // 
            ((System.ComponentModel.ISupportInitialize)(this.radImageEditor1)).EndInit();
            this.ResumeLayout();
        }

        #endregion

        private Telerik.WinControls.UI.RadImageEditor radImageEditor1;
    }
}

