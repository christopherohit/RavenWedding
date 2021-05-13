Namespace Telerik.Examples.WinControls.Forms.MDIMenuMerge
	Partial Public Class RadChildForm
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
			Me.radStatusBar1 = New Telerik.WinControls.UI.RadStatusStrip()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
			Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
			Me.radProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
			Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCheckBoxElement1 = New Telerik.WinControls.UI.RadCheckBoxElement()
			Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
			Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.timer1 = New Timer(Me.components)
			Me.radMenu1 = New Telerik.WinControls.UI.RadMenu()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			CType(Me.radStatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radStatusBar1
			' 
			Me.radStatusBar1.AutoSize = True
			Me.radStatusBar1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement1, Me.CommandBarSeparator3, Me.radLabelElement3, Me.CommandBarSeparator4, Me.radLabelElement2, Me.radProgressBarElement1, Me.CommandBarSeparator5, Me.radCheckBoxElement1, Me.CommandBarSeparator1, Me.radLabelElement1, Me.CommandBarSeparator2})
			Me.radStatusBar1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
			Me.radStatusBar1.Location = New Point(0, 317)
			Me.radStatusBar1.Margin = New Padding(5)
			Me.radStatusBar1.Name = "radStatusBar1"
			Me.radStatusBar1.Size = New Size(567, 25)
			Me.radStatusBar1.SizingGrip = True
			Me.radStatusBar1.TabIndex = 0
			Me.radStatusBar1.Text = "radStatusBar1"
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Text = "radStatusBar1"
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Padding = New Padding(2)
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).MinSize = New Size(0, 19)
			CType(Me.radStatusBar1.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.StatusBarBoxLayout).Margin = New Padding(0, 0, 14, 0)
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.CanFocus = True
			Me.radButtonElement1.Margin = New Padding(1)
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radStatusBar1.SetSpring(Me.radButtonElement1, False)
			Me.radButtonElement1.Text = "Page 1 of 1"

			' 
			' CommandBarSeparator3
			' 
			Me.CommandBarSeparator3.Margin = New Padding(1)
			Me.CommandBarSeparator3.MinSize = New Size(2, 17)
			Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
			Me.radStatusBar1.SetSpring(Me.CommandBarSeparator3, False)
			Me.CommandBarSeparator3.Text = "CommandBarSeparator3"
			' 
			' radLabelElement3
			' 
			Me.radLabelElement3.ForeColor = Color.FromArgb((CInt((CByte(165)))), (CInt((CByte(165)))), (CInt((CByte(165)))))
			Me.radLabelElement3.Margin = New Padding(1)
			Me.radLabelElement3.Name = "radLabelElement3"
			Me.radStatusBar1.SetSpring(Me.radLabelElement3, False)
			Me.radLabelElement3.Text = "Words: 2"
			' 
			' CommandBarSeparator4
			' 
			Me.CommandBarSeparator4.Margin = New Padding(1)
			Me.CommandBarSeparator4.MinSize = New Size(2, 17)
			Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
			Me.radStatusBar1.SetSpring(Me.CommandBarSeparator4, False)
			Me.CommandBarSeparator4.Text = "CommandBarSeparator4"
			' 
			' radLabelElement2
			' 
			Me.radLabelElement2.Margin = New Padding(1)
			Me.radLabelElement2.Name = "radLabelElement2"
			Me.radStatusBar1.SetSpring(Me.radLabelElement2, False)
			Me.radLabelElement2.Text = "Saving..."
			' 
			' radProgressBarElement1
			' 

			Me.radProgressBarElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			Me.radProgressBarElement1.Bounds = New Rectangle(0, 0, 80, 16)
			Me.radProgressBarElement1.ClipDrawing = True
			Me.radProgressBarElement1.DefaultSize = New Size(80, 16)
			Me.radProgressBarElement1.Margin = New Padding(1)
			Me.radProgressBarElement1.Name = "radProgressBarElement1"
			Me.radStatusBar1.SetSpring(Me.radProgressBarElement1, False)
			Me.radProgressBarElement1.TextAlignment = ContentAlignment.MiddleCenter
			' 
			' CommandBarSeparator5
			' 
			Me.CommandBarSeparator5.Margin = New Padding(1)
			Me.CommandBarSeparator5.MinSize = New Size(2, 17)
			Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
			Me.radStatusBar1.SetSpring(Me.CommandBarSeparator5, False)
			Me.CommandBarSeparator5.Text = "CommandBarSeparator5"
			' 
			' radCheckBoxElement1
			' 
			Me.radCheckBoxElement1.CanFocus = True
			Me.radCheckBoxElement1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radCheckBoxElement1.Margin = New Padding(1)
			Me.radCheckBoxElement1.Name = "radCheckBoxElement1"
			Me.radCheckBoxElement1.ShowBorder = False
			Me.radStatusBar1.SetSpring(Me.radCheckBoxElement1, False)
			Me.radCheckBoxElement1.Text = "Check for errors"
			' 
			' CommandBarSeparator1
			' 
			Me.CommandBarSeparator1.Margin = New Padding(1)
			Me.CommandBarSeparator1.MinSize = New Size(2, 17)
			Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
			Me.radStatusBar1.SetSpring(Me.CommandBarSeparator1, False)
			Me.CommandBarSeparator1.Text = "CommandBarSeparator1"
			' 
			' radLabelElement1
			' 
			Me.radLabelElement1.Margin = New Padding(1)
			Me.radLabelElement1.Name = "radLabelElement1"
			Me.radStatusBar1.SetSpring(Me.radLabelElement1, False)
			Me.radLabelElement1.Text = "English (US)"
			' 
			' CommandBarSeparator2
			' 
			Me.CommandBarSeparator2.Margin = New Padding(1)
			Me.CommandBarSeparator2.MinSize = New Size(2, 17)
			Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
			Me.radStatusBar1.SetSpring(Me.CommandBarSeparator2, False)
			Me.CommandBarSeparator2.Text = "CommandBarSeparator2"
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 1000

			' 
			' radMenu1
			' 
			Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2})
			Me.radMenu1.Location = New Point(0, 0)
			Me.radMenu1.Name = "radMenu1"
			Me.radMenu1.Size = New Size(567, 27)
			Me.radMenu1.TabIndex = 1
			Me.radMenu1.Text = "radMenu1"
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem3})
			Me.radMenuItem1.MergeType = MenuMerge.MergeItems
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "File"
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.MergeType = MenuMerge.MergeItems
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "Print"
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Tools"
			' 
			' radTextBox1
			' 
			Me.radTextBox1.Dock = DockStyle.Fill
			Me.radTextBox1.Location = New Point(0, 27)
			Me.radTextBox1.Multiline = True
			Me.radTextBox1.Name = "radTextBox1"
			' 
			' 
			' 
			Me.radTextBox1.RootElement.StretchVertically = True
			Me.radTextBox1.Size = New Size(567, 290)
			Me.radTextBox1.TabIndex = 2
			' 
			' RadChildForm
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.BackColor = Color.FromArgb((CInt((CByte(191)))), (CInt((CByte(219)))), (CInt((CByte(255)))))
			Me.ClientSize = New Size(567, 342)
			Me.Controls.Add(Me.radTextBox1)
			Me.Controls.Add(Me.radMenu1)
			Me.Controls.Add(Me.radStatusBar1)
			Me.Name = "RadChildForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.RootElement.MinSize = New Size(150, 36)
			Me.Text = "RadChildForm"
			CType(Me.radStatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radStatusBar1 As Telerik.WinControls.UI.RadStatusStrip
		Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
		Private radProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
		Private CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
		Private timer1 As Timer
		Private radLabelElement1 As Telerik.WinControls.UI.RadLabelElement
		Private CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
		Private radLabelElement2 As Telerik.WinControls.UI.RadLabelElement
		Private CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
		Private radLabelElement3 As Telerik.WinControls.UI.RadLabelElement
		Private CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCheckBoxElement1 As Telerik.WinControls.UI.RadCheckBoxElement
		Private CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
		Private radMenu1 As Telerik.WinControls.UI.RadMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
	End Class
End Namespace