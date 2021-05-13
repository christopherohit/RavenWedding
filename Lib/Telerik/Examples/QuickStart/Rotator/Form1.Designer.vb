Namespace Telerik.Examples.WinControls.Rotator
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
			Me.radRotator1 = New Telerik.WinControls.UI.RadRotator()
			Me.radItemsContainer1 = New Telerik.WinControls.UI.RadItemsContainer()
			Me.radImageItem1 = New Telerik.WinControls.UI.RadImageItem()
			Me.radItemsContainer2 = New Telerik.WinControls.UI.RadItemsContainer()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
			Me.radTextBoxElement1 = New Telerik.WinControls.UI.RadTextBoxElement()
			Me.radWebBrowserItem1 = New Telerik.WinControls.UI.RadWebBrowserItem()
			Me.radButtonPrevious = New Telerik.WinControls.UI.RadButton()
			Me.radButtonNext = New Telerik.WinControls.UI.RadButton()
			Me.radStartStopButton = New Telerik.WinControls.UI.RadButton()
			Me.currentFrameTextBox = New Telerik.WinControls.UI.RadTextBox()
			Me.radLabelInterval = New Telerik.WinControls.UI.RadLabel()
			Me.intervalTextBox = New Telerik.WinControls.UI.RadTextBox()
			Me.radCheckBoxOpacity = New Telerik.WinControls.UI.RadCheckBox()
			Me.locationAnimationTextBox = New Telerik.WinControls.UI.RadTextBox()
			Me.radLabelMsec = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelLocationAnimation = New Telerik.WinControls.UI.RadLabel()
			Me.radButtonApply = New Telerik.WinControls.UI.RadButton()
			Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.tableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.tableLayoutPanel3 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radRotator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonNext, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radStartStopButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.currentFrameTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelInterval, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.intervalTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.locationAnimationTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelMsec, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelLocationAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonApply, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			Me.tableLayoutPanel2.SuspendLayout()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.tableLayoutPanel3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.ForeColor = Color.Black
			Me.settingsPanel.Location = New Point(1439, 1)
			Me.settingsPanel.Margin = New Padding(5, 5, 5, 5)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.PanelContainer.Margin = New Padding(5, 5, 5, 5)
			Me.settingsPanel.PanelContainer.Size = New Size(468, 1278)
			Me.settingsPanel.Size = New Size(468, 1278)
			' 
			' radRotator1
			' 
			Me.radRotator1.Dock = DockStyle.Fill
			Me.radRotator1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radItemsContainer1, Me.radItemsContainer2, Me.radWebBrowserItem1})
			Me.radRotator1.Location = New Point(5, 5)
			Me.radRotator1.Margin = New Padding(5, 5, 5, 5)
			Me.radRotator1.Name = "radRotator1"
			Me.radRotator1.Size = New Size(1436, 1008)
			Me.radRotator1.TabIndex = 0
			Me.radRotator1.Text = "radRotator1"
			' 
			' radItemsContainer1
			' 
			Me.radItemsContainer1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radImageItem1})
			Me.radItemsContainer1.Name = "radItemsContainer1"
			Me.radItemsContainer1.Text = "radItemsContainer1"
			Me.radItemsContainer1.Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radImageItem1
			' 
			Me.radImageItem1.Alignment = ContentAlignment.MiddleCenter
			Me.radImageItem1.Image = My.Resources.RadRotatorWinF
			Me.radImageItem1.Name = "radImageItem1"
			Me.radImageItem1.StretchHorizontally = False
			Me.radImageItem1.StretchVertically = False
			Me.radImageItem1.Text = "radImageItem1"
			' 
			' radItemsContainer2
			' 
			Me.radItemsContainer2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement1, Me.radLabelElement1, Me.radTextBoxElement1})
			Me.radItemsContainer2.Name = "radItemsContainer2"
			Me.radItemsContainer2.Text = "radItemsContainer2"
			Me.radItemsContainer2.Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.CanFocus = True
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radButtonElement1.Padding = New Padding(0, 6, 0, 6)
			Me.radButtonElement1.StretchHorizontally = False
			Me.radButtonElement1.StretchVertically = False
			Me.radButtonElement1.Text = "Previous frame"
			' 
			' radLabelElement1
			' 
			Me.radLabelElement1.Alignment = ContentAlignment.MiddleCenter
			Me.radLabelElement1.Font = New Font("Calibri", 36F, (CType((FontStyle.Bold Or FontStyle.Italic), FontStyle)), GraphicsUnit.Point, (CByte(0)))
			Me.radLabelElement1.Name = "radLabelElement1"
			Me.radLabelElement1.Opacity = 0.25R
			Me.radLabelElement1.StretchHorizontally = False
			Me.radLabelElement1.StretchVertically = False
			Me.radLabelElement1.Text = "Second rotator frame"
			Me.radLabelElement1.TextAlignment = ContentAlignment.MiddleLeft
			Me.radLabelElement1.TextWrap = True
			' 
			' radTextBoxElement1
			' 
			Me.radTextBoxElement1.Alignment = ContentAlignment.BottomRight
			Me.radTextBoxElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			Me.radTextBoxElement1.BackColor = Color.Black
			Me.radTextBoxElement1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.radTextBoxElement1.ForeColor = Color.White
			Me.radTextBoxElement1.MinSize = New Size(781, 0)
			Me.radTextBoxElement1.Name = "radTextBoxElement1"
			Me.radTextBoxElement1.Padding = New Padding(4, 4, 4, 5)
			Me.radTextBoxElement1.StretchHorizontally = False
			Me.radTextBoxElement1.StretchVertically = False
			Me.radTextBoxElement1.TextAlign = HorizontalAlignment.Left
			' 
			' radWebBrowserItem1
			' 
			Me.radWebBrowserItem1.DocumentText = "<HTML></HTML>" & vbNullChar
			Me.radWebBrowserItem1.Name = "radWebBrowserItem1"
			Me.radWebBrowserItem1.Text = "radWebBrowserItem1"
			Me.radWebBrowserItem1.Url = New Uri("about:blank", UriKind.Absolute)
			Me.radWebBrowserItem1.Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonPrevious
			' 
			Me.radButtonPrevious.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
			Me.radButtonPrevious.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.radButtonPrevious.Location = New Point(83, 24)
			Me.radButtonPrevious.Margin = New Padding(5, 5, 5, 5)
			Me.radButtonPrevious.Name = "radButtonPrevious"
			Me.radButtonPrevious.ShowItemToolTips = False
			Me.radButtonPrevious.Size = New Size(68, 41)
			Me.radButtonPrevious.TabIndex = 1
			Me.radButtonPrevious.Text = "|<"
			' 
			' radButtonNext
			' 
			Me.radButtonNext.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
			Me.radButtonNext.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.radButtonNext.Location = New Point(239, 23)
			Me.radButtonNext.Margin = New Padding(5, 5, 5, 5)
			Me.radButtonNext.Name = "radButtonNext"
			Me.radButtonNext.Size = New Size(68, 42)
			Me.radButtonNext.TabIndex = 2
			Me.radButtonNext.Text = ">|"
			' 
			' radStartStopButton
			' 
			Me.radStartStopButton.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
			Me.radStartStopButton.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.radStartStopButton.Location = New Point(161, 23)
			Me.radStartStopButton.Margin = New Padding(5, 5, 5, 5)
			Me.radStartStopButton.Name = "radStartStopButton"
			Me.radStartStopButton.Size = New Size(68, 42)
			Me.radStartStopButton.TabIndex = 3
			' 
			' currentFrameTextBox
			' 
			Me.currentFrameTextBox.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
			Me.currentFrameTextBox.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.currentFrameTextBox.Location = New Point(5, 26)
			Me.currentFrameTextBox.Margin = New Padding(5, 5, 5, 5)
			Me.currentFrameTextBox.Name = "currentFrameTextBox"
			' 
			' 
			' 
			Me.currentFrameTextBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.currentFrameTextBox.Size = New Size(68, 37)
			Me.currentFrameTextBox.TabIndex = 4
			Me.currentFrameTextBox.TabStop = False
			' 
			' radLabelInterval
			' 
			Me.radLabelInterval.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
			Me.radLabelInterval.Location = New Point(5, 42)
			Me.radLabelInterval.Margin = New Padding(5, 5, 5, 5)
			Me.radLabelInterval.Name = "radLabelInterval"
			Me.radLabelInterval.Size = New Size(53, 22)
			Me.radLabelInterval.TabIndex = 5
			Me.radLabelInterval.Text = "Interval"
			Me.radLabelInterval.TextAlignment = ContentAlignment.TopLeft
			' 
			' intervalTextBox
			' 
			Me.intervalTextBox.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
			Me.intervalTextBox.Location = New Point(5, 91)
			Me.intervalTextBox.Margin = New Padding(5, 5, 5, 5)
			Me.intervalTextBox.MaxLength = 5
			Me.intervalTextBox.Name = "intervalTextBox"
			' 
			' 
			' 
			Me.intervalTextBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.intervalTextBox.Size = New Size(146, 25)
			Me.intervalTextBox.TabIndex = 6
			Me.intervalTextBox.TabStop = False
			Me.intervalTextBox.Text = "2000"
			' 
			' radCheckBoxOpacity
			' 
			Me.radCheckBoxOpacity.Anchor = AnchorStyles.Left
			Me.radCheckBoxOpacity.CheckState = CheckState.Checked
			Me.radCheckBoxOpacity.Location = New Point(5, 299)
			Me.radCheckBoxOpacity.Margin = New Padding(5, 5, 5, 5)
			Me.radCheckBoxOpacity.Name = "radCheckBoxOpacity"
			Me.radCheckBoxOpacity.Size = New Size(140, 22)
			Me.radCheckBoxOpacity.TabIndex = 7
			Me.radCheckBoxOpacity.Text = "Opacity Animation"
			Me.radCheckBoxOpacity.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' locationAnimationTextBox
			' 
			Me.locationAnimationTextBox.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
			Me.locationAnimationTextBox.Location = New Point(5, 229)
			Me.locationAnimationTextBox.Margin = New Padding(5, 5, 5, 5)
			Me.locationAnimationTextBox.Name = "locationAnimationTextBox"
			' 
			' 
			' 
			Me.locationAnimationTextBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.locationAnimationTextBox.Size = New Size(146, 25)
			Me.locationAnimationTextBox.TabIndex = 8
			Me.locationAnimationTextBox.TabStop = False
			Me.locationAnimationTextBox.Text = "0, -1"
			' 
			' radLabelMsec
			' 
			Me.radLabelMsec.Anchor = AnchorStyles.Left
			Me.radLabelMsec.Location = New Point(161, 92)
			Me.radLabelMsec.Margin = New Padding(5, 5, 5, 5)
			Me.radLabelMsec.Name = "radLabelMsec"
			Me.radLabelMsec.Size = New Size(25, 22)
			Me.radLabelMsec.TabIndex = 9
			Me.radLabelMsec.Text = "ms"
			Me.radLabelMsec.TextAlignment = ContentAlignment.TopLeft
			' 
			' radLabelLocationAnimation
			' 
			Me.radLabelLocationAnimation.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
			Me.radLabelLocationAnimation.Location = New Point(5, 180)
			Me.radLabelLocationAnimation.Margin = New Padding(5, 5, 5, 5)
			Me.radLabelLocationAnimation.Name = "radLabelLocationAnimation"
			Me.radLabelLocationAnimation.Size = New Size(130, 22)
			Me.radLabelLocationAnimation.TabIndex = 10
			Me.radLabelLocationAnimation.Text = "Location animation:"
			Me.radLabelLocationAnimation.TextAlignment = ContentAlignment.TopLeft
			' 
			' radButtonApply
			' 
			Me.radButtonApply.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
			Me.tableLayoutPanel2.SetColumnSpan(Me.radButtonApply, 2)
			Me.radButtonApply.Location = New Point(5, 361)
			Me.radButtonApply.Margin = New Padding(5, 5, 5, 5)
			Me.radButtonApply.Name = "radButtonApply"
			Me.radButtonApply.Size = New Size(302, 38)
			Me.radButtonApply.TabIndex = 11
			Me.radButtonApply.Text = "Apply"
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupSettings.Anchor = AnchorStyles.Top
			Me.radGroupSettings.Controls.Add(Me.tableLayoutPanel2)
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.HeaderText = " Settings "
			Me.radGroupSettings.Location = New Point(20, 69)
			Me.radGroupSettings.Margin = New Padding(5, 5, 5, 5)
			Me.radGroupSettings.Name = "radGroupSettings"
			Me.radGroupSettings.Padding = New Padding(15, 31, 15, 15)
			Me.radGroupSettings.Size = New Size(355, 480)
			Me.radGroupSettings.TabIndex = 0
			Me.radGroupSettings.Text = " Settings "
			' 
			' tableLayoutPanel2
			' 
			Me.tableLayoutPanel2.ColumnCount = 2
			Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel2.Controls.Add(Me.radLabelInterval, 0, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.radButtonApply, 0, 5)
			Me.tableLayoutPanel2.Controls.Add(Me.intervalTextBox, 0, 1)
			Me.tableLayoutPanel2.Controls.Add(Me.radCheckBoxOpacity, 0, 4)
			Me.tableLayoutPanel2.Controls.Add(Me.radLabelMsec, 1, 1)
			Me.tableLayoutPanel2.Controls.Add(Me.locationAnimationTextBox, 0, 3)
			Me.tableLayoutPanel2.Controls.Add(Me.radLabelLocationAnimation, 0, 2)
			Me.tableLayoutPanel2.Location = New Point(20, 36)
			Me.tableLayoutPanel2.Margin = New Padding(5, 5, 5, 5)
			Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
			Me.tableLayoutPanel2.RowCount = 6
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel2.Size = New Size(312, 415)
			Me.tableLayoutPanel2.TabIndex = 12
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.tableLayoutPanel1.ColumnCount = 4
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.Controls.Add(Me.currentFrameTextBox, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.radButtonPrevious, 1, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.radButtonNext, 3, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.radStartStopButton, 2, 0)
			Me.tableLayoutPanel1.Location = New Point(1129, 1023)
			Me.tableLayoutPanel1.Margin = New Padding(5, 5, 5, 5)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 1
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Size = New Size(312, 89)
			Me.tableLayoutPanel1.TabIndex = 5
			' 
			' tableLayoutPanel3
			' 
			Me.tableLayoutPanel3.Dock = DockStyle.Fill
			Me.tableLayoutPanel3.ColumnCount = 1
			Me.tableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel3.Controls.Add(Me.tableLayoutPanel1, 0, 1)
			Me.tableLayoutPanel3.Controls.Add(Me.radRotator1, 0, 0)
			Me.tableLayoutPanel3.Location = New Point(4, 8)
			Me.tableLayoutPanel3.Margin = New Padding(4, 4, 4, 4)
			Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
			Me.tableLayoutPanel3.RowCount = 2
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 76.94915F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 23.05085F))
			Me.tableLayoutPanel3.Size = New Size(1446, 1324)
			Me.tableLayoutPanel3.TabIndex = 6
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.tableLayoutPanel3)
			Me.Name = "Form1"
			Me.Size = New Size(800, 800)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.tableLayoutPanel3, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radRotator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonPrevious, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonNext, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radStartStopButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.currentFrameTextBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelInterval, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.intervalTextBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxOpacity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.locationAnimationTextBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelMsec, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelLocationAnimation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonApply, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSettings.ResumeLayout(False)
			Me.tableLayoutPanel2.ResumeLayout(False)
			Me.tableLayoutPanel2.PerformLayout()
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel1.PerformLayout()
			Me.tableLayoutPanel3.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radRotator1 As Telerik.WinControls.UI.RadRotator
		Private radItemsContainer1 As Telerik.WinControls.UI.RadItemsContainer
		Private radImageItem1 As Telerik.WinControls.UI.RadImageItem
		Private radItemsContainer2 As Telerik.WinControls.UI.RadItemsContainer
		Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
		Private radLabelElement1 As Telerik.WinControls.UI.RadLabelElement
		Private radTextBoxElement1 As Telerik.WinControls.UI.RadTextBoxElement
		Private radButtonPrevious As Telerik.WinControls.UI.RadButton
		Private radButtonNext As Telerik.WinControls.UI.RadButton
		Private radStartStopButton As Telerik.WinControls.UI.RadButton
		Private currentFrameTextBox As Telerik.WinControls.UI.RadTextBox
		Private radLabelInterval As Telerik.WinControls.UI.RadLabel
		Private intervalTextBox As Telerik.WinControls.UI.RadTextBox
		Private radCheckBoxOpacity As Telerik.WinControls.UI.RadCheckBox
		Private locationAnimationTextBox As Telerik.WinControls.UI.RadTextBox
		Private radLabelMsec As Telerik.WinControls.UI.RadLabel
		Private radLabelLocationAnimation As Telerik.WinControls.UI.RadLabel
		Private radButtonApply As Telerik.WinControls.UI.RadButton
		Private radWebBrowserItem1 As Telerik.WinControls.UI.RadWebBrowserItem
		Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
		Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private tableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private tableLayoutPanel3 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace