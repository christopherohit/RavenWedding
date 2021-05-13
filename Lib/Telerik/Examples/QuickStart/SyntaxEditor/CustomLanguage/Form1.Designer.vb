Namespace Telerik.Examples.WinControls.SyntaxEditor.CustomLanguage
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.syntaxEditor = New Telerik.WinControls.UI.RadSyntaxEditor()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.syntaxEditor, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.syntaxEditor)
            Me.radPanelDemoHolder.Padding = New System.Windows.Forms.Padding(13)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(1991, 1156)
            '
            'settingsPanel
            '
            '
            'syntaxEditor
            '
            Me.syntaxEditor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.syntaxEditor.Location = New System.Drawing.Point(13, 13)
            Me.syntaxEditor.Name = "syntaxEditor"
            Me.syntaxEditor.Size = New System.Drawing.Size(1965, 1130)
            Me.syntaxEditor.TabIndex = 0
            Me.syntaxEditor.Text = "radSyntaxEditor1"
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
            CType(Me.syntaxEditor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private syntaxEditor As Telerik.WinControls.UI.RadSyntaxEditor
    End Class
End Namespace
