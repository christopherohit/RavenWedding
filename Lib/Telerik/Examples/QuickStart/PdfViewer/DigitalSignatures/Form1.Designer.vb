Namespace Telerik.Examples.WinControls.PdfViewer.DigitalSignatures
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
			Me.radPdfViewerNavigator1 = New Telerik.WinControls.UI.RadPdfViewerNavigator()
			Me.radPdfViewer1 = New Telerik.WinControls.UI.RadPdfViewer()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.unknownSignatureRadioButton = New Telerik.WinControls.UI.RadRadioButton()
			Me.invalidSignatureRadioButton = New Telerik.WinControls.UI.RadRadioButton()
			Me.openDocumentButton = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.unknownSignatureRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.invalidSignatureRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.openDocumentButton, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.openDocumentButton)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Size = New Size(230, 192)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.openDocumentButton, 0)
			' 
			' radPdfViewerNavigator1
			' 
			Me.radPdfViewerNavigator1.AssociatedViewer = Me.radPdfViewer1
			Me.radPdfViewerNavigator1.Dock = DockStyle.Top
			Me.radPdfViewerNavigator1.Location = New Point(0, 0)
			Me.radPdfViewerNavigator1.Name = "radPdfViewerNavigator1"
			Me.radPdfViewerNavigator1.Size = New Size(1541, 38)
			Me.radPdfViewerNavigator1.TabIndex = 2
			Me.radPdfViewerNavigator1.Text = "radPdfViewerNavigator1"
			' 
			' radPdfViewer1
			' 
			Me.radPdfViewer1.Dock = DockStyle.Fill
			Me.radPdfViewer1.Location = New Point(0, 38)
			Me.radPdfViewer1.Name = "radPdfViewer1"
			Me.radPdfViewer1.Size = New Size(1541, 757)
			Me.radPdfViewer1.TabIndex = 3
			Me.radPdfViewer1.Text = "radPdfViewer1"
			Me.radPdfViewer1.ThumbnailsScaleFactor = 0.15F
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.unknownSignatureRadioButton)
			Me.radGroupBox1.Controls.Add(Me.invalidSignatureRadioButton)
			Me.radGroupBox1.HeaderText = "Load Document with:"
			Me.radGroupBox1.Location = New Point(10, 32)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(210, 89)
			Me.radGroupBox1.TabIndex = 5
			Me.radGroupBox1.Text = "Load Document with:"
			' 
			' unknownSignatureRadioButton
			' 
			Me.unknownSignatureRadioButton.Anchor = AnchorStyles.Top
			Me.unknownSignatureRadioButton.CheckState = CheckState.Checked
			Me.unknownSignatureRadioButton.Location = New Point(5, 60)
			Me.unknownSignatureRadioButton.Name = "unknownSignatureRadioButton"
			Me.unknownSignatureRadioButton.Size = New Size(118, 18)
			Me.unknownSignatureRadioButton.TabIndex = 6
			Me.unknownSignatureRadioButton.Text = "Unknown Signature"
			Me.unknownSignatureRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' invalidSignatureRadioButton
			' 
			Me.invalidSignatureRadioButton.Anchor = AnchorStyles.Top
			Me.invalidSignatureRadioButton.Location = New Point(5, 32)
			Me.invalidSignatureRadioButton.Name = "invalidSignatureRadioButton"
			Me.invalidSignatureRadioButton.Size = New Size(104, 18)
			Me.invalidSignatureRadioButton.TabIndex = 5
			Me.invalidSignatureRadioButton.TabStop = False
			Me.invalidSignatureRadioButton.Text = "Invalid Signature"
			' 
			' openDocumentButton
			' 
			Me.openDocumentButton.Anchor = AnchorStyles.Top
			Me.openDocumentButton.Location = New Point(10, 127)
			Me.openDocumentButton.Name = "openDocumentButton"
			Me.openDocumentButton.Size = New Size(210, 24)
			Me.openDocumentButton.TabIndex = 7
			Me.openDocumentButton.Text = "Open your document"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPdfViewer1)
			Me.Controls.Add(Me.radPdfViewerNavigator1)
			Me.Name = "Form1"
			Me.Size = New Size(1551, 805)
			Me.Controls.SetChildIndex(Me.radPdfViewerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.radPdfViewer1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.unknownSignatureRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.invalidSignatureRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.openDocumentButton, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private radPdfViewerNavigator1 As Telerik.WinControls.UI.RadPdfViewerNavigator
		Private radPdfViewer1 As Telerik.WinControls.UI.RadPdfViewer
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private openDocumentButton As Telerik.WinControls.UI.RadButton
		Private unknownSignatureRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private invalidSignatureRadioButton As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace