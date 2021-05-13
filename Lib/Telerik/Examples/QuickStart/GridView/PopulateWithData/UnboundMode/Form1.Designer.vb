Namespace Telerik.Examples.WinControls.GridView.PopulateWithData.UnboundMode
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
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.radBtnRmRows = New Telerik.WinControls.UI.RadButton()
            Me.radBtnAddRow = New Telerik.WinControls.UI.RadButton()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radBtnRmCol = New Telerik.WinControls.UI.RadButton()
            Me.radComboBox1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radBtnAddCol = New Telerik.WinControls.UI.RadButton()
            Me.radCheckShowNewRow = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupCols = New Telerik.WinControls.UI.RadGroupBox()
            Me.radGroupAddCol = New Telerik.WinControls.UI.RadGroupBox()
            Me.radGroupRmCol = New Telerik.WinControls.UI.RadGroupBox()
            Me.radComboColumnsRemove = New Telerik.WinControls.UI.RadDropDownList()
            Me.radGroupRows = New Telerik.WinControls.UI.RadGroupBox()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBtnRmRows, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBtnAddRow, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBtnRmCol, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBtnAddCol, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckShowNewRow, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupCols, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupCols.SuspendLayout()
            CType(Me.radGroupAddCol, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupAddCol.SuspendLayout()
            CType(Me.radGroupRmCol, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupRmCol.SuspendLayout()
            CType(Me.radComboColumnsRemove, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupRows, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupRows.SuspendLayout()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.radGroupCols)
            Me.settingsPanel.Controls.Add(Me.radGroupRows)
            Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 818)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupRows, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupCols, 0)
            '
            'radGridView1
            '
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            '
            '
            '
            Me.radGridView1.MasterTemplate.AllowColumnChooser = False
            Me.radGridView1.MasterTemplate.AutoGenerateColumns = False
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            Me.radGridView1.MasterTemplate.Caption = Nothing
            Me.radGridView1.MasterTemplate.MultiSelect = True
            Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
            Me.radGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(2011, 1157)
            Me.radGridView1.TabIndex = 2
            '
            'radBtnRmRows
            '
            Me.radBtnRmRows.Location = New System.Drawing.Point(12, 58)
            Me.radBtnRmRows.Name = "radBtnRmRows"
            Me.radBtnRmRows.Size = New System.Drawing.Size(156, 23)
            Me.radBtnRmRows.TabIndex = 6
            Me.radBtnRmRows.Text = "Remove Selected Rows"
            '
            'radBtnAddRow
            '
            Me.radBtnAddRow.Location = New System.Drawing.Point(12, 29)
            Me.radBtnAddRow.Name = "radBtnAddRow"
            Me.radBtnAddRow.Size = New System.Drawing.Size(156, 23)
            Me.radBtnAddRow.TabIndex = 5
            Me.radBtnAddRow.Text = "Add Row"
            '
            'radLabel4
            '
            Me.radLabel4.Location = New System.Drawing.Point(15, 22)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(36, 18)
            Me.radLabel4.TabIndex = 3
            Me.radLabel4.Text = "Index:"
            '
            'radBtnRmCol
            '
            Me.radBtnRmCol.Location = New System.Drawing.Point(15, 48)
            Me.radBtnRmCol.Name = "radBtnRmCol"
            Me.radBtnRmCol.Size = New System.Drawing.Size(130, 23)
            Me.radBtnRmCol.TabIndex = 3
            Me.radBtnRmCol.Text = "Remove Column"
            '
            'radComboBox1
            '
            Me.radComboBox1.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
            Me.radComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radComboBox1.Location = New System.Drawing.Point(54, 19)
            Me.radComboBox1.Name = "radComboBox1"
            Me.radComboBox1.Size = New System.Drawing.Size(91, 20)
            Me.radComboBox1.TabIndex = 0
            '
            'radLabel2
            '
            Me.radLabel2.Location = New System.Drawing.Point(15, 22)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(33, 18)
            Me.radLabel2.TabIndex = 2
            Me.radLabel2.Text = "Type:"
            '
            'radBtnAddCol
            '
            Me.radBtnAddCol.Location = New System.Drawing.Point(15, 56)
            Me.radBtnAddCol.Name = "radBtnAddCol"
            Me.radBtnAddCol.Size = New System.Drawing.Size(130, 23)
            Me.radBtnAddCol.TabIndex = 1
            Me.radBtnAddCol.Text = "Add Column"
            '
            'radCheckShowNewRow
            '
            Me.radCheckShowNewRow.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckShowNewRow.Location = New System.Drawing.Point(12, 93)
            Me.radCheckShowNewRow.Name = "radCheckShowNewRow"
            Me.radCheckShowNewRow.Size = New System.Drawing.Size(130, 18)
            Me.radCheckShowNewRow.TabIndex = 7
            Me.radCheckShowNewRow.Text = "Show ""Add New Row"""
            Me.radCheckShowNewRow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radGroupCols
            '
            Me.radGroupCols.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupCols.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupCols.Controls.Add(Me.radGroupAddCol)
            Me.radGroupCols.Controls.Add(Me.radGroupRmCol)
            Me.radGroupCols.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.radGroupCols.HeaderText = "Columns"
            Me.radGroupCols.Location = New System.Drawing.Point(-5, 6)
            Me.radGroupCols.Name = "radGroupCols"
            Me.radGroupCols.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupCols.Size = New System.Drawing.Size(180, 222)
            Me.radGroupCols.TabIndex = 8
            Me.radGroupCols.Text = "Columns"
            '
            'radGroupAddCol
            '
            Me.radGroupAddCol.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupAddCol.Controls.Add(Me.radLabel2)
            Me.radGroupAddCol.Controls.Add(Me.radComboBox1)
            Me.radGroupAddCol.Controls.Add(Me.radBtnAddCol)
            Me.radGroupAddCol.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.radGroupAddCol.HeaderText = "Add"
            Me.radGroupAddCol.Location = New System.Drawing.Point(10, 119)
            Me.radGroupAddCol.Name = "radGroupAddCol"
            Me.radGroupAddCol.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupAddCol.Size = New System.Drawing.Size(161, 91)
            Me.radGroupAddCol.TabIndex = 8
            Me.radGroupAddCol.Text = "Add"
            '
            'radGroupRmCol
            '
            Me.radGroupRmCol.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupRmCol.Controls.Add(Me.radLabel4)
            Me.radGroupRmCol.Controls.Add(Me.radComboColumnsRemove)
            Me.radGroupRmCol.Controls.Add(Me.radBtnRmCol)
            Me.radGroupRmCol.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.radGroupRmCol.HeaderText = "Remove"
            Me.radGroupRmCol.Location = New System.Drawing.Point(10, 22)
            Me.radGroupRmCol.Name = "radGroupRmCol"
            Me.radGroupRmCol.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupRmCol.Size = New System.Drawing.Size(161, 91)
            Me.radGroupRmCol.TabIndex = 8
            Me.radGroupRmCol.Text = "Remove"
            '
            'radComboColumnsRemove
            '
            Me.radComboColumnsRemove.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
            Me.radComboColumnsRemove.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radComboColumnsRemove.Location = New System.Drawing.Point(56, 22)
            Me.radComboColumnsRemove.Name = "radComboColumnsRemove"
            Me.radComboColumnsRemove.Size = New System.Drawing.Size(91, 20)
            Me.radComboColumnsRemove.TabIndex = 0
            '
            'radGroupRows
            '
            Me.radGroupRows.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupRows.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupRows.Controls.Add(Me.radBtnAddRow)
            Me.radGroupRows.Controls.Add(Me.radBtnRmRows)
            Me.radGroupRows.Controls.Add(Me.radCheckShowNewRow)
            Me.radGroupRows.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.radGroupRows.HeaderText = "Rows"
            Me.radGroupRows.Location = New System.Drawing.Point(-5, 234)
            Me.radGroupRows.Name = "radGroupRows"
            Me.radGroupRows.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupRows.Size = New System.Drawing.Size(180, 128)
            Me.radGroupRows.TabIndex = 9
            Me.radGroupRows.Text = "Rows"
            '
            'Form1
            '
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBtnRmRows, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBtnAddRow, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBtnRmCol, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBtnAddCol, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckShowNewRow, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupCols, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupCols.ResumeLayout(False)
            CType(Me.radGroupAddCol, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupAddCol.ResumeLayout(False)
            Me.radGroupAddCol.PerformLayout()
            CType(Me.radGroupRmCol, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupRmCol.ResumeLayout(False)
            Me.radGroupRmCol.PerformLayout()
            CType(Me.radComboColumnsRemove, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupRows, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupRows.ResumeLayout(False)
            Me.radGroupRows.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radBtnRmCol As Telerik.WinControls.UI.RadButton
		Private radBtnAddCol As Telerik.WinControls.UI.RadButton
		Private radComboBox1 As Telerik.WinControls.UI.RadDropDownList
		Private radCheckShowNewRow As Telerik.WinControls.UI.RadCheckBox
		Private radBtnRmRows As Telerik.WinControls.UI.RadButton
		Private radBtnAddRow As Telerik.WinControls.UI.RadButton
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radGroupRows As Telerik.WinControls.UI.RadGroupBox
		Private radGroupCols As Telerik.WinControls.UI.RadGroupBox
		Private radGroupAddCol As Telerik.WinControls.UI.RadGroupBox
		Private radGroupRmCol As Telerik.WinControls.UI.RadGroupBox
		Private radComboColumnsRemove As Telerik.WinControls.UI.RadDropDownList
	End Class
End Namespace