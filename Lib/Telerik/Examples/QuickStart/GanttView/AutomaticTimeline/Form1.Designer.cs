namespace Telerik.Examples.WinControls.GanttView.AutomaticTimeline
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
            this.radGanttView1 = new Telerik.WinControls.UI.RadGanttView();
            this.radGanttView2 = new Telerik.WinControls.UI.RadGanttView();
            this.radTrackBarZoom = new Telerik.WinControls.UI.RadTrackBar();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBarZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.SuspendLayout();
            // 
            // radGanttView1
            // 
            this.radGanttView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radGanttView1.Location = new System.Drawing.Point(12, 259);
            this.radGanttView1.Name = "radGanttView1";
            this.radGanttView1.Ratio = 0.004F;
            this.radGanttView1.Size = new System.Drawing.Size(1420, 81);
            this.radGanttView1.SplitterWidth = 7;
            this.radGanttView1.TabIndex = 0;
            this.radGanttView1.Text = "radGanttView1";
            ((Telerik.WinControls.UI.RadGanttViewElement)(this.radGanttView1.GetChildAt(0))).SplitterWidth = 7;
            ((Telerik.WinControls.UI.GanttViewTextViewElement)(this.radGanttView1.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.GanttViewViewsSplitterElement)(this.radGanttView1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radGanttView2
            // 
            this.radGanttView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radGanttView2.Location = new System.Drawing.Point(12, 454);
            this.radGanttView2.Name = "radGanttView2";
            this.radGanttView2.Ratio = 0.004F;
            this.radGanttView2.Size = new System.Drawing.Size(1420, 80);
            this.radGanttView2.SplitterWidth = 7;
            this.radGanttView2.TabIndex = 0;
            this.radGanttView2.Text = "radGanttView1";
            ((Telerik.WinControls.UI.RadGanttViewElement)(this.radGanttView2.GetChildAt(0))).SplitterWidth = 7;
            ((Telerik.WinControls.UI.GanttViewTextViewElement)(this.radGanttView2.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.GanttViewViewsSplitterElement)(this.radGanttView2.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radTrackBarZoom
            // 
            this.radTrackBarZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radTrackBarZoom.Location = new System.Drawing.Point(21, 630);
            this.radTrackBarZoom.Maximum = 31F;
            this.radTrackBarZoom.Name = "radTrackBarZoom";
            this.radTrackBarZoom.Size = new System.Drawing.Size(1411, 37);
            this.radTrackBarZoom.TabIndex = 1;
            this.radTrackBarZoom.Text = "radTrackBar1";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.radLabel1.Location = new System.Drawing.Point(24, 211);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(220, 37);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Static timeline view";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.radLabel2.Location = new System.Drawing.Point(24, 411);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(283, 37);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Automatic timeline views";
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.radLabel3.Location = new System.Drawing.Point(24, 587);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(75, 37);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Zoom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radTrackBarZoom);
            this.Controls.Add(this.radGanttView2);
            this.Controls.Add(this.radGanttView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1444, 1000);
            this.Controls.SetChildIndex(this.radGanttView1, 0);
            this.Controls.SetChildIndex(this.radGanttView2, 0);
            this.Controls.SetChildIndex(this.radTrackBarZoom, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBarZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGanttView radGanttView1;
        private Telerik.WinControls.UI.RadGanttView radGanttView2;
        private Telerik.WinControls.UI.RadTrackBar radTrackBarZoom;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}