Namespace Telerik.Examples.WinControls.Barcode.DataMatrix
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radBarcode1 = New Telerik.WinControls.UI.RadBarcode()
            Me.encodationLabel = New Telerik.WinControls.UI.RadLabel()
            Me.symbolSizeLabel = New Telerik.WinControls.UI.RadLabel()
            Me.encodingLabel = New Telerik.WinControls.UI.RadLabel()
            Me.symbolSizeDdl = New Telerik.WinControls.UI.RadDropDownList()
            Me.encodationDdl = New Telerik.WinControls.UI.RadDropDownList()
            Me.encodingDdl = New Telerik.WinControls.UI.RadDropDownList()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBarcode1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.encodationLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.symbolSizeLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.encodingLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.symbolSizeDdl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.encodationDdl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.encodingDdl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.radBarcode1)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(404, 285)
            Me.radPanelDemoHolder.Padding = New System.Windows.Forms.Padding(100)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(506, 412)
            '
            'settingsPanel
            '
            Me.settingsPanel.BackColor = System.Drawing.Color.White
            Me.settingsPanel.Location = New System.Drawing.Point(1044, 90)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Controls.Add(Me.symbolSizeDdl)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.encodationDdl)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.encodingDdl)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.symbolSizeLabel)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.encodationLabel)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.encodingLabel)
            '
            'optionsLabel
            '
            Me.optionsLabel.Location = New System.Drawing.Point(3, 573)
            '
            'radBarcode1
            '
            Me.radBarcode1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radBarcode1.Location = New System.Drawing.Point(152, 104)
            Me.radBarcode1.Name = "radBarcode1"
            Me.radBarcode1.Size = New System.Drawing.Size(203, 203)
            Me.radBarcode1.TabIndex = 0
            Me.radBarcode1.Text = "radBarcode1"
            '
            'encodationLabel
            '
            Me.encodationLabel.Location = New System.Drawing.Point(3, 3)
            Me.encodationLabel.Name = "encodationLabel"
            Me.encodationLabel.Size = New System.Drawing.Size(65, 18)
            Me.encodationLabel.TabIndex = 3
            Me.encodationLabel.Text = "Encodation:"
            '
            'symbolSizeLabel
            '
            Me.symbolSizeLabel.Location = New System.Drawing.Point(3, 57)
            Me.symbolSizeLabel.Name = "symbolSizeLabel"
            Me.symbolSizeLabel.Size = New System.Drawing.Size(69, 18)
            Me.symbolSizeLabel.TabIndex = 4
            Me.symbolSizeLabel.Text = "Symbol Size:"
            '
            'encodingLabel
            '
            Me.encodingLabel.Location = New System.Drawing.Point(3, 111)
            Me.encodingLabel.Name = "encodingLabel"
            Me.encodingLabel.Size = New System.Drawing.Size(55, 18)
            Me.encodingLabel.TabIndex = 5
            Me.encodingLabel.Text = "Encoding:"
            '
            'symbolSizeDdl
            '
            Me.symbolSizeDdl.DropDownAnimationEnabled = False
            Me.symbolSizeDdl.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.symbolSizeDdl.Location = New System.Drawing.Point(3, 81)
            Me.symbolSizeDdl.Name = "symbolSizeDdl"
            Me.symbolSizeDdl.Size = New System.Drawing.Size(194, 20)
            Me.symbolSizeDdl.TabIndex = 7
            Me.symbolSizeDdl.Text = "symbolSizeDdl"
            '
            'encodationDdl
            '
            Me.encodationDdl.DropDownAnimationEnabled = False
            Me.encodationDdl.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.encodationDdl.Location = New System.Drawing.Point(3, 27)
            Me.encodationDdl.Name = "encodationDdl"
            Me.encodationDdl.Size = New System.Drawing.Size(194, 20)
            Me.encodationDdl.TabIndex = 6
            Me.encodationDdl.Text = "encodationDdl"
            '
            'encodingDdl
            '
            Me.encodingDdl.DropDownAnimationEnabled = False
            Me.encodingDdl.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.encodingDdl.Location = New System.Drawing.Point(3, 135)
            Me.encodingDdl.Name = "encodingDdl"
            Me.encodingDdl.Size = New System.Drawing.Size(194, 20)
            Me.encodingDdl.TabIndex = 8
            Me.encodingDdl.Text = "encodingDdl"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1314, 786)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBarcode1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.encodationLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.symbolSizeLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.encodingLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.symbolSizeDdl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.encodationDdl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.encodingDdl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private radBarcode1 As Telerik.WinControls.UI.RadBarcode
        Private encodationDdl As Telerik.WinControls.UI.RadDropDownList
        Private symbolSizeDdl As Telerik.WinControls.UI.RadDropDownList
        Private encodingDdl As Telerik.WinControls.UI.RadDropDownList
        Private encodationLabel As Telerik.WinControls.UI.RadLabel
        Private symbolSizeLabel As Telerik.WinControls.UI.RadLabel
        Private encodingLabel As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
