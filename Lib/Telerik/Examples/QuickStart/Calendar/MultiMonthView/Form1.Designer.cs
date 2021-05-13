namespace Telerik.Examples.WinControls.Calendar.MultiMonthView
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
            this.radGroupRenderDir = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioRows = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioCols = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRenderDir)).BeginInit();
            this.radGroupRenderDir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCols)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupRenderDir);
            this.settingsPanel.Location = new System.Drawing.Point(729, 1);
            this.settingsPanel.Size = new System.Drawing.Size(250, 867);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupRenderDir, 0);
            // 
            // radCalendar1
            // 
            this.radCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radCalendar1.FocusedDate = new System.DateTime(2009, 3, 9, 0, 0, 0, 0);
            this.radCalendar1.ForeColor = System.Drawing.Color.Black;
            this.radCalendar1.Location = new System.Drawing.Point(0, 0);
            this.radCalendar1.MinimumSize = new System.Drawing.Size(443, 406);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radCalendar1.RootElement.MinSize = new System.Drawing.Size(443, 406);
            this.radCalendar1.Size = new System.Drawing.Size(662, 579);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.ZoomFactor = 1.2F;
            // 
            // radGroupRenderDir
            // 
            this.radGroupRenderDir.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupRenderDir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupRenderDir.Controls.Add(this.radRadioRows);
            this.radGroupRenderDir.Controls.Add(this.radRadioCols);
            this.radGroupRenderDir.HeaderText = "Rendering Direction";
            this.radGroupRenderDir.Location = new System.Drawing.Point(10, 6);
            this.radGroupRenderDir.Name = "radGroupRenderDir";
            this.radGroupRenderDir.Size = new System.Drawing.Size(230, 88);
            this.radGroupRenderDir.TabIndex = 5;
            this.radGroupRenderDir.Text = "Rendering Direction";
            // 
            // radRadioRows
            // 
            this.radRadioRows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioRows.Location = new System.Drawing.Point(5, 29);
            this.radRadioRows.Name = "radRadioRows";
            this.radRadioRows.Size = new System.Drawing.Size(98, 18);
            this.radRadioRows.TabIndex = 6;
            this.radRadioRows.Text = "Render In Rows";
            // 
            // radRadioCols
            // 
            this.radRadioCols.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioCols.Location = new System.Drawing.Point(5, 51);
            this.radRadioCols.Name = "radRadioCols";
            this.radRadioCols.Size = new System.Drawing.Size(115, 18);
            this.radRadioCols.TabIndex = 6;
            this.radRadioCols.Text = "Render In Columns";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;        
            this.Controls.Add(this.radCalendar1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1168, 694);
            this.Controls.SetChildIndex(this.radCalendar1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRenderDir)).EndInit();
            this.radGroupRenderDir.ResumeLayout(false);
            this.radGroupRenderDir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCols)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadGroupBox radGroupRenderDir;
        private Telerik.WinControls.UI.RadRadioButton radRadioRows;
        private Telerik.WinControls.UI.RadRadioButton radRadioCols;
	}
}