Namespace Telerik.Examples.WinControls.Sparkline.FirstLook
    Partial Class SparklineUserControl
        Private components As System.ComponentModel.IContainer = Nothing

        Private Sub InitializeComponent()
            Me.alertLabel = New Telerik.WinControls.UI.RadLabel()
            Me.radSparkline1 = New Telerik.WinControls.UI.RadSparkline()
            Me.timeLabel = New Telerik.WinControls.UI.RadLabel()
            DirectCast((Me.alertLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast((Me.radSparkline1), System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast((Me.timeLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.alertLabel.AutoSize = False
            Me.alertLabel.Dock = System.Windows.Forms.DockStyle.Left
            Me.alertLabel.Location = New System.Drawing.Point(0, 0)
            Me.alertLabel.Name = "radLabel1"
            Me.alertLabel.Size = New System.Drawing.Size(16, 35)
            Me.alertLabel.TabIndex = 0
            Me.alertLabel.Text = "!"
            Me.radSparkline1.AxisDrawMode = Telerik.WinControls.UI.AxisDrawMode.BelowSeries
            Me.radSparkline1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSparkline1.Location = New System.Drawing.Point(16, 0)
            Me.radSparkline1.Name = "radSparkline1"
            Me.radSparkline1.Size = New System.Drawing.Size(159, 35)
            Me.radSparkline1.TabIndex = 1
            Me.radSparkline1.Text = "radSparkline1"
            Me.timeLabel.AutoSize = False
            Me.timeLabel.Dock = System.Windows.Forms.DockStyle.Right
            Me.timeLabel.Location = New System.Drawing.Point(175, 0)
            Me.timeLabel.Name = "radLabel2"
            Me.timeLabel.Size = New System.Drawing.Size(55, 35)
            Me.timeLabel.TabIndex = 0
            Me.timeLabel.Text = "time"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radSparkline1)
            Me.Controls.Add(Me.timeLabel)
            Me.Controls.Add(Me.alertLabel)
            Me.Name = "SparklineUserControl"
            Me.Size = New System.Drawing.Size(230, 35)
            DirectCast((Me.alertLabel), System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast((Me.radSparkline1), System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast((Me.timeLabel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private alertLabel As Telerik.WinControls.UI.RadLabel
        Private radSparkline1 As Telerik.WinControls.UI.RadSparkline
        Private timeLabel As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
