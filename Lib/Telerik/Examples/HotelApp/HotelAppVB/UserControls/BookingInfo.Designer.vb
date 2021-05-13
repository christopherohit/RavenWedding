Namespace CustomControls
	Partial Public Class BookingInfo
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
			Dim tableViewDefinition1 As New Telerik.WinControls.UI.TableViewDefinition()
			Me.headerContainer = New Telerik.WinControls.UI.RadPanel()
			Me.bookingInfoLabel = New Telerik.WinControls.UI.RadLabel()
			Me.closeButton = New Telerik.WinControls.UI.RadButton()
			Me.roomImageBox = New Telerik.WinControls.UI.RadPanel()
			Me.bookingStatusLabel = New Telerik.WinControls.UI.RadLabel()
			Me.bookingStatusDropDown = New Telerik.WinControls.UI.RadDropDownList()
			Me.bookingStatusContainer = New Telerik.WinControls.UI.RadPanel()
			Me.bookingNameContainer = New Telerik.WinControls.UI.RadPanel()
			Me.bookingNameLabel = New Telerik.WinControls.UI.RadLabel()
			Me.dropDownSeparator = New Telerik.WinControls.UI.RadSeparator()
			Me.bookingRoomTypeIcon = New Telerik.WinControls.UI.RadLabel()
			Me.manageReservationContainer = New Telerik.WinControls.UI.RadPanel()
			Me.manageStatusLabel = New Telerik.WinControls.UI.RadLabel()
			Me.roomIdLabel = New Telerik.WinControls.UI.RadLabel()
			Me.bookingPriceLabel = New Telerik.WinControls.UI.RadLabel()
			Me.paymentSeparator = New Telerik.WinControls.UI.RadSeparator()
			Me.bookingDatesGrid = New Telerik.WinControls.UI.RadGridView()
			CType(Me.headerContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.headerContainer.SuspendLayout()
			CType(Me.bookingInfoLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.roomImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bookingStatusLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bookingStatusDropDown, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bookingStatusContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.bookingStatusContainer.SuspendLayout()
			CType(Me.bookingNameContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.bookingNameContainer.SuspendLayout()
			CType(Me.bookingNameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.bookingNameLabel.SuspendLayout()
			CType(Me.dropDownSeparator, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bookingRoomTypeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.manageReservationContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.manageReservationContainer.SuspendLayout()
			CType(Me.manageStatusLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.roomIdLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bookingPriceLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.bookingPriceLabel.SuspendLayout()
			CType(Me.paymentSeparator, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bookingDatesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bookingDatesGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' headerContainer
			' 
			Me.headerContainer.Controls.Add(Me.bookingInfoLabel)
			Me.headerContainer.Controls.Add(Me.closeButton)
			Me.headerContainer.Dock = DockStyle.Top
			Me.headerContainer.Location = New Point(0, 0)
			Me.headerContainer.Name = "headerContainer"
			Me.headerContainer.Size = New Size(270, 50)
			Me.headerContainer.TabIndex = 0
			' 
			' bookingInfoLabel
			' 
			Me.bookingInfoLabel.AutoSize = False
			Me.bookingInfoLabel.Dock = DockStyle.Fill
			Me.bookingInfoLabel.Location = New Point(0, 0)
			Me.bookingInfoLabel.Margin = New Padding(0)
			Me.bookingInfoLabel.Name = "bookingInfoLabel"
			Me.bookingInfoLabel.Size = New Size(240, 50)
			Me.bookingInfoLabel.TabIndex = 1
			Me.bookingInfoLabel.Text = "bookingInfoLabel"
			' 
			' closeButton
			' 
			Me.closeButton.Dock = DockStyle.Right
			Me.closeButton.Location = New Point(240, 0)
			Me.closeButton.Margin = New Padding(0)
			Me.closeButton.Name = "closeButton"
			Me.closeButton.Size = New Size(30, 50)
			Me.closeButton.TabIndex = 0
'			Me.closeButton.Click += New System.EventHandler(Me.closeButton_Click)
			' 
			' roomImageBox
			' 
			Me.roomImageBox.Dock = DockStyle.Top
			Me.roomImageBox.Location = New Point(0, 50)
			Me.roomImageBox.Margin = New Padding(0)
			Me.roomImageBox.Name = "roomImageBox"
			Me.roomImageBox.Size = New Size(270, 180)
			Me.roomImageBox.TabIndex = 1
			' 
			' bookingStatusLabel
			' 
			Me.bookingStatusLabel.AutoSize = False
			Me.bookingStatusLabel.Dock = DockStyle.Left
			Me.bookingStatusLabel.Location = New Point(0, 0)
			Me.bookingStatusLabel.Name = "bookingStatusLabel"
			Me.bookingStatusLabel.Size = New Size(60, 40)
			Me.bookingStatusLabel.TabIndex = 2
			Me.bookingStatusLabel.Text = "Status:"
			' 
			' bookingStatusDropDown
			' 
			Me.bookingStatusDropDown.AutoSize = False
			Me.bookingStatusDropDown.Dock = DockStyle.Fill
			Me.bookingStatusDropDown.Location = New Point(60, 0)
			Me.bookingStatusDropDown.Margin = New Padding(3, 3, 10, 3)
			Me.bookingStatusDropDown.Name = "bookingStatusDropDown"
			Me.bookingStatusDropDown.Size = New Size(210, 40)
			Me.bookingStatusDropDown.TabIndex = 3
			Me.bookingStatusDropDown.Text = "radDropDownList1"
			' 
			' bookingStatusContainer
			' 
			Me.bookingStatusContainer.Controls.Add(Me.bookingStatusDropDown)
			Me.bookingStatusContainer.Controls.Add(Me.bookingStatusLabel)
			Me.bookingStatusContainer.Dock = DockStyle.Top
			Me.bookingStatusContainer.Location = New Point(0, 230)
			Me.bookingStatusContainer.Name = "bookingStatusContainer"
			Me.bookingStatusContainer.Size = New Size(270, 40)
			Me.bookingStatusContainer.TabIndex = 4
			' 
			' bookingNameContainer
			' 
			Me.bookingNameContainer.Controls.Add(Me.bookingNameLabel)
			Me.bookingNameContainer.Dock = DockStyle.Top
			Me.bookingNameContainer.Location = New Point(0, 270)
			Me.bookingNameContainer.Name = "bookingNameContainer"
			Me.bookingNameContainer.Size = New Size(270, 70)
			Me.bookingNameContainer.TabIndex = 5
			' 
			' bookingNameLabel
			' 
			Me.bookingNameLabel.AutoSize = False
			Me.bookingNameLabel.Controls.Add(Me.dropDownSeparator)
			Me.bookingNameLabel.Controls.Add(Me.bookingRoomTypeIcon)
			Me.bookingNameLabel.Dock = DockStyle.Fill
			Me.bookingNameLabel.Location = New Point(0, 0)
			Me.bookingNameLabel.Name = "bookingNameLabel"
			Me.bookingNameLabel.Size = New Size(270, 70)
			Me.bookingNameLabel.TabIndex = 1
			' 
			' dropDownSeparator
			' 
			Me.dropDownSeparator.Location = New Point(70, 0)
			Me.dropDownSeparator.Name = "dropDownSeparator"
			Me.dropDownSeparator.Size = New Size(180, 10)
			Me.dropDownSeparator.TabIndex = 0
			Me.dropDownSeparator.Text = "radSeparator1"
			' 
			' bookingRoomTypeIcon
			' 
			Me.bookingRoomTypeIcon.AutoSize = False
			Me.bookingRoomTypeIcon.Dock = DockStyle.Right
			Me.bookingRoomTypeIcon.Location = New Point(200, 0)
			Me.bookingRoomTypeIcon.Name = "bookingRoomTypeIcon"
			Me.bookingRoomTypeIcon.Size = New Size(70, 70)
			Me.bookingRoomTypeIcon.TabIndex = 0
			' 
			' manageReservationContainer
			' 
			Me.manageReservationContainer.Controls.Add(Me.manageStatusLabel)
			Me.manageReservationContainer.Controls.Add(Me.roomIdLabel)
			Me.manageReservationContainer.Dock = DockStyle.Top
			Me.manageReservationContainer.Location = New Point(0, 340)
			Me.manageReservationContainer.Name = "manageReservationContainer"
			Me.manageReservationContainer.Size = New Size(270, 60)
			Me.manageReservationContainer.TabIndex = 6
			' 
			' manageStatusLabel
			' 
			Me.manageStatusLabel.AutoSize = False
			Me.manageStatusLabel.Dock = DockStyle.Right
			Me.manageStatusLabel.Location = New Point(120, 0)
			Me.manageStatusLabel.Name = "manageStatusLabel"
			Me.manageStatusLabel.Size = New Size(150, 60)
			Me.manageStatusLabel.TabIndex = 1
			Me.manageStatusLabel.Text = "Change reservation"
'			Me.manageStatusLabel.Click += New System.EventHandler(Me.manageStatusLabel_Click)
			' 
			' roomIdLabel
			' 
			Me.roomIdLabel.AutoSize = False
			Me.roomIdLabel.Dock = DockStyle.Fill
			Me.roomIdLabel.Location = New Point(0, 0)
			Me.roomIdLabel.Margin = New Padding(10, 3, 3, 3)
			Me.roomIdLabel.Name = "roomIdLabel"
			Me.roomIdLabel.Size = New Size(270, 60)
			Me.roomIdLabel.TabIndex = 0
			Me.roomIdLabel.Text = "radLabel1"
			' 
			' bookingPriceLabel
			' 
			Me.bookingPriceLabel.AutoSize = False
			Me.bookingPriceLabel.Controls.Add(Me.paymentSeparator)
			Me.bookingPriceLabel.Dock = DockStyle.Top
			Me.bookingPriceLabel.Location = New Point(0, 530)
			Me.bookingPriceLabel.Margin = New Padding(0)
			Me.bookingPriceLabel.Name = "bookingPriceLabel"
			Me.bookingPriceLabel.Size = New Size(270, 59)
			Me.bookingPriceLabel.TabIndex = 0
			Me.bookingPriceLabel.Text = "radLabel1"
			' 
			' paymentSeparator
			' 
			Me.paymentSeparator.Location = New Point(8, 3)
			Me.paymentSeparator.Name = "paymentSeparator"
			Me.paymentSeparator.Size = New Size(250, 4)
			Me.paymentSeparator.TabIndex = 0
			Me.paymentSeparator.Text = "radSeparator1"
			' 
			' bookingDatesGrid
			' 
			Me.bookingDatesGrid.Dock = DockStyle.Top
			Me.bookingDatesGrid.Location = New Point(0, 400)
			Me.bookingDatesGrid.Margin = New Padding(0)
			' 
			' 
			' 
			Me.bookingDatesGrid.MasterTemplate.ViewDefinition = tableViewDefinition1
			Me.bookingDatesGrid.Name = "bookingDatesGrid"
			Me.bookingDatesGrid.Size = New Size(270, 130)
			Me.bookingDatesGrid.TabIndex = 8
			Me.bookingDatesGrid.Text = "radGridView1"
			' 
			' BookingInfo
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.bookingPriceLabel)
			Me.Controls.Add(Me.bookingDatesGrid)
			Me.Controls.Add(Me.manageReservationContainer)
			Me.Controls.Add(Me.bookingNameContainer)
			Me.Controls.Add(Me.bookingStatusContainer)
			Me.Controls.Add(Me.roomImageBox)
			Me.Controls.Add(Me.headerContainer)
			Me.Name = "BookingInfo"
			Me.Size = New Size(270, 685)
			CType(Me.headerContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.headerContainer.ResumeLayout(False)
			CType(Me.bookingInfoLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.roomImageBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bookingStatusLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bookingStatusDropDown, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bookingStatusContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.bookingStatusContainer.ResumeLayout(False)
			CType(Me.bookingNameContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.bookingNameContainer.ResumeLayout(False)
			CType(Me.bookingNameLabel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.bookingNameLabel.ResumeLayout(False)
			CType(Me.dropDownSeparator, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bookingRoomTypeIcon, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.manageReservationContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.manageReservationContainer.ResumeLayout(False)
			CType(Me.manageStatusLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.roomIdLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bookingPriceLabel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.bookingPriceLabel.ResumeLayout(False)
			CType(Me.paymentSeparator, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bookingDatesGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bookingDatesGrid, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private headerContainer As Telerik.WinControls.UI.RadPanel
		Private bookingInfoLabel As Telerik.WinControls.UI.RadLabel
		Private WithEvents closeButton As Telerik.WinControls.UI.RadButton
		Private roomImageBox As Telerik.WinControls.UI.RadPanel
		Private bookingStatusLabel As Telerik.WinControls.UI.RadLabel
		Private bookingStatusDropDown As Telerik.WinControls.UI.RadDropDownList
		Private bookingStatusContainer As Telerik.WinControls.UI.RadPanel
		Private bookingNameContainer As Telerik.WinControls.UI.RadPanel
		Private bookingNameLabel As Telerik.WinControls.UI.RadLabel
		Private bookingRoomTypeIcon As Telerik.WinControls.UI.RadLabel
		Private manageReservationContainer As Telerik.WinControls.UI.RadPanel
		Private WithEvents manageStatusLabel As Telerik.WinControls.UI.RadLabel
		Private roomIdLabel As Telerik.WinControls.UI.RadLabel
		Private bookingDatesGrid As Telerik.WinControls.UI.RadGridView
		Private bookingPriceLabel As Telerik.WinControls.UI.RadLabel
		Private paymentSeparator As Telerik.WinControls.UI.RadSeparator
		Private dropDownSeparator As Telerik.WinControls.UI.RadSeparator

	End Class
End Namespace
