Imports Telerik.Examples.WinControls.DataSources
Namespace Telerik.Examples.WinControls.GridView.Customize.FormatValues
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
			Dim gridViewDecimalColumn2 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn3 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn4 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Me.orderDetailsBindingSource = New BindingSource(Me.components)
			Me.nwindDataSet1 = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.orderDetailsBindingSource1 = New BindingSource(Me.components)
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radButtonAdd = New Telerik.WinControls.UI.RadButton()
			Me.order_DetailsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter()
			Me.order_DetailsTableAdapter1 = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckPrice = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckID = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckPercent = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orderDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonAdd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radCheckPrice, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckPercent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.ForeColor = Color.Black
			Me.settingsPanel.Location = New Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = Color.Black
			Me.settingsPanel.Size = New Size(200, 735)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			' 
			' orderDetailsBindingSource
			' 
			Me.orderDetailsBindingSource.DataMember = "Order Details"
			Me.orderDetailsBindingSource.DataSource = Me.nwindDataSet1
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "NwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' orderDetailsBindingSource1
			' 
			Me.orderDetailsBindingSource1.DataMember = "Order Details"
			Me.orderDetailsBindingSource1.DataSource = Me.nwindDataSet1
			' 
			' nwindRadGridView
			' 
			Me.nwindRadGridView.DataSetName = "NwindRadGridView"
			Me.nwindRadGridView.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' radTextBox1
			' 
			Me.radTextBox1.Location = New Point(13, 35)
			Me.radTextBox1.Name = "radTextBox1"
			' 
			' 
			' 
			Me.radTextBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTextBox1.Size = New Size(137, 20)
			Me.radTextBox1.TabIndex = 6
			Me.radTextBox1.TabStop = False
			Me.radTextBox1.Text = "{0:$#,###0.00}"
			' 
			' radButtonAdd
			' 
			Me.radButtonAdd.Location = New Point(13, 61)
			Me.radButtonAdd.Name = "radButtonAdd"
			Me.radButtonAdd.Size = New Size(123, 21)
			Me.radButtonAdd.TabIndex = 5
			Me.radButtonAdd.Text = "Apply to All Columns"
			' 
			' order_DetailsTableAdapter
			' 
			Me.order_DetailsTableAdapter.ClearBeforeFill = True
			' 
			' order_DetailsTableAdapter1
			' 
			Me.order_DetailsTableAdapter1.ClearBeforeFill = True
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.EnableHotTracking = False
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.Caption = Nothing
			gridViewDecimalColumn1.DataType = GetType(Integer)
			gridViewDecimalColumn1.FieldName = "OrderID"
			gridViewDecimalColumn1.HeaderText = "OrderID"
			gridViewDecimalColumn1.Name = "OrderID"
			gridViewDecimalColumn1.Width = 195
			gridViewDecimalColumn2.DataType = GetType(Integer)
			gridViewDecimalColumn2.FieldName = "ProductID"
			gridViewDecimalColumn2.HeaderText = "ProductID"
			gridViewDecimalColumn2.Name = "ProductID"
			gridViewDecimalColumn2.Width = 195
			gridViewDecimalColumn3.DataType = GetType(Decimal)
			gridViewDecimalColumn3.FieldName = "UnitPrice"
			gridViewDecimalColumn3.HeaderText = "UnitPrice"
			gridViewDecimalColumn3.Name = "UnitPrice"
			gridViewDecimalColumn3.Width = 195
			gridViewDecimalColumn4.DataType = GetType(Single)
			gridViewDecimalColumn4.FieldName = "Discount"
			gridViewDecimalColumn4.FormatString = "{0: 0.00;0.00;none}"
			gridViewDecimalColumn4.HeaderText = "Discount"
			gridViewDecimalColumn4.Name = "Discount"
			gridViewDecimalColumn4.Width = 196
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn3)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn4)
			Me.radGridView1.MasterTemplate.DataSource = Me.orderDetailsBindingSource
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.Name = "radGridView1"
			' 
			' 
			' 
			Me.radGridView1.Size = New Size(1224, 737)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radCheckPrice)
			Me.radGroupBox1.Controls.Add(Me.radCheckID)
			Me.radGroupBox1.Controls.Add(Me.radCheckPercent)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.FooterText = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupBox1.HeaderText = "Example Formatting"
			Me.radGroupBox1.Location = New Point(10, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 98)
			Me.radGroupBox1.TabIndex = 7
			Me.radGroupBox1.Text = "Example Formatting"
			' 
			' radCheckPrice
			' 
			Me.radCheckPrice.Location = New Point(12, 68)
			Me.radCheckPrice.Name = "radCheckPrice"
			Me.radCheckPrice.Size = New Size(153, 17)
			Me.radCheckPrice.TabIndex = 8
			Me.radCheckPrice.Text = "Apply '$' to UnitPrice"
			' 
			' radCheckID
			' 
			Me.radCheckID.Location = New Point(12, 46)
			Me.radCheckID.Name = "radCheckID"
			Me.radCheckID.Size = New Size(153, 17)
			Me.radCheckID.TabIndex = 8
			Me.radCheckID.Text = "Apply '#' to OrderID"

			' 
			' radCheckPercent
			' 
			Me.radCheckPercent.Location = New Point(12, 24)
			Me.radCheckPercent.Name = "radCheckPercent"
			Me.radCheckPercent.Size = New Size(153, 17)
			Me.radCheckPercent.TabIndex = 8
			Me.radCheckPercent.Text = "Apply '%' to Discount"

			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radTextBox1)
			Me.radGroupBox2.Controls.Add(Me.radButtonAdd)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.FooterText = ""
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupBox2.HeaderText = "Custom Format String"
			Me.radGroupBox2.Location = New Point(10, 112)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New Size(180, 100)
			Me.radGroupBox2.TabIndex = 8
			Me.radGroupBox2.Text = "Custom Format String"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Size(1224, 737)

			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orderDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonAdd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radCheckPrice, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckPercent, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private orderDetailsBindingSource As BindingSource
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private radButtonAdd As Telerik.WinControls.UI.RadButton
		Private order_DetailsTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter
		Private orderDetailsBindingSource1 As BindingSource
		Private nwindDataSet1 As NorthwindDataSet
		Private order_DetailsTableAdapter1 As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radCheckPrice As Telerik.WinControls.UI.RadCheckBox
		Private radCheckID As Telerik.WinControls.UI.RadCheckBox
		Private radCheckPercent As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
