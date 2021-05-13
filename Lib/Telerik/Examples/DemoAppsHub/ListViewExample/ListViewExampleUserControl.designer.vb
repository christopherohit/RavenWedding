Imports Microsoft.VisualBasic
Imports System
Namespace DemoAppsHub.ListViewExample
	Public Partial Class ListViewExampleUserControl
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim radListDataItem10 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem11 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem12 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem13 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem14 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem15 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem16 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem17 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem18 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListView1 = New Telerik.WinControls.UI.RadListView()
			Me.carsRatesDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.sofiaCarRentalDataSet = New Telerik.Examples.WinControls.DataSources.SofiaCarRentalDataSet()
			Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
			Me.commandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
			Me.commandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
			Me.commandBarLabel1 = New Telerik.WinControls.UI.CommandBarLabel()
			Me.commandBarDropDownSort = New Telerik.WinControls.UI.CommandBarDropDownList()
			Me.commandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.commandBarLabel2 = New Telerik.WinControls.UI.CommandBarLabel()
			Me.commandBarDropDownGroup = New Telerik.WinControls.UI.CommandBarDropDownList()
			Me.commandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.commandBarToggleList = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.commandBarToggleTiles = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.commandBarToggleDetails = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.commandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.commandBarTextBoxFilter = New Telerik.WinControls.UI.CommandBarTextBox()
            Me.carsRatesDataTableTableAdapter = New Telerik.Examples.WinControls.DataSources.SofiaCarRentalDataSetTableAdapters.CarsRatesDataTableTableAdapter()
			CType(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsRatesDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sofiaCarRentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radListView1
			' 
			Me.radListView1.DataSource = Me.carsRatesDataTableBindingSource
			Me.radListView1.DisplayMember = "Make"
			Me.radListView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radListView1.EnableColumnSort = True
			Me.radListView1.EnableSorting = True
			Me.radListView1.FullRowSelect = False
			Me.radListView1.GroupIndent = 0
			Me.radListView1.GroupItemSize = New System.Drawing.Size(200, 20)
			Me.radListView1.ItemSize = New System.Drawing.Size(64, 64)
			Me.radListView1.Location = New System.Drawing.Point(0, 30)
			Me.radListView1.Name = "radListView1"
			Me.radListView1.Size = New System.Drawing.Size(919, 462)
			Me.radListView1.TabIndex = 0
			Me.radListView1.Text = "radListView1"
			Me.radListView1.ValueMember = "CarID"
			Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView
'			Me.radListView1.VisualItemCreating += New Telerik.WinControls.UI.ListViewVisualItemCreatingEventHandler(radListView1_VisualItemCreating);
'			Me.radListView1.BindingCompleted += New System.EventHandler(Me.radListView1_BindingCompleted);
'			Me.radListView1.ItemDataBound += New Telerik.WinControls.UI.ListViewItemEventHandler(Me.radListView1_ItemDataBound);
'			Me.radListView1.ColumnCreating += New Telerik.WinControls.UI.ListViewColumnCreatingEventHandler(Me.radListView1_ColumnCreating);
			' 
			' carsRatesDataTableBindingSource
			' 
			Me.carsRatesDataTableBindingSource.DataMember = "CarsRatesDataTable"
			Me.carsRatesDataTableBindingSource.DataSource = Me.sofiaCarRentalDataSet
			' 
			' sofiaCarRentalDataSet
			' 
			Me.sofiaCarRentalDataSet.DataSetName = "SofiaCarRentalDataSet"
			Me.sofiaCarRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' radCommandBar1
			' 
			Me.radCommandBar1.AutoSize = True
			Me.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radCommandBar1.Location = New System.Drawing.Point(0, 0)
			Me.radCommandBar1.Name = "radCommandBar1"
			Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() { Me.commandBarRowElement1})
			Me.radCommandBar1.Size = New System.Drawing.Size(919, 30)
			Me.radCommandBar1.TabIndex = 4
			' 
			' commandBarRowElement1
			' 
			Me.commandBarRowElement1.DisplayName = Nothing
			Me.commandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
			Me.commandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() { Me.commandBarStripElement1})
			' 
			' commandBarStripElement1
			' 
			Me.commandBarStripElement1.DisplayName = "commandBarStripElement1"
			Me.commandBarStripElement1.EnableDragging = False
			Me.commandBarStripElement1.FloatingForm = Nothing
			Me.commandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.commandBarLabel1, Me.commandBarDropDownSort, Me.commandBarSeparator1, Me.commandBarLabel2, Me.commandBarDropDownGroup, Me.commandBarSeparator2, Me.commandBarToggleList, Me.commandBarToggleTiles, Me.commandBarToggleDetails, Me.commandBarSeparator3, Me.commandBarTextBoxFilter})
			Me.commandBarStripElement1.Name = "commandBarStripElement1"
			Me.commandBarStripElement1.StretchHorizontally = True
			Me.commandBarStripElement1.Text = ""
			' 
			' commandBarLabel1
			' 
			Me.commandBarLabel1.AccessibleDescription = "Sort By:"
			Me.commandBarLabel1.AccessibleName = "Sort By:"
			Me.commandBarLabel1.DisplayName = "commandBarLabel1"
			Me.commandBarLabel1.Name = "commandBarLabel1"
			Me.commandBarLabel1.Text = "Sort By:"
			Me.commandBarLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarLabel1.VisibleInOverflowMenu = True
			' 
			' commandBarDropDownSort
			' 
			Me.commandBarDropDownSort.AccessibleDescription = "None"
			Me.commandBarDropDownSort.AccessibleName = "None"
			Me.commandBarDropDownSort.DisplayName = "commandBarDropDownList1"
			Me.commandBarDropDownSort.DropDownAnimationEnabled = True
			Me.commandBarDropDownSort.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem10.Text = "None"
			radListDataItem10.TextWrap = True
			radListDataItem11.Text = "Make"
			radListDataItem11.TextWrap = True
			radListDataItem12.Text = "Model"
			radListDataItem12.TextWrap = True
			radListDataItem13.Text = "Category"
			radListDataItem13.TextWrap = True
			radListDataItem14.Text = "Year"
			radListDataItem14.TextWrap = True
			Me.commandBarDropDownSort.Items.Add(radListDataItem10)
			Me.commandBarDropDownSort.Items.Add(radListDataItem11)
			Me.commandBarDropDownSort.Items.Add(radListDataItem12)
			Me.commandBarDropDownSort.Items.Add(radListDataItem13)
			Me.commandBarDropDownSort.Items.Add(radListDataItem14)
			Me.commandBarDropDownSort.Name = "commandBarDropDownSort"
			Me.commandBarDropDownSort.Text = "None"
			Me.commandBarDropDownSort.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarDropDownSort.VisibleInOverflowMenu = True
'			Me.commandBarDropDownSort.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.commandBarDropDownSort_SelectedIndexChanged);
			' 
			' commandBarSeparator1
			' 
			Me.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1"
			Me.commandBarSeparator1.AccessibleName = "commandBarSeparator1"
			Me.commandBarSeparator1.DisplayName = "commandBarSeparator1"
			Me.commandBarSeparator1.Name = "commandBarSeparator1"
			Me.commandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarSeparator1.VisibleInOverflowMenu = False
			' 
			' commandBarLabel2
			' 
			Me.commandBarLabel2.AccessibleDescription = "Group By:"
			Me.commandBarLabel2.AccessibleName = "Group By:"
			Me.commandBarLabel2.DisplayName = "commandBarLabel2"
			Me.commandBarLabel2.Name = "commandBarLabel2"
			Me.commandBarLabel2.Text = "Group By:"
			Me.commandBarLabel2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarLabel2.VisibleInOverflowMenu = True
			' 
			' commandBarDropDownGroup
			' 
			Me.commandBarDropDownGroup.DisplayName = "commandBarDropDownList2"
			Me.commandBarDropDownGroup.DropDownAnimationEnabled = True
			Me.commandBarDropDownGroup.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem15.Text = "None"
			radListDataItem15.TextWrap = True
			radListDataItem16.Text = "Make"
			radListDataItem16.TextWrap = True
			radListDataItem17.Text = "Category"
			radListDataItem17.TextWrap = True
			radListDataItem18.Text = "Year"
			radListDataItem18.TextWrap = True
			Me.commandBarDropDownGroup.Items.Add(radListDataItem15)
			Me.commandBarDropDownGroup.Items.Add(radListDataItem16)
			Me.commandBarDropDownGroup.Items.Add(radListDataItem17)
			Me.commandBarDropDownGroup.Items.Add(radListDataItem18)
			Me.commandBarDropDownGroup.Name = "commandBarDropDownGroup"
			Me.commandBarDropDownGroup.Text = ""
			Me.commandBarDropDownGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarDropDownGroup.VisibleInOverflowMenu = True
'			Me.commandBarDropDownGroup.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.commandBarDropDownGroup_SelectedIndexChanged);
			' 
			' commandBarSeparator2
			' 
			Me.commandBarSeparator2.AccessibleDescription = "commandBarSeparator2"
			Me.commandBarSeparator2.AccessibleName = "commandBarSeparator2"
			Me.commandBarSeparator2.DisplayName = "commandBarSeparator2"
			Me.commandBarSeparator2.Name = "commandBarSeparator2"
			Me.commandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarSeparator2.VisibleInOverflowMenu = False
			' 
			' commandBarToggleList
			' 
			Me.commandBarToggleList.AccessibleDescription = "commandBarToggleButton1"
			Me.commandBarToggleList.AccessibleName = "commandBarToggleButton1"
			Me.commandBarToggleList.DisplayName = "commandBarToggleButton1"
			Me.commandBarToggleList.Image = Global.Resources.tiles_icon
			Me.commandBarToggleList.Name = "commandBarToggleList"
			Me.commandBarToggleList.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
			Me.commandBarToggleList.Text = "commandBarToggleButton1"
			Me.commandBarToggleList.ToolTipText = "ListView"
			Me.commandBarToggleList.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarToggleList.VisibleInOverflowMenu = True
'			Me.commandBarToggleList.ToggleStateChanging += New Telerik.WinControls.UI.StateChangingEventHandler(Me.viewToggleButton_ToggleStateChanging);
'			Me.commandBarToggleList.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.viewToggleButton_ToggleStateChanged);
			' 
			' commandBarToggleTiles
			' 
			Me.commandBarToggleTiles.AccessibleDescription = "commandBarToggleButton2"
			Me.commandBarToggleTiles.AccessibleName = "commandBarToggleButton2"
			Me.commandBarToggleTiles.DisplayName = "commandBarToggleButton2"
			Me.commandBarToggleTiles.Image = Global.Resources.list_icon
			Me.commandBarToggleTiles.Name = "commandBarToggleTiles"
			Me.commandBarToggleTiles.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
			Me.commandBarToggleTiles.Text = "commandBarToggleButton2"
			Me.commandBarToggleTiles.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.commandBarToggleTiles.ToolTipText = "IconsView"
			Me.commandBarToggleTiles.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarToggleTiles.VisibleInOverflowMenu = True
'			Me.commandBarToggleTiles.ToggleStateChanging += New Telerik.WinControls.UI.StateChangingEventHandler(Me.viewToggleButton_ToggleStateChanging);
'			Me.commandBarToggleTiles.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.viewToggleButton_ToggleStateChanged);
			' 
			' commandBarToggleDetails
			' 
			Me.commandBarToggleDetails.AccessibleDescription = "commandBarToggleButton3"
			Me.commandBarToggleDetails.AccessibleName = "commandBarToggleButton3"
			Me.commandBarToggleDetails.DisplayName = "commandBarToggleButton3"
			Me.commandBarToggleDetails.Image = Global.Resources.details_icon
			Me.commandBarToggleDetails.Name = "commandBarToggleDetails"
			Me.commandBarToggleDetails.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
			Me.commandBarToggleDetails.Text = "commandBarToggleButton3"
			Me.commandBarToggleDetails.ToolTipText = "DetailsView"
			Me.commandBarToggleDetails.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarToggleDetails.VisibleInOverflowMenu = True
'			Me.commandBarToggleDetails.ToggleStateChanging += New Telerik.WinControls.UI.StateChangingEventHandler(Me.viewToggleButton_ToggleStateChanging);
'			Me.commandBarToggleDetails.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.viewToggleButton_ToggleStateChanged);
			' 
			' commandBarSeparator3
			' 
			Me.commandBarSeparator3.AccessibleDescription = "commandBarSeparator3"
			Me.commandBarSeparator3.AccessibleName = "commandBarSeparator3"
			Me.commandBarSeparator3.DisplayName = "commandBarSeparator3"
			Me.commandBarSeparator3.Name = "commandBarSeparator3"
			Me.commandBarSeparator3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarSeparator3.VisibleInOverflowMenu = False
			' 
			' commandBarTextBoxFilter
			' 
			Me.commandBarTextBoxFilter.DisplayName = "commandBarTextBox1"
			Me.commandBarTextBoxFilter.MinSize = New System.Drawing.Size(200, 0)
			Me.commandBarTextBoxFilter.Name = "commandBarTextBoxFilter"
			Me.commandBarTextBoxFilter.StretchHorizontally = True
			Me.commandBarTextBoxFilter.Text = ""
			Me.commandBarTextBoxFilter.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarTextBoxFilter.VisibleInOverflowMenu = True
'			Me.commandBarTextBoxFilter.TextChanged += New System.EventHandler(Me.commandBarTextBoxFilter_TextChanged);

			' 
			' carsRatesDataTableTableAdapter
			' 
			Me.carsRatesDataTableTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoScroll = False
			Me.Controls.Add(Me.radListView1)
			Me.Controls.Add(Me.radCommandBar1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(920,600)
			CType(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsRatesDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sofiaCarRentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radListView1 As Telerik.WinControls.UI.RadListView
		Private radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
		Private commandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
		Private commandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
		Private commandBarLabel1 As Telerik.WinControls.UI.CommandBarLabel
		Private WithEvents commandBarDropDownSort As Telerik.WinControls.UI.CommandBarDropDownList
		Private commandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
		Private commandBarLabel2 As Telerik.WinControls.UI.CommandBarLabel
		Private WithEvents commandBarDropDownGroup As Telerik.WinControls.UI.CommandBarDropDownList
		Private commandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
		Private WithEvents commandBarTextBoxFilter As Telerik.WinControls.UI.CommandBarTextBox
		Private WithEvents commandBarToggleList As Telerik.WinControls.UI.CommandBarToggleButton
		Private WithEvents commandBarToggleTiles As Telerik.WinControls.UI.CommandBarToggleButton
		Private WithEvents commandBarToggleDetails As Telerik.WinControls.UI.CommandBarToggleButton
		Private commandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
        Private sofiaCarRentalDataSet As Telerik.Examples.WinControls.DataSources.SofiaCarRentalDataSet
		Private carsRatesDataTableBindingSource As System.Windows.Forms.BindingSource
        Private carsRatesDataTableTableAdapter As Telerik.Examples.WinControls.DataSources.SofiaCarRentalDataSetTableAdapters.CarsRatesDataTableTableAdapter
	End Class
End Namespace