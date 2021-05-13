namespace Telerik.Examples.WinControls.PageView.StripView.CustomTheme
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
            this.enableAnimationCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.animationTypeCombo = new Telerik.WinControls.UI.RadDropDownList();
            this.shrinkItemsCheck = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enableAnimationCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationTypeCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrinkItemsCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.shrinkItemsCheck);
            this.settingsPanel.Controls.Add(this.animationTypeCombo);
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Controls.Add(this.enableAnimationCheck);
            this.settingsPanel.Location = new System.Drawing.Point(999, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 524);        
            this.settingsPanel.Controls.SetChildIndex(this.enableAnimationCheck, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.animationTypeCombo, 0);
            this.settingsPanel.Controls.SetChildIndex(this.shrinkItemsCheck, 0);
            // 
            // enableAnimationCheck
            // 
            this.enableAnimationCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enableAnimationCheck.Location = new System.Drawing.Point(10, 38);
            this.enableAnimationCheck.Name = "enableAnimationCheck";
            this.enableAnimationCheck.Size = new System.Drawing.Size(139, 18);
            this.enableAnimationCheck.TabIndex = 1;
            this.enableAnimationCheck.Text = "Enable Scroll Animation";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(10, 62);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(118, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Scroll Animation Type:";
            // 
            // animationTypeCombo
            // 
            this.animationTypeCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.animationTypeCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.animationTypeCombo.Location = new System.Drawing.Point(10, 84);
            this.animationTypeCombo.Name = "animationTypeCombo";
            // 
            // 
            // 
            this.animationTypeCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.animationTypeCombo.Size = new System.Drawing.Size(180, 20);
            this.animationTypeCombo.TabIndex = 3;
            // 
            // shrinkItemsCheck
            // 
            this.shrinkItemsCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shrinkItemsCheck.Location = new System.Drawing.Point(10, 122);
            this.shrinkItemsCheck.Name = "shrinkItemsCheck";
            this.shrinkItemsCheck.Size = new System.Drawing.Size(82, 18);
            this.shrinkItemsCheck.TabIndex = 4;
            this.shrinkItemsCheck.Text = "Shrink Items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1244, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enableAnimationCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationTypeCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrinkItemsCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCheckBox enableAnimationCheck;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox shrinkItemsCheck;
        private Telerik.WinControls.UI.RadDropDownList animationTypeCombo;
    }
}
