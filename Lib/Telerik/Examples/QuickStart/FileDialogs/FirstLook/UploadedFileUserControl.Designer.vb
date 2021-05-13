Namespace Telerik.Examples.WinControls.FileDialogs.FirstLook
    Partial Class UploadedFileUserControl
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.labelUploadDate = New Telerik.WinControls.UI.RadLabel()
            Me.labelFileType = New Telerik.WinControls.UI.RadLabel()
            Me.btnRemove = New Telerik.WinControls.UI.RadButton()
            Me.labelFileName = New Telerik.WinControls.UI.RadLabel()
            Me.btnDownload = New Telerik.WinControls.UI.RadButton()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            CType((Me.radPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            CType((Me.labelUploadDate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelFileType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnRemove), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelFileName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnDownload), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.tableLayoutPanel1.ColumnCount = 9
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0F))
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 1
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(693, 37)
            Me.tableLayoutPanel1.TabIndex = 0
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 3
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radPanel1, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.btnDownload, 2, 0)
            Me.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 1
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(738, 47)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 0
            Me.radPanel1.Controls.Add(Me.labelUploadDate)
            Me.radPanel1.Controls.Add(Me.labelFileType)
            Me.radPanel1.Controls.Add(Me.btnRemove)
            Me.radPanel1.Controls.Add(Me.labelFileName)
            Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel1.Location = New System.Drawing.Point(10, 9)
            Me.radPanel1.Margin = New System.Windows.Forms.Padding(10, 9, 3, 1)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Padding = New System.Windows.Forms.Padding(4)
            Me.radPanel1.Size = New System.Drawing.Size(571, 37)
            Me.radPanel1.TabIndex = 1
            Me.labelUploadDate.AutoSize = False
            Me.labelUploadDate.Location = New System.Drawing.Point(329, 10)
            Me.labelUploadDate.Name = "labelUploadDate"
            Me.labelUploadDate.Size = New System.Drawing.Size(138, 18)
            Me.labelUploadDate.TabIndex = 2
            Me.labelUploadDate.Text = "5/2/2019 2:22 PM"
            Me.labelFileType.AutoSize = False
            Me.labelFileType.Location = New System.Drawing.Point(257, 10)
            Me.labelFileType.Name = "labelFileType"
            Me.labelFileType.Size = New System.Drawing.Size(66, 18)
            Me.labelFileType.TabIndex = 1
            Me.labelFileType.Text = "File"
            Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnRemove.Location = New System.Drawing.Point(537, 4)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Padding = New System.Windows.Forms.Padding(3)
            Me.btnRemove.Size = New System.Drawing.Size(30, 29)
            Me.btnRemove.TabIndex = 3
            Me.btnRemove.Text = "X"
            AddHandler Me.btnRemove.Click, AddressOf Me.btnRemove_Click
            Me.labelFileName.AutoSize = False
            Me.labelFileName.Location = New System.Drawing.Point(10, 10)
            Me.labelFileName.Name = "labelFileName"
            Me.labelFileName.Size = New System.Drawing.Size(241, 18)
            Me.labelFileName.TabIndex = 0
            Me.labelFileName.Text = "dummy file.txt"
            Me.btnDownload.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.btnDownload.Location = New System.Drawing.Point(597, 9)
            Me.btnDownload.Margin = New System.Windows.Forms.Padding(3, 9, 13, 1)
            Me.btnDownload.Name = "btnDownload"
            Me.btnDownload.Size = New System.Drawing.Size(128, 37)
            Me.btnDownload.TabIndex = 0
            Me.btnDownload.Text = "Download"
            AddHandler Me.btnDownload.Click, AddressOf Me.btnDownload_Click
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.Name = "UploadedFileUserControl"
            Me.Size = New System.Drawing.Size(738, 47)
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            CType((Me.radPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            CType((Me.labelUploadDate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelFileType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnRemove), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelFileName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnDownload), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private btnDownload As Telerik.WinControls.UI.RadButton
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private labelFileName As Telerik.WinControls.UI.RadLabel
        Private labelUploadDate As Telerik.WinControls.UI.RadLabel
        Private labelFileType As Telerik.WinControls.UI.RadLabel
        Private btnRemove As Telerik.WinControls.UI.RadButton
    End Class
End Namespace
