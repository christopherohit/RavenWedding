namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
{
    partial class CinemaMovieUserControl
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
            this.doubleBufferedTableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.durationLabel = new Telerik.WinControls.UI.RadLabel();
            this.startTimeLabel = new Telerik.WinControls.UI.RadLabel();
            this.descriptionLabel = new Telerik.WinControls.UI.RadLabel();
            this.genreLabel = new Telerik.WinControls.UI.RadLabel();
            this.imageLabel = new Telerik.WinControls.UI.RadLabel();
            this.movieNameLabel = new Telerik.WinControls.UI.RadLabel();
            this.doubleBufferedTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTimeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieNameLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBufferedTableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel1.ColumnCount = 3;
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.durationLabel, 2, 3);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.startTimeLabel, 1, 3);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.descriptionLabel, 1, 2);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.genreLabel, 1, 1);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.imageLabel, 0, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.movieNameLabel, 1, 0);
            this.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleBufferedTableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1";
            this.doubleBufferedTableLayoutPanel1.RowCount = 4;
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.doubleBufferedTableLayoutPanel1.Size = new System.Drawing.Size(663, 161);
            this.doubleBufferedTableLayoutPanel1.TabIndex = 0;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = false;
            this.durationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.durationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.durationLabel.Location = new System.Drawing.Point(359, 141);
            this.durationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(304, 20);
            this.durationLabel.TabIndex = 5;
            this.durationLabel.Text = "Duration";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = false;
            this.startTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.startTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.startTimeLabel.Location = new System.Drawing.Point(55, 141);
            this.startTimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(304, 20);
            this.startTimeLabel.TabIndex = 4;
            this.startTimeLabel.Text = "Start time";
            // 
            // descriptionLabel
            // 
            this.doubleBufferedTableLayoutPanel1.SetColumnSpan(this.descriptionLabel, 2);
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.descriptionLabel.Location = new System.Drawing.Point(55, 60);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(600, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            // 
            // 
            // 
            this.descriptionLabel.RootElement.MaxSize = new System.Drawing.Size(600, 0);
            this.descriptionLabel.Size = new System.Drawing.Size(193, 19);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Here comes the movie description";
            this.descriptionLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = false;
            this.doubleBufferedTableLayoutPanel1.SetColumnSpan(this.genreLabel, 2);
            this.genreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.genreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.genreLabel.Location = new System.Drawing.Point(55, 40);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(608, 20);
            this.genreLabel.TabIndex = 2;
            this.genreLabel.Text = "Genre";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = false;
            this.imageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageLabel.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.imageLabel.Location = new System.Drawing.Point(0, 0);
            this.imageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.imageLabel.Name = "imageLabel";
            this.doubleBufferedTableLayoutPanel1.SetRowSpan(this.imageLabel, 4);
            this.imageLabel.Size = new System.Drawing.Size(55, 161);
            this.imageLabel.TabIndex = 0;
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = false;
            this.doubleBufferedTableLayoutPanel1.SetColumnSpan(this.movieNameLabel, 2);
            this.movieNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(160)))), ((int)(((byte)(218)))));
            this.movieNameLabel.Location = new System.Drawing.Point(55, 0);
            this.movieNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(608, 40);
            this.movieNameLabel.TabIndex = 1;
            this.movieNameLabel.Text = "Movie Name";
            // 
            // CinemaMovieUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.doubleBufferedTableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.Name = "CinemaMovieUserControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(673, 171);
            this.doubleBufferedTableLayoutPanel1.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTimeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieNameLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel imageLabel;
        private Telerik.WinControls.UI.RadLabel durationLabel;
        private Telerik.WinControls.UI.RadLabel startTimeLabel;
        private Telerik.WinControls.UI.RadLabel descriptionLabel;
        private Telerik.WinControls.UI.RadLabel genreLabel;
        private Telerik.WinControls.UI.RadLabel movieNameLabel;
    }
}
