Namespace Telerik.Examples.WinControls.PdfViewer.InteractiveForms
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
			CType(Me.radPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPdfViewerNavigator1
			' 
			Me.radPdfViewerNavigator1.AssociatedViewer = Me.radPdfViewer1
			Me.radPdfViewerNavigator1.Dock = DockStyle.Top
			Me.radPdfViewerNavigator1.Location = New Point(0, 0)
			Me.radPdfViewerNavigator1.Name = "radPdfViewerNavigator1"
			Me.radPdfViewerNavigator1.Size = New Size(1320, 38)
			Me.radPdfViewerNavigator1.TabIndex = 2
			Me.radPdfViewerNavigator1.Text = "radPdfViewerNavigator1"
			' 
			' radPdfViewer1
			' 
			Me.radPdfViewer1.Dock = DockStyle.Fill
			Me.radPdfViewer1.Location = New Point(0, 38)
			Me.radPdfViewer1.Name = "radPdfViewer1"
			Me.radPdfViewer1.Size = New Size(1320, 991)
			Me.radPdfViewer1.TabIndex = 3
			Me.radPdfViewer1.Text = "radPdfViewer1"
			Me.radPdfViewer1.ThumbnailsScaleFactor = 0.15F
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPdfViewer1)
			Me.Controls.Add(Me.radPdfViewerNavigator1)
			Me.Name = "Form1"
			Me.Size = New Size(1330, 1039)
			Me.Controls.SetChildIndex(Me.radPdfViewerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.radPdfViewer1, 0)
			CType(Me.radPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private radPdfViewerNavigator1 As Telerik.WinControls.UI.RadPdfViewerNavigator
		Private radPdfViewer1 As Telerik.WinControls.UI.RadPdfViewer
	End Class
End Namespace