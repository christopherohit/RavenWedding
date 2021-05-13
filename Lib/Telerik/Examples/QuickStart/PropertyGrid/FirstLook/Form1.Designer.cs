using System;
namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
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
            this.surface1 = new Telerik.Examples.WinControls.PropertyGrid.FirstLook.Surface();
            this.radPropertyGrid1 = new Telerik.WinControls.UI.RadPropertyGrid();
            this.radDropDownButton1 = new Telerik.WinControls.UI.RadDropDownButton();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.radButtonRemove = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.surface1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radButtonRemove);
            this.settingsPanel.Controls.Add(this.radDropDownButton1);
            this.settingsPanel.Location = new System.Drawing.Point(729, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 548);
            this.settingsPanel.Controls.SetChildIndex(this.radDropDownButton1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radButtonRemove, 0);
            // 
            // surface1
            // 
            this.surface1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surface1.Location = new System.Drawing.Point(0, 0);
            this.surface1.Name = "surface1";
            this.surface1.Size = new System.Drawing.Size(232, 348);
            this.surface1.TabIndex = 0;
            // 
            // radPropertyGrid1
            // 
            this.radPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPropertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.radPropertyGrid1.Name = "radPropertyGrid1";
            this.radPropertyGrid1.PropertySort = System.Windows.Forms.PropertySort.CategorizedAlphabetical;
            this.radPropertyGrid1.Size = new System.Drawing.Size(231, 348);
            this.radPropertyGrid1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.radPropertyGrid1.TabIndex = 0;
            this.radPropertyGrid1.Text = "radPropertyGrid1";
            this.radPropertyGrid1.ToolbarVisible = true;
            // 
            // radDropDownButton1
            // 
            this.radDropDownButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownButton1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4,
            this.radMenuItem5});
            this.radDropDownButton1.Location = new System.Drawing.Point(10, 42);
            this.radDropDownButton1.Name = "radDropDownButton1";
            this.radDropDownButton1.Size = new System.Drawing.Size(180, 24);
            this.radDropDownButton1.TabIndex = 1;
            this.radDropDownButton1.Text = "Add";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Button";
            this.radMenuItem1.AccessibleName = "Button";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Button";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Label";
            this.radMenuItem2.AccessibleName = "Label";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Label";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Checkbox";
            this.radMenuItem3.AccessibleName = "Checkbox";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Checkbox";
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "Radio Button";
            this.radMenuItem4.AccessibleName = "Radio Button";
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Radio Button";
            this.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.AccessibleDescription = "ScrollBar";
            this.radMenuItem5.AccessibleName = "ScrollBar";
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "ScrollBar";
            this.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.EnableElementShadow = false;
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(700, 500);
            this.radSplitContainer1.SplitterWidth = 4;
            this.radSplitContainer1.TabIndex = 2;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.surface1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(232, 348);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.radPropertyGrid1);
            this.splitPanel2.Location = new System.Drawing.Point(236, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(231, 348);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // radButtonRemove
            // 
            this.radButtonRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonRemove.Location = new System.Drawing.Point(10, 73);
            this.radButtonRemove.Name = "radButtonRemove";
            this.radButtonRemove.Size = new System.Drawing.Size(180, 24);
            this.radButtonRemove.TabIndex = 2;
            this.radButtonRemove.Text = "Remove";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1223, 619);
            this.Controls.SetChildIndex(this.radSplitContainer1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.surface1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Surface surface1;
        private Telerik.WinControls.UI.RadPropertyGrid radPropertyGrid1;
        private Telerik.WinControls.UI.RadDropDownButton radDropDownButton1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadButton radButtonRemove;
    }
}

