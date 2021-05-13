namespace Telerik.Examples.WinControls.PageView.StripView.AddNewItem
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
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.stripAlignCombo = new Telerik.WinControls.UI.RadDropDownList();
            this.newItemVisibilityCombo = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.shrinkItemsCheck = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripAlignCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newItemVisibilityCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrinkItemsCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.shrinkItemsCheck);
            this.settingsPanel.Controls.Add(this.newItemVisibilityCombo);
            this.settingsPanel.Controls.Add(this.radLabel2);
            this.settingsPanel.Controls.Add(this.stripAlignCombo);
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Location = new System.Drawing.Point(1068, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 443);

            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.stripAlignCombo, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.newItemVisibilityCombo, 0);
            this.settingsPanel.Controls.SetChildIndex(this.shrinkItemsCheck, 0);
            // 
            // radPageView1
            // 
            this.radPageView1.Location = new System.Drawing.Point(20, 20);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.Size = new System.Drawing.Size(640, 328);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "radPageView1";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(10, 85);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(61, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Strip Align:";
            // 
            // stripAlignCombo
            // 
            this.stripAlignCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stripAlignCombo.DropDownAnimationEnabled = false;
            this.stripAlignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.stripAlignCombo.Location = new System.Drawing.Point(10, 107);
            this.stripAlignCombo.Name = "stripAlignCombo";
            this.stripAlignCombo.Size = new System.Drawing.Size(180, 20);
            this.stripAlignCombo.TabIndex = 3;
          
            // 
            // newItemVisibilityCombo
            // 
            this.newItemVisibilityCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newItemVisibilityCombo.DropDownAnimationEnabled = false;
            this.newItemVisibilityCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.newItemVisibilityCombo.Location = new System.Drawing.Point(10, 59);
            this.newItemVisibilityCombo.Name = "newItemVisibilityCombo";
            this.newItemVisibilityCombo.Size = new System.Drawing.Size(180, 20);
            this.newItemVisibilityCombo.TabIndex = 5;
         
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(10, 37);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(102, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "New Item Visibility:";
            // 
            // shrinkItemsCheck
            // 
            this.shrinkItemsCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shrinkItemsCheck.Location = new System.Drawing.Point(10, 142);
            this.shrinkItemsCheck.Name = "shrinkItemsCheck";
            this.shrinkItemsCheck.Size = new System.Drawing.Size(82, 18);
            this.shrinkItemsCheck.TabIndex = 6;
            this.shrinkItemsCheck.Text = "Shrink Items";
         
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPageView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1029, 755);
            this.Controls.SetChildIndex(this.radPageView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripAlignCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newItemVisibilityCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrinkItemsCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadDropDownList stripAlignCombo;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList newItemVisibilityCombo;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadCheckBox shrinkItemsCheck;
    }
}
