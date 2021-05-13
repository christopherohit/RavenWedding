Namespace CS
	Partial Public Class RadForm1
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
            Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
            Me.commandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.commandBarStripElement2 = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.refreshButton = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.addSubscriptionButton = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.newCategoryButton = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.windowButton = New Telerik.WinControls.UI.CommandBarDropDownButton()
            Me.commandBarStripElement3 = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.commandBarLabel1 = New Telerik.WinControls.UI.CommandBarLabel()
            Me.office2010SilverButton = New Telerik.WinControls.UI.CommandBarButton()
            Me.office2010BlackButton = New Telerik.WinControls.UI.CommandBarButton()
            Me.office2010BlueButton = New Telerik.WinControls.UI.CommandBarButton()
            Me.controlDefaultButton = New Telerik.WinControls.UI.CommandBarButton()
            Me.telerikButton = New Telerik.WinControls.UI.CommandBarButton()
            Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
            Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.feedContentCommandBar = New Telerik.WinControls.UI.RadCommandBar()
            Me.commandBarRowElement2 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.commandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.scrollToPanelButton = New Telerik.WinControls.UI.CommandBarButton()
            Me.openInBrowserButton = New Telerik.WinControls.UI.CommandBarButton()
            Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
            Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
            Me.office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
            Me.office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
            Me.telerikTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
            CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radDock1.SuspendLayout()
            Me.toolWindow1.SuspendLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.feedContentCommandBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.toolTabStrip1.SuspendLayout()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radCommandBar1
            '
            Me.radCommandBar1.AutoSize = True
            Me.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radCommandBar1.Location = New System.Drawing.Point(0, 0)
            Me.radCommandBar1.Name = "radCommandBar1"
            Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.commandBarRowElement1})
            Me.radCommandBar1.Size = New System.Drawing.Size(1069, 30)
            Me.radCommandBar1.TabIndex = 0
            Me.radCommandBar1.Text = "radCommandBar1"
            '
            'commandBarRowElement1
            '
            Me.commandBarRowElement1.DisplayName = Nothing
            Me.commandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.commandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.commandBarStripElement2, Me.commandBarStripElement3})
            '
            'commandBarStripElement2
            '
            Me.commandBarStripElement2.DisplayName = "commandBarStripElement1"
            Me.commandBarStripElement2.DrawText = True
            Me.commandBarStripElement2.FloatingForm = Nothing
            Me.commandBarStripElement2.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.refreshButton, Me.commandBarSeparator1, Me.addSubscriptionButton, Me.commandBarSeparator2, Me.newCategoryButton, Me.commandBarSeparator3, Me.windowButton})
            Me.commandBarStripElement2.Name = "commandBarStripElement1"
            Me.commandBarStripElement2.Text = ""
            Me.commandBarStripElement2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'refreshButton
            '
            Me.refreshButton.AccessibleDescription = "commandBarButton1"
            Me.refreshButton.AccessibleName = "commandBarButton1"
            Me.refreshButton.DisplayName = "Refresh"
            Me.refreshButton.Image = Global.My.Resources.Resources.arrow_refresh
            Me.refreshButton.Name = "refreshButton"
            Me.refreshButton.Text = "commandBarButton1"
            Me.refreshButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.refreshButton.VisibleInOverflowMenu = True
            '
            'commandBarSeparator1
            '
            Me.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1"
            Me.commandBarSeparator1.AccessibleName = "commandBarSeparator1"
            Me.commandBarSeparator1.DisplayName = "commandBarSeparator1"
            Me.commandBarSeparator1.Name = "commandBarSeparator1"
            Me.commandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.commandBarSeparator1.VisibleInOverflowMenu = False
            '
            'addSubscriptionButton
            '
            Me.addSubscriptionButton.AccessibleDescription = "commandBarButton2"
            Me.addSubscriptionButton.AccessibleName = "commandBarButton2"
            Me.addSubscriptionButton.DisplayName = "Add subscription"
            Me.addSubscriptionButton.DrawText = True
            Me.addSubscriptionButton.Image = Global.My.Resources.Resources.feed_add
            Me.addSubscriptionButton.Name = "addSubscriptionButton"
            Me.addSubscriptionButton.Text = "Add subscription"
            Me.addSubscriptionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.addSubscriptionButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.addSubscriptionButton.VisibleInOverflowMenu = True
            '
            'commandBarSeparator2
            '
            Me.commandBarSeparator2.AccessibleDescription = "commandBarSeparator2"
            Me.commandBarSeparator2.AccessibleName = "commandBarSeparator2"
            Me.commandBarSeparator2.DisplayName = "commandBarSeparator2"
            Me.commandBarSeparator2.Name = "commandBarSeparator2"
            Me.commandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.commandBarSeparator2.VisibleInOverflowMenu = False
            '
            'newCategoryButton
            '
            Me.newCategoryButton.AccessibleDescription = "commandBarButton1"
            Me.newCategoryButton.AccessibleName = "commandBarButton1"
            Me.newCategoryButton.DisplayName = "Window"
            Me.newCategoryButton.DrawText = True
            Me.newCategoryButton.Image = Global.My.Resources.Resources.folder_feed
            Me.newCategoryButton.Name = "newCategoryButton"
            Me.newCategoryButton.Text = "New category"
            Me.newCategoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.newCategoryButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.newCategoryButton.VisibleInOverflowMenu = True
            '
            'commandBarSeparator3
            '
            Me.commandBarSeparator3.AccessibleDescription = "commandBarSeparator3"
            Me.commandBarSeparator3.AccessibleName = "commandBarSeparator3"
            Me.commandBarSeparator3.DisplayName = "commandBarSeparator3"
            Me.commandBarSeparator3.Name = "commandBarSeparator3"
            Me.commandBarSeparator3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.commandBarSeparator3.VisibleInOverflowMenu = False
            '
            'windowButton
            '
            Me.windowButton.AccessibleDescription = "Windows"
            Me.windowButton.AccessibleName = "Windows"
            Me.windowButton.DisplayName = "commandBarDropDownButton1"
            Me.windowButton.DrawText = True
            Me.windowButton.Image = Global.My.Resources.Resources.application_double
            Me.windowButton.Name = "windowButton"
            Me.windowButton.Text = "Window"
            Me.windowButton.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.windowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.windowButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.windowButton.VisibleInOverflowMenu = True
            '
            'commandBarStripElement3
            '
            Me.commandBarStripElement3.DisplayName = "commandBarStripElement3"
            Me.commandBarStripElement3.FloatingForm = Nothing
            Me.commandBarStripElement3.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.commandBarLabel1, Me.office2010SilverButton, Me.office2010BlackButton, Me.office2010BlueButton, Me.controlDefaultButton, Me.telerikButton})
            Me.commandBarStripElement3.Name = "commandBarStripElement3"
            Me.commandBarStripElement3.Text = ""
            '
            'commandBarLabel1
            '
            Me.commandBarLabel1.AccessibleDescription = "Themes:"
            Me.commandBarLabel1.AccessibleName = "Themes:"
            Me.commandBarLabel1.DisplayName = "commandBarLabel1"
            Me.commandBarLabel1.Name = "commandBarLabel1"
            Me.commandBarLabel1.Text = "Themes:"
            Me.commandBarLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.commandBarLabel1.VisibleInOverflowMenu = False
            '
            'office2010SilverButton
            '
            Me.office2010SilverButton.AccessibleDescription = "Office2010Silver"
            Me.office2010SilverButton.AccessibleName = "Office2010Silver"
            Me.office2010SilverButton.DisplayName = "Office2010Silver"
            Me.office2010SilverButton.Image = Global.My.Resources.Resources.theme_silver
            Me.office2010SilverButton.Name = "office2010SilverButton"
            Me.office2010SilverButton.Text = "Office2010Silver"
            Me.office2010SilverButton.ToolTipText = "Office2010Silver"
            Me.office2010SilverButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.office2010SilverButton.VisibleInOverflowMenu = True
            '
            'office2010BlackButton
            '
            Me.office2010BlackButton.AccessibleDescription = "Office2010Black"
            Me.office2010BlackButton.AccessibleName = "Office2010Black"
            Me.office2010BlackButton.DisplayName = "Office2010Black"
            Me.office2010BlackButton.Image = Global.My.Resources.Resources.theme_black
            Me.office2010BlackButton.Name = "office2010BlackButton"
            Me.office2010BlackButton.Text = "Office2010Black"
            Me.office2010BlackButton.ToolTipText = "Office2010Black"
            Me.office2010BlackButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.office2010BlackButton.VisibleInOverflowMenu = True
            '
            'office2010BlueButton
            '
            Me.office2010BlueButton.AccessibleDescription = "Office2010Blue"
            Me.office2010BlueButton.AccessibleName = "Office2010Blue"
            Me.office2010BlueButton.DisplayName = "Office2010Blue"
            Me.office2010BlueButton.Image = Global.My.Resources.Resources.theme_blue
            Me.office2010BlueButton.Name = "office2010BlueButton"
            Me.office2010BlueButton.Text = "Office2010Blue"
            Me.office2010BlueButton.ToolTipText = "Office2010Blue"
            Me.office2010BlueButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.office2010BlueButton.VisibleInOverflowMenu = True
            '
            'controlDefaultButton
            '
            Me.controlDefaultButton.AccessibleDescription = "ControlDefault"
            Me.controlDefaultButton.AccessibleName = "ControlDefault"
            Me.controlDefaultButton.DisplayName = "ControlDefault"
            Me.controlDefaultButton.Image = Global.My.Resources.Resources.theme_default
            Me.controlDefaultButton.Name = "controlDefaultButton"
            Me.controlDefaultButton.Text = "ControlDefault"
            Me.controlDefaultButton.ToolTipText = "ControlDefault"
            Me.controlDefaultButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.controlDefaultButton.VisibleInOverflowMenu = True
            '
            'telerikButton
            '
            Me.telerikButton.AccessibleDescription = "Telerik"
            Me.telerikButton.AccessibleName = "Telerik"
            Me.telerikButton.DisplayName = "TelerikMetro"
            Me.telerikButton.Image = Global.My.Resources.Resources.theme_telerik
            Me.telerikButton.Name = "telerikButton"
            Me.telerikButton.Text = "TelerikMetro"
            Me.telerikButton.ToolTipText = "Telerik"
            Me.telerikButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.telerikButton.VisibleInOverflowMenu = True
            '
            'radDock1
            '
            Me.radDock1.ActiveWindow = Me.toolWindow1
            Me.radDock1.Controls.Add(Me.documentContainer1)
            Me.radDock1.Controls.Add(Me.toolTabStrip1)
            Me.radDock1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
            Me.radDock1.IsCleanUpTarget = True
            Me.radDock1.Location = New System.Drawing.Point(0, 30)
            Me.radDock1.MainDocumentContainer = Me.documentContainer1
            Me.radDock1.Name = "radDock1"
            Me.radDock1.Orientation = System.Windows.Forms.Orientation.Horizontal
            Me.radDock1.Padding = New System.Windows.Forms.Padding(5)
            '
            '
            '
            Me.radDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.radDock1.RootElement.Padding = New System.Windows.Forms.Padding(5)
            Me.radDock1.Size = New System.Drawing.Size(1069, 599)
            Me.radDock1.SplitterWidth = 4
            Me.radDock1.TabIndex = 1
            Me.radDock1.TabStop = False
            Me.radDock1.Text = "radDock1"
            '
            'toolWindow1
            '
            Me.toolWindow1.Caption = Nothing
            Me.toolWindow1.Controls.Add(Me.webBrowser1)
            Me.toolWindow1.Controls.Add(Me.radLabel1)
            Me.toolWindow1.Controls.Add(Me.feedContentCommandBar)
            Me.toolWindow1.Location = New System.Drawing.Point(1, 24)
            Me.toolWindow1.Name = "toolWindow1"
            Me.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.toolWindow1.Size = New System.Drawing.Size(1057, 174)
            Me.toolWindow1.Text = "Feed content"
            '
            'webBrowser1
            '
            Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.webBrowser1.Location = New System.Drawing.Point(31, 25)
            Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.webBrowser1.Name = "webBrowser1"
            Me.webBrowser1.Size = New System.Drawing.Size(1026, 149)
            Me.webBrowser1.TabIndex = 0
            '
            'radLabel1
            '
            Me.radLabel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radLabel1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radLabel1.Location = New System.Drawing.Point(31, 0)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(14, 25)
            Me.radLabel1.TabIndex = 5
            Me.radLabel1.Text = " "
            '
            'feedContentCommandBar
            '
            Me.feedContentCommandBar.AutoSize = True
            Me.feedContentCommandBar.Dock = System.Windows.Forms.DockStyle.Left
            Me.feedContentCommandBar.Location = New System.Drawing.Point(0, 0)
            Me.feedContentCommandBar.Name = "feedContentCommandBar"
            Me.feedContentCommandBar.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.feedContentCommandBar.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.commandBarRowElement2})
            Me.feedContentCommandBar.Size = New System.Drawing.Size(31, 174)
            Me.feedContentCommandBar.TabIndex = 4
            Me.feedContentCommandBar.Text = "radCommandBar2"
            '
            'commandBarRowElement2
            '
            Me.commandBarRowElement2.DisplayName = Nothing
            Me.commandBarRowElement2.MinSize = New System.Drawing.Size(25, 25)
            Me.commandBarRowElement2.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.commandBarStripElement1})
            '
            'commandBarStripElement1
            '
            Me.commandBarStripElement1.DisplayName = "commandBarStripElement1"
            Me.commandBarStripElement1.FloatingForm = Nothing
            Me.commandBarStripElement1.GradientAngle = 1440.0!
            Me.commandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.scrollToPanelButton, Me.openInBrowserButton})
            Me.commandBarStripElement1.Name = "commandBarStripElement1"
            Me.commandBarStripElement1.StretchHorizontally = False
            Me.commandBarStripElement1.StretchVertically = False
            Me.commandBarStripElement1.Text = ""
            '
            'scrollToPanelButton
            '
            Me.scrollToPanelButton.AccessibleDescription = "commandBarButton1"
            Me.scrollToPanelButton.AccessibleName = "commandBarButton1"
            Me.scrollToPanelButton.DisplayName = "commandBarButton1"
            Me.scrollToPanelButton.Image = Global.My.Resources.Resources.application_go
            Me.scrollToPanelButton.Name = "scrollToPanelButton"
            Me.scrollToPanelButton.StretchHorizontally = False
            Me.scrollToPanelButton.StretchVertically = False
            Me.scrollToPanelButton.Text = "commandBarButton1"
            Me.scrollToPanelButton.ToolTipText = "Scroll to panel"
            Me.scrollToPanelButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.scrollToPanelButton.VisibleInOverflowMenu = True
            '
            'openInBrowserButton
            '
            Me.openInBrowserButton.AccessibleDescription = "commandBarButton2"
            Me.openInBrowserButton.AccessibleName = "commandBarButton2"
            Me.openInBrowserButton.DisplayName = "commandBarButton2"
            Me.openInBrowserButton.Image = Global.My.Resources.Resources.page_world
            Me.openInBrowserButton.Name = "openInBrowserButton"
            Me.openInBrowserButton.StretchHorizontally = False
            Me.openInBrowserButton.StretchVertically = False
            Me.openInBrowserButton.Text = "commandBarButton2"
            Me.openInBrowserButton.ToolTipText = "Open in browser"
            Me.openInBrowserButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.openInBrowserButton.VisibleInOverflowMenu = True
            '
            'documentContainer1
            '
            Me.documentContainer1.Location = New System.Drawing.Point(5, 5)
            Me.documentContainer1.Name = "documentContainer1"
            '
            '
            '
            Me.documentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.documentContainer1.Size = New System.Drawing.Size(1059, 385)
            Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
            Me.documentContainer1.SplitterWidth = 4
            Me.documentContainer1.TabIndex = 0
            Me.documentContainer1.TabStop = False
            '
            'toolTabStrip1
            '
            Me.toolTabStrip1.Controls.Add(Me.toolWindow1)
            Me.toolTabStrip1.Location = New System.Drawing.Point(5, 394)
            Me.toolTabStrip1.Name = "toolTabStrip1"
            '
            '
            '
            Me.toolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.toolTabStrip1.SelectedIndex = 0
            Me.toolTabStrip1.Size = New System.Drawing.Size(1059, 200)
            Me.toolTabStrip1.TabIndex = 1
            Me.toolTabStrip1.TabStop = False
            '
            'RadForm1
            '
            Me.ClientSize = New System.Drawing.Size(1069, 629)
            Me.Controls.Add(Me.radDock1)
            Me.Controls.Add(Me.radCommandBar1)
            Me.Name = "RadForm1"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Rss reader by Telerik"
            Me.ThemeName = "ControlDefault"
            CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radDock1.ResumeLayout(False)
            Me.toolWindow1.ResumeLayout(False)
            Me.toolWindow1.PerformLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.feedContentCommandBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.toolTabStrip1.ResumeLayout(False)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
		Private commandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
		Private commandBarStripElement2 As Telerik.WinControls.UI.CommandBarStripElement
		Private newCategoryButton As Telerik.WinControls.UI.CommandBarButton
		Private addSubscriptionButton As Telerik.WinControls.UI.CommandBarButton
		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
        Private webBrowser1 As WebBrowser
		Private windowButton As Telerik.WinControls.UI.CommandBarDropDownButton
		Private commandBarStripElement3 As Telerik.WinControls.UI.CommandBarStripElement
		Private refreshButton As Telerik.WinControls.UI.CommandBarButton
		Private commandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
		Private commandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
		Private commandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
		Private commandBarLabel1 As Telerik.WinControls.UI.CommandBarLabel
		Private office2010SilverButton As Telerik.WinControls.UI.CommandBarButton
		Private office2010BlackButton As Telerik.WinControls.UI.CommandBarButton
		Private office2010BlueButton As Telerik.WinControls.UI.CommandBarButton
		Private controlDefaultButton As Telerik.WinControls.UI.CommandBarButton
		Private telerikButton As Telerik.WinControls.UI.CommandBarButton
		Private office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
		Private office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
		Private office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
        Private feedContentCommandBar As Telerik.WinControls.UI.RadCommandBar
		Private commandBarRowElement2 As Telerik.WinControls.UI.CommandBarRowElement
		Private commandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
		Private WithEvents scrollToPanelButton As Telerik.WinControls.UI.CommandBarButton
		Private WithEvents openInBrowserButton As Telerik.WinControls.UI.CommandBarButton
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Friend WithEvents toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Private WithEvents telerikTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
	End Class
End Namespace
