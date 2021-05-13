Namespace Telerik.Examples.WinControls.GridView.Globalization.Localization
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
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn1 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn2 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn3 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.productsBindingSource = New BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.productsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.ProductsTableAdapter()
			Me.radGroupLanguages = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioGerman = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioEnglish = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupLanguages.SuspendLayout()
			CType(Me.radRadioGerman, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioEnglish, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupLanguages)
			Me.settingsPanel.ForeColor = Color.Black
			Me.settingsPanel.Location = New Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = Color.Black
			Me.settingsPanel.Size = New Size(200, 735)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupLanguages, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.EnableHotTracking = False
			Me.radGridView1.ForeColor = Color.Black
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowDragToGroup = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.Caption = Nothing
			gridViewTextBoxColumn1.FieldName = "ProductName"
			gridViewTextBoxColumn1.HeaderText = "Product Name"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "ProductName"
			gridViewTextBoxColumn1.Width = 240
			gridViewTextBoxColumn2.FieldName = "QuantityPerUnit"
			gridViewTextBoxColumn2.HeaderText = "Unit Quantity"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.TextAlignment = ContentAlignment.MiddleCenter
			gridViewTextBoxColumn2.Name = "QuantityPerUnit"
			gridViewTextBoxColumn2.Width = 183
			gridViewDecimalColumn1.DataType = GetType(Decimal)
			gridViewDecimalColumn1.FieldName = "UnitPrice"
			gridViewDecimalColumn1.FormatString = "${0:F2}"
			gridViewDecimalColumn1.HeaderText = "Unit Price"
			gridViewDecimalColumn1.IsAutoGenerated = True
			gridViewDecimalColumn1.Name = "UnitPrice"
			gridViewDecimalColumn1.Width = 183
			gridViewDecimalColumn2.DataType = GetType(Short)
			gridViewDecimalColumn2.FieldName = "UnitsInStock"
			gridViewDecimalColumn2.HeaderText = "In Stock"
			gridViewDecimalColumn2.IsAutoGenerated = True
			gridViewDecimalColumn2.Name = "UnitsInStock"
			gridViewDecimalColumn2.Width = 183
			gridViewDecimalColumn3.DataType = GetType(Short)
			gridViewDecimalColumn3.FieldName = "UnitsOnOrder"
			gridViewDecimalColumn3.FormatString = "{0:0;0;No}"
			gridViewDecimalColumn3.HeaderText = "Ordered Units"
			gridViewDecimalColumn3.IsAutoGenerated = True
			gridViewDecimalColumn3.Name = "UnitsOnOrder"
			gridViewDecimalColumn3.Width = 183
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn3)
			Me.radGridView1.MasterTemplate.DataSource = Me.productsBindingSource
			Me.radGridView1.MasterTemplate.EnableGrouping = False
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.Name = "radGridView1"
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = Color.Black
			Me.radGridView1.Size = New Size(1224, 737)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			Me.radGridView1.ThemeName = "Telerik"
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' radGroupLanguages
			' 
			Me.radGroupLanguages.Anchor = AnchorStyles.Top
			Me.radGroupLanguages.Controls.Add(Me.radRadioGerman)
			Me.radGroupLanguages.Controls.Add(Me.radRadioEnglish)
			Me.radGroupLanguages.FooterImageIndex = -1
			Me.radGroupLanguages.FooterImageKey = ""
			Me.radGroupLanguages.HeaderImageIndex = -1
			Me.radGroupLanguages.HeaderImageKey = ""
			Me.radGroupLanguages.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupLanguages.HeaderText = " Choose Language "
			Me.radGroupLanguages.Location = New Point(10, 6)
			Me.radGroupLanguages.Name = "radGroupLanguages"
			Me.radGroupLanguages.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupLanguages.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupLanguages.Size = New Size(180, 74)
			Me.radGroupLanguages.TabIndex = 0
			Me.radGroupLanguages.Text = " Choose Language "
			' 
			' radRadioGerman
			' 
			Me.radRadioGerman.Location = New Point(25, 46)
			Me.radRadioGerman.Name = "radRadioGerman"
			Me.radRadioGerman.Size = New Size(61, 16)
			Me.radRadioGerman.TabIndex = 0
			Me.radRadioGerman.Text = "German"

			' 
			' radRadioEnglish
			' 
			Me.radRadioEnglish.Location = New Point(25, 24)
			Me.radRadioEnglish.Name = "radRadioEnglish"
			Me.radRadioEnglish.Size = New Size(57, 16)
			Me.radRadioEnglish.TabIndex = 0
			Me.radRadioEnglish.Text = "English"

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
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupLanguages, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupLanguages.ResumeLayout(False)
			CType(Me.radRadioGerman, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioEnglish, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private productsBindingSource As BindingSource
		Private productsTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.ProductsTableAdapter
		Private radGroupLanguages As Telerik.WinControls.UI.RadGroupBox
		Private radRadioGerman As Telerik.WinControls.UI.RadRadioButton
		Private radRadioEnglish As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace
