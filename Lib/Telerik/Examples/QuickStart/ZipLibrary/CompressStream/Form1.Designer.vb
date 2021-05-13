Namespace Telerik.Examples.WinControls.ZipLibrary.CompressStream
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
			Me.uncompressedTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.compressedTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.uncompressedLabel = New Telerik.WinControls.UI.RadLabel()
			Me.compressedLabel = New Telerik.WinControls.UI.RadLabel()
			Me.compressButton = New Telerik.WinControls.UI.RadButton()
			Me.compressionMethodsDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.uncompressedTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.compressedTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.uncompressedLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.compressedLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.compressButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.compressionMethodsDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Controls.Add(Me.compressionMethodsDropDownList)
			Me.settingsPanel.Location = New Point(1280, 19)
			Me.settingsPanel.Controls.SetChildIndex(Me.compressionMethodsDropDownList, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			' 
			' uncompressedTextBoxControl
			' 
			Me.uncompressedTextBoxControl.Location = New Point(0, 3)
			Me.uncompressedTextBoxControl.Multiline = True
			Me.uncompressedTextBoxControl.Name = "uncompressedTextBoxControl"
			Me.uncompressedTextBoxControl.Size = New Size(400, 200)
			Me.uncompressedTextBoxControl.TabIndex = 2
			' 
			' compressedTextBoxControl
			' 
			Me.compressedTextBoxControl.Location = New Point(0, 253)
			Me.compressedTextBoxControl.Multiline = True
			Me.compressedTextBoxControl.Name = "compressedTextBoxControl"
			Me.compressedTextBoxControl.Size = New Size(400, 200)
			Me.compressedTextBoxControl.TabIndex = 3
			' 
			' uncompressedLabel
			' 
			Me.uncompressedLabel.Location = New Point(3, 209)
			Me.uncompressedLabel.Name = "uncompressedLabel"
			Me.uncompressedLabel.Size = New Size(114, 18)
			Me.uncompressedLabel.TabIndex = 4
			Me.uncompressedLabel.Text = "Uuncompressed size: "
			' 
			' compressedLabel
			' 
			Me.compressedLabel.Location = New Point(3, 459)
			Me.compressedLabel.Name = "compressedLabel"
			Me.compressedLabel.Size = New Size(96, 18)
			Me.compressedLabel.TabIndex = 5
			Me.compressedLabel.Text = "Compressed size: "
			' 
			' compressButton
			' 
			Me.compressButton.Location = New Point(290, 216)
			Me.compressButton.Name = "compressButton"
			Me.compressButton.Size = New Size(110, 24)
			Me.compressButton.TabIndex = 6
			Me.compressButton.Text = "Compress"
'			Me.compressButton.Click += New System.EventHandler(Me.compressButton_Click)
			' 
			' compressionMethodsDropDownList
			' 
			Me.compressionMethodsDropDownList.AllowShowFocusCues = False
			Me.compressionMethodsDropDownList.Anchor = AnchorStyles.Top
			Me.compressionMethodsDropDownList.AutoCompleteDisplayMember = Nothing
			Me.compressionMethodsDropDownList.AutoCompleteValueMember = Nothing
			Me.compressionMethodsDropDownList.DescriptionTextMember = Nothing
			Me.compressionMethodsDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.compressionMethodsDropDownList.Location = New Point(10, 56)
			Me.compressionMethodsDropDownList.Name = "compressionMethodsDropDownList"
			Me.compressionMethodsDropDownList.Size = New Size(210, 20)
			Me.compressionMethodsDropDownList.TabIndex = 1
			Me.compressionMethodsDropDownList.Text = "radDropDownList1"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(10, 32)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(96, 18)
			Me.radLabel1.TabIndex = 6
			Me.radLabel1.Text = "Compression level"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.Transparent
			Me.Controls.Add(Me.compressButton)
			Me.Controls.Add(Me.compressedLabel)
			Me.Controls.Add(Me.uncompressedLabel)
			Me.Controls.Add(Me.compressedTextBoxControl)
			Me.Controls.Add(Me.uncompressedTextBoxControl)
			Me.Name = "Form1"
			Me.Size = New Size(1523, 1000)
			Me.Controls.SetChildIndex(Me.uncompressedTextBoxControl, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.compressedTextBoxControl, 0)
			Me.Controls.SetChildIndex(Me.uncompressedLabel, 0)
			Me.Controls.SetChildIndex(Me.compressedLabel, 0)
			Me.Controls.SetChildIndex(Me.compressButton, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.uncompressedTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.compressedTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.uncompressedLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.compressedLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.compressButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.compressionMethodsDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private uncompressedTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private compressedTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private uncompressedLabel As Telerik.WinControls.UI.RadLabel
		Private compressedLabel As Telerik.WinControls.UI.RadLabel
		Private WithEvents compressButton As Telerik.WinControls.UI.RadButton
		Private compressionMethodsDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace