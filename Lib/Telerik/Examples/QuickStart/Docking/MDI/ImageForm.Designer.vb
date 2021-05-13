Namespace Telerik.Examples.WinControls.Docking.MDI
	Partial Public Class ImageForm
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
			Me.pictureBox1 = New PictureBox()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BackgroundImage = My.Resources.VistaExplorerBottomRight1
			Me.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch
			Me.pictureBox1.Dock = DockStyle.Fill
			Me.pictureBox1.Image = Telerik.WinControls.ResFinder.WinFormsLogoWithText
			Me.pictureBox1.Location = New Point(0, 0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Size(639, 481)
			Me.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' ImageForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(639, 481)
			Me.Controls.Add(Me.pictureBox1)
			Me.Name = "ImageForm"
			Me.Text = "ImageForm"
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pictureBox1 As PictureBox
	End Class
End Namespace