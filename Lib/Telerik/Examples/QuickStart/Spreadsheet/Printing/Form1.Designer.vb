Namespace Telerik.Examples.WinControls.Spreadsheet.Printing
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
            Me.radSpreadsheetRibbonBar1 = New Telerik.WinControls.UI.RadSpreadsheetRibbonBar()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSpreadsheet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSpreadsheetRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New System.Drawing.Point(928, 280)
            ' 
            ' radSpreadsheet1
            ' 
            Me.radSpreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSpreadsheet1.Location = New System.Drawing.Point(0, 168)
            Me.radSpreadsheet1.Name = "radSpreadsheet1"
            Me.radSpreadsheet1.Size = New System.Drawing.Size(1467, 822)
            Me.radSpreadsheet1.TabIndex = 2
            Me.radSpreadsheet1.Text = "radSpreadsheet1"
            ' 
            ' radSpreadsheetRibbonBar1
            ' 
            Me.radSpreadsheetRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
            Me.radSpreadsheetRibbonBar1.AssociatedSpreadsheet = Me.radSpreadsheet1
            ' 
            ' 
            ' 
            Me.radSpreadsheetRibbonBar1.ExitButton.Text = "Exit"
            Me.radSpreadsheetRibbonBar1.Location = New System.Drawing.Point(0, 0)
            Me.radSpreadsheetRibbonBar1.Name = "radSpreadsheetRibbonBar1"
            ' 
            ' 
            ' 
            Me.radSpreadsheetRibbonBar1.OptionsButton.Text = "Options"
            Me.radSpreadsheetRibbonBar1.Size = New System.Drawing.Size(1467, 168)
            Me.radSpreadsheetRibbonBar1.TabIndex = 0
            Me.radSpreadsheetRibbonBar1.Text = "Printing"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radSpreadsheet1)
            Me.Controls.Add(Me.radSpreadsheetRibbonBar1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1477, 1000)
            Me.Controls.SetChildIndex(Me.radSpreadsheetRibbonBar1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radSpreadsheet1, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSpreadsheet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSpreadsheetRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private radSpreadsheet1 As Telerik.WinControls.UI.RadSpreadsheet
        Private radSpreadsheetRibbonBar1 As Telerik.WinControls.UI.RadSpreadsheetRibbonBar
    End Class
End Namespace