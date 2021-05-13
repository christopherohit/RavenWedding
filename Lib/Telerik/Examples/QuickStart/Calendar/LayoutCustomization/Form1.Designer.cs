namespace Telerik.Examples.WinControls.Calendar.LayoutCustomization
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
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.radGroupDisplay = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadio7Cols = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadio21Cols = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadio14Cols = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupDisplay)).BeginInit();
            this.radGroupDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadio7Cols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadio21Cols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadio14Cols)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(972, 1);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupDisplay);
            this.settingsPanel.PanelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(252, 339);
            this.settingsPanel.Size = new System.Drawing.Size(252, 339);
            // 
            // radCalendar1
            // 
            this.radCalendar1.FocusedDate = new System.DateTime(2013, 3, 13, 0, 0, 0, 0);
            this.radCalendar1.ForeColor = System.Drawing.Color.Black;
            this.radCalendar1.HeaderHeight = 23;
            this.radCalendar1.HeaderWidth = 23;
            this.radCalendar1.Location = new System.Drawing.Point(20, 20);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.Size = new System.Drawing.Size(287, 241);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.ZoomFactor = 1.2F;
            // 
            // radGroupDisplay
            // 
            this.radGroupDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupDisplay.Controls.Add(this.radRadio7Cols);
            this.radGroupDisplay.Controls.Add(this.radRadio21Cols);
            this.radGroupDisplay.Controls.Add(this.radRadio14Cols);
            this.radGroupDisplay.HeaderText = "Display Options";
            this.radGroupDisplay.Location = new System.Drawing.Point(5, 57);
            this.radGroupDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radGroupDisplay.Name = "radGroupDisplay";
            this.radGroupDisplay.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.radGroupDisplay.Size = new System.Drawing.Size(227, 143);
            this.radGroupDisplay.TabIndex = 2;
            this.radGroupDisplay.Text = "Display Options";
            // 
            // radRadio7Cols
            // 
            this.radRadio7Cols.Location = new System.Drawing.Point(23, 42);
            this.radRadio7Cols.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRadio7Cols.Name = "radRadio7Cols";
            this.radRadio7Cols.Size = new System.Drawing.Size(151, 22);
            this.radRadio7Cols.TabIndex = 3;
            this.radRadio7Cols.Text = "7 columns by 6 rows";
            // 
            // radRadio21Cols
            // 
            this.radRadio21Cols.Location = new System.Drawing.Point(23, 96);
            this.radRadio21Cols.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRadio21Cols.Name = "radRadio21Cols";
            this.radRadio21Cols.Size = new System.Drawing.Size(159, 22);
            this.radRadio21Cols.TabIndex = 3;
            this.radRadio21Cols.Text = "21 coulmns by 2 rows";
            // 
            // radRadio14Cols
            // 
            this.radRadio14Cols.Location = new System.Drawing.Point(23, 69);
            this.radRadio14Cols.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRadio14Cols.Name = "radRadio14Cols";
            this.radRadio14Cols.Size = new System.Drawing.Size(159, 22);
            this.radRadio14Cols.TabIndex = 3;
            this.radRadio14Cols.Text = "14 coulmns by 3 rows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radCalendar1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2349, 1464);
            this.Controls.SetChildIndex(this.radCalendar1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupDisplay)).EndInit();
            this.radGroupDisplay.ResumeLayout(false);
            this.radGroupDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadio7Cols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadio21Cols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadio14Cols)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadGroupBox radGroupDisplay;
        private Telerik.WinControls.UI.RadRadioButton radRadio7Cols;
        private Telerik.WinControls.UI.RadRadioButton radRadio14Cols;
        private Telerik.WinControls.UI.RadRadioButton radRadio21Cols;


	}
}