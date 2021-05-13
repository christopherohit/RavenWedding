Namespace Telerik.Examples.WinControls.PageView.StackView.FirstLook
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.pageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radioContentAfterSelected = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioContentWithSelected = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioStandard = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radioPositionRight = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioPositionLeft = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioPositionBottom = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioPositionTop = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.showFooterCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.showHeaderCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.pageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage2.SuspendLayout()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage3.SuspendLayout()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radioContentAfterSelected, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioContentWithSelected, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioStandard, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radioPositionRight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioPositionLeft, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioPositionBottom, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioPositionTop, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.showFooterCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.showHeaderCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(848, 1)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.PanelContainer.Size = New Size(359, 913)
			Me.settingsPanel.Size = New Size(359, 913)
			' 
			' pageView1
			' 
			Me.pageView1.Controls.Add(Me.radPageViewPage1)
			Me.pageView1.Controls.Add(Me.radPageViewPage2)
			Me.pageView1.Controls.Add(Me.radPageViewPage3)
			Me.pageView1.ItemSizeMode = (CType((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth Or Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight), Telerik.WinControls.UI.PageViewItemSizeMode))
            Me.pageView1.Location = New Point(20, 20)
			Me.pageView1.Name = "pageView1"
			Me.pageView1.SelectedPage = Me.radPageViewPage1
			Me.pageView1.Size = New Size(441, 528)
			Me.pageView1.TabIndex = 1
			Me.pageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radLabel1)
			Me.radPageViewPage1.ItemSize = New SizeF(441F, 40F)
			Me.radPageViewPage1.Location = New Point(6, 35)
			Me.radPageViewPage1.Margin = New Padding(4, 4, 4, 4)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New Size(429, 371)
			Me.radPageViewPage1.Text = "Selection Settings"
			' 
			' radLabel1
			' 
			Me.radLabel1.AutoSize = False
			Me.radLabel1.Dock = DockStyle.Fill
			Me.radLabel1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radLabel1.Location = New Point(0, 0)
			Me.radLabel1.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(429, 371)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = resources.GetString("radLabel1.Text")
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.Controls.Add(Me.radLabel2)
			Me.radPageViewPage2.ItemSize = New SizeF(441F, 40F)
			Me.radPageViewPage2.Location = New Point(8, 37)
			Me.radPageViewPage2.Margin = New Padding(4, 4, 4, 4)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New Size(425, 370)
			Me.radPageViewPage2.Text = "Stack Position Settings"
			' 
			' radLabel2
			' 
			Me.radLabel2.AutoSize = False
			Me.radLabel2.Dock = DockStyle.Fill
			Me.radLabel2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radLabel2.Location = New Point(0, 0)
			Me.radLabel2.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(425, 370)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = resources.GetString("radLabel2.Text")
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.Controls.Add(Me.radLabel3)
			Me.radPageViewPage3.ItemSize = New SizeF(441F, 40F)
			Me.radPageViewPage3.Location = New Point(7, 34)
			Me.radPageViewPage3.Margin = New Padding(4, 4, 4, 4)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New Size(428, 374)
			Me.radPageViewPage3.Text = "Layout Settings"
			' 
			' radLabel3
			' 
			Me.radLabel3.AutoSize = False
			Me.radLabel3.Dock = DockStyle.Fill
			Me.radLabel3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radLabel3.Location = New Point(0, 0)
			Me.radLabel3.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(428, 374)
			Me.radLabel3.TabIndex = 2
			Me.radLabel3.Text = resources.GetString("radLabel3.Text")
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radioContentAfterSelected)
			Me.radGroupBox1.Controls.Add(Me.radioContentWithSelected)
			Me.radGroupBox1.Controls.Add(Me.radioStandard)
			Me.radGroupBox1.HeaderText = "Selection Settings"
			Me.radGroupBox1.Location = New Point(56, 52)
			Me.radGroupBox1.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupBox1.Size = New Size(240, 149)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Selection Settings"
			' 
			' radioContentAfterSelected
			' 
			Me.radioContentAfterSelected.Location = New Point(36, 105)
			Me.radioContentAfterSelected.Margin = New Padding(4, 4, 4, 4)
			Me.radioContentAfterSelected.Name = "radioContentAfterSelected"
			Me.radioContentAfterSelected.Size = New Size(157, 22)
			Me.radioContentAfterSelected.TabIndex = 0
			Me.radioContentAfterSelected.Text = "ContentAfterSelected"
			' 
			' radioContentWithSelected
			' 
			Me.radioContentWithSelected.Location = New Point(36, 75)
			Me.radioContentWithSelected.Margin = New Padding(4, 4, 4, 4)
			Me.radioContentWithSelected.Name = "radioContentWithSelected"
			Me.radioContentWithSelected.Size = New Size(155, 22)
			Me.radioContentWithSelected.TabIndex = 0
			Me.radioContentWithSelected.Text = "ContentWithSelected"
			' 
			' radioStandard
			' 
			Me.radioStandard.Location = New Point(36, 46)
			Me.radioStandard.Margin = New Padding(4, 4, 4, 4)
			Me.radioStandard.Name = "radioStandard"
			Me.radioStandard.Size = New Size(80, 22)
			Me.radioStandard.TabIndex = 0
			Me.radioStandard.Text = "Standard"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radioPositionRight)
			Me.radGroupBox2.Controls.Add(Me.radioPositionLeft)
			Me.radGroupBox2.Controls.Add(Me.radioPositionBottom)
			Me.radGroupBox2.Controls.Add(Me.radioPositionTop)
			Me.radGroupBox2.HeaderText = "Stack Position"
			Me.radGroupBox2.Location = New Point(56, 209)
			Me.radGroupBox2.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupBox2.Size = New Size(240, 177)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = "Stack Position"
			' 
			' radioPositionRight
			' 
			Me.radioPositionRight.Location = New Point(36, 130)
			Me.radioPositionRight.Margin = New Padding(4, 4, 4, 4)
			Me.radioPositionRight.Name = "radioPositionRight"
			Me.radioPositionRight.Size = New Size(58, 22)
			Me.radioPositionRight.TabIndex = 0
			Me.radioPositionRight.Text = "Right"
			' 
			' radioPositionLeft
			' 
			Me.radioPositionLeft.Location = New Point(36, 101)
			Me.radioPositionLeft.Margin = New Padding(4, 4, 4, 4)
			Me.radioPositionLeft.Name = "radioPositionLeft"
			Me.radioPositionLeft.Size = New Size(48, 22)
			Me.radioPositionLeft.TabIndex = 0
			Me.radioPositionLeft.Text = "Left"
			' 
			' radioPositionBottom
			' 
			Me.radioPositionBottom.Location = New Point(36, 42)
			Me.radioPositionBottom.Margin = New Padding(4, 4, 4, 4)
			Me.radioPositionBottom.Name = "radioPositionBottom"
			Me.radioPositionBottom.Size = New Size(71, 22)
			Me.radioPositionBottom.TabIndex = 0
			Me.radioPositionBottom.Text = "Bottom"
			' 
			' radioPositionTop
			' 
			Me.radioPositionTop.Location = New Point(36, 71)
			Me.radioPositionTop.Margin = New Padding(4, 4, 4, 4)
			Me.radioPositionTop.Name = "radioPositionTop"
			Me.radioPositionTop.Size = New Size(49, 22)
			Me.radioPositionTop.TabIndex = 0
			Me.radioPositionTop.Text = "Top"
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox3.Anchor = AnchorStyles.Top
			Me.radGroupBox3.Controls.Add(Me.showFooterCheck)
			Me.radGroupBox3.Controls.Add(Me.showHeaderCheck)
			Me.radGroupBox3.Controls.Add(Me.radSpinEditor1)
			Me.radGroupBox3.Controls.Add(Me.radLabel4)
			Me.radGroupBox3.HeaderText = "Layout Settings"
			Me.radGroupBox3.Location = New Point(56, 394)
			Me.radGroupBox3.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupBox3.Size = New Size(240, 177)
			Me.radGroupBox3.TabIndex = 1
			Me.radGroupBox3.Text = "Layout Settings"
			' 
			' showFooterCheck
			' 
			Me.showFooterCheck.Location = New Point(36, 127)
			Me.showFooterCheck.Margin = New Padding(4, 4, 4, 4)
			Me.showFooterCheck.Name = "showFooterCheck"
			Me.showFooterCheck.Size = New Size(102, 22)
			Me.showFooterCheck.TabIndex = 2
			Me.showFooterCheck.Text = "Show Footer"
			' 
			' showHeaderCheck
			' 
			Me.showHeaderCheck.Location = New Point(36, 97)
			Me.showHeaderCheck.Margin = New Padding(4, 4, 4, 4)
			Me.showHeaderCheck.Name = "showHeaderCheck"
			Me.showHeaderCheck.Size = New Size(107, 22)
			Me.showHeaderCheck.TabIndex = 2
			Me.showHeaderCheck.Text = "Show Header"
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Location = New Point(133, 50)
			Me.radSpinEditor1.Margin = New Padding(4, 4, 4, 4)
			Me.radSpinEditor1.Maximum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.radSpinEditor1.Minimum = New Decimal(New Integer() { 10, 0, 0, -2147483648})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.Size = New Size(89, 24)
			Me.radSpinEditor1.TabIndex = 1
			Me.radSpinEditor1.TabStop = False
			Me.radSpinEditor1.Tag = "Right"
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New Point(17, 50)
			Me.radLabel4.Margin = New Padding(4, 4, 4, 4)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(89, 22)
			Me.radLabel4.TabIndex = 0
			Me.radLabel4.Text = "Item spacing:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.pageView1)
			Me.Name = "Form1"
			Me.Size = New Size(1919, 1104)
			Me.Controls.SetChildIndex(Me.pageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.pageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage2.ResumeLayout(False)
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage3.ResumeLayout(False)
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radioContentAfterSelected, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioContentWithSelected, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioStandard, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radioPositionRight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioPositionLeft, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioPositionBottom, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioPositionTop, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			CType(Me.showFooterCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.showHeaderCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		Private pageView1 As Telerik.WinControls.UI.RadPageView

		#End Region
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radioContentWithSelected As Telerik.WinControls.UI.RadRadioButton
		Private radioStandard As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radioPositionRight As Telerik.WinControls.UI.RadRadioButton
		Private radioPositionLeft As Telerik.WinControls.UI.RadRadioButton
		Private radioPositionBottom As Telerik.WinControls.UI.RadRadioButton
		Private radioPositionTop As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private showFooterCheck As Telerik.WinControls.UI.RadCheckBox
		Private showHeaderCheck As Telerik.WinControls.UI.RadCheckBox
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radioContentAfterSelected As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace
