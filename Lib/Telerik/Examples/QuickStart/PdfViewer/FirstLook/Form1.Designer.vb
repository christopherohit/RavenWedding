Namespace Telerik.Examples.WinControls.PdfViewer.FirstLook
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
			Me.radPdfViewer1 = New Telerik.WinControls.UI.RadPdfViewer()
			Me.radPDFCommandBar1 = New Telerik.WinControls.UI.RadPdfViewerNavigator()
			CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPDFCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPdfViewer1
			' 
			Me.radPdfViewer1.Dock = DockStyle.Fill
			Me.radPdfViewer1.Location = New Point(0, 68)
			Me.radPdfViewer1.Name = "radPdfViewer1"
			Me.radPdfViewer1.Size = New Size(767, 441)
			Me.radPdfViewer1.TabIndex = 0
			Me.radPdfViewer1.Text = "radPdfViewer1"
			Me.radPdfViewer1.ReadingMode = Telerik.WinControls.UI.ReadingMode.OnDemand
			Me.radPdfViewer1.ViewerMode = Telerik.WinControls.UI.FixedDocumentViewerMode.Pan
			' 
			' radPDFCommandBar1
			' 
			Me.radPDFCommandBar1.Dock = DockStyle.Top
			Me.radPDFCommandBar1.Location = New Point(0, 0)
			Me.radPDFCommandBar1.Name = "radPDFCommandBar1"
			Me.radPDFCommandBar1.AssociatedViewer = Me.radPdfViewer1
			Me.radPDFCommandBar1.Size = New Size(767, 68)
			Me.radPDFCommandBar1.TabIndex = 1
			Me.radPDFCommandBar1.Text = "radPDFCommandBar1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(767, 509)
			Me.Controls.Add(Me.radPdfViewer1)
			Me.Controls.Add(Me.radPDFCommandBar1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPDFCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radPdfViewer1 As Telerik.WinControls.UI.RadPdfViewer
		Private radPDFCommandBar1 As Telerik.WinControls.UI.RadPdfViewerNavigator
	End Class
End Namespace