Namespace Telerik.Examples.WinControls.WordsProcessing.WordGridIntegration
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim tableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.headerRowColorBox = New Telerik.WinControls.UI.RadColorBox()
            Me.groupHeaderColorBox = New Telerik.WinControls.UI.RadColorBox()
            Me.dataRowColorBox = New Telerik.WinControls.UI.RadColorBox()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.exportButton = New Telerik.WinControls.UI.RadButton()
            Me.exportFormatDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.headerRowColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupHeaderColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataRowColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportFormatDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(1778, 0)
            Me.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.radGridView1.Location = New System.Drawing.Point(20, 20)
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AllowColumnChooser = False
            Me.radGridView1.MasterTemplate.AllowColumnReorder = False
            Me.radGridView1.MasterTemplate.AllowDeleteRow = False
            Me.radGridView1.MasterTemplate.AllowDragToGroup = False
            Me.radGridView1.MasterTemplate.AllowEditRow = False
            Me.radGridView1.MasterTemplate.AllowRowResize = False
            Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
            Me.radGridView1.MasterTemplate.ShowRowHeaderColumn = False
            Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(661, 361)
            Me.radGridView1.TabIndex = 0
            Me.headerRowColorBox.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.headerRowColorBox.Location = New System.Drawing.Point(207, 47)
            Me.headerRowColorBox.Name = "headerRowColorBox"
            Me.headerRowColorBox.Size = New System.Drawing.Size(199, 20)
            Me.headerRowColorBox.TabIndex = 1
            Me.groupHeaderColorBox.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.groupHeaderColorBox.Location = New System.Drawing.Point(207, 85)
            Me.groupHeaderColorBox.Name = "groupHeaderColorBox"
            Me.groupHeaderColorBox.Size = New System.Drawing.Size(199, 20)
            Me.groupHeaderColorBox.TabIndex = 2
            Me.dataRowColorBox.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.dataRowColorBox.Location = New System.Drawing.Point(207, 123)
            Me.dataRowColorBox.Name = "dataRowColorBox"
            Me.dataRowColorBox.Size = New System.Drawing.Size(199, 20)
            Me.dataRowColorBox.TabIndex = 3
            Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabel1.Location = New System.Drawing.Point(3, 48)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(106, 18)
            Me.radLabel1.TabIndex = 4
            Me.radLabel1.Text = "Header background"
            Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabel2.Location = New System.Drawing.Point(3, 86)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(138, 18)
            Me.radLabel2.TabIndex = 5
            Me.radLabel2.Text = "Group header background"
            Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabel3.Location = New System.Drawing.Point(3, 124)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(91, 18)
            Me.radLabel3.TabIndex = 6
            Me.radLabel3.Text = "Row background"
            Me.exportButton.Location = New System.Drawing.Point(20, 598)
            Me.exportButton.Name = "exportButton"
            Me.exportButton.Size = New System.Drawing.Size(661, 24)
            Me.exportButton.TabIndex = 7
            Me.exportButton.Text = "Export"
            AddHandler Me.exportButton.Click, New System.EventHandler(AddressOf Me.exportButton_Click)
            Me.exportFormatDropDownList.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.exportFormatDropDownList.DropDownAnimationEnabled = False
            Me.exportFormatDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.exportFormatDropDownList.Location = New System.Drawing.Point(207, 9)
            Me.exportFormatDropDownList.Name = "exportFormatDropDownList"
            Me.exportFormatDropDownList.Size = New System.Drawing.Size(199, 20)
            Me.exportFormatDropDownList.TabIndex = 8
            Me.exportFormatDropDownList.Text = "radDropDownList1"
            AddHandler Me.exportFormatDropDownList.SelectedIndexChanged, New Telerik.WinControls.UI.Data.PositionChangedEventHandler(AddressOf Me.exportFormatDropDownList_SelectedIndexChanged)
            Me.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabel4.Location = New System.Drawing.Point(3, 10)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(77, 18)
            Me.radLabel4.TabIndex = 9
            Me.radLabel4.Text = "Export Format"
            Me.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBox1.Location = New System.Drawing.Point(3, 163)
            Me.radCheckBox1.Name = "radCheckBox1"
            Me.radCheckBox1.Size = New System.Drawing.Size(189, 18)
            Me.radCheckBox1.TabIndex = 10
            Me.radCheckBox1.Text = "Repeat header row on every page"
            Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBox1.CheckStateChanged, New System.EventHandler(AddressOf Me.radCheckBox1_CheckStateChanged)
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 2
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.exportFormatDropDownList, 1, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBox1, 0, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel4, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.dataRowColorBox, 1, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.headerRowColorBox, 1, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.groupHeaderColorBox, 1, 2)
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(40, 392)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 5
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(409, 193)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 11
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.Controls.Add(Me.exportButton)
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.exportButton, 0)
            Me.Controls.SetChildIndex(Me.doubleBufferedTableLayoutPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.headerRowColorBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupHeaderColorBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataRowColorBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportFormatDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private headerRowColorBox As Telerik.WinControls.UI.RadColorBox
        Private groupHeaderColorBox As Telerik.WinControls.UI.RadColorBox
        Private dataRowColorBox As Telerik.WinControls.UI.RadColorBox
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private exportButton As Telerik.WinControls.UI.RadButton
        Private exportFormatDropDownList As Telerik.WinControls.UI.RadDropDownList
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    End Class
End Namespace
