Namespace Telerik.Examples.WinControls.Scheduler.Grouping
	Partial Public Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim dateTimeInterval1 As New Telerik.WinControls.UI.DateTimeInterval()
			Dim schedulerDailyPrintStyle1 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radSchedulerDemo = New Telerik.WinControls.UI.RadScheduler()
			Me.imageList1 = New ImageList(Me.components)
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			Me.radTrackBar1 = New Telerik.WinControls.UI.RadTrackBar()
			Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox4.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox4)
			Me.settingsPanel.Location = New Point(1042, 1)
			Me.settingsPanel.Size = New Size(200, 269)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox4, 0)
			' 
			' radSchedulerDemo
			' 
			dateTimeInterval1.End = New Date((CLng(0)))
			dateTimeInterval1.Start = New Date((CLng(0)))
			Me.radSchedulerDemo.AccessibleInterval = dateTimeInterval1
			Me.radSchedulerDemo.Culture = New System.Globalization.CultureInfo("en-US")
			Me.radSchedulerDemo.DataSource = Nothing
			Me.radSchedulerDemo.Dock = DockStyle.Fill
			Me.radSchedulerDemo.HeaderFormat = "MMMM dd"
			Me.radSchedulerDemo.Location = New Point(0, 77)
			Me.radSchedulerDemo.Name = "radSchedulerDemo"
			schedulerDailyPrintStyle1.AppointmentFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			schedulerDailyPrintStyle1.DateEndRange = New Date(2014, 6, 15, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.DateHeadingFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			schedulerDailyPrintStyle1.DateStartRange = New Date(2014, 6, 10, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.PageHeadingFont = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
			Me.radSchedulerDemo.PrintStyle = schedulerDailyPrintStyle1
			Me.radSchedulerDemo.Size = New Size(1289, 845)
			Me.radSchedulerDemo.TabIndex = 0
			Me.radSchedulerDemo.Text = "radScheduler1"
'			Me.radSchedulerDemo.CellSelectionChanged += New System.EventHandler(Me.radSchedulerDemo_CellSelectionChanged)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "1.png")
			Me.imageList1.Images.SetKeyName(1, "2.png")
			Me.imageList1.Images.SetKeyName(2, "3.png")
			Me.imageList1.Images.SetKeyName(3, "4.png")
			Me.imageList1.Images.SetKeyName(4, "5.png")
			' 
			' radSchedulerNavigator1
			' 
			Me.radSchedulerNavigator1.AssociatedScheduler = Nothing
			Me.radSchedulerNavigator1.DateFormat = "MM/dd/yyyy"
			Me.radSchedulerNavigator1.Dock = DockStyle.Top
			Me.radSchedulerNavigator1.Location = New Point(0, 0)
			Me.radSchedulerNavigator1.MinimumSize = New Size(400, 74)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.MinSize = New Size(400, 74)
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New Size(1289, 77)
			Me.radSchedulerNavigator1.TabIndex = 0
			Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
			' 
			' radTrackBar1
			' 
			Me.radTrackBar1.Anchor = AnchorStyles.Top
			Me.radTrackBar1.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight
			Me.radTrackBar1.LargeTickFrequency = 1
			Me.radTrackBar1.Location = New Point(5, 24)
			Me.radTrackBar1.Maximum = 10F
			Me.radTrackBar1.Minimum = 1F
			Me.radTrackBar1.Name = "radTrackBar1"
			Me.radTrackBar1.Size = New Size(170, 55)
			Me.radTrackBar1.TabIndex = 1
			Me.radTrackBar1.Text = "radTrackBar1"
			Me.radTrackBar1.Value = 1F
'			Me.radTrackBar1.ValueChanged += New System.EventHandler(Me.radTrackBar1_ValueChanged)
'			Me.radTrackBar1.ToolTipTextNeeded += New Telerik.WinControls.ToolTipTextNeededEventHandler(Me.radTrackBar1_ToolTipTextNeeded)
			' 
			' radGroupBox4
			' 
			Me.radGroupBox4.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox4.Anchor = AnchorStyles.Top
			Me.radGroupBox4.Controls.Add(Me.radTrackBar1)
			Me.radGroupBox4.HeaderText = "Resize the selected resource"
			Me.radGroupBox4.Location = New Point(10, 32)
			Me.radGroupBox4.Name = "radGroupBox4"
			Me.radGroupBox4.Size = New Size(180, 84)
			Me.radGroupBox4.TabIndex = 5
			Me.radGroupBox4.Text = "Resize the selected resource"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radSchedulerDemo)
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Name = "Form1"
			Me.Size = New Size(1299, 932)
			Me.Controls.SetChildIndex(Me.radSchedulerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.radSchedulerDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox4.ResumeLayout(False)
			Me.radGroupBox4.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents radSchedulerDemo As Telerik.WinControls.UI.RadScheduler
		Private imageList1 As ImageList
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
		Private WithEvents radTrackBar1 As Telerik.WinControls.UI.RadTrackBar
		Private radGroupBox4 As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace
