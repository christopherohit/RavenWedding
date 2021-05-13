Namespace CS
	Partial Public Class ChangeCategoryForm
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
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.errorProvider1 = New ErrorProvider(Me.components)
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBox2 = New Telerik.WinControls.UI.RadTextBox()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Location = New Point(12, 67)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(123, 18)
			Me.radCheckBox1.TabIndex = 1
			Me.radCheckBox1.Text = "Add in new category"
'			Me.radCheckBox1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox1_ToggleStateChanged)
			' 
			' radTextBox1
			' 
			Me.radTextBox1.Enabled = False
			Me.radTextBox1.Location = New Point(12, 91)
			Me.radTextBox1.Name = "radTextBox1"
			Me.radTextBox1.Size = New Size(266, 20)
			Me.radTextBox1.TabIndex = 2
			Me.radTextBox1.TabStop = False
			' 
			' radButton2
			' 
			Me.radButton2.DialogResult = DialogResult.Cancel
			Me.radButton2.Location = New Point(146, 177)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New Size(92, 24)
			Me.radButton2.TabIndex = 5
			Me.radButton2.Text = "Cancel"
'			Me.radButton2.Click += New System.EventHandler(Me.radButton2_Click)
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(43, 177)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(92, 24)
			Me.radButton1.TabIndex = 4
			Me.radButton1.Text = "OK"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click)
			' 
			' errorProvider1
			' 
			Me.errorProvider1.ContainerControl = Me
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.DropDownAnimationEnabled = True
			Me.radDropDownList1.Location = New Point(12, 151)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.ShowImageInEditorArea = True
			Me.radDropDownList1.Size = New Size(266, 20)
			Me.radDropDownList1.TabIndex = 6
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(12, 127)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(132, 18)
			Me.radLabel1.TabIndex = 7
			Me.radLabel1.Text = "Choose existing category"
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(12, 12)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(87, 18)
			Me.radLabel2.TabIndex = 8
			Me.radLabel2.Text = "Enter new name"
			' 
			' radTextBox2
			' 
			Me.radTextBox2.Location = New Point(12, 36)
			Me.radTextBox2.Name = "radTextBox2"
			Me.radTextBox2.Size = New Size(266, 20)
			Me.radTextBox2.TabIndex = 3
			Me.radTextBox2.TabStop = False
			' 
			' ChangeCategoryForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoSize = True
			Me.ClientSize = New Size(286, 210)
			Me.Controls.Add(Me.radTextBox2)
			Me.Controls.Add(Me.radLabel2)
			Me.Controls.Add(Me.radLabel1)
			Me.Controls.Add(Me.radDropDownList1)
			Me.Controls.Add(Me.radButton2)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.radTextBox1)
			Me.Controls.Add(Me.radCheckBox1)
			Me.Name = "ChangeCategoryForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "ChangeCategoryForm"
			Me.ThemeName = "ControlDefault"
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private errorProvider1 As ErrorProvider
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radTextBox2 As Telerik.WinControls.UI.RadTextBox
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
