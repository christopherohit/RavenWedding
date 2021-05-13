Namespace Telerik.Examples.WinControls.Editors.BrowseEditor.Settings
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.readOnlyCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.clearButtonCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radBrowseEditor1 = New Telerik.WinControls.UI.RadBrowseEditor()
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radDropDownList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.readOnlyCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.clearButtonCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radBrowseEditor1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.radBrowseEditor1)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(1634, 1126)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.clearButtonCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.readOnlyCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radDropDownList1)
            Me.optionsLabel.Location = New System.Drawing.Point(3, 306)
            Me.radDropDownList1.Location = New System.Drawing.Point(3, 82)
            Me.radDropDownList1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.Size = New System.Drawing.Size(125, 20)
            Me.radDropDownList1.TabIndex = 1
            Me.radDropDownList1.Text = "radDropDownList1"
            Me.readOnlyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.readOnlyCheckBox.Location = New System.Drawing.Point(3, 20)
            Me.readOnlyCheckBox.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
            Me.readOnlyCheckBox.Name = "readOnlyCheckBox"
            Me.readOnlyCheckBox.Size = New System.Drawing.Size(72, 18)
            Me.readOnlyCheckBox.TabIndex = 2
            Me.readOnlyCheckBox.Text = "Read Only"
            Me.readOnlyCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.readOnlyCheckBox.ToggleStateChanged, AddressOf Me.ReadOnlyCheckBox_ToggleStateChanged
            Me.clearButtonCheckBox.Location = New System.Drawing.Point(3, 51)
            Me.clearButtonCheckBox.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
            Me.clearButtonCheckBox.Name = "clearButtonCheckBox"
            Me.clearButtonCheckBox.Size = New System.Drawing.Size(113, 18)
            Me.clearButtonCheckBox.TabIndex = 3
            Me.clearButtonCheckBox.Text = "Show Clear Button"
            AddHandler Me.clearButtonCheckBox.ToggleStateChanged, AddressOf Me.ClearButtonCheckBox_ToggleStateChanged
            Me.radBrowseEditor1.Location = New System.Drawing.Point(182, 579)
            Me.radBrowseEditor1.Name = "radBrowseEditor1"
            Me.radBrowseEditor1.Size = New System.Drawing.Size(394, 20)
            Me.radBrowseEditor1.TabIndex = 1
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1634, 1126)
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.radPanelDemoHolder.PerformLayout()
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radDropDownList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.readOnlyCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.clearButtonCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radBrowseEditor1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private clearButtonCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private readOnlyCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
        Private radBrowseEditor1 As Telerik.WinControls.UI.RadBrowseEditor
    End Class
End Namespace
