namespace Telerik.Examples.WinControls.Integration.Magnifier
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
            this.radToggleButton1 = new Telerik.WinControls.UI.RadToggleButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.magnifier1 = new Telerik.Examples.WinControls.Integration.Magnifier.Magnifier();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnifier1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 818);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radToggleButton1
            // 
            this.radToggleButton1.Location = new System.Drawing.Point(16, 72);
            this.radToggleButton1.Name = "radToggleButton1";
            this.radToggleButton1.Size = new System.Drawing.Size(135, 23);
            this.radToggleButton1.TabIndex = 3;
            this.radToggleButton1.Text = "Toggle items\' opacity";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radSpinEditor1);
            this.radGroupBox1.Controls.Add(this.radToggleButton1);
            this.radGroupBox1.FooterText = "";
            this.radGroupBox1.HeaderText = "Magnifier Options";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 115);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Magnifier Options";
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.DecimalPlaces = 2;
            this.radSpinEditor1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.radSpinEditor1.Location = new System.Drawing.Point(116, 34);
            this.radSpinEditor1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.radSpinEditor1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.radSpinEditor1.Name = "radSpinEditor1";
            // 
            // 
            // 
            this.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditor1.Size = new System.Drawing.Size(44, 20);
            this.radSpinEditor1.TabIndex = 1;
            this.radSpinEditor1.TabStop = false;
            this.radSpinEditor1.Tag = "Right";
            this.radSpinEditor1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.radPanel1.Controls.Add(this.magnifier1);
            this.radPanel1.Location = new System.Drawing.Point(398, 31);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(482, 438);
            this.radPanel1.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(7, 36);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(103, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Magnification level:";
            // 
            // magnifier1
            // 
            this.magnifier1.Columns = 7;
            this.magnifier1.DefaultCellSize = new System.Drawing.Size(56, 56);
            this.magnifier1.Location = new System.Drawing.Point(26, 13);
            this.magnifier1.Name = "magnifier1";
            this.magnifier1.Size = new System.Drawing.Size(429, 411);
            this.magnifier1.TabIndex = 0;
            this.magnifier1.Text = "magnifier1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1308, 506);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnifier1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Magnifier magnifier1;
        private Telerik.WinControls.UI.RadToggleButton radToggleButton1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
	}
}
