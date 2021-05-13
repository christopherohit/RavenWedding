Namespace HotelApp
	Partial Public Class RoomDetailsUC
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
			Dim schedulerDailyPrintStyle1 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
			Me.headerPanel = New Telerik.WinControls.UI.RadPanel()
			Me.searchPanel = New Telerik.WinControls.UI.RadPanel()
			Me.roomDetailsSearchDropDown = New HotelApp.SearchDropDownList()
			Me.statusLabel = New Telerik.WinControls.UI.RadLabel()
			Me.typeLabel = New Telerik.WinControls.UI.RadLabel()
			Me.roomIdLabel = New Telerik.WinControls.UI.RadLabel()
			Me.backButton = New Telerik.WinControls.UI.RadButton()
			Me.guestPanel = New Telerik.WinControls.UI.RadPanel()
			Me.updateButton = New Telerik.WinControls.UI.RadButton()
			Me.needsRepairsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
			Me.prioritySeparator = New Telerik.WinControls.UI.RadSeparator()
			Me.priorityDropDown = New Telerik.WinControls.UI.RadDropDownList()
			Me.priorityHeader = New Telerik.WinControls.UI.RadLabel()
			Me.statusSeparator = New Telerik.WinControls.UI.RadSeparator()
			Me.statusDropDown = New Telerik.WinControls.UI.RadDropDownList()
			Me.statusHeaderLabel = New Telerik.WinControls.UI.RadLabel()
			Me.houseKeepingHeaderLabel = New Telerik.WinControls.UI.RadLabel()
			Me.guestSeparator = New Telerik.WinControls.UI.RadSeparator()
			Me.addGuestPanel = New Telerik.WinControls.UI.RadPanel()
			Me.addGuestLabel = New Telerik.WinControls.UI.RadLabel()
			Me.addGuestButton = New Telerik.WinControls.UI.RadButton()
			Me.guestNamePanel = New Telerik.WinControls.UI.RadPanel()
			Me.guestNameLabel = New Telerik.WinControls.UI.RadLabel()
			Me.roomIconLabel = New Telerik.WinControls.UI.RadLabel()
			Me.guestHeaderPanel = New Telerik.WinControls.UI.RadPanel()
			Me.guestHeaderLabel = New Telerik.WinControls.UI.RadLabel()
			Me.closeButton = New Telerik.WinControls.UI.RadButton()
			Me.schedulePanel = New Telerik.WinControls.UI.RadPanel()
			Me.roomsScheduler = New Telerik.WinControls.UI.RadScheduler()
			Me.roomsSchedulerNavigator = New Telerik.WinControls.UI.RadSchedulerNavigator()
			CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.headerPanel.SuspendLayout()
			CType(Me.searchPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.searchPanel.SuspendLayout()
			CType(Me.roomDetailsSearchDropDown, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statusLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.typeLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.roomIdLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.guestPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.guestPanel.SuspendLayout()
			CType(Me.updateButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.needsRepairsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.needsRepairsCheckBox.SuspendLayout()
			CType(Me.prioritySeparator, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.priorityDropDown, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.priorityHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.priorityHeader.SuspendLayout()
			CType(Me.statusSeparator, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statusDropDown, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statusHeaderLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.houseKeepingHeaderLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.houseKeepingHeaderLabel.SuspendLayout()
			CType(Me.guestSeparator, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.addGuestPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.addGuestPanel.SuspendLayout()
			CType(Me.addGuestLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.addGuestButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.guestNamePanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.guestNamePanel.SuspendLayout()
			CType(Me.guestNameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.roomIconLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.guestHeaderPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.guestHeaderPanel.SuspendLayout()
			CType(Me.guestHeaderLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulePanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.schedulePanel.SuspendLayout()
			CType(Me.roomsScheduler, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.roomsSchedulerNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' headerPanel
			' 
			Me.headerPanel.Controls.Add(Me.searchPanel)
			Me.headerPanel.Controls.Add(Me.statusLabel)
			Me.headerPanel.Controls.Add(Me.typeLabel)
			Me.headerPanel.Controls.Add(Me.roomIdLabel)
			Me.headerPanel.Controls.Add(Me.backButton)
			Me.headerPanel.Dock = DockStyle.Top
			Me.headerPanel.Location = New Point(0, 0)
			Me.headerPanel.Name = "headerPanel"
			Me.headerPanel.Size = New Size(1360, 60)
			Me.headerPanel.TabIndex = 0
			' 
			' searchPanel
			' 
			Me.searchPanel.Controls.Add(Me.roomDetailsSearchDropDown)
			Me.searchPanel.Dock = DockStyle.Right
			Me.searchPanel.Location = New Point(710, 0)
			Me.searchPanel.Name = "searchPanel"
			Me.searchPanel.Size = New Size(650, 60)
			Me.searchPanel.TabIndex = 5
			' 
			' roomDetailsSearchDropDown
			' 
			Me.roomDetailsSearchDropDown.AutoSize = False
			Me.roomDetailsSearchDropDown.Location = New Point(3, 14)
			Me.roomDetailsSearchDropDown.Name = "roomDetailsSearchDropDown"
			Me.roomDetailsSearchDropDown.NullText = "Search by room# or guest name"
			' 
			' 
			' 
			Me.roomDetailsSearchDropDown.RootElement.EnableElementShadow = False
			Me.roomDetailsSearchDropDown.Size = New Size(620, 35)
			Me.roomDetailsSearchDropDown.TabIndex = 0
			' 
			' statusLabel
			' 
			Me.statusLabel.AutoSize = False
			Me.statusLabel.Dock = DockStyle.Fill
			Me.statusLabel.Location = New Point(265, 0)
			Me.statusLabel.Name = "statusLabel"
			Me.statusLabel.Size = New Size(1095, 60)
			Me.statusLabel.TabIndex = 4
			Me.statusLabel.Text = "radLabel1"
			' 
			' typeLabel
			' 
			Me.typeLabel.AutoSize = False
			Me.typeLabel.Dock = DockStyle.Left
			Me.typeLabel.Location = New Point(165, 0)
			Me.typeLabel.Name = "typeLabel"
			Me.typeLabel.Size = New Size(100, 60)
			Me.typeLabel.TabIndex = 3
			Me.typeLabel.Text = "radLabel1"
			' 
			' roomIdLabel
			' 
			Me.roomIdLabel.AutoSize = False
			Me.roomIdLabel.Dock = DockStyle.Left
			Me.roomIdLabel.Location = New Point(35, 0)
			Me.roomIdLabel.Name = "roomIdLabel"
			Me.roomIdLabel.Size = New Size(130, 60)
			Me.roomIdLabel.TabIndex = 2
			Me.roomIdLabel.Text = "radLabel1"
			' 
			' backButton
			' 
			Me.backButton.Dock = DockStyle.Left
			Me.backButton.Location = New Point(0, 0)
			Me.backButton.Name = "backButton"
			Me.backButton.Size = New Size(35, 60)
			Me.backButton.TabIndex = 1
			Me.backButton.Text = "radButton1"
			' 
			' guestPanel
			' 
			Me.guestPanel.Controls.Add(Me.updateButton)
			Me.guestPanel.Controls.Add(Me.needsRepairsCheckBox)
			Me.guestPanel.Controls.Add(Me.priorityDropDown)
			Me.guestPanel.Controls.Add(Me.priorityHeader)
			Me.guestPanel.Controls.Add(Me.statusDropDown)
			Me.guestPanel.Controls.Add(Me.statusHeaderLabel)
			Me.guestPanel.Controls.Add(Me.houseKeepingHeaderLabel)
			Me.guestPanel.Controls.Add(Me.addGuestPanel)
			Me.guestPanel.Controls.Add(Me.guestNamePanel)
			Me.guestPanel.Controls.Add(Me.guestHeaderPanel)
			Me.guestPanel.Dock = DockStyle.Right
			Me.guestPanel.Location = New Point(1090, 60)
			Me.guestPanel.Name = "guestPanel"
			Me.guestPanel.Size = New Size(270, 740)
			Me.guestPanel.TabIndex = 1
			' 
			' updateButton
			' 
			Me.updateButton.Location = New Point(17, 405)
			Me.updateButton.Name = "updateButton"
			Me.updateButton.Size = New Size(100, 24)
			Me.updateButton.TabIndex = 11
			Me.updateButton.Text = "Update"
'			Me.updateButton.Click += New System.EventHandler(Me.updateButton_Click)
			' 
			' needsRepairsCheckBox
			' 
			Me.needsRepairsCheckBox.AutoSize = False
			Me.needsRepairsCheckBox.Controls.Add(Me.prioritySeparator)
			Me.needsRepairsCheckBox.Dock = DockStyle.Top
			Me.needsRepairsCheckBox.Location = New Point(0, 348)
			Me.needsRepairsCheckBox.Name = "needsRepairsCheckBox"
			Me.needsRepairsCheckBox.Size = New Size(270, 50)
			Me.needsRepairsCheckBox.TabIndex = 0
			Me.needsRepairsCheckBox.Text = "Needs repairs"
			' 
			' prioritySeparator
			' 
			Me.prioritySeparator.Location = New Point(10, 3)
			Me.prioritySeparator.Name = "prioritySeparator"
			Me.prioritySeparator.Size = New Size(230, 4)
			Me.prioritySeparator.TabIndex = 10
			Me.prioritySeparator.Text = "radSeparator2"
			' 
			' priorityDropDown
			' 
			Me.priorityDropDown.AutoSize = False
			Me.priorityDropDown.Dock = DockStyle.Top
			Me.priorityDropDown.Location = New Point(0, 308)
			Me.priorityDropDown.Name = "priorityDropDown"
			Me.priorityDropDown.Size = New Size(270, 40)
			Me.priorityDropDown.TabIndex = 9
			Me.priorityDropDown.Text = "radDropDownList1"
			' 
			' priorityHeader
			' 
			Me.priorityHeader.AutoSize = False
			Me.priorityHeader.Controls.Add(Me.statusSeparator)
			Me.priorityHeader.Dock = DockStyle.Top
			Me.priorityHeader.Location = New Point(0, 258)
			Me.priorityHeader.Name = "priorityHeader"
			Me.priorityHeader.Size = New Size(270, 50)
			Me.priorityHeader.TabIndex = 8
			Me.priorityHeader.Text = "Priority:"
			' 
			' statusSeparator
			' 
			Me.statusSeparator.Location = New Point(10, 0)
			Me.statusSeparator.Name = "statusSeparator"
			Me.statusSeparator.Size = New Size(230, 4)
			Me.statusSeparator.TabIndex = 7
			Me.statusSeparator.Text = "radSeparator1"
			' 
			' statusDropDown
			' 
			Me.statusDropDown.AutoSize = False
			Me.statusDropDown.Dock = DockStyle.Top
			Me.statusDropDown.Location = New Point(0, 218)
			Me.statusDropDown.Name = "statusDropDown"
			Me.statusDropDown.Size = New Size(270, 40)
			Me.statusDropDown.TabIndex = 6
			Me.statusDropDown.Text = "radDropDownList1"
			' 
			' statusHeaderLabel
			' 
			Me.statusHeaderLabel.AutoSize = False
			Me.statusHeaderLabel.Dock = DockStyle.Top
			Me.statusHeaderLabel.Location = New Point(0, 200)
			Me.statusHeaderLabel.Name = "statusHeaderLabel"
			Me.statusHeaderLabel.Size = New Size(270, 18)
			Me.statusHeaderLabel.TabIndex = 5
			Me.statusHeaderLabel.Text = "Status:"
			' 
			' houseKeepingHeaderLabel
			' 
			Me.houseKeepingHeaderLabel.AutoSize = False
			Me.houseKeepingHeaderLabel.Controls.Add(Me.guestSeparator)
			Me.houseKeepingHeaderLabel.Dock = DockStyle.Top
			Me.houseKeepingHeaderLabel.Location = New Point(0, 150)
			Me.houseKeepingHeaderLabel.Name = "houseKeepingHeaderLabel"
			Me.houseKeepingHeaderLabel.Size = New Size(270, 50)
			Me.houseKeepingHeaderLabel.TabIndex = 4
			Me.houseKeepingHeaderLabel.Text = "HOUSE KEEPING STATUS"
			' 
			' guestSeparator
			' 
			Me.guestSeparator.Location = New Point(10, 0)
			Me.guestSeparator.Name = "guestSeparator"
			Me.guestSeparator.Size = New Size(250, 4)
			Me.guestSeparator.TabIndex = 3
			Me.guestSeparator.Text = "radSeparator1"
			' 
			' addGuestPanel
			' 
			Me.addGuestPanel.Controls.Add(Me.addGuestLabel)
			Me.addGuestPanel.Controls.Add(Me.addGuestButton)
			Me.addGuestPanel.Dock = DockStyle.Top
			Me.addGuestPanel.Location = New Point(0, 100)
			Me.addGuestPanel.Name = "addGuestPanel"
			Me.addGuestPanel.Size = New Size(270, 50)
			Me.addGuestPanel.TabIndex = 2
			' 
			' addGuestLabel
			' 
			Me.addGuestLabel.AutoSize = False
			Me.addGuestLabel.Dock = DockStyle.Fill
			Me.addGuestLabel.Location = New Point(30, 0)
			Me.addGuestLabel.Name = "addGuestLabel"
			Me.addGuestLabel.Size = New Size(240, 50)
			Me.addGuestLabel.TabIndex = 4
			Me.addGuestLabel.Text = "Add guest"
			' 
			' addGuestButton
			' 
			Me.addGuestButton.Dock = DockStyle.Left
			Me.addGuestButton.Location = New Point(0, 0)
			Me.addGuestButton.Name = "addGuestButton"
			Me.addGuestButton.Size = New Size(30, 50)
			Me.addGuestButton.TabIndex = 3
			' 
			' guestNamePanel
			' 
			Me.guestNamePanel.Controls.Add(Me.guestNameLabel)
			Me.guestNamePanel.Controls.Add(Me.roomIconLabel)
			Me.guestNamePanel.Dock = DockStyle.Top
			Me.guestNamePanel.Location = New Point(0, 50)
			Me.guestNamePanel.Name = "guestNamePanel"
			Me.guestNamePanel.Size = New Size(270, 50)
			Me.guestNamePanel.TabIndex = 1
			' 
			' guestNameLabel
			' 
			Me.guestNameLabel.AutoSize = False
			Me.guestNameLabel.Dock = DockStyle.Fill
			Me.guestNameLabel.Location = New Point(0, 0)
			Me.guestNameLabel.Name = "guestNameLabel"
			Me.guestNameLabel.Size = New Size(170, 50)
			Me.guestNameLabel.TabIndex = 1
			' 
			' roomIconLabel
			' 
			Me.roomIconLabel.AutoSize = False
			Me.roomIconLabel.Dock = DockStyle.Right
			Me.roomIconLabel.Location = New Point(170, 0)
			Me.roomIconLabel.Name = "roomIconLabel"
			Me.roomIconLabel.Size = New Size(100, 50)
			Me.roomIconLabel.TabIndex = 0
			' 
			' guestHeaderPanel
			' 
			Me.guestHeaderPanel.Controls.Add(Me.guestHeaderLabel)
			Me.guestHeaderPanel.Controls.Add(Me.closeButton)
			Me.guestHeaderPanel.Dock = DockStyle.Top
			Me.guestHeaderPanel.Location = New Point(0, 0)
			Me.guestHeaderPanel.Name = "guestHeaderPanel"
			Me.guestHeaderPanel.Size = New Size(270, 50)
			Me.guestHeaderPanel.TabIndex = 0
			' 
			' guestHeaderLabel
			' 
			Me.guestHeaderLabel.AutoSize = False
			Me.guestHeaderLabel.Dock = DockStyle.Fill
			Me.guestHeaderLabel.Location = New Point(0, 0)
			Me.guestHeaderLabel.Name = "guestHeaderLabel"
			Me.guestHeaderLabel.Size = New Size(240, 50)
			Me.guestHeaderLabel.TabIndex = 1
			Me.guestHeaderLabel.Text = "GUEST"
			' 
			' closeButton
			' 
			Me.closeButton.Dock = DockStyle.Right
			Me.closeButton.Location = New Point(240, 0)
			Me.closeButton.Name = "closeButton"
			Me.closeButton.Size = New Size(30, 50)
			Me.closeButton.TabIndex = 0
			' 
			' schedulePanel
			' 
			Me.schedulePanel.Controls.Add(Me.roomsScheduler)
			Me.schedulePanel.Controls.Add(Me.roomsSchedulerNavigator)
			Me.schedulePanel.Dock = DockStyle.Fill
			Me.schedulePanel.Location = New Point(0, 60)
			Me.schedulePanel.Name = "schedulePanel"
			Me.schedulePanel.Size = New Size(1090, 740)
			Me.schedulePanel.TabIndex = 2
			Me.schedulePanel.Text = "radPanel1"
			' 
			' roomsScheduler
			' 
			Me.roomsScheduler.Culture = New System.Globalization.CultureInfo("en-US")
			Me.roomsScheduler.Dock = DockStyle.Fill
			Me.roomsScheduler.Location = New Point(0, 77)
			Me.roomsScheduler.Name = "roomsScheduler"
			schedulerDailyPrintStyle1.AppointmentFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			schedulerDailyPrintStyle1.DateEndRange = New Date(2017, 7, 10, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.DateHeadingFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			schedulerDailyPrintStyle1.DateStartRange = New Date(2017, 7, 5, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.PageHeadingFont = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
			Me.roomsScheduler.PrintStyle = schedulerDailyPrintStyle1
			Me.roomsScheduler.Size = New Size(1090, 663)
			Me.roomsScheduler.TabIndex = 1
			Me.roomsScheduler.Text = "radScheduler1"
			' 
			' roomsSchedulerNavigator
			' 
			Me.roomsSchedulerNavigator.AssociatedScheduler = Me.roomsScheduler
			Me.roomsSchedulerNavigator.DateFormat = "yyyy/MM/dd"
			Me.roomsSchedulerNavigator.Dock = DockStyle.Top
			Me.roomsSchedulerNavigator.Location = New Point(0, 0)
			Me.roomsSchedulerNavigator.Name = "roomsSchedulerNavigator"
			Me.roomsSchedulerNavigator.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.roomsSchedulerNavigator.RootElement.StretchVertically = False
			Me.roomsSchedulerNavigator.Size = New Size(1090, 77)
			Me.roomsSchedulerNavigator.TabIndex = 0
			Me.roomsSchedulerNavigator.Text = "radSchedulerNavigator1"
			' 
			' RoomDetailsUC
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.schedulePanel)
			Me.Controls.Add(Me.guestPanel)
			Me.Controls.Add(Me.headerPanel)
			Me.Name = "RoomDetailsUC"
			Me.Size = New Size(1360, 800)
			CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.headerPanel.ResumeLayout(False)
			CType(Me.searchPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.searchPanel.ResumeLayout(False)
			CType(Me.roomDetailsSearchDropDown, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statusLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.typeLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.roomIdLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.guestPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.guestPanel.ResumeLayout(False)
			CType(Me.updateButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.needsRepairsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
			Me.needsRepairsCheckBox.ResumeLayout(False)
			CType(Me.prioritySeparator, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.priorityDropDown, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.priorityHeader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.priorityHeader.ResumeLayout(False)
			CType(Me.statusSeparator, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statusDropDown, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statusHeaderLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.houseKeepingHeaderLabel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.houseKeepingHeaderLabel.ResumeLayout(False)
			CType(Me.guestSeparator, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.addGuestPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.addGuestPanel.ResumeLayout(False)
			CType(Me.addGuestLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.addGuestButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.guestNamePanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.guestNamePanel.ResumeLayout(False)
			CType(Me.guestNameLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.roomIconLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.guestHeaderPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.guestHeaderPanel.ResumeLayout(False)
			CType(Me.guestHeaderLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulePanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.schedulePanel.ResumeLayout(False)
			Me.schedulePanel.PerformLayout()
			CType(Me.roomsScheduler, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.roomsSchedulerNavigator, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private headerPanel As Telerik.WinControls.UI.RadPanel
		Private guestPanel As Telerik.WinControls.UI.RadPanel
		Private schedulePanel As Telerik.WinControls.UI.RadPanel
		Private roomsScheduler As Telerik.WinControls.UI.RadScheduler
		Private roomsSchedulerNavigator As Telerik.WinControls.UI.RadSchedulerNavigator
		Private roomDetailsSearchDropDown As SearchDropDownList
		Private backButton As Telerik.WinControls.UI.RadButton
		Private roomIdLabel As Telerik.WinControls.UI.RadLabel
		Private typeLabel As Telerik.WinControls.UI.RadLabel
		Private statusLabel As Telerik.WinControls.UI.RadLabel
		Private guestHeaderPanel As Telerik.WinControls.UI.RadPanel
		Private closeButton As Telerik.WinControls.UI.RadButton
		Private guestHeaderLabel As Telerik.WinControls.UI.RadLabel
		Private guestNamePanel As Telerik.WinControls.UI.RadPanel
		Private guestNameLabel As Telerik.WinControls.UI.RadLabel
		Private roomIconLabel As Telerik.WinControls.UI.RadLabel
		Private addGuestPanel As Telerik.WinControls.UI.RadPanel
		Private guestSeparator As Telerik.WinControls.UI.RadSeparator
		Private addGuestButton As Telerik.WinControls.UI.RadButton
		Private addGuestLabel As Telerik.WinControls.UI.RadLabel
		Private statusHeaderLabel As Telerik.WinControls.UI.RadLabel
		Private houseKeepingHeaderLabel As Telerik.WinControls.UI.RadLabel
		Private statusSeparator As Telerik.WinControls.UI.RadSeparator
		Private statusDropDown As Telerik.WinControls.UI.RadDropDownList
		Private priorityDropDown As Telerik.WinControls.UI.RadDropDownList
		Private priorityHeader As Telerik.WinControls.UI.RadLabel
		Private needsRepairsCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private prioritySeparator As Telerik.WinControls.UI.RadSeparator
		Private WithEvents updateButton As Telerik.WinControls.UI.RadButton
		Private searchPanel As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace
