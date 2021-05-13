Namespace Telerik.Examples.WinControls.Editors.ButtonTextBox
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radButtonTextBox1 = New Telerik.WinControls.UI.RadButtonTextBox()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.doubleBufferedFlowLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radButton1 = New Telerik.WinControls.UI.RadButton()
            Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radButtonTextBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType((Me.radButton1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radRadioButton2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radRadioButton1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(985, 98)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(230, 190)
            Me.settingsPanel.Size = New System.Drawing.Size(230, 190)
            Me.radButtonTextBox1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.radButtonTextBox1.Location = New System.Drawing.Point(81, 1)
            Me.radButtonTextBox1.Margin = New System.Windows.Forms.Padding(1)
            Me.radButtonTextBox1.Name = "radButtonTextBox1"
            Me.radButtonTextBox1.Size = New System.Drawing.Size(298, 38)
            Me.radButtonTextBox1.TabIndex = 1
            Me.radButtonTextBox1.Text = "radButtonTextBox1"
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 5
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695955F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695955F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.21967F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695955F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.692477F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonTextBox1, 2, 0)
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(183, 98)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 1
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(460, 40)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 2
            Me.doubleBufferedFlowLayoutPanel1.Location = New System.Drawing.Point(252, 165)
            Me.doubleBufferedFlowLayoutPanel1.Name = "doubleBufferedFlowLayoutPanel1"
            Me.doubleBufferedFlowLayoutPanel1.Size = New System.Drawing.Size(485, 306)
            Me.doubleBufferedFlowLayoutPanel1.TabIndex = 3
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.radButton1)
            Me.radGroupBox1.Controls.Add(Me.radRadioButton2)
            Me.radGroupBox1.Controls.Add(Me.radRadioButton1)
            Me.radGroupBox1.HeaderText = "Add buttons to:"
            Me.radGroupBox1.Location = New System.Drawing.Point(15, 33)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(200, 154)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Add buttons to:"
            Me.radButton1.Location = New System.Drawing.Point(15, 110)
            Me.radButton1.Name = "radButton1"
            Me.radButton1.Size = New System.Drawing.Size(110, 24)
            Me.radButton1.TabIndex = 2
            Me.radButton1.Text = "Clear buttons"
            AddHandler Me.radButton1.Click, New System.EventHandler(AddressOf Me.radButton1_Click)
            Me.radRadioButton2.Location = New System.Drawing.Point(15, 72)
            Me.radRadioButton2.Name = "radRadioButton2"
            Me.radRadioButton2.Size = New System.Drawing.Size(130, 18)
            Me.radRadioButton2.TabIndex = 1
            Me.radRadioButton2.TabStop = False
            Me.radRadioButton2.Text = "Add button to the left"
            Me.radRadioButton1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radRadioButton1.Location = New System.Drawing.Point(15, 34)
            Me.radRadioButton1.Name = "radRadioButton1"
            Me.radRadioButton1.Size = New System.Drawing.Size(137, 18)
            Me.radRadioButton1.TabIndex = 0
            Me.radRadioButton1.Text = "Add button to the right"
            Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.doubleBufferedFlowLayoutPanel1)
            Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1036, 411)
            Me.Controls.SetChildIndex(Me.doubleBufferedTableLayoutPanel1, 0)
            Me.Controls.SetChildIndex(Me.doubleBufferedFlowLayoutPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radButtonTextBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType((Me.radButton1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radRadioButton2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radRadioButton1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radButtonTextBox1 As Telerik.WinControls.UI.RadButtonTextBox
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private doubleBufferedFlowLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
        Private radButton1 As Telerik.WinControls.UI.RadButton
    End Class
End Namespace
