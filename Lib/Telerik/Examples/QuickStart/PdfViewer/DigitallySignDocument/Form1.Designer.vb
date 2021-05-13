Namespace Telerik.Examples.WinControls.PdfViewer.DigitallySignDocument
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
			Me.openDocumentButton = New Telerik.WinControls.UI.RadButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.downloadCertificateButton = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.openDocumentButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.downloadCertificateButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Size = New Size(230, 192)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			' 
			' radPdfViewerNavigator1
			' 
			Me.radPdfViewerNavigator1.AssociatedViewer = Me.radPdfViewer1
			Me.radPdfViewerNavigator1.Dock = DockStyle.Top
			Me.radPdfViewerNavigator1.Location = New Point(0, 0)
			Me.radPdfViewerNavigator1.Name = "radPdfViewerNavigator1"
			Me.radPdfViewerNavigator1.Size = New Size(1295, 38)
			Me.radPdfViewerNavigator1.TabIndex = 2
			Me.radPdfViewerNavigator1.Text = "radPdfViewerNavigator1"
			' 
			' radPdfViewer1
			' 
			Me.radPdfViewer1.Dock = DockStyle.Fill
			Me.radPdfViewer1.Location = New Point(0, 38)
			Me.radPdfViewer1.Name = "radPdfViewer1"
			Me.radPdfViewer1.Size = New Size(1295, 991)
			Me.radPdfViewer1.TabIndex = 3
			Me.radPdfViewer1.Text = "radPdfViewer1"
			Me.radPdfViewer1.ThumbnailsScaleFactor = 0.15F
			' 
			' openDocumentButton
			' 
			Me.openDocumentButton.Anchor = AnchorStyles.Top
			Me.openDocumentButton.Location = New Point(5, 26)
			Me.openDocumentButton.Name = "openDocumentButton"
			Me.openDocumentButton.Size = New Size(200, 26)
			Me.openDocumentButton.TabIndex = 0
			Me.openDocumentButton.Text = "Open your document"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.downloadCertificateButton)
			Me.radGroupBox1.Controls.Add(Me.openDocumentButton)
			Me.radGroupBox1.HeaderText = "Load Document with:"
			Me.radGroupBox1.Location = New Point(10, 32)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(210, 89)
			Me.radGroupBox1.TabIndex = 5
			Me.radGroupBox1.Text = "Load Document with:"
			' 
			' downloadCertificateButton
			' 
			Me.downloadCertificateButton.Anchor = AnchorStyles.Top
			Me.downloadCertificateButton.Location = New Point(5, 58)
			Me.downloadCertificateButton.Name = "downloadCertificateButton"
			Me.downloadCertificateButton.Size = New Size(200, 24)
			Me.downloadCertificateButton.TabIndex = 0
			Me.downloadCertificateButton.Text = "Download test certificate"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.AutoSize = False
			Me.radLabel1.ForeColor = Color.Red
			Me.radLabel1.Location = New Point(10, 128)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(210, 18)
			Me.radLabel1.TabIndex = 6
			Me.radLabel1.Tag = "NotAutoSized"
			Me.radLabel1.Text = "Certificate Password: johndoe"
			Me.radLabel1.TextAlignment = ContentAlignment.MiddleCenter
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPdfViewer1)
			Me.Controls.Add(Me.radPdfViewerNavigator1)
			Me.Name = "Form1"
			Me.Size = New Size(1305, 1039)
			Me.Controls.SetChildIndex(Me.radPdfViewerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.radPdfViewer1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.openDocumentButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.downloadCertificateButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private radPdfViewerNavigator1 As Telerik.WinControls.UI.RadPdfViewerNavigator
		Private radPdfViewer1 As Telerik.WinControls.UI.RadPdfViewer
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private openDocumentButton As Telerik.WinControls.UI.RadButton
		Private downloadCertificateButton As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace