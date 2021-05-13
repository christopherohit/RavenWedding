namespace Telerik.Examples.WinControls.GanttView.MSProjectImport
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
            this.radGanttView1 = new Telerik.WinControls.UI.RadGanttView();
            this.radGroupBoxSource = new Telerik.WinControls.UI.RadGroupBox();
            this.radListControlSources = new Telerik.WinControls.UI.RadListControl();

            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlSources)).BeginInit();
            this.radGroupBoxSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // radGanttView1
            // 
            this.radGanttView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGanttView1.Location = new System.Drawing.Point(0, 0);
            this.radGanttView1.Name = "radGanttView1";
            this.radGanttView1.Size = new System.Drawing.Size(1004, 600);
            this.radGanttView1.TabIndex = 0;
            this.radGanttView1.Text = "radGanttView1";
            this.radGanttView1.ThemeName = "TelerikMetroBlue";
            this.radGanttView1.Ratio = 0.3823065f;
            this.radGanttView1.GanttViewElement.AllowDefaultContextMenu = false;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBoxSource);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(973, 1);
            this.settingsPanel.Size = new System.Drawing.Size(303, 747);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxSource, 0);
            // 
            // radGroupBoxColumns
            // 
            this.radGroupBoxSource.HeaderText = "Source";
            this.radGroupBoxSource.Location = new System.Drawing.Point(15, 6);
            this.radGroupBoxSource.Name = "radGroupBoxColumns";
            this.radGroupBoxSource.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBoxSource.Size = new System.Drawing.Size(115, 298);
            this.radGroupBoxSource.TabIndex = 1;
            this.radGroupBoxSource.Text = "Source";
            this.radGroupBoxSource.Controls.Add(this.radListControlSources);
            //
            // radListControlSources
            //
            this.radListControlSources.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 651);
            this.Controls.Add(this.radGanttView1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.Text = "RadGanttViewExample";
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlSources)).EndInit();
            this.radGroupBoxSource.ResumeLayout(false);
            this.radGroupBoxSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Telerik.WinControls.UI.RadGanttView radGanttView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxSource;
        private Telerik.WinControls.UI.RadListControl radListControlSources;
    }
}

