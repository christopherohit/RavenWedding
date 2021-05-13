Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Sorting
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem10 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem11 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem12 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem13 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
            Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
            Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
            Me.radBtnAdd = New Telerik.WinControls.UI.RadButton()
            Me.radBtnRemove = New Telerik.WinControls.UI.RadButton()
            Me.radTxtText = New Telerik.WinControls.UI.RadTextBox()
            Me.radTxtIndex = New Telerik.WinControls.UI.RadTextBox()
            Me.radLblText = New Telerik.WinControls.UI.RadLabel()
            Me.radLblItemIndex = New Telerik.WinControls.UI.RadLabel()
            Me.radComboSortMode = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLblSortMode = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupSettings.SuspendLayout()
            CType(Me.radBtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBtnRemove, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTxtText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTxtIndex, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLblText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLblItemIndex, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radComboSortMode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLblSortMode, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
            Me.radPanelDemoHolder.ForeColor = System.Drawing.Color.Black
            Me.radPanelDemoHolder.MaximumSize = New System.Drawing.Size(362, 100)
            Me.radPanelDemoHolder.MinimumSize = New System.Drawing.Size(362, 100)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.RootElement.MaxSize = New System.Drawing.Size(362, 100)
            Me.radPanelDemoHolder.RootElement.MinSize = New System.Drawing.Size(362, 100)
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(362, 100)
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupSettings)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(230, 755)
            Me.settingsPanel.Size = New System.Drawing.Size(230, 755)
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "WizardPicture.bmp")
            Me.imageList1.Images.SetKeyName(1, "bulb_on.GIF")
            Me.imageList1.Images.SetKeyName(2, "CLSDFOLD.BMP")
            Me.imageList1.Images.SetKeyName(3, "test.bmp")
            Me.imageList1.Images.SetKeyName(4, "untitled.bmp")
            '
            'radComboDemo
            '
            Me.radComboDemo.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
            RadListDataItem1.Text = "Amsterdam"
            RadListDataItem2.Text = "Barcelona"
            RadListDataItem3.Text = "Bonn"
            RadListDataItem4.Text = "Brussels"
            RadListDataItem5.Text = "New York"
            RadListDataItem6.Text = "London"
            RadListDataItem7.Text = "Paris"
            RadListDataItem8.Text = "Sofia"
            RadListDataItem9.Text = "Prague"
            RadListDataItem10.Text = "Hamburg"
            Me.radComboDemo.Items.Add(RadListDataItem1)
            Me.radComboDemo.Items.Add(RadListDataItem2)
            Me.radComboDemo.Items.Add(RadListDataItem3)
            Me.radComboDemo.Items.Add(RadListDataItem4)
            Me.radComboDemo.Items.Add(RadListDataItem5)
            Me.radComboDemo.Items.Add(RadListDataItem6)
            Me.radComboDemo.Items.Add(RadListDataItem7)
            Me.radComboDemo.Items.Add(RadListDataItem8)
            Me.radComboDemo.Items.Add(RadListDataItem9)
            Me.radComboDemo.Items.Add(RadListDataItem10)
            Me.radComboDemo.Location = New System.Drawing.Point(20, 20)
            Me.radComboDemo.Name = "radComboDemo"
            Me.radComboDemo.NullText = "Choose City..."
            Me.radComboDemo.Size = New System.Drawing.Size(306, 20)
            Me.radComboDemo.TabIndex = 0
            '
            'radGroupSettings
            '
            Me.radGroupSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupSettings.Controls.Add(Me.radBtnAdd)
            Me.radGroupSettings.Controls.Add(Me.radBtnRemove)
            Me.radGroupSettings.Controls.Add(Me.radTxtText)
            Me.radGroupSettings.Controls.Add(Me.radTxtIndex)
            Me.radGroupSettings.Controls.Add(Me.radLblText)
            Me.radGroupSettings.Controls.Add(Me.radLblItemIndex)
            Me.radGroupSettings.Controls.Add(Me.radComboSortMode)
            Me.radGroupSettings.Controls.Add(Me.radLblSortMode)
            Me.radGroupSettings.FooterText = ""
            Me.radGroupSettings.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.radGroupSettings.HeaderText = " Settings "
            Me.radGroupSettings.Location = New System.Drawing.Point(40, 6)
            Me.radGroupSettings.Name = "radGroupSettings"
            Me.radGroupSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupSettings.Size = New System.Drawing.Size(180, 228)
            Me.radGroupSettings.TabIndex = 0
            Me.radGroupSettings.Text = " Settings "
            '
            'radBtnAdd
            '
            Me.radBtnAdd.Location = New System.Drawing.Point(39, 191)
            Me.radBtnAdd.Name = "radBtnAdd"
            Me.radBtnAdd.Size = New System.Drawing.Size(61, 23)
            Me.radBtnAdd.TabIndex = 14
            Me.radBtnAdd.Tag = "NotTouch"
            Me.radBtnAdd.Text = "Add"
            '
            'radBtnRemove
            '
            Me.radBtnRemove.Location = New System.Drawing.Point(106, 191)
            Me.radBtnRemove.Name = "radBtnRemove"
            Me.radBtnRemove.Size = New System.Drawing.Size(64, 23)
            Me.radBtnRemove.TabIndex = 13
            Me.radBtnRemove.Tag = "NotTouch"
            Me.radBtnRemove.Text = "Remove"
            '
            'radTxtText
            '
            Me.radTxtText.Location = New System.Drawing.Point(55, 156)
            Me.radTxtText.Name = "radTxtText"
            Me.radTxtText.Size = New System.Drawing.Size(94, 20)
            Me.radTxtText.TabIndex = 12
            Me.radTxtText.TabStop = False
            Me.radTxtText.Tag = "Right"
            '
            'radTxtIndex
            '
            Me.radTxtIndex.Location = New System.Drawing.Point(55, 120)
            Me.radTxtIndex.Name = "radTxtIndex"
            Me.radTxtIndex.ReadOnly = True
            Me.radTxtIndex.Size = New System.Drawing.Size(94, 20)
            Me.radTxtIndex.TabIndex = 11
            Me.radTxtIndex.TabStop = False
            Me.radTxtIndex.Tag = "Right"
            '
            'radLblText
            '
            Me.radLblText.Location = New System.Drawing.Point(20, 159)
            Me.radLblText.Name = "radLblText"
            Me.radLblText.Size = New System.Drawing.Size(30, 18)
            Me.radLblText.TabIndex = 10
            Me.radLblText.Text = "Text:"
            '
            'radLblItemIndex
            '
            Me.radLblItemIndex.Location = New System.Drawing.Point(14, 123)
            Me.radLblItemIndex.Name = "radLblItemIndex"
            Me.radLblItemIndex.Size = New System.Drawing.Size(36, 18)
            Me.radLblItemIndex.TabIndex = 9
            Me.radLblItemIndex.Text = "Index:"
            '
            'radComboSortMode
            '
            Me.radComboSortMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            RadListDataItem11.Text = "Ascending"
            RadListDataItem12.Text = "Descending"
            RadListDataItem13.Text = "None"
            Me.radComboSortMode.Items.Add(RadListDataItem11)
            Me.radComboSortMode.Items.Add(RadListDataItem12)
            Me.radComboSortMode.Items.Add(RadListDataItem13)
            Me.radComboSortMode.Location = New System.Drawing.Point(14, 52)
            Me.radComboSortMode.Name = "radComboSortMode"
            Me.radComboSortMode.Size = New System.Drawing.Size(135, 20)
            Me.radComboSortMode.TabIndex = 1
            '
            'radLblSortMode
            '
            Me.radLblSortMode.Location = New System.Drawing.Point(12, 28)
            Me.radLblSortMode.Name = "radLblSortMode"
            Me.radLblSortMode.Size = New System.Drawing.Size(61, 18)
            Me.radLblSortMode.TabIndex = 0
            Me.radLblSortMode.Text = "Sort mode:"
            '
            'Form1
            '
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1177)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.radPanelDemoHolder.PerformLayout()
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupSettings.ResumeLayout(False)
            Me.radGroupSettings.PerformLayout()
            CType(Me.radBtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBtnRemove, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTxtText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTxtIndex, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLblText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLblItemIndex, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radComboSortMode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLblSortMode, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub


		#End Region

		Private radComboDemo As Telerik.WinControls.UI.RadDropDownList
		Private imageList1 As ImageList
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
		Private radComboSortMode As Telerik.WinControls.UI.RadDropDownList
		Private radLblSortMode As Telerik.WinControls.UI.RadLabel
		Private radBtnAdd As Telerik.WinControls.UI.RadButton
		Private radBtnRemove As Telerik.WinControls.UI.RadButton
		Private radTxtText As Telerik.WinControls.UI.RadTextBox
		Private radTxtIndex As Telerik.WinControls.UI.RadTextBox
		Private radLblText As Telerik.WinControls.UI.RadLabel
		Private radLblItemIndex As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace