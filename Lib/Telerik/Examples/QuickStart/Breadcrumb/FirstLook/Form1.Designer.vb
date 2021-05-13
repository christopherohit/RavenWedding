Namespace Telerik.Examples.WinControls.Breadcrumb.FirstLook
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radBreadCrumb1 = New Telerik.WinControls.UI.RadBreadCrumb()
            Me.textModeCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.autoCompleteCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.histroyCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.selectTreeNodeCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBreadCrumb1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textModeCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.autoCompleteCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.histroyCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.selectTreeNodeCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.radTreeView1)
            Me.radPanelDemoHolder.Controls.Add(Me.radBreadCrumb1)
            Me.radPanelDemoHolder.Padding = New System.Windows.Forms.Padding(15)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(1634, 923)
            '
            'settingsPanel
            '
            Me.settingsPanel.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Location = New System.Drawing.Point(1111, 1)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Controls.Add(Me.selectTreeNodeCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.histroyCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.textModeCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.autoCompleteCheckBox)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(200, 668)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 668)
            '
            'optionsLabel
            '
            Me.optionsLabel.Location = New System.Drawing.Point(46, 304)
            '
            'radTreeView1
            '
            Me.radTreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radTreeView1.ImageIndex = 5
            Me.radTreeView1.ImageList = Me.imageList1
            Me.radTreeView1.Location = New System.Drawing.Point(15, 45)
            Me.radTreeView1.Name = "radTreeView1"
            Me.radTreeView1.Size = New System.Drawing.Size(1604, 863)
            Me.radTreeView1.SpacingBetweenNodes = -1
            Me.radTreeView1.TabIndex = 1
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.White
            Me.imageList1.Images.SetKeyName(0, "computer")
            Me.imageList1.Images.SetKeyName(1, "desktop")
            Me.imageList1.Images.SetKeyName(2, "documents")
            Me.imageList1.Images.SetKeyName(3, "downloads")
            Me.imageList1.Images.SetKeyName(4, "favorites")
            Me.imageList1.Images.SetKeyName(5, "folder")
            Me.imageList1.Images.SetKeyName(6, "hdd")
            Me.imageList1.Images.SetKeyName(7, "libraries")
            Me.imageList1.Images.SetKeyName(8, "music")
            Me.imageList1.Images.SetKeyName(9, "network drive")
            Me.imageList1.Images.SetKeyName(10, "network")
            Me.imageList1.Images.SetKeyName(11, "pictures")
            Me.imageList1.Images.SetKeyName(12, "video")
            Me.imageList1.Images.SetKeyName(13, "virtual machines")
            Me.imageList1.Images.SetKeyName(14, "work")
            '
            'radLabel3
            '
            Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.radLabel3.Location = New System.Drawing.Point(8, 2)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(89, 24)
            Me.radLabel3.TabIndex = 0
            Me.radLabel3.Text = "File Browser"
            '
            'radBreadCrumb1
            '
            Me.radBreadCrumb1.ChildMember = Nothing
            Me.radBreadCrumb1.DataMember = Nothing
            Me.radBreadCrumb1.DefaultTreeView = Me.radTreeView1
            Me.radBreadCrumb1.DisplayMember = Nothing
            Me.radBreadCrumb1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radBreadCrumb1.Location = New System.Drawing.Point(15, 15)
            Me.radBreadCrumb1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
            Me.radBreadCrumb1.Name = "radBreadCrumb1"
            Me.radBreadCrumb1.ParentMember = Nothing
            Me.radBreadCrumb1.Size = New System.Drawing.Size(1604, 22)
            Me.radBreadCrumb1.TabIndex = 2
            Me.radBreadCrumb1.Text = "radBreadCrumb1"
            Me.radBreadCrumb1.ValueMember = Nothing
            '
            'textModeCheckBox
            '
            Me.textModeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.textModeCheckBox.Location = New System.Drawing.Point(3, 51)
            Me.textModeCheckBox.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
            Me.textModeCheckBox.Name = "textModeCheckBox"
            Me.textModeCheckBox.Size = New System.Drawing.Size(124, 18)
            Me.textModeCheckBox.TabIndex = 6
            Me.textModeCheckBox.Text = "Is TextMode Enabled"
            Me.textModeCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'autoCompleteCheckBox
            '
            Me.autoCompleteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.autoCompleteCheckBox.Location = New System.Drawing.Point(3, 20)
            Me.autoCompleteCheckBox.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
            Me.autoCompleteCheckBox.Name = "autoCompleteCheckBox"
            Me.autoCompleteCheckBox.Size = New System.Drawing.Size(147, 18)
            Me.autoCompleteCheckBox.TabIndex = 5
            Me.autoCompleteCheckBox.Text = "Is AutoComplete Enabled"
            Me.autoCompleteCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'histroyCheckBox
            '
            Me.histroyCheckBox.Location = New System.Drawing.Point(3, 82)
            Me.histroyCheckBox.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
            Me.histroyCheckBox.Name = "histroyCheckBox"
            Me.histroyCheckBox.Size = New System.Drawing.Size(110, 18)
            Me.histroyCheckBox.TabIndex = 7
            Me.histroyCheckBox.Text = "Is History Enabled"
            '
            'selectTreeNodeCheckBox
            '
            Me.selectTreeNodeCheckBox.Location = New System.Drawing.Point(3, 113)
            Me.selectTreeNodeCheckBox.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
            Me.selectTreeNodeCheckBox.Name = "selectTreeNodeCheckBox"
            Me.selectTreeNodeCheckBox.Size = New System.Drawing.Size(147, 18)
            Me.selectTreeNodeCheckBox.TabIndex = 8
            Me.selectTreeNodeCheckBox.Text = "Select TreeNode On Click"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1463, 923)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.radPanelDemoHolder.PerformLayout()
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBreadCrumb1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textModeCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.autoCompleteCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.histroyCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.selectTreeNodeCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private imageList1 As System.Windows.Forms.ImageList
        Private radBreadCrumb1 As Telerik.WinControls.UI.RadBreadCrumb
        Private textModeCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private autoCompleteCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private selectTreeNodeCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private histroyCheckBox As Telerik.WinControls.UI.RadCheckBox
    End Class
End Namespace
