Namespace Telerik.Examples.WinControls.SyntaxEditor.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
            Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
            Me.syntaxEditor = New Telerik.WinControls.UI.RadSyntaxEditor()
            Me.infoLabel = New Telerik.WinControls.UI.RadLabel()
            Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
            Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
            Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.treeView = New Telerik.WinControls.UI.RadTreeView()
            Me.radButton1 = New Telerik.WinControls.UI.RadButton()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radDock1.SuspendLayout()
            Me.documentWindow1.SuspendLayout()
            CType(Me.syntaxEditor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.infoLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.documentContainer1.SuspendLayout()
            CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.documentTabStrip1.SuspendLayout()
            CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.toolTabStrip1.SuspendLayout()
            Me.toolWindow1.SuspendLayout()
            CType(Me.treeView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.radDock1)
            Me.radPanelDemoHolder.Padding = New System.Windows.Forms.Padding(10)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(1991, 1156)
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(1260, 46)
            '
            'radDock1
            '
            Me.radDock1.ActiveWindow = Me.documentWindow1
            Me.radDock1.Controls.Add(Me.documentContainer1)
            Me.radDock1.Controls.Add(Me.toolTabStrip1)
            Me.radDock1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radDock1.IsCleanUpTarget = True
            Me.radDock1.Location = New System.Drawing.Point(10, 10)
            Me.radDock1.MainDocumentContainer = Me.documentContainer1
            Me.radDock1.Name = "radDock1"
            '
            '
            '
            Me.radDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.radDock1.Size = New System.Drawing.Size(1971, 1136)
            Me.radDock1.TabIndex = 0
            Me.radDock1.TabStop = False
            '
            'documentWindow1
            '
            Me.documentWindow1.Controls.Add(Me.syntaxEditor)
            Me.documentWindow1.Controls.Add(Me.infoLabel)
            Me.documentWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.documentWindow1.Location = New System.Drawing.Point(6, 29)
            Me.documentWindow1.Name = "documentWindow1"
            Me.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
            Me.documentWindow1.Size = New System.Drawing.Size(1647, 1091)
            Me.documentWindow1.Text = "documentWindow1"
            '
            'syntaxEditor
            '
            Me.syntaxEditor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.syntaxEditor.Location = New System.Drawing.Point(0, 0)
            Me.syntaxEditor.Name = "syntaxEditor"
            Me.syntaxEditor.Size = New System.Drawing.Size(1647, 1091)
            Me.syntaxEditor.TabIndex = 0
            Me.syntaxEditor.Text = "``"
            '
            'infoLabel
            '
            Me.infoLabel.AutoSize = False
            Me.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.infoLabel.Font = New System.Drawing.Font("Segoe UI", 22.0!)
            Me.infoLabel.Location = New System.Drawing.Point(0, 0)
            Me.infoLabel.Name = "infoLabel"
            Me.infoLabel.Size = New System.Drawing.Size(1647, 1091)
            Me.infoLabel.TabIndex = 1
            Me.infoLabel.Text = "Type not supported"
            Me.infoLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.infoLabel.Visible = False
            '
            'documentContainer1
            '
            Me.documentContainer1.Controls.Add(Me.documentTabStrip1)
            Me.documentContainer1.Name = "documentContainer1"
            '
            '
            '
            Me.documentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.documentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(871, 200)
            Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
            Me.documentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-98, 0)
            '
            'documentTabStrip1
            '
            Me.documentTabStrip1.CanUpdateChildIndex = True
            Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
            Me.documentTabStrip1.Location = New System.Drawing.Point(0, 0)
            Me.documentTabStrip1.Name = "documentTabStrip1"
            '
            '
            '
            Me.documentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.documentTabStrip1.SelectedIndex = 0
            Me.documentTabStrip1.Size = New System.Drawing.Size(1659, 1126)
            Me.documentTabStrip1.TabIndex = 0
            Me.documentTabStrip1.TabStop = False
            '
            'toolTabStrip1
            '
            Me.toolTabStrip1.CanUpdateChildIndex = True
            Me.toolTabStrip1.Controls.Add(Me.toolWindow1)
            Me.toolTabStrip1.Location = New System.Drawing.Point(1668, 5)
            Me.toolTabStrip1.Name = "toolTabStrip1"
            '
            '
            '
            Me.toolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.toolTabStrip1.SelectedIndex = 0
            Me.toolTabStrip1.Size = New System.Drawing.Size(298, 1126)
            Me.toolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(298, 200)
            Me.toolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(98, 0)
            Me.toolTabStrip1.TabIndex = 1
            Me.toolTabStrip1.TabStop = False
            '
            'toolWindow1
            '
            Me.toolWindow1.Caption = Nothing
            Me.toolWindow1.Controls.Add(Me.treeView)
            Me.toolWindow1.Controls.Add(Me.radButton1)
            Me.toolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolWindow1.Location = New System.Drawing.Point(1, 24)
            Me.toolWindow1.Name = "toolWindow1"
            Me.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.toolWindow1.Size = New System.Drawing.Size(296, 1100)
            Me.toolWindow1.Text = "Solution Explorer"
            '
            'treeView
            '
            Me.treeView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeView.Location = New System.Drawing.Point(0, 46)
            Me.treeView.Name = "treeView"
            Me.treeView.Size = New System.Drawing.Size(296, 1054)
            Me.treeView.SpacingBetweenNodes = -1
            Me.treeView.TabIndex = 0
            '
            'radButton1
            '
            Me.radButton1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.radButton1.Location = New System.Drawing.Point(0, 0)
            Me.radButton1.Name = "radButton1"
            Me.radButton1.Size = New System.Drawing.Size(296, 46)
            Me.radButton1.TabIndex = 1
            Me.radButton1.Text = "Open Folder"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1991, 1156)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radDock1.ResumeLayout(False)
            Me.documentWindow1.ResumeLayout(False)
            CType(Me.syntaxEditor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.infoLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.documentContainer1.ResumeLayout(False)
            CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.documentTabStrip1.ResumeLayout(False)
            CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.toolTabStrip1.ResumeLayout(False)
            Me.toolWindow1.ResumeLayout(False)
            CType(Me.treeView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
        Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
        Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
        Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
        Private syntaxEditor As Telerik.WinControls.UI.RadSyntaxEditor
        Private treeView As Telerik.WinControls.UI.RadTreeView
        Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
        Private infoLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
        Friend WithEvents toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    End Class
End Namespace
