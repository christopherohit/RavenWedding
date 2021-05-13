Imports Microsoft.VisualBasic
Imports System
Namespace ExportWithDpl.SpreadsheetStreaming
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
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
            Dim tableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim radListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.radLabelRowsCount = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelExtension = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorRowsCount = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radDropDownListExtension = New Telerik.WinControls.UI.RadDropDownList()
            Me.radProgressBarExportProgress = New Telerik.WinControls.UI.RadProgressBar()
            Me.radLabelExportedCells = New Telerik.WinControls.UI.RadLabel()
            Me.radButtonExport = New Telerik.WinControls.UI.RadButton()
            Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.radLabelNumberOfExportedCells = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelExportTime = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelExportTimeElapsed = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelSeconds = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelMB = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelMemory = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelCurrentMemory = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelRowsCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelExtension, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditorRowsCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListExtension, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radProgressBarExportProgress, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelExportedCells, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonExport, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flowLayoutPanel1.SuspendLayout()
            CType(Me.radLabelNumberOfExportedCells, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelExportTime, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelExportTimeElapsed, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelMB, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelMemory, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelCurrentMemory, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radGridView1
            ' 
            Me.radGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.radGridView1.Location = New System.Drawing.Point(12, 12)
            ' 
            ' 
            ' 
            Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(1086, 556)
            Me.radGridView1.TabIndex = 0
            Me.radGridView1.Text = "radGridView1"
            ' 
            ' radLabelRowsCount
            ' 
            Me.radLabelRowsCount.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
            Me.radLabelRowsCount.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.radLabelRowsCount.Location = New System.Drawing.Point(12, 587)
            Me.radLabelRowsCount.Name = "radLabelRowsCount"
            Me.radLabelRowsCount.Size = New System.Drawing.Size(71, 18)
            Me.radLabelRowsCount.TabIndex = 1
            Me.radLabelRowsCount.Text = "Rows count:"
            ' 
            ' radLabelExtension
            ' 
            Me.radLabelExtension.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
            Me.radLabelExtension.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.radLabelExtension.Location = New System.Drawing.Point(159, 587)
            Me.radLabelExtension.Name = "radLabelExtension"
            Me.radLabelExtension.Size = New System.Drawing.Size(61, 18)
            Me.radLabelExtension.TabIndex = 1
            Me.radLabelExtension.Text = "Extension:"
            ' 
            ' radSpinEditorRowsCount
            ' 
            Me.radSpinEditorRowsCount.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
            Me.radSpinEditorRowsCount.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.radSpinEditorRowsCount.Location = New System.Drawing.Point(89, 584)
            Me.radSpinEditorRowsCount.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.radSpinEditorRowsCount.Minimum = New Decimal(New Integer() {500, 0, 0, 0})
            Me.radSpinEditorRowsCount.Name = "radSpinEditorRowsCount"
            Me.radSpinEditorRowsCount.Size = New System.Drawing.Size(57, 20)
            Me.radSpinEditorRowsCount.TabIndex = 2
            Me.radSpinEditorRowsCount.TabStop = False
            Me.radSpinEditorRowsCount.Value = New Decimal(New Integer() {10000, 0, 0, 0})
            ' 
            ' radDropDownListExtension
            ' 
            Me.radDropDownListExtension.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
            Me.radDropDownListExtension.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            radListDataItem1.Text = "Xlsx"
            radListDataItem2.Text = "Csv"
            Me.radDropDownListExtension.Items.Add(radListDataItem1)
            Me.radDropDownListExtension.Items.Add(radListDataItem2)
            Me.radDropDownListExtension.Location = New System.Drawing.Point(226, 584)
            Me.radDropDownListExtension.Name = "radDropDownListExtension"
            Me.radDropDownListExtension.Size = New System.Drawing.Size(125, 20)
            Me.radDropDownListExtension.TabIndex = 3
            Me.radDropDownListExtension.Text = "Xlsx"
            ' 
            ' radProgressBarExportProgress
            ' 
            Me.radProgressBarExportProgress.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.radProgressBarExportProgress.Location = New System.Drawing.Point(12, 613)
            Me.radProgressBarExportProgress.Name = "radProgressBarExportProgress"
            Me.radProgressBarExportProgress.Size = New System.Drawing.Size(1086, 24)
            Me.radProgressBarExportProgress.TabIndex = 4
            ' 
            ' radLabelExportedCells
            ' 
            Me.radLabelExportedCells.Location = New System.Drawing.Point(3, 3)
            Me.radLabelExportedCells.Name = "radLabelExportedCells"
            Me.radLabelExportedCells.Size = New System.Drawing.Size(78, 18)
            Me.radLabelExportedCells.TabIndex = 1
            Me.radLabelExportedCells.Text = "Exported cells:"
            ' 
            ' radButtonExport
            ' 
            Me.radButtonExport.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.radButtonExport.Location = New System.Drawing.Point(988, 584)
            Me.radButtonExport.Name = "radButtonExport"
            Me.radButtonExport.Size = New System.Drawing.Size(110, 24)
            Me.radButtonExport.TabIndex = 5
            Me.radButtonExport.Text = "Export document"
            ' 
            ' flowLayoutPanel1
            ' 
            Me.flowLayoutPanel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.flowLayoutPanel1.Controls.Add(Me.radLabelExportedCells)
            Me.flowLayoutPanel1.Controls.Add(Me.radLabelNumberOfExportedCells)
            Me.flowLayoutPanel1.Controls.Add(Me.radLabelExportTime)
            Me.flowLayoutPanel1.Controls.Add(Me.radLabelExportTimeElapsed)
            Me.flowLayoutPanel1.Controls.Add(Me.radLabelSeconds)
            Me.flowLayoutPanel1.Controls.Add(Me.radLabelCurrentMemory)
            Me.flowLayoutPanel1.Controls.Add(Me.radLabelMemory)
            Me.flowLayoutPanel1.Controls.Add(Me.radLabelMB)
            Me.flowLayoutPanel1.Location = New System.Drawing.Point(12, 643)
            Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
            Me.flowLayoutPanel1.Size = New System.Drawing.Size(1086, 24)
            Me.flowLayoutPanel1.TabIndex = 6
            ' 
            ' radLabelNumberOfExportedCells
            ' 
            Me.radLabelNumberOfExportedCells.Location = New System.Drawing.Point(87, 3)
            Me.radLabelNumberOfExportedCells.Name = "radLabelNumberOfExportedCells"
            Me.radLabelNumberOfExportedCells.Size = New System.Drawing.Size(12, 18)
            Me.radLabelNumberOfExportedCells.TabIndex = 1
            Me.radLabelNumberOfExportedCells.Text = "0"
            ' 
            ' radLabelExportTime
            ' 
            Me.radLabelExportTime.Location = New System.Drawing.Point(105, 3)
            Me.radLabelExportTime.Name = "radLabelExportTime"
            Me.radLabelExportTime.Size = New System.Drawing.Size(66, 18)
            Me.radLabelExportTime.TabIndex = 1
            Me.radLabelExportTime.Text = "Export time:"
            ' 
            ' radLabelExportTimeElapsed
            ' 
            Me.radLabelExportTimeElapsed.Location = New System.Drawing.Point(177, 3)
            Me.radLabelExportTimeElapsed.Name = "radLabelExportTimeElapsed"
            Me.radLabelExportTimeElapsed.Size = New System.Drawing.Size(12, 18)
            Me.radLabelExportTimeElapsed.TabIndex = 1
            Me.radLabelExportTimeElapsed.Text = "0"
            ' 
            ' radLabelSeconds
            ' 
            Me.radLabelSeconds.Location = New System.Drawing.Point(195, 3)
            Me.radLabelSeconds.Name = "radLabelSeconds"
            Me.radLabelSeconds.Size = New System.Drawing.Size(11, 18)
            Me.radLabelSeconds.TabIndex = 1
            Me.radLabelSeconds.Text = "s"
            ' 
            ' radLabelMB
            ' 
            Me.radLabelMB.Location = New System.Drawing.Point(327, 3)
            Me.radLabelMB.Name = "radLabelMB"
            Me.radLabelMB.Size = New System.Drawing.Size(23, 18)
            Me.radLabelMB.TabIndex = 1
            Me.radLabelMB.Text = "MB"
            ' 
            ' radLabelMemory
            ' 
            Me.radLabelMemory.Location = New System.Drawing.Point(309, 3)
            Me.radLabelMemory.Name = "radLabelMemory"
            Me.radLabelMemory.Size = New System.Drawing.Size(12, 18)
            Me.radLabelMemory.TabIndex = 1
            Me.radLabelMemory.Text = "0"
            ' 
            ' radLabelCurrentMemory
            ' 
            Me.radLabelCurrentMemory.Location = New System.Drawing.Point(212, 3)
            Me.radLabelCurrentMemory.Name = "radLabelCurrentMemory"
            Me.radLabelCurrentMemory.Size = New System.Drawing.Size(91, 18)
            Me.radLabelCurrentMemory.TabIndex = 1
            Me.radLabelCurrentMemory.Text = "Current memory:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1110, 673)
            Me.Controls.Add(Me.flowLayoutPanel1)
            Me.Controls.Add(Me.radButtonExport)
            Me.Controls.Add(Me.radProgressBarExportProgress)
            Me.Controls.Add(Me.radDropDownListExtension)
            Me.Controls.Add(Me.radSpinEditorRowsCount)
            Me.Controls.Add(Me.radLabelExtension)
            Me.Controls.Add(Me.radLabelRowsCount)
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            ' 
            ' 
            ' 
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Form1"
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelRowsCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelExtension, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditorRowsCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListExtension, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radProgressBarExportProgress, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelExportedCells, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonExport, System.ComponentModel.ISupportInitialize).EndInit()
            Me.flowLayoutPanel1.ResumeLayout(False)
            Me.flowLayoutPanel1.PerformLayout()
            CType(Me.radLabelNumberOfExportedCells, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelExportTime, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelExportTimeElapsed, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelSeconds, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelMB, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelMemory, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelCurrentMemory, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private radLabelRowsCount As Telerik.WinControls.UI.RadLabel
        Private radLabelExtension As Telerik.WinControls.UI.RadLabel
        Private radSpinEditorRowsCount As Telerik.WinControls.UI.RadSpinEditor
        Private radDropDownListExtension As Telerik.WinControls.UI.RadDropDownList
        Private radProgressBarExportProgress As Telerik.WinControls.UI.RadProgressBar
        Private radLabelExportedCells As Telerik.WinControls.UI.RadLabel
        Private radButtonExport As Telerik.WinControls.UI.RadButton
        Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Private radLabelNumberOfExportedCells As Telerik.WinControls.UI.RadLabel
        Private radLabelExportTime As Telerik.WinControls.UI.RadLabel
        Private radLabelExportTimeElapsed As Telerik.WinControls.UI.RadLabel
        Private radLabelSeconds As Telerik.WinControls.UI.RadLabel
        Private radLabelCurrentMemory As Telerik.WinControls.UI.RadLabel
        Private radLabelMemory As Telerik.WinControls.UI.RadLabel
        Private radLabelMB As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace