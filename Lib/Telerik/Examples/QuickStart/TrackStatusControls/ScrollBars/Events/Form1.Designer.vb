Namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollBars.Events
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.radVScrollBar1 = New Telerik.WinControls.UI.RadVScrollBar()
            Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.scrollToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.leftTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.rightBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.pageLeftUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.pageRightBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
            Me.scrollLeftUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.scrollRightBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.radHScrollBar1 = New Telerik.WinControls.UI.RadHScrollBar()
            Me.radPanelDemo = New Telerik.WinControls.UI.RadPanel()
            Me.radBtnClear = New Telerik.WinControls.UI.RadButton()
            Me.radTxtEvents = New Telerik.WinControls.UI.RadTextBox()
            Me.radLblEvents = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radVScrollBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contextMenuStrip1.SuspendLayout()
            CType(Me.radHScrollBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanelDemo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBtnClear, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTxtEvents, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLblEvents, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.radPanelDemo)
            Me.radPanelDemoHolder.Controls.Add(Me.radHScrollBar1)
            Me.radPanelDemoHolder.Controls.Add(Me.radTxtEvents)
            Me.radPanelDemoHolder.Controls.Add(Me.radLblEvents)
            Me.radPanelDemoHolder.Controls.Add(Me.radBtnClear)
            Me.radPanelDemoHolder.Controls.Add(Me.radVScrollBar1)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(634, 584)
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(200, 196)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 196)
            '
            'radVScrollBar1
            '
            Me.radVScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.radVScrollBar1.ContextMenuStrip = Me.contextMenuStrip1
            Me.radVScrollBar1.ForeColor = System.Drawing.Color.Black
            Me.radVScrollBar1.LargeChange = 1
            Me.radVScrollBar1.Location = New System.Drawing.Point(542, 35)
            Me.radVScrollBar1.Margin = New System.Windows.Forms.Padding(2)
            Me.radVScrollBar1.Maximum = 20
            Me.radVScrollBar1.Minimum = 10
            Me.radVScrollBar1.Name = "radVScrollBar1"
            Me.radVScrollBar1.Size = New System.Drawing.Size(18, 226)
            Me.radVScrollBar1.TabIndex = 36
            Me.radVScrollBar1.Value = 15
            '
            'contextMenuStrip1
            '
            Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.scrollToToolStripMenuItem, Me.toolStripSeparator1, Me.leftTopToolStripMenuItem, Me.rightBottomToolStripMenuItem, Me.toolStripSeparator2, Me.pageLeftUpToolStripMenuItem, Me.pageRightBottomToolStripMenuItem, Me.toolStripSeparator3, Me.scrollLeftUpToolStripMenuItem, Me.scrollRightBottomToolStripMenuItem})
            Me.contextMenuStrip1.Name = "contextMenuStrip1"
            Me.contextMenuStrip1.Size = New System.Drawing.Size(177, 176)
            '
            'scrollToToolStripMenuItem
            '
            Me.scrollToToolStripMenuItem.Name = "scrollToToolStripMenuItem"
            Me.scrollToToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
            Me.scrollToToolStripMenuItem.Text = "Scroll To"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(173, 6)
            '
            'leftTopToolStripMenuItem
            '
            Me.leftTopToolStripMenuItem.Name = "leftTopToolStripMenuItem"
            Me.leftTopToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
            Me.leftTopToolStripMenuItem.Text = "Left / Top"
            '
            'rightBottomToolStripMenuItem
            '
            Me.rightBottomToolStripMenuItem.Name = "rightBottomToolStripMenuItem"
            Me.rightBottomToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
            Me.rightBottomToolStripMenuItem.Text = "Right  /Bottom"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(173, 6)
            '
            'pageLeftUpToolStripMenuItem
            '
            Me.pageLeftUpToolStripMenuItem.Name = "pageLeftUpToolStripMenuItem"
            Me.pageLeftUpToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
            Me.pageLeftUpToolStripMenuItem.Text = "Page Left / Up"
            '
            'pageRightBottomToolStripMenuItem
            '
            Me.pageRightBottomToolStripMenuItem.Name = "pageRightBottomToolStripMenuItem"
            Me.pageRightBottomToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
            Me.pageRightBottomToolStripMenuItem.Text = "Page Right / Down"
            '
            'toolStripSeparator3
            '
            Me.toolStripSeparator3.Name = "toolStripSeparator3"
            Me.toolStripSeparator3.Size = New System.Drawing.Size(173, 6)
            '
            'scrollLeftUpToolStripMenuItem
            '
            Me.scrollLeftUpToolStripMenuItem.Name = "scrollLeftUpToolStripMenuItem"
            Me.scrollLeftUpToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
            Me.scrollLeftUpToolStripMenuItem.Text = "Scroll Left / Up"
            '
            'scrollRightBottomToolStripMenuItem
            '
            Me.scrollRightBottomToolStripMenuItem.Name = "scrollRightBottomToolStripMenuItem"
            Me.scrollRightBottomToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
            Me.scrollRightBottomToolStripMenuItem.Text = "Scroll Right / Down"
            '
            'radHScrollBar1
            '
            Me.radHScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.radHScrollBar1.ContextMenuStrip = Me.contextMenuStrip1
            Me.radHScrollBar1.ForeColor = System.Drawing.Color.Black
            Me.radHScrollBar1.Location = New System.Drawing.Point(38, 265)
            Me.radHScrollBar1.Margin = New System.Windows.Forms.Padding(2)
            Me.radHScrollBar1.Name = "radHScrollBar1"
            Me.radHScrollBar1.Size = New System.Drawing.Size(501, 18)
            Me.radHScrollBar1.TabIndex = 35
            '
            'radPanelDemo
            '
            Me.radPanelDemo.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.radPanelDemo.ForeColor = System.Drawing.Color.Black
            Me.radPanelDemo.Location = New System.Drawing.Point(39, 35)
            Me.radPanelDemo.Name = "radPanelDemo"
            Me.radPanelDemo.Size = New System.Drawing.Size(499, 225)
            Me.radPanelDemo.TabIndex = 55
            '
            'radBtnClear
            '
            Me.radBtnClear.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.radBtnClear.Location = New System.Drawing.Point(261, 547)
            Me.radBtnClear.Name = "radBtnClear"
            Me.radBtnClear.Size = New System.Drawing.Size(77, 23)
            Me.radBtnClear.TabIndex = 56
            Me.radBtnClear.Text = "Clear"
            '
            'radTxtEvents
            '
            Me.radTxtEvents.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.radTxtEvents.AutoSize = False
            Me.radTxtEvents.Location = New System.Drawing.Point(39, 340)
            Me.radTxtEvents.Multiline = True
            Me.radTxtEvents.Name = "radTxtEvents"
            Me.radTxtEvents.ReadOnly = True
            Me.radTxtEvents.Size = New System.Drawing.Size(522, 204)
            Me.radTxtEvents.TabIndex = 57
            Me.radTxtEvents.TabStop = False
            '
            'radLblEvents
            '
            Me.radLblEvents.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.radLblEvents.Location = New System.Drawing.Point(39, 308)
            Me.radLblEvents.Name = "radLblEvents"
            Me.radLblEvents.Size = New System.Drawing.Size(135, 18)
            Me.radLblEvents.TabIndex = 58
            Me.radLblEvents.Text = "Received Scrolling Events:"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1172)
            Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.radPanelDemoHolder.PerformLayout()
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radVScrollBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.contextMenuStrip1.ResumeLayout(False)
            CType(Me.radHScrollBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanelDemo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBtnClear, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTxtEvents, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLblEvents, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private radHScrollBar1 As Telerik.WinControls.UI.RadHScrollBar
        Private radVScrollBar1 As Telerik.WinControls.UI.RadVScrollBar
        Private radPanelDemo As Telerik.WinControls.UI.RadPanel
        Private radBtnClear As Telerik.WinControls.UI.RadButton
        Private radTxtEvents As Telerik.WinControls.UI.RadTextBox
        Private radLblEvents As Telerik.WinControls.UI.RadLabel
        Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
        Private scrollToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Private leftTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private rightBottomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Private pageLeftUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private pageRightBottomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
        Private scrollLeftUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private scrollRightBottomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace
