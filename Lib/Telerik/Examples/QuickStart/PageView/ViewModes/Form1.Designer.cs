namespace Telerik.Examples.WinControls.PageView.ViewModes
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.viewModeCombo = new Telerik.WinControls.UI.RadDropDownList();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModeCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.viewModeCombo);
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Location = new System.Drawing.Point(1002, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 536);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.viewModeCombo, 0);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(10, 37);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(64, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "View Mode:";
            // 
            // viewModeCombo
            // 
            this.viewModeCombo.AllowShowFocusCues = false;
            this.viewModeCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viewModeCombo.Location = new System.Drawing.Point(10, 59);
            this.viewModeCombo.Name = "viewModeCombo";
            // 
            // 
            // 
            this.viewModeCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.viewModeCombo.Size = new System.Drawing.Size(180, 20);
            this.viewModeCombo.TabIndex = 2;
            this.viewModeCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radPageView1
            // 
            this.radPageView1.Location = new System.Drawing.Point(20, 20);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.Size = new System.Drawing.Size(519, 419);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "radPageView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(519, 419);
            this.Controls.Add(this.radPageView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1384, 977);
            this.Controls.SetChildIndex(this.radPageView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModeCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList viewModeCombo;
        private Telerik.WinControls.UI.RadPageView radPageView1;
    }
}
