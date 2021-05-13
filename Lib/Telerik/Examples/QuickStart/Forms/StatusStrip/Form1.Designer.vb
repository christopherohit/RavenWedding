Namespace Telerik.Examples.WinControls.Forms.StatusStrip
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radStatusBar1 = New Telerik.WinControls.UI.RadStatusStrip()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
			Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
			Me.radProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
			Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCheckBoxElement1 = New Telerik.WinControls.UI.RadCheckBoxElement()
			Me.radLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
			Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radSplitButtonElement1 = New Telerik.WinControls.UI.RadSplitButtonElement()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.timer1 = New Timer(Me.components)
			Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radStatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radStatusBar1
			' 
			Me.radStatusBar1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement1, Me.CommandBarSeparator3, Me.radLabelElement3, Me.CommandBarSeparator4, Me.radLabelElement2, Me.radProgressBarElement1, Me.CommandBarSeparator5, Me.radCheckBoxElement1, Me.radLabelElement1, Me.CommandBarSeparator2, Me.radSplitButtonElement1, Me.CommandBarSeparator1})
			Me.radStatusBar1.Location = New Point(0, 217)
			Me.radStatusBar1.Name = "radStatusBar1"
			Me.radStatusBar1.Size = New Size(631, 26)
			Me.radStatusBar1.TabIndex = 0
			Me.radStatusBar1.Text = "radStatusBar1"
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Text = "radStatusBar1"
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.AccessibleDescription = "Page 1 of 1"
			Me.radButtonElement1.AccessibleName = "Page 1 of 1"
			Me.radButtonElement1.CanFocus = True
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radStatusBar1.SetSpring(Me.radButtonElement1, False)
			Me.radButtonElement1.Text = "Page 1 of 1"
			Me.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' CommandBarSeparator3
			' 
			Me.CommandBarSeparator3.Margin = New Padding(1)
			Me.CommandBarSeparator3.MinSize = New Size(2, 17)
			Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
			Me.radStatusBar1.SetSpring(Me.CommandBarSeparator3, False)
			Me.CommandBarSeparator3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.CommandBarSeparator3.VisibleInOverflowMenu = False
			' 
			' radLabelElement3
			' 
			Me.radLabelElement3.AccessibleDescription = "Words: 2"
			Me.radLabelElement3.AccessibleName = "Words: 2"
			Me.radLabelElement3.ForeColor = Color.FromArgb((CInt((CByte(165)))), (CInt((CByte(165)))), (CInt((CByte(165)))))
			Me.radLabelElement3.Margin = New Padding(0, 1, 0, 0)
			Me.radLabelElement3.Name = "radLabelElement3"
			Me.radStatusBar1.SetSpring(Me.radLabelElement3, False)
			Me.radLabelElement3.Text = "Words: 2"
			Me.radLabelElement3.TextWrap = True
			Me.radLabelElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' CommandBarSeparator4
			' 
			Me.CommandBarSeparator4.MinSize = New Size(2, 17)
			Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
			Me.radStatusBar1.SetSpring(Me.CommandBarSeparator4, False)
			Me.CommandBarSeparator4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.CommandBarSeparator4.VisibleInOverflowMenu = False
			' 
			' radLabelElement2
			' 
			Me.radLabelElement2.AccessibleDescription = "Saving..."
			Me.radLabelElement2.AccessibleName = "Saving..."
			Me.radLabelElement2.Margin = New Padding(0, 1, 0, 0)
			Me.radLabelElement2.Name = "radLabelElement2"
			Me.radStatusBar1.SetSpring(Me.radLabelElement2, False)
			Me.radLabelElement2.Text = "Saving..."
			Me.radLabelElement2.TextWrap = True
			Me.radLabelElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radProgressBarElement1
			' 
			Me.radProgressBarElement1.AutoSize = True
			Me.radProgressBarElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			Me.radProgressBarElement1.Bounds = New Rectangle(0, 0, 133, 16)
			Me.radProgressBarElement1.ClipDrawing = True
			Me.radProgressBarElement1.DefaultSize = New Size(130, 16)
			Me.radProgressBarElement1.Margin = New Padding(0, 3, 0, 0)
			Me.radProgressBarElement1.Name = "radProgressBarElement1"
			Me.radProgressBarElement1.SeparatorColor1 = Color.White
			Me.radProgressBarElement1.SeparatorColor2 = Color.White
			Me.radProgressBarElement1.SeparatorColor3 = Color.White
			Me.radProgressBarElement1.SeparatorColor4 = Color.White
			Me.radProgressBarElement1.SeparatorGradientAngle = 0
			Me.radProgressBarElement1.SeparatorGradientPercentage1 = 0.4F
			Me.radProgressBarElement1.SeparatorGradientPercentage2 = 0.6F
			Me.radProgressBarElement1.SeparatorNumberOfColors = 2
			Me.radStatusBar1.SetSpring(Me.radProgressBarElement1, False)
			Me.radProgressBarElement1.StepWidth = 14
			Me.radProgressBarElement1.SweepAngle = 90
			Me.radProgressBarElement1.TextAlignment = ContentAlignment.MiddleCenter
			Me.radProgressBarElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' CommandBarSeparator5
			' 
			Me.CommandBarSeparator5.Margin = New Padding(1)
			Me.CommandBarSeparator5.MinSize = New Size(2, 17)
			Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
			Me.radStatusBar1.SetSpring(Me.CommandBarSeparator5, False)
			Me.CommandBarSeparator5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.CommandBarSeparator5.VisibleInOverflowMenu = False
			' 
			' radCheckBoxElement1
			' 
			Me.radCheckBoxElement1.AccessibleDescription = "Check for errors"
			Me.radCheckBoxElement1.AccessibleName = "Check for errors"
			Me.radCheckBoxElement1.CanFocus = True
			Me.radCheckBoxElement1.Checked = False
			Me.radCheckBoxElement1.Margin = New Padding(0)
			Me.radCheckBoxElement1.Name = "radCheckBoxElement1"
			Me.radCheckBoxElement1.ShowBorder = False
			Me.radStatusBar1.SetSpring(Me.radCheckBoxElement1, False)
			Me.radCheckBoxElement1.Text = "Check for errors"
			Me.radCheckBoxElement1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radCheckBoxElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radLabelElement1
			' 
			Me.radLabelElement1.AccessibleDescription = "English (US)"
			Me.radLabelElement1.AccessibleName = "English (US)"
			Me.radLabelElement1.Margin = New Padding(0, 1, 0, 0)
			Me.radLabelElement1.Name = "radLabelElement1"
			Me.radStatusBar1.SetSpring(Me.radLabelElement1, False)
			Me.radLabelElement1.Text = "English (US)"
			Me.radLabelElement1.TextWrap = True
			Me.radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' CommandBarSeparator2
			' 
			Me.CommandBarSeparator2.Margin = New Padding(1)
			Me.CommandBarSeparator2.MinSize = New Size(2, 17)
			Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
			Me.radStatusBar1.SetSpring(Me.CommandBarSeparator2, False)
			Me.CommandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.CommandBarSeparator2.VisibleInOverflowMenu = False
			' 
			' radSplitButtonElement1
			' 
			Me.radSplitButtonElement1.AccessibleDescription = "Zoom"
			Me.radSplitButtonElement1.AccessibleName = "Zoom"
			Me.radSplitButtonElement1.ArrowButtonMinSize = New Size(12, 12)
			Me.radSplitButtonElement1.DefaultItem = Nothing
			Me.radSplitButtonElement1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radSplitButtonElement1.ExpandArrowButton = False
			Me.radSplitButtonElement1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem9, Me.radMenuItem10})
			Me.radSplitButtonElement1.Margin = New Padding(0)
			Me.radSplitButtonElement1.Name = "radSplitButtonElement1"
			Me.radStatusBar1.SetSpring(Me.radSplitButtonElement1, False)
			Me.radSplitButtonElement1.Text = "Zoom"
			Me.radSplitButtonElement1.TextImageRelation = TextImageRelation.Overlay
			Me.radSplitButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.AccessibleDescription = "50%"
			Me.radMenuItem1.AccessibleName = "50%"
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "50%"
			Me.radMenuItem1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.AccessibleDescription = "75%"
			Me.radMenuItem2.AccessibleName = "75%"
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "75%"
			Me.radMenuItem2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.AccessibleDescription = "100%"
			Me.radMenuItem9.AccessibleName = "100%"
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "100%"
			Me.radMenuItem9.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.AccessibleDescription = "200%"
			Me.radMenuItem10.AccessibleName = "200%"
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Text = "200%"
			Me.radMenuItem10.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem10.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' CommandBarSeparator1
			' 
			Me.CommandBarSeparator1.MinSize = New Size(2, 17)
			Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
			Me.radStatusBar1.SetSpring(Me.CommandBarSeparator1, False)
			Me.CommandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.CommandBarSeparator1.VisibleInOverflowMenu = False
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.AccessibleDescription = "radMenuItem3"
			Me.radMenuItem3.AccessibleName = "radMenuItem3"
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "radMenuItem3"
			Me.radMenuItem3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.AccessibleDescription = "radMenuItem4"
			Me.radMenuItem4.AccessibleName = "radMenuItem4"
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "radMenuItem4"
			Me.radMenuItem4.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.AccessibleDescription = "radMenuItem5"
			Me.radMenuItem5.AccessibleName = "radMenuItem5"
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "radMenuItem5"
			Me.radMenuItem5.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.AccessibleDescription = "radMenuItem6"
			Me.radMenuItem6.AccessibleName = "radMenuItem6"
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Text = "radMenuItem6"
			Me.radMenuItem6.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.AccessibleDescription = "radMenuItem7"
			Me.radMenuItem7.AccessibleName = "radMenuItem7"
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "radMenuItem7"
			Me.radMenuItem7.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.AccessibleDescription = "radMenuItem8"
			Me.radMenuItem8.AccessibleName = "radMenuItem8"
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "radMenuItem8"
			Me.radMenuItem8.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 1000

			' 
			' radLabel1
			' 
			Me.radLabel1.AutoSize = False
			Me.radLabel1.BackColor = Color.Transparent
			Me.radLabel1.Dock = DockStyle.Fill
			Me.radLabel1.Font = New Font("Tahoma", 10F)
			Me.radLabel1.Location = New Point(0, 0)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(631, 217)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = resources.GetString("radLabel1.Text")
			Me.radLabel1.TextAlignment = ContentAlignment.MiddleLeft
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.ClientSize = New Size(731, 343)
			Me.Controls.Add(Me.radLabel1)
			Me.Controls.Add(Me.radStatusBar1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "RadStatusStrip Example"
			CType(Me.radStatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radStatusBar1 As Telerik.WinControls.UI.RadStatusStrip
		Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
		Private radProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
		Private CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
		Private CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
		Private timer1 As Timer
		Private radSplitButtonElement1 As Telerik.WinControls.UI.RadSplitButtonElement
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radLabelElement1 As Telerik.WinControls.UI.RadLabelElement
		Private CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem10 As Telerik.WinControls.UI.RadMenuItem
		Private radLabelElement2 As Telerik.WinControls.UI.RadLabelElement
		Private CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
		Private radLabelElement3 As Telerik.WinControls.UI.RadLabelElement
		Private CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCheckBoxElement1 As Telerik.WinControls.UI.RadCheckBoxElement
		Private roundRectShape1 As Telerik.WinControls.RoundRectShape
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace