Namespace Telerik.Examples.WinControls.Scheduler.CustomElements
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
			Dim dateTimeInterval2 As New Telerik.WinControls.UI.DateTimeInterval()
			Dim schedulerDailyPrintStyle2 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1281, 166)
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radScheduler1)
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(964, 662)
			Me.radPanel1.TabIndex = 2
			Me.radPanel1.Text = "radPanel1"
			' 
			' radScheduler1
			' 
			dateTimeInterval2.End = New Date((CLng(0)))
			dateTimeInterval2.Start = New Date((CLng(0)))
			Me.radScheduler1.AccessibleInterval = dateTimeInterval2
			Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.radScheduler1.DataSource = Nothing
			Me.radScheduler1.Dock = DockStyle.Fill
			Me.radScheduler1.Location = New Point(0, 0)
			Me.radScheduler1.Name = "radScheduler1"
			schedulerDailyPrintStyle2.AppointmentFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			schedulerDailyPrintStyle2.DateEndRange = New Date(2014, 6, 10, 0, 0, 0, 0)
			schedulerDailyPrintStyle2.DateHeadingFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			schedulerDailyPrintStyle2.DateStartRange = New Date(2014, 6, 5, 0, 0, 0, 0)
			schedulerDailyPrintStyle2.PageHeadingFont = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
			Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle2
			Me.radScheduler1.Size = New Size(964, 662)
			Me.radScheduler1.TabIndex = 0
			Me.radScheduler1.Text = "radScheduler1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1476, 1000)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler

	End Class
End Namespace