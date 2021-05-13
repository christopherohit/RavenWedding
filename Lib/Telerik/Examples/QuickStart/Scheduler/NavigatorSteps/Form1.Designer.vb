Namespace Telerik.Examples.WinControls.Scheduler.NavigatorSteps
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
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radComboBox1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckBox1)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(1016, 1)
			Me.settingsPanel.Size = New Size(200, 832)

			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox1, 0)
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radComboBox1)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditor1)
			Me.radGroupBox1.Controls.Add(Me.radLabel2)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(0)
			Me.radGroupBox1.HeaderText = "Navigator Step Settings"
			Me.radGroupBox1.Location = New Point(10, 83)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 131)
			Me.radGroupBox1.TabIndex = 5
			Me.radGroupBox1.Text = "Navigator Step Settings"
			' 
			' radComboBox1
			' 
			Me.radComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBox1.Location = New Point(14, 45)
			Me.radComboBox1.Name = "radComboBox1"
			' 
			' 
			' 
			Me.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBox1.Size = New Size(153, 20)
			Me.radComboBox1.TabIndex = 4
			Me.radComboBox1.TabStop = False
			Me.radComboBox1.Text = "radComboBox1"

			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Location = New Point(14, 95)
			Me.radSpinEditor1.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.ShowBorder = True
			Me.radSpinEditor1.Size = New Size(153, 20)
			Me.radSpinEditor1.TabIndex = 3
			Me.radSpinEditor1.TabStop = False
			Me.radSpinEditor1.Value = New Decimal(New Integer() { 1, 0, 0, 0})

			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(14, 74)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(31, 18)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "Step:"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(14, 24)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(58, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Step Type:"
			' 
			' radScheduler1
			' 
			Me.radScheduler1.DataSource = Nothing
			Me.radScheduler1.Dock = DockStyle.Fill
			Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radScheduler1.HeaderFormat = "MM/dd/yy (ddd)"
			Me.radScheduler1.Location = New Point(0, 78)
			Me.radScheduler1.Name = "radScheduler1"
			Me.radScheduler1.Size = New Size(1217, 756)
			Me.radScheduler1.TabIndex = 1
			Me.radScheduler1.Text = "radScheduler1"
			' 
			' radSchedulerNavigator1
			' 
			Me.radSchedulerNavigator1.AutoSize = True
			Me.radSchedulerNavigator1.DateFormat = "MMM dd, yyyy"
			Me.radSchedulerNavigator1.Dock = DockStyle.Top
			Me.radSchedulerNavigator1.Location = New Point(0, 0)
			Me.radSchedulerNavigator1.MinimumSize = New Size(400, 74)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.NavigationStep = 1
			Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.MinSize = New Size(400, 74)
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New Size(1217, 78)
			Me.radSchedulerNavigator1.TabIndex = 2
			Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Anchor = AnchorStyles.Top
			Me.radCheckBox1.Location = New Point(10, 53)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(129, 18)
			Me.radCheckBox1.TabIndex = 6
			Me.radCheckBox1.Text = "Automatic Navigation"
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Name = "Form1"
			Me.Size = New Size(1217, 834)
			Me.Controls.SetChildIndex(Me.radSchedulerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
		Private radComboBox1 As Telerik.WinControls.UI.RadDropDownList
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox

	End Class
End Namespace