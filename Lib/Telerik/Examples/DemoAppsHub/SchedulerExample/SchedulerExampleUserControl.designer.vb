Imports Microsoft.VisualBasic
Imports System
Namespace DemoAppsHub.SchedulerExample
	Public Partial Class SchedulerExampleUserControl
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dateTimeInterval2 As Telerik.WinControls.UI.DateTimeInterval = New Telerik.WinControls.UI.DateTimeInterval()
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radScheduler1
			' 
			dateTimeInterval2.End = New System.DateTime((CLng(Fix(0))))
			dateTimeInterval2.Start = New System.DateTime((CLng(Fix(0))))
			Me.radScheduler1.AccessibleInterval = dateTimeInterval2
			Me.radScheduler1.AppointmentTitleFormat = Nothing
			Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.radScheduler1.DataSource = Nothing
			Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radScheduler1.HeaderFormat = "dd dddd"
			Me.radScheduler1.Location = New System.Drawing.Point(0, 77)
			Me.radScheduler1.Name = "radScheduler1"
			Me.radScheduler1.Size = New System.Drawing.Size(995, 515)
			Me.radScheduler1.TabIndex = 1
			Me.radScheduler1.Tag = "DRTL"
			Me.radScheduler1.Text = "radScheduler1"
			' 
			' radSchedulerNavigator1
			' 
			Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1
			Me.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
			Me.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radSchedulerNavigator1.Location = New System.Drawing.Point(0, 0)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New System.Drawing.Size(995, 77)
			Me.radSchedulerNavigator1.TabIndex = 0
			Me.radSchedulerNavigator1.Tag = "DRTL"
			Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
			' 
			' SchedulerExampleUserControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Controls.Add(Me.radScheduler1)
			Me.Name = "SchedulerExampleUserControl"
			Me.Size = New System.Drawing.Size(800, 600)
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
	End Class
End Namespace
