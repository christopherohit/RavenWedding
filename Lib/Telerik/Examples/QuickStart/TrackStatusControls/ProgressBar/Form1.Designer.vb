Namespace Telerik.Examples.WinControls.TrackStatusControls.ProgressBar
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.radTrackBar1 = New Telerik.WinControls.UI.RadTrackBar()
            Me.radProgressBar5 = New Telerik.WinControls.UI.RadProgressBar()
            Me.radProgressBar2 = New Telerik.WinControls.UI.RadProgressBar()
            Me.radProgressBar4 = New Telerik.WinControls.UI.RadProgressBar()
            Me.radProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
            Me.radProgressBar6 = New Telerik.WinControls.UI.RadProgressBar()
            Me.radGroupHorizontal = New Telerik.WinControls.UI.RadGroupBox()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radGroupImage = New Telerik.WinControls.UI.RadGroupBox()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radProgressBar5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radProgressBar4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radProgressBar6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupHorizontal.SuspendLayout()
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            DirectCast(Me.radGroupImage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupImage.SuspendLayout()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New System.Drawing.Point(821, 1)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 705)
            ' 
            ' timer1
            ' 
            Me.timer1.Enabled = True
            Me.timer1.Interval = 50
            ' 
            ' radTrackBar1
            ' 
            Me.radTrackBar1.Location = New System.Drawing.Point(15, 138)
            Me.radTrackBar1.Maximum = 10.0F
            Me.radTrackBar1.Name = "radTrackBar1"
            Me.radTrackBar1.Size = New System.Drawing.Size(320, 34)
            Me.radTrackBar1.TabIndex = 18
            Me.radTrackBar1.Text = "radTrackBar1"
            Me.radTrackBar1.Value = 10.0F
            ' 
            ' radProgressBar5
            ' 
            Me.radProgressBar5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radProgressBar5.Image = DirectCast(resources.GetObject("radProgressBar5.Image"), System.Drawing.Image)
            Me.radProgressBar5.Location = New System.Drawing.Point(15, 23)
            Me.radProgressBar5.Name = "radProgressBar5"
            Me.radProgressBar5.SeparatorColor1 = System.Drawing.Color.FromArgb(CInt(CByte(239)), CInt(CByte(239)), CInt(CByte(239)))
            Me.radProgressBar5.SeparatorWidth = 4
            Me.radProgressBar5.Size = New System.Drawing.Size(320, 85)
            Me.radProgressBar5.StepWidth = 13
            Me.radProgressBar5.TabIndex = 14
            Me.radProgressBar5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radProgressBar5.Value1 = 100
            ' 
            ' radProgressBar2
            ' 
            Me.radProgressBar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radProgressBar2.Location = New System.Drawing.Point(15, 64)
            Me.radProgressBar2.Name = "radProgressBar2"
            Me.radProgressBar2.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Right
            Me.radProgressBar2.SeparatorColor1 = System.Drawing.Color.FromArgb(CInt(CByte(239)), CInt(CByte(239)), CInt(CByte(239)))
            Me.radProgressBar2.SeparatorWidth = 0
            Me.radProgressBar2.ShowProgressIndicators = True
            Me.radProgressBar2.Size = New System.Drawing.Size(320, 28)
            Me.radProgressBar2.StepWidth = 13
            Me.radProgressBar2.TabIndex = 13
            Me.radProgressBar2.Text = "60 %"
            Me.radProgressBar2.Value1 = 60
            ' 
            ' radProgressBar4
            ' 
            Me.radProgressBar4.Location = New System.Drawing.Point(59, 23)
            Me.radProgressBar4.Name = "radProgressBar4"
            Me.radProgressBar4.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Top
            Me.radProgressBar4.SeparatorColor1 = System.Drawing.Color.FromArgb(CInt(CByte(239)), CInt(CByte(239)), CInt(CByte(239)))
            Me.radProgressBar4.SeparatorWidth = 4
            Me.radProgressBar4.ShowProgressIndicators = True
            Me.radProgressBar4.Size = New System.Drawing.Size(31, 269)
            Me.radProgressBar4.StepWidth = 13
            Me.radProgressBar4.TabIndex = 12
            Me.radProgressBar4.Text = "60 %"
            Me.radProgressBar4.Value1 = 60
            ' 
            ' radProgressBar1
            ' 
            Me.radProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radProgressBar1.ImageScalingSize = New System.Drawing.Size(0, 0)
            Me.radProgressBar1.Location = New System.Drawing.Point(15, 23)
            Me.radProgressBar1.Name = "radProgressBar1"
            Me.radProgressBar1.SeparatorColor1 = System.Drawing.Color.FromArgb(CInt(CByte(239)), CInt(CByte(239)), CInt(CByte(239)))
            Me.radProgressBar1.SeparatorWidth = 0
            Me.radProgressBar1.ShowProgressIndicators = True
            Me.radProgressBar1.Size = New System.Drawing.Size(320, 28)
            Me.radProgressBar1.StepWidth = 13
            Me.radProgressBar1.SweepAngle = 120
            Me.radProgressBar1.TabIndex = 6
            Me.radProgressBar1.Text = "60 %"
            Me.radProgressBar1.Value1 = 60
            ' 
            ' radProgressBar6
            ' 
            Me.radProgressBar6.Location = New System.Drawing.Point(15, 23)
            Me.radProgressBar6.Name = "radProgressBar6"
            Me.radProgressBar6.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Bottom
            Me.radProgressBar6.SeparatorColor1 = System.Drawing.Color.FromArgb(CInt(CByte(239)), CInt(CByte(239)), CInt(CByte(239)))
            Me.radProgressBar6.SeparatorWidth = 0
            Me.radProgressBar6.ShowProgressIndicators = True
            Me.radProgressBar6.Size = New System.Drawing.Size(31, 269)
            Me.radProgressBar6.StepWidth = 13
            Me.radProgressBar6.TabIndex = 25
            Me.radProgressBar6.Text = "60 %"
            Me.radProgressBar6.Value1 = 60
            ' 
            ' radGroupHorizontal
            ' 
            Me.radGroupHorizontal.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupHorizontal.Controls.Add(Me.radProgressBar1)
            Me.radGroupHorizontal.Controls.Add(Me.radProgressBar2)
            Me.radGroupHorizontal.FooterText = ""
            Me.radGroupHorizontal.HeaderText = "Horizontal"
            Me.radGroupHorizontal.Location = New System.Drawing.Point(20, 20)
            Me.radGroupHorizontal.Name = "radGroupHorizontal"
            Me.radGroupHorizontal.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupHorizontal.Size = New System.Drawing.Size(350, 106)
            Me.radGroupHorizontal.TabIndex = 30
            Me.radGroupHorizontal.Text = "Horizontal"
            ' 
            ' radGroupBox2
            ' 
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Controls.Add(Me.radProgressBar6)
            Me.radGroupBox2.Controls.Add(Me.radProgressBar4)
            Me.radGroupBox2.FooterText = ""
            Me.radGroupBox2.HeaderText = "Vertical"
            Me.radGroupBox2.Location = New System.Drawing.Point(383, 20)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupBox2.Size = New System.Drawing.Size(105, 305)
            Me.radGroupBox2.TabIndex = 31
            Me.radGroupBox2.Text = "Vertical"
            ' 
            ' radGroupImage
            ' 
            Me.radGroupImage.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupImage.Controls.Add(Me.radLabel1)
            Me.radGroupImage.Controls.Add(Me.radTrackBar1)
            Me.radGroupImage.Controls.Add(Me.radProgressBar5)
            Me.radGroupImage.FooterText = ""
            Me.radGroupImage.HeaderText = "Image progress bar"
            Me.radGroupImage.Location = New System.Drawing.Point(20, 138)
            Me.radGroupImage.Name = "radGroupImage"
            Me.radGroupImage.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupImage.Size = New System.Drawing.Size(350, 187)
            Me.radGroupImage.TabIndex = 32
            Me.radGroupImage.Text = "Image progress bar"
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Location = New System.Drawing.Point(15, 114)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(52, 18)
            Me.radLabel1.TabIndex = 19
            Me.radLabel1.Text = "Slide me!"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.radGroupBox2)
            Me.Controls.Add(Me.radGroupImage)
            Me.Controls.Add(Me.radGroupHorizontal)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
            Me.Size = New System.Drawing.Size(1438, 917)
            Me.Controls.SetChildIndex(Me.radGroupHorizontal, 0)
            Me.Controls.SetChildIndex(Me.radGroupImage, 0)
            Me.Controls.SetChildIndex(Me.radGroupBox2, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radProgressBar5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radProgressBar4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radProgressBar6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupHorizontal.ResumeLayout(False)
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            DirectCast(Me.radGroupImage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupImage.ResumeLayout(False)
            Me.radGroupImage.PerformLayout()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private timer1 As System.Windows.Forms.Timer
        Private radProgressBar1 As Telerik.WinControls.UI.RadProgressBar
        Private radProgressBar4 As Telerik.WinControls.UI.RadProgressBar
        Private radProgressBar2 As Telerik.WinControls.UI.RadProgressBar
        Private radProgressBar5 As Telerik.WinControls.UI.RadProgressBar
        Private radTrackBar1 As Telerik.WinControls.UI.RadTrackBar
        Private radProgressBar6 As Telerik.WinControls.UI.RadProgressBar
        Private radGroupHorizontal As Telerik.WinControls.UI.RadGroupBox
        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Private radGroupImage As Telerik.WinControls.UI.RadGroupBox
        Private radLabel1 As Telerik.WinControls.UI.RadLabel


    End Class
End Namespace