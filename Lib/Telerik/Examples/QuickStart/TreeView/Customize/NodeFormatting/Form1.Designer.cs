namespace Telerik.Examples.WinControls.TreeView.Customize.NodeFormatting
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
            if (this.boldFont != null)
            {
                this.boldFont.Dispose();
                this.boldFont = null;
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
            this.btnSpy = new Telerik.WinControls.UI.RadButton();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radCheckBoxFormatting = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFormatting)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBoxFormatting);
            this.settingsPanel.Location = new System.Drawing.Point(982, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 830);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxFormatting, 0);
            // 
            // btnSpy
            // 
            this.btnSpy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpy.Image = ((System.Drawing.Image)(resources.GetObject("btnSpy.Image")));
            this.btnSpy.Location = new System.Drawing.Point(10, 7);
            this.btnSpy.Name = "btnSpy";
            this.btnSpy.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            // 
            // 
            // 
            this.btnSpy.RootElement.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSpy.Size = new System.Drawing.Size(180, 24);
            this.btnSpy.TabIndex = 0;
            this.btnSpy.Text = "RadControl Spy ";
            this.btnSpy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radTreeView1
            // 
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(420, 415);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 0;
            // 
            // radCheckBoxFormatting
            // 
            this.radCheckBoxFormatting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxFormatting.Location = new System.Drawing.Point(10, 38);
            this.radCheckBoxFormatting.Name = "radCheckBoxFormatting";
            this.radCheckBoxFormatting.Size = new System.Drawing.Size(110, 18);
            this.radCheckBoxFormatting.TabIndex = 1;
            this.radCheckBoxFormatting.Text = "Enable formatting";
            this.radCheckBoxFormatting.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radTreeView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1029, 602);
            this.Controls.SetChildIndex(this.radTreeView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFormatting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnSpy;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxFormatting;
    }
}
