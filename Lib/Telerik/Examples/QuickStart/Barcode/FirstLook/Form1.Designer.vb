
Namespace Telerik.Examples.WinControls.Barcode.FirstLook

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
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBarcode1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(1081, 1)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(200, 788)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 788)
            '
            'radBarcode1
            '
            Me.radBarcode1.AutoSize = True
            Me.radBarcode1.Location = New System.Drawing.Point(505, 505)
            Me.radBarcode1.Name = "radBarcode1"
            Me.radBarcode1.Size = New System.Drawing.Size(2, 2)
            Me.radBarcode1.TabIndex = 1
            Me.radBarcode1.Text = "radBarcode1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.Controls.Add(Me.radBarcode1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.radBarcode1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBarcode1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private radBarcode1 As Telerik.WinControls.UI.RadBarcode
    End Class
End Namespace