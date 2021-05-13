Namespace Telerik.Examples.WinControls.GridView.Hierarchy.FolderTree
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.imageList1 = New ImageList(Me.components)
			Me.radButtonExpand = New Telerik.WinControls.UI.RadButton()
			Me.radButtonCollapse = New Telerik.WinControls.UI.RadButton()
			Me.radCheckBoxShowCellBorders = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBoxShowLines = New Telerik.WinControls.UI.RadCheckBox()
            Me.radColorBoxBackColor = New Telerik.WinControls.UI.RadColorBox()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonExpand, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonCollapse, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxShowCellBorders, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxShowLines, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radColorBoxBackColor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radButtonCollapse)
            Me.settingsPanel.Controls.Add(Me.radButtonExpand)
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Location = New Point(955, 1)
            Me.settingsPanel.Size = New Size(200, 747)
            Me.settingsPanel.ThemeName = "ControlDefault"
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radButtonExpand, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radButtonCollapse, 0)
            ' 
            ' radGridView1
            ' 
            Me.radGridView1.Dock = DockStyle.Fill
            Me.radGridView1.Location = New Point(0, 0)
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New Size(1156, 749)
            Me.radGridView1.TabIndex = 1
            Me.radGridView1.Text = "radGridView1"
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
            Me.imageList1.TransparentColor = Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "folder_blue_open1.png")
            Me.imageList1.Images.SetKeyName(1, "folder1.png")
            Me.imageList1.Images.SetKeyName(2, "new1.png")
            ' 
            ' radButtonExpand
            ' 
            Me.radButtonExpand.Anchor = AnchorStyles.Top
            Me.radButtonExpand.Location = New Point(10, 52)
            Me.radButtonExpand.Name = "radButtonExpand"
            Me.radButtonExpand.Size = New Size(180, 24)
            Me.radButtonExpand.TabIndex = 2
            Me.radButtonExpand.Text = "Expand All"

            ' 
            ' radButtonCollapse
            ' 
            Me.radButtonCollapse.Anchor = AnchorStyles.Top
            Me.radButtonCollapse.Location = New Point(10, 82)
            Me.radButtonCollapse.Name = "radButtonCollapse"
            Me.radButtonCollapse.Size = New Size(180, 24)
            Me.radButtonCollapse.TabIndex = 3
            Me.radButtonCollapse.Text = "Collapse All"

            ' 
            ' radCheckBoxShowCellBorders
            ' 
            Me.radCheckBoxShowCellBorders.Location = New Point(13, 47)
            Me.radCheckBoxShowCellBorders.Name = "radCheckBoxShowCellBorders"
            ' 
            ' 
            ' 
            Me.radCheckBoxShowCellBorders.RootElement.StretchHorizontally = True
            Me.radCheckBoxShowCellBorders.RootElement.StretchVertically = True
            Me.radCheckBoxShowCellBorders.Size = New Size(109, 18)
            Me.radCheckBoxShowCellBorders.TabIndex = 2
            Me.radCheckBoxShowCellBorders.Text = "Show cell borders"
            Me.radCheckBoxShowCellBorders.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.Anchor = AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.radColorBoxBackColor)
            Me.radGroupBox1.Controls.Add(Me.radLabel3)
            Me.radGroupBox1.Controls.Add(Me.radDropDownList1)
            Me.radGroupBox1.Controls.Add(Me.radLabel1)
            Me.radGroupBox1.Controls.Add(Me.radCheckBoxShowLines)
            Me.radGroupBox1.Controls.Add(Me.radCheckBoxShowCellBorders)
            Me.radGroupBox1.FooterImageIndex = -1
            Me.radGroupBox1.FooterImageKey = ""
            Me.radGroupBox1.HeaderImageIndex = -1
            Me.radGroupBox1.HeaderImageKey = ""
            Me.radGroupBox1.HeaderMargin = New Padding(0)
            Me.radGroupBox1.HeaderText = "Customize lines"
            Me.radGroupBox1.Location = New Point(10, 128)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
            ' 
            ' 
            ' 
            Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
            Me.radGroupBox1.Size = New Size(180, 189)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Customize lines"
            ' 
            ' radDropDownList1
            ' 
            radListDataItem1.Text = "Solid"
            radListDataItem1.TextWrap = True
            radListDataItem2.Text = "Dash"
            radListDataItem2.TextWrap = True
            radListDataItem3.Text = "Dot"
            radListDataItem3.TextWrap = True
            radListDataItem4.Text = "DashDot"
            radListDataItem4.TextWrap = True
            radListDataItem5.Text = "DashDotDot"
            radListDataItem5.TextWrap = True
            Me.radDropDownList1.Items.Add(radListDataItem1)
            Me.radDropDownList1.Items.Add(radListDataItem2)
            Me.radDropDownList1.Items.Add(radListDataItem3)
            Me.radDropDownList1.Items.Add(radListDataItem4)
            Me.radDropDownList1.Items.Add(radListDataItem5)
            Me.radDropDownList1.Location = New Point(16, 96)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.ShowImageInEditorArea = True
            Me.radDropDownList1.Size = New Size(151, 21)
            Me.radDropDownList1.TabIndex = 5
            Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Location = New Point(13, 72)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New Size(55, 18)
            Me.radLabel1.TabIndex = 4
            Me.radLabel1.Text = "Line style:"
            ' 
            ' radCheckBoxShowLines
            ' 
            Me.radCheckBoxShowLines.Location = New Point(13, 23)
            Me.radCheckBoxShowLines.Name = "radCheckBoxShowLines"
            ' 
            ' 
            ' 
            Me.radCheckBoxShowLines.RootElement.StretchHorizontally = True
            Me.radCheckBoxShowLines.RootElement.StretchVertically = True
            Me.radCheckBoxShowLines.Size = New Size(109, 18)
            Me.radCheckBoxShowLines.TabIndex = 3
            Me.radCheckBoxShowLines.Text = "Show tree lines"

            ' 
            ' radColorBoxBackColor
            ' 
            Me.radColorBoxBackColor.Location = New Point(59, 152)
            Me.radColorBoxBackColor.Name = "radColorBoxBackColor"
            Me.radColorBoxBackColor.Size = New Size(59, 24)
            Me.radColorBoxBackColor.TabIndex = 9

            ' 
            ' radLabel3
            ' 
            Me.radLabel3.Location = New Point(16, 123)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New Size(57, 18)
            Me.radLabel3.TabIndex = 10
            Me.radLabel3.Text = "Line color:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Size = New Size(1156, 749)

            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonExpand, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonCollapse, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxShowCellBorders, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxShowLines, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radColorBoxBackColor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private imageList1 As ImageList
        Private radButtonCollapse As Telerik.WinControls.UI.RadButton
        Private radButtonExpand As Telerik.WinControls.UI.RadButton
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radCheckBoxShowLines As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxShowCellBorders As Telerik.WinControls.UI.RadCheckBox
        Private radColorBoxBackColor As Telerik.WinControls.UI.RadColorBox
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
