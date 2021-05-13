Namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollBars.FirstLook
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
			Me.contextMenuStrip1 = New ContextMenuStrip(Me.components)
			Me.scrollToToolStripMenuItem = New ToolStripMenuItem()
			Me.toolStripSeparator1 = New ToolStripSeparator()
			Me.leftTopToolStripMenuItem = New ToolStripMenuItem()
			Me.rightBottomToolStripMenuItem = New ToolStripMenuItem()
			Me.toolStripSeparator2 = New ToolStripSeparator()
			Me.pageLeftUpToolStripMenuItem = New ToolStripMenuItem()
			Me.pageRightBottomToolStripMenuItem = New ToolStripMenuItem()
			Me.toolStripSeparator3 = New ToolStripSeparator()
			Me.scrollLeftUpToolStripMenuItem = New ToolStripMenuItem()
			Me.scrollRightBottomToolStripMenuItem = New ToolStripMenuItem()
			Me.radVScrollBar1 = New Telerik.WinControls.UI.RadVScrollBar()
			Me.radHScrollBar1 = New Telerik.WinControls.UI.RadHScrollBar()
			Me.spinMinThumb = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinThumbLength = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinValue = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinLargeChange = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinMax = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinMin = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinSmallChange = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radGroupCommonSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLblThumbLengthProp = New Telerik.WinControls.UI.RadLabel()
			Me.radLblMinThumbLength = New Telerik.WinControls.UI.RadLabel()
			Me.radLblValue = New Telerik.WinControls.UI.RadLabel()
			Me.radLblSmallChange = New Telerik.WinControls.UI.RadLabel()
			Me.radLblMinimum = New Telerik.WinControls.UI.RadLabel()
			Me.radLblLargeChange = New Telerik.WinControls.UI.RadLabel()
			Me.radLblMaximum = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			Me.contextMenuStrip1.SuspendLayout()
			CType(Me.radVScrollBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radHScrollBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinMinThumb, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinThumbLength, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinValue, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinLargeChange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinMax, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinMin, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinSmallChange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupCommonSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupCommonSettings.SuspendLayout()
			CType(Me.radLblThumbLengthProp, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblMinThumbLength, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblValue, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblSmallChange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblMinimum, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblLargeChange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblMaximum, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radPanel1)
			Me.radPanelDemoHolder.Controls.Add(Me.radVScrollBar1)
			Me.radPanelDemoHolder.Controls.Add(Me.radHScrollBar1)
			Me.radPanelDemoHolder.ForeColor = Color.Black
			Me.radPanelDemoHolder.Size = New Size(483, 357)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupCommonSettings)
			Me.settingsPanel.Location = New Point(796, 1)
			Me.settingsPanel.Size = New Size(200, 632)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupCommonSettings, 0)
			' 
			' contextMenuStrip1
			' 
			Me.contextMenuStrip1.Items.AddRange(New ToolStripItem() { Me.scrollToToolStripMenuItem, Me.toolStripSeparator1, Me.leftTopToolStripMenuItem, Me.rightBottomToolStripMenuItem, Me.toolStripSeparator2, Me.pageLeftUpToolStripMenuItem, Me.pageRightBottomToolStripMenuItem, Me.toolStripSeparator3, Me.scrollLeftUpToolStripMenuItem, Me.scrollRightBottomToolStripMenuItem})
			Me.contextMenuStrip1.Name = "contextMenuStrip1"
			Me.contextMenuStrip1.Size = New Size(177, 176)
			' 
			' scrollToToolStripMenuItem
			' 
			Me.scrollToToolStripMenuItem.Name = "scrollToToolStripMenuItem"
			Me.scrollToToolStripMenuItem.Size = New Size(176, 22)
			Me.scrollToToolStripMenuItem.Text = "Scroll To"

			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New Size(173, 6)
			' 
			' leftTopToolStripMenuItem
			' 
			Me.leftTopToolStripMenuItem.Name = "leftTopToolStripMenuItem"
			Me.leftTopToolStripMenuItem.Size = New Size(176, 22)
			Me.leftTopToolStripMenuItem.Text = "Left / Top"

			' 
			' rightBottomToolStripMenuItem
			' 
			Me.rightBottomToolStripMenuItem.Name = "rightBottomToolStripMenuItem"
			Me.rightBottomToolStripMenuItem.Size = New Size(176, 22)
			Me.rightBottomToolStripMenuItem.Text = "Right  /Bottom"

			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New Size(173, 6)
			' 
			' pageLeftUpToolStripMenuItem
			' 
			Me.pageLeftUpToolStripMenuItem.Name = "pageLeftUpToolStripMenuItem"
			Me.pageLeftUpToolStripMenuItem.Size = New Size(176, 22)
			Me.pageLeftUpToolStripMenuItem.Text = "Page Left / Up"

			' 
			' pageRightBottomToolStripMenuItem
			' 
			Me.pageRightBottomToolStripMenuItem.Name = "pageRightBottomToolStripMenuItem"
			Me.pageRightBottomToolStripMenuItem.Size = New Size(176, 22)
			Me.pageRightBottomToolStripMenuItem.Text = "Page Right / Down"

			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New Size(173, 6)
			' 
			' scrollLeftUpToolStripMenuItem
			' 
			Me.scrollLeftUpToolStripMenuItem.Name = "scrollLeftUpToolStripMenuItem"
			Me.scrollLeftUpToolStripMenuItem.Size = New Size(176, 22)
			Me.scrollLeftUpToolStripMenuItem.Text = "Scroll Left / Up"

			' 
			' scrollRightBottomToolStripMenuItem
			' 
			Me.scrollRightBottomToolStripMenuItem.Name = "scrollRightBottomToolStripMenuItem"
			Me.scrollRightBottomToolStripMenuItem.Size = New Size(176, 22)
			Me.scrollRightBottomToolStripMenuItem.Text = "Scroll Right / Down"

			' 
			' radVScrollBar1
			' 
			Me.radVScrollBar1.ContextMenuStrip = Me.contextMenuStrip1
			Me.radVScrollBar1.Location = New Point(333, 0)
			Me.radVScrollBar1.Margin = New Padding(2)
			Me.radVScrollBar1.Name = "radVScrollBar1"
			Me.radVScrollBar1.Size = New Size(18, 293)
			Me.radVScrollBar1.TabIndex = 36
			Me.radVScrollBar1.Text = "radVScrollBar1"

			' 
			' radHScrollBar1
			' 
			Me.radHScrollBar1.ContextMenuStrip = Me.contextMenuStrip1
			Me.radHScrollBar1.Location = New Point(1, 298)
			Me.radHScrollBar1.Margin = New Padding(2)
			Me.radHScrollBar1.Name = "radHScrollBar1"
			Me.radHScrollBar1.Size = New Size(325, 18)
			Me.radHScrollBar1.TabIndex = 35
			Me.radHScrollBar1.Text = "radHScrollBar1"

			' 
			' spinMinThumb
			' 
			Me.spinMinThumb.Location = New Point(16, 195)
			Me.spinMinThumb.Name = "spinMinThumb"
			' 
			' 
			' 
			Me.spinMinThumb.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinMinThumb.Size = New Size(113, 20)
			Me.spinMinThumb.TabIndex = 69
			Me.spinMinThumb.TabStop = False

			' 
			' spinThumbLength
			' 
			Me.spinThumbLength.DecimalPlaces = 2
			Me.spinThumbLength.Increment = New Decimal(New Integer() { 1, 0, 0, 65536})
			Me.spinThumbLength.Location = New Point(16, 245)
			Me.spinThumbLength.Maximum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinThumbLength.Minimum = New Decimal(New Integer() { 1, 0, 0, -2147483648})
			Me.spinThumbLength.Name = "spinThumbLength"
			' 
			' 
			' 
			Me.spinThumbLength.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinThumbLength.Size = New Size(113, 20)
			Me.spinThumbLength.TabIndex = 67
			Me.spinThumbLength.TabStop = False
			Me.spinThumbLength.Value = New Decimal(New Integer() { 10, 0, 0, 131072})

			' 
			' spinValue
			' 
			Me.spinValue.Location = New Point(91, 147)
			Me.spinValue.Name = "spinValue"
			' 
			' 
			' 
			Me.spinValue.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinValue.Size = New Size(62, 20)
			Me.spinValue.TabIndex = 68
			Me.spinValue.TabStop = False
			Me.spinValue.Tag = "Right"

			' 
			' spinLargeChange
			' 
			Me.spinLargeChange.Location = New Point(91, 91)
			Me.spinLargeChange.Name = "spinLargeChange"
			' 
			' 
			' 
			Me.spinLargeChange.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinLargeChange.Size = New Size(62, 20)
			Me.spinLargeChange.TabIndex = 66
			Me.spinLargeChange.TabStop = False
			Me.spinLargeChange.Tag = "Right"

			' 
			' spinMax
			' 
			Me.spinMax.Location = New Point(91, 35)
			Me.spinMax.Name = "spinMax"
			' 
			' 
			' 
			Me.spinMax.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinMax.Size = New Size(62, 20)
			Me.spinMax.TabIndex = 63
			Me.spinMax.TabStop = False
			Me.spinMax.Tag = "Right"

			' 
			' spinMin
			' 
			Me.spinMin.Location = New Point(91, 63)
			Me.spinMin.Name = "spinMin"
			' 
			' 
			' 
			Me.spinMin.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinMin.Size = New Size(62, 20)
			Me.spinMin.TabIndex = 64
			Me.spinMin.TabStop = False
			Me.spinMin.Tag = "Right"

			' 
			' spinSmallChange
			' 
			Me.spinSmallChange.Location = New Point(91, 119)
			Me.spinSmallChange.Name = "spinSmallChange"
			' 
			' 
			' 
			Me.spinSmallChange.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinSmallChange.Size = New Size(62, 20)
			Me.spinSmallChange.TabIndex = 65
			Me.spinSmallChange.TabStop = False
			Me.spinSmallChange.Tag = "Right"

			' 
			' radPanel1
			' 
			Me.radPanel1.ForeColor = Color.Black
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(326, 293)
			Me.radPanel1.TabIndex = 63
			' 
			' radGroupCommonSettings
			' 
			Me.radGroupCommonSettings.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupCommonSettings.Anchor = AnchorStyles.Top
			Me.radGroupCommonSettings.Controls.Add(Me.radLblThumbLengthProp)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblMinThumbLength)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblValue)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblSmallChange)
			Me.radGroupCommonSettings.Controls.Add(Me.spinMinThumb)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblMinimum)
			Me.radGroupCommonSettings.Controls.Add(Me.spinThumbLength)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblLargeChange)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblMaximum)
			Me.radGroupCommonSettings.Controls.Add(Me.spinMax)
			Me.radGroupCommonSettings.Controls.Add(Me.spinSmallChange)
			Me.radGroupCommonSettings.Controls.Add(Me.spinMin)
			Me.radGroupCommonSettings.Controls.Add(Me.spinValue)
			Me.radGroupCommonSettings.Controls.Add(Me.spinLargeChange)
			Me.radGroupCommonSettings.FooterText = ""
			Me.radGroupCommonSettings.HeaderText = "Settings"
			Me.radGroupCommonSettings.Location = New Point(10, 6)
			Me.radGroupCommonSettings.Name = "radGroupCommonSettings"
			' 
			' 
			' 
			Me.radGroupCommonSettings.RootElement.Padding = New Padding(2, 18, 2, 2)
			Me.radGroupCommonSettings.Size = New Size(180, 284)
			Me.radGroupCommonSettings.TabIndex = 0
			Me.radGroupCommonSettings.Text = "Settings"
			' 
			' radLblThumbLengthProp
			' 
			Me.radLblThumbLengthProp.Location = New Point(8, 223)
			Me.radLblThumbLengthProp.Name = "radLblThumbLengthProp"
			Me.radLblThumbLengthProp.Size = New Size(138, 18)
			Me.radLblThumbLengthProp.TabIndex = 69
			Me.radLblThumbLengthProp.Text = "Thumb Length Proportion:"
			' 
			' radLblMinThumbLength
			' 
			Me.radLblMinThumbLength.Location = New Point(10, 173)
			Me.radLblMinThumbLength.Name = "radLblMinThumbLength"
			Me.radLblMinThumbLength.Size = New Size(104, 18)
			Me.radLblMinThumbLength.TabIndex = 69
			Me.radLblMinThumbLength.Text = "Min Thumb Length:"
			' 
			' radLblValue
			' 
			Me.radLblValue.Location = New Point(10, 147)
			Me.radLblValue.Name = "radLblValue"
			Me.radLblValue.Size = New Size(37, 18)
			Me.radLblValue.TabIndex = 69
			Me.radLblValue.Text = "Value:"
			' 
			' radLblSmallChange
			' 
			Me.radLblSmallChange.Location = New Point(7, 122)
			Me.radLblSmallChange.Name = "radLblSmallChange"
			Me.radLblSmallChange.Size = New Size(77, 18)
			Me.radLblSmallChange.TabIndex = 69
			Me.radLblSmallChange.Text = "Small Change:"
			' 
			' radLblMinimum
			' 
			Me.radLblMinimum.Location = New Point(10, 66)
			Me.radLblMinimum.Name = "radLblMinimum"
			Me.radLblMinimum.Size = New Size(57, 18)
			Me.radLblMinimum.TabIndex = 69
			Me.radLblMinimum.Text = "Minimum:"
			' 
			' radLblLargeChange
			' 
			Me.radLblLargeChange.Location = New Point(7, 94)
			Me.radLblLargeChange.Name = "radLblLargeChange"
			Me.radLblLargeChange.Size = New Size(78, 18)
			Me.radLblLargeChange.TabIndex = 69
			Me.radLblLargeChange.Text = "Large Change:"
			' 
			' radLblMaximum
			' 
			Me.radLblMaximum.Location = New Point(8, 38)
			Me.radLblMaximum.Name = "radLblMaximum"
			Me.radLblMaximum.Size = New Size(58, 18)
			Me.radLblMaximum.TabIndex = 69
			Me.radLblMaximum.Text = "Maximum:"
			' 
			' Form1
			' 
			Me.Name = "Form1"
            Me.Size = New Size(1063, 516)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			Me.contextMenuStrip1.ResumeLayout(False)
			CType(Me.radVScrollBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radHScrollBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinMinThumb, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinThumbLength, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinValue, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinLargeChange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinMax, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinMin, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinSmallChange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupCommonSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupCommonSettings.ResumeLayout(False)
			Me.radGroupCommonSettings.PerformLayout()
			CType(Me.radLblThumbLengthProp, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblMinThumbLength, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblValue, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblSmallChange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblMinimum, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblLargeChange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblMaximum, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radHScrollBar1 As Telerik.WinControls.UI.RadHScrollBar
		Private radVScrollBar1 As Telerik.WinControls.UI.RadVScrollBar
		Private contextMenuStrip1 As ContextMenuStrip
		Private scrollToToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator1 As ToolStripSeparator
		Private leftTopToolStripMenuItem As ToolStripMenuItem
		Private rightBottomToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator2 As ToolStripSeparator
		Private pageLeftUpToolStripMenuItem As ToolStripMenuItem
		Private pageRightBottomToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator3 As ToolStripSeparator
		Private scrollLeftUpToolStripMenuItem As ToolStripMenuItem
		Private scrollRightBottomToolStripMenuItem As ToolStripMenuItem
		Private spinMinThumb As Telerik.WinControls.UI.RadSpinEditor
		Private spinValue As Telerik.WinControls.UI.RadSpinEditor
		Private spinLargeChange As Telerik.WinControls.UI.RadSpinEditor
		Private spinMax As Telerik.WinControls.UI.RadSpinEditor
		Private spinThumbLength As Telerik.WinControls.UI.RadSpinEditor
		Private spinMin As Telerik.WinControls.UI.RadSpinEditor
		Private spinSmallChange As Telerik.WinControls.UI.RadSpinEditor
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radGroupCommonSettings As Telerik.WinControls.UI.RadGroupBox
		Private radLblValue As Telerik.WinControls.UI.RadLabel
		Private radLblSmallChange As Telerik.WinControls.UI.RadLabel
		Private radLblMinimum As Telerik.WinControls.UI.RadLabel
		Private radLblLargeChange As Telerik.WinControls.UI.RadLabel
		Private radLblMaximum As Telerik.WinControls.UI.RadLabel
		Private radLblThumbLengthProp As Telerik.WinControls.UI.RadLabel
		Private radLblMinThumbLength As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace