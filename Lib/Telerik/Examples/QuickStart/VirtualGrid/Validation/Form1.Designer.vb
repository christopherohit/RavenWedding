Namespace Telerik.Examples.WinControls.VirtualGrid.Validation
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radVirtualGrid1 = New Telerik.WinControls.UI.RadVirtualGrid()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorSecondCondition = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radSpinEditorFirstCondition = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radDropDownListSecondCondition = New Telerik.WinControls.UI.RadDropDownList()
            Me.radDropDownListFirstCondition = New Telerik.WinControls.UI.RadDropDownList()
            Me.radDropDownListColumnName = New Telerik.WinControls.UI.RadDropDownList()
            Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.radVirtualGrid1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditorSecondCondition), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditorFirstCondition), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radDropDownListSecondCondition), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radDropDownListFirstCondition), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radDropDownListColumnName), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(0, 0)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(230, 321)
            Me.settingsPanel.Size = New System.Drawing.Size(230, 321)
            Me.radVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radVirtualGrid1.Location = New System.Drawing.Point(0, 0)
            Me.radVirtualGrid1.MasterViewInfo.RowCount = 1000
            Me.radVirtualGrid1.Name = "radVirtualGrid1"
            Me.radVirtualGrid1.Size = New System.Drawing.Size(1473, 786)
            Me.radVirtualGrid1.TabIndex = 0
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.tableLayoutPanel1)
            Me.radGroupBox1.HeaderText = "Column restrictions:"
            Me.radGroupBox1.Location = New System.Drawing.Point(5, 33)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(220, 256)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Column restrictions:"
            Me.radGroupBox1.UseMnemonic = False
            Me.radLabel1.Location = New System.Drawing.Point(3, 111)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(24, 18)
            Me.radLabel1.TabIndex = 2
            Me.radLabel1.Text = "and"
            Me.radSpinEditorSecondCondition.Location = New System.Drawing.Point(3, 183)
            Me.radSpinEditorSecondCondition.Name = "radSpinEditorSecondCondition"
            Me.radSpinEditorSecondCondition.Size = New System.Drawing.Size(180, 20)
            Me.radSpinEditorSecondCondition.TabIndex = 1
            Me.radSpinEditorSecondCondition.TabStop = False
            Me.radSpinEditorFirstCondition.Location = New System.Drawing.Point(3, 75)
            Me.radSpinEditorFirstCondition.Name = "radSpinEditorFirstCondition"
            Me.radSpinEditorFirstCondition.Size = New System.Drawing.Size(180, 20)
            Me.radSpinEditorFirstCondition.TabIndex = 1
            Me.radSpinEditorFirstCondition.TabStop = False
            Me.radDropDownListSecondCondition.DropDownAnimationEnabled = False
            Me.radDropDownListSecondCondition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListSecondCondition.Location = New System.Drawing.Point(3, 144)
            Me.radDropDownListSecondCondition.Name = "radDropDownListSecondCondition"
            Me.radDropDownListSecondCondition.Size = New System.Drawing.Size(180, 20)
            Me.radDropDownListSecondCondition.TabIndex = 0
            Me.radDropDownListFirstCondition.DropDownAnimationEnabled = False
            Me.radDropDownListFirstCondition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListFirstCondition.Location = New System.Drawing.Point(3, 39)
            Me.radDropDownListFirstCondition.Name = "radDropDownListFirstCondition"
            Me.radDropDownListFirstCondition.Size = New System.Drawing.Size(180, 20)
            Me.radDropDownListFirstCondition.TabIndex = 0
            Me.radDropDownListColumnName.DropDownAnimationEnabled = False
            Me.radDropDownListColumnName.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListColumnName.Location = New System.Drawing.Point(3, 3)
            Me.radDropDownListColumnName.Name = "radDropDownListColumnName"
            Me.radDropDownListColumnName.Size = New System.Drawing.Size(180, 20)
            Me.radDropDownListColumnName.TabIndex = 0
            Me.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.tableLayoutPanel1.ColumnCount = 1
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.radDropDownListColumnName, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radSpinEditorSecondCondition, 0, 5)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.radDropDownListSecondCondition, 0, 4)
            Me.tableLayoutPanel1.Controls.Add(Me.radDropDownListFirstCondition, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radSpinEditorFirstCondition, 0, 2)
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(5, 21)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 6
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.20737F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.97235F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(210, 217)
            Me.tableLayoutPanel1.TabIndex = 3
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radVirtualGrid1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1483, 796)
            Me.Controls.SetChildIndex(Me.radVirtualGrid1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.radVirtualGrid1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditorSecondCondition), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditorFirstCondition), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radDropDownListSecondCondition), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radDropDownListFirstCondition), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radDropDownListColumnName), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

        Private WithEvents radVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radSpinEditorSecondCondition As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditorFirstCondition As Telerik.WinControls.UI.RadSpinEditor
        Private radDropDownListSecondCondition As Telerik.WinControls.UI.RadDropDownList
        Private radDropDownListFirstCondition As Telerik.WinControls.UI.RadDropDownList
        Private radDropDownListColumnName As Telerik.WinControls.UI.RadDropDownList
        Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    End Class
End Namespace
