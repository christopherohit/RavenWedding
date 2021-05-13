Namespace Telerik.Examples.WinControls.Spreadsheet.Protection
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
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
            Me.radSpreadsheet1 = New Telerik.WinControls.UI.RadSpreadsheet()
            Me.protectSheetButton = New Telerik.WinControls.UI.RadButton()
            Me.saveSheetButton = New Telerik.WinControls.UI.RadButton()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radSpreadsheet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.protectSheetButton, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.saveSheetButton, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radLabel1)
            Me.settingsPanel.Controls.Add(Me.saveSheetButton)
            Me.settingsPanel.Controls.Add(Me.protectSheetButton)
            Me.settingsPanel.Location = New System.Drawing.Point(1153, 112)
            Me.settingsPanel.Size = New System.Drawing.Size(230, 126)
            Me.settingsPanel.Controls.SetChildIndex(Me.protectSheetButton, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.saveSheetButton, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
            ' 
            ' radSpreadsheet1
            ' 
            Me.radSpreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSpreadsheet1.Location = New System.Drawing.Point(0, 0)
            Me.radSpreadsheet1.Name = "radSpreadsheet1"
            Me.radSpreadsheet1.Size = New System.Drawing.Size(1467, 990)
            Me.radSpreadsheet1.TabIndex = 2
            Me.radSpreadsheet1.Text = "radSpreadsheet1"
            ' 
            ' protectSheetButton
            ' 
            Me.protectSheetButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.protectSheetButton.Location = New System.Drawing.Point(10, 56)
            Me.protectSheetButton.Name = "protectSheetButton"
            Me.protectSheetButton.Size = New System.Drawing.Size(210, 24)
            Me.protectSheetButton.TabIndex = 1
            Me.protectSheetButton.Text = "Protect sheet"
            AddHandler Me.protectSheetButton.Click, AddressOf Me.protectSheetButton_Click
            ' 
            ' saveSheetButton
            ' 
            Me.saveSheetButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.saveSheetButton.Location = New System.Drawing.Point(10, 86)
            Me.saveSheetButton.Name = "saveSheetButton"
            Me.saveSheetButton.Size = New System.Drawing.Size(210, 24)
            Me.saveSheetButton.TabIndex = 2
            Me.saveSheetButton.Text = "Save File"
            AddHandler Me.saveSheetButton.Click, AddressOf Me.saveSheetButton_Click
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel1.AutoSize = False
            Me.radLabel1.Location = New System.Drawing.Point(10, 32)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(210, 18)
            Me.radLabel1.TabIndex = 3
            Me.radLabel1.Tag = "NotAutoSized"
            Me.radLabel1.Text = "<html>The password is <em>telerik</em>.</html>"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radSpreadsheet1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1477, 1000)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radSpreadsheet1, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            DirectCast(Me.radSpreadsheet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.protectSheetButton, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.saveSheetButton, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radSpreadsheet1 As Telerik.WinControls.UI.RadSpreadsheet
        Private saveSheetButton As Telerik.WinControls.UI.RadButton
        Private protectSheetButton As Telerik.WinControls.UI.RadButton
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace