Namespace Telerik.Examples.WinControls.CardView.CustomItems
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
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem7 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem8 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem9 As New Telerik.WinControls.UI.RadListDataItem()
			Me.sofiaCarRentalDataSet = New Telerik.Examples.WinControls.DataSources.SofiaCarRentalDataSet()
			Me.carsRatesDataTableBindingSource = New BindingSource(Me.components)
			Me.carsRatesDataTableTableAdapter = New Telerik.Examples.WinControls.DataSources.SofiaCarRentalDataSetTableAdapters.CarsRatesDataTableTableAdapter()
			Me.radCardView1 = New Telerik.WinControls.UI.RadCardView()
			Me.cardViewItem16 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem1 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem7 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem8 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem9 = New Telerik.WinControls.UI.CardViewItem()
			Me.layoutControlLabelItem1 = New Telerik.WinControls.UI.LayoutControlLabelItem()
			Me.cardViewItem2 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem3 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem4 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem6 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewGroupItem1 = New Telerik.WinControls.UI.CardViewGroupItem()
			Me.cardViewItem10 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem11 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem12 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem13 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem14 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem15 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem5 = New Telerik.WinControls.UI.CardViewItem()
			Me.layoutControlLabelItem2 = New Telerik.WinControls.UI.LayoutControlLabelItem()
			Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
			Me.commandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
			Me.commandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
			Me.commandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.commandBarLabel1 = New Telerik.WinControls.UI.CommandBarLabel()
			Me.commandBarDropDownSort = New Telerik.WinControls.UI.CommandBarDropDownList()
			Me.commandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.commandBarLabel2 = New Telerik.WinControls.UI.CommandBarLabel()
			Me.commandBarDropDownGroup = New Telerik.WinControls.UI.CommandBarDropDownList()
			Me.commandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.commandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.commandBarLabel3 = New Telerik.WinControls.UI.CommandBarLabel()
			Me.commandBarTextBoxFilter = New Telerik.WinControls.UI.CommandBarTextBox()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sofiaCarRentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsRatesDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCardView1.CardTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radCardView1.SuspendLayout()
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1313, 3)
			' 
			' sofiaCarRentalDataSet
			' 
			Me.sofiaCarRentalDataSet.DataSetName = "SofiaCarRentalDataSet"
			Me.sofiaCarRentalDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' carsRatesDataTableBindingSource
			' 
			Me.carsRatesDataTableBindingSource.DataMember = "CarsRatesDataTable"
			Me.carsRatesDataTableBindingSource.DataSource = Me.sofiaCarRentalDataSet
			' 
			' carsRatesDataTableTableAdapter
			' 
			Me.carsRatesDataTableTableAdapter.ClearBeforeFill = True
			' 
			' radCardView1
			' 
			' 
			' radCardView1Template
			' 
			Me.radCardView1.CardTemplate.HiddenItems.AddRange(New Telerik.WinControls.RadItem() { Me.cardViewItem16, Me.cardViewItem1, Me.cardViewItem7, Me.cardViewItem8, Me.cardViewItem9, Me.cardViewItem3, Me.layoutControlLabelItem1})
			Me.radCardView1.CardTemplate.Items.AddRange(New Telerik.WinControls.RadItem() { Me.cardViewItem2, Me.cardViewItem4, Me.cardViewItem6, Me.cardViewGroupItem1, Me.cardViewItem5, Me.layoutControlLabelItem2})
			Me.radCardView1.CardTemplate.Location = New Point(570, 228)
			Me.radCardView1.CardTemplate.Name = "radCardView1Template"
			Me.radCardView1.CardTemplate.Size = New Size(360, 420)
			Me.radCardView1.CardTemplate.TabIndex = 0
			Me.radCardView1.DataSource = Me.carsRatesDataTableBindingSource
			Me.radCardView1.DisplayMember = "Make"
			Me.radCardView1.Dock = DockStyle.Fill
			Me.radCardView1.ItemSize = New Size(360, 420)
			Me.radCardView1.Location = New Point(0, 30)
			Me.radCardView1.Name = "radCardView1"
			Me.radCardView1.Size = New Size(1501, 877)
			Me.radCardView1.TabIndex = 2
			Me.radCardView1.Text = "radCardView1"
			Me.radCardView1.ValueMember = "CarID"
			CType(Me.radCardView1.GetChildAt(0), Telerik.WinControls.UI.RadCardViewElement).DrawBorder = False
			' 
			' cardViewItem16
			' 
			Me.cardViewItem16.Bounds = New Rectangle(0, 390, 192, 26)
			Me.cardViewItem16.FieldName = "Available"
			Me.cardViewItem16.Name = "cardViewItem16"
			Me.cardViewItem16.Text = "Available"
			' 
			' cardViewItem1
			' 
			Me.cardViewItem1.Bounds = New Rectangle(0, 0, 192, 26)
			Me.cardViewItem1.FieldName = "CarID"
			Me.cardViewItem1.Name = "cardViewItem1"
			Me.cardViewItem1.Text = "CarID"
			' 
			' cardViewItem7
			' 
			Me.cardViewItem7.Bounds = New Rectangle(0, 156, 192, 26)
			Me.cardViewItem7.FieldName = "Daily"
			Me.cardViewItem7.Name = "cardViewItem7"
			Me.cardViewItem7.Text = "Daily"
			' 
			' cardViewItem8
			' 
			Me.cardViewItem8.Bounds = New Rectangle(0, 182, 192, 26)
			Me.cardViewItem8.FieldName = "Weekly"
			Me.cardViewItem8.Name = "cardViewItem8"
			Me.cardViewItem8.Text = "Weekly"
			' 
			' cardViewItem9
			' 
			Me.cardViewItem9.Bounds = New Rectangle(0, 208, 192, 26)
			Me.cardViewItem9.FieldName = "Monthly"
			Me.cardViewItem9.Name = "cardViewItem9"
			Me.cardViewItem9.Text = "Monthly"
			' 
			' layoutControlLabelItem1
			' 
			Me.layoutControlLabelItem1.Bounds = New Rectangle(0, 0, 360, 26)
			Me.layoutControlLabelItem1.Name = "layoutControlLabelItem1"
			Me.layoutControlLabelItem1.Text = "layoutControlLabelItem1"
			' 
			' cardViewItem2
			' 
			Me.cardViewItem2.Bounds = New Rectangle(0, 160, 360, 30)
			Me.cardViewItem2.FieldName = "Make"
			Me.cardViewItem2.MaxSize = New Size(0, 0)
			Me.cardViewItem2.MinSize = New Size(0, 30)
			Me.cardViewItem2.Name = "cardViewItem2"
			Me.cardViewItem2.Text = "Make"
			Me.cardViewItem2.TextProportionalSize = 0F
			' 
			' cardViewItem3
			' 
			Me.cardViewItem3.Bounds = New Rectangle(350, 160, 10, 30)
			Me.cardViewItem3.FieldName = "Model"
			Me.cardViewItem3.MaxSize = New Size(10, 30)
			Me.cardViewItem3.MinSize = New Size(10, 30)
			Me.cardViewItem3.Name = "cardViewItem3"
			Me.cardViewItem3.Text = "Model"
			Me.cardViewItem3.TextProportionalSize = 0F
			' 
			' cardViewItem4
			' 
			Me.cardViewItem4.Bounds = New Rectangle(0, 190, 50, 30)
			Me.cardViewItem4.FieldName = "CarYear"
			Me.cardViewItem4.MaxSize = New Size(50, 30)
			Me.cardViewItem4.MinSize = New Size(50, 30)
			Me.cardViewItem4.Name = "cardViewItem4"
			Me.cardViewItem4.Text = "CarYear"
			Me.cardViewItem4.TextProportionalSize = 0F
			' 
			' cardViewItem6
			' 
			Me.cardViewItem6.Bounds = New Rectangle(50, 190, 310, 30)
			Me.cardViewItem6.FieldName = "CategoryName"
			Me.cardViewItem6.MaxSize = New Size(0, 30)
			Me.cardViewItem6.MinSize = New Size(0, 30)
			Me.cardViewItem6.Name = "cardViewItem6"
			Me.cardViewItem6.Text = "CategoryName"
			Me.cardViewItem6.TextProportionalSize = 0F
			' 
			' cardViewGroupItem1
			' 
			Me.cardViewGroupItem1.Bounds = New Rectangle(0, 230, 360, 190)
			Me.cardViewGroupItem1.DrawText = True
			Me.cardViewGroupItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.cardViewItem10, Me.cardViewItem11, Me.cardViewItem12, Me.cardViewItem13, Me.cardViewItem14, Me.cardViewItem15})
			Me.cardViewGroupItem1.Name = "cardViewGroupItem1"
			' 
			' cardViewItem10
			' 
			Me.cardViewItem10.Bounds = New Rectangle(0, 0, 352, 28)
			Me.cardViewItem10.FieldName = "Mp3Player"
			Me.cardViewItem10.Name = "cardViewItem10"
			Me.cardViewItem10.Text = "Mp3Player"
			' 
			' cardViewItem11
			' 
			Me.cardViewItem11.Bounds = New Rectangle(0, 28, 352, 28)
			Me.cardViewItem11.FieldName = "DVDPlayer"
			Me.cardViewItem11.Name = "cardViewItem11"
			Me.cardViewItem11.Text = "DVDPlayer"
			' 
			' cardViewItem12
			' 
			Me.cardViewItem12.Bounds = New Rectangle(0, 56, 352, 28)
			Me.cardViewItem12.FieldName = "AirConditioner"
			Me.cardViewItem12.Name = "cardViewItem12"
			Me.cardViewItem12.Text = "AirConditioner"
			' 
			' cardViewItem13
			' 
			Me.cardViewItem13.Bounds = New Rectangle(0, 84, 352, 26)
			Me.cardViewItem13.FieldName = "ABS"
			Me.cardViewItem13.Name = "cardViewItem13"
			Me.cardViewItem13.Text = "ABS"
			' 
			' cardViewItem14
			' 
			Me.cardViewItem14.Bounds = New Rectangle(0, 110, 352, 26)
			Me.cardViewItem14.FieldName = "ASR"
			Me.cardViewItem14.Name = "cardViewItem14"
			Me.cardViewItem14.Text = "ASR"
			' 
			' cardViewItem15
			' 
			Me.cardViewItem15.Bounds = New Rectangle(0, 136, 352, 26)
			Me.cardViewItem15.FieldName = "Navigation"
			Me.cardViewItem15.Name = "cardViewItem15"
			Me.cardViewItem15.Text = "Navigation"
			' 
			' cardViewItem5
			' 
			Me.cardViewItem5.Bounds = New Rectangle(0, 0, 360, 160)
			Me.cardViewItem5.FieldName = "ImageFileName"
			Me.cardViewItem5.MaxSize = New Size(0, 160)
			Me.cardViewItem5.MinSize = New Size(0, 160)
			Me.cardViewItem5.Name = "cardViewItem5"
			Me.cardViewItem5.Text = "ImageFileName"
			' 
			' layoutControlLabelItem2
			' 
			Me.layoutControlLabelItem2.Bounds = New Rectangle(0, 220, 360, 10)
			Me.layoutControlLabelItem2.DrawText = False
			Me.layoutControlLabelItem2.MaxSize = New Size(0, 10)
			Me.layoutControlLabelItem2.MinSize = New Size(46, 10)
			Me.layoutControlLabelItem2.Name = "layoutControlLabelItem2"
			' 
			' radCommandBar1
			' 
			Me.radCommandBar1.Dock = DockStyle.Top
			Me.radCommandBar1.Location = New Point(0, 0)
			Me.radCommandBar1.Name = "radCommandBar1"
			Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() { Me.commandBarRowElement1})
			Me.radCommandBar1.Size = New Size(1501, 30)
			Me.radCommandBar1.TabIndex = 4
			' 
			' commandBarRowElement1
			' 
			Me.commandBarRowElement1.DisplayName = Nothing
			Me.commandBarRowElement1.MinSize = New Size(25, 25)
			Me.commandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() { Me.commandBarStripElement1})
			' 
			' commandBarStripElement1
			' 
			Me.commandBarStripElement1.DisplayName = "commandBarStripElement1"
			Me.commandBarStripElement1.EnableDragging = False
			Me.commandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.commandBarSeparator4, Me.commandBarLabel1, Me.commandBarDropDownSort, Me.commandBarSeparator1, Me.commandBarLabel2, Me.commandBarDropDownGroup, Me.commandBarSeparator2, Me.commandBarSeparator3, Me.commandBarLabel3, Me.commandBarTextBoxFilter})
			Me.commandBarStripElement1.Name = "commandBarStripElement1"
			Me.commandBarStripElement1.StretchHorizontally = True
			Me.commandBarStripElement1.Text = ""
			' 
			' commandBarSeparator4
			' 
			Me.commandBarSeparator4.AccessibleDescription = "commandBarSeparator4"
			Me.commandBarSeparator4.AccessibleName = "commandBarSeparator4"
			Me.commandBarSeparator4.DisplayName = "commandBarSeparator4"
			Me.commandBarSeparator4.Name = "commandBarSeparator4"
			Me.commandBarSeparator4.VisibleInOverflowMenu = False
			' 
			' commandBarLabel1
			' 
			Me.commandBarLabel1.DisplayName = "commandBarLabel1"
			Me.commandBarLabel1.Name = "commandBarLabel1"
			Me.commandBarLabel1.Text = "Sort By:"
			' 
			' commandBarDropDownSort
			' 
			Me.commandBarDropDownSort.DisplayName = "commandBarDropDownList1"
			Me.commandBarDropDownSort.DropDownAnimationEnabled = True
			Me.commandBarDropDownSort.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem1.Text = "None"
			radListDataItem2.Text = "Make"
			radListDataItem3.Text = "Model"
			radListDataItem4.Text = "Category"
			radListDataItem5.Text = "Year"
			Me.commandBarDropDownSort.Items.Add(radListDataItem1)
			Me.commandBarDropDownSort.Items.Add(radListDataItem2)
			Me.commandBarDropDownSort.Items.Add(radListDataItem3)
			Me.commandBarDropDownSort.Items.Add(radListDataItem4)
			Me.commandBarDropDownSort.Items.Add(radListDataItem5)
			Me.commandBarDropDownSort.MaxDropDownItems = 0
			Me.commandBarDropDownSort.Name = "commandBarDropDownSort"
			Me.commandBarDropDownSort.Text = "None"
			' 
			' commandBarSeparator1
			' 
			Me.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1"
			Me.commandBarSeparator1.AccessibleName = "commandBarSeparator1"
			Me.commandBarSeparator1.DisplayName = "commandBarSeparator1"
			Me.commandBarSeparator1.Name = "commandBarSeparator1"
			Me.commandBarSeparator1.VisibleInOverflowMenu = False
			' 
			' commandBarLabel2
			' 
			Me.commandBarLabel2.DisplayName = "commandBarLabel2"
			Me.commandBarLabel2.Name = "commandBarLabel2"
			Me.commandBarLabel2.Text = "Group By:"
			' 
			' commandBarDropDownGroup
			' 
			Me.commandBarDropDownGroup.DisplayName = "commandBarDropDownList2"
			Me.commandBarDropDownGroup.DropDownAnimationEnabled = True
			Me.commandBarDropDownGroup.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem6.Text = "None"
			radListDataItem7.Text = "Make"
			radListDataItem8.Text = "Category"
			radListDataItem9.Text = "Year"
			Me.commandBarDropDownGroup.Items.Add(radListDataItem6)
			Me.commandBarDropDownGroup.Items.Add(radListDataItem7)
			Me.commandBarDropDownGroup.Items.Add(radListDataItem8)
			Me.commandBarDropDownGroup.Items.Add(radListDataItem9)
			Me.commandBarDropDownGroup.MaxDropDownItems = 0
			Me.commandBarDropDownGroup.Name = "commandBarDropDownGroup"
			Me.commandBarDropDownGroup.Text = ""
			' 
			' commandBarSeparator2
			' 
			Me.commandBarSeparator2.AccessibleDescription = "commandBarSeparator2"
			Me.commandBarSeparator2.AccessibleName = "commandBarSeparator2"
			Me.commandBarSeparator2.DisplayName = "commandBarSeparator2"
			Me.commandBarSeparator2.Name = "commandBarSeparator2"
			Me.commandBarSeparator2.VisibleInOverflowMenu = False
			' 
			' commandBarSeparator3
			' 
			Me.commandBarSeparator3.AccessibleDescription = "commandBarSeparator3"
			Me.commandBarSeparator3.AccessibleName = "commandBarSeparator3"
			Me.commandBarSeparator3.DisplayName = "commandBarSeparator3"
			Me.commandBarSeparator3.Name = "commandBarSeparator3"
			Me.commandBarSeparator3.VisibleInOverflowMenu = False
			' 
			' commandBarLabel3
			' 
			Me.commandBarLabel3.DisplayName = "commandBarLabel3"
			Me.commandBarLabel3.Name = "commandBarLabel3"
			Me.commandBarLabel3.Text = "Filter:"
			' 
			' commandBarTextBoxFilter
			' 
			Me.commandBarTextBoxFilter.DisplayName = "commandBarTextBox1"
			Me.commandBarTextBoxFilter.MinSize = New Size(200, 0)
			Me.commandBarTextBoxFilter.Name = "commandBarTextBoxFilter"
			Me.commandBarTextBoxFilter.StretchHorizontally = True
			Me.commandBarTextBoxFilter.Text = ""
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radCardView1)
			Me.radPanel1.Controls.Add(Me.radCommandBar1)
			Me.radPanel1.Dock = DockStyle.Fill
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(1501, 907)
			Me.radPanel1.TabIndex = 5
			Me.radPanel1.Text = "radPanel1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.None
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1511, 917)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sofiaCarRentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsRatesDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCardView1.CardTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCardView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radCardView1.ResumeLayout(False)
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private carsRatesDataTableBindingSource As BindingSource
		Private sofiaCarRentalDataSet As DataSources.SofiaCarRentalDataSet
		Private carsRatesDataTableTableAdapter As DataSources.SofiaCarRentalDataSetTableAdapters.CarsRatesDataTableTableAdapter
		Private radCardView1 As Telerik.WinControls.UI.RadCardView
		Private cardViewGroupItem1 As Telerik.WinControls.UI.CardViewGroupItem
		Private cardViewItem1 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem2 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem3 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem4 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem5 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem6 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem7 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem8 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem9 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem10 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem11 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem12 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem13 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem14 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem15 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem16 As Telerik.WinControls.UI.CardViewItem
		Private layoutControlLabelItem1 As Telerik.WinControls.UI.LayoutControlLabelItem
		Private radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
		Private commandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
		Private commandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
		Private commandBarLabel1 As Telerik.WinControls.UI.CommandBarLabel
		Private commandBarDropDownSort As Telerik.WinControls.UI.CommandBarDropDownList
		Private commandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
		Private commandBarLabel2 As Telerik.WinControls.UI.CommandBarLabel
		Private commandBarDropDownGroup As Telerik.WinControls.UI.CommandBarDropDownList
		Private commandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
		Private commandBarTextBoxFilter As Telerik.WinControls.UI.CommandBarTextBox
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private commandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
		Private commandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
		Private commandBarLabel3 As Telerik.WinControls.UI.CommandBarLabel
		Private layoutControlLabelItem2 As Telerik.WinControls.UI.LayoutControlLabelItem
	End Class
End Namespace