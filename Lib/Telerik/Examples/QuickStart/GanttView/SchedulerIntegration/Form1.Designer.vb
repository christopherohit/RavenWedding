Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GanttView.SchedulerIntegration
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
            Dim DateTimeInterval1 As Telerik.WinControls.UI.DateTimeInterval = New Telerik.WinControls.UI.DateTimeInterval()
            Dim SchedulerDailyPrintStyle1 As Telerik.WinControls.UI.SchedulerDailyPrintStyle = New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
            Dim GanttViewPrintSettings1 As Telerik.WinControls.UI.GanttViewPrintSettings = New Telerik.WinControls.UI.GanttViewPrintSettings()
            Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
            Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.radGanttView1 = New Telerik.WinControls.UI.RadGanttView()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radSplitContainer1.SuspendLayout()
            CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel1.SuspendLayout()
            CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel2.SuspendLayout()
            CType(Me.radGanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radSplitContainer1
            '
            Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
            Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
            Me.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.radSplitContainer1.Name = "radSplitContainer1"
            Me.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            '
            '
            Me.radSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.radSplitContainer1.Size = New System.Drawing.Size(1490, 1001)
            Me.radSplitContainer1.SplitterWidth = 4
            Me.radSplitContainer1.TabIndex = 0
            Me.radSplitContainer1.TabStop = False
            Me.radSplitContainer1.Text = "radSplitContainer1"
            '
            'splitPanel1
            '
            Me.splitPanel1.Controls.Add(Me.radScheduler1)
            Me.splitPanel1.Location = New System.Drawing.Point(0, 0)
            Me.splitPanel1.Name = "splitPanel1"
            '
            '
            '
            Me.splitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel1.Size = New System.Drawing.Size(1490, 498)
            Me.splitPanel1.TabIndex = 0
            Me.splitPanel1.TabStop = False
            Me.splitPanel1.Text = "splitPanel1"
            '
            'radScheduler1
            '
            DateTimeInterval1.End = New Date(CType(0, Long))
            DateTimeInterval1.Start = New Date(CType(0, Long))
            Me.radScheduler1.AccessibleInterval = DateTimeInterval1
            Me.radScheduler1.AppointmentTitleFormat = Nothing
            Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radScheduler1.DataSource = Nothing
            Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
            Me.radScheduler1.HeaderFormat = "dd dddd"
            Me.radScheduler1.Location = New System.Drawing.Point(0, 0)
            Me.radScheduler1.Name = "radScheduler1"
            SchedulerDailyPrintStyle1.AppointmentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            SchedulerDailyPrintStyle1.DateEndRange = New Date(2013, 10, 2, 0, 0, 0, 0)
            SchedulerDailyPrintStyle1.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
            SchedulerDailyPrintStyle1.DateStartRange = New Date(2013, 9, 19, 0, 0, 0, 0)
            SchedulerDailyPrintStyle1.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold)
            Me.radScheduler1.PrintStyle = SchedulerDailyPrintStyle1
            Me.radScheduler1.Size = New System.Drawing.Size(1490, 498)
            Me.radScheduler1.TabIndex = 2
            Me.radScheduler1.Text = "radScheduler1"
            '
            'splitPanel2
            '
            Me.splitPanel2.Controls.Add(Me.radGanttView1)
            Me.splitPanel2.Location = New System.Drawing.Point(0, 502)
            Me.splitPanel2.Name = "splitPanel2"
            '
            '
            '
            Me.splitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel2.Size = New System.Drawing.Size(1490, 499)
            Me.splitPanel2.TabIndex = 1
            Me.splitPanel2.TabStop = False
            Me.splitPanel2.Text = "splitPanel2"
            '
            'radGanttView1
            '
            Me.radGanttView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGanttView1.Location = New System.Drawing.Point(0, 0)
            Me.radGanttView1.Name = "radGanttView1"
            Me.radGanttView1.PrintSettings = GanttViewPrintSettings1
            Me.radGanttView1.Size = New System.Drawing.Size(1490, 499)
            Me.radGanttView1.SplitterWidth = 7
            Me.radGanttView1.TabIndex = 3
            Me.radGanttView1.Text = "radGanttView1"
            '
            'imageList1
            '
            Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "1.png")
            Me.imageList1.Images.SetKeyName(1, "2.png")
            Me.imageList1.Images.SetKeyName(2, "3.png")
            Me.imageList1.Images.SetKeyName(3, "4.png")
            Me.imageList1.Images.SetKeyName(4, "5.png")
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radSplitContainer1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1500, 1011)
            Me.Controls.SetChildIndex(Me.radSplitContainer1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radSplitContainer1.ResumeLayout(False)
            CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel1.ResumeLayout(False)
            CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel2.ResumeLayout(False)
            CType(Me.radGanttView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region


		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radGanttView1 As Telerik.WinControls.UI.RadGanttView
        Private imageList1 As System.Windows.Forms.ImageList
        Friend WithEvents splitPanel1 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents splitPanel2 As Telerik.WinControls.UI.SplitPanel
	End Class
End Namespace