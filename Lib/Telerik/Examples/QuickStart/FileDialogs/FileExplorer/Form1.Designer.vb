
Namespace Telerik.Examples.WinControls.FileDialogs.FileExplorer
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.explorerControl1 = New Telerik.WinControls.UI.ExplorerControl()
            Me.multiSelectCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.dragdropCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.expandToCurrDirCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.showHiddenFilesCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radSeparator1 = New Telerik.WinControls.UI.RadSeparator()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.filterDescriptorsDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.safeFileNamesListControl = New Telerik.WinControls.UI.RadListControl()
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.multiSelectCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dragdropCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.expandToCurrDirCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.showHiddenFilesCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSeparator1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.filterDescriptorsDropDownList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.safeFileNamesListControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.explorerControl1)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(2142, 1156)
            Me.settingsPanel.Location = New System.Drawing.Point(1250, 93)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.multiSelectCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.dragdropCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.expandToCurrDirCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.showHiddenFilesCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radSeparator1)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel1)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.filterDescriptorsDropDownList)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel2)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.safeFileNamesListControl)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(253, 598)
            Me.settingsPanel.Size = New System.Drawing.Size(253, 598)
            Me.optionsLabel.Location = New System.Drawing.Point(63, 573)
            Me.explorerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.explorerControl1.Location = New System.Drawing.Point(0, 0)
            Me.explorerControl1.Name = "explorerControl1"
            Me.explorerControl1.Size = New System.Drawing.Size(2142, 1156)
            Me.explorerControl1.TabIndex = 0
            Me.multiSelectCheckBox.Location = New System.Drawing.Point(3, 3)
            Me.multiSelectCheckBox.Name = "multiSelectCheckBox"
            Me.multiSelectCheckBox.Size = New System.Drawing.Size(75, 18)
            Me.multiSelectCheckBox.TabIndex = 1
            Me.multiSelectCheckBox.Text = "MultiSelect"
            AddHandler Me.multiSelectCheckBox.ToggleStateChanged, AddressOf Me.MultiSelectCheckBox_ToggleStateChanged
            Me.dragdropCheckBox.Location = New System.Drawing.Point(3, 32)
            Me.dragdropCheckBox.Name = "dragdropCheckBox"
            Me.dragdropCheckBox.Size = New System.Drawing.Size(117, 18)
            Me.dragdropCheckBox.TabIndex = 2
            Me.dragdropCheckBox.Text = "IsDragDropEnabled"
            AddHandler Me.dragdropCheckBox.ToggleStateChanged, AddressOf Me.DragdropCheckBox_ToggleStateChanged
            Me.expandToCurrDirCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.expandToCurrDirCheckBox.Location = New System.Drawing.Point(3, 61)
            Me.expandToCurrDirCheckBox.Name = "expandToCurrDirCheckBox"
            Me.expandToCurrDirCheckBox.Size = New System.Drawing.Size(152, 18)
            Me.expandToCurrDirCheckBox.TabIndex = 3
            Me.expandToCurrDirCheckBox.Text = "ExpandToCurrentDirectory"
            Me.expandToCurrDirCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.expandToCurrDirCheckBox.ToggleStateChanged, AddressOf Me.ExpandToCurrDirCheckBox_ToggleStateChanged
            Me.showHiddenFilesCheckBox.Location = New System.Drawing.Point(3, 90)
            Me.showHiddenFilesCheckBox.Name = "showHiddenFilesCheckBox"
            Me.showHiddenFilesCheckBox.Size = New System.Drawing.Size(106, 18)
            Me.showHiddenFilesCheckBox.TabIndex = 4
            Me.showHiddenFilesCheckBox.Text = "ShowHiddenFiles"
            AddHandler Me.showHiddenFilesCheckBox.ToggleStateChanged, AddressOf Me.ShowHiddenFilesCheckBox_ToggleStateChanged
            Me.radSeparator1.Location = New System.Drawing.Point(3, 114)
            Me.radSeparator1.Name = "radSeparator1"
            Me.radSeparator1.Size = New System.Drawing.Size(194, 14)
            Me.radSeparator1.TabIndex = 5
            Me.radLabel1.Location = New System.Drawing.Point(3, 134)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(33, 18)
            Me.radLabel1.TabIndex = 6
            Me.radLabel1.Text = "Filter:"
            Me.filterDescriptorsDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.filterDescriptorsDropDownList.Location = New System.Drawing.Point(3, 158)
            Me.filterDescriptorsDropDownList.Name = "filterDescriptorsDropDownList"
            Me.filterDescriptorsDropDownList.Size = New System.Drawing.Size(194, 20)
            Me.filterDescriptorsDropDownList.TabIndex = 7
            AddHandler Me.filterDescriptorsDropDownList.SelectedIndexChanged, AddressOf Me.FilterDescriptorsDropDownList_SelectedIndexChanged
            Me.radLabel2.Location = New System.Drawing.Point(3, 190)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(133, 18)
            Me.radLabel2.TabIndex = 8
            Me.radLabel2.Text = "Selected Safe File Names:"
            Me.safeFileNamesListControl.Location = New System.Drawing.Point(3, 214)
            Me.safeFileNamesListControl.Name = "safeFileNamesListControl"
            Me.safeFileNamesListControl.SelectionMode = System.Windows.Forms.SelectionMode.None
            Me.safeFileNamesListControl.Size = New System.Drawing.Size(194, 277)
            Me.safeFileNamesListControl.TabIndex = 9
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2142, 1156)
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.multiSelectCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dragdropCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.expandToCurrDirCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.showHiddenFilesCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSeparator1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.filterDescriptorsDropDownList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.safeFileNamesListControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private explorerControl1 As Telerik.WinControls.UI.ExplorerControl
        Private filterDescriptorsDropDownList As Telerik.WinControls.UI.RadDropDownList
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radSeparator1 As Telerik.WinControls.UI.RadSeparator
        Private showHiddenFilesCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private expandToCurrDirCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private dragdropCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private multiSelectCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private safeFileNamesListControl As Telerik.WinControls.UI.RadListControl
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace