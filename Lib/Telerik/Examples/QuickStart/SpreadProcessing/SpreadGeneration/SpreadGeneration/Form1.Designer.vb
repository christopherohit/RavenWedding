Namespace Telerik.Examples.WinControls.DocumentsProcessing.SpreadGeneration
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim gridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim tableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.exportFormatDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.exportButton = New Telerik.WinControls.UI.RadButton()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.totalSumLabel = New Telerik.WinControls.UI.RadLabel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportFormatDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.totalSumLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(1778, 0)
            Me.radGridView1.AllowDrop = True
            Me.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.radGridView1.Location = New System.Drawing.Point(20, 20)
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AllowCellContextMenu = False
            Me.radGridView1.MasterTemplate.AllowColumnChooser = False
            Me.radGridView1.MasterTemplate.AllowColumnHeaderContextMenu = False
            Me.radGridView1.MasterTemplate.AllowColumnReorder = False
            Me.radGridView1.MasterTemplate.AllowDeleteRow = False
            Me.radGridView1.MasterTemplate.AllowDragToGroup = False
            Me.radGridView1.MasterTemplate.AllowEditRow = False
            Me.radGridView1.MasterTemplate.AllowRowReorder = True
            Me.radGridView1.MasterTemplate.AllowRowResize = False
            gridViewTextBoxColumn1.EnableExpressionEditor = False
            gridViewTextBoxColumn1.FieldName = "Name"
            gridViewTextBoxColumn1.HeaderText = "ITEM"
            gridViewTextBoxColumn1.Name = "ITEM"
            gridViewTextBoxColumn1.Width = 41
            gridViewTextBoxColumn2.EnableExpressionEditor = False
            gridViewTextBoxColumn2.FieldName = "Quantity"
            gridViewTextBoxColumn2.HeaderText = "QTY"
            gridViewTextBoxColumn2.Name = "QTY"
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            gridViewTextBoxColumn2.Width = 36
            gridViewTextBoxColumn3.EnableExpressionEditor = False
            gridViewTextBoxColumn3.FieldName = "UnitPrice"
            gridViewTextBoxColumn3.FormatString = "{0:C}"
            gridViewTextBoxColumn3.HeaderText = "PRICE"
            gridViewTextBoxColumn3.Name = "Price"
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            gridViewTextBoxColumn3.Width = 46
            gridViewTextBoxColumn4.EnableExpressionEditor = False
            gridViewTextBoxColumn4.FieldName = "SubTotal"
            gridViewTextBoxColumn4.FormatString = "{0:C}"
            gridViewTextBoxColumn4.HeaderText = "SUB TOTAL"
            gridViewTextBoxColumn4.Name = "Sub Total"
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            gridViewTextBoxColumn4.Width = 81
            Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4})
            Me.radGridView1.MasterTemplate.EnableGrouping = False
            Me.radGridView1.MasterTemplate.EnableSorting = False
            Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.[ReadOnly] = True
            Me.radGridView1.Size = New System.Drawing.Size(482, 350)
            Me.radGridView1.TabIndex = 0
            Me.radLabel1.Location = New System.Drawing.Point(20, 431)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(79, 18)
            Me.radLabel1.TabIndex = 1
            Me.radLabel1.Text = "Export Format:"
            Me.exportFormatDropDownList.DropDownAnimationEnabled = False
            Me.exportFormatDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.exportFormatDropDownList.Location = New System.Drawing.Point(134, 429)
            Me.exportFormatDropDownList.Name = "exportFormatDropDownList"
            Me.exportFormatDropDownList.Size = New System.Drawing.Size(93, 20)
            Me.exportFormatDropDownList.TabIndex = 2
            Me.exportFormatDropDownList.Text = "radDropDownList1"
            Me.exportButton.Location = New System.Drawing.Point(20, 480)
            Me.exportButton.Name = "exportButton"
            Me.exportButton.Size = New System.Drawing.Size(482, 24)
            Me.exportButton.TabIndex = 3
            Me.exportButton.Text = "Export"
            AddHandler Me.exportButton.Click, New System.EventHandler(AddressOf Me.exportButton_Click)
            Me.radLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel2.Location = New System.Drawing.Point(319, 389)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(45, 20)
            Me.radLabel2.TabIndex = 4
            Me.radLabel2.Text = "Total:"
            Me.totalSumLabel.AutoSize = False
            Me.totalSumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.totalSumLabel.Location = New System.Drawing.Point(384, 389)
            Me.totalSumLabel.Name = "totalSumLabel"
            Me.totalSumLabel.Size = New System.Drawing.Size(118, 18)
            Me.totalSumLabel.TabIndex = 5
            Me.totalSumLabel.Text = "$0"
            Me.totalSumLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.totalSumLabel)
            Me.Controls.Add(Me.radLabel2)
            Me.Controls.Add(Me.exportButton)
            Me.Controls.Add(Me.exportFormatDropDownList)
            Me.Controls.Add(Me.radLabel1)
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.radLabel1, 0)
            Me.Controls.SetChildIndex(Me.exportFormatDropDownList, 0)
            Me.Controls.SetChildIndex(Me.exportButton, 0)
            Me.Controls.SetChildIndex(Me.radLabel2, 0)
            Me.Controls.SetChildIndex(Me.totalSumLabel, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportFormatDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.totalSumLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private exportFormatDropDownList As Telerik.WinControls.UI.RadDropDownList
        Private exportButton As Telerik.WinControls.UI.RadButton
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private totalSumLabel As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
