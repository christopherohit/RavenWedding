Namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
    Partial Class FilePathUserControl
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radBrowseEditor1 = New Telerik.WinControls.UI.RadBrowseEditor()
            Me.deleteBtn = New Telerik.WinControls.UI.RadButton()
            Me.radSeparator1 = New Telerik.WinControls.UI.RadSeparator()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.labelHolderPanel = New System.Windows.Forms.Panel()
            Me.fileLabel = New Telerik.WinControls.UI.RadLabel()
            Me.tableLayoutPanel1.SuspendLayout()
            CType((Me.radBrowseEditor1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.deleteBtn), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSeparator1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.labelHolderPanel.SuspendLayout()
            CType((Me.fileLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.tableLayoutPanel1.ColumnCount = 4
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.83422F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.33155F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.83422F))
            Me.tableLayoutPanel1.Controls.Add(Me.radBrowseEditor1, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.deleteBtn, 2, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radSeparator1, 1, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.panel2, 1, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.labelHolderPanel, 1, 1)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 4
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(490, 56)
            Me.tableLayoutPanel1.TabIndex = 0
            Me.radBrowseEditor1.AutoSize = False
            Me.radBrowseEditor1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radBrowseEditor1.Location = New System.Drawing.Point(61, 3)
            Me.radBrowseEditor1.Name = "radBrowseEditor1"
            Me.radBrowseEditor1.Size = New System.Drawing.Size(335, 24)
            Me.radBrowseEditor1.TabIndex = 0
            Me.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill
            Me.deleteBtn.Location = New System.Drawing.Point(402, 3)
            Me.deleteBtn.Name = "deleteBtn"
            Me.deleteBtn.Size = New System.Drawing.Size(25, 24)
            Me.deleteBtn.TabIndex = 1
            Me.deleteBtn.Text = "radButton1"
            AddHandler Me.deleteBtn.Click, AddressOf deleteBtn_Click
            Me.tableLayoutPanel1.SetColumnSpan(Me.radSeparator1, 2)
            Me.radSeparator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSeparator1.Location = New System.Drawing.Point(61, 41)
            Me.radSeparator1.Name = "radSeparator1"
            Me.radSeparator1.Size = New System.Drawing.Size(366, 4)
            Me.radSeparator1.TabIndex = 2
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(61, 51)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(335, 2)
            Me.panel2.TabIndex = 5
            Me.labelHolderPanel.Controls.Add(Me.fileLabel)
            Me.labelHolderPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelHolderPanel.Location = New System.Drawing.Point(61, 33)
            Me.labelHolderPanel.Name = "labelHolderPanel"
            Me.labelHolderPanel.Size = New System.Drawing.Size(335, 2)
            Me.labelHolderPanel.TabIndex = 4
            Me.fileLabel.AutoSize = False
            Me.fileLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fileLabel.Location = New System.Drawing.Point(0, 0)
            Me.fileLabel.MinimumSize = New System.Drawing.Size(0, 4)
            Me.fileLabel.Name = "fileLabel"
            Me.fileLabel.RootElement.MinSize = New System.Drawing.Size(0, 4)
            Me.fileLabel.Size = New System.Drawing.Size(335, 4)
            Me.fileLabel.TabIndex = 6
            Me.fileLabel.Visible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Name = "FilePathUserControl"
            Me.Size = New System.Drawing.Size(490, 56)
            Me.tableLayoutPanel1.ResumeLayout(False)
            CType((Me.radBrowseEditor1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.deleteBtn), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSeparator1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.labelHolderPanel.ResumeLayout(False)
            CType((Me.fileLabel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private radBrowseEditor1 As Telerik.WinControls.UI.RadBrowseEditor
        Private deleteBtn As Telerik.WinControls.UI.RadButton
        Private radSeparator1 As Telerik.WinControls.UI.RadSeparator
        Private panel2 As System.Windows.Forms.Panel
        Private labelHolderPanel As System.Windows.Forms.Panel
        Private fileLabel As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
