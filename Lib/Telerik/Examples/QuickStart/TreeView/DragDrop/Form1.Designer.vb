Namespace Telerik.Examples.WinControls.TreeView.DragDrop
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim radTreeNode11 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode12 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode13 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode14 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode15 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode16 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode17 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode18 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode19 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode20 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim radTreeNode21 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode22 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode23 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode24 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode25 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode26 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode27 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode28 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode29 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Dim radTreeNode30 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
            Me.radTreeView2 = New Telerik.WinControls.UI.RadTreeView()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
            Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
            Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
            Me.radPanel1 = New Telerik.Examples.WinControls.TreeView.TreeExampleHeaderPanel()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType((Me.radTreeView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radTreeView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radTextBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radPanel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel2.SuspendLayout()
            CType((Me.radPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(1211, 1)
            Me.settingsPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.settingsPanel.PanelContainer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(992, 1248)
            Me.settingsPanel.Size = New System.Drawing.Size(992, 1248)
            Me.radTreeView2.AllowDragDrop = True
            Me.radTreeView2.AllowDrop = True
            Me.radTreeView2.Dock = System.Windows.Forms.DockStyle.Right
            Me.radTreeView2.ImageList = Me.imageList1
            Me.radTreeView2.ItemHeight = 25
            Me.radTreeView2.Location = New System.Drawing.Point(487, 25)
            Me.radTreeView2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.radTreeView2.Name = "radTreeView2"
            radTreeNode11.Expanded = True
            radTreeNode11.Image = (CType((resources.GetObject("radTreeNode11.Image")), System.Drawing.Image))
            radTreeNode11.ImageIndex = 0
            radTreeNode12.Image = (CType((resources.GetObject("radTreeNode12.Image")), System.Drawing.Image))
            radTreeNode12.ImageIndex = 1
            radTreeNode12.Text = "Deleted Items"
            radTreeNode13.Image = (CType((resources.GetObject("radTreeNode13.Image")), System.Drawing.Image))
            radTreeNode13.ImageIndex = 2
            radTreeNode13.Text = "Drafts"
            radTreeNode14.Image = (CType((resources.GetObject("radTreeNode14.Image")), System.Drawing.Image))
            radTreeNode14.ImageIndex = 3
            radTreeNode14.Text = "Inbox"
            radTreeNode15.Image = (CType((resources.GetObject("radTreeNode15.Image")), System.Drawing.Image))
            radTreeNode15.ImageIndex = 5
            radTreeNode15.Text = "OutBox"
            radTreeNode16.Image = (CType((resources.GetObject("radTreeNode16.Image")), System.Drawing.Image))
            radTreeNode16.ImageIndex = 6
            radTreeNode16.Text = "Rss Feeds"
            radTreeNode17.Image = (CType((resources.GetObject("radTreeNode17.Image")), System.Drawing.Image))
            radTreeNode17.ImageIndex = 8
            radTreeNode17.Text = "Sent Items"
            radTreeNode18.Expanded = True
            radTreeNode18.Image = (CType((resources.GetObject("radTreeNode18.Image")), System.Drawing.Image))
            radTreeNode18.ImageIndex = 9
            radTreeNode19.Image = (CType((resources.GetObject("radTreeNode19.Image")), System.Drawing.Image))
            radTreeNode19.ImageIndex = 8
            radTreeNode19.Text = "Large Mail"
            radTreeNode20.Image = (CType((resources.GetObject("radTreeNode20.Image")), System.Drawing.Image))
            radTreeNode20.ImageIndex = 8
            radTreeNode20.Text = "Unread Mail"
            radTreeNode18.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() {radTreeNode19, radTreeNode20})
            radTreeNode18.NumberOfColors = 2
            radTreeNode18.Text = "Search Folders"
            radTreeNode11.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() {radTreeNode12, radTreeNode13, radTreeNode14, radTreeNode15, radTreeNode16, radTreeNode17, radTreeNode18})
            radTreeNode11.Text = "Personal Folders"
            Me.radTreeView2.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() {radTreeNode11})
            Me.radTreeView2.Size = New System.Drawing.Size(406, 543)
            Me.radTreeView2.SpacingBetweenNodes = -1
            Me.radTreeView2.TabIndex = 5
            Me.radTreeView2.TreeIndent = 25
            Me.imageList1.ImageStream = (CType((resources.GetObject("imageList1.ImageStream")), System.Windows.Forms.ImageListStreamer))
            Me.imageList1.TransparentColor = System.Drawing.Color.Fuchsia
            Me.imageList1.Images.SetKeyName(0, "0_Personal_Folders.gif")
            Me.imageList1.Images.SetKeyName(1, "1_Deleted_Items.gif")
            Me.imageList1.Images.SetKeyName(2, "2_Drafts.gif")
            Me.imageList1.Images.SetKeyName(3, "3_Inbox.gif")
            Me.imageList1.Images.SetKeyName(4, "4_Junk_E-mail.gif")
            Me.imageList1.Images.SetKeyName(5, "5_Outbox.gif")
            Me.imageList1.Images.SetKeyName(6, "6_Rss_Feeds.gif")
            Me.imageList1.Images.SetKeyName(7, "7_Sent_Items.gif")
            Me.imageList1.Images.SetKeyName(8, "8.1_Search.gif")
            Me.imageList1.Images.SetKeyName(9, "8_Search.gif")
            Me.radTreeView1.AllowDragDrop = True
            Me.radTreeView1.AllowDrop = True
            Me.radTreeView1.Dock = System.Windows.Forms.DockStyle.Left
            Me.radTreeView1.ImageList = Me.imageList1
            Me.radTreeView1.ItemHeight = 25
            Me.radTreeView1.Location = New System.Drawing.Point(0, 25)
            Me.radTreeView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.radTreeView1.Name = "radTreeView1"
            radTreeNode21.Expanded = True
            radTreeNode21.Image = (CType((resources.GetObject("radTreeNode21.Image")), System.Drawing.Image))
            radTreeNode21.ImageIndex = 0
            radTreeNode22.Image = (CType((resources.GetObject("radTreeNode22.Image")), System.Drawing.Image))
            radTreeNode22.ImageIndex = 1
            radTreeNode22.Text = "Deleted Items"
            radTreeNode23.Image = (CType((resources.GetObject("radTreeNode23.Image")), System.Drawing.Image))
            radTreeNode23.ImageIndex = 2
            radTreeNode23.Text = "Drafts"
            radTreeNode24.Image = (CType((resources.GetObject("radTreeNode24.Image")), System.Drawing.Image))
            radTreeNode24.ImageIndex = 3
            radTreeNode24.Text = "Inbox"
            radTreeNode25.Image = (CType((resources.GetObject("radTreeNode25.Image")), System.Drawing.Image))
            radTreeNode25.ImageIndex = 5
            radTreeNode25.Text = "OutBox"
            radTreeNode26.Image = (CType((resources.GetObject("radTreeNode26.Image")), System.Drawing.Image))
            radTreeNode26.ImageIndex = 6
            radTreeNode26.Text = "Rss Feeds"
            radTreeNode27.Image = (CType((resources.GetObject("radTreeNode27.Image")), System.Drawing.Image))
            radTreeNode27.ImageIndex = 8
            radTreeNode27.Text = "Sent Items"
            radTreeNode28.Expanded = True
            radTreeNode28.Image = (CType((resources.GetObject("radTreeNode28.Image")), System.Drawing.Image))
            radTreeNode28.ImageIndex = 9
            radTreeNode29.Image = (CType((resources.GetObject("radTreeNode29.Image")), System.Drawing.Image))
            radTreeNode29.ImageIndex = 8
            radTreeNode29.Text = "Large Mail"
            radTreeNode30.Image = (CType((resources.GetObject("radTreeNode30.Image")), System.Drawing.Image))
            radTreeNode30.ImageIndex = 8
            radTreeNode30.Text = "Unread Mail"
            radTreeNode28.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() {radTreeNode29, radTreeNode30})
            radTreeNode28.NumberOfColors = 2
            radTreeNode28.Text = "Search Folders"
            radTreeNode21.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() {radTreeNode22, radTreeNode23, radTreeNode24, radTreeNode25, radTreeNode26, radTreeNode27, radTreeNode28})
            radTreeNode21.Text = "Personal Folders"
            Me.radTreeView1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() {radTreeNode21})
            Me.radTreeView1.Size = New System.Drawing.Size(433, 543)
            Me.radTreeView1.SpacingBetweenNodes = -1
            Me.radTreeView1.TabIndex = 4
            Me.radTreeView1.TreeIndent = 25
            Me.radTextBox1.AllowDrop = True
            Me.radTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.radTextBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radTextBox1.Location = New System.Drawing.Point(0, 0)
            Me.radTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.radTextBox1.Name = "radTextBox1"
            Me.radTextBox1.[ReadOnly] = True
            Me.radTextBox1.Size = New System.Drawing.Size(893, 25)
            Me.radTextBox1.TabIndex = 2
            Me.radTextBox1.TabStop = False
            Me.radPanel2.Controls.Add(Me.radTreeView1)
            Me.radPanel2.Controls.Add(Me.radTreeView2)
            Me.radPanel2.Controls.Add(Me.radTextBox1)
            Me.radPanel2.Location = New System.Drawing.Point(20, 76)
            Me.radPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.radPanel2.Name = "radPanel2"
            Me.radPanel2.Size = New System.Drawing.Size(893, 568)
            Me.radPanel2.TabIndex = 7
            Me.radPanel1.Location = New System.Drawing.Point(20, 17)
            Me.radPanel1.Margin = New System.Windows.Forms.Padding(4)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(893, 39)
            Me.radPanel1.TabIndex = 8
            Me.radPanel1.Text = "Drag && drop between controls"
            CType((Me.radPanel1.GetChildAt(0)), Telerik.WinControls.UI.RadPanelElement).Text = "Drag && drop between controls"
            CType((Me.radPanel1.GetChildAt(0)), Telerik.WinControls.UI.RadPanelElement).Padding = New System.Windows.Forms.Padding(8, 4, 2, 2)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.radPanel2)
            Me.Controls.Add(Me.radPanel1)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(0, 0, 12, 12)
            Me.Size = New System.Drawing.Size(1887, 1104)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            Me.Controls.SetChildIndex(Me.radPanel2, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.radTreeView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radTreeView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radTextBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radPanel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel2.ResumeLayout(False)
            Me.radPanel2.PerformLayout()
            CType((Me.radPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
        Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
        Private imageList1 As System.Windows.Forms.ImageList
        Private radTreeView2 As Telerik.WinControls.UI.RadTreeView
        Private radPanel2 As Telerik.WinControls.UI.RadPanel
        Private radPanel1 As TreeExampleHeaderPanel
    End Class
End Namespace
