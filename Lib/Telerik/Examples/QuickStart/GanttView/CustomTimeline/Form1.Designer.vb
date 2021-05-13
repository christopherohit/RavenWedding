Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.GanttView.CustomTimeline
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Form1
        Inherits ExamplesForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.

        Private Sub InitializeComponent()
            Dim ganttViewTextViewColumn1 As New Telerik.WinControls.UI.GanttViewTextViewColumn()
            Dim ganttViewTextViewColumn2 As New Telerik.WinControls.UI.GanttViewTextViewColumn()
            Dim ganttViewTextViewColumn3 As New Telerik.WinControls.UI.GanttViewTextViewColumn()
            Dim ganttViewTextViewColumn4 As New Telerik.WinControls.UI.GanttViewTextViewColumn()
            Me.radGanttView1 = New Telerik.WinControls.UI.RadGanttView()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadGanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radGanttView1
            ' 
            ganttViewTextViewColumn1.FieldName = "Title"
            ganttViewTextViewColumn1.HeaderText = "War"
            ganttViewTextViewColumn1.Name = "Title"
            ganttViewTextViewColumn1.Width = 300
            ganttViewTextViewColumn2.FieldName = "Start"
            ganttViewTextViewColumn2.FormatString = "{0:dd.MM.yyyy}"
            ganttViewTextViewColumn2.HeaderText = "Start"
            ganttViewTextViewColumn2.Name = "Start"
            ganttViewTextViewColumn2.Width = 75
            ganttViewTextViewColumn3.FieldName = "End"
            ganttViewTextViewColumn3.FormatString = "{0:dd.MM.yyyy}"
            ganttViewTextViewColumn3.HeaderText = "End"
            ganttViewTextViewColumn3.Name = "End"
            ganttViewTextViewColumn3.Width = 75
            ganttViewTextViewColumn4.FieldName = "Casualties"
            ganttViewTextViewColumn4.HeaderText = "Casualties"
            ganttViewTextViewColumn4.Name = "Casualties"
            ganttViewTextViewColumn4.Width = 75
            Me.RadGanttView1.Columns.AddRange(New Telerik.WinControls.UI.GanttViewTextViewColumn() {ganttViewTextViewColumn1, ganttViewTextViewColumn2, ganttViewTextViewColumn3, ganttViewTextViewColumn4})
            Me.RadGanttView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RadGanttView1.Location = New System.Drawing.Point(0, 0)
            Me.RadGanttView1.Name = "radGanttView1"
            Me.RadGanttView1.Ratio = 0.3648276F
            Me.RadGanttView1.[ReadOnly] = True
            Me.RadGanttView1.Size = New System.Drawing.Size(1158, 698)
            Me.RadGanttView1.SplitterWidth = 7
            Me.RadGanttView1.TabIndex = 0
            Me.RadGanttView1.Text = "radGanttView1"
            CType(Me.RadGanttView1.GetChildAt(0), Telerik.WinControls.UI.RadGanttViewElement).SplitterWidth = 7
            CType(Me.RadGanttView1.GetChildAt(0), Telerik.WinControls.UI.RadGanttViewElement).[ReadOnly] = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.RadGanttView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1168, 708)
            Me.Controls.SetChildIndex(Me.RadGanttView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadGanttView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents RadGanttView1 As Telerik.WinControls.UI.RadGanttView
    End Class
End Namespace

