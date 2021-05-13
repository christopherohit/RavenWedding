namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.Localization
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
            this.radVirtualGrid1 = new Telerik.WinControls.UI.RadVirtualGrid();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButtonGerman = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonGerman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radVirtualGrid1
            // 
            this.radVirtualGrid1.Location = new System.Drawing.Point(24, 22);
            this.radVirtualGrid1.MasterViewInfo.RowCount = 1000;
            this.radVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radVirtualGrid1.Name = "radVirtualGrid1";
            this.radVirtualGrid1.Size = new System.Drawing.Size(870, 512);
            this.radVirtualGrid1.TabIndex = 0;
            this.radVirtualGrid1.Text = "radVirtualGrid1";
            this.radVirtualGrid1.CellValueNeeded += new Telerik.WinControls.UI.VirtualGridCellValueNeededEventHandler(this.radVirtualGrid1_CellValueNeeded);
            this.radVirtualGrid1.CellFormatting += new Telerik.WinControls.UI.VirtualGridCellElementEventHandler(this.radVirtualGrid1_CellFormatting);
            this.radVirtualGrid1.SortChanged += new Telerik.WinControls.UI.VirtualGridEventHandler(this.radVirtualGrid1_SortChanged);
            this.radVirtualGrid1.FilterChanged += new Telerik.WinControls.UI.VirtualGridEventHandler(this.radVirtualGrid1_FilterChanged);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radRadioButton2);
            this.radGroupBox1.Controls.Add(this.radRadioButtonGerman);
            this.radGroupBox1.HeaderText = "Choose Language";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 33);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(210, 83);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Choose Language";
            this.radGroupBox1.UseMnemonic = false;
            // 
            // radRadioButton1
            // 
            this.radRadioButtonGerman.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButtonGerman.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radRadioButtonGerman.Location = new System.Drawing.Point(5, 45);
            this.radRadioButtonGerman.Name = "radRadioButton1";
            this.radRadioButtonGerman.Size = new System.Drawing.Size(60, 18);
            this.radRadioButtonGerman.TabIndex = 0;
            this.radRadioButtonGerman.Text = "German";
            this.radRadioButtonGerman.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton2.Location = new System.Drawing.Point(5, 21);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(56, 18);
            this.radRadioButton2.TabIndex = 0;
            this.radRadioButton2.TabStop = false;
            this.radRadioButton2.Text = "English";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radVirtualGrid1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1881, 1096);
            this.Controls.SetChildIndex(this.radVirtualGrid1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonGerman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadVirtualGrid radVirtualGrid1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonGerman;
    }
}