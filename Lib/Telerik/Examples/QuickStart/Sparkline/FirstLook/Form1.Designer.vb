Namespace Telerik.Examples.WinControls.Sparkline.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim cartesianArea1 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.sparklineUserControl1 = New Telerik.Examples.WinControls.Sparkline.FirstLook.SparklineUserControl()
            Me.sparklineUserControl2 = New Telerik.Examples.WinControls.Sparkline.FirstLook.SparklineUserControl()
            Me.sparklineUserControl3 = New Telerik.Examples.WinControls.Sparkline.FirstLook.SparklineUserControl()
            Me.sparklineUserControl4 = New Telerik.Examples.WinControls.Sparkline.FirstLook.SparklineUserControl()
            Me.sparklineUserControl5 = New Telerik.Examples.WinControls.Sparkline.FirstLook.SparklineUserControl()
            Me.sparklineUserControl6 = New Telerik.Examples.WinControls.Sparkline.FirstLook.SparklineUserControl()
            Me.sparklineUserControl7 = New Telerik.Examples.WinControls.Sparkline.FirstLook.SparklineUserControl()
            Me.sparklineUserControl8 = New Telerik.Examples.WinControls.Sparkline.FirstLook.SparklineUserControl()
            Me.sparklineUserControl9 = New Telerik.Examples.WinControls.Sparkline.FirstLook.SparklineUserControl()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
            Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            CType((Me.radLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radChartView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(173, 103)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(780, 480)
            Me.settingsPanel.Location = New System.Drawing.Point(1392, 46)
            Me.radLabel2.AutoSize = False
            Me.radLabel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel2.Location = New System.Drawing.Point(73, 38)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(224, 29)
            Me.radLabel2.TabIndex = 1
            Me.radLabel2.Text = "Call Duration"
            Me.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radLabel1.AutoSize = False
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radLabel1, 4)
            Me.radLabel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0F)
            Me.radLabel1.Location = New System.Drawing.Point(0, 0)
            Me.radLabel1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(780, 28)
            Me.radLabel1.TabIndex = 0
            Me.radLabel1.Text = "Performance by Representative"
            Me.radLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 4
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel2, 1, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel3, 2, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel4, 3, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.sparklineUserControl1, 1, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.sparklineUserControl2, 2, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.sparklineUserControl3, 3, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.sparklineUserControl4, 1, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.sparklineUserControl5, 2, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.sparklineUserControl6, 3, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.sparklineUserControl7, 1, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.sparklineUserControl8, 2, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.sparklineUserControl9, 3, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel6, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel7, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel8, 0, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radChartView1, 0, 5)
            Me.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 6
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(780, 480)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 1
            Me.radLabel3.AutoSize = False
            Me.radLabel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel3.Location = New System.Drawing.Point(303, 38)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(224, 29)
            Me.radLabel3.TabIndex = 2
            Me.radLabel3.Text = "Hold Time"
            Me.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radLabel4.AutoSize = False
            Me.radLabel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel4.Location = New System.Drawing.Point(533, 38)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(244, 29)
            Me.radLabel4.TabIndex = 3
            Me.radLabel4.Text = "Issues Resolved"
            Me.radLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.sparklineUserControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sparklineUserControl1.Location = New System.Drawing.Point(73, 73)
            Me.sparklineUserControl1.Name = "sparklineUserControl1"
            Me.sparklineUserControl1.Size = New System.Drawing.Size(224, 29)
            Me.sparklineUserControl1.TabIndex = 4
            Me.sparklineUserControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sparklineUserControl2.Location = New System.Drawing.Point(303, 73)
            Me.sparklineUserControl2.Name = "sparklineUserControl2"
            Me.sparklineUserControl2.Size = New System.Drawing.Size(224, 29)
            Me.sparklineUserControl2.TabIndex = 5
            Me.sparklineUserControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sparklineUserControl3.Location = New System.Drawing.Point(533, 73)
            Me.sparklineUserControl3.Name = "sparklineUserControl3"
            Me.sparklineUserControl3.Size = New System.Drawing.Size(244, 29)
            Me.sparklineUserControl3.TabIndex = 7
            Me.sparklineUserControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sparklineUserControl4.Location = New System.Drawing.Point(73, 108)
            Me.sparklineUserControl4.Name = "sparklineUserControl4"
            Me.sparklineUserControl4.Size = New System.Drawing.Size(224, 29)
            Me.sparklineUserControl4.TabIndex = 8
            Me.sparklineUserControl5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sparklineUserControl5.Location = New System.Drawing.Point(303, 108)
            Me.sparklineUserControl5.Name = "sparklineUserControl5"
            Me.sparklineUserControl5.Size = New System.Drawing.Size(224, 29)
            Me.sparklineUserControl5.TabIndex = 9
            Me.sparklineUserControl6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sparklineUserControl6.Location = New System.Drawing.Point(533, 108)
            Me.sparklineUserControl6.Name = "sparklineUserControl6"
            Me.sparklineUserControl6.Size = New System.Drawing.Size(244, 29)
            Me.sparklineUserControl6.TabIndex = 10
            Me.sparklineUserControl7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sparklineUserControl7.Location = New System.Drawing.Point(73, 143)
            Me.sparklineUserControl7.Name = "sparklineUserControl7"
            Me.sparklineUserControl7.Size = New System.Drawing.Size(224, 29)
            Me.sparklineUserControl7.TabIndex = 11
            Me.sparklineUserControl8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sparklineUserControl8.Location = New System.Drawing.Point(303, 143)
            Me.sparklineUserControl8.Name = "sparklineUserControl8"
            Me.sparklineUserControl8.Size = New System.Drawing.Size(224, 29)
            Me.sparklineUserControl8.TabIndex = 12
            Me.sparklineUserControl9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sparklineUserControl9.Location = New System.Drawing.Point(533, 143)
            Me.sparklineUserControl9.Name = "sparklineUserControl9"
            Me.sparklineUserControl9.Size = New System.Drawing.Size(244, 29)
            Me.sparklineUserControl9.TabIndex = 13
            Me.radLabel6.AutoSize = False
            Me.radLabel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel6.Location = New System.Drawing.Point(3, 73)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(64, 29)
            Me.radLabel6.TabIndex = 14
            Me.radLabel6.Text = "Sam"
            Me.radLabel7.AutoSize = False
            Me.radLabel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel7.Location = New System.Drawing.Point(3, 108)
            Me.radLabel7.Name = "radLabel7"
            Me.radLabel7.Size = New System.Drawing.Size(64, 29)
            Me.radLabel7.TabIndex = 15
            Me.radLabel7.Text = "John"
            Me.radLabel8.AutoSize = False
            Me.radLabel8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel8.Location = New System.Drawing.Point(3, 143)
            Me.radLabel8.Name = "radLabel8"
            Me.radLabel8.Size = New System.Drawing.Size(64, 29)
            Me.radLabel8.TabIndex = 16
            Me.radLabel8.Text = "Mike"
            Me.radChartView1.AreaDesign = cartesianArea1
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radChartView1, 4)
            Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView1.Location = New System.Drawing.Point(1, 176)
            Me.radChartView1.Margin = New System.Windows.Forms.Padding(1)
            Me.radChartView1.Name = "radChartView1"
            Me.radChartView1.ShowGrid = False
            Me.radChartView1.Size = New System.Drawing.Size(778, 303)
            Me.radChartView1.TabIndex = 17
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2073, 1130)
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            CType((Me.radLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radChartView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private sparklineUserControl1 As SparklineUserControl
        Private sparklineUserControl2 As SparklineUserControl
        Private sparklineUserControl3 As SparklineUserControl
        Private sparklineUserControl4 As SparklineUserControl
        Private sparklineUserControl5 As SparklineUserControl
        Private sparklineUserControl6 As SparklineUserControl
        Private sparklineUserControl7 As SparklineUserControl
        Private sparklineUserControl8 As SparklineUserControl
        Private sparklineUserControl9 As SparklineUserControl
        Private radLabel6 As Telerik.WinControls.UI.RadLabel
        Private radLabel7 As Telerik.WinControls.UI.RadLabel
        Private radLabel8 As Telerik.WinControls.UI.RadLabel
        Private radChartView1 As Telerik.WinControls.UI.RadChartView
    End Class
End Namespace
