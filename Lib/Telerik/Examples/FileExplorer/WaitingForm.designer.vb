Namespace FileExplorer
	Partial Public Class WaitingForm
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
			Me.radWaitingBar1 = New Telerik.WinControls.UI.RadWaitingBar()
			CType(Me.radWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radWaitingBar1
			' 
			Me.radWaitingBar1.Location = New Point(12, 12)
			Me.radWaitingBar1.Name = "radWaitingBar1"
			Me.radWaitingBar1.Size = New Size(441, 19)
			Me.radWaitingBar1.TabIndex = 3
			Me.radWaitingBar1.Text = "radWaitingBar1"
			Me.radWaitingBar1.WaitingIndicatorSize = New Size(50, 30)
			Me.radWaitingBar1.WaitingSpeed = 10
			' 
			' WaitingForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(465, 41)
			Me.Controls.Add(Me.radWaitingBar1)
			Me.Name = "WaitingForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Copying..."
			CType(Me.radWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar
	End Class
End Namespace