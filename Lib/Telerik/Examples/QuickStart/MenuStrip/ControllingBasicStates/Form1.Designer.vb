Namespace Telerik.Examples.WinControls.MenuStrip.ControllingBasicStates
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
			Me.radMenuDemo = New Telerik.WinControls.UI.RadMenu()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem11 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem14 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem15 = New Telerik.WinControls.UI.RadMenuItem()
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
			Me.radMenuDemo.AllowMerge = False
			Me.radMenuDemo.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3})
			Me.radMenuDemo.Location = New Point(0, 0)
			Me.radMenuDemo.Name = "radMenuDemo"
			' 
			' 
			' 
			Me.radMenuDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenuDemo.Size = New Size(600, 20)
			Me.radMenuDemo.TabIndex = 0
			Me.radMenuDemo.Text = "radMenu1"
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.AccessibleDescription = "Add items at runtime"
			Me.radMenuItem1.AccessibleName = "Add items at runtime"
			Me.radMenuItem1.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem4, Me.radMenuItem5, Me.radMenuItem6, Me.radMenuItem7, Me.radMenuSeparatorItem1})
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.ShowArrow = False
			Me.radMenuItem1.Text = "Add items at runtime"
			Me.radMenuItem1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.AccessibleDescription = "Add a new Text file"
			Me.radMenuItem4.AccessibleName = "Add a new Text file"
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "Add a new Text file"
			Me.radMenuItem4.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.AccessibleDescription = "Add a new XML file"
			Me.radMenuItem5.AccessibleName = "Add a new XML file"
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "Add a new XML file"
			Me.radMenuItem5.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.AccessibleDescription = "Add a new Project"
			Me.radMenuItem6.AccessibleName = "Add a new Project"
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Text = "Add a new Project"
			Me.radMenuItem6.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.AccessibleDescription = "Add a new Solution"
			Me.radMenuItem7.AccessibleName = "Add a new Solution"
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "Add a new Solution"
			Me.radMenuItem7.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.AccessibleDescription = "Remove items at runtime"
			Me.radMenuItem2.AccessibleName = "Remove items at runtime"
			Me.radMenuItem2.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem8, Me.radMenuItem9, Me.radMenuItem10, Me.radMenuItem11})
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.ShowArrow = False
			Me.radMenuItem2.Text = "Remove items at runtime"
			Me.radMenuItem2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.AccessibleDescription = "Remove this Text file"
			Me.radMenuItem8.AccessibleName = "Remove this Text file"
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "Remove this Text file"
			Me.radMenuItem8.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.AccessibleDescription = "Remove this XML file"
			Me.radMenuItem9.AccessibleName = "Remove this XML file"
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "Remove this XML file"
			Me.radMenuItem9.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.AccessibleDescription = "Remove this Project"
			Me.radMenuItem10.AccessibleName = "Remove this Project"
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Text = "Remove this Project"
			Me.radMenuItem10.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem10.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem11
			' 
			Me.radMenuItem11.AccessibleDescription = "Remove this Solution"
			Me.radMenuItem11.AccessibleName = "Remove this Solution"
			Me.radMenuItem11.Name = "radMenuItem11"
			Me.radMenuItem11.Text = "Remove this Solution"
			Me.radMenuItem11.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem11.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.AccessibleDescription = "Disable items at runtime"
			Me.radMenuItem3.AccessibleName = "Disable items at runtime"
			Me.radMenuItem3.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem12, Me.radMenuItem13, Me.radMenuItem14, Me.radMenuItem15})
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.ShowArrow = False
			Me.radMenuItem3.Text = "Disable items at runtime"
			Me.radMenuItem3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem12
			' 
			Me.radMenuItem12.AccessibleDescription = "Disable this Text file"
			Me.radMenuItem12.AccessibleName = "Disable this Text file"
			Me.radMenuItem12.Name = "radMenuItem12"
			Me.radMenuItem12.Text = "Disable this Text file"
			Me.radMenuItem12.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem12.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem13
			' 
			Me.radMenuItem13.AccessibleDescription = "Disable this XML file"
			Me.radMenuItem13.AccessibleName = "Disable this XML file"
			Me.radMenuItem13.Name = "radMenuItem13"
			Me.radMenuItem13.Text = "Disable this XML file"
			Me.radMenuItem13.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem13.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem14
			' 
			Me.radMenuItem14.AccessibleDescription = "Disable this Project"
			Me.radMenuItem14.AccessibleName = "Disable this Project"
			Me.radMenuItem14.Name = "radMenuItem14"
			Me.radMenuItem14.Text = "Disable this Project"
			Me.radMenuItem14.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem14.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem15
			' 
			Me.radMenuItem15.AccessibleDescription = "Disable this Solution"
			Me.radMenuItem15.AccessibleName = "Disable this Solution"
			Me.radMenuItem15.Name = "radMenuItem15"
			Me.radMenuItem15.Text = "Disable this Solution"
			Me.radMenuItem15.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem15.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radMenuDemo)
            Me.radPanel1.Location = New Point(20, 20)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(600, 350)
			Me.radPanel1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radPanel1)
			Me.MaximumSize = New Size(1280, 994)
			Me.Name = "Form1"
			Me.Size = New Size(1170, 754)
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
		Private radMenuItem6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem10 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem11 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem12 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem13 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem14 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem15 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace