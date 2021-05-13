Namespace Telerik.Examples.WinControls.Scheduler.Reminder
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
			Me.components = New System.ComponentModel.Container()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			Me.radSchedulerReminder1 = New Telerik.WinControls.UI.RadSchedulerReminder(Me.components)
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButtonCustom = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonDefault = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radRadioButtonCustom, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonDefault, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Controls.Add(Me.radSpinEditor1)
			Me.settingsPanel.Controls.Add(Me.radButton1)
			Me.settingsPanel.Location = New Point(979, 1)
			Me.settingsPanel.Size = New Size(200, 476)

			Me.settingsPanel.Controls.SetChildIndex(Me.radButton1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditor1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = AnchorStyles.Top
			Me.radButton1.Location = New Point(10, 216)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(180, 24)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "Start"

			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(10, 57)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(129, 16)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "TimeInterval in seconds:"
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Anchor = AnchorStyles.Top
			Me.radSpinEditor1.Location = New Point(10, 79)
			Me.radSpinEditor1.Maximum = New Decimal(New Integer() { 1000000, 0, 0, 0})
			Me.radSpinEditor1.Minimum = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.ShowBorder = True
			Me.radSpinEditor1.Size = New Size(180, 20)
			Me.radSpinEditor1.TabIndex = 3
			Me.radSpinEditor1.TabStop = False
			Me.radSpinEditor1.Value = New Decimal(New Integer() { 5, 0, 0, 0})
			' 
			' radScheduler1
			' 
			Me.radScheduler1.DataSource = Nothing
			Me.radScheduler1.Dock = DockStyle.Fill
			Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radScheduler1.HeaderFormat = "dd dddd"
			Me.radScheduler1.Location = New Point(0, 74)
			Me.radScheduler1.Name = "radScheduler1"
			Me.radScheduler1.Size = New Size(1180, 404)
			Me.radScheduler1.TabIndex = 1
			Me.radScheduler1.Text = "radScheduler1"
			' 
			' radSchedulerNavigator1
			' 
			Me.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
			Me.radSchedulerNavigator1.Dock = DockStyle.Top
			Me.radSchedulerNavigator1.Location = New Point(0, 0)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.NavigationStep = 1
			Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New Size(1180, 74)
			Me.radSchedulerNavigator1.TabIndex = 2
			Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
			' 
			' radSchedulerReminder1
			' 
			Me.radSchedulerReminder1.AssociatedScheduler = Me.radScheduler1
			'this.radSchedulerReminder1.StartNotification = System.TimeSpan.Parse("00:15:00");
			Me.radSchedulerReminder1.TimeInterval = 60000
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonCustom)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonDefault)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(0)
			Me.radGroupBox1.HeaderText = "Alarm Form"
			Me.radGroupBox1.Location = New Point(10, 110)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 80)
			Me.radGroupBox1.TabIndex = 4
			Me.radGroupBox1.Text = "Alarm Form"
			' 
			' radRadioButtonCustom
			' 
			Me.radRadioButtonCustom.Location = New Point(13, 47)
			Me.radRadioButtonCustom.Name = "radRadioButtonCustom"
			Me.radRadioButtonCustom.Size = New Size(143, 18)
			Me.radRadioButtonCustom.TabIndex = 1
			Me.radRadioButtonCustom.Text = "Custom Alarm Form"

			' 
			' radRadioButtonDefault
			' 
			Me.radRadioButtonDefault.Location = New Point(13, 23)
			Me.radRadioButtonDefault.Name = "radRadioButtonDefault"
			Me.radRadioButtonDefault.Size = New Size(110, 18)
			Me.radRadioButtonDefault.TabIndex = 0
			Me.radRadioButtonDefault.Text = "Default"
			Me.radRadioButtonDefault.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Name = "Form1"
			Me.Size = New Size(1180, 478)
			Me.Controls.SetChildIndex(Me.radSchedulerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radRadioButtonCustom, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonDefault, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radSchedulerReminder1 As Telerik.WinControls.UI.RadSchedulerReminder
		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radRadioButtonCustom As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButtonDefault As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace