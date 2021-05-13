Namespace Telerik.Examples.WinControls.Docking.MDI
	Partial Public Class ReportForm
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
			Me.webBrowser1 = New WebBrowser()
			Me.SuspendLayout()
			' 
			' webBrowser1
			' 
			Me.webBrowser1.Dock = DockStyle.Fill
			Me.webBrowser1.Location = New Point(0, 0)
			Me.webBrowser1.MinimumSize = New Size(20, 20)
			Me.webBrowser1.Name = "webBrowser1"
			Me.webBrowser1.Size = New Size(601, 551)
			Me.webBrowser1.TabIndex = 0
			Me.webBrowser1.ScriptErrorsSuppressed = True
			Me.webBrowser1.Url = New Uri("http://www.telerik.com/", UriKind.Absolute)
			' 
			' ReportForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(601, 551)
			Me.Controls.Add(Me.webBrowser1)
			Me.Name = "ReportForm"
			Me.Text = "ReportForm"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private webBrowser1 As WebBrowser
	End Class
End Namespace