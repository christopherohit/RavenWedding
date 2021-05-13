Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GanttView.MSProjectImport
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.radGanttView1 = New Telerik.WinControls.UI.RadGanttView()
            Me.radGroupBoxSource = New Telerik.WinControls.UI.RadGroupBox()
            Me.radListControlSources = New Telerik.WinControls.UI.RadListControl()

            DirectCast(Me.radGanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBoxSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radListControlSources, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBoxSource.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' radGanttView1
            ' 
            Me.radGanttView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGanttView1.Location = New System.Drawing.Point(0, 0)
            Me.radGanttView1.Name = "radGanttView1"
            Me.radGanttView1.Size = New System.Drawing.Size(1004, 600)
            Me.radGanttView1.TabIndex = 0
            Me.radGanttView1.Text = "radGanttView1"
            Me.radGanttView1.ThemeName = "TelerikMetroBlue"
            Me.radGanttView1.Ratio = 0.3823065F
            Me.radGanttView1.GanttViewElement.AllowDefaultContextMenu = False
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupBoxSource)
            Me.settingsPanel.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Location = New System.Drawing.Point(973, 1)
            Me.settingsPanel.Size = New System.Drawing.Size(303, 747)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxSource, 0)
            ' 
            ' radGroupBoxColumns
            ' 
            Me.radGroupBoxSource.HeaderText = "Source"
            Me.radGroupBoxSource.Location = New System.Drawing.Point(15, 6)
            Me.radGroupBoxSource.Name = "radGroupBoxColumns"
            Me.radGroupBoxSource.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBoxSource.Size = New System.Drawing.Size(115, 298)
            Me.radGroupBoxSource.TabIndex = 1
            Me.radGroupBoxSource.Text = "Source"
            Me.radGroupBoxSource.Controls.Add(Me.radListControlSources)
            '
            ' radListControlSources
            '
            Me.radListControlSources.Dock = System.Windows.Forms.DockStyle.Fill
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1016, 651)
            Me.Controls.Add(Me.radGanttView1)
            Me.Name = "Form1"
            ' 
            ' 
            ' 
            Me.Text = "RadGanttViewExample"
            DirectCast(Me.radGanttView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBoxSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radListControlSources, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxSource.ResumeLayout(False)
            Me.radGroupBoxSource.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region

        Private radGanttView1 As Telerik.WinControls.UI.RadGanttView
        Private radGroupBoxSource As Telerik.WinControls.UI.RadGroupBox
        Private radListControlSources As Telerik.WinControls.UI.RadListControl
    End Class
End Namespace
