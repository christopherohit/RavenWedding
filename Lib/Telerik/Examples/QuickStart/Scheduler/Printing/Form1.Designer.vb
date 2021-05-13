Namespace Telerik.Examples.WinControls.Scheduler.Printing
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dateTimeInterval1 As New Telerik.WinControls.UI.DateTimeInterval()
			Dim schedulerDailyPrintStyle1 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
			Dim radPrintWatermark1 As New Telerik.WinControls.UI.RadPrintWatermark()
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			Me.radPrintDocument1 = New Telerik.WinControls.UI.RadPrintDocument()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radioAgenda = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioDetails = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioMonthly = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioWeekly = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioDaily = New Telerik.WinControls.UI.RadRadioButton()
			Me.buttonPrint = New Telerik.WinControls.UI.RadButton()
			Me.buttonPreview = New Telerik.WinControls.UI.RadButton()
			Me.buttonSettings = New Telerik.WinControls.UI.RadButton()
			Me.radioWeeklyCalendar = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radioDetails, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioWeekly, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioDaily, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonPrint, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonPreview, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioWeeklyCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.buttonSettings)
			Me.settingsPanel.Controls.Add(Me.buttonPreview)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.buttonPrint)
			Me.settingsPanel.Dock = DockStyle.Right
			Me.settingsPanel.Location = New Point(1635, 0)
			Me.settingsPanel.Size = New Size(238, 1002)
			Me.settingsPanel.Controls.SetChildIndex(Me.buttonPrint, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.buttonPreview, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.buttonSettings, 0)
			' 
			' radScheduler1
			' 
			dateTimeInterval1.End = New Date((CLng(0)))
			dateTimeInterval1.Start = New Date((CLng(0)))
			Me.radScheduler1.AccessibleInterval = dateTimeInterval1
			Me.radScheduler1.AppointmentTitleFormat = Nothing
			Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.radScheduler1.DataSource = Nothing
			Me.radScheduler1.Dock = DockStyle.Fill
			Me.radScheduler1.Location = New Point(0, 77)
			Me.radScheduler1.Name = "radScheduler1"
			schedulerDailyPrintStyle1.AppointmentFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			schedulerDailyPrintStyle1.DateEndRange = New Date(2012, 2, 13, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.DateHeadingFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			schedulerDailyPrintStyle1.DateStartRange = New Date(2012, 2, 8, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.PageHeadingFont = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
			schedulerDailyPrintStyle1.ShowLinedNotesArea = True
			schedulerDailyPrintStyle1.ShowNotesArea = True
			Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle1
			Me.radScheduler1.Size = New Size(1635, 925)
			Me.radScheduler1.TabIndex = 1
			Me.radScheduler1.Text = "radScheduler1"
			' 
			' radSchedulerNavigator1
			' 
			Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1
			Me.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
			Me.radSchedulerNavigator1.Dock = DockStyle.Top
			Me.radSchedulerNavigator1.Location = New Point(0, 0)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New Size(1635, 77)
			Me.radSchedulerNavigator1.TabIndex = 2
			Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
			' 
			' radPrintDocument1
			' 
			Me.radPrintDocument1.AssociatedObject = Me.radScheduler1
			Me.radPrintDocument1.FooterFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.radPrintDocument1.HeaderFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.radPrintDocument1.LeftFooter = "Page [Page #] of [Total Pages]"
			Me.radPrintDocument1.LeftHeader = "[Time Printed]"
			Me.radPrintDocument1.MiddleFooter = "***"
			Me.radPrintDocument1.MiddleHeader = "Weekly Task List"
			Me.radPrintDocument1.RightFooter = "Printed by: [User Name]"
			Me.radPrintDocument1.RightHeader = "[Date Printed]"
			Me.radPrintDocument1.Watermark = radPrintWatermark1
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radioAgenda)
			Me.radGroupBox1.Controls.Add(Me.radioDetails)
			Me.radGroupBox1.Controls.Add(Me.radioMonthly)
			Me.radGroupBox1.Controls.Add(Me.radioWeeklyCalendar)
			Me.radGroupBox1.Controls.Add(Me.radioWeekly)
			Me.radGroupBox1.Controls.Add(Me.radioDaily)
			Me.radGroupBox1.HeaderText = "Print Style"
			Me.radGroupBox1.Location = New Point(10, 37)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(218, 178)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Print Style"

			' 
			' radioAgenda
			' 
			Me.radioAgenda.Anchor = AnchorStyles.Top
			Me.radioAgenda.Location = New Point(5, 145)
			Me.radioAgenda.Name = "radioAgenda"
			Me.radioAgenda.Size = New Size(81, 18)
			Me.radioAgenda.TabIndex = 4
			Me.radioAgenda.Text = "Agenda Style"
			' 
			' radioDetails
			' 
			Me.radioDetails.Anchor = AnchorStyles.Top
			Me.radioDetails.Location = New Point(5, 121)
			Me.radioDetails.Name = "radioDetails"
			Me.radioDetails.Size = New Size(81, 18)
			Me.radioDetails.TabIndex = 3
			Me.radioDetails.Text = "Details Style"
			' 
			' radioMonthly
			' 
			Me.radioMonthly.Anchor = AnchorStyles.Top
			Me.radioMonthly.Location = New Point(5, 97)
			Me.radioMonthly.Name = "radioMonthly"
			Me.radioMonthly.Size = New Size(89, 18)
			Me.radioMonthly.TabIndex = 2
			Me.radioMonthly.Text = "Monthly Style"
			' 
			' radioWeekly
			' 
			Me.radioWeekly.Anchor = AnchorStyles.Top
			Me.radioWeekly.Location = New Point(5, 49)
			Me.radioWeekly.Name = "radioWeekly"
			Me.radioWeekly.Size = New Size(84, 18)
			Me.radioWeekly.TabIndex = 1
			Me.radioWeekly.Text = "Weekly Style"
			' 
			' radioDaily
			' 
			Me.radioDaily.Anchor = AnchorStyles.Top
			Me.radioDaily.CheckState = CheckState.Checked
			Me.radioDaily.Location = New Point(5, 25)
			Me.radioDaily.Name = "radioDaily"
			Me.radioDaily.Size = New Size(72, 18)
			Me.radioDaily.TabIndex = 0
			Me.radioDaily.TabStop = True
			Me.radioDaily.Text = "Daily Style"
			Me.radioDaily.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' buttonPrint
			' 
			Me.buttonPrint.Anchor = AnchorStyles.Top
			Me.buttonPrint.Location = New Point(10, 229)
			Me.buttonPrint.Name = "buttonPrint"
			Me.buttonPrint.Size = New Size(218, 24)
			Me.buttonPrint.TabIndex = 2
			Me.buttonPrint.Text = "Print ..."
			' 
			' buttonPreview
			' 
			Me.buttonPreview.Anchor = AnchorStyles.Top
			Me.buttonPreview.Location = New Point(10, 267)
			Me.buttonPreview.Name = "buttonPreview"
			Me.buttonPreview.Size = New Size(218, 24)
			Me.buttonPreview.TabIndex = 3
			Me.buttonPreview.Text = "Print Preview"
			' 
			' buttonSettings
			' 
			Me.buttonSettings.Anchor = AnchorStyles.Top
			Me.buttonSettings.Location = New Point(10, 305)
			Me.buttonSettings.Name = "buttonSettings"
			Me.buttonSettings.Size = New Size(218, 24)
			Me.buttonSettings.TabIndex = 4
			Me.buttonSettings.Text = "Print Settings"
			' 
			' radioWeeklyCalendar
			' 
			Me.radioWeeklyCalendar.Anchor = AnchorStyles.Top
			Me.radioWeeklyCalendar.Location = New Point(5, 73)
			Me.radioWeeklyCalendar.Name = "radioWeeklyCalendar"
			Me.radioWeeklyCalendar.Size = New Size(131, 18)
			Me.radioWeeklyCalendar.TabIndex = 1
			Me.radioWeeklyCalendar.Text = "Weekly Calendar Style"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Name = "Form1"
			Me.Size = New Size(1883, 1012)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radSchedulerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radioAgenda, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioDetails, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioMonthly, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioWeekly, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioDaily, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonPrint, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonPreview, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonSettings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioWeeklyCalendar, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
		Private radPrintDocument1 As Telerik.WinControls.UI.RadPrintDocument
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radioDaily As Telerik.WinControls.UI.RadRadioButton
		Private radioWeekly As Telerik.WinControls.UI.RadRadioButton
		Private radioMonthly As Telerik.WinControls.UI.RadRadioButton
		Private radioDetails As Telerik.WinControls.UI.RadRadioButton
		Private radioAgenda As Telerik.WinControls.UI.RadRadioButton
		Private buttonPrint As Telerik.WinControls.UI.RadButton
		Private buttonPreview As Telerik.WinControls.UI.RadButton
		Private buttonSettings As Telerik.WinControls.UI.RadButton
		Private radioWeeklyCalendar As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace