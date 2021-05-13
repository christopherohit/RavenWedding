namespace Telerik.Examples.WinControls.Calendar.SpecialDays
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.UI.RadCalendarDay radCalendarDay1 = new Telerik.WinControls.UI.RadCalendarDay();
            Telerik.WinControls.UI.RadCalendarDay radCalendarDay2 = new Telerik.WinControls.UI.RadCalendarDay();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "boss.png");
            this.imageList1.Images.SetKeyName(1, "AnnsBirthday.PNG");
            // 
            // radCalendar1
            // 
            this.radCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radCalendar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCalendar1.FocusedDate = new System.DateTime(2013, 3, 15, 0, 0, 0, 0);
            this.radCalendar1.Location = new System.Drawing.Point(0, 0);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.Size = new System.Drawing.Size(1134, 486);
            radCalendarDay1.Date = new System.DateTime(2013, 3, 10, 0, 0, 0, 0);
            radCalendarDay1.Selectable = false;
            radCalendarDay2.Date = new System.DateTime(2013, 3, 26, 0, 0, 0, 0);
            radCalendarDay2.Selectable = false;
            this.radCalendar1.SpecialDays.Add(radCalendarDay1);
            this.radCalendar1.SpecialDays.Add(radCalendarDay2);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.ZoomFactor = 1.2F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radCalendar1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1144, 489);
            this.Controls.SetChildIndex(this.radCalendar1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadCalendar radCalendar1;
		private System.Windows.Forms.ImageList imageList1;
	}
}