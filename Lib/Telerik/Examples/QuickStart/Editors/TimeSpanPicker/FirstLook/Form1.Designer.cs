namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
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
            this.cinemaProgramLabel = new Telerik.WinControls.UI.RadLabel();
            this.editorsPanel = new Telerik.WinControls.UI.RadPanel();
            this.doubleBufferedTableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.movieDurationLabel = new Telerik.WinControls.UI.RadLabel();
            this.moviesPlayingAfterLabel = new Telerik.WinControls.UI.RadLabel();
            this.minStartTimeTimeSpanPicker = new Telerik.WinControls.UI.RadTimeSpanPicker();
            this.durationTimeSpanPicker = new Telerik.WinControls.UI.RadTimeSpanPicker();
            this.searchMovieLabel = new Telerik.WinControls.UI.RadLabel();
            this.moviesPanel = new Telerik.WinControls.UI.RadPanel();
            this.moviesScrollablePanel = new Telerik.WinControls.UI.RadScrollablePanel();
            this.moviesStartingAfterLabel = new Telerik.WinControls.UI.RadLabel();
            this.editorsScrollablePanel = new Telerik.WinControls.UI.RadScrollablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaProgramLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorsPanel)).BeginInit();
            this.editorsPanel.SuspendLayout();
            this.doubleBufferedTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDurationLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesPlayingAfterLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minStartTimeTimeSpanPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationTimeSpanPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchMovieLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesPanel)).BeginInit();
            this.moviesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesScrollablePanel)).BeginInit();
            this.moviesScrollablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesStartingAfterLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorsScrollablePanel)).BeginInit();
            this.editorsScrollablePanel.PanelContainer.SuspendLayout();
            this.editorsScrollablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.moviesPanel);
            this.radPanelDemoHolder.Controls.Add(this.editorsPanel);
            this.radPanelDemoHolder.Controls.Add(this.cinemaProgramLabel);
            this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(950, 573);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1334, 294);
            // 
            // cinemaProgramLabel
            // 
            this.cinemaProgramLabel.AutoSize = false;
            this.cinemaProgramLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cinemaProgramLabel.Font = new System.Drawing.Font("Segoe UI", 16.5F);
            this.cinemaProgramLabel.Image = global::Telerik.Examples.WinControls.Properties.Resources.cinema_icon;
            this.cinemaProgramLabel.Location = new System.Drawing.Point(0, 0);
            this.cinemaProgramLabel.Name = "cinemaProgramLabel";
            this.cinemaProgramLabel.Size = new System.Drawing.Size(950, 40);
            this.cinemaProgramLabel.TabIndex = 0;
            this.cinemaProgramLabel.Text = "Cinema program for ";
            this.cinemaProgramLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // editorsPanel
            // 
            this.editorsPanel.Controls.Add(this.editorsScrollablePanel);
            this.editorsPanel.Controls.Add(this.searchMovieLabel);
            this.editorsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.editorsPanel.Location = new System.Drawing.Point(0, 40);
            this.editorsPanel.Name = "editorsPanel";
            this.editorsPanel.Size = new System.Drawing.Size(235, 533);
            this.editorsPanel.TabIndex = 1;
            // 
            // doubleBufferedTableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel1.ColumnCount = 1;
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.movieDurationLabel, 0, 2);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.moviesPlayingAfterLabel, 0, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.minStartTimeTimeSpanPicker, 0, 1);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.durationTimeSpanPicker, 0, 3);
            this.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleBufferedTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1";
            this.doubleBufferedTableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.doubleBufferedTableLayoutPanel1.RowCount = 5;
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.doubleBufferedTableLayoutPanel1.Size = new System.Drawing.Size(233, 501);
            this.doubleBufferedTableLayoutPanel1.TabIndex = 1;
            // 
            // movieDurationLabel
            // 
            this.movieDurationLabel.AutoSize = false;
            this.movieDurationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieDurationLabel.Location = new System.Drawing.Point(8, 88);
            this.movieDurationLabel.Name = "movieDurationLabel";
            this.movieDurationLabel.Size = new System.Drawing.Size(217, 34);
            this.movieDurationLabel.TabIndex = 2;
            this.movieDurationLabel.Text = "Minimum movie duration:";
            this.movieDurationLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // moviesPlayingAfterLabel
            // 
            this.moviesPlayingAfterLabel.AutoSize = false;
            this.moviesPlayingAfterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesPlayingAfterLabel.Location = new System.Drawing.Point(8, 8);
            this.moviesPlayingAfterLabel.Name = "moviesPlayingAfterLabel";
            this.moviesPlayingAfterLabel.Size = new System.Drawing.Size(217, 34);
            this.moviesPlayingAfterLabel.TabIndex = 0;
            this.moviesPlayingAfterLabel.Text = "Movies playing after:";
            this.moviesPlayingAfterLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // minStartTimeTimeSpanPicker
            // 
            this.minStartTimeTimeSpanPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minStartTimeTimeSpanPicker.EditMode = Telerik.WinControls.UI.TimeSpanEditMode.Popup;
            this.minStartTimeTimeSpanPicker.EnableNullValueInput = true;
            this.minStartTimeTimeSpanPicker.Format = "hh\':\'mm\' hours\'";
            this.minStartTimeTimeSpanPicker.Location = new System.Drawing.Point(8, 54);
            this.minStartTimeTimeSpanPicker.MinutesStep = 10;
            this.minStartTimeTimeSpanPicker.Name = "minStartTimeTimeSpanPicker";
            this.minStartTimeTimeSpanPicker.NullText = "Select time...";
            this.minStartTimeTimeSpanPicker.Size = new System.Drawing.Size(217, 22);
            this.minStartTimeTimeSpanPicker.TabIndex = 1;
            this.minStartTimeTimeSpanPicker.TabStop = false;
            this.minStartTimeTimeSpanPicker.Value = null;
            this.minStartTimeTimeSpanPicker.ValueChanged += new System.EventHandler(this.MovieFilterTimeSpanPicker_ValueChanged);
            // 
            // durationTimeSpanPicker
            // 
            this.durationTimeSpanPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.durationTimeSpanPicker.EditMode = Telerik.WinControls.UI.TimeSpanEditMode.Popup;
            this.durationTimeSpanPicker.EnableNullValueInput = true;
            this.durationTimeSpanPicker.Format = "hh\':\'mm\' hours\'";
            this.durationTimeSpanPicker.Location = new System.Drawing.Point(8, 134);
            this.durationTimeSpanPicker.Name = "durationTimeSpanPicker";
            this.durationTimeSpanPicker.NullText = "Select duration...";
            this.durationTimeSpanPicker.Size = new System.Drawing.Size(217, 22);
            this.durationTimeSpanPicker.TabIndex = 3;
            this.durationTimeSpanPicker.TabStop = false;
            this.durationTimeSpanPicker.Value = null;
            this.durationTimeSpanPicker.ValueChanged += new System.EventHandler(this.MovieFilterTimeSpanPicker_ValueChanged);
            // 
            // searchMovieLabel
            // 
            this.searchMovieLabel.AutoSize = false;
            this.searchMovieLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.searchMovieLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchMovieLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.searchMovieLabel.ForeColor = System.Drawing.Color.White;
            this.searchMovieLabel.Location = new System.Drawing.Point(0, 0);
            this.searchMovieLabel.Name = "searchMovieLabel";
            this.searchMovieLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.searchMovieLabel.Size = new System.Drawing.Size(235, 30);
            this.searchMovieLabel.TabIndex = 0;
            this.searchMovieLabel.Text = "Search Movie";
            // 
            // moviesPanel
            // 
            this.moviesPanel.Controls.Add(this.moviesScrollablePanel);
            this.moviesPanel.Controls.Add(this.moviesStartingAfterLabel);
            this.moviesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesPanel.Location = new System.Drawing.Point(235, 40);
            this.moviesPanel.Name = "moviesPanel";
            this.moviesPanel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.moviesPanel.Size = new System.Drawing.Size(715, 533);
            this.moviesPanel.TabIndex = 2;
            ((Telerik.WinControls.UI.RadPanelElement)(this.moviesPanel.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            ((Telerik.WinControls.UI.RadPanelElement)(this.moviesPanel.GetChildAt(0))).Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            // 
            // moviesScrollablePanel
            // 
            this.moviesScrollablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesScrollablePanel.Location = new System.Drawing.Point(6, 30);
            this.moviesScrollablePanel.Name = "moviesScrollablePanel";
            // 
            // moviesScrollablePanel.PanelContainer
            // 
            this.moviesScrollablePanel.PanelContainer.Size = new System.Drawing.Size(707, 501);
            // 
            // 
            // 
            this.moviesScrollablePanel.RootElement.DpiScaleFactorChanged += new System.EventHandler(this.MoviesScrollablePanel_RootElement_DpiScaleFactorChanged);
            this.moviesScrollablePanel.Size = new System.Drawing.Size(709, 503);
            this.moviesScrollablePanel.TabIndex = 2;
            // 
            // moviesStartingAfterLabel
            // 
            this.moviesStartingAfterLabel.AutoSize = false;
            this.moviesStartingAfterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.moviesStartingAfterLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.moviesStartingAfterLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.moviesStartingAfterLabel.ForeColor = System.Drawing.Color.White;
            this.moviesStartingAfterLabel.Location = new System.Drawing.Point(6, 0);
            this.moviesStartingAfterLabel.Name = "moviesStartingAfterLabel";
            this.moviesStartingAfterLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.moviesStartingAfterLabel.Size = new System.Drawing.Size(709, 30);
            this.moviesStartingAfterLabel.TabIndex = 1;
            this.moviesStartingAfterLabel.Text = "Movies starting today after 12:00 with minimum duration 30 minutes";
            // 
            // editorsScrollablePanel
            // 
            this.editorsScrollablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorsScrollablePanel.Location = new System.Drawing.Point(0, 30);
            this.editorsScrollablePanel.Name = "editorsScrollablePanel";
            // 
            // editorsScrollablePanel.PanelContainer
            // 
            this.editorsScrollablePanel.PanelContainer.Controls.Add(this.doubleBufferedTableLayoutPanel1);
            this.editorsScrollablePanel.PanelContainer.Size = new System.Drawing.Size(233, 501);
            this.editorsScrollablePanel.Size = new System.Drawing.Size(235, 503);
            this.editorsScrollablePanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1963, 1157);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaProgramLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorsPanel)).EndInit();
            this.editorsPanel.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel1.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDurationLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesPlayingAfterLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minStartTimeTimeSpanPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationTimeSpanPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchMovieLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesPanel)).EndInit();
            this.moviesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviesScrollablePanel)).EndInit();
            this.moviesScrollablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviesStartingAfterLabel)).EndInit();
            this.editorsScrollablePanel.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorsScrollablePanel)).EndInit();
            this.editorsScrollablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel cinemaProgramLabel;
        private Telerik.WinControls.UI.RadPanel editorsPanel;
        private Telerik.WinControls.UI.RadPanel moviesPanel;
        private Telerik.WinControls.UI.RadLabel moviesStartingAfterLabel;
        private Telerik.WinControls.UI.RadLabel searchMovieLabel;
        private Telerik.WinControls.UI.RadLabel movieDurationLabel;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel moviesPlayingAfterLabel;
        private Telerik.WinControls.UI.RadTimeSpanPicker minStartTimeTimeSpanPicker;
        private Telerik.WinControls.UI.RadTimeSpanPicker durationTimeSpanPicker;
        private Telerik.WinControls.UI.RadScrollablePanel moviesScrollablePanel;
        private Telerik.WinControls.UI.RadScrollablePanel editorsScrollablePanel;
    }
}