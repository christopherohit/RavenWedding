Imports Telerik.QuickStart.WinControls
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.GridView.Performance.HighRefresh
    Partial Public Class Form1
        Inherits ExamplesForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Me.components = New Container()
            Me.infoCountLabel = New Telerik.WinControls.UI.RadLabel()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.infoAverageLabel = New Telerik.WinControls.UI.RadLabel()
            Me.countResultLabel = New Telerik.WinControls.UI.RadLabel()
            Me.averageResultLabel = New Telerik.WinControls.UI.RadLabel()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.radLblAverage = New Telerik.WinControls.UI.RadLabel()
            Me.radLblRefreshCount = New Telerik.WinControls.UI.RadLabel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.infoCountLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.infoAverageLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.countResultLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.averageResultLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            CType(Me.radLblAverage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLblRefreshCount, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New Point(796, 1)
            ' 
            ' 
            ' 
            Me.settingsPanel.RootElement.ForeColor = Color.Black
            Me.settingsPanel.Size = New Size(200, 715)
            ' 
            ' infoCountLabel
            ' 
            Me.infoCountLabel.AutoSize = False
            Me.infoCountLabel.Font = New Font("Microsoft Sans Serif", 11.0F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
            Me.infoCountLabel.ForeColor = Color.Red
            Me.infoCountLabel.Location = New Point(12, 793)
            Me.infoCountLabel.Name = "infoCountLabel"
            ' 
            ' 
            ' 
            Me.infoCountLabel.RootElement.StretchHorizontally = True
            Me.infoCountLabel.RootElement.StretchVertically = True
            Me.infoCountLabel.Size = New Size(113, 21)
            Me.infoCountLabel.TabIndex = 1
            Me.infoCountLabel.Text = "Refresh Count: "
            Me.infoCountLabel.TextAlignment = ContentAlignment.MiddleLeft
            Me.infoCountLabel.Visible = False
            ' 
            ' radGridView1
            ' 
            Me.radGridView1.Dock = DockStyle.Fill
            Me.radGridView1.ForeColor = Color.Black
            Me.radGridView1.Location = New Point(0, 48)
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.RightToLeft = RightToLeft.No
            ' 
            ' 
            ' 
            Me.radGridView1.RootElement.ForeColor = Color.Black
            Me.radGridView1.Size = New Size(980, 766)
            Me.radGridView1.TabIndex = 2
            Me.radGridView1.Text = "radGridView1"
            ' 
            ' infoAverageLabel
            ' 
            Me.infoAverageLabel.AutoSize = False
            Me.infoAverageLabel.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
            Me.infoAverageLabel.ForeColor = Color.Red
            Me.infoAverageLabel.Location = New Point(237, 793)
            Me.infoAverageLabel.Name = "infoAverageLabel"
            ' 
            ' 
            ' 
            Me.infoAverageLabel.RootElement.StretchHorizontally = True
            Me.infoAverageLabel.RootElement.StretchVertically = True
            Me.infoAverageLabel.Size = New Size(172, 21)
            Me.infoAverageLabel.TabIndex = 2
            Me.infoAverageLabel.Text = "Average Refresh Time: "
            Me.infoAverageLabel.TextAlignment = ContentAlignment.MiddleLeft
            Me.infoAverageLabel.Visible = False
            ' 
            ' countResultLabel
            ' 
            Me.countResultLabel.AutoSize = False
            Me.countResultLabel.Font = New Font("Microsoft Sans Serif", 11.0F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
            Me.countResultLabel.ForeColor = Color.Red
            Me.countResultLabel.Location = New Point(117, 793)
            Me.countResultLabel.Name = "countResultLabel"
            ' 
            ' 
            ' 
            Me.countResultLabel.RootElement.StretchHorizontally = True
            Me.countResultLabel.RootElement.StretchVertically = True
            Me.countResultLabel.Size = New Size(15, 21)
            Me.countResultLabel.TabIndex = 2
            Me.countResultLabel.Text = "x"
            Me.countResultLabel.TextAlignment = ContentAlignment.MiddleLeft
            Me.countResultLabel.Visible = False
            ' 
            ' averageResultLabel
            ' 
            Me.averageResultLabel.AutoSize = False
            Me.averageResultLabel.Font = New Font("Microsoft Sans Serif", 11.0F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
            Me.averageResultLabel.ForeColor = Color.Red
            Me.averageResultLabel.Location = New Point(402, 793)
            Me.averageResultLabel.Name = "averageResultLabel"
            ' 
            ' 
            ' 
            Me.averageResultLabel.RootElement.StretchHorizontally = True
            Me.averageResultLabel.RootElement.StretchVertically = True
            Me.averageResultLabel.Size = New Size(15, 21)
            Me.averageResultLabel.TabIndex = 3
            Me.averageResultLabel.Text = "x"
            Me.averageResultLabel.TextAlignment = ContentAlignment.MiddleLeft
            Me.averageResultLabel.Visible = False
            ' 
            ' radPanel1
            ' 
            Me.radPanel1.Controls.Add(Me.radLblAverage)
            Me.radPanel1.Controls.Add(Me.radLblRefreshCount)
            Me.radPanel1.Dock = DockStyle.Top
            Me.radPanel1.ForeColor = Color.Black
            Me.radPanel1.Location = New Point(0, 0)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New Size(980, 48)
            Me.radPanel1.TabIndex = 4
            ' 
            ' radLblAverage
            ' 
            Me.radLblAverage.Location = New Point(3, 28)
            Me.radLblAverage.Name = "radLblAverage"
            Me.radLblAverage.Size = New Size(0, 0)
            Me.radLblAverage.TabIndex = 1
            ' 
            ' radLblRefreshCount
            ' 
            Me.radLblRefreshCount.Location = New Point(3, 8)
            Me.radLblRefreshCount.Name = "radLblRefreshCount"
            Me.radLblRefreshCount.Size = New Size(80, 14)
            Me.radLblRefreshCount.TabIndex = 0
            Me.radLblRefreshCount.Text = "Refresh Count:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.radGridView1)
            Me.Controls.Add(Me.averageResultLabel)
            Me.Controls.Add(Me.radPanel1)
            Me.Controls.Add(Me.countResultLabel)
            Me.Controls.Add(Me.infoAverageLabel)
            Me.Controls.Add(Me.infoCountLabel)
            Me.Name = "Form1"
            Me.Size = New Size(980, 717)
            Me.Controls.SetChildIndex(Me.infoCountLabel, 0)
            Me.Controls.SetChildIndex(Me.infoAverageLabel, 0)
            Me.Controls.SetChildIndex(Me.countResultLabel, 0)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            Me.Controls.SetChildIndex(Me.averageResultLabel, 0)
            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.infoCountLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.infoAverageLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.countResultLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.averageResultLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            Me.radPanel1.PerformLayout()
            CType(Me.radLblAverage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLblRefreshCount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private infoCountLabel As Telerik.WinControls.UI.RadLabel
        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private infoAverageLabel As Telerik.WinControls.UI.RadLabel
        Private countResultLabel As Telerik.WinControls.UI.RadLabel
        Private averageResultLabel As Telerik.WinControls.UI.RadLabel
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private radLblRefreshCount As Telerik.WinControls.UI.RadLabel
        Private radLblAverage As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace