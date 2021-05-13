Namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
    Partial Class CinemaMovieUserControl
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.durationLabel = New Telerik.WinControls.UI.RadLabel()
            Me.startTimeLabel = New Telerik.WinControls.UI.RadLabel()
            Me.descriptionLabel = New Telerik.WinControls.UI.RadLabel()
            Me.genreLabel = New Telerik.WinControls.UI.RadLabel()
            Me.imageLabel = New Telerik.WinControls.UI.RadLabel()
            Me.movieNameLabel = New Telerik.WinControls.UI.RadLabel()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            CType(Me.durationLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.startTimeLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.descriptionLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.genreLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.movieNameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 3
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.durationLabel, 2, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.startTimeLabel, 1, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.descriptionLabel, 1, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.genreLabel, 1, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.imageLabel, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.movieNameLabel, 1, 0)
            Me.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(5, 5)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 4
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(663, 161)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 0
            Me.durationLabel.AutoSize = False
            Me.durationLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.durationLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.durationLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((118)))))), (CInt(((CByte((118)))))), (CInt(((CByte((118)))))))
            Me.durationLabel.Location = New System.Drawing.Point(359, 141)
            Me.durationLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.durationLabel.Name = "durationLabel"
            Me.durationLabel.Size = New System.Drawing.Size(304, 20)
            Me.durationLabel.TabIndex = 5
            Me.durationLabel.Text = "Duration"
            Me.startTimeLabel.AutoSize = False
            Me.startTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.startTimeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.startTimeLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((118)))))), (CInt(((CByte((118)))))), (CInt(((CByte((118)))))))
            Me.startTimeLabel.Location = New System.Drawing.Point(55, 141)
            Me.startTimeLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.startTimeLabel.Name = "startTimeLabel"
            Me.startTimeLabel.Size = New System.Drawing.Size(304, 20)
            Me.startTimeLabel.TabIndex = 4
            Me.startTimeLabel.Text = "Start time"
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.descriptionLabel, 2)
            Me.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.descriptionLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((118)))))), (CInt(((CByte((118)))))), (CInt(((CByte((118)))))))
            Me.descriptionLabel.Location = New System.Drawing.Point(55, 60)
            Me.descriptionLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.descriptionLabel.MaximumSize = New System.Drawing.Size(600, 0)
            Me.descriptionLabel.Name = "descriptionLabel"
            Me.descriptionLabel.RootElement.MaxSize = New System.Drawing.Size(600, 0)
            Me.descriptionLabel.Size = New System.Drawing.Size(193, 19)
            Me.descriptionLabel.TabIndex = 3
            Me.descriptionLabel.Text = "Here comes the movie description"
            Me.descriptionLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.genreLabel.AutoSize = False
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.genreLabel, 2)
            Me.genreLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.genreLabel.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold)
            Me.genreLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((118)))))), (CInt(((CByte((118)))))), (CInt(((CByte((118)))))))
            Me.genreLabel.Location = New System.Drawing.Point(55, 40)
            Me.genreLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.genreLabel.Name = "genreLabel"
            Me.genreLabel.Size = New System.Drawing.Size(608, 20)
            Me.genreLabel.TabIndex = 2
            Me.genreLabel.Text = "Genre"
            Me.imageLabel.AutoSize = False
            Me.imageLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.imageLabel.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
            Me.imageLabel.Location = New System.Drawing.Point(0, 0)
            Me.imageLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.imageLabel.Name = "imageLabel"
            Me.doubleBufferedTableLayoutPanel1.SetRowSpan(Me.imageLabel, 4)
            Me.imageLabel.Size = New System.Drawing.Size(55, 161)
            Me.imageLabel.TabIndex = 0
            Me.movieNameLabel.AutoSize = False
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.movieNameLabel, 2)
            Me.movieNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.movieNameLabel.Font = New System.Drawing.Font("Segoe UI Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.movieNameLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((37)))))), (CInt(((CByte((160)))))), (CInt(((CByte((218)))))))
            Me.movieNameLabel.Location = New System.Drawing.Point(55, 0)
            Me.movieNameLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.movieNameLabel.Name = "movieNameLabel"
            Me.movieNameLabel.Size = New System.Drawing.Size(608, 40)
            Me.movieNameLabel.TabIndex = 1
            Me.movieNameLabel.Text = "Movie Name"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.Margin = New System.Windows.Forms.Padding(8, 4, 8, 4)
            Me.Name = "CinemaMovieUserControl"
            Me.Padding = New System.Windows.Forms.Padding(5)
            Me.Size = New System.Drawing.Size(673, 171)
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            CType(Me.durationLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.startTimeLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.descriptionLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.genreLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.movieNameLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private imageLabel As Telerik.WinControls.UI.RadLabel
        Private durationLabel As Telerik.WinControls.UI.RadLabel
        Private startTimeLabel As Telerik.WinControls.UI.RadLabel
        Private descriptionLabel As Telerik.WinControls.UI.RadLabel
        Private genreLabel As Telerik.WinControls.UI.RadLabel
        Private movieNameLabel As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
