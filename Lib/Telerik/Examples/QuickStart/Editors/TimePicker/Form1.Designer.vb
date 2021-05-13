Namespace Telerik.Examples.WinControls.Editors.TimePicker
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
			Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem7 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem8 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radTimePicker1 = New Telerik.WinControls.UI.RadTimePicker()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radTimePicker3 = New Telerik.WinControls.UI.RadTimePicker()
			Me.radTimePicker2 = New Telerik.WinControls.UI.RadTimePicker()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.TablesDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.ClockPossitionDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radLabelTimeZone = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.radSeparator1 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelDate = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radClock1 = New Telerik.WinControls.UI.RadClock()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTimePicker3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.TablesDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ClockPossitionDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelTimeZone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radClock1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radPageView1)
			Me.radPanelDemoHolder.Margin = New Padding(5, 5, 5, 5)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
			Me.radPanelDemoHolder.Size = New Size(633, 534)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(616, 1)
			Me.settingsPanel.Margin = New Padding(5, 5, 5, 5)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.PanelContainer.Size = New Size(330, 584)
			Me.settingsPanel.Size = New Size(330, 584)
			' 
			' radTimePicker1
			' 
			Me.radTimePicker1.Location = New Point(240, 145)
			Me.radTimePicker1.Margin = New Padding(4, 4, 4, 4)
			Me.radTimePicker1.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
			Me.radTimePicker1.MinValue = New Date((CLng(0)))
			Me.radTimePicker1.Name = "radTimePicker1"
			Me.radTimePicker1.Size = New Size(187, 24)
			Me.radTimePicker1.TabIndex = 0
			Me.radTimePicker1.TabStop = False
			Me.radTimePicker1.Value = New Date((CLng(0)))
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radLabel7)
			Me.radGroupBox2.Controls.Add(Me.radLabel5)
			Me.radGroupBox2.Controls.Add(Me.radTimePicker3)
			Me.radGroupBox2.Controls.Add(Me.radTimePicker2)
			Me.radGroupBox2.Controls.Add(Me.radLabel4)
			Me.radGroupBox2.Controls.Add(Me.TablesDropDownList)
			Me.radGroupBox2.Controls.Add(Me.ClockPossitionDropDownList)
			Me.radGroupBox2.Controls.Add(Me.radLabel2)
			Me.radGroupBox2.Controls.Add(Me.radCheckBox1)
			Me.radGroupBox2.HeaderText = "RadTimePicker Settings"
			Me.radGroupBox2.Location = New Point(54, 59)
			Me.radGroupBox2.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(2, 22, 2, 2)
			Me.radGroupBox2.Size = New Size(305, 301)
			Me.radGroupBox2.TabIndex = 3
			Me.radGroupBox2.Text = "RadTimePicker Settings"
			' 
			' radLabel7
			' 
			Me.radLabel7.Anchor = AnchorStyles.Top
			Me.radLabel7.Location = New Point(6, 239)
			Me.radLabel7.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New Size(71, 22)
			Me.radLabel7.TabIndex = 7
			Me.radLabel7.Text = "Max Time:"
			' 
			' radLabel5
			' 
			Me.radLabel5.Anchor = AnchorStyles.Top
			Me.radLabel5.Location = New Point(6, 181)
			Me.radLabel5.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New Size(69, 22)
			Me.radLabel5.TabIndex = 6
			Me.radLabel5.Text = "Min Time:"
			' 
			' radTimePicker3
			' 
			Me.radTimePicker3.Location = New Point(6, 265)
			Me.radTimePicker3.Margin = New Padding(4, 4, 4, 4)
			Me.radTimePicker3.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
			Me.radTimePicker3.MinValue = New Date((CLng(0)))
			Me.radTimePicker3.Name = "radTimePicker3"
			Me.radTimePicker3.Size = New Size(292, 24)
			Me.radTimePicker3.TabIndex = 5
			Me.radTimePicker3.TabStop = False
			Me.radTimePicker3.Value = New Date(2014, 6, 10, 16, 15, 44, 0)
			' 
			' radTimePicker2
			' 
			Me.radTimePicker2.Location = New Point(6, 208)
			Me.radTimePicker2.Margin = New Padding(4, 4, 4, 4)
			Me.radTimePicker2.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
			Me.radTimePicker2.MinValue = New Date((CLng(0)))
			Me.radTimePicker2.Name = "radTimePicker2"
			Me.radTimePicker2.Size = New Size(292, 24)
			Me.radTimePicker2.TabIndex = 4
			Me.radTimePicker2.TabStop = False
			Me.radTimePicker2.Value = New Date(2014, 6, 10, 16, 15, 44, 0)
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = AnchorStyles.Top
			Me.radLabel4.Location = New Point(6, 126)
			Me.radLabel4.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(108, 22)
			Me.radLabel4.TabIndex = 3
			Me.radLabel4.Text = "Time table style:"
			' 
			' TablesDropDownList
			' 
			Me.TablesDropDownList.Anchor = AnchorStyles.Top
			Me.TablesDropDownList.DropDownHeight = 133
			Me.TablesDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem6.Text = "One table"
			radListDataItem7.Text = "Two tables"
			Me.TablesDropDownList.Items.Add(radListDataItem6)
			Me.TablesDropDownList.Items.Add(radListDataItem7)
			Me.TablesDropDownList.Location = New Point(6, 151)
			Me.TablesDropDownList.Margin = New Padding(4, 4, 4, 4)
			Me.TablesDropDownList.Name = "TablesDropDownList"
			Me.TablesDropDownList.Size = New Size(292, 24)
			Me.TablesDropDownList.TabIndex = 2
			' 
			' ClockPossitionDropDownList
			' 
			Me.ClockPossitionDropDownList.Anchor = AnchorStyles.Top
			Me.ClockPossitionDropDownList.DropDownHeight = 133
			Me.ClockPossitionDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem1.Text = "Clock Before Tables"
			radListDataItem2.Text = "Clock Above Tables"
			radListDataItem8.Text = "Hide Clock"
			Me.ClockPossitionDropDownList.Items.Add(radListDataItem1)
			Me.ClockPossitionDropDownList.Items.Add(radListDataItem2)
			Me.ClockPossitionDropDownList.Items.Add(radListDataItem8)
			Me.ClockPossitionDropDownList.Location = New Point(6, 94)
			Me.ClockPossitionDropDownList.Margin = New Padding(4, 4, 4, 4)
			Me.ClockPossitionDropDownList.Name = "ClockPossitionDropDownList"
			Me.ClockPossitionDropDownList.Size = New Size(292, 24)
			Me.ClockPossitionDropDownList.TabIndex = 1
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(6, 70)
			Me.radLabel2.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(99, 22)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "Clock position:"
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Anchor = AnchorStyles.Top
			Me.radCheckBox1.Location = New Point(6, 26)
			Me.radCheckBox1.Margin = New Padding(4, 4, 4, 4)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(84, 22)
			Me.radCheckBox1.TabIndex = 0
			Me.radCheckBox1.Text = "ReadOnly"
			' 
			' radPageView1
			' 
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage3)
			Me.radPageView1.Location = New Point(0, 0)
			Me.radPageView1.Margin = New Padding(4, 4, 4, 4)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New Size(613, 430)
			Me.radPageView1.TabIndex = 1
			CType(Me.radPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radButton1)
			Me.radPageViewPage1.Controls.Add(Me.radTimePicker1)
			Me.radPageViewPage1.Controls.Add(Me.radLabelTimeZone)
			Me.radPageViewPage1.Controls.Add(Me.radLabel6)
			Me.radPageViewPage1.Controls.Add(Me.radSeparator1)
			Me.radPageViewPage1.Controls.Add(Me.radLabel3)
			Me.radPageViewPage1.Controls.Add(Me.radLabelDate)
			Me.radPageViewPage1.Controls.Add(Me.radLabel1)
			Me.radPageViewPage1.Controls.Add(Me.radClock1)
			Me.radPageViewPage1.ItemSize = New SizeF(112F, 36F)
			Me.radPageViewPage1.Location = New Point(12, 47)
			Me.radPageViewPage1.Margin = New Padding(4, 4, 4, 4)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New Size(587, 369)
			Me.radPageViewPage1.Text = "Date and Time"
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(276, 285)
			Me.radButton1.Margin = New Padding(4, 4, 4, 4)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(230, 30)
			Me.radButton1.TabIndex = 9
			Me.radButton1.Text = "Change time zone..."
			' 
			' radLabelTimeZone
			' 
			Me.radLabelTimeZone.Location = New Point(5, 256)
			Me.radLabelTimeZone.Margin = New Padding(4, 4, 4, 4)
			Me.radLabelTimeZone.Name = "radLabelTimeZone"
			Me.radLabelTimeZone.Size = New Size(33, 22)
			Me.radLabelTimeZone.TabIndex = 8
			Me.radLabelTimeZone.Text = "UTC"
			' 
			' radLabel6
			' 
			Me.radLabel6.Location = New Point(2, 225)
			Me.radLabel6.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New Size(79, 22)
			Me.radLabel6.TabIndex = 7
			Me.radLabel6.Text = "Time zone  "
			' 
			' radSeparator1
			' 
			Me.radSeparator1.Location = New Point(4, 231)
			Me.radSeparator1.Margin = New Padding(4, 4, 4, 4)
			Me.radSeparator1.Name = "radSeparator1"
			Me.radSeparator1.Size = New Size(534, 12)
			Me.radSeparator1.TabIndex = 7
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New Point(236, 118)
			Me.radLabel3.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(41, 22)
			Me.radLabel3.TabIndex = 3
			Me.radLabel3.Text = "Time:"
			' 
			' radLabelDate
			' 
			Me.radLabelDate.Location = New Point(236, 68)
			Me.radLabelDate.Margin = New Padding(4, 4, 4, 4)
			Me.radLabelDate.Name = "radLabelDate"
			Me.radLabelDate.Size = New Size(129, 22)
			Me.radLabelDate.TabIndex = 2
			Me.radLabelDate.Text = "12 February 2012 y."
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(236, 42)
			Me.radLabel1.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(39, 22)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Date:"
			' 
			' radClock1
			' 
			Me.radClock1.BackColor = Color.Transparent
			Me.radClock1.Location = New Point(26, 20)
			Me.radClock1.Margin = New Padding(4, 4, 4, 4)
			Me.radClock1.Name = "radClock1"
			Me.radClock1.Size = New Size(168, 169)
			Me.radClock1.TabIndex = 0
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.ItemSize = New SizeF(129F, 36F)
			Me.radPageViewPage2.Location = New Point(14, 48)
			Me.radPageViewPage2.Margin = New Padding(4, 4, 4, 4)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New Size(539, 320)
			Me.radPageViewPage2.Text = "Additional Clocks"
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.ItemSize = New SizeF(105F, 36F)
			Me.radPageViewPage3.Location = New Point(12, 46)
			Me.radPageViewPage3.Margin = New Padding(4, 4, 4, 4)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New Size(541, 322)
			Me.radPageViewPage3.Text = "Internet Time"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96, 96)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Name = "Form1"
			Me.Size = New Size(2527, 1464)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTimePicker3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.TablesDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ClockPossitionDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			Me.radPageViewPage1.PerformLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelTimeZone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radClock1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTimePicker1 As Telerik.WinControls.UI.RadTimePicker
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private ClockPossitionDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private TablesDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radLabelTimeZone As Telerik.WinControls.UI.RadLabel
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private radSeparator1 As Telerik.WinControls.UI.RadSeparator
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabelDate As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radClock1 As Telerik.WinControls.UI.RadClock
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radTimePicker3 As Telerik.WinControls.UI.RadTimePicker
		Private radTimePicker2 As Telerik.WinControls.UI.RadTimePicker
	End Class
End Namespace