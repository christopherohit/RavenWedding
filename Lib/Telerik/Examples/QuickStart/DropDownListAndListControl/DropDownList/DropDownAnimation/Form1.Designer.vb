Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.DropDownAnimation
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
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
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem7 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem8 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem9 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem10 As New Telerik.WinControls.UI.RadListDataItem()
			Me.imageList1 = New ImageList(Me.components)
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radGroupAnimSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radSpinFrames = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radCheckEnableAnim = New Telerik.WinControls.UI.RadCheckBox()
			Me.radComboAnimType = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLblFrames = New Telerik.WinControls.UI.RadLabel()
			Me.radLblDropDownAnim = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupAnimSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupAnimSettings.SuspendLayout()
			CType(Me.radSpinFrames, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckEnableAnim, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboAnimType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblFrames, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblDropDownAnim, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.MaximumSize = New Size(362, 100)
			Me.radPanelDemoHolder.MinimumSize = New Size(362, 100)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.MaxSize = New Size(362, 100)
			Me.radPanelDemoHolder.RootElement.MinSize = New Size(362, 100)
			Me.radPanelDemoHolder.Size = New Size(362, 100)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupAnimSettings)
			Me.settingsPanel.Location = New Point(973, 1)
			Me.settingsPanel.Size = New Size(250, 534)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupAnimSettings, 0)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "WizardPicture.bmp")
			Me.imageList1.Images.SetKeyName(1, "bulb_on.GIF")
			Me.imageList1.Images.SetKeyName(2, "CLSDFOLD.BMP")
			Me.imageList1.Images.SetKeyName(3, "test.bmp")
			Me.imageList1.Images.SetKeyName(4, "untitled.bmp")
			' 
			' radComboDemo
			' 
			Me.radComboDemo.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboDemo.ImageList = Me.imageList1
			radListDataItem1.Text = "Amsterdam"
			radListDataItem1.TextWrap = True
			radListDataItem2.Text = "Barcelona"
			radListDataItem2.TextWrap = True
			radListDataItem3.Text = "Bonn"
			radListDataItem3.TextWrap = True
			radListDataItem4.Text = "Brussels"
			radListDataItem4.TextWrap = True
			radListDataItem5.Text = "New York"
			radListDataItem5.TextWrap = True
			radListDataItem6.Text = "London"
			radListDataItem6.TextWrap = True
			radListDataItem7.Text = "Paris"
			radListDataItem7.TextWrap = True
			radListDataItem8.Text = "Sofia"
			radListDataItem8.TextWrap = True
			radListDataItem9.Text = "Prague"
			radListDataItem9.TextWrap = True
			radListDataItem10.Text = "Hamburg"
			radListDataItem10.TextWrap = True
			Me.radComboDemo.Items.Add(radListDataItem1)
			Me.radComboDemo.Items.Add(radListDataItem2)
			Me.radComboDemo.Items.Add(radListDataItem3)
			Me.radComboDemo.Items.Add(radListDataItem4)
			Me.radComboDemo.Items.Add(radListDataItem5)
			Me.radComboDemo.Items.Add(radListDataItem6)
			Me.radComboDemo.Items.Add(radListDataItem7)
			Me.radComboDemo.Items.Add(radListDataItem8)
			Me.radComboDemo.Items.Add(radListDataItem9)
			Me.radComboDemo.Items.Add(radListDataItem10)
			Me.radComboDemo.Location = New Point(20, 20)
			Me.radComboDemo.Name = "radComboDemo"
			Me.radComboDemo.NullText = "Choose City..."
			' 
			' 
			' 
			Me.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDemo.Size = New Size(306, 20)
			Me.radComboDemo.TabIndex = 0
			' 
			' radGroupAnimSettings
			' 
			Me.radGroupAnimSettings.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupAnimSettings.Controls.Add(Me.radSpinFrames)
			Me.radGroupAnimSettings.Controls.Add(Me.radCheckEnableAnim)
			Me.radGroupAnimSettings.Controls.Add(Me.radComboAnimType)
			Me.radGroupAnimSettings.Controls.Add(Me.radLblFrames)
			Me.radGroupAnimSettings.Controls.Add(Me.radLblDropDownAnim)
			Me.radGroupAnimSettings.FooterText = ""
			Me.radGroupAnimSettings.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupAnimSettings.HeaderText = " Animation settings "
			Me.radGroupAnimSettings.Location = New Point(15, 6)
			Me.radGroupAnimSettings.Name = "radGroupAnimSettings"
			' 
			' 
			' 
			Me.radGroupAnimSettings.RootElement.Padding = New Padding(2, 18, 2, 2)
			Me.radGroupAnimSettings.Size = New Size(162, 156)
			Me.radGroupAnimSettings.TabIndex = 0
			Me.radGroupAnimSettings.Text = " Animation settings "
			' 
			' radSpinFrames
			' 
			Me.radSpinFrames.Location = New Point(64, 119)
			Me.radSpinFrames.Name = "radSpinFrames"
			' 
			' 
			' 
			Me.radSpinFrames.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinFrames.Size = New Size(80, 20)
			Me.radSpinFrames.TabIndex = 3
			Me.radSpinFrames.TabStop = False
			Me.radSpinFrames.Tag = "Right"
			' 
			' radCheckEnableAnim
			' 
			Me.radCheckEnableAnim.Location = New Point(12, 39)
			Me.radCheckEnableAnim.Name = "radCheckEnableAnim"
			Me.radCheckEnableAnim.Size = New Size(108, 18)
			Me.radCheckEnableAnim.TabIndex = 2
			Me.radCheckEnableAnim.Text = "Enable Animation"
			' 
			' radComboAnimType
			' 
			Me.radComboAnimType.Location = New Point(12, 90)
			Me.radComboAnimType.Name = "radComboAnimType"
			' 
			' 
			' 
			Me.radComboAnimType.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboAnimType.Size = New Size(132, 20)
			Me.radComboAnimType.TabIndex = 1
			Me.radComboAnimType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			' 
			' radLblFrames
			' 
			Me.radLblFrames.Location = New Point(12, 121)
			Me.radLblFrames.Name = "radLblFrames"
			Me.radLblFrames.Size = New Size(44, 18)
			Me.radLblFrames.TabIndex = 0
			Me.radLblFrames.Text = "Frames:"
			' 
			' radLblDropDownAnim
			' 
			Me.radLblDropDownAnim.Location = New Point(12, 66)
			Me.radLblDropDownAnim.Name = "radLblDropDownAnim"
			Me.radLblDropDownAnim.Size = New Size(85, 18)
			Me.radLblDropDownAnim.TabIndex = 0
			Me.radLblDropDownAnim.Text = "Animation type:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Name = "Form1"
			Me.Size = New Size(1142, 516)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupAnimSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupAnimSettings.ResumeLayout(False)
			Me.radGroupAnimSettings.PerformLayout()
			CType(Me.radSpinFrames, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckEnableAnim, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboAnimType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblFrames, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblDropDownAnim, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As ImageList
		Private radComboDemo As Telerik.WinControls.UI.RadDropDownList
		Private radGroupAnimSettings As Telerik.WinControls.UI.RadGroupBox
		Private radLblDropDownAnim As Telerik.WinControls.UI.RadLabel
		Private radComboAnimType As Telerik.WinControls.UI.RadDropDownList
		Private radSpinFrames As Telerik.WinControls.UI.RadSpinEditor
		Private radCheckEnableAnim As Telerik.WinControls.UI.RadCheckBox
		Private radLblFrames As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace