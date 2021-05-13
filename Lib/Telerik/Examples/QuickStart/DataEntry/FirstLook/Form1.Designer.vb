Namespace Telerik.Examples.WinControls.DataEntry.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.radDataEntry1 = New Telerik.WinControls.UI.RadDataEntry()
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
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.furnitureDataSet = New Telerik.Examples.WinControls.DataSources.FurnitureDataSet()
            Me.productsTableAdapter = New Telerik.Examples.WinControls.DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            CType(Me.radDataEntry1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radDataEntry1.SuspendLayout()
            CType(Me.radBindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.furnitureDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(622, 3)
            Me.radPanel1.Controls.Add(Me.radDataEntry1)
            Me.radPanel1.Controls.Add(Me.radBindingNavigator1)
            Me.radPanel1.Location = New System.Drawing.Point(0, 0)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(620, 471)
            Me.radPanel1.TabIndex = 2
            Me.radDataEntry1.ColumnCount = 2
            Me.radDataEntry1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radDataEntry1.FitToParentWidth = True
            Me.radDataEntry1.ItemDefaultSize = New System.Drawing.Size(300, 24)
            Me.radDataEntry1.ItemSpace = 8
            Me.radDataEntry1.Location = New System.Drawing.Point(0, 30)
            Me.radDataEntry1.Name = "radDataEntry1"
            Me.radDataEntry1.PanelContainer.Size = New System.Drawing.Size(618, 439)
            Me.radDataEntry1.Size = New System.Drawing.Size(620, 441)
            Me.radDataEntry1.TabIndex = 1
            Me.radBindingNavigator1.AutoHandleAddNew = False
            Me.radBindingNavigator1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radBindingNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.radBindingNavigator1.Name = "radBindingNavigator1"
            Me.radBindingNavigator1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.radBindingNavigator1RowElement})
            Me.radBindingNavigator1.Size = New System.Drawing.Size(620, 30)
            Me.radBindingNavigator1.TabIndex = 2
            Me.radBindingNavigator1RowElement.MinSize = New System.Drawing.Size(25, 25)
            Me.radBindingNavigator1RowElement.Name = "radBindingNavigator1RowElement"
            Me.radBindingNavigator1RowElement.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.radBindingNavigator1FirstStrip, Me.radBindingNavigator1SecondStrip})
            Me.radBindingNavigator1FirstStrip.DisplayName = "radBindingNavigator1FirstStrip"
            Me.radBindingNavigator1FirstStrip.EnableDragging = False
            Me.radBindingNavigator1FirstStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.radBindingNavigator1FirstStrip.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.radBindingNavigator1MoveFirstItem, Me.commandBarSeparator1, Me.radBindingNavigator1MovePreviousItem, Me.commandBarSeparator2, Me.radBindingNavigator1PositionItem, Me.radBindingNavigator1CountItem, Me.commandBarSeparator3, Me.radBindingNavigator1MoveNextItem, Me.commandBarSeparator4, Me.radBindingNavigator1MoveLastItem})
            Me.radBindingNavigator1FirstStrip.MinSize = New System.Drawing.Size(0, 0)
            Me.radBindingNavigator1FirstStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radBindingNavigator1FirstStrip.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radBindingNavigator1FirstStrip.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.radBindingNavigator1MoveFirstItem.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
            Me.radBindingNavigator1MoveFirstItem.Name = "radBindingNavigator1MoveFirstItem"
            Me.commandBarSeparator1.Name = "commandBarSeparator1"
            Me.commandBarSeparator1.VisibleInOverflowMenu = False
            Me.radBindingNavigator1MovePreviousItem.Name = "radBindingNavigator1MovePreviousItem"
            Me.commandBarSeparator2.Name = "commandBarSeparator2"
            Me.commandBarSeparator2.VisibleInOverflowMenu = False
            Me.radBindingNavigator1PositionItem.Name = "radBindingNavigator1PositionItem"
            Me.radBindingNavigator1CountItem.Name = "radBindingNavigator1CountItem"
            Me.radBindingNavigator1CountItem.Text = "of {0}"
            Me.commandBarSeparator3.Name = "commandBarSeparator3"
            Me.commandBarSeparator3.VisibleInOverflowMenu = False
            Me.radBindingNavigator1MoveNextItem.Name = "radBindingNavigator1MoveNextItem"
            Me.commandBarSeparator4.Name = "commandBarSeparator4"
            Me.commandBarSeparator4.VisibleInOverflowMenu = False
            Me.radBindingNavigator1MoveLastItem.Name = "radBindingNavigator1MoveLastItem"
            Me.radBindingNavigator1SecondStrip.DisplayName = "radBindingNavigator1SecondStrip"
            Me.radBindingNavigator1SecondStrip.EnableDragging = False
            Me.radBindingNavigator1SecondStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.radBindingNavigator1SecondStrip.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.radBindingNavigator1AddNewItem, Me.commandBarSeparator5, Me.radBindingNavigator1DeleteItem})
            Me.radBindingNavigator1SecondStrip.MinSize = New System.Drawing.Size(0, 0)
            Me.radBindingNavigator1SecondStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radBindingNavigator1SecondStrip.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radBindingNavigator1SecondStrip.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.radBindingNavigator1AddNewItem.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
            Me.radBindingNavigator1AddNewItem.Name = "radBindingNavigator1AddNewItem"
            Me.commandBarSeparator5.Name = "commandBarSeparator5"
            Me.commandBarSeparator5.VisibleInOverflowMenu = False
            Me.radBindingNavigator1DeleteItem.Name = "radBindingNavigator1DeleteItem"
            Me.bindingSource1.AllowNew = False
            Me.bindingSource1.DataMember = "Products"
            Me.bindingSource1.DataSource = Me.furnitureDataSet
            Me.furnitureDataSet.DataSetName = "FurnitureDataSet"
            Me.furnitureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            Me.productsTableAdapter.ClearBeforeFill = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            Me.radPanel1.PerformLayout()
            CType(Me.radDataEntry1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radDataEntry1.ResumeLayout(False)
            CType(Me.radBindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.furnitureDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private radDataEntry1 As Telerik.WinControls.UI.RadDataEntry
        Private bindingSource1 As System.Windows.Forms.BindingSource
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
    End Class
End Namespace
