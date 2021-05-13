Namespace Telerik.Examples.WinControls.DataLayout.FirstLook
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
            Me.bindingSource1 = New BindingSource(Me.components)
            Me.furnitureDataSet = New Telerik.Examples.WinControls.DataSources.FurnitureDataSet()
            Me.productsTableAdapter = New Telerik.Examples.WinControls.DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter()
            Me.radBindingNavigator1 = New Telerik.WinControls.UI.RadBindingNavigator()
            Me.radBindingNavigator1RowElement = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.radBindingNavigator1FirstStrip = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.radBindingNavigator1MoveFirstItem = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.radBindingNavigator1MovePreviousItem = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.radBindingNavigator1PositionItem = New Telerik.WinControls.UI.CommandBarTextBox()
            Me.radBindingNavigator1CountItem = New Telerik.WinControls.UI.CommandBarLabel()
            Me.commandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.radBindingNavigator1MoveNextItem = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.radBindingNavigator1MoveLastItem = New Telerik.WinControls.UI.CommandBarButton()
            Me.radBindingNavigator1SecondStrip = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.radBindingNavigator1AddNewItem = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.radBindingNavigator1DeleteItem = New Telerik.WinControls.UI.CommandBarButton()
            Me.radDataLayout1 = New Telerik.WinControls.UI.RadDataLayout()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.radButtonCustomize = New Telerik.WinControls.UI.RadButton()
            Me.radButtonSaveLayout = New Telerik.WinControls.UI.RadButton()
            Me.radButtonLoadLayout = New Telerik.WinControls.UI.RadButton()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.furnitureDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDataLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDataLayout1.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radDataLayout1.SuspendLayout()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            CType(Me.radButtonCustomize, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonSaveLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonLoadLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Location = New Point(755, 107)
            Me.settingsPanel.Size = New Size(230, 253)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataMember = "Products"
            Me.bindingSource1.DataSource = Me.furnitureDataSet
            ' 
            ' furnitureDataSet
            ' 
            Me.furnitureDataSet.DataSetName = "FurnitureDataSet"
            Me.furnitureDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            ' 
            ' productsTableAdapter
            ' 
            Me.productsTableAdapter.ClearBeforeFill = True
            ' 
            ' radBindingNavigator1
            ' 
            Me.radBindingNavigator1.BindingSource = Me.bindingSource1
            Me.radBindingNavigator1.Dock = DockStyle.Top
            Me.radBindingNavigator1.Location = New Point(0, 0)
            Me.radBindingNavigator1.Name = "radBindingNavigator1"
            Me.radBindingNavigator1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.radBindingNavigator1RowElement})
            Me.radBindingNavigator1.Size = New Size(629, 30)
            Me.radBindingNavigator1.TabIndex = 1
            Me.radBindingNavigator1.Text = "radBindingNavigator1"
            ' 
            ' radBindingNavigator1RowElement
            ' 
            Me.radBindingNavigator1RowElement.MinSize = New Size(25, 25)
            Me.radBindingNavigator1RowElement.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.radBindingNavigator1FirstStrip, Me.radBindingNavigator1SecondStrip})
            ' 
            ' radBindingNavigator1FirstStrip
            ' 
            Me.radBindingNavigator1FirstStrip.DisplayName = "radBindingNavigator1FirstStrip"
            Me.radBindingNavigator1FirstStrip.EnableDragging = False
            ' 
            ' 
            ' 
            Me.radBindingNavigator1FirstStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.radBindingNavigator1FirstStrip.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.radBindingNavigator1MoveFirstItem, Me.commandBarSeparator1, Me.radBindingNavigator1MovePreviousItem, Me.commandBarSeparator2, Me.radBindingNavigator1PositionItem, Me.radBindingNavigator1CountItem, Me.commandBarSeparator3, Me.radBindingNavigator1MoveNextItem, Me.commandBarSeparator4, Me.radBindingNavigator1MoveLastItem})
            Me.radBindingNavigator1FirstStrip.MinSize = New Size(0, 0)
            ' 
            ' 
            ' 
            Me.radBindingNavigator1FirstStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radBindingNavigator1FirstStrip.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radBindingNavigator1FirstStrip.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            ' 
            ' radBindingNavigator1MoveFirstItem
            ' 
            Me.radBindingNavigator1MoveFirstItem.Image = (CType(resources.GetObject("radBindingNavigator1MoveFirstItem.Image"), Image))
            Me.radBindingNavigator1MoveFirstItem.Margin = New Padding(3, 0, 0, 0)
            Me.radBindingNavigator1MoveFirstItem.Name = "radBindingNavigator1MoveFirstItem"
            ' 
            ' commandBarSeparator1
            ' 
            Me.commandBarSeparator1.Name = "commandBarSeparator1"
            Me.commandBarSeparator1.VisibleInOverflowMenu = False
            ' 
            ' radBindingNavigator1MovePreviousItem
            ' 
            Me.radBindingNavigator1MovePreviousItem.Image = (CType(resources.GetObject("radBindingNavigator1MovePreviousItem.Image"), Image))
            Me.radBindingNavigator1MovePreviousItem.Name = "radBindingNavigator1MovePreviousItem"
            ' 
            ' commandBarSeparator2
            ' 
            Me.commandBarSeparator2.Name = "commandBarSeparator2"
            Me.commandBarSeparator2.VisibleInOverflowMenu = False
            ' 
            ' radBindingNavigator1PositionItem
            ' 
            Me.radBindingNavigator1PositionItem.Name = "radBindingNavigator1PositionItem"
            Me.radBindingNavigator1PositionItem.Text = "0"
            ' 
            ' radBindingNavigator1CountItem
            ' 
            Me.radBindingNavigator1CountItem.Name = "radBindingNavigator1CountItem"
            Me.radBindingNavigator1CountItem.Text = "of 0"
            ' 
            ' commandBarSeparator3
            ' 
            Me.commandBarSeparator3.Name = "commandBarSeparator3"
            Me.commandBarSeparator3.VisibleInOverflowMenu = False
            ' 
            ' radBindingNavigator1MoveNextItem
            ' 
            Me.radBindingNavigator1MoveNextItem.Image = (CType(resources.GetObject("radBindingNavigator1MoveNextItem.Image"), Image))
            Me.radBindingNavigator1MoveNextItem.Name = "radBindingNavigator1MoveNextItem"
            ' 
            ' commandBarSeparator4
            ' 
            Me.commandBarSeparator4.Name = "commandBarSeparator4"
            Me.commandBarSeparator4.VisibleInOverflowMenu = False
            ' 
            ' radBindingNavigator1MoveLastItem
            ' 
            Me.radBindingNavigator1MoveLastItem.Image = (CType(resources.GetObject("radBindingNavigator1MoveLastItem.Image"), Image))
            Me.radBindingNavigator1MoveLastItem.Name = "radBindingNavigator1MoveLastItem"
            ' 
            ' radBindingNavigator1SecondStrip
            ' 
            Me.radBindingNavigator1SecondStrip.DisplayName = "radBindingNavigator1SecondStrip"
            Me.radBindingNavigator1SecondStrip.EnableDragging = False
            ' 
            ' 
            ' 
            Me.radBindingNavigator1SecondStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.radBindingNavigator1SecondStrip.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.radBindingNavigator1AddNewItem, Me.commandBarSeparator5, Me.radBindingNavigator1DeleteItem})
            Me.radBindingNavigator1SecondStrip.MinSize = New Size(0, 0)
            ' 
            ' 
            ' 
            Me.radBindingNavigator1SecondStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radBindingNavigator1SecondStrip.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radBindingNavigator1SecondStrip.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            ' 
            ' radBindingNavigator1AddNewItem
            ' 
            Me.radBindingNavigator1AddNewItem.Image = (CType(resources.GetObject("radBindingNavigator1AddNewItem.Image"), Image))
            Me.radBindingNavigator1AddNewItem.Margin = New Padding(3, 0, 0, 0)
            Me.radBindingNavigator1AddNewItem.Name = "radBindingNavigator1AddNewItem"
            ' 
            ' commandBarSeparator5
            ' 
            Me.commandBarSeparator5.Name = "commandBarSeparator5"
            Me.commandBarSeparator5.VisibleInOverflowMenu = False
            ' 
            ' radBindingNavigator1DeleteItem
            ' 
            Me.radBindingNavigator1DeleteItem.Image = (CType(resources.GetObject("radBindingNavigator1DeleteItem.Image"), Image))
            Me.radBindingNavigator1DeleteItem.Name = "radBindingNavigator1DeleteItem"
            ' 
            ' radDataLayout1
            ' 
            Me.radDataLayout1.ColumnCount = 2
            Me.radDataLayout1.Dock = DockStyle.Fill
            Me.radDataLayout1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.radDataLayout1.ItemDefaultHeight = 26
            ' 
            ' radDataLayout1.LayoutControl
            ' 
            Me.radDataLayout1.LayoutControl.Dock = DockStyle.Fill
            Me.radDataLayout1.LayoutControl.DrawBorder = False
            Me.radDataLayout1.LayoutControl.Location = New Point(0, 0)
            Me.radDataLayout1.LayoutControl.Name = "LayoutControl"
            Me.radDataLayout1.LayoutControl.Size = New Size(627, 470)
            Me.radDataLayout1.LayoutControl.TabIndex = 0
            Me.radDataLayout1.Location = New Point(0, 30)
            Me.radDataLayout1.Name = "radDataLayout1"
            Me.radDataLayout1.Size = New Size(629, 472)
            Me.radDataLayout1.TabIndex = 2
            Me.radDataLayout1.Text = "radDataLayout1"
            ' 
            ' radPanel1
            ' 
            Me.radPanel1.Controls.Add(Me.radDataLayout1)
            Me.radPanel1.Controls.Add(Me.radBindingNavigator1)
            Me.radPanel1.Location = New Point(2, 2)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New Size(629, 502)
            Me.radPanel1.TabIndex = 3
            Me.radPanel1.Text = "radPanel1"
            ' 
            ' radButtonCustomize
            ' 
            Me.radButtonCustomize.Anchor = AnchorStyles.Top
            Me.radButtonCustomize.Location = New Point(5, 30)
            Me.radButtonCustomize.Name = "radButtonCustomize"
            Me.radButtonCustomize.Size = New Size(200, 24)
            Me.radButtonCustomize.TabIndex = 1
            Me.radButtonCustomize.Text = "Customize ..."
            '			Me.radButtonCustomize.Click += New System.EventHandler(Me.radButtonCustomize_Click)
            ' 
            ' radButtonSaveLayout
            ' 
            Me.radButtonSaveLayout.Anchor = AnchorStyles.Top
            Me.radButtonSaveLayout.Location = New Point(5, 60)
            Me.radButtonSaveLayout.Name = "radButtonSaveLayout"
            Me.radButtonSaveLayout.Size = New Size(200, 24)
            Me.radButtonSaveLayout.TabIndex = 2
            Me.radButtonSaveLayout.Text = "Save Layout"
            '			Me.radButtonSaveLayout.Click += New System.EventHandler(Me.radButtonSaveLayout_Click)
            ' 
            ' radButtonLoadLayout
            ' 
            Me.radButtonLoadLayout.Anchor = AnchorStyles.Top
            Me.radButtonLoadLayout.Location = New Point(5, 90)
            Me.radButtonLoadLayout.Name = "radButtonLoadLayout"
            Me.radButtonLoadLayout.Size = New Size(200, 24)
            Me.radButtonLoadLayout.TabIndex = 3
            Me.radButtonLoadLayout.Text = "Load Layout"
            '			Me.radButtonLoadLayout.Click += New System.EventHandler(Me.radButtonLoadLayout_Click)
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.radButtonLoadLayout)
            Me.radGroupBox1.Controls.Add(Me.radButtonCustomize)
            Me.radGroupBox1.Controls.Add(Me.radButtonSaveLayout)
            Me.radGroupBox1.HeaderText = "DataLayout Actions"
            Me.radGroupBox1.Location = New Point(10, 32)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New Size(210, 130)
            Me.radGroupBox1.TabIndex = 4
            Me.radGroupBox1.Text = "DataLayout Actions"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.radPanel1)
            Me.Name = "Form1"
            Me.Size = New Size(1483, 917)
            '			Me.Load += New System.EventHandler(Me.Form1_Load)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.furnitureDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDataLayout1.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDataLayout1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radDataLayout1.ResumeLayout(False)
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            Me.radPanel1.PerformLayout()
            CType(Me.radButtonCustomize, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonSaveLayout, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonLoadLayout, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private bindingSource1 As BindingSource
        Private furnitureDataSet As DataSources.FurnitureDataSet
        Private productsTableAdapter As DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter
        Private radBindingNavigator1 As Telerik.WinControls.UI.RadBindingNavigator
        Private radBindingNavigator1RowElement As Telerik.WinControls.UI.CommandBarRowElement
        Private radBindingNavigator1FirstStrip As Telerik.WinControls.UI.CommandBarStripElement
        Private radBindingNavigator1MoveFirstItem As Telerik.WinControls.UI.CommandBarButton
        Private commandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
        Private radBindingNavigator1MovePreviousItem As Telerik.WinControls.UI.CommandBarButton
        Private commandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
        Private radBindingNavigator1PositionItem As Telerik.WinControls.UI.CommandBarTextBox
        Private radBindingNavigator1CountItem As Telerik.WinControls.UI.CommandBarLabel
        Private commandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
        Private radBindingNavigator1MoveNextItem As Telerik.WinControls.UI.CommandBarButton
        Private commandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
        Private radBindingNavigator1MoveLastItem As Telerik.WinControls.UI.CommandBarButton
        Private radBindingNavigator1SecondStrip As Telerik.WinControls.UI.CommandBarStripElement
        Private radBindingNavigator1AddNewItem As Telerik.WinControls.UI.CommandBarButton
        Private commandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
        Private radBindingNavigator1DeleteItem As Telerik.WinControls.UI.CommandBarButton
        Private radDataLayout1 As Telerik.WinControls.UI.RadDataLayout
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private WithEvents radButtonLoadLayout As Telerik.WinControls.UI.RadButton
        Private WithEvents radButtonCustomize As Telerik.WinControls.UI.RadButton
        Private WithEvents radButtonSaveLayout As Telerik.WinControls.UI.RadButton
    End Class
End Namespace