Imports System.Drawing
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.Scheduler.AgendaView
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
			Dim listViewDataItem1 As New Telerik.WinControls.UI.ListViewDataItem("All Categories")
			Dim listViewDataItem2 As New Telerik.WinControls.UI.ListViewDataItem("Important")
			Dim listViewDataItem3 As New Telerik.WinControls.UI.ListViewDataItem("Business")
			Dim listViewDataItem4 As New Telerik.WinControls.UI.ListViewDataItem("Personal")
			Dim schedulerDailyPrintStyle1 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
			Me.leftSettingsPanel = New Telerik.WinControls.UI.RadScrollablePanel()
			Me.noGroupRadioButton = New Telerik.WinControls.UI.RadRadioButton()
			Me.groupRadioButton = New Telerik.WinControls.UI.RadRadioButton()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.resourceToggleButton3 = New Telerik.WinControls.UI.RadToggleButton()
			Me.resourceToggleButton2 = New Telerik.WinControls.UI.RadToggleButton()
			Me.resourceToggleButton1 = New Telerik.WinControls.UI.RadToggleButton()
			Me.speakersLabel = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckedListBox1 = New Telerik.WinControls.UI.RadCheckedListBox()
			Me.backgroundsLabel = New Telerik.WinControls.UI.RadLabel()
			Me.daysCountSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
			Me.daysCountLabel = New Telerik.WinControls.UI.RadLabel()
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.startDateLabel = New Telerik.WinControls.UI.RadLabel()
			Me.leftPanelHeaderLabel = New Telerik.WinControls.UI.RadLabel()
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			CType(Me.leftSettingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.leftSettingsPanel.SuspendLayout()
			CType(Me.noGroupRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.resourceToggleButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.resourceToggleButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.resourceToggleButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.speakersLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckedListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.backgroundsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.daysCountSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.daysCountLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.startDateLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.leftPanelHeaderLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' leftSettingsPanel
			' 
			Me.leftSettingsPanel.Controls.Add(Me.noGroupRadioButton)
			Me.leftSettingsPanel.Controls.Add(Me.groupRadioButton)
			Me.leftSettingsPanel.Controls.Add(Me.radLabel2)
			Me.leftSettingsPanel.Controls.Add(Me.resourceToggleButton3)
			Me.leftSettingsPanel.Controls.Add(Me.resourceToggleButton2)
			Me.leftSettingsPanel.Controls.Add(Me.resourceToggleButton1)
			Me.leftSettingsPanel.Controls.Add(Me.speakersLabel)
			Me.leftSettingsPanel.Controls.Add(Me.radCheckedListBox1)
			Me.leftSettingsPanel.Controls.Add(Me.backgroundsLabel)
			Me.leftSettingsPanel.Controls.Add(Me.daysCountSpinEditor)
			Me.leftSettingsPanel.Controls.Add(Me.daysCountLabel)
			Me.leftSettingsPanel.Controls.Add(Me.radCalendar1)
			Me.leftSettingsPanel.Controls.Add(Me.radLabel1)
			Me.leftSettingsPanel.Controls.Add(Me.startDateLabel)
			Me.leftSettingsPanel.Controls.Add(Me.leftPanelHeaderLabel)
			Me.leftSettingsPanel.Dock = System.Windows.Forms.DockStyle.Left
			Me.leftSettingsPanel.Location = New System.Drawing.Point(0, 0)
			Me.leftSettingsPanel.Name = "leftSettingsPanel"
			Me.leftSettingsPanel.Size = New System.Drawing.Size(278, 836)
			Me.leftSettingsPanel.TabIndex = 0
			' 
			' noGroupRadioButton
			' 
			Me.noGroupRadioButton.Dock = System.Windows.Forms.DockStyle.Top
			Me.noGroupRadioButton.Location = New System.Drawing.Point(0, 729)
			Me.noGroupRadioButton.Name = "noGroupRadioButton"
			Me.noGroupRadioButton.Size = New System.Drawing.Size(70, 20)
			Me.noGroupRadioButton.MinimumSize = New Size(180, 28)
			Me.noGroupRadioButton.TabIndex = 14
			Me.noGroupRadioButton.Text = "No Group"
			' 
			' groupRadioButton
			' 
			Me.groupRadioButton.Dock = System.Windows.Forms.DockStyle.Top
			Me.groupRadioButton.Location = New System.Drawing.Point(0, 711)
			Me.groupRadioButton.Name = "groupRadioButton"
			Me.groupRadioButton.Size = New System.Drawing.Size(93, 20)
			Me.groupRadioButton.MinimumSize = New Size(180, 28)
			Me.groupRadioButton.TabIndex = 13
			Me.groupRadioButton.Text = "Group by Date"
			' 
			' radLabel2
			' 
			Me.radLabel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.radLabel2.Location = New System.Drawing.Point(0, 693)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(72, 18)

			Me.radLabel2.TabIndex = 17
			Me.radLabel2.Text = "Agenda View"

			' 
			' resourceToggleButton3
			' 
			Me.resourceToggleButton3.Dock = System.Windows.Forms.DockStyle.Top
			Me.resourceToggleButton3.Image = My.Resources.bob45x45
			Me.resourceToggleButton3.Location = New System.Drawing.Point(0, 624)
			Me.resourceToggleButton3.Name = "resourceToggleButton3"
			Me.resourceToggleButton3.Size = New System.Drawing.Size(231, 65)
			Me.resourceToggleButton3.TabIndex = 10
			Me.resourceToggleButton3.Text = "Robert King"
			Me.resourceToggleButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.resourceToggleButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.resourceToggleButton3.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Image = My.Resources.bob45x45
			CType(Me.resourceToggleButton3.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.resourceToggleButton3.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.resourceToggleButton3.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Text = "Robert King"
			CType(Me.resourceToggleButton3.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Margin = New System.Windows.Forms.Padding(5, 5, 10, 5)
			' 
			' resourceToggleButton2
			' 
			Me.resourceToggleButton2.Dock = System.Windows.Forms.DockStyle.Top
			Me.resourceToggleButton2.Image = My.Resources.andrew45x45
			Me.resourceToggleButton2.Location = New System.Drawing.Point(0, 559)
			Me.resourceToggleButton2.Name = "resourceToggleButton2"
			Me.resourceToggleButton2.Size = New System.Drawing.Size(231, 65)
			Me.resourceToggleButton2.TabIndex = 9
			Me.resourceToggleButton2.Text = "Andrew Fuller"
			Me.resourceToggleButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.resourceToggleButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.resourceToggleButton2.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Image = My.Resources.andrew45x45
			CType(Me.resourceToggleButton2.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.resourceToggleButton2.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.resourceToggleButton2.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Text = "Andrew Fuller"
			CType(Me.resourceToggleButton2.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Margin = New System.Windows.Forms.Padding(5, 5, 10, 5)
			' 
			' resourceToggleButton1
			' 
			Me.resourceToggleButton1.Dock = System.Windows.Forms.DockStyle.Top
			Me.resourceToggleButton1.Image = My.Resources.nancy45x45
			Me.resourceToggleButton1.Location = New System.Drawing.Point(0, 494)
			Me.resourceToggleButton1.Name = "resourceToggleButton1"
			Me.resourceToggleButton1.Size = New System.Drawing.Size(231, 65)
			Me.resourceToggleButton1.TabIndex = 8
			Me.resourceToggleButton1.Text = "Nancy Davolio"
			Me.resourceToggleButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.resourceToggleButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.resourceToggleButton1.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Image = My.Resources.nancy45x45
			CType(Me.resourceToggleButton1.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.resourceToggleButton1.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.resourceToggleButton1.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Text = "Nancy Davolio"
			CType(Me.resourceToggleButton1.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Margin = New System.Windows.Forms.Padding(5, 5, 10, 5)
			' 
			' speakersLabel
			' 
			Me.speakersLabel.Dock = System.Windows.Forms.DockStyle.Top
			Me.speakersLabel.Location = New System.Drawing.Point(0, 476)
			Me.speakersLabel.Name = "speakersLabel"
			Me.speakersLabel.Size = New System.Drawing.Size(111, 18)
			Me.speakersLabel.TabIndex = 7
			Me.speakersLabel.Text = "Conference Speakers"
			' 
			' radCheckedListBox1
			' 
			Me.radCheckedListBox1.Dock = System.Windows.Forms.DockStyle.Top
			listViewDataItem1.Text = "All Categories"
			listViewDataItem1.Tag = 0
			listViewDataItem2.Text = "Important"
			listViewDataItem2.Tag = 2
			listViewDataItem3.Text = "Business"
			listViewDataItem3.Tag = 3
			listViewDataItem4.Text = "Personal"
			listViewDataItem4.Tag = 4
			Me.radCheckedListBox1.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() { listViewDataItem1, listViewDataItem2, listViewDataItem3, listViewDataItem4 })
			Me.radCheckedListBox1.Location = New System.Drawing.Point(0, 336)
			Me.radCheckedListBox1.Name = "radCheckedListBox1"
			Me.radCheckedListBox1.Size = New System.Drawing.Size(231, 140)
			Me.radCheckedListBox1.TabIndex = 5
			' 
			' backgroundsLabel
			' 
			Me.backgroundsLabel.Dock = System.Windows.Forms.DockStyle.Top
			Me.backgroundsLabel.Location = New System.Drawing.Point(0, 318)
			Me.backgroundsLabel.Name = "backgroundsLabel"
			Me.backgroundsLabel.Size = New System.Drawing.Size(74, 18)
			Me.backgroundsLabel.TabIndex = 16
			Me.backgroundsLabel.Text = "All categories"
			' 
			' daysCountSpinEditor
			' 
			Me.daysCountSpinEditor.AutoSize = False
			Me.daysCountSpinEditor.Dock = System.Windows.Forms.DockStyle.Top
			Me.daysCountSpinEditor.Location = New System.Drawing.Point(0, 298)
			Me.daysCountSpinEditor.Name = "daysCountSpinEditor"
			Me.daysCountSpinEditor.Size = New System.Drawing.Size(231, 24)
			Me.daysCountSpinEditor.TabIndex = 15
			Me.daysCountSpinEditor.TabStop = False
			' 
			' daysCountLabel
			' 
			Me.daysCountLabel.Dock = System.Windows.Forms.DockStyle.Top
			Me.daysCountLabel.Location = New System.Drawing.Point(0, 280)
			Me.daysCountLabel.Name = "daysCountLabel"
			Me.daysCountLabel.Size = New System.Drawing.Size(66, 18)
			Me.daysCountLabel.TabIndex = 4
			Me.daysCountLabel.Text = "Days Count:"
			' 
			' radCalendar1
			' 
			Me.radCalendar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radCalendar1.Location = New System.Drawing.Point(0, 53)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.Size = New System.Drawing.Size(231, 227)
			Me.radCalendar1.TabIndex = 3
			' 
			' radLabel1
			' 
			Me.radLabel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radLabel1.Location = New System.Drawing.Point(0, 35)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(129, 18)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "Pick your event start day"
			' 
			' startDateLabel
			' 
			Me.startDateLabel.Dock = System.Windows.Forms.DockStyle.Top
			Me.startDateLabel.Location = New System.Drawing.Point(0, 18)
			Me.startDateLabel.Name = "startDateLabel"
			Me.startDateLabel.Size = New System.Drawing.Size(60, 17)
			Me.startDateLabel.TabIndex = 1
			Me.startDateLabel.Text = "<html><b>Start Date:"
			' 
			' leftPanelHeaderLabel
			' 
			Me.leftPanelHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top
			Me.leftPanelHeaderLabel.Location = New System.Drawing.Point(0, 0)
			Me.leftPanelHeaderLabel.Name = "leftPanelHeaderLabel"
			Me.leftPanelHeaderLabel.Size = New System.Drawing.Size(150, 18)
			Me.leftPanelHeaderLabel.TabIndex = 0
			Me.leftPanelHeaderLabel.Text = "2018 CONFERENCE AGENDA"
			' 
			' radSchedulerNavigator1
			' 
			Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1
			Me.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
			Me.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radSchedulerNavigator1.Location = New System.Drawing.Point(231, 0)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New System.Drawing.Size(851, 77)
			Me.radSchedulerNavigator1.TabIndex = 1
			' 
			' radScheduler1
			' 
			Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScheduler1.Location = New System.Drawing.Point(231, 77)
			Me.radScheduler1.Name = "radScheduler1"
			schedulerDailyPrintStyle1.AppointmentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			schedulerDailyPrintStyle1.DateEndRange = New Date(2018, 8, 19, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			schedulerDailyPrintStyle1.DateStartRange = New Date(2018, 8, 14, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold)
			Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle1
			Me.radScheduler1.Size = New System.Drawing.Size(851, 759)
			Me.radScheduler1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1082, 836)
			Me.Controls.Add(Me.radScheduler1)
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Controls.Add(Me.leftSettingsPanel)
			Me.Name = "Form1"
			Me.Text = "RadForm2"
			CType(Me.leftSettingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.leftSettingsPanel.ResumeLayout(False)
			Me.leftSettingsPanel.PerformLayout()
			CType(Me.noGroupRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.resourceToggleButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.resourceToggleButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.resourceToggleButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.speakersLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckedListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.backgroundsLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.daysCountSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.daysCountLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.startDateLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.leftPanelHeaderLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

			AdjustFontsAndMargins()
		End Sub

		Private Sub AdjustFontsAndMargins()
			Me.leftPanelHeaderLabel.Font = defaultFontHeader
			Me.startDateLabel.Font = defaultFontBold
			Me.radLabel1.Font = defaultFont
			Me.radLabel2.Font = defaultFontBold
			Me.speakersLabel.Font = defaultFontBold
			Me.daysCountLabel.Font = defaultFontBold
			Me.backgroundsLabel.Font = defaultFontBold

			Me.resourceToggleButton1.Image = My.Resources.nancy45x45
			Me.resourceToggleButton1.Height = 65
			Me.resourceToggleButton1.ButtonElement.Margin = New System.Windows.Forms.Padding(12, 5, 10, 5)
			Me.resourceToggleButton1.Font = defaultFont

			Me.resourceToggleButton1.ButtonElement.ImagePrimitive.Margin = New Padding(0, 0, 3, 0)
			Me.resourceToggleButton2.ButtonElement.ImagePrimitive.Margin = New Padding(0, 0, 3, 0)
			Me.resourceToggleButton3.ButtonElement.ImagePrimitive.Margin = New Padding(0, 0, 3, 0)

			Me.resourceToggleButton2.Height = 65
			Me.resourceToggleButton2.ButtonElement.Margin = New System.Windows.Forms.Padding(12, 5, 10, 5)
			Me.resourceToggleButton2.Font = defaultFont

			Me.resourceToggleButton3.Height = 65
			Me.resourceToggleButton3.ButtonElement.Margin = New System.Windows.Forms.Padding(12, 5, 10, 5)
			Me.resourceToggleButton3.Font = defaultFont

			Me.leftPanelHeaderLabel.LabelElement.Margin = New Padding(8, 10, 0, 0)
			Me.startDateLabel.LabelElement.Margin = New Padding(10, 20, 0, 0)

			Me.daysCountLabel.LabelElement.Margin = New Padding(10, 10, 0,5)

			Me.radLabel1.LabelElement.Margin = New Padding(8, 10, 0, 5)
			Me.radLabel2.LabelElement.Margin = New Padding(8, 10, 0, 0)
			Me.speakersLabel.LabelElement.Margin = defaultPadding
			Me.backgroundsLabel.LabelElement.Margin = defaultPadding
			Me.radCalendar1.CalendarElement.DrawBorder = False
			Me.radCalendar1.CalendarElement.Margin = New Padding(12, 0, 10, 0)

			Me.radCheckedListBox1.ListViewElement.DrawBorder = False
			Me.radCheckedListBox1.ListViewElement.ViewElement.DrawBorder = False
			Me.groupRadioButton.ButtonElement.Margin = New Padding(10, 5, 0, 0)
			Me.noGroupRadioButton.ButtonElement.Margin = New Padding(10, 5, 0, 0)
			Me.groupRadioButton.ButtonElement.TextElement.Font = defaultFont
			Me.noGroupRadioButton.ButtonElement.TextElement.Font = defaultFont
			Me.groupRadioButton.ButtonElement.CheckMarkPrimitive.Margin = New Padding(0, 0, 8, 0)
			Me.noGroupRadioButton.ButtonElement.CheckMarkPrimitive.Margin = New Padding(0, 0, 8, 0)
			Me.daysCountSpinEditor.SpinElement.Margin = New Padding(12, 0, 10, 0)
			Me.daysCountSpinEditor.SpinElement.TextBoxItem.Margin = New Padding(0)

			Me.radCheckedListBox1.ListViewElement.ViewElement.BackColor = Color.Transparent
		End Sub

		#End Region

		Private leftSettingsPanel As Telerik.WinControls.UI.RadScrollablePanel
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private leftPanelHeaderLabel As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private startDateLabel As Telerik.WinControls.UI.RadLabel
		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private daysCountLabel As Telerik.WinControls.UI.RadLabel
		Private radCheckedListBox1 As Telerik.WinControls.UI.RadCheckedListBox
		Private resourceToggleButton3 As Telerik.WinControls.UI.RadToggleButton
		Private resourceToggleButton2 As Telerik.WinControls.UI.RadToggleButton
		Private resourceToggleButton1 As Telerik.WinControls.UI.RadToggleButton
		Private speakersLabel As Telerik.WinControls.UI.RadLabel
		Private noGroupRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private groupRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private daysCountSpinEditor As Telerik.WinControls.UI.RadSpinEditor
		Private backgroundsLabel As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace