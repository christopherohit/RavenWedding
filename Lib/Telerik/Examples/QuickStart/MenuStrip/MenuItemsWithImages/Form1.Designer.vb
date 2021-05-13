Namespace Telerik.Examples.WinControls.MenuStrip.MenuItemsWithImages
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
			Me.imageList1 = New ImageList(Me.components)
			Me.radMenuDemo = New Telerik.WinControls.UI.RadMenu()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem1_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem1_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem8 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem2_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radPanelDemoHolder = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 735)

			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "CloseSolution.bmp")
			Me.imageList1.Images.SetKeyName(6, "System.Windows.Forms.ContextMenu.bmp")
			Me.imageList1.Images.SetKeyName(7, "System.Windows.Forms.CheckedListBox.bmp")
			Me.imageList1.Images.SetKeyName(8, "System.Windows.Forms.ColorDialog.bmp")
			Me.imageList1.Images.SetKeyName(9, "System.Windows.Forms.ComboBox.bmp")
			Me.imageList1.Images.SetKeyName(10, "icon1.png")
			Me.imageList1.Images.SetKeyName(11, "icon2.png")
			Me.imageList1.Images.SetKeyName(12, "icon3.png")
			Me.imageList1.Images.SetKeyName(13, "icon4.png")
			' 
			' radMenuDemo
			' 
			Me.radMenuDemo.AllItemsEqualHeight = True
			Me.radMenuDemo.AllowMerge = False
			Me.radMenuDemo.BackColor = Color.Transparent
			Me.radMenuDemo.ForeColor = Color.Black
			Me.radMenuDemo.ImageList = Me.imageList1
			Me.radMenuDemo.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3, Me.radMenuItem4})
			Me.radMenuDemo.Location = New Point(1, 1)
			Me.radMenuDemo.Name = "radMenuDemo"
			' 
			' 
			' 
			Me.radMenuDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenuDemo.Size = New Size(499, 71)
			Me.radMenuDemo.TabIndex = 0
			Me.radMenuDemo.Text = "radMenu1"

			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.AccessibleDescription = "RadCalendar"
			Me.radMenuItem1.AccessibleName = "RadCalendar"
			Me.radMenuItem1.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem1.Image = (CType(resources.GetObject("radMenuItem1.Image"), Image))
			Me.radMenuItem1.ImageAlignment = ContentAlignment.MiddleCenter
			Me.radMenuItem1.ImageIndex = 10
			Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1_1, Me.radMenuItem1_2, Me.radMenuSeparatorItem1, Me.radMenuItem1_3, Me.radMenuSeparatorItem2, Me.radMenuItem1_4})
			Me.radMenuItem1.MinSize = New Size(80, 0)
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Padding = New Padding(2)
			Me.radMenuItem1.ShowArrow = False
			Me.radMenuItem1.Text = "RadCalendar"
			Me.radMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText
			Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_1
			' 
			Me.radMenuItem1_1.AccessibleDescription = "Features"
			Me.radMenuItem1_1.AccessibleName = "Features"
			Me.radMenuItem1_1.MinSize = New Size(180, 25)
			Me.radMenuItem1_1.Name = "radMenuItem1_1"
			Me.radMenuItem1_1.Text = "Features"
			Me.radMenuItem1_1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_2
			' 
			Me.radMenuItem1_2.AccessibleDescription = "Product Overview"
			Me.radMenuItem1_2.AccessibleName = "Product Overview"
			Me.radMenuItem1_2.Name = "radMenuItem1_2"
			Me.radMenuItem1_2.Text = "Product Overview"
			Me.radMenuItem1_2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.AutoSize = False
			Me.radMenuSeparatorItem1.Bounds = New Rectangle(0, 47, 154, 1)
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.PositionOffset = New SizeF(26F, 0F)
			Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_3
			' 
			Me.radMenuItem1_3.AccessibleDescription = "Version History"
			Me.radMenuItem1_3.AccessibleName = "Version History"
			Me.radMenuItem1_3.Name = "radMenuItem1_3"
			Me.radMenuItem1_3.Text = "Version History"
			Me.radMenuItem1_3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.AutoSize = False
			Me.radMenuSeparatorItem2.Bounds = New Rectangle(0, 70, 154, 1)
			Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.PositionOffset = New SizeF(26F, 0F)
			Me.radMenuSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_4
			' 
			Me.radMenuItem1_4.AccessibleDescription = "Close"
			Me.radMenuItem1_4.AccessibleName = "Close"
			Me.radMenuItem1_4.Name = "radMenuItem1_4"
			Me.radMenuItem1_4.Text = "Close"
			Me.radMenuItem1_4.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.AccessibleDescription = "RadUpload"
			Me.radMenuItem2.AccessibleName = "RadUpload"
			Me.radMenuItem2.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem2.Image = (CType(resources.GetObject("radMenuItem2.Image"), Image))
			Me.radMenuItem2.ImageAlignment = ContentAlignment.MiddleCenter
			Me.radMenuItem2.ImageIndex = 11
			Me.radMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem2_1, Me.radMenuItem2_2, Me.radMenuSeparatorItem8, Me.radMenuItem2_3, Me.radMenuItem2_4})
			Me.radMenuItem2.MinSize = New Size(80, 0)
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Padding = New Padding(2)
			Me.radMenuItem2.ShowArrow = False
			Me.radMenuItem2.Text = "RadUpload"
			Me.radMenuItem2.TextImageRelation = TextImageRelation.ImageAboveText
			Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2_1
			' 
			Me.radMenuItem2_1.AccessibleDescription = "Product Overview"
			Me.radMenuItem2_1.AccessibleName = "Product Overview"
			Me.radMenuItem2_1.Name = "radMenuItem2_1"
			Me.radMenuItem2_1.Text = "Product Overview"
			Me.radMenuItem2_1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2_1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2_2
			' 
			Me.radMenuItem2_2.AccessibleDescription = "Features"
			Me.radMenuItem2_2.AccessibleName = "Features"
			Me.radMenuItem2_2.Name = "radMenuItem2_2"
			Me.radMenuItem2_2.Text = "Features"
			Me.radMenuItem2_2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2_2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem8
			' 
			Me.radMenuSeparatorItem8.Name = "radMenuSeparatorItem8"
			Me.radMenuSeparatorItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2_3
			' 
			Me.radMenuItem2_3.AccessibleDescription = "Benefits"
			Me.radMenuItem2_3.AccessibleName = "Benefits"
			Me.radMenuItem2_3.Name = "radMenuItem2_3"
			Me.radMenuItem2_3.Text = "Benefits"
			Me.radMenuItem2_3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2_3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2_4
			' 
			Me.radMenuItem2_4.AccessibleDescription = "Comparison Sheet"
			Me.radMenuItem2_4.AccessibleName = "Comparison Sheet"
			Me.radMenuItem2_4.Name = "radMenuItem2_4"
			Me.radMenuItem2_4.Text = "Comparison Sheet"
			Me.radMenuItem2_4.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2_4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.AccessibleDescription = "RadMenu"
			Me.radMenuItem3.AccessibleName = "RadMenu"
			Me.radMenuItem3.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem3.Image = (CType(resources.GetObject("radMenuItem3.Image"), Image))
			Me.radMenuItem3.ImageAlignment = ContentAlignment.MiddleCenter
			Me.radMenuItem3.ImageIndex = 12
			Me.radMenuItem3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem3_1, Me.radMenuItem3_2, Me.radMenuItem3_3, Me.radMenuItem3_4})
			Me.radMenuItem3.MinSize = New Size(80, 0)
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Padding = New Padding(2)
			Me.radMenuItem3.ShowArrow = False
			Me.radMenuItem3.Text = "RadMenu"
			Me.radMenuItem3.TextImageRelation = TextImageRelation.ImageAboveText
			Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3_1
			' 
			Me.radMenuItem3_1.AccessibleDescription = "Product Overview"
			Me.radMenuItem3_1.AccessibleName = "Product Overview"
			Me.radMenuItem3_1.Name = "radMenuItem3_1"
			Me.radMenuItem3_1.Text = "Product Overview"
			Me.radMenuItem3_1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem3_1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3_2
			' 
			Me.radMenuItem3_2.AccessibleDescription = "Features"
			Me.radMenuItem3_2.AccessibleName = "Features"
			Me.radMenuItem3_2.Name = "radMenuItem3_2"
			Me.radMenuItem3_2.Text = "Features"
			Me.radMenuItem3_2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem3_2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3_3
			' 
			Me.radMenuItem3_3.AccessibleDescription = "Comparison Sheets"
			Me.radMenuItem3_3.AccessibleName = "Comparison Sheets"
			Me.radMenuItem3_3.Name = "radMenuItem3_3"
			Me.radMenuItem3_3.Text = "Comparison Sheets"
			Me.radMenuItem3_3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem3_3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3_4
			' 
			Me.radMenuItem3_4.AccessibleDescription = "Benefits"
			Me.radMenuItem3_4.AccessibleName = "Benefits"
			Me.radMenuItem3_4.Name = "radMenuItem3_4"
			Me.radMenuItem3_4.Text = "Benefits"
			Me.radMenuItem3_4.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem3_4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.AccessibleDescription = "RadGrid"
			Me.radMenuItem4.AccessibleName = "RadGrid"
			Me.radMenuItem4.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem4.Image = (CType(resources.GetObject("radMenuItem4.Image"), Image))
			Me.radMenuItem4.ImageAlignment = ContentAlignment.MiddleCenter
			Me.radMenuItem4.ImageIndex = 13
			Me.radMenuItem4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem4_1, Me.radMenuItem4_2, Me.radMenuItem4_3})
			Me.radMenuItem4.MinSize = New Size(80, 0)
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Padding = New Padding(2)
			Me.radMenuItem4.ShowArrow = False
			Me.radMenuItem4.Text = "RadGrid"
			Me.radMenuItem4.TextImageRelation = TextImageRelation.ImageAboveText
			Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4_1
			' 
			Me.radMenuItem4_1.AccessibleDescription = "Product Overview"
			Me.radMenuItem4_1.AccessibleName = "Product Overview"
			Me.radMenuItem4_1.Name = "radMenuItem4_1"
			Me.radMenuItem4_1.Text = "Product Overview"
			Me.radMenuItem4_1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem4_1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4_2
			' 
			Me.radMenuItem4_2.AccessibleDescription = "Features"
			Me.radMenuItem4_2.AccessibleName = "Features"
			Me.radMenuItem4_2.Name = "radMenuItem4_2"
			Me.radMenuItem4_2.Text = "Features"
			Me.radMenuItem4_2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem4_2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4_3
			' 
			Me.radMenuItem4_3.AccessibleDescription = "Comparison Sheet"
			Me.radMenuItem4_3.AccessibleName = "Comparison Sheet"
			Me.radMenuItem4_3.Name = "radMenuItem4_3"
			Me.radMenuItem4_3.Text = "Comparison Sheet"
			Me.radMenuItem4_3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem4_3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radMenuDemo)
            Me.radPanelDemoHolder.Location = New Point(20, 20)
			Me.radPanelDemoHolder.Name = "radPanelDemoHolder"
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.Padding = New Padding(1, 1, 0, 0)
			Me.radPanelDemoHolder.Size = New Size(500, 350)
			Me.radPanelDemoHolder.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radPanelDemoHolder)
			Me.MaximumSize = New Size(1280, 994)
			Me.Name = "Form1"
			Me.Size = New Size(1170, 671)
			Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region


		Private radMenuDemo As Telerik.WinControls.UI.RadMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_4 As Telerik.WinControls.UI.RadMenuItem

		Private radMenuItem2_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_4 As Telerik.WinControls.UI.RadMenuItem

		Private radMenuItem3_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_4 As Telerik.WinControls.UI.RadMenuItem

		Private radMenuItem4_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_3 As Telerik.WinControls.UI.RadMenuItem
		Private imageList1 As ImageList
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem8 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radPanelDemoHolder As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace