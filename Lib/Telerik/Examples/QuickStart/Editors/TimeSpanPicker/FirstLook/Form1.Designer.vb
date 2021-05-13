Namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.cinemaProgramLabel = New Telerik.WinControls.UI.RadLabel()
            Me.editorsPanel = New Telerik.WinControls.UI.RadPanel()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.movieDurationLabel = New Telerik.WinControls.UI.RadLabel()
            Me.moviesPlayingAfterLabel = New Telerik.WinControls.UI.RadLabel()
            Me.minStartTimeTimeSpanPicker = New Telerik.WinControls.UI.RadTimeSpanPicker()
            Me.durationTimeSpanPicker = New Telerik.WinControls.UI.RadTimeSpanPicker()
            Me.searchMovieLabel = New Telerik.WinControls.UI.RadLabel()
            Me.moviesPanel = New Telerik.WinControls.UI.RadPanel()
            Me.moviesScrollablePanel = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.moviesStartingAfterLabel = New Telerik.WinControls.UI.RadLabel()
            Me.editorsScrollablePanel = New Telerik.WinControls.UI.RadScrollablePanel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cinemaProgramLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.editorsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.editorsPanel.SuspendLayout()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            CType(Me.movieDurationLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.moviesPlayingAfterLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.minStartTimeTimeSpanPicker, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.durationTimeSpanPicker, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.searchMovieLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.moviesPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moviesPanel.SuspendLayout()
            CType(Me.moviesScrollablePanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moviesScrollablePanel.SuspendLayout()
            CType(Me.moviesStartingAfterLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.editorsScrollablePanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.editorsScrollablePanel.PanelContainer.SuspendLayout()
            Me.editorsScrollablePanel.SuspendLayout()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.moviesPanel)
            Me.radPanelDemoHolder.Controls.Add(Me.editorsPanel)
            Me.radPanelDemoHolder.Controls.Add(Me.cinemaProgramLabel)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(950, 573)
            Me.settingsPanel.Location = New System.Drawing.Point(1334, 294)
            Me.cinemaProgramLabel.AutoSize = False
            Me.cinemaProgramLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.cinemaProgramLabel.Font = New System.Drawing.Font("Segoe UI", 16.5F)
            Me.cinemaProgramLabel.Image = My.Resources.cinema_icon
            Me.cinemaProgramLabel.Location = New System.Drawing.Point(0, 0)
            Me.cinemaProgramLabel.Name = "cinemaProgramLabel"
            Me.cinemaProgramLabel.Size = New System.Drawing.Size(950, 40)
            Me.cinemaProgramLabel.TabIndex = 0
            Me.cinemaProgramLabel.Text = "Cinema program for "
            Me.cinemaProgramLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.editorsPanel.Controls.Add(Me.editorsScrollablePanel)
            Me.editorsPanel.Controls.Add(Me.searchMovieLabel)
            Me.editorsPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.editorsPanel.Location = New System.Drawing.Point(0, 40)
            Me.editorsPanel.Name = "editorsPanel"
            Me.editorsPanel.Size = New System.Drawing.Size(235, 533)
            Me.editorsPanel.TabIndex = 1
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 1
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.movieDurationLabel, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.moviesPlayingAfterLabel, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.minStartTimeTimeSpanPicker, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.durationTimeSpanPicker, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
            Me.doubleBufferedTableLayoutPanel1.RowCount = 5
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(233, 501)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 1
            Me.movieDurationLabel.AutoSize = False
            Me.movieDurationLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.movieDurationLabel.Location = New System.Drawing.Point(8, 88)
            Me.movieDurationLabel.Name = "movieDurationLabel"
            Me.movieDurationLabel.Size = New System.Drawing.Size(217, 34)
            Me.movieDurationLabel.TabIndex = 2
            Me.movieDurationLabel.Text = "Minimum movie duration:"
            Me.movieDurationLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.moviesPlayingAfterLabel.AutoSize = False
            Me.moviesPlayingAfterLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moviesPlayingAfterLabel.Location = New System.Drawing.Point(8, 8)
            Me.moviesPlayingAfterLabel.Name = "moviesPlayingAfterLabel"
            Me.moviesPlayingAfterLabel.Size = New System.Drawing.Size(217, 34)
            Me.moviesPlayingAfterLabel.TabIndex = 0
            Me.moviesPlayingAfterLabel.Text = "Movies playing after:"
            Me.moviesPlayingAfterLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.minStartTimeTimeSpanPicker.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.minStartTimeTimeSpanPicker.EditMode = Telerik.WinControls.UI.TimeSpanEditMode.Popup
            Me.minStartTimeTimeSpanPicker.EnableNullValueInput = True
            Me.minStartTimeTimeSpanPicker.Format = "hh':'mm' hours'"
            Me.minStartTimeTimeSpanPicker.Location = New System.Drawing.Point(8, 54)
            Me.minStartTimeTimeSpanPicker.MinutesStep = 10
            Me.minStartTimeTimeSpanPicker.Name = "minStartTimeTimeSpanPicker"
            Me.minStartTimeTimeSpanPicker.NullText = "Select time..."
            Me.minStartTimeTimeSpanPicker.Size = New System.Drawing.Size(217, 22)
            Me.minStartTimeTimeSpanPicker.TabIndex = 1
            Me.minStartTimeTimeSpanPicker.TabStop = False
            Me.minStartTimeTimeSpanPicker.Value = Nothing
            AddHandler Me.minStartTimeTimeSpanPicker.ValueChanged, New System.EventHandler(AddressOf Me.MovieFilterTimeSpanPicker_ValueChanged)
            Me.durationTimeSpanPicker.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.durationTimeSpanPicker.EditMode = Telerik.WinControls.UI.TimeSpanEditMode.Popup
            Me.durationTimeSpanPicker.EnableNullValueInput = True
            Me.durationTimeSpanPicker.Format = "hh':'mm' hours'"
            Me.durationTimeSpanPicker.Location = New System.Drawing.Point(8, 134)
            Me.durationTimeSpanPicker.Name = "durationTimeSpanPicker"
            Me.durationTimeSpanPicker.NullText = "Select duration..."
            Me.durationTimeSpanPicker.Size = New System.Drawing.Size(217, 22)
            Me.durationTimeSpanPicker.TabIndex = 3
            Me.durationTimeSpanPicker.TabStop = False
            Me.durationTimeSpanPicker.Value = Nothing
            AddHandler Me.durationTimeSpanPicker.ValueChanged, New System.EventHandler(AddressOf Me.MovieFilterTimeSpanPicker_ValueChanged)
            Me.searchMovieLabel.AutoSize = False
            Me.searchMovieLabel.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((153)))))), (CInt(((CByte((188)))))))
            Me.searchMovieLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.searchMovieLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.searchMovieLabel.ForeColor = System.Drawing.Color.White
            Me.searchMovieLabel.Location = New System.Drawing.Point(0, 0)
            Me.searchMovieLabel.Name = "searchMovieLabel"
            Me.searchMovieLabel.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
            Me.searchMovieLabel.Size = New System.Drawing.Size(235, 30)
            Me.searchMovieLabel.TabIndex = 0
            Me.searchMovieLabel.Text = "Search Movie"
            Me.moviesPanel.Controls.Add(Me.moviesScrollablePanel)
            Me.moviesPanel.Controls.Add(Me.moviesStartingAfterLabel)
            Me.moviesPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moviesPanel.Location = New System.Drawing.Point(235, 40)
            Me.moviesPanel.Name = "moviesPanel"
            Me.moviesPanel.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
            Me.moviesPanel.Size = New System.Drawing.Size(715, 533)
            Me.moviesPanel.TabIndex = 2
            CType(Me.moviesPanel.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
            CType(Me.moviesPanel.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Margin = New System.Windows.Forms.Padding(6, 0, 0, 0)
            Me.moviesScrollablePanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moviesScrollablePanel.Location = New System.Drawing.Point(6, 30)
            Me.moviesScrollablePanel.Name = "moviesScrollablePanel"
            Me.moviesScrollablePanel.PanelContainer.Size = New System.Drawing.Size(707, 501)
            AddHandler Me.moviesScrollablePanel.RootElement.DpiScaleFactorChanged, New System.EventHandler(AddressOf Me.MoviesScrollablePanel_RootElement_DpiScaleFactorChanged)
            Me.moviesScrollablePanel.Size = New System.Drawing.Size(709, 503)
            Me.moviesScrollablePanel.TabIndex = 2
            Me.moviesStartingAfterLabel.AutoSize = False
            Me.moviesStartingAfterLabel.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((153)))))), (CInt(((CByte((188)))))))
            Me.moviesStartingAfterLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.moviesStartingAfterLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.moviesStartingAfterLabel.ForeColor = System.Drawing.Color.White
            Me.moviesStartingAfterLabel.Location = New System.Drawing.Point(6, 0)
            Me.moviesStartingAfterLabel.Name = "moviesStartingAfterLabel"
            Me.moviesStartingAfterLabel.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
            Me.moviesStartingAfterLabel.Size = New System.Drawing.Size(709, 30)
            Me.moviesStartingAfterLabel.TabIndex = 1
            Me.moviesStartingAfterLabel.Text = "Movies starting today after 12:00 with minimum duration 30 minutes"
            Me.editorsScrollablePanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editorsScrollablePanel.Location = New System.Drawing.Point(0, 30)
            Me.editorsScrollablePanel.Name = "editorsScrollablePanel"
            Me.editorsScrollablePanel.PanelContainer.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.editorsScrollablePanel.PanelContainer.Size = New System.Drawing.Size(233, 501)
            Me.editorsScrollablePanel.Size = New System.Drawing.Size(235, 503)
            Me.editorsScrollablePanel.TabIndex = 3
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1963, 1157)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cinemaProgramLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.editorsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.editorsPanel.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            CType(Me.movieDurationLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.moviesPlayingAfterLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.minStartTimeTimeSpanPicker, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.durationTimeSpanPicker, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.searchMovieLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.moviesPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moviesPanel.ResumeLayout(False)
            CType(Me.moviesScrollablePanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moviesScrollablePanel.ResumeLayout(False)
            CType(Me.moviesStartingAfterLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.editorsScrollablePanel.PanelContainer.ResumeLayout(False)
            CType(Me.editorsScrollablePanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.editorsScrollablePanel.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Private cinemaProgramLabel As Telerik.WinControls.UI.RadLabel
        Private editorsPanel As Telerik.WinControls.UI.RadPanel
        Private moviesPanel As Telerik.WinControls.UI.RadPanel
        Private moviesStartingAfterLabel As Telerik.WinControls.UI.RadLabel
        Private searchMovieLabel As Telerik.WinControls.UI.RadLabel
        Private movieDurationLabel As Telerik.WinControls.UI.RadLabel
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private moviesPlayingAfterLabel As Telerik.WinControls.UI.RadLabel
        Private minStartTimeTimeSpanPicker As Telerik.WinControls.UI.RadTimeSpanPicker
        Private durationTimeSpanPicker As Telerik.WinControls.UI.RadTimeSpanPicker
        Private moviesScrollablePanel As Telerik.WinControls.UI.RadScrollablePanel
        Private editorsScrollablePanel As Telerik.WinControls.UI.RadScrollablePanel
    End Class
End Namespace
