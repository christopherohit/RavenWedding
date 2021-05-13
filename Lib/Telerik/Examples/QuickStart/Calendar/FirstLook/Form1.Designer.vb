Namespace Telerik.Examples.WinControls.Calendar.FirstLook
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
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.cbTitleFormat = New Telerik.WinControls.UI.RadDropDownList()
			Me.lbRenderingDirection = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
			Me.chShowSelector = New Telerik.WinControls.UI.RadCheckBox()
			Me.chRowHeader = New Telerik.WinControls.UI.RadCheckBox()
			Me.chColumnHeader = New Telerik.WinControls.UI.RadCheckBox()
			Me.lbTitleFormat = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			Me.chNavigationButtons = New Telerik.WinControls.UI.RadCheckBox()
			Me.chFastNavigationButtons = New Telerik.WinControls.UI.RadCheckBox()
			Me.chViewHeader = New Telerik.WinControls.UI.RadCheckBox()
			Me.chAllowFishEye = New Telerik.WinControls.UI.RadCheckBox()
			Me.nudHeaderHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.nudHeaderWidth = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radioButton16 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioButton15 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.doubleBufferedTableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbTitleFormat, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbRenderingDirection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chShowSelector, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chColumnHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbTitleFormat, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chNavigationButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chFastNavigationButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chViewHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chAllowFishEye, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudHeaderHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudHeaderWidth, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton16, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			Me.doubleBufferedTableLayoutPanel2.SuspendLayout()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1107, 1)
			Me.settingsPanel.Margin = New Padding(4, 4, 4, 4)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Margin = New Padding(4, 4, 4, 4)
			Me.settingsPanel.PanelContainer.Size = New Size(324, 1030)
			Me.settingsPanel.Size = New Size(324, 1030)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.AllowColumnHeaderSelectors = True
			Me.radCalendar1.AllowFishEye = True
			Me.radCalendar1.AllowMultipleSelect = True
			Me.radCalendar1.AllowMultipleView = True
			Me.radCalendar1.AllowRowHeaderSelectors = True
			Me.radCalendar1.AllowViewSelector = True
			Me.radCalendar1.BackColor = Color.FromArgb((CInt((CByte(248)))), (CInt((CByte(248)))), (CInt((CByte(248)))))
			Me.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full
			Me.radCalendar1.FocusedDate = New Date(2013, 3, 11, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = Color.Black
			Me.radCalendar1.HeaderHeight = 23
			Me.radCalendar1.HeaderWidth = 23
			Me.radCalendar1.Location = New Point(0, 0)
			Me.radCalendar1.Margin = New Padding(4, 4, 4, 4)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.ShowFastNavigationButtons = False
			Me.radCalendar1.ShowFooter = True
			Me.radCalendar1.ShowRowHeaders = True
			Me.radCalendar1.ShowViewSelector = True
			Me.radCalendar1.Size = New Size(853, 539)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.ZoomFactor = 1.2F
			CType(Me.radCalendar1.GetChildAt(0), Telerik.WinControls.UI.RadCalendarElement).AllowFishEye = True
			CType(Me.radCalendar1.GetChildAt(0), Telerik.WinControls.UI.RadCalendarElement).ZoomFactor = 1.2F
			CType(Me.radCalendar1.GetChildAt(0), Telerik.WinControls.UI.RadCalendarElement).Padding = New Padding(4, 0, 0, 0)
			' 
			' cbTitleFormat
			' 
			Me.cbTitleFormat.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.cbTitleFormat.DropDownHeight = 141
			Me.cbTitleFormat.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.cbTitleFormat.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem1.Selected = True
			radListDataItem1.Text = "MMMM yyyy"
			radListDataItem2.Text = "MM/yy"
			radListDataItem3.Text = "MM-yy"
			radListDataItem4.Text = "MMM yyyy"
			Me.cbTitleFormat.Items.Add(radListDataItem1)
			Me.cbTitleFormat.Items.Add(radListDataItem2)
			Me.cbTitleFormat.Items.Add(radListDataItem3)
			Me.cbTitleFormat.Items.Add(radListDataItem4)
			Me.cbTitleFormat.Location = New Point(4, 484)
			Me.cbTitleFormat.Margin = New Padding(4, 4, 4, 4)
			Me.cbTitleFormat.MaxDropDownItems = 4
			Me.cbTitleFormat.Name = "cbTitleFormat"
			Me.cbTitleFormat.Size = New Size(259, 24)
			Me.cbTitleFormat.TabIndex = 1
			Me.cbTitleFormat.Text = "MMMM yyyy"
			' 
			' lbRenderingDirection
			' 
			Me.lbRenderingDirection.Location = New Point(4, 4)
			Me.lbRenderingDirection.Margin = New Padding(4, 4, 4, 4)
			Me.lbRenderingDirection.Name = "lbRenderingDirection"
			Me.lbRenderingDirection.Size = New Size(165, 22)
			Me.lbRenderingDirection.TabIndex = 4
			Me.lbRenderingDirection.Text = "Select rendering direction"
			Me.lbRenderingDirection.TextAlignment = ContentAlignment.TopLeft
			' 
			' radCheckBox3
			' 
			Me.radCheckBox3.Location = New Point(4, 244)
			Me.radCheckBox3.Margin = New Padding(4, 4, 4, 4)
			Me.radCheckBox3.Name = "radCheckBox3"
			Me.radCheckBox3.Size = New Size(98, 22)
			Me.radCheckBox3.TabIndex = 19
			Me.radCheckBox3.Text = "Right to left"
			' 
			' chShowSelector
			' 
			Me.chShowSelector.CheckState = CheckState.Checked
			Me.chShowSelector.Location = New Point(4, 100)
			Me.chShowSelector.Margin = New Padding(4, 4, 4, 4)
			Me.chShowSelector.Name = "chShowSelector"
			Me.chShowSelector.Size = New Size(110, 22)
			Me.chShowSelector.TabIndex = 8
			Me.chShowSelector.Text = "Show selector"
			Me.chShowSelector.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' chRowHeader
			' 
			Me.chRowHeader.CheckState = CheckState.Checked
			Me.chRowHeader.Location = New Point(4, 4)
			Me.chRowHeader.Margin = New Padding(4, 4, 4, 4)
			Me.chRowHeader.Name = "chRowHeader"
			Me.chRowHeader.Size = New Size(132, 22)
			Me.chRowHeader.TabIndex = 6
			Me.chRowHeader.Text = "Show row header"
			Me.chRowHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' chColumnHeader
			' 
			Me.chColumnHeader.CheckState = CheckState.Checked
			Me.chColumnHeader.Location = New Point(4, 52)
			Me.chColumnHeader.Margin = New Padding(4, 4, 4, 4)
			Me.chColumnHeader.Name = "chColumnHeader"
			Me.chColumnHeader.Size = New Size(158, 22)
			Me.chColumnHeader.TabIndex = 7
			Me.chColumnHeader.Text = "Show column  header"
			Me.chColumnHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' lbTitleFormat
			' 
			Me.lbTitleFormat.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
			Me.lbTitleFormat.Location = New Point(4, 454)
			Me.lbTitleFormat.Margin = New Padding(4, 4, 4, 4)
			Me.lbTitleFormat.Name = "lbTitleFormat"
			Me.lbTitleFormat.Size = New Size(81, 22)
			Me.lbTitleFormat.TabIndex = 6
			Me.lbTitleFormat.Text = "Title format:"
			Me.lbTitleFormat.TextAlignment = ContentAlignment.TopLeft
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.CheckState = CheckState.Checked
			Me.radCheckBox2.Location = New Point(4, 388)
			Me.radCheckBox2.Margin = New Padding(4, 4, 4, 4)
			Me.radCheckBox2.Name = "radCheckBox2"
			Me.radCheckBox2.Size = New Size(153, 22)
			Me.radCheckBox2.TabIndex = 18
			Me.radCheckBox2.Text = "Show Navigation Bar"
			Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' chNavigationButtons
			' 
			Me.chNavigationButtons.CheckState = CheckState.Checked
			Me.chNavigationButtons.Location = New Point(4, 148)
			Me.chNavigationButtons.Margin = New Padding(4, 4, 4, 4)
			Me.chNavigationButtons.Name = "chNavigationButtons"
			Me.chNavigationButtons.Size = New Size(178, 22)
			Me.chNavigationButtons.TabIndex = 9
			Me.chNavigationButtons.Text = "Show navigation buttons"
			Me.chNavigationButtons.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' chFastNavigationButtons
			' 
			Me.chFastNavigationButtons.Location = New Point(4, 196)
			Me.chFastNavigationButtons.Margin = New Padding(4, 4, 4, 4)
			Me.chFastNavigationButtons.Name = "chFastNavigationButtons"
			Me.chFastNavigationButtons.Size = New Size(163, 40)
			Me.chFastNavigationButtons.TabIndex = 10
			Me.chFastNavigationButtons.Text = "Show fast navigation " & vbCrLf & "buttons"
			' 
			' chViewHeader
			' 
			Me.chViewHeader.CheckState = CheckState.Checked
			Me.chViewHeader.Location = New Point(4, 292)
			Me.chViewHeader.Margin = New Padding(4, 4, 4, 4)
			Me.chViewHeader.Name = "chViewHeader"
			Me.chViewHeader.Size = New Size(136, 22)
			Me.chViewHeader.TabIndex = 11
			Me.chViewHeader.Text = "Show view header"
			Me.chViewHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' chAllowFishEye
			' 
			Me.chAllowFishEye.CheckState = CheckState.Checked
			Me.chAllowFishEye.Location = New Point(4, 340)
			Me.chAllowFishEye.Margin = New Padding(4, 4, 4, 4)
			Me.chAllowFishEye.Name = "chAllowFishEye"
			Me.chAllowFishEye.Size = New Size(113, 22)
			Me.chAllowFishEye.TabIndex = 12
			Me.chAllowFishEye.Text = "Allow fish eye "
			Me.chAllowFishEye.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' nudHeaderHeight
			' 
			Me.nudHeaderHeight.Location = New Point(4, 256)
			Me.nudHeaderHeight.Margin = New Padding(4, 4, 4, 4)
			Me.nudHeaderHeight.Minimum = New Decimal(New Integer() { 17, 0, 0, 0})
			Me.nudHeaderHeight.Name = "nudHeaderHeight"
			Me.nudHeaderHeight.NullableValue = New Decimal(New Integer() { 17, 0, 0, 0})
			' 
			' 
			' 
			Me.nudHeaderHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.nudHeaderHeight.Size = New Size(237, 24)
			Me.nudHeaderHeight.TabIndex = 20
			Me.nudHeaderHeight.TabStop = False
			Me.nudHeaderHeight.Value = New Decimal(New Integer() { 17, 0, 0, 0})
			' 
			' nudHeaderWidth
			' 
			Me.nudHeaderWidth.Location = New Point(4, 172)
			Me.nudHeaderWidth.Margin = New Padding(4, 4, 4, 4)
			Me.nudHeaderWidth.Minimum = New Decimal(New Integer() { 17, 0, 0, 0})
			Me.nudHeaderWidth.Name = "nudHeaderWidth"
			Me.nudHeaderWidth.NullableValue = New Decimal(New Integer() { 17, 0, 0, 0})
			' 
			' 
			' 
			Me.nudHeaderWidth.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.nudHeaderWidth.Size = New Size(237, 24)
			Me.nudHeaderWidth.TabIndex = 20
			Me.nudHeaderWidth.TabStop = False
			Me.nudHeaderWidth.Value = New Decimal(New Integer() { 17, 0, 0, 0})
			' 
			' radioButton16
			' 
			Me.radioButton16.Location = New Point(4, 46)
			Me.radioButton16.Margin = New Padding(4, 4, 4, 4)
			Me.radioButton16.Name = "radioButton16"
			Me.radioButton16.Size = New Size(121, 22)
			Me.radioButton16.TabIndex = 21
			Me.radioButton16.Text = "Render In Rows"
			' 
			' radioButton15
			' 
			Me.radioButton15.Location = New Point(4, 88)
			Me.radioButton15.Margin = New Padding(4, 4, 4, 4)
			Me.radioButton15.Name = "radioButton15"
			Me.radioButton15.Size = New Size(142, 22)
			Me.radioButton15.TabIndex = 21
			Me.radioButton15.Text = "Render In Columns"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
			Me.radGroupBox1.FooterText = ""
			Me.radGroupBox1.HeaderText = "Calendar Settings"
			Me.radGroupBox1.Location = New Point(22, 40)
			Me.radGroupBox1.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupBox1.Size = New Size(293, 585)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = "Calendar Settings"
			' 
			' tableLayoutPanel1
			' 
			Me.doubleBufferedTableLayoutPanel1.ColumnCount = 1
			Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.cbTitleFormat, 0, 10)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.chRowHeader, 0, 0)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.lbTitleFormat, 0, 9)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.chFastNavigationButtons, 0, 4)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBox2, 0, 8)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.chAllowFishEye, 0, 7)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.chViewHeader, 0, 6)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.chColumnHeader, 0, 1)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBox3, 0, 5)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.chShowSelector, 0, 2)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.chNavigationButtons, 0, 3)
			Me.doubleBufferedTableLayoutPanel1.Location = New Point(17, 32)
			Me.doubleBufferedTableLayoutPanel1.Margin = New Padding(4, 4, 4, 4)
			Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
			Me.doubleBufferedTableLayoutPanel1.RowCount = 11
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
			Me.doubleBufferedTableLayoutPanel1.Size = New Size(267, 533)
			Me.doubleBufferedTableLayoutPanel1.TabIndex = 1
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.doubleBufferedTableLayoutPanel2)
			Me.radGroupBox2.FooterText = ""
			Me.radGroupBox2.HeaderText = "Rendering Options"
			Me.radGroupBox2.Location = New Point(22, 644)
			Me.radGroupBox2.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupBox2.Size = New Size(284, 357)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = "Rendering Options"
			' 
			' customTableLayoutPanel1
			' 
			Me.doubleBufferedTableLayoutPanel2.ColumnCount = 1
			Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.lbRenderingDirection, 0, 0)
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.nudHeaderHeight, 0, 6)
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radLabel2, 0, 5)
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radioButton16, 0, 1)
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radLabel1, 0, 3)
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.nudHeaderWidth, 0, 4)
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radioButton15, 0, 2)
			Me.doubleBufferedTableLayoutPanel2.Location = New Point(21, 42)
			Me.doubleBufferedTableLayoutPanel2.Margin = New Padding(4, 4, 4, 4)
			Me.doubleBufferedTableLayoutPanel2.Name = "doubleBufferedTableLayoutPanel2"
			Me.doubleBufferedTableLayoutPanel2.RowCount = 7
			Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.29389F))
			Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.29388F))
			Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.29388F))
			Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.29388F))
			Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.29388F))
			Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.29388F))
			Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.23671F))
			Me.doubleBufferedTableLayoutPanel2.Size = New Size(245, 299)
			Me.doubleBufferedTableLayoutPanel2.TabIndex = 22
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
			Me.radLabel2.Location = New Point(4, 226)
			Me.radLabel2.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(97, 22)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "Header Height"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
			Me.radLabel1.Location = New Point(4, 142)
			Me.radLabel1.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(93, 22)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "Header Width"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New Size(2349, 1464)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbTitleFormat, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbRenderingDirection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chShowSelector, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chColumnHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbTitleFormat, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chNavigationButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chFastNavigationButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chViewHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chAllowFishEye, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudHeaderHeight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudHeaderWidth, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton16, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel1.PerformLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel2.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel2.PerformLayout()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private cbTitleFormat As Telerik.WinControls.UI.RadDropDownList
		Private lbRenderingDirection As Telerik.WinControls.UI.RadLabel
		Private lbTitleFormat As Telerik.WinControls.UI.RadLabel
		Private chRowHeader As Telerik.WinControls.UI.RadCheckBox
		Private chColumnHeader As Telerik.WinControls.UI.RadCheckBox
		Private chShowSelector As Telerik.WinControls.UI.RadCheckBox
		Private chNavigationButtons As Telerik.WinControls.UI.RadCheckBox
		Private chFastNavigationButtons As Telerik.WinControls.UI.RadCheckBox
		Private chViewHeader As Telerik.WinControls.UI.RadCheckBox
		Private chAllowFishEye As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
		Private nudHeaderHeight As Telerik.WinControls.UI.RadSpinEditor
		Private nudHeaderWidth As Telerik.WinControls.UI.RadSpinEditor
		Private radioButton16 As Telerik.WinControls.UI.RadRadioButton
		Private radioButton15 As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private doubleBufferedTableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace