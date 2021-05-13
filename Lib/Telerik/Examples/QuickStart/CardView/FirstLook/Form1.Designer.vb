Namespace Telerik.Examples.WinControls.CardView.FirstLook
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
			Me.radCardView1 = New Telerik.WinControls.UI.RadCardView()
			Me.cardViewItem1 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem10 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem17 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem14 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewGroupItem1 = New Telerik.WinControls.UI.CardViewGroupItem()
			Me.cardViewItem5 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem15 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem3 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem2 = New Telerik.WinControls.UI.CardViewItem()
			Me.layoutControlTabbedGroup1 = New Telerik.WinControls.UI.LayoutControlTabbedGroup()
			Me.cardViewGroupItem2 = New Telerik.WinControls.UI.CardViewGroupItem()
			Me.cardViewItem8 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem9 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem11 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem12 = New Telerik.WinControls.UI.CardViewItem()
			Me.layoutControlLabelItem1 = New Telerik.WinControls.UI.LayoutControlLabelItem()
			Me.cardViewGroupItem3 = New Telerik.WinControls.UI.CardViewGroupItem()
			Me.cardViewItem13 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem16 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem6 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewGroupItem4 = New Telerik.WinControls.UI.CardViewGroupItem()
			Me.cardViewItem4 = New Telerik.WinControls.UI.CardViewItem()
			Me.cardViewItem7 = New Telerik.WinControls.UI.CardViewItem()
			Me.layoutControlLabelItem2 = New Telerik.WinControls.UI.LayoutControlLabelItem()
			Me.employeesBindingSource = New BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCardView1.CardTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radCardView1.SuspendLayout()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1133, 29)
			' 
			' radCardView1
			' 
			Me.radCardView1.AllowEdit = False
			' 
			' radCardView1Template
			' 
			Me.radCardView1.CardTemplate.HiddenItems.AddRange(New Telerik.WinControls.RadItem() { Me.cardViewItem1, Me.cardViewItem10, Me.cardViewItem17, Me.cardViewItem14})
			Me.radCardView1.CardTemplate.Items.AddRange(New Telerik.WinControls.RadItem() { Me.cardViewGroupItem1})
			Me.radCardView1.CardTemplate.Location = New Point(0, 0)
			Me.radCardView1.CardTemplate.Name = "radCardView1Template"
			Me.radCardView1.CardTemplate.Size = New Size(500, 250)
			Me.radCardView1.CardTemplate.TabIndex = 0
			Me.radCardView1.DataSource = Me.employeesBindingSource
			Me.radCardView1.Dock = DockStyle.Fill
			Me.radCardView1.ItemSize = New Size(500, 250)
			Me.radCardView1.Location = New Point(0, 0)
			Me.radCardView1.Name = "radCardView1"
			Me.radCardView1.Size = New Size(1501, 907)
			Me.radCardView1.TabIndex = 2
			Me.radCardView1.Text = "radCardView1"
			CType(Me.radCardView1.GetChildAt(0), Telerik.WinControls.UI.RadCardViewElement).DrawBorder = False
			' 
			' cardViewItem1
			' 
			Me.cardViewItem1.Bounds = New Rectangle(0, 0, 175, 26)
			Me.cardViewItem1.FieldName = "EmployeeID"
			Me.cardViewItem1.Name = "cardViewItem1"
			Me.cardViewItem1.Text = "EmployeeID"
			' 
			' cardViewItem10
			' 
			Me.cardViewItem10.Bounds = New Rectangle(263, 0, 129, 322)
			Me.cardViewItem10.FieldName = "Region"
			Me.cardViewItem10.Name = "cardViewItem10"
			Me.cardViewItem10.Text = "Region"
			' 
			' cardViewItem17
			' 
			Me.cardViewItem17.Bounds = New Rectangle(0, 94, 191, 47)
			Me.cardViewItem17.FieldName = "ReportsTo"
			Me.cardViewItem17.Name = "cardViewItem17"
			Me.cardViewItem17.Text = "ReportsTo"
			Me.cardViewItem17.TextProportionalSize = 0.3F
			' 
			' cardViewItem14
			' 
			Me.cardViewItem14.Bounds = New Rectangle(0, 26, 265, 26)
			Me.cardViewItem14.FieldName = "Extension"
			Me.cardViewItem14.Name = "cardViewItem14"
			Me.cardViewItem14.Text = "Extension"
			Me.cardViewItem14.TextProportionalSize = 0.3F
			' 
			' cardViewGroupItem1
			' 
			Me.cardViewGroupItem1.Bounds = New Rectangle(0, 0, 500, 250)
			Me.cardViewGroupItem1.FieldName = "LastName"
			Me.cardViewGroupItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.cardViewItem5, Me.cardViewItem15, Me.cardViewItem3, Me.cardViewItem2, Me.layoutControlTabbedGroup1})
			Me.cardViewGroupItem1.Name = "cardViewGroupItem1"
			' 
			' cardViewItem5
			' 
			Me.cardViewItem5.Bounds = New Rectangle(198, 0, 26, 26)
			Me.cardViewItem5.FieldName = "TitleOfCourtesy"
			Me.cardViewItem5.MaxSize = New Size(26, 0)
			Me.cardViewItem5.MinSize = New Size(26, 26)
			Me.cardViewItem5.Name = "cardViewItem5"
			Me.cardViewItem5.Text = "TitleOfCourtesy"
			Me.cardViewItem5.TextProportionalSize = 0F
			' 
			' cardViewItem15
			' 
			Me.cardViewItem15.Bounds = New Rectangle(0, 0, 198, 222)
			Me.cardViewItem15.FieldName = "Photo"
			Me.cardViewItem15.Name = "cardViewItem15"
			Me.cardViewItem15.Text = "Photo"
			Me.cardViewItem15.TextProportionalSize = 0F
			' 
			' cardViewItem3
			' 
			Me.cardViewItem3.Bounds = New Rectangle(224, 0, 70, 26)
			Me.cardViewItem3.FieldName = "FirstName"
			Me.cardViewItem3.MaxSize = New Size(70, 0)
			Me.cardViewItem3.Name = "cardViewItem3"
			Me.cardViewItem3.Text = "FirstName"
			Me.cardViewItem3.TextProportionalSize = 0F
			' 
			' cardViewItem2
			' 
			Me.cardViewItem2.Bounds = New Rectangle(294, 0, 198, 26)
			Me.cardViewItem2.FieldName = "LastName"
			Me.cardViewItem2.Name = "cardViewItem2"
			Me.cardViewItem2.Text = "LastName"
			Me.cardViewItem2.TextProportionalSize = 0F
			' 
			' layoutControlTabbedGroup1
			' 
			Me.layoutControlTabbedGroup1.Bounds = New Rectangle(198, 26, 294, 196)
			Me.layoutControlTabbedGroup1.ItemGroups.AddRange(New Telerik.WinControls.RadItem() { Me.cardViewGroupItem2, Me.cardViewGroupItem3, Me.cardViewGroupItem4})
			Me.layoutControlTabbedGroup1.Name = "layoutControlTabbedGroup1"
			Me.layoutControlTabbedGroup1.SelectedGroup = Me.cardViewGroupItem2
			' 
			' cardViewGroupItem2
			' 
			Me.cardViewGroupItem2.Bounds = New Rectangle(0, 0, 286, 164)
			Me.cardViewGroupItem2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.cardViewItem8, Me.cardViewItem9, Me.cardViewItem11, Me.cardViewItem12, Me.layoutControlLabelItem1})
			Me.cardViewGroupItem2.Name = "cardViewGroupItem2"
			Me.cardViewGroupItem2.Text = "Address"
			' 
			' cardViewItem8
			' 
			Me.cardViewItem8.Bounds = New Rectangle(0, 0, 286, 26)
			Me.cardViewItem8.FieldName = "Address"
			Me.cardViewItem8.Name = "cardViewItem8"
			Me.cardViewItem8.Text = "Address"
			Me.cardViewItem8.TextProportionalSize = 0.3F
			Me.cardViewItem8.TextWrap = True
			' 
			' cardViewItem9
			' 
			Me.cardViewItem9.Bounds = New Rectangle(0, 26, 286, 26)
			Me.cardViewItem9.FieldName = "City"
			Me.cardViewItem9.Name = "cardViewItem9"
			Me.cardViewItem9.Text = "City"
			Me.cardViewItem9.TextProportionalSize = 0.3F
			' 
			' cardViewItem11
			' 
			Me.cardViewItem11.Bounds = New Rectangle(0, 52, 286, 26)
			Me.cardViewItem11.FieldName = "PostalCode"
			Me.cardViewItem11.Name = "cardViewItem11"
			Me.cardViewItem11.Text = "PostalCode"
			Me.cardViewItem11.TextProportionalSize = 0.3F
			' 
			' cardViewItem12
			' 
			Me.cardViewItem12.Bounds = New Rectangle(0, 78, 286, 26)
			Me.cardViewItem12.FieldName = "Country"
			Me.cardViewItem12.Name = "cardViewItem12"
			Me.cardViewItem12.Text = "Country"
			Me.cardViewItem12.TextProportionalSize = 0.3F
			' 
			' layoutControlLabelItem1
			' 
			Me.layoutControlLabelItem1.Bounds = New Rectangle(0, 104, 286, 60)
			Me.layoutControlLabelItem1.DrawText = False
			Me.layoutControlLabelItem1.Name = "layoutControlLabelItem1"
			' 
			' cardViewGroupItem3
			' 
			Me.cardViewGroupItem3.Bounds = New Rectangle(0, 0, 164, 172)
			Me.cardViewGroupItem3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.cardViewItem13, Me.cardViewItem16, Me.cardViewItem6})
			Me.cardViewGroupItem3.Name = "cardViewGroupItem3"
			Me.cardViewGroupItem3.Text = "Personal"
			' 
			' cardViewItem13
			' 
			Me.cardViewItem13.Bounds = New Rectangle(0, 0, 156, 26)
			Me.cardViewItem13.FieldName = "HomePhone"
			Me.cardViewItem13.Name = "cardViewItem13"
			Me.cardViewItem13.Text = "HomePhone"
			Me.cardViewItem13.TextProportionalSize = 0.3F
			' 
			' cardViewItem16
			' 
			Me.cardViewItem16.Bounds = New Rectangle(0, 52, 156, 112)
			Me.cardViewItem16.FieldName = "Notes"
			Me.cardViewItem16.Name = "cardViewItem16"
			Me.cardViewItem16.Text = "Notes"
			Me.cardViewItem16.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
			Me.cardViewItem16.TextProportionalSize = 0.2F
			Me.cardViewItem16.TextWrap = True
			' 
			' cardViewItem6
			' 
			Me.cardViewItem6.Bounds = New Rectangle(0, 26, 156, 26)
			Me.cardViewItem6.FieldName = "BirthDate"
			Me.cardViewItem6.Name = "cardViewItem6"
			Me.cardViewItem6.Text = "BirthDate"
			Me.cardViewItem6.TextProportionalSize = 0.3F
			' 
			' cardViewGroupItem4
			' 
			Me.cardViewGroupItem4.Bounds = New Rectangle(0, 0, 164, 172)
			Me.cardViewGroupItem4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.cardViewItem4, Me.cardViewItem7, Me.layoutControlLabelItem2})
			Me.cardViewGroupItem4.Name = "cardViewGroupItem4"
			Me.cardViewGroupItem4.Text = "Job"
			' 
			' cardViewItem4
			' 
			Me.cardViewItem4.Bounds = New Rectangle(0, 0, 156, 26)
			Me.cardViewItem4.FieldName = "Title"
			Me.cardViewItem4.Name = "cardViewItem4"
			Me.cardViewItem4.Text = "Title"
			Me.cardViewItem4.TextProportionalSize = 0.3F
			' 
			' cardViewItem7
			' 
			Me.cardViewItem7.Bounds = New Rectangle(0, 26, 156, 26)
			Me.cardViewItem7.FieldName = "HireDate"
			Me.cardViewItem7.Name = "cardViewItem7"
			Me.cardViewItem7.Text = "HireDate"
			Me.cardViewItem7.TextProportionalSize = 0.3F
			' 
			' layoutControlLabelItem2
			' 
			Me.layoutControlLabelItem2.Bounds = New Rectangle(0, 52, 156, 112)
			Me.layoutControlLabelItem2.DrawText = False
			Me.layoutControlLabelItem2.Name = "layoutControlLabelItem2"
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.None
			Me.Controls.Add(Me.radCardView1)
			Me.Name = "Form1"
			Me.Size = New Size(1511, 917)
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radCardView1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCardView1.CardTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCardView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radCardView1.ResumeLayout(False)
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCardView1 As Telerik.WinControls.UI.RadCardView
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesBindingSource As BindingSource
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
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
		Private cardViewItem17 As Telerik.WinControls.UI.CardViewItem
		Private layoutControlTabbedGroup1 As Telerik.WinControls.UI.LayoutControlTabbedGroup
		Private cardViewGroupItem2 As Telerik.WinControls.UI.CardViewGroupItem
		Private cardViewGroupItem3 As Telerik.WinControls.UI.CardViewGroupItem
		Private cardViewGroupItem4 As Telerik.WinControls.UI.CardViewGroupItem
		Private layoutControlLabelItem1 As Telerik.WinControls.UI.LayoutControlLabelItem
		Private layoutControlLabelItem2 As Telerik.WinControls.UI.LayoutControlLabelItem
	End Class
End Namespace