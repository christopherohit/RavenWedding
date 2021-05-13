Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Events
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem7 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem8 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem9 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem10 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem11 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem12 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem13 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem14 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem15 As New Telerik.WinControls.UI.RadListDataItem()
			Me.imageList1 = New ImageList(Me.components)
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radComboSort = New Telerik.WinControls.UI.RadDropDownList()
			Me.radCheckCase = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLblSort = New Telerik.WinControls.UI.RadLabel()
			Me.radLblDropDownStyle = New Telerik.WinControls.UI.RadLabel()
			Me.radComboDropDownStyle = New Telerik.WinControls.UI.RadDropDownList()
			Me.radGroupEvents = New Telerik.WinControls.UI.RadGroupBox()
			Me.radTxtEvents = New Telerik.WinControls.UI.RadTextBox()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			CType(Me.radComboSort, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckCase, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblSort, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblDropDownStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboDropDownStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupEvents.SuspendLayout()
			CType(Me.radTxtEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.ForeColor = Color.Black
			Me.radPanelDemoHolder.MaximumSize = New Size(362, 100)
			Me.radPanelDemoHolder.MinimumSize = New Size(362, 100)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.MaxSize = New Size(362, 100)
			Me.radPanelDemoHolder.RootElement.MinSize = New Size(362, 100)
			Me.radPanelDemoHolder.Size = New Size(362, 100)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupEvents)
			Me.settingsPanel.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 486)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSettings, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupEvents, 0)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "WizardPicture.bmp")
			Me.imageList1.Images.SetKeyName(1, "bulb_on.GIF")
			Me.imageList1.Images.SetKeyName(2, "CLSDFOLD.BMP")
			Me.imageList1.Images.SetKeyName(3, "test.bmp")
			Me.imageList1.Images.SetKeyName(4, "untitled.bmp")
			' 
			' radComboDemo
			' 
			Me.radComboDemo.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			radListDataItem1.Text = "Amsterdam"
			radListDataItem1.TextWrap = True
			radListDataItem2.Text = "Barcelona"
			radListDataItem2.TextWrap = True
			radListDataItem3.Text = "Bonn"
			radListDataItem3.TextWrap = True
			radListDataItem4.Text = "Brussels"
			radListDataItem4.TextWrap = True
			radListDataItem5.Text = "New York"
			radListDataItem5.TextWrap = True
			radListDataItem6.Text = "London"
			radListDataItem6.TextWrap = True
			radListDataItem7.Text = "Paris"
			radListDataItem7.TextWrap = True
			radListDataItem8.Text = "Sofia"
			radListDataItem8.TextWrap = True
			radListDataItem9.Text = "Prague"
			radListDataItem9.TextWrap = True
			radListDataItem10.Text = "Hamburg"
			radListDataItem10.TextWrap = True
			Me.radComboDemo.Items.Add(radListDataItem1)
			Me.radComboDemo.Items.Add(radListDataItem2)
			Me.radComboDemo.Items.Add(radListDataItem3)
			Me.radComboDemo.Items.Add(radListDataItem4)
			Me.radComboDemo.Items.Add(radListDataItem5)
			Me.radComboDemo.Items.Add(radListDataItem6)
			Me.radComboDemo.Items.Add(radListDataItem7)
			Me.radComboDemo.Items.Add(radListDataItem8)
			Me.radComboDemo.Items.Add(radListDataItem9)
			Me.radComboDemo.Items.Add(radListDataItem10)
			Me.radComboDemo.Location = New Point(20, 20)
			Me.radComboDemo.Name = "radComboDemo"
			Me.radComboDemo.NullText = "Choose City..."
			' 
			' 
			' 
			Me.radComboDemo.Size = New Size(306, 18)
			Me.radComboDemo.TabIndex = 0
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupSettings.Anchor = AnchorStyles.Top
			Me.radGroupSettings.Controls.Add(Me.radComboSort)
			Me.radGroupSettings.Controls.Add(Me.radCheckCase)
			Me.radGroupSettings.Controls.Add(Me.radLblSort)
			Me.radGroupSettings.Controls.Add(Me.radLblDropDownStyle)
			Me.radGroupSettings.Controls.Add(Me.radComboDropDownStyle)
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupSettings.HeaderText = "Settings"
			Me.radGroupSettings.Location = New Point(1, 6)
			Me.radGroupSettings.Name = "radGroupSettings"
			Me.radGroupSettings.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupSettings.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupSettings.Size = New Size(163, 160)
			Me.radGroupSettings.TabIndex = 0
			Me.radGroupSettings.Text = "Settings"
			' 
			' radComboSort
			' 
			Me.radComboSort.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			radListDataItem11.Text = "Ascending"
			radListDataItem11.TextWrap = True
			radListDataItem12.Text = "Descending"
			radListDataItem12.TextWrap = True
			radListDataItem13.Text = "None"
			radListDataItem13.TextWrap = True
			Me.radComboSort.Items.Add(radListDataItem11)
			Me.radComboSort.Items.Add(radListDataItem12)
			Me.radComboSort.Items.Add(radListDataItem13)
			Me.radComboSort.Location = New Point(18, 96)
			Me.radComboSort.Name = "radComboSort"
			' 
			' 
			' 
			Me.radComboSort.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboSort.Size = New Size(122, 20)
			Me.radComboSort.TabIndex = 1
			Me.radComboDemo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			' 
			' radCheckCase
			' 
			Me.radCheckCase.Location = New Point(18, 125)
			Me.radCheckCase.Name = "radCheckCase"
			Me.radCheckCase.Size = New Size(89, 18)
			Me.radCheckCase.TabIndex = 4
			Me.radCheckCase.Text = "Case sensitive"

			' 
			' radLblSort
			' 
			Me.radLblSort.Location = New Point(18, 72)
			Me.radLblSort.Name = "radLblSort"
			Me.radLblSort.Size = New Size(76, 18)
			Me.radLblSort.TabIndex = 3
			Me.radLblSort.Text = "Sort direction:"
			' 
			' radLblDropDownStyle
			' 
			Me.radLblDropDownStyle.Location = New Point(18, 19)
			Me.radLblDropDownStyle.Name = "radLblDropDownStyle"
			Me.radLblDropDownStyle.Size = New Size(92, 18)
			Me.radLblDropDownStyle.TabIndex = 2
			Me.radLblDropDownStyle.Text = "Drop-down style:"
			' 
			' radComboDropDownStyle
			' 
			Me.radComboDropDownStyle.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			radListDataItem14.Text = "DropDown"
			radListDataItem14.TextWrap = True
			radListDataItem15.Text = "DropDownList"
			radListDataItem15.TextWrap = True
			Me.radComboDropDownStyle.Items.Add(radListDataItem14)
			Me.radComboDropDownStyle.Items.Add(radListDataItem15)
			Me.radComboDropDownStyle.Location = New Point(18, 43)
			Me.radComboDropDownStyle.Name = "radComboDropDownStyle"
			' 
			' 
			' 
			Me.radComboDropDownStyle.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDropDownStyle.Size = New Size(122, 20)
			Me.radComboDropDownStyle.TabIndex = 0
			Me.radComboDropDownStyle.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			' 
			' radGroupEvents
			' 
			Me.radGroupEvents.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupEvents.Anchor = AnchorStyles.Top
			Me.radGroupEvents.Controls.Add(Me.radTxtEvents)
			Me.radGroupEvents.FooterText = ""
			Me.radGroupEvents.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupEvents.HeaderText = " Events "
			Me.radGroupEvents.Location = New Point(1, 172)
			Me.radGroupEvents.Name = "radGroupEvents"
			Me.radGroupEvents.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupEvents.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupEvents.Size = New Size(163, 322)
			Me.radGroupEvents.TabIndex = 1
			Me.radGroupEvents.Text = " Events "
			' 
			' radTxtEvents
			' 
			Me.radTxtEvents.AutoSize = False
			Me.radTxtEvents.Location = New Point(22, 26)
			Me.radTxtEvents.Multiline = True
			Me.radTxtEvents.Name = "radTxtEvents"
			Me.radTxtEvents.Size = New Size(136, 283)
			Me.radTxtEvents.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Name = "Form1"
			Me.Size = New Size(1142, 516)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSettings.ResumeLayout(False)
			Me.radGroupSettings.PerformLayout()
			CType(Me.radComboSort, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckCase, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblSort, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblDropDownStyle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboDropDownStyle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupEvents.ResumeLayout(False)
			CType(Me.radTxtEvents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radComboDemo As Telerik.WinControls.UI.RadDropDownList
		Private imageList1 As ImageList
		Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
		Private radGroupEvents As Telerik.WinControls.UI.RadGroupBox
		Private radCheckCase As Telerik.WinControls.UI.RadCheckBox
		Private radLblSort As Telerik.WinControls.UI.RadLabel
		Private radLblDropDownStyle As Telerik.WinControls.UI.RadLabel
		Private radComboSort As Telerik.WinControls.UI.RadDropDownList
		Private radComboDropDownStyle As Telerik.WinControls.UI.RadDropDownList
		Private radTxtEvents As Telerik.WinControls.UI.RadTextBox
	End Class
End Namespace