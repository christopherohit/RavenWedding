Namespace Telerik.Examples.WinControls.PageView.StripView.Settings
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
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.stripAlignCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.itemAlignCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.fitModeCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.sizeModeCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.orientationCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.spacingSpin = New Telerik.WinControls.UI.RadSpinEditor()
			Me.addPageButton = New Telerik.WinControls.UI.RadButton()
			Me.multiLineFitCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.stripAlignCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.itemAlignCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			CType(Me.fitModeCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sizeModeCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orientationCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spacingSpin, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.addPageButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.multiLineFitCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.multiLineFitCombo)
			Me.settingsPanel.Controls.Add(Me.addPageButton)
			Me.settingsPanel.Controls.Add(Me.spacingSpin)
			Me.settingsPanel.Controls.Add(Me.radLabel7)
			Me.settingsPanel.Controls.Add(Me.radLabel6)
			Me.settingsPanel.Controls.Add(Me.orientationCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel5)
			Me.settingsPanel.Controls.Add(Me.sizeModeCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel4)
			Me.settingsPanel.Controls.Add(Me.fitModeCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel3)
			Me.settingsPanel.Controls.Add(Me.itemAlignCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.stripAlignCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Location = New Point(1002, 1)
			Me.settingsPanel.Size = New Size(200, 524)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.stripAlignCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.itemAlignCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel3, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.fitModeCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel4, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.sizeModeCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel5, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.orientationCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel6, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel7, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.spacingSpin, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.addPageButton, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.multiLineFitCombo, 0)
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(10, 37)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(86, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Strip Alignment:"
			' 
			' stripAlignCombo
			' 
			Me.stripAlignCombo.AllowShowFocusCues = False
			Me.stripAlignCombo.Anchor = AnchorStyles.Top
			Me.stripAlignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.stripAlignCombo.Location = New Point(10, 59)
			Me.stripAlignCombo.Name = "stripAlignCombo"
			' 
			' 
			' 
			Me.stripAlignCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.stripAlignCombo.Size = New Size(180, 20)
			Me.stripAlignCombo.TabIndex = 2
			' 
			' itemAlignCombo
			' 
			Me.itemAlignCombo.AllowShowFocusCues = False
			Me.itemAlignCombo.Anchor = AnchorStyles.Top
			Me.itemAlignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.itemAlignCombo.Location = New Point(10, 107)
			Me.itemAlignCombo.Name = "itemAlignCombo"
			' 
			' 
			' 
			Me.itemAlignCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.itemAlignCombo.Size = New Size(180, 20)
			Me.itemAlignCombo.TabIndex = 4
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(10, 85)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(85, 18)
			Me.radLabel2.TabIndex = 3
			Me.radLabel2.Text = "Item Alignment:"
			' 
			' radPageView1
			' 
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage3)
			Me.radPageView1.Location = New Point(0, 0)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New Size(834, 654)
			Me.radPageView1.TabIndex = 1
			Me.radPageView1.Text = "radPageView1"
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.ItemSize = New SizeF(112F, 28F)
			Me.radPageViewPage1.Location = New Point(10, 37)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New Size(813, 606)
			Me.radPageViewPage1.Text = "radPageViewPage1"
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.ItemSize = New SizeF(112F, 28F)
			Me.radPageViewPage2.Location = New Point(9, 33)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New Size(574, 285)
			Me.radPageViewPage2.Text = "radPageViewPage2"
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.ItemSize = New SizeF(112F, 28F)
			Me.radPageViewPage3.Location = New Point(9, 33)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New Size(574, 285)
			Me.radPageViewPage3.Text = "radPageViewPage3"
			' 
			' fitModeCombo
			' 
			Me.fitModeCombo.AllowShowFocusCues = False
			Me.fitModeCombo.Anchor = AnchorStyles.Top
			Me.fitModeCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.fitModeCombo.Location = New Point(10, 155)
			Me.fitModeCombo.Name = "fitModeCombo"
			' 
			' 
			' 
			Me.fitModeCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.fitModeCombo.Size = New Size(180, 20)
			Me.fitModeCombo.TabIndex = 6
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = AnchorStyles.Top
			Me.radLabel3.Location = New Point(10, 133)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(78, 18)
			Me.radLabel3.TabIndex = 5
			Me.radLabel3.Text = "Item Fit Mode:"
			' 
			' sizeModeCombo
			' 
			Me.sizeModeCombo.AllowShowFocusCues = False
			Me.sizeModeCombo.Anchor = AnchorStyles.Top
			Me.sizeModeCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.sizeModeCombo.Location = New Point(10, 251)
			Me.sizeModeCombo.Name = "sizeModeCombo"
			' 
			' 
			' 
			Me.sizeModeCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.sizeModeCombo.Size = New Size(180, 20)
			Me.sizeModeCombo.TabIndex = 8
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = AnchorStyles.Top
			Me.radLabel4.Location = New Point(10, 229)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(86, 18)
			Me.radLabel4.TabIndex = 7
			Me.radLabel4.Text = "Item Size Mode:"
			' 
			' orientationCombo
			' 
			Me.orientationCombo.AllowShowFocusCues = False
			Me.orientationCombo.Anchor = AnchorStyles.Top
			Me.orientationCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.orientationCombo.Location = New Point(10, 299)
			Me.orientationCombo.Name = "orientationCombo"
			' 
			' 
			' 
			Me.orientationCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.orientationCombo.Size = New Size(180, 20)
			Me.orientationCombo.TabIndex = 10
			' 
			' radLabel5
			' 
			Me.radLabel5.Anchor = AnchorStyles.Top
			Me.radLabel5.Location = New Point(10, 277)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New Size(133, 18)
			Me.radLabel5.TabIndex = 9
			Me.radLabel5.Text = "Item Content Orientation:"
			' 
			' radLabel6
			' 
			Me.radLabel6.Anchor = AnchorStyles.Top
			Me.radLabel6.Location = New Point(10, 325)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New Size(73, 18)
			Me.radLabel6.TabIndex = 11
			Me.radLabel6.Text = "Item Spacing:"
			' 
			' spacingSpin
			' 
			Me.spacingSpin.Anchor = AnchorStyles.Top
			Me.spacingSpin.Location = New Point(10, 347)
			Me.spacingSpin.Name = "spacingSpin"
			' 
			' 
			' 
			Me.spacingSpin.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spacingSpin.Size = New Size(180, 20)
			Me.spacingSpin.TabIndex = 12
			Me.spacingSpin.TabStop = False
			' 
			' addPageButton
			' 
			Me.addPageButton.Anchor = AnchorStyles.Top
			Me.addPageButton.Location = New Point(10, 404)
			Me.addPageButton.Name = "addPageButton"
			Me.addPageButton.Size = New Size(180, 24)
			Me.addPageButton.TabIndex = 13
			Me.addPageButton.Text = "Add Page"
			' 
			' multiLineFitCombo
			' 
			Me.multiLineFitCombo.AllowShowFocusCues = False
			Me.multiLineFitCombo.Anchor = AnchorStyles.Top
			Me.multiLineFitCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.multiLineFitCombo.Enabled = False
			Me.multiLineFitCombo.Location = New Point(10, 203)
			Me.multiLineFitCombo.Name = "multiLineFitCombo"
			' 
			' 
			' 
			Me.multiLineFitCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.multiLineFitCombo.Size = New Size(180, 20)
			Me.multiLineFitCombo.TabIndex = 15
			' 
			' radLabel7
			' 
			Me.radLabel7.Anchor = AnchorStyles.Top
			Me.radLabel7.Location = New Point(10, 181)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New Size(102, 18)
			Me.radLabel7.TabIndex = 14
			Me.radLabel7.Text = "MultiLine Fit Mode:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Size = New Size(1573, 958)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.stripAlignCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.itemAlignCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			CType(Me.fitModeCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sizeModeCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orientationCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spacingSpin, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.addPageButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.multiLineFitCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private itemAlignCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private stripAlignCombo As Telerik.WinControls.UI.RadDropDownList
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private fitModeCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private spacingSpin As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private orientationCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private sizeModeCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private addPageButton As Telerik.WinControls.UI.RadButton
		Private multiLineFitCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
