namespace Telerik.Examples.WinControls.Calendar.ReadOnlyView
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
            this.radCheckReadOnly = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckReadOnly)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckReadOnly);
            this.settingsPanel.Location = new System.Drawing.Point(895, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 694);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckReadOnly, 0);
            // 
            // radCalendar1
            // 
            this.radCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radCalendar1.FocusedDate = new System.DateTime(2013, 3, 13, 0, 0, 0, 0);
            this.radCalendar1.ForeColor = System.Drawing.Color.Black;
            this.radCalendar1.Location = new System.Drawing.Point(0, 0);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.ReadOnly = true;
            this.radCalendar1.Size = new System.Drawing.Size(288, 229);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.ZoomFactor = 1.2F;
            // 
            // radCheckReadOnly
            // 
            this.radCheckReadOnly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckReadOnly.Location = new System.Drawing.Point(10, 6);
            this.radCheckReadOnly.Name = "radCheckReadOnly";
            this.radCheckReadOnly.Size = new System.Drawing.Size(117, 18);
            this.radCheckReadOnly.TabIndex = 1;
            this.radCheckReadOnly.Text = "Read-only calendar";
            this.radCheckReadOnly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radCalendar1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1170, 754);
            this.Controls.SetChildIndex(this.radCalendar1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckReadOnly)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadCheckBox radCheckReadOnly;
	}
}