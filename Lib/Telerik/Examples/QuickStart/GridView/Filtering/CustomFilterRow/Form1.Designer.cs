namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.settingsPanel = new Telerik.WinControls.UI.RadPanel();
			this.btnSpy = new Telerik.WinControls.UI.RadButton();
			this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
			((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSpy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// settingsPanel
			// 
			this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsPanel.AutoScroll = true;
			this.settingsPanel.BackColor = System.Drawing.Color.Transparent;
			this.settingsPanel.Controls.Add(this.btnSpy);
			this.settingsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.settingsPanel.Location = new System.Drawing.Point(103, 19);
			this.settingsPanel.Name = "settingsPanel";
			this.settingsPanel.Size = new System.Drawing.Size(0, 0);
			this.settingsPanel.TabIndex = 0;
			this.settingsPanel.Visible = false;
			// 
			// btnSpy
			// 
			this.btnSpy.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSpy.Image = ((System.Drawing.Image)(resources.GetObject("btnSpy.Image")));
			this.btnSpy.Location = new System.Drawing.Point(-54, 7);
			this.btnSpy.Name = "btnSpy";
			this.btnSpy.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			// 
			// 
			// 
			this.btnSpy.RootElement.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.btnSpy.Size = new System.Drawing.Size(120, 24);
			this.btnSpy.TabIndex = 0;
			this.btnSpy.Text = "RadControl Spy ";
			this.btnSpy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// radGridView1
			// 
			this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radGridView1.Location = new System.Drawing.Point(0, 0);
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.Size = new System.Drawing.Size(1217, 526);
			this.radGridView1.TabIndex = 1;
			this.radGridView1.Text = "radGridView1";
            this.radGridView1.CreateRowInfo += new Telerik.WinControls.UI.GridViewCreateRowInfoEventHandler(this.MasterTemplate_CreateRowInfo);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.radGridView1);
			this.Name = "Form1";
			this.Size = new System.Drawing.Size(1217, 526);
			((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSpy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private new Telerik.WinControls.UI.RadPanel settingsPanel;
        private Telerik.WinControls.UI.RadButton btnSpy;
    }
}
