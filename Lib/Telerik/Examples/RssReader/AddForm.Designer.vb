Namespace CS
	Partial Public Class AddForm
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
			Me.components = New System.ComponentModel.Container()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.errorProvider1 = New ErrorProvider(Me.components)
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(15, 12)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(147, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Please enter category name:"
			' 
			' radTextBox1
			' 
			Me.radTextBox1.Location = New Point(15, 36)
			Me.radTextBox1.Name = "radTextBox1"
			Me.radTextBox1.Size = New Size(255, 20)
			Me.radTextBox1.TabIndex = 1
			Me.radTextBox1.TabStop = False
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(45, 62)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(92, 24)
			Me.radButton1.TabIndex = 2
			Me.radButton1.Text = "OK"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click)
			' 
			' radButton2
			' 
			Me.radButton2.DialogResult = DialogResult.Cancel
			Me.radButton2.Location = New Point(148, 62)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New Size(92, 24)
			Me.radButton2.TabIndex = 3
			Me.radButton2.Text = "Cancel"
'			Me.radButton2.Click += New System.EventHandler(Me.radButton2_Click)
			' 
			' errorProvider1
			' 
			Me.errorProvider1.ContainerControl = Me
			' 
			' AddForm
			' 
			Me.AcceptButton = Me.radButton1
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.radButton2
			Me.ClientSize = New Size(283, 94)
			Me.Controls.Add(Me.radButton2)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.radTextBox1)
			Me.Controls.Add(Me.radLabel1)
			Me.Name = "AddForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "AddGroupForm"
			Me.ThemeName = "ControlDefault"
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private errorProvider1 As ErrorProvider
	End Class
End Namespace
