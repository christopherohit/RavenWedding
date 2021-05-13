Namespace Telerik.Examples.WinControls.GridView.Events
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
            Dim tableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.nwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
            Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radButton1 = New Telerik.WinControls.UI.RadButton()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radListBoxEvents = New Telerik.WinControls.UI.RadListControl()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radListBoxEvents, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(0, 1)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel4)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel3)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radButton1)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radListBoxEvents)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel1)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(200, 611)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 611)
            Me.nwindDataSet.DataSetName = "NwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            Me.carsBindingSource.DataMember = "Cars"
            Me.carsBindingSource.DataSource = Me.nwindDataSet
            Me.carsTableAdapter.ClearBeforeFill = True
            Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel1.Location = New System.Drawing.Point(10, 78)
            Me.radLabel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(124, 18)
            Me.radLabel1.TabIndex = 2
            Me.radLabel1.Text = "Events fired by the grid:"
            Me.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radButton1.Location = New System.Drawing.Point(10, 32)
            Me.radButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.radButton1.Name = "radButton1"
            Me.radButton1.Size = New System.Drawing.Size(180, 23)
            Me.radButton1.TabIndex = 3
            Me.radButton1.Text = "Clear events list"
            Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel3.Location = New System.Drawing.Point(10, 446)
            Me.radLabel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(89, 18)
            Me.radLabel3.TabIndex = 5
            Me.radLabel3.Text = "CellMouseMove:"
            Me.radListBoxEvents.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radListBoxEvents.AutoScroll = True
            Me.radListBoxEvents.Location = New System.Drawing.Point(10, 102)
            Me.radListBoxEvents.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.radListBoxEvents.Name = "radListBoxEvents"
            Me.radListBoxEvents.Size = New System.Drawing.Size(180, 303)
            Me.radListBoxEvents.TabIndex = 1
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.EnableHotTracking = False
            Me.radGridView1.Location = New System.Drawing.Point(0, 50)
            Me.radGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AllowDragToGroup = False
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            Me.radGridView1.MasterTemplate.Caption = Nothing
            Me.radGridView1.MasterTemplate.EnableGrouping = False
            Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
            Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(2072, 1106)
            Me.radGridView1.TabIndex = 0
            Me.radPanel1.Controls.Add(Me.radLabel2)
            Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radPanel1.Location = New System.Drawing.Point(0, 0)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(2072, 50)
            Me.radPanel1.TabIndex = 1
            Me.radLabel2.Location = New System.Drawing.Point(3, 17)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(417, 18)
            Me.radLabel2.TabIndex = 0
            Me.radLabel2.Text = "Click on the grid to see the events which are displayed in the text box on the ri" & "ght."
            Me.radLabel4.Location = New System.Drawing.Point(10, 470)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(55, 18)
            Me.radLabel4.TabIndex = 6
            Me.radLabel4.Text = "radLabel4"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radGridView1)
            Me.Controls.Add(Me.radPanel1)
            Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2072, 1156)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radListBoxEvents, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            Me.radPanel1.PerformLayout()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private nwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
        Private carsBindingSource As System.Windows.Forms.BindingSource
        Private carsTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radButton1 As Telerik.WinControls.UI.RadButton
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radListBoxEvents As Telerik.WinControls.UI.RadListControl
        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
