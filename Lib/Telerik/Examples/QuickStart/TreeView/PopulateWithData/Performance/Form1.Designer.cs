namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.Performance
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
            this.radTreeViewDemo = new Telerik.WinControls.UI.RadTreeView();
            this.radBtnLoad = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeViewDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radBtnLoad);
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Controls.Add(this.radProgressBar1);
            this.settingsPanel.Location = new System.Drawing.Point(982, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 830);
            this.settingsPanel.Controls.SetChildIndex(this.radProgressBar1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radBtnLoad, 0);
            // 
            // radTreeViewDemo
            // 
            this.radTreeViewDemo.Dock = System.Windows.Forms.DockStyle.Left;
            this.radTreeViewDemo.Location = new System.Drawing.Point(0, 0);
            this.radTreeViewDemo.Name = "radTreeViewDemo";
            this.radTreeViewDemo.Size = new System.Drawing.Size(246, 659);
            this.radTreeViewDemo.SpacingBetweenNodes = -1;
            this.radTreeViewDemo.TabIndex = 0;
            this.radTreeViewDemo.Text = "radTreeView1";
            // 
            // radBtnLoad
            // 
            this.radBtnLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radBtnLoad.Location = new System.Drawing.Point(10, 37);
            this.radBtnLoad.Name = "radBtnLoad";
            this.radBtnLoad.Size = new System.Drawing.Size(180, 26);
            this.radBtnLoad.TabIndex = 2;
            this.radBtnLoad.Text = "Load 50,000 nodes";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(10, 87);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(73, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Time Elapsed:";
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radProgressBar1.Location = new System.Drawing.Point(10, 69);
            this.radProgressBar1.Maximum = 50000;
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.Size = new System.Drawing.Size(180, 12);
            this.radProgressBar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radTreeViewDemo);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1108, 669);
            this.Controls.SetChildIndex(this.radTreeViewDemo, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeViewDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadTreeView radTreeViewDemo;
        private Telerik.WinControls.UI.RadButton radBtnLoad;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
	}
}