namespace Telerik.Examples.WinControls.GanttView.CustomTimeline
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
            Telerik.WinControls.UI.GanttViewTextViewColumn ganttViewTextViewColumn1 = new Telerik.WinControls.UI.GanttViewTextViewColumn();
            Telerik.WinControls.UI.GanttViewTextViewColumn ganttViewTextViewColumn2 = new Telerik.WinControls.UI.GanttViewTextViewColumn();
            Telerik.WinControls.UI.GanttViewTextViewColumn ganttViewTextViewColumn3 = new Telerik.WinControls.UI.GanttViewTextViewColumn();
            Telerik.WinControls.UI.GanttViewTextViewColumn ganttViewTextViewColumn4 = new Telerik.WinControls.UI.GanttViewTextViewColumn();
            this.radGanttView1 = new Telerik.WinControls.UI.RadGanttView();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGanttView1
            // 
            ganttViewTextViewColumn1.FieldName = "Title";
            ganttViewTextViewColumn1.HeaderText = "War";
            ganttViewTextViewColumn1.Name = "Title";
            ganttViewTextViewColumn1.Width = 300;
            ganttViewTextViewColumn2.FieldName = "Start";
            ganttViewTextViewColumn2.FormatString = "{0:dd.MM.yyyy}";
            ganttViewTextViewColumn2.HeaderText = "Start";
            ganttViewTextViewColumn2.Name = "Start";
            ganttViewTextViewColumn2.Width = 75;
            ganttViewTextViewColumn3.FieldName = "End";
            ganttViewTextViewColumn3.FormatString = "{0:dd.MM.yyyy}";
            ganttViewTextViewColumn3.HeaderText = "End";
            ganttViewTextViewColumn3.Name = "End";
            ganttViewTextViewColumn3.Width = 75;
            ganttViewTextViewColumn4.FieldName = "Casualties";
            ganttViewTextViewColumn4.HeaderText = "Casualties";
            ganttViewTextViewColumn4.Name = "Casualties";
            ganttViewTextViewColumn4.Width = 75;
            this.radGanttView1.Columns.AddRange(new Telerik.WinControls.UI.GanttViewTextViewColumn[] {
            ganttViewTextViewColumn1,
            ganttViewTextViewColumn2,
            ganttViewTextViewColumn3,
            ganttViewTextViewColumn4});
            this.radGanttView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGanttView1.Location = new System.Drawing.Point(0, 0);
            this.radGanttView1.Name = "radGanttView1";
            this.radGanttView1.Ratio = 0.3648276F;
            this.radGanttView1.ReadOnly = true;
            this.radGanttView1.Size = new System.Drawing.Size(1158, 698);
            this.radGanttView1.SplitterWidth = 7;
            this.radGanttView1.TabIndex = 0;
            this.radGanttView1.Text = "radGanttView1";
            ((Telerik.WinControls.UI.RadGanttViewElement)(this.radGanttView1.GetChildAt(0))).SplitterWidth = 7;
            ((Telerik.WinControls.UI.RadGanttViewElement)(this.radGanttView1.GetChildAt(0))).ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGanttView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1168, 708);
            this.Controls.SetChildIndex(this.radGanttView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGanttView radGanttView1;
    }
}