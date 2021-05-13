Namespace Telerik.Examples.WinControls.DataFilter.FirstLook
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
			Dim gridViewDecimalColumn1 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn2 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDateTimeColumn1 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn2 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn3 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDecimalColumn3 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn4 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim tableViewDefinition1 As New Telerik.WinControls.UI.TableViewDefinition()
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.ordersBindingSource = New BindingSource(Me.components)
			Me.ordersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter()
			Me.radDataFilter1 = New Telerik.WinControls.UI.RadDataFilter()
			Me.dataFilterDescriptorItem1 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem2 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem3 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem4 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem5 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem6 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem7 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem8 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem9 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem10 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem11 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem12 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem13 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem14 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.dataFilterDescriptorItem15 = New Telerik.WinControls.UI.DataFilterDescriptorItem()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
			Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
			Me.radScrollablePanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDataFilter1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel1.SuspendLayout()
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel2.SuspendLayout()
			CType(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radScrollablePanel1.PanelContainer.SuspendLayout()
			Me.radScrollablePanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(819, 68)
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.northwindDataSet
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' radDataFilter1
			' 
			Me.radDataFilter1.DataSource = Me.ordersBindingSource
			Me.radDataFilter1.Descriptors.AddRange(New Telerik.WinControls.RadItem() { Me.dataFilterDescriptorItem1, Me.dataFilterDescriptorItem2, Me.dataFilterDescriptorItem3, Me.dataFilterDescriptorItem4, Me.dataFilterDescriptorItem5, Me.dataFilterDescriptorItem6, Me.dataFilterDescriptorItem7, Me.dataFilterDescriptorItem8, Me.dataFilterDescriptorItem9, Me.dataFilterDescriptorItem10, Me.dataFilterDescriptorItem11, Me.dataFilterDescriptorItem12, Me.dataFilterDescriptorItem13, Me.dataFilterDescriptorItem14, Me.dataFilterDescriptorItem15})
			Me.radDataFilter1.Dock = DockStyle.Fill
			Me.radDataFilter1.Expression = "([OrderDate] < '11/1/1996 2:14:18 PM' OR [OrderDate] > '10/1/1996 2:13:49 PM') AN" & "D [ShipCity] = 'Seattle' AND [ShipCountry] = 'USA'"
			Me.radDataFilter1.Location = New Point(0, 0)
			Me.radDataFilter1.Name = "radDataFilter1"
			Me.radDataFilter1.Padding = New Padding(5, 4, 5, 4)
			Me.radDataFilter1.Size = New Size(597, 905)
			Me.radDataFilter1.TabIndex = 2
			Me.radDataFilter1.Text = "radDataFilter1"
			' 
			' dataFilterDescriptorItem1
			' 
			Me.dataFilterDescriptorItem1.DescriptorName = "OrderID"
			Me.dataFilterDescriptorItem1.DescriptorType = GetType(Integer)
			Me.dataFilterDescriptorItem1.IsAutoGenerated = True
			Me.dataFilterDescriptorItem1.Name = "dataFilterDescriptorItem1"
			' 
			' dataFilterDescriptorItem2
			' 
			Me.dataFilterDescriptorItem2.DescriptorName = "CustomerID"
			Me.dataFilterDescriptorItem2.DescriptorType = GetType(String)
			Me.dataFilterDescriptorItem2.IsAutoGenerated = True
			Me.dataFilterDescriptorItem2.Name = "dataFilterDescriptorItem2"
			' 
			' dataFilterDescriptorItem3
			' 
			Me.dataFilterDescriptorItem3.DescriptorName = "EmployeeID"
			Me.dataFilterDescriptorItem3.DescriptorType = GetType(Integer)
			Me.dataFilterDescriptorItem3.IsAutoGenerated = True
			Me.dataFilterDescriptorItem3.Name = "dataFilterDescriptorItem3"
			' 
			' dataFilterDescriptorItem4
			' 
			Me.dataFilterDescriptorItem4.DescriptorName = "OrderDate"
			Me.dataFilterDescriptorItem4.DescriptorType = GetType(Date)
			Me.dataFilterDescriptorItem4.IsAutoGenerated = True
			Me.dataFilterDescriptorItem4.Name = "dataFilterDescriptorItem4"
			' 
			' dataFilterDescriptorItem5
			' 
			Me.dataFilterDescriptorItem5.DescriptorName = "RequiredDate"
			Me.dataFilterDescriptorItem5.DescriptorType = GetType(Date)
			Me.dataFilterDescriptorItem5.IsAutoGenerated = True
			Me.dataFilterDescriptorItem5.Name = "dataFilterDescriptorItem5"
			' 
			' dataFilterDescriptorItem6
			' 
			Me.dataFilterDescriptorItem6.DescriptorName = "ShippedDate"
			Me.dataFilterDescriptorItem6.DescriptorType = GetType(Date)
			Me.dataFilterDescriptorItem6.IsAutoGenerated = True
			Me.dataFilterDescriptorItem6.Name = "dataFilterDescriptorItem6"
			' 
			' dataFilterDescriptorItem7
			' 
			Me.dataFilterDescriptorItem7.DescriptorName = "ShipVia"
			Me.dataFilterDescriptorItem7.DescriptorType = GetType(Integer)
			Me.dataFilterDescriptorItem7.IsAutoGenerated = True
			Me.dataFilterDescriptorItem7.Name = "dataFilterDescriptorItem7"
			' 
			' dataFilterDescriptorItem8
			' 
			Me.dataFilterDescriptorItem8.DescriptorName = "Freight"
			Me.dataFilterDescriptorItem8.DescriptorType = GetType(Decimal)
			Me.dataFilterDescriptorItem8.IsAutoGenerated = True
			Me.dataFilterDescriptorItem8.Name = "dataFilterDescriptorItem8"
			' 
			' dataFilterDescriptorItem9
			' 
			Me.dataFilterDescriptorItem9.DescriptorName = "ShipName"
			Me.dataFilterDescriptorItem9.DescriptorType = GetType(String)
			Me.dataFilterDescriptorItem9.IsAutoGenerated = True
			Me.dataFilterDescriptorItem9.Name = "dataFilterDescriptorItem9"
			' 
			' dataFilterDescriptorItem10
			' 
			Me.dataFilterDescriptorItem10.DescriptorName = "ShipAddress"
			Me.dataFilterDescriptorItem10.DescriptorType = GetType(String)
			Me.dataFilterDescriptorItem10.IsAutoGenerated = True
			Me.dataFilterDescriptorItem10.Name = "dataFilterDescriptorItem10"
			' 
			' dataFilterDescriptorItem11
			' 
			Me.dataFilterDescriptorItem11.DescriptorName = "ShipCity"
			Me.dataFilterDescriptorItem11.DescriptorType = GetType(String)
			Me.dataFilterDescriptorItem11.IsAutoGenerated = True
			Me.dataFilterDescriptorItem11.Name = "dataFilterDescriptorItem11"
			' 
			' dataFilterDescriptorItem12
			' 
			Me.dataFilterDescriptorItem12.DescriptorName = "ShipRegion"
			Me.dataFilterDescriptorItem12.DescriptorType = GetType(String)
			Me.dataFilterDescriptorItem12.IsAutoGenerated = True
			Me.dataFilterDescriptorItem12.Name = "dataFilterDescriptorItem12"
			' 
			' dataFilterDescriptorItem13
			' 
			Me.dataFilterDescriptorItem13.DescriptorName = "ShipPostalCode"
			Me.dataFilterDescriptorItem13.DescriptorType = GetType(String)
			Me.dataFilterDescriptorItem13.IsAutoGenerated = True
			Me.dataFilterDescriptorItem13.Name = "dataFilterDescriptorItem13"
			' 
			' dataFilterDescriptorItem14
			' 
			Me.dataFilterDescriptorItem14.DescriptorName = "ShipCountry"
			Me.dataFilterDescriptorItem14.DescriptorType = GetType(String)
			Me.dataFilterDescriptorItem14.IsAutoGenerated = True
			Me.dataFilterDescriptorItem14.Name = "dataFilterDescriptorItem14"
			' 
			' dataFilterDescriptorItem15
			' 
			Me.dataFilterDescriptorItem15.DescriptorName = "OrdersOrder Details"
			Me.dataFilterDescriptorItem15.DescriptorType = GetType(System.ComponentModel.IBindingList)
			Me.dataFilterDescriptorItem15.IsAutoGenerated = True
			Me.dataFilterDescriptorItem15.Name = "dataFilterDescriptorItem15"
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			gridViewDecimalColumn1.DataType = GetType(Integer)
			gridViewDecimalColumn1.FieldName = "OrderID"
			gridViewDecimalColumn1.HeaderText = "OrderID"
			gridViewDecimalColumn1.IsAutoGenerated = True
			gridViewDecimalColumn1.Name = "OrderID"
			gridViewDecimalColumn1.Width = 98
			gridViewTextBoxColumn1.FieldName = "CustomerID"
			gridViewTextBoxColumn1.HeaderText = "CustomerID"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "CustomerID"
			gridViewTextBoxColumn1.Width = 98
			gridViewDecimalColumn2.DataType = GetType(Integer)
			gridViewDecimalColumn2.FieldName = "EmployeeID"
			gridViewDecimalColumn2.HeaderText = "EmployeeID"
			gridViewDecimalColumn2.IsAutoGenerated = True
			gridViewDecimalColumn2.IsVisible = False
			gridViewDecimalColumn2.Name = "EmployeeID"
			gridViewDecimalColumn2.Width = 68
			gridViewDateTimeColumn1.CustomFormat = ""
			gridViewDateTimeColumn1.FieldName = "OrderDate"
			gridViewDateTimeColumn1.Format = DateTimePickerFormat.Short
			gridViewDateTimeColumn1.FormatString = "{0:MM/dd/yyyy}"
			gridViewDateTimeColumn1.HeaderText = "OrderDate"
			gridViewDateTimeColumn1.IsAutoGenerated = True
			gridViewDateTimeColumn1.Name = "OrderDate"
			gridViewDateTimeColumn1.Width = 98
			gridViewDateTimeColumn2.CustomFormat = ""
			gridViewDateTimeColumn2.FieldName = "RequiredDate"
			gridViewDateTimeColumn2.Format = DateTimePickerFormat.Short
			gridViewDateTimeColumn2.FormatString = "{0:MM/dd/yyyy}"
			gridViewDateTimeColumn2.HeaderText = "RequiredDate"
			gridViewDateTimeColumn2.IsAutoGenerated = True
			gridViewDateTimeColumn2.Name = "RequiredDate"
			gridViewDateTimeColumn2.Width = 98
			gridViewDateTimeColumn3.CustomFormat = ""
			gridViewDateTimeColumn3.FieldName = "ShippedDate"
			gridViewDateTimeColumn3.Format = DateTimePickerFormat.Short
			gridViewDateTimeColumn3.FormatString = "{0:MM/dd/yyyy}"
			gridViewDateTimeColumn3.HeaderText = "ShippedDate"
			gridViewDateTimeColumn3.IsAutoGenerated = True
			gridViewDateTimeColumn3.Name = "ShippedDate"
			gridViewDateTimeColumn3.Width = 98
			gridViewDecimalColumn3.DataType = GetType(Integer)
			gridViewDecimalColumn3.FieldName = "ShipVia"
			gridViewDecimalColumn3.HeaderText = "ShipVia"
			gridViewDecimalColumn3.IsAutoGenerated = True
			gridViewDecimalColumn3.IsVisible = False
			gridViewDecimalColumn3.Name = "ShipVia"
			gridViewDecimalColumn3.Width = 74
			gridViewDecimalColumn4.FieldName = "Freight"
			gridViewDecimalColumn4.HeaderText = "Freight"
			gridViewDecimalColumn4.IsAutoGenerated = True
			gridViewDecimalColumn4.Name = "Freight"
			gridViewDecimalColumn4.Width = 98
			gridViewTextBoxColumn2.FieldName = "ShipName"
			gridViewTextBoxColumn2.HeaderText = "ShipName"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.IsVisible = False
			gridViewTextBoxColumn2.Name = "ShipName"
			gridViewTextBoxColumn2.Width = 96
			gridViewTextBoxColumn3.FieldName = "ShipAddress"
			gridViewTextBoxColumn3.HeaderText = "ShipAddress"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.IsVisible = False
			gridViewTextBoxColumn3.Name = "ShipAddress"
			gridViewTextBoxColumn3.Width = 74
			gridViewTextBoxColumn4.FieldName = "ShipCity"
			gridViewTextBoxColumn4.HeaderText = "ShipCity"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "ShipCity"
			gridViewTextBoxColumn4.Width = 98
			gridViewTextBoxColumn5.FieldName = "ShipRegion"
			gridViewTextBoxColumn5.HeaderText = "ShipRegion"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.Name = "ShipRegion"
			gridViewTextBoxColumn5.Width = 98
			gridViewTextBoxColumn6.FieldName = "ShipPostalCode"
			gridViewTextBoxColumn6.HeaderText = "ShipPostalCode"
			gridViewTextBoxColumn6.IsAutoGenerated = True
			gridViewTextBoxColumn6.IsVisible = False
			gridViewTextBoxColumn6.Name = "ShipPostalCode"
			gridViewTextBoxColumn6.Width = 74
			gridViewTextBoxColumn7.FieldName = "ShipCountry"
			gridViewTextBoxColumn7.HeaderText = "ShipCountry"
			gridViewTextBoxColumn7.IsAutoGenerated = True
			gridViewTextBoxColumn7.Name = "ShipCountry"
			gridViewTextBoxColumn7.Width = 92
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewDecimalColumn1, gridViewTextBoxColumn1, gridViewDecimalColumn2, gridViewDateTimeColumn1, gridViewDateTimeColumn2, gridViewDateTimeColumn3, gridViewDecimalColumn3, gridViewDecimalColumn4, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewTextBoxColumn7})
			Me.radGridView1.MasterTemplate.DataSource = Me.ordersBindingSource
			Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New Size(889, 905)
			Me.radGridView1.TabIndex = 3
			Me.radGridView1.Text = "radGridView1"
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
			Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
			Me.radSplitContainer1.Dock = DockStyle.Fill
			Me.radSplitContainer1.Location = New Point(0, 0)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			Me.radSplitContainer1.Size = New Size(1490, 905)
			Me.radSplitContainer1.TabIndex = 1
			Me.radSplitContainer1.TabStop = False
			Me.radSplitContainer1.Text = "radSplitContainer1"
			' 
			' splitPanel1
			' 
			Me.splitPanel1.Controls.Add(Me.radDataFilter1)
			Me.splitPanel1.Location = New Point(0, 0)
			Me.splitPanel1.Name = "splitPanel1"
			' 
			' 
			' 
			Me.splitPanel1.RootElement.MinSize = New Size(400, 200)
			Me.splitPanel1.Size = New Size(597, 905)
			Me.splitPanel1.SizeInfo.AutoSizeScale = New SizeF(-0.09811828F, 0F)
			Me.splitPanel1.SizeInfo.MinimumSize = New Size(400, 200)
			Me.splitPanel1.SizeInfo.SplitterCorrection = New Size(-141, 0)
			Me.splitPanel1.TabIndex = 0
			Me.splitPanel1.TabStop = False
			Me.splitPanel1.Text = "splitPanel1"
			' 
			' splitPanel2
			' 
			Me.splitPanel2.Controls.Add(Me.radGridView1)
			Me.splitPanel2.Location = New Point(601, 0)
			Me.splitPanel2.Name = "splitPanel2"
			' 
			' 
			' 
			Me.splitPanel2.RootElement.MinSize = New Size(400, 200)
			Me.splitPanel2.Size = New Size(889, 905)
			Me.splitPanel2.SizeInfo.AutoSizeScale = New SizeF(0.09811831F, 0F)
			Me.splitPanel2.SizeInfo.MinimumSize = New Size(400, 200)
			Me.splitPanel2.SizeInfo.SplitterCorrection = New Size(141, 0)
			Me.splitPanel2.TabIndex = 1
			Me.splitPanel2.TabStop = False
			Me.splitPanel2.Text = "splitPanel2"
			' 
			' radScrollablePanel1
			' 
			Me.radScrollablePanel1.Dock = DockStyle.Fill
			Me.radScrollablePanel1.Location = New Point(0, 0)
			Me.radScrollablePanel1.Name = "radScrollablePanel1"
			' 
			' radScrollablePanel1.PanelContainer
			' 
			Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radSplitContainer1)
			Me.radScrollablePanel1.PanelContainer.MinimumSize = New Size(800, 200)
			Me.radScrollablePanel1.PanelContainer.Size = New Size(1490, 905)
			Me.radScrollablePanel1.Size = New Size(1492, 907)
			Me.radScrollablePanel1.TabIndex = 2
			Me.radScrollablePanel1.Text = "radScrollablePanel1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radScrollablePanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1502, 917)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radScrollablePanel1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDataFilter1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel1.ResumeLayout(False)
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel2.ResumeLayout(False)
			Me.radScrollablePanel1.PanelContainer.ResumeLayout(False)
			CType(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radScrollablePanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private northwindDataSet As DataSources.NorthwindDataSet
		Private ordersBindingSource As BindingSource
		Private ordersTableAdapter As DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter
		Private radDataFilter1 As Telerik.WinControls.UI.RadDataFilter
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
		Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
		Private dataFilterDescriptorItem1 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem2 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem3 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem4 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem5 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem6 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem7 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem8 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem9 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem10 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem11 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem12 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem13 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem14 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private dataFilterDescriptorItem15 As Telerik.WinControls.UI.DataFilterDescriptorItem
		Private radScrollablePanel1 As Telerik.WinControls.UI.RadScrollablePanel
	End Class
End Namespace