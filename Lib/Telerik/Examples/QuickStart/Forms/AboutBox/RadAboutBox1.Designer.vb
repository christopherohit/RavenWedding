Namespace Telerik.Examples.WinControls.Forms.AboutBox
	Partial Friend Class RadAboutBox1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(RadAboutBox1))
			Me.tableLayoutPanel = New TableLayoutPanel()
			Me.logoPictureBox = New PictureBox()
			Me.radLabelProductName = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelVersion = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelCopyright = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelCompanyName = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBoxDescription = New Telerik.WinControls.UI.RadTextBox()
			Me.okRadButton = New Telerik.WinControls.UI.RadButton()
			Me.tableLayoutPanel.SuspendLayout()
			CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelProductName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelVersion, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelCopyright, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBoxDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.okRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' tableLayoutPanel
			' 
			Me.tableLayoutPanel.BackColor = Color.Transparent
			Me.tableLayoutPanel.ColumnCount = 2
			Me.tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33F))
			Me.tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 67F))
			Me.tableLayoutPanel.Controls.Add(Me.logoPictureBox, 0, 0)
			Me.tableLayoutPanel.Controls.Add(Me.radLabelProductName, 1, 0)
			Me.tableLayoutPanel.Controls.Add(Me.radLabelVersion, 1, 1)
			Me.tableLayoutPanel.Controls.Add(Me.radLabelCopyright, 1, 2)
			Me.tableLayoutPanel.Controls.Add(Me.radLabelCompanyName, 1, 3)
			Me.tableLayoutPanel.Controls.Add(Me.radTextBoxDescription, 1, 4)
			Me.tableLayoutPanel.Controls.Add(Me.okRadButton, 1, 5)
			Me.tableLayoutPanel.Dock = DockStyle.Fill
			Me.tableLayoutPanel.Location = New Point(9, 9)
			Me.tableLayoutPanel.Name = "tableLayoutPanel"
			Me.tableLayoutPanel.RowCount = 6
			Me.tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
			Me.tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
			Me.tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
			Me.tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
			Me.tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
			Me.tableLayoutPanel.Size = New Size(388, 265)
			Me.tableLayoutPanel.TabIndex = 0
			' 
			' logoPictureBox
			' 
			Me.logoPictureBox.Dock = DockStyle.Fill
			Me.logoPictureBox.Image = (CType(resources.GetObject("logoPictureBox.Image"), Image))
			Me.logoPictureBox.Location = New Point(3, 3)
			Me.logoPictureBox.Name = "logoPictureBox"
			Me.tableLayoutPanel.SetRowSpan(Me.logoPictureBox, 6)
			Me.logoPictureBox.Size = New Size(122, 259)
			Me.logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
			Me.logoPictureBox.TabIndex = 12
			Me.logoPictureBox.TabStop = False
			' 
			' radLabelProductName
			' 
			Me.radLabelProductName.Dock = DockStyle.Fill
			Me.radLabelProductName.Location = New Point(134, 0)
			Me.radLabelProductName.Margin = New Padding(6, 0, 3, 0)
			Me.radLabelProductName.MaximumSize = New Size(0, 17)
			Me.radLabelProductName.Name = "radLabelProductName"
			' 
			' 
			' 
			Me.radLabelProductName.RootElement.MaxSize = New Size(0, 17)
			Me.radLabelProductName.Size = New Size(76, 14)
			Me.radLabelProductName.TabIndex = 19
			Me.radLabelProductName.Text = "Product Name"
			Me.radLabelProductName.TextAlignment = ContentAlignment.MiddleLeft
			' 
			' radLabelVersion
			' 
			Me.radLabelVersion.Dock = DockStyle.Fill
			Me.radLabelVersion.Location = New Point(134, 26)
			Me.radLabelVersion.Margin = New Padding(6, 0, 3, 0)
			Me.radLabelVersion.MaximumSize = New Size(0, 17)
			Me.radLabelVersion.Name = "radLabelVersion"
			' 
			' 
			' 
			Me.radLabelVersion.RootElement.MaxSize = New Size(0, 17)
			Me.radLabelVersion.Size = New Size(43, 14)
			Me.radLabelVersion.TabIndex = 0
			Me.radLabelVersion.Text = "Version"
			Me.radLabelVersion.TextAlignment = ContentAlignment.MiddleLeft
			' 
			' radLabelCopyright
			' 
			Me.radLabelCopyright.Dock = DockStyle.Fill
			Me.radLabelCopyright.Location = New Point(134, 52)
			Me.radLabelCopyright.Margin = New Padding(6, 0, 3, 0)
			Me.radLabelCopyright.MaximumSize = New Size(0, 17)
			Me.radLabelCopyright.Name = "radLabelCopyright"
			' 
			' 
			' 
			Me.radLabelCopyright.RootElement.MaxSize = New Size(0, 17)
			Me.radLabelCopyright.Size = New Size(53, 14)
			Me.radLabelCopyright.TabIndex = 21
			Me.radLabelCopyright.Text = "Copyright"
			Me.radLabelCopyright.TextAlignment = ContentAlignment.MiddleLeft
			' 
			' radLabelCompanyName
			' 
			Me.radLabelCompanyName.Dock = DockStyle.Fill
			Me.radLabelCompanyName.Location = New Point(134, 78)
			Me.radLabelCompanyName.Margin = New Padding(6, 0, 3, 0)
			Me.radLabelCompanyName.MaximumSize = New Size(0, 17)
			Me.radLabelCompanyName.Name = "radLabelCompanyName"
			' 
			' 
			' 
			Me.radLabelCompanyName.RootElement.MaxSize = New Size(0, 17)
			Me.radLabelCompanyName.Size = New Size(86, 14)
			Me.radLabelCompanyName.TabIndex = 22
			Me.radLabelCompanyName.Text = "Company Name"
			Me.radLabelCompanyName.TextAlignment = ContentAlignment.MiddleLeft
			' 
			' radTextBoxDescription
			' 
			Me.radTextBoxDescription.Dock = DockStyle.Fill
			Me.radTextBoxDescription.Location = New Point(134, 107)
			Me.radTextBoxDescription.Margin = New Padding(6, 3, 3, 3)
			Me.radTextBoxDescription.Multiline = True
			Me.radTextBoxDescription.Name = "radTextBoxDescription"
			Me.radTextBoxDescription.ReadOnly = True
			' 
			' 
			' 
			Me.radTextBoxDescription.RootElement.StretchVertically = True
            Me.radTextBoxDescription.ScrollBars = ScrollBars.None
			Me.radTextBoxDescription.Size = New Size(251, 126)
			Me.radTextBoxDescription.TabIndex = 23
			Me.radTextBoxDescription.TabStop = False
			Me.radTextBoxDescription.Text = "Description"
			' 
			' okRadButton
			' 
			Me.okRadButton.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.okRadButton.DialogResult = DialogResult.Cancel
			Me.okRadButton.Location = New Point(310, 239)
			Me.okRadButton.Name = "okRadButton"
			Me.okRadButton.Size = New Size(75, 23)
			Me.okRadButton.TabIndex = 24
			Me.okRadButton.Text = "&OK"
			' 
			' RadAboutBox1
			' 
			Me.AcceptButton = Me.okRadButton
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(406, 283)
			Me.Controls.Add(Me.tableLayoutPanel)
			Me.FormBorderStyle = FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "RadAboutBox1"
			Me.Padding = New Padding(9)
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "RadAboutBox1"
			Me.tableLayoutPanel.ResumeLayout(False)
			Me.tableLayoutPanel.PerformLayout()
			CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelProductName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelVersion, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelCopyright, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelCompanyName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBoxDescription, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.okRadButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tableLayoutPanel As TableLayoutPanel
		Private logoPictureBox As PictureBox
		Private radLabelProductName As Telerik.WinControls.UI.RadLabel
		Private radLabelVersion As Telerik.WinControls.UI.RadLabel
		Private radLabelCopyright As Telerik.WinControls.UI.RadLabel
		Private radLabelCompanyName As Telerik.WinControls.UI.RadLabel
		Private radTextBoxDescription As Telerik.WinControls.UI.RadTextBox
		Private okRadButton As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
