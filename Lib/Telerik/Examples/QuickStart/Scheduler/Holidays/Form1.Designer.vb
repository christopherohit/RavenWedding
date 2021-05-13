Namespace Telerik.Examples.WinControls.Scheduler.Holidays
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
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.timePickerRulerStart = New Telerik.WinControls.UI.RadTimePicker()
			Me.timePickerRulerEnd = New Telerik.WinControls.UI.RadTimePicker()
			Me.radButtonImportFromOutlook = New Telerik.WinControls.UI.RadButton()
			Me.radCheckedDDLHolidays = New Telerik.WinControls.UI.RadCheckedDropDownList()
			Me.radCheckBoxColorCells = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timePickerRulerStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timePickerRulerEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonImportFromOutlook, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckedDDLHolidays, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxColorCells, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckBoxColorCells)
			Me.settingsPanel.Controls.Add(Me.radCheckedDDLHolidays)
			Me.settingsPanel.Controls.Add(Me.radButtonImportFromOutlook)
			Me.settingsPanel.Location = New Point(1065, 80)
			Me.settingsPanel.Size = New Size(230, 719)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButtonImportFromOutlook, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckedDDLHolidays, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxColorCells, 0)
			' 
			' radScheduler1
			' 
			dateTimeInterval1.End = New Date((CLng(0)))
			dateTimeInterval1.Start = New Date((CLng(0)))
			Me.radScheduler1.AccessibleInterval = dateTimeInterval1
			Me.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month
			Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.radScheduler1.Dock = DockStyle.Fill
			Me.radScheduler1.Location = New Point(0, 0)
			Me.radScheduler1.Name = "radScheduler1"
			schedulerDailyPrintStyle1.AppointmentFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			schedulerDailyPrintStyle1.DateEndRange = New Date(2014, 6, 15, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.DateHeadingFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			schedulerDailyPrintStyle1.DateStartRange = New Date(2014, 6, 10, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.PageHeadingFont = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
			Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle1
			Me.radScheduler1.Size = New Size(1503, 651)
			Me.radScheduler1.TabIndex = 2
			' 
			' timePickerRulerStart
			' 
			Me.timePickerRulerStart.Anchor = AnchorStyles.Top
			Me.timePickerRulerStart.Location = New Point(90, 3)
			Me.timePickerRulerStart.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
			Me.timePickerRulerStart.MinValue = New Date((CLng(0)))
			Me.timePickerRulerStart.Name = "timePickerRulerStart"
			Me.timePickerRulerStart.Size = New Size(107, 20)
			Me.timePickerRulerStart.TabIndex = 8
			Me.timePickerRulerStart.TabStop = False
			Me.timePickerRulerStart.Value = New Date(2014, 6, 9, 14, 58, 13, 0)
			' 
			' timePickerRulerEnd
			' 
			Me.timePickerRulerEnd.Anchor = AnchorStyles.Top
			Me.timePickerRulerEnd.Location = New Point(90, 29)
			Me.timePickerRulerEnd.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
			Me.timePickerRulerEnd.MinValue = New Date((CLng(0)))
			Me.timePickerRulerEnd.Name = "timePickerRulerEnd"
			Me.timePickerRulerEnd.Size = New Size(107, 20)
			Me.timePickerRulerEnd.TabIndex = 9
			Me.timePickerRulerEnd.TabStop = False
			Me.timePickerRulerEnd.Value = New Date(2014, 6, 9, 14, 58, 13, 0)
			' 
			' radButtonImportFromOutlook
			' 
			Me.radButtonImportFromOutlook.Anchor = AnchorStyles.Top
			Me.radButtonImportFromOutlook.Location = New Point(10, 49)
			Me.radButtonImportFromOutlook.Name = "radButtonImportFromOutlook"
			Me.radButtonImportFromOutlook.Size = New Size(210, 24)
			Me.radButtonImportFromOutlook.TabIndex = 1
			Me.radButtonImportFromOutlook.Text = "Import Outlook Holidays File"
'			Me.radButtonImportFromOutlook.Click += New System.EventHandler(Me.radButtonImportFromOutlook_Click)
			' 
			' radCheckedDDLHolidays
			' 
			Me.radCheckedDDLHolidays.Anchor = AnchorStyles.Top
			Me.radCheckedDDLHolidays.Location = New Point(10, 134)
			Me.radCheckedDDLHolidays.Name = "radCheckedDDLHolidays"
			Me.radCheckedDDLHolidays.NullText = "Holidays"
			Me.radCheckedDDLHolidays.Size = New Size(210, 20)
			Me.radCheckedDDLHolidays.TabIndex = 3
'			Me.radCheckedDDLHolidays.ItemCheckedChanged += New Telerik.WinControls.UI.RadCheckedListDataItemEventHandler(Me.radCheckedDDLHolidays_ItemCheckedChanged)
			' 
			' radCheckBoxColorCells
			' 
			Me.radCheckBoxColorCells.Anchor = AnchorStyles.Top
			Me.radCheckBoxColorCells.Location = New Point(10, 95)
			Me.radCheckBoxColorCells.Name = "radCheckBoxColorCells"
			Me.radCheckBoxColorCells.Size = New Size(85, 18)
			Me.radCheckBoxColorCells.TabIndex = 4
			Me.radCheckBoxColorCells.Text = "Colorize cells"
			Me.radCheckBoxColorCells.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBoxColorCells.CheckStateChanged += New System.EventHandler(Me.radCheckBoxColorCells_CheckStateChanged)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Name = "Form1"
			Me.Size = New Size(1513, 661)
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timePickerRulerStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timePickerRulerEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonImportFromOutlook, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckedDDLHolidays, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxColorCells, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

#End Region
        Private WithEvents radScheduler1 As Telerik.WinControls.UI.RadScheduler
        Private timePickerRulerStart As Telerik.WinControls.UI.RadTimePicker
		Private timePickerRulerEnd As Telerik.WinControls.UI.RadTimePicker
		Private WithEvents radCheckedDDLHolidays As Telerik.WinControls.UI.RadCheckedDropDownList
		Private WithEvents radButtonImportFromOutlook As Telerik.WinControls.UI.RadButton
		Private WithEvents radCheckBoxColorCells As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace