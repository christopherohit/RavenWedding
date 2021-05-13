Namespace Telerik.Examples.WinControls.MenuStrip.MenuWithHeaderColumn
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radMenuDemo = New Telerik.WinControls.UI.RadMenu()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 818)

			' 
			' radMenuDemo
			' 
			Me.radMenuDemo.ForeColor = Color.Black
			Me.radMenuDemo.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem7})
			Me.radMenuDemo.Location = New Point(0, 0)
			Me.radMenuDemo.Name = "radMenuDemo"
			Me.radMenuDemo.Size = New Size(500, 20)
			Me.radMenuDemo.TabIndex = 0
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.AccessibleDescription = "File"
			Me.radMenuItem1.AccessibleName = "File"
			Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem2, Me.radMenuItem3, Me.radMenuItem4, Me.radMenuItem5, Me.radMenuSeparatorItem1, Me.radMenuItem6, Me.radMenuSeparatorItem2, Me.radMenuItem10})
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.ShowArrow = False
			Me.radMenuItem1.Text = "File"
			Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.AccessibleDescription = "New"
			Me.radMenuItem2.AccessibleName = "New"
			Me.radMenuItem2.Image = My.Resources.RibbonMenuNewMagenta
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Padding = New Padding(-3)
			Me.radMenuItem2.Text = "New"
			Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.AccessibleDescription = "Open"
			Me.radMenuItem3.AccessibleName = "Open"
			Me.radMenuItem3.Image = My.Resources.RibbonMenuOpenMagenta
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Padding = New Padding(-3)
			Me.radMenuItem3.Text = "Open"
			Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.AccessibleDescription = "Save"
			Me.radMenuItem4.AccessibleName = "Save"
			Me.radMenuItem4.Image = My.Resources.RibbonMenuSaveMagenta
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Padding = New Padding(-3)
			Me.radMenuItem4.Text = "Save"
			Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.AccessibleDescription = "Save As"
			Me.radMenuItem5.AccessibleName = "Save As"
			Me.radMenuItem5.Image = My.Resources.RibbonMenuSaveAsMagenta
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Padding = New Padding(-3)
			Me.radMenuItem5.Text = "Save As"
			Me.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.AccessibleDescription = "New item"
			Me.radMenuSeparatorItem1.AccessibleName = "New item"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "New item"
			Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.AccessibleDescription = "Print"
			Me.radMenuItem6.AccessibleName = "Print"
			Me.radMenuItem6.Image = My.Resources._5RibbonbarMenuPrintMagenta
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Padding = New Padding(-3)
			Me.radMenuItem6.Text = "Print"
			Me.radMenuItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.AccessibleDescription = "New item"
			Me.radMenuSeparatorItem2.AccessibleName = "New item"
			Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Text = "New item"
			Me.radMenuSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.AccessibleDescription = "Exit"
			Me.radMenuItem10.AccessibleName = "Exit"
			Me.radMenuItem10.Image = My.Resources._9RibbonMenuCloseMagenta
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Padding = New Padding(-3)
			Me.radMenuItem10.Text = "Exit"
			Me.radMenuItem10.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.AccessibleDescription = "Edit"
			Me.radMenuItem7.AccessibleName = "Edit"
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.ShowArrow = False
			Me.radMenuItem7.Text = "Edit"
			Me.radMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radMenuDemo)
            Me.radPanel1.Location = New Point(20, 20)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(500, 350)
			Me.radPanel1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1542, 1000)

			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radMenuDemo As Telerik.WinControls.UI.RadMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem10 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace
