namespace Telerik.Examples.WinControls.TreeView.Selection
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
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radCheckBoxAllowMultiSelect = new Telerik.WinControls.UI.RadCheckBox();
            this.radButtonSelectAll = new Telerik.WinControls.UI.RadButton();
            this.radButtonClearSelection = new Telerik.WinControls.UI.RadButton();
            this.radButtonToggleSelection = new Telerik.WinControls.UI.RadButton();
            this.radCheckBoxAllowKeyboardSelecttion = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAllowMultiSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSelectAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonClearSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonToggleSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAllowKeyboardSelecttion)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBoxAllowKeyboardSelecttion);
            this.settingsPanel.Controls.Add(this.radButtonToggleSelection);
            this.settingsPanel.Controls.Add(this.radButtonClearSelection);
            this.settingsPanel.Controls.Add(this.radButtonSelectAll);
            this.settingsPanel.Controls.Add(this.radCheckBoxAllowMultiSelect);
            this.settingsPanel.Location = new System.Drawing.Point(982, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 830);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxAllowMultiSelect, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radButtonSelectAll, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radButtonClearSelection, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radButtonToggleSelection, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxAllowKeyboardSelecttion, 0);
            // 
            // radTreeView1
            // 
            this.radTreeView1.AccessibleName = "RadTreeView";
            this.radTreeView1.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radTreeView1.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.radTreeView1.ItemHeight = 27;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(246, 990);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            // 
            // radCheckBoxAllowMultiSelect
            // 
            this.radCheckBoxAllowMultiSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxAllowMultiSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxAllowMultiSelect.Location = new System.Drawing.Point(10, 38);
            this.radCheckBoxAllowMultiSelect.Name = "radCheckBoxAllowMultiSelect";
            this.radCheckBoxAllowMultiSelect.Size = new System.Drawing.Size(139, 18);
            this.radCheckBoxAllowMultiSelect.TabIndex = 1;
            this.radCheckBoxAllowMultiSelect.Text = "Allow multiple selection";
            this.radCheckBoxAllowMultiSelect.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radButtonSelectAll
            // 
            this.radButtonSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonSelectAll.Location = new System.Drawing.Point(10, 63);
            this.radButtonSelectAll.Name = "radButtonSelectAll";
            this.radButtonSelectAll.Size = new System.Drawing.Size(180, 24);
            this.radButtonSelectAll.TabIndex = 2;
            this.radButtonSelectAll.Text = "Select All";
            // 
            // radButtonClearSelection
            // 
            this.radButtonClearSelection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonClearSelection.Location = new System.Drawing.Point(10, 94);
            this.radButtonClearSelection.Name = "radButtonClearSelection";
            this.radButtonClearSelection.Size = new System.Drawing.Size(180, 24);
            this.radButtonClearSelection.TabIndex = 3;
            this.radButtonClearSelection.Text = "Clear Selection";
            // 
            // radButtonToggleSelection
            // 
            this.radButtonToggleSelection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonToggleSelection.Location = new System.Drawing.Point(10, 125);
            this.radButtonToggleSelection.Name = "radButtonToggleSelection";
            this.radButtonToggleSelection.Size = new System.Drawing.Size(180, 24);
            this.radButtonToggleSelection.TabIndex = 4;
            this.radButtonToggleSelection.Text = "Toggle Selection";
            // 
            // radCheckBoxAllowKeyboardSelecttion
            // 
            this.radCheckBoxAllowKeyboardSelecttion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxAllowKeyboardSelecttion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxAllowKeyboardSelecttion.Location = new System.Drawing.Point(10, 155);
            this.radCheckBoxAllowKeyboardSelecttion.Name = "radCheckBoxAllowKeyboardSelecttion";
            this.radCheckBoxAllowKeyboardSelecttion.Size = new System.Drawing.Size(145, 18);
            this.radCheckBoxAllowKeyboardSelecttion.TabIndex = 2;
            this.radCheckBoxAllowKeyboardSelecttion.Text = "Keyboard Search Enabled";
            this.radCheckBoxAllowKeyboardSelecttion.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxAllowKeyboardSelecttion.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxAllowKeyboardSelection_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radTreeView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1433, 1000);
            this.Controls.SetChildIndex(this.radTreeView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAllowMultiSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSelectAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonClearSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonToggleSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAllowKeyboardSelecttion)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadButton radButtonToggleSelection;
        private Telerik.WinControls.UI.RadButton radButtonClearSelection;
        private Telerik.WinControls.UI.RadButton radButtonSelectAll;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxAllowMultiSelect;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxAllowKeyboardSelecttion;
	}
}