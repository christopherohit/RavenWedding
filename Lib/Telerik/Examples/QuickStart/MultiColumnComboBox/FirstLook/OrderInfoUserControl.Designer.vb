Namespace Telerik.Examples.WinControls.MultiColumnComboBox.FirstLook
    Partial Class OrderInfoUserControl
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.initialsLabel = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.firstNameLabel = New Telerik.WinControls.UI.RadLabel()
            Me.lastNameLabel = New Telerik.WinControls.UI.RadLabel()
            Me.customerLabel = New Telerik.WinControls.UI.RadLabel()
            Me.productCountLabel = New Telerik.WinControls.UI.RadLabel()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.initialsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.firstNameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lastNameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customerLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productCountLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 3
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel4, 1, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel3, 1, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel2, 1, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.initialsLabel, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 1, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.firstNameLabel, 2, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.lastNameLabel, 2, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.customerLabel, 2, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.productCountLabel, 2, 3)
            Me.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(7, 7)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 4
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(427, 106)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 0
            Me.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Me.radLabel4.ForeColor = System.Drawing.Color.Black
            Me.radLabel4.Location = New System.Drawing.Point(109, 81)
            Me.radLabel4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(93, 21)
            Me.radLabel4.TabIndex = 3
            Me.radLabel4.Text = "Product count:"
            Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Me.radLabel3.ForeColor = System.Drawing.Color.Black
            Me.radLabel3.Location = New System.Drawing.Point(109, 54)
            Me.radLabel3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(67, 21)
            Me.radLabel3.TabIndex = 3
            Me.radLabel3.Text = "Customer:"
            Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Me.radLabel2.ForeColor = System.Drawing.Color.Black
            Me.radLabel2.Location = New System.Drawing.Point(109, 28)
            Me.radLabel2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(72, 21)
            Me.radLabel2.TabIndex = 2
            Me.radLabel2.Text = "Last Name:"
            Me.initialsLabel.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.initialsLabel.AutoSize = False
            Me.initialsLabel.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((153)))))), (CInt(((CByte((188)))))))
            Me.initialsLabel.Font = New System.Drawing.Font("Segoe UI", 36.0F)
            Me.initialsLabel.ForeColor = System.Drawing.Color.White
            Me.initialsLabel.Location = New System.Drawing.Point(3, 3)
            Me.initialsLabel.Name = "initialsLabel"
            Me.doubleBufferedTableLayoutPanel1.SetRowSpan(Me.initialsLabel, 4)
            Me.initialsLabel.Size = New System.Drawing.Size(100, 100)
            Me.initialsLabel.TabIndex = 0
            Me.initialsLabel.Text = "ND"
            Me.initialsLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Me.radLabel1.ForeColor = System.Drawing.Color.Black
            Me.radLabel1.Location = New System.Drawing.Point(109, 2)
            Me.radLabel1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(73, 21)
            Me.radLabel1.TabIndex = 1
            Me.radLabel1.Text = "First Name:"
            Me.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.firstNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F)
            Me.firstNameLabel.ForeColor = System.Drawing.Color.Black
            Me.firstNameLabel.Location = New System.Drawing.Point(234, 2)
            Me.firstNameLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.firstNameLabel.Name = "firstNameLabel"
            Me.firstNameLabel.Size = New System.Drawing.Size(66, 21)
            Me.firstNameLabel.TabIndex = 4
            Me.firstNameLabel.Text = "Nancy"
            Me.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.lastNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F)
            Me.lastNameLabel.ForeColor = System.Drawing.Color.Black
            Me.lastNameLabel.Location = New System.Drawing.Point(234, 28)
            Me.lastNameLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.lastNameLabel.Name = "lastNameLabel"
            Me.lastNameLabel.Size = New System.Drawing.Size(67, 21)
            Me.lastNameLabel.TabIndex = 5
            Me.lastNameLabel.Text = "Davolio"
            Me.customerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.customerLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F)
            Me.customerLabel.ForeColor = System.Drawing.Color.Black
            Me.customerLabel.Location = New System.Drawing.Point(234, 54)
            Me.customerLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.customerLabel.Name = "customerLabel"
            Me.customerLabel.Size = New System.Drawing.Size(66, 21)
            Me.customerLabel.TabIndex = 6
            Me.customerLabel.Text = "Maria Anders"
            Me.productCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.productCountLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F)
            Me.productCountLabel.ForeColor = System.Drawing.Color.Black
            Me.productCountLabel.Location = New System.Drawing.Point(234, 81)
            Me.productCountLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.productCountLabel.Name = "productCountLabel"
            Me.productCountLabel.Size = New System.Drawing.Size(15, 21)
            Me.productCountLabel.TabIndex = 7
            Me.productCountLabel.Text = "4"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.Name = "OrderInfoUserControl"
            Me.Padding = New System.Windows.Forms.Padding(7)
            Me.Size = New System.Drawing.Size(441, 120)
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.initialsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.firstNameLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lastNameLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customerLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productCountLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private initialsLabel As Telerik.WinControls.UI.RadLabel
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private firstNameLabel As Telerik.WinControls.UI.RadLabel
        Private lastNameLabel As Telerik.WinControls.UI.RadLabel
        Private customerLabel As Telerik.WinControls.UI.RadLabel
        Private productCountLabel As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
