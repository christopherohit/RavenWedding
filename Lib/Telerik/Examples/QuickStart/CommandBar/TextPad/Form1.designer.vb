Namespace Telerik.Examples.WinControls.CommandBar.TextPad
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim radListDataItem13 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem14 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem15 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem16 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem17 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem18 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem19 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem20 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem21 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem22 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem23 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem24 As New Telerik.WinControls.UI.RadListDataItem()
			Me.pictureBox1 = New PictureBox()
			Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
			Me.radCommandBarLineElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
			Me.radCommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
			Me.radCommandBarButtonItem1 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem2 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem3 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem4 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem5 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarSeparatorItem1 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarButtonItem6 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem7 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem8 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarSeparatorItem2 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarButtonItem9 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem10 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarLineElement2 = New Telerik.WinControls.UI.CommandBarRowElement()
			Me.radCommandBarStripElement2 = New Telerik.WinControls.UI.CommandBarStripElement()
			Me.radCommandBarToggleButtonItem1 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem2 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem3 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarSeparatorItem3 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarDropDownListItem1 = New Telerik.WinControls.UI.CommandBarDropDownList()
			Me.radCommandBarDropDownListItem2 = New Telerik.WinControls.UI.CommandBarDropDownList()
			Me.radCommandBarSeparatorItem4 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarToggleButtonItem4 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem5 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem6 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem7 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarSeparatorItem5 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarToggleButtonItem8 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem9 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.panel1 = New Panel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1179, 1)
			Me.settingsPanel.Size = New Size(2785, 2246)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch
			Me.pictureBox1.Image = My.Resources.WordExample_bg
			Me.pictureBox1.Location = New Point(-7, -1)
			Me.pictureBox1.Margin = New Padding(4, 4, 4, 4)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Size(863, 411)
			Me.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' radCommandBar1
			' 
			Me.radCommandBar1.Location = New Point(5, 69)
			Me.radCommandBar1.Margin = New Padding(4, 4, 4, 4)
			Me.radCommandBar1.Name = "radCommandBar1"
			Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() { Me.radCommandBarLineElement1, Me.radCommandBarLineElement2})
			Me.radCommandBar1.Size = New Size(832, 83)
			Me.radCommandBar1.TabIndex = 1
			' 
			' radCommandBarLineElement1
			' 
			Me.radCommandBarLineElement1.BorderLeftShadowColor = Color.Empty
			Me.radCommandBarLineElement1.DisplayName = Nothing
			Me.radCommandBarLineElement1.MinSize = New Size(33, 31)
			Me.radCommandBarLineElement1.Name = "radCommandBarLineElement1"
			Me.radCommandBarLineElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() { Me.radCommandBarStripElement1})
			Me.radCommandBarLineElement1.Text = ""
			' 
			' radCommandBarStripElement1
			' 
			Me.radCommandBarStripElement1.DisplayName = "Commands Strip"
			Me.radCommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.radCommandBarButtonItem1, Me.radCommandBarButtonItem2, Me.radCommandBarButtonItem3, Me.radCommandBarButtonItem4, Me.radCommandBarButtonItem5, Me.radCommandBarSeparatorItem1, Me.radCommandBarButtonItem6, Me.radCommandBarButtonItem7, Me.radCommandBarButtonItem8, Me.radCommandBarSeparatorItem2, Me.radCommandBarButtonItem9, Me.radCommandBarButtonItem10})
			Me.radCommandBarStripElement1.Name = "radCommandBarStripElement1"
			Me.radCommandBarStripElement1.OverflowMenuMaxSize = New Size(360, 0)
			Me.radCommandBarStripElement1.OverflowMenuMinSize = New Size(67, 31)
			Me.radCommandBarStripElement1.Text = ""
			' 
			' radCommandBarButtonItem1
			' 
			Me.radCommandBarButtonItem1.DisplayName = "New File Button"
			Me.radCommandBarButtonItem1.Image = (CType(resources.GetObject("radCommandBarButtonItem1.Image"), Image))
			Me.radCommandBarButtonItem1.Name = "radCommandBarButtonItem1"
			Me.radCommandBarButtonItem1.Text = "radCommandBarButtonItem1"
			' 
			' radCommandBarButtonItem2
			' 
			Me.radCommandBarButtonItem2.DisplayName = "Open File Button"
			Me.radCommandBarButtonItem2.Image = (CType(resources.GetObject("radCommandBarButtonItem2.Image"), Image))
			Me.radCommandBarButtonItem2.Name = "radCommandBarButtonItem2"
			Me.radCommandBarButtonItem2.Text = "radCommandBarButtonItem2"
			' 
			' radCommandBarButtonItem3
			' 
			Me.radCommandBarButtonItem3.DisplayName = "Save File Button"
			Me.radCommandBarButtonItem3.Image = (CType(resources.GetObject("radCommandBarButtonItem3.Image"), Image))
			Me.radCommandBarButtonItem3.Name = "radCommandBarButtonItem3"
			Me.radCommandBarButtonItem3.Text = "radCommandBarButtonItem3"
			' 
			' radCommandBarButtonItem4
			' 
			Me.radCommandBarButtonItem4.DisplayName = "Undo Button"
			Me.radCommandBarButtonItem4.Image = (CType(resources.GetObject("radCommandBarButtonItem4.Image"), Image))
			Me.radCommandBarButtonItem4.Name = "radCommandBarButtonItem4"
			Me.radCommandBarButtonItem4.Text = "radCommandBarButtonItem4"
			' 
			' radCommandBarButtonItem5
			' 
			Me.radCommandBarButtonItem5.DisplayName = "Redo Button"
			Me.radCommandBarButtonItem5.Image = (CType(resources.GetObject("radCommandBarButtonItem5.Image"), Image))
			Me.radCommandBarButtonItem5.Name = "radCommandBarButtonItem5"
			Me.radCommandBarButtonItem5.Text = "radCommandBarButtonItem5"
			' 
			' radCommandBarSeparatorItem1
			' 
			Me.radCommandBarSeparatorItem1.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem1.Name = "radCommandBarSeparatorItem1"
			Me.radCommandBarSeparatorItem1.VisibleInOverflowMenu = False
			' 
			' radCommandBarButtonItem6
			' 
			Me.radCommandBarButtonItem6.DisplayName = "Cut Button"
			Me.radCommandBarButtonItem6.Image = (CType(resources.GetObject("radCommandBarButtonItem6.Image"), Image))
			Me.radCommandBarButtonItem6.Name = "radCommandBarButtonItem6"
			Me.radCommandBarButtonItem6.Text = "radCommandBarButtonItem6"
			' 
			' radCommandBarButtonItem7
			' 
			Me.radCommandBarButtonItem7.DisplayName = "Copy Button"
			Me.radCommandBarButtonItem7.Image = (CType(resources.GetObject("radCommandBarButtonItem7.Image"), Image))
			Me.radCommandBarButtonItem7.Name = "radCommandBarButtonItem7"
			Me.radCommandBarButtonItem7.Text = "radCommandBarButtonItem7"
			' 
			' radCommandBarButtonItem8
			' 
			Me.radCommandBarButtonItem8.DisplayName = "Paste Button"
			Me.radCommandBarButtonItem8.Image = (CType(resources.GetObject("radCommandBarButtonItem8.Image"), Image))
			Me.radCommandBarButtonItem8.Name = "radCommandBarButtonItem8"
			Me.radCommandBarButtonItem8.Text = "radCommandBarButtonItem8"
			' 
			' radCommandBarSeparatorItem2
			' 
			Me.radCommandBarSeparatorItem2.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem2.Name = "radCommandBarSeparatorItem2"
			Me.radCommandBarSeparatorItem2.VisibleInOverflowMenu = False
			' 
			' radCommandBarButtonItem9
			' 
			Me.radCommandBarButtonItem9.DisplayName = "Print Button"
			Me.radCommandBarButtonItem9.Image = (CType(resources.GetObject("radCommandBarButtonItem9.Image"), Image))
			Me.radCommandBarButtonItem9.Name = "radCommandBarButtonItem9"
			Me.radCommandBarButtonItem9.Text = "radCommandBarButtonItem9"
			' 
			' radCommandBarButtonItem10
			' 
			Me.radCommandBarButtonItem10.DisplayName = "Print Preview Button"
			Me.radCommandBarButtonItem10.Image = (CType(resources.GetObject("radCommandBarButtonItem10.Image"), Image))
			Me.radCommandBarButtonItem10.Name = "radCommandBarButtonItem10"
			Me.radCommandBarButtonItem10.Text = "radCommandBarButtonItem10"
			' 
			' radCommandBarLineElement2
			' 
			Me.radCommandBarLineElement2.DisplayName = Nothing
			Me.radCommandBarLineElement2.MinSize = New Size(33, 31)
			Me.radCommandBarLineElement2.Name = "radCommandBarLineElement2"
			Me.radCommandBarLineElement2.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() { Me.radCommandBarStripElement2})
			' 
			' radCommandBarStripElement2
			' 
			Me.radCommandBarStripElement2.DisplayName = "Text Style Strip"
			Me.radCommandBarStripElement2.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.radCommandBarToggleButtonItem1, Me.radCommandBarToggleButtonItem2, Me.radCommandBarToggleButtonItem3, Me.radCommandBarSeparatorItem3, Me.radCommandBarDropDownListItem1, Me.radCommandBarDropDownListItem2, Me.radCommandBarSeparatorItem4, Me.radCommandBarToggleButtonItem4, Me.radCommandBarToggleButtonItem5, Me.radCommandBarToggleButtonItem6, Me.radCommandBarToggleButtonItem7, Me.radCommandBarSeparatorItem5, Me.radCommandBarToggleButtonItem8, Me.radCommandBarToggleButtonItem9})
			Me.radCommandBarStripElement2.Name = "radCommandBarStripElement2"
			Me.radCommandBarStripElement2.OverflowMenuMaxSize = New Size(360, 0)
			Me.radCommandBarStripElement2.OverflowMenuMinSize = New Size(67, 31)
			Me.radCommandBarStripElement2.Text = ""
			' 
			' radCommandBarToggleButtonItem1
			' 
			Me.radCommandBarToggleButtonItem1.DisplayName = "Bold Toggle Button"
			Me.radCommandBarToggleButtonItem1.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem1.Image"), Image))
			Me.radCommandBarToggleButtonItem1.Name = "radCommandBarToggleButtonItem1"
			Me.radCommandBarToggleButtonItem1.Text = "radCommandBarToggleButtonItem1"
			' 
			' radCommandBarToggleButtonItem2
			' 
			Me.radCommandBarToggleButtonItem2.DisplayName = "Italic Toggle Button"
			Me.radCommandBarToggleButtonItem2.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem2.Image"), Image))
			Me.radCommandBarToggleButtonItem2.Name = "radCommandBarToggleButtonItem2"
			Me.radCommandBarToggleButtonItem2.Text = "radCommandBarToggleButtonItem2"
			' 
			' radCommandBarToggleButtonItem3
			' 
			Me.radCommandBarToggleButtonItem3.DisplayName = "Underline Toggle Button"
			Me.radCommandBarToggleButtonItem3.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem3.Image"), Image))
			Me.radCommandBarToggleButtonItem3.Name = "radCommandBarToggleButtonItem3"
			Me.radCommandBarToggleButtonItem3.Text = "radCommandBarToggleButtonItem3"
			' 
			' radCommandBarSeparatorItem3
			' 
			Me.radCommandBarSeparatorItem3.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem3.Name = "radCommandBarSeparatorItem3"
			Me.radCommandBarSeparatorItem3.VisibleInOverflowMenu = False
			' 
			' radCommandBarDropDownListItem1
			' 
			Me.radCommandBarDropDownListItem1.DisplayName = "Font Family Dropdown"
			Me.radCommandBarDropDownListItem1.DropDownAnimationEnabled = True
            Me.radCommandBarDropDownListItem1.DropDownHeight = 141
			radListDataItem13.Text = "Arial"
			radListDataItem14.Text = "Tahoma"
			radListDataItem15.Text = "Verdana"
			radListDataItem16.Text = "Times New Roman"
			radListDataItem17.Text = "Segoe UI"
			Me.radCommandBarDropDownListItem1.Items.Add(radListDataItem13)
			Me.radCommandBarDropDownListItem1.Items.Add(radListDataItem14)
			Me.radCommandBarDropDownListItem1.Items.Add(radListDataItem15)
			Me.radCommandBarDropDownListItem1.Items.Add(radListDataItem16)
			Me.radCommandBarDropDownListItem1.Items.Add(radListDataItem17)
			Me.radCommandBarDropDownListItem1.Margin = New Padding(0, 0, 3, 0)
            Me.radCommandBarDropDownListItem1.MaxDropDownItems = 0
            Me.radCommandBarDropDownListItem1.MinSize = New System.Drawing.Size(200, 0)
            Me.radCommandBarDropDownListItem1.Name = "radCommandBarDropDownListItem1"
            Me.radCommandBarDropDownListItem1.Text = "Arial"
			' 
			' radCommandBarDropDownListItem2
			' 
			Me.radCommandBarDropDownListItem2.DisplayName = "Font Size Dropdown"
			Me.radCommandBarDropDownListItem2.DropDownAnimationEnabled = True
			Me.radCommandBarDropDownListItem2.DropDownHeight = 141
			radListDataItem18.Text = "8"
			radListDataItem19.Text = "10"
			radListDataItem20.Text = "12"
			radListDataItem21.Text = "16"
			radListDataItem22.Text = "18"
			radListDataItem23.Text = "22"
			radListDataItem24.Text = "24"
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem18)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem19)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem20)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem21)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem22)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem23)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem24)
            Me.radCommandBarDropDownListItem2.MaxDropDownItems = 0
            Me.radCommandBarDropDownListItem2.MinSize = New System.Drawing.Size(100, 0)
            Me.radCommandBarDropDownListItem2.Name = "radCommandBarDropDownListItem2"
            Me.radCommandBarDropDownListItem2.Text = "12"
			' 
			' radCommandBarSeparatorItem4
			' 
			Me.radCommandBarSeparatorItem4.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem4.Name = "radCommandBarSeparatorItem4"
			Me.radCommandBarSeparatorItem4.VisibleInOverflowMenu = False
			' 
			' radCommandBarToggleButtonItem4
			' 
			Me.radCommandBarToggleButtonItem4.DisplayName = "Left Align Button"
			Me.radCommandBarToggleButtonItem4.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem4.Image"), Image))
			Me.radCommandBarToggleButtonItem4.Name = "radCommandBarToggleButtonItem4"
			Me.radCommandBarToggleButtonItem4.Text = "radCommandBarToggleButtonItem4"
			' 
			' radCommandBarToggleButtonItem5
			' 
			Me.radCommandBarToggleButtonItem5.DisplayName = "Center Align Button"
			Me.radCommandBarToggleButtonItem5.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem5.Image"), Image))
			Me.radCommandBarToggleButtonItem5.Name = "radCommandBarToggleButtonItem5"
			Me.radCommandBarToggleButtonItem5.Text = "radCommandBarToggleButtonItem5"
			' 
			' radCommandBarToggleButtonItem6
			' 
			Me.radCommandBarToggleButtonItem6.DisplayName = "Right Align Button"
			Me.radCommandBarToggleButtonItem6.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem6.Image"), Image))
			Me.radCommandBarToggleButtonItem6.Name = "radCommandBarToggleButtonItem6"
			Me.radCommandBarToggleButtonItem6.Text = "radCommandBarToggleButtonItem6"
			' 
			' radCommandBarToggleButtonItem7
			' 
			Me.radCommandBarToggleButtonItem7.DisplayName = "Justify Text Button"
			Me.radCommandBarToggleButtonItem7.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem7.Image"), Image))
			Me.radCommandBarToggleButtonItem7.Name = "radCommandBarToggleButtonItem7"
			Me.radCommandBarToggleButtonItem7.Text = "radCommandBarToggleButtonItem7"
			' 
			' radCommandBarSeparatorItem5
			' 
			Me.radCommandBarSeparatorItem5.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem5.Name = "radCommandBarSeparatorItem5"
			Me.radCommandBarSeparatorItem5.VisibleInOverflowMenu = False
			' 
			' radCommandBarToggleButtonItem8
			' 
			Me.radCommandBarToggleButtonItem8.DisplayName = "Bulleted List Button"
			Me.radCommandBarToggleButtonItem8.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem8.Image"), Image))
			Me.radCommandBarToggleButtonItem8.Name = "radCommandBarToggleButtonItem8"
			Me.radCommandBarToggleButtonItem8.Text = "radCommandBarToggleButtonItem8"
			' 
			' radCommandBarToggleButtonItem9
			' 
			Me.radCommandBarToggleButtonItem9.DisplayName = "Ordered List Button"
			Me.radCommandBarToggleButtonItem9.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem9.Image"), Image))
			Me.radCommandBarToggleButtonItem9.Name = "radCommandBarToggleButtonItem9"
			Me.radCommandBarToggleButtonItem9.Text = "radCommandBarToggleButtonItem9"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.radCommandBar1)
			Me.panel1.Controls.Add(Me.pictureBox1)
			Me.panel1.Location = New Point(0, 0)
			Me.panel1.Margin = New Padding(4, 4, 4, 4)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Size(845, 414)
			Me.panel1.TabIndex = 2
			' 
			' Form1
			' 
            Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Size = New Size(2349, 1464)
			Me.Controls.SetChildIndex(Me.panel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pictureBox1 As PictureBox
		Private radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
		Private radCommandBarLineElement1 As Telerik.WinControls.UI.CommandBarRowElement
		Private radCommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
		Private radCommandBarButtonItem1 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem2 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem3 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem4 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem5 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarSeparatorItem1 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCommandBarButtonItem6 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem7 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem8 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarSeparatorItem2 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCommandBarButtonItem9 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem10 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarLineElement2 As Telerik.WinControls.UI.CommandBarRowElement
		Private radCommandBarStripElement2 As Telerik.WinControls.UI.CommandBarStripElement
		Private radCommandBarToggleButtonItem1 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarToggleButtonItem2 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarToggleButtonItem3 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarSeparatorItem3 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCommandBarDropDownListItem1 As Telerik.WinControls.UI.CommandBarDropDownList
		Private radCommandBarDropDownListItem2 As Telerik.WinControls.UI.CommandBarDropDownList
		Private radCommandBarSeparatorItem4 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCommandBarToggleButtonItem4 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarToggleButtonItem5 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarToggleButtonItem6 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarToggleButtonItem7 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarSeparatorItem5 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCommandBarToggleButtonItem8 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarToggleButtonItem9 As Telerik.WinControls.UI.CommandBarToggleButton
		Private panel1 As Panel
	End Class
End Namespace