Namespace Telerik.Examples.WinControls.CardView.Settings
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
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim listViewDetailColumn5 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Image")
			Dim listViewDetailColumn6 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "City")
			Dim listViewDetailColumn7 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Population")
			Dim listViewDetailColumn8 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Country")
			Me.radGroupBoxProperties = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDropDownListOrientation = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabelOrientation = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBoxAllowCustomize = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxHotTracking = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxShowGroups = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxAllowEdit = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBoxVisualSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radColorBoxBorderColor = New Telerik.WinControls.UI.RadColorBox()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radBrowseEditorFont = New Telerik.WinControls.UI.RadBrowseEditor()
			Me.radColorBoxForeColor = New Telerik.WinControls.UI.RadColorBox()
			Me.radColorBoxBackColor = New Telerik.WinControls.UI.RadColorBox()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownListVisualItems = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabelSelectItem = New Telerik.WinControls.UI.RadLabel()
			Me.radCardView1 = New Telerik.WinControls.UI.RadCardView()
			Me.cardViewGroupItem1 = New Telerik.WinControls.UI.CardViewGroupItem()
			Me.cardViewItem1 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem2 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem3 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem4 = New Telerik.WinControls.UI.CardViewItem()
			Me.radContextMenu1 = New Telerik.WinControls.UI.RadContextMenu(Me.components)
			Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.doubleBufferedTableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupBoxProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxProperties.SuspendLayout()
			CType(Me.radDropDownListOrientation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelOrientation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxAllowCustomize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxHotTracking, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxShowGroups, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxAllowEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBoxVisualSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxVisualSettings.SuspendLayout()
			CType(Me.radColorBoxBorderColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBrowseEditorFont, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radColorBoxForeColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radColorBoxBackColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListVisualItems, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelSelectItem, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCardView1.CardTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
			Me.doubleBufferedTableLayoutPanel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1651, 25)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBoxVisualSettings)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBoxProperties)
			Me.settingsPanel.PanelContainer.Size = New Size(313, 647)
			Me.settingsPanel.Size = New Size(313, 647)
			' 
			' radGroupBoxProperties
			' 
			Me.radGroupBoxProperties.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBoxProperties.Anchor = AnchorStyles.Top
			Me.radGroupBoxProperties.Controls.Add(Me.doubleBufferedTableLayoutPanel2)
			Me.radGroupBoxProperties.HeaderText = "Properties"
            Me.radGroupBoxProperties.Location = New Point(16, 10)
			Me.radGroupBoxProperties.Name = "radGroupBoxProperties"
            Me.radGroupBoxProperties.Size = New Size(287, 230)
			Me.radGroupBoxProperties.TabIndex = 1
			Me.radGroupBoxProperties.Tag = "1"
			Me.radGroupBoxProperties.Text = "Properties"
			' 
			' radDropDownListOrientation
			' 
			Me.radDropDownListOrientation.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radDropDownListOrientation.DropDownHeight = 141
			Me.radDropDownListOrientation.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem3.Selected = True
			radListDataItem3.Text = "Horizontal"
			radListDataItem4.Text = "Vertical"
			Me.radDropDownListOrientation.Items.Add(radListDataItem3)
			Me.radDropDownListOrientation.Items.Add(radListDataItem4)
			Me.radDropDownListOrientation.Location = New Point(136, 164)
			Me.radDropDownListOrientation.Name = "radDropDownListOrientation"
			Me.radDropDownListOrientation.Size = New Size(130, 24)
			Me.radDropDownListOrientation.TabIndex = 7
			Me.radDropDownListOrientation.Tag = "1"
			Me.radDropDownListOrientation.Text = "Horizontal"
            AddHandler Me.radDropDownListOrientation.SelectedIndexChanged, New Telerik.WinControls.UI.Data.PositionChangedEventHandler(AddressOf Me.radDropDownListOrientation_SelectedIndexChanged)
			' 
			' radLabelOrientation
			' 
			Me.radLabelOrientation.Location = New Point(4, 164)
			Me.radLabelOrientation.Name = "radLabelOrientation"
			Me.radLabelOrientation.Size = New Size(114, 22)
			Me.radLabelOrientation.TabIndex = 6
			Me.radLabelOrientation.Text = "Items Orientation"
			' 
			' radCheckBoxAllowCustomize
			' 
			Me.radCheckBoxAllowCustomize.Location = New Point(4, 124)
			Me.radCheckBoxAllowCustomize.Name = "radCheckBoxAllowCustomize"
			Me.radCheckBoxAllowCustomize.Size = New Size(217, 22)
			Me.radCheckBoxAllowCustomize.TabIndex = 3
			Me.radCheckBoxAllowCustomize.Text = "Allow Customize CardTemplate"
            AddHandler Me.radCheckBoxAllowCustomize.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxAllowCustomize_ToggleStateChanged)
			' 
			' radCheckBoxHotTracking
			' 
			Me.radCheckBoxHotTracking.Location = New Point(4, 84)
			Me.radCheckBoxHotTracking.Name = "radCheckBoxHotTracking"
			Me.radCheckBoxHotTracking.Size = New Size(145, 22)
			Me.radCheckBoxHotTracking.TabIndex = 2
			Me.radCheckBoxHotTracking.Text = "Enable HotTracking"
            AddHandler Me.radCheckBoxHotTracking.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxHotTracking_ToggleStateChanged)
			' 
			' radCheckBoxShowGroups
			' 
			Me.radCheckBoxShowGroups.Location = New Point(4, 44)
			Me.radCheckBoxShowGroups.Name = "radCheckBoxShowGroups"
			Me.radCheckBoxShowGroups.Size = New Size(106, 22)
			Me.radCheckBoxShowGroups.TabIndex = 1
			Me.radCheckBoxShowGroups.Text = "Show groups"
            AddHandler Me.radCheckBoxShowGroups.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxShowGroups_ToggleStateChanged)
			' 
			' radCheckBoxAllowEdit
			' 
			Me.radCheckBoxAllowEdit.Location = New Point(4, 4)
			Me.radCheckBoxAllowEdit.Name = "radCheckBoxAllowEdit"
			Me.radCheckBoxAllowEdit.Size = New Size(134, 22)
			Me.radCheckBoxAllowEdit.TabIndex = 0
			Me.radCheckBoxAllowEdit.Text = "Enable Edit Items "
            AddHandler Me.radCheckBoxAllowEdit.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxAllowEdit_ToggleStateChanged)
			' 
			' radGroupBoxVisualSettings
			' 
			Me.radGroupBoxVisualSettings.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBoxVisualSettings.Anchor = AnchorStyles.Top
			Me.radGroupBoxVisualSettings.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
			Me.radGroupBoxVisualSettings.HeaderText = "Edit Visual Settings"
            Me.radGroupBoxVisualSettings.Location = New Point(16, 250)
			Me.radGroupBoxVisualSettings.Name = "radGroupBoxVisualSettings"
            Me.radGroupBoxVisualSettings.Size = New Size(287, 265)
			Me.radGroupBoxVisualSettings.TabIndex = 2
			Me.radGroupBoxVisualSettings.Tag = "1"
			Me.radGroupBoxVisualSettings.Text = "Edit Visual Settings"
			' 
			' radColorBoxBorderColor
			' 
			Me.radColorBoxBorderColor.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radColorBoxBorderColor.Location = New Point(127, 192)
			Me.radColorBoxBorderColor.Name = "radColorBoxBorderColor"
			Me.radColorBoxBorderColor.Size = New Size(143, 24)
			Me.radColorBoxBorderColor.TabIndex = 10
			Me.radColorBoxBorderColor.Tag = "1"
            AddHandler Me.radColorBoxBorderColor.ValueChanged, New System.EventHandler(AddressOf Me.radColorBoxBorderColor_ValueChanged)
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New Point(4, 192)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(82, 22)
			Me.radLabel4.TabIndex = 8
			Me.radLabel4.Text = "BorderColor"
			' 
			' radBrowseEditorFont
			' 
			Me.radBrowseEditorFont.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radBrowseEditorFont.DialogType = Telerik.WinControls.UI.BrowseEditorDialogType.FontDialog
			Me.radBrowseEditorFont.Location = New Point(127, 145)
			Me.radBrowseEditorFont.Name = "radBrowseEditorFont"
			Me.radBrowseEditorFont.Size = New Size(143, 24)
			Me.radBrowseEditorFont.TabIndex = 7
			Me.radBrowseEditorFont.Tag = "1"
            AddHandler Me.radBrowseEditorFont.ValueChanged, New System.EventHandler(AddressOf Me.radBrowseEditorFont_ValueChanged)
			' 
			' radColorBoxForeColor
			' 
			Me.radColorBoxForeColor.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radColorBoxForeColor.Location = New Point(127, 98)
			Me.radColorBoxForeColor.Name = "radColorBoxForeColor"
			Me.radColorBoxForeColor.Size = New Size(143, 24)
			Me.radColorBoxForeColor.TabIndex = 6
			Me.radColorBoxForeColor.Tag = "1"
            AddHandler Me.radColorBoxForeColor.ValueChanged, New System.EventHandler(AddressOf Me.radColorBoxForeColor_ValueChanged)
			' 
			' radColorBoxBackColor
			' 
			Me.radColorBoxBackColor.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radColorBoxBackColor.Location = New Point(127, 51)
			Me.radColorBoxBackColor.Name = "radColorBoxBackColor"
			Me.radColorBoxBackColor.Size = New Size(143, 24)
			Me.radColorBoxBackColor.TabIndex = 5
			Me.radColorBoxBackColor.Tag = "1"
            AddHandler Me.radColorBoxBackColor.ValueChanged, New System.EventHandler(AddressOf Me.radColorBoxBackColor_ValueChanged)
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New Point(4, 145)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(35, 22)
			Me.radLabel3.TabIndex = 4
			Me.radLabel3.Text = "Font"
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(4, 98)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(67, 22)
			Me.radLabel2.TabIndex = 3
			Me.radLabel2.Text = "ForeColor"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(4, 51)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(69, 22)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "BackColor"
			' 
			' radDropDownListVisualItems
			' 
			Me.radDropDownListVisualItems.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radDropDownListVisualItems.DropDownHeight = 141
			Me.radDropDownListVisualItems.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownListVisualItems.Location = New Point(127, 4)
			Me.radDropDownListVisualItems.Name = "radDropDownListVisualItems"
			Me.radDropDownListVisualItems.Size = New Size(143, 24)
			Me.radDropDownListVisualItems.TabIndex = 1
			Me.radDropDownListVisualItems.Tag = "1"
            AddHandler Me.radDropDownListVisualItems.SelectedIndexChanged, New Telerik.WinControls.UI.Data.PositionChangedEventHandler(AddressOf Me.radDropDownListVisualItems_SelectedIndexChanged)
            ' 
            ' radLabelSelectItem
            ' 
            Me.radLabelSelectItem.Location = New Point(4, 4)
            Me.radLabelSelectItem.Name = "radLabelSelectItem"
            Me.radLabelSelectItem.Size = New Size(78, 22)
            Me.radLabelSelectItem.TabIndex = 0
            Me.radLabelSelectItem.Text = "Select Item:"
            ' 
            ' radCardView1
            ' 
            Me.radCardView1.AllowArbitraryItemHeight = False
            ' 
            ' 
            ' 
            Me.radCardView1.CardTemplate.HiddenItems.AddRange(New Telerik.WinControls.RadItem() {Me.cardViewGroupItem1})
            Me.radCardView1.CardTemplate.Items.AddRange(New Telerik.WinControls.RadItem() {Me.cardViewItem1, Me.cardViewItem2, Me.cardViewItem3, Me.cardViewItem4})
            Me.radCardView1.CardTemplate.Location = New Point(1257, 386)
            Me.radCardView1.CardTemplate.Name = "radCardView1Template"
            Me.radCardView1.CardTemplate.Size = New Size(293, 369)
            Me.radCardView1.CardTemplate.TabIndex = 0
            listViewDetailColumn5.HeaderText = "Image"
            listViewDetailColumn5.MinWidth = 26.66667F
            listViewDetailColumn5.Width = 266.6667F
            listViewDetailColumn6.HeaderText = "City"
            listViewDetailColumn6.MinWidth = 26.66667F
            listViewDetailColumn6.Width = 266.6667F
            listViewDetailColumn7.HeaderText = "Population"
            listViewDetailColumn7.MinWidth = 26.66667F
            listViewDetailColumn7.Width = 266.6667F
            listViewDetailColumn8.HeaderText = "Country"
            listViewDetailColumn8.MinWidth = 26.66667F
            listViewDetailColumn8.Width = 266.6667F
            Me.radCardView1.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {listViewDetailColumn5, listViewDetailColumn6, listViewDetailColumn7, listViewDetailColumn8})
            Me.radCardView1.Dock = DockStyle.Fill
            Me.radCardView1.GroupIndent = 33
            Me.radCardView1.GroupItemSize = New Size(267, 25)
            Me.radCardView1.ItemSize = New Size(293, 369)
            Me.radCardView1.Location = New Point(0, 0)
            Me.radCardView1.Name = "radCardView1"
            Me.radCardView1.SelectLastAddedItem = False
            Me.radCardView1.Size = New Size(2336, 1452)
            Me.radCardView1.TabIndex = 2
            ' 
            ' cardViewGroupItem1
            ' 
            Me.cardViewGroupItem1.Bounds = New Rectangle(0, 0, 230, 320)
            Me.cardViewGroupItem1.Name = "cardViewGroupItem1"
            ' 
            ' cardViewItem1
            ' 
            Me.cardViewItem1.Bounds = New Rectangle(0, 0, 293, 273)
            Me.cardViewItem1.FieldName = "Column 0"
            Me.cardViewItem1.Name = "cardViewItem1"
            Me.cardViewItem1.Text = "Column 0"
            Me.cardViewItem1.TextProportionalSize = 0.0F
            ' 
            ' cardViewItem2
            ' 
            Me.cardViewItem2.Bounds = New Rectangle(0, 273, 293, 32)
            Me.cardViewItem2.FieldName = "Column 1"
            Me.cardViewItem2.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
            Me.cardViewItem2.Name = "cardViewItem2"
            Me.cardViewItem2.Text = "Column 1"
            Me.cardViewItem2.TextProportionalSize = 0.35F
            ' 
            ' cardViewItem3
            ' 
            Me.cardViewItem3.Bounds = New Rectangle(0, 305, 293, 32)
            Me.cardViewItem3.FieldName = "Column 2"
            Me.cardViewItem3.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
            Me.cardViewItem3.Name = "cardViewItem3"
            Me.cardViewItem3.Text = "Column 2"
            Me.cardViewItem3.TextProportionalSize = 0.35F
            ' 
            ' cardViewItem4
            ' 
            Me.cardViewItem4.Bounds = New Rectangle(0, 337, 293, 32)
            Me.cardViewItem4.FieldName = "Column 3"
            Me.cardViewItem4.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
            Me.cardViewItem4.Name = "cardViewItem4"
            Me.cardViewItem4.Text = "Column 3"
            Me.cardViewItem4.TextProportionalSize = 0.35F
            ' 
            ' tableLayoutPanel1
            ' 
            Me.doubleBufferedTableLayoutPanel1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 2
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.21073F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 54.78927F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelSelectItem, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radColorBoxBorderColor, 1, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radBrowseEditorFont, 1, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel4, 0, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radColorBoxForeColor, 1, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radColorBoxBackColor, 1, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDropDownListVisualItems, 1, 0)
            Me.doubleBufferedTableLayoutPanel1.Location = New Point(6, 25)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 5
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.Size = New Size(274, 237)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 11
            ' 
            ' tableLayoutPanel2
            ' 
            Me.doubleBufferedTableLayoutPanel2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.doubleBufferedTableLayoutPanel2.ColumnCount = 2
            Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.24812F))
            Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.75188F))
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radCheckBoxAllowEdit, 0, 0)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radDropDownListOrientation, 1, 4)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radCheckBoxShowGroups, 0, 1)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radLabelOrientation, 0, 4)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radCheckBoxHotTracking, 0, 2)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radCheckBoxAllowCustomize, 0, 3)
            Me.doubleBufferedTableLayoutPanel2.Location = New Point(6, 25)
            Me.doubleBufferedTableLayoutPanel2.Name = "doubleBufferedTableLayoutPanel2"
            Me.doubleBufferedTableLayoutPanel2.RowCount = 5
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
            Me.doubleBufferedTableLayoutPanel2.Size = New Size(270, 204)
            Me.doubleBufferedTableLayoutPanel2.TabIndex = 8
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.radCardView1)
            Me.Name = "Form1"
            Me.Size = New Size(2349, 1464)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            Me.Controls.SetChildIndex(Me.radCardView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.radGroupBoxProperties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxProperties.ResumeLayout(False)
            CType(Me.radDropDownListOrientation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelOrientation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxAllowCustomize, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxHotTracking, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxShowGroups, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxAllowEdit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBoxVisualSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxVisualSettings.ResumeLayout(False)
            CType(Me.radColorBoxBorderColor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBrowseEditorFont, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radColorBoxForeColor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radColorBoxBackColor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListVisualItems, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelSelectItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCardView1.CardTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCardView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            Me.doubleBufferedTableLayoutPanel2.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radGroupBoxProperties As Telerik.WinControls.UI.RadGroupBox
        Private radDropDownListOrientation As Telerik.WinControls.UI.RadDropDownList
        Private radLabelOrientation As Telerik.WinControls.UI.RadLabel
        Private radCheckBoxAllowCustomize As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxHotTracking As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxShowGroups As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxAllowEdit As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBoxVisualSettings As Telerik.WinControls.UI.RadGroupBox
        Private radDropDownListVisualItems As Telerik.WinControls.UI.RadDropDownList
		Private radLabelSelectItem As Telerik.WinControls.UI.RadLabel
		Private radCardView1 As Telerik.WinControls.UI.RadCardView
		Private cardViewGroupItem1 As Telerik.WinControls.UI.CardViewGroupItem
		Private cardViewItem1 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem2 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem3 As Telerik.WinControls.UI.CardViewItem
		Private cardViewItem4 As Telerik.WinControls.UI.CardViewItem
        Private radColorBoxForeColor As Telerik.WinControls.UI.RadColorBox
        Private radColorBoxBackColor As Telerik.WinControls.UI.RadColorBox
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radContextMenu1 As Telerik.WinControls.UI.RadContextMenu
        Private radColorBoxBorderColor As Telerik.WinControls.UI.RadColorBox
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radBrowseEditorFont As Telerik.WinControls.UI.RadBrowseEditor
		Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private doubleBufferedTableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace