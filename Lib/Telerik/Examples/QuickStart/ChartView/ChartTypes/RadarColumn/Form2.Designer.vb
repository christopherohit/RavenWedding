
Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.RadarColumn


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Form1


        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim CartesianArea1 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
            Me.RadChartView1 = New Telerik.WinControls.UI.RadChartView()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'RadChartView1
            '
            Me.RadChartView1.AreaDesign = CartesianArea1
            Me.RadChartView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RadChartView1.Location = New System.Drawing.Point(0, 0)
            Me.RadChartView1.Name = "RadChartView1"
            Me.RadChartView1.ShowGrid = False
            Me.RadChartView1.Size = New System.Drawing.Size(1492, 906)
            Me.RadChartView1.TabIndex = 0
            '
            'Form2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.RadChartView1)
            Me.Name = "Form2"
            Me.Size = New System.Drawing.Size(1502, 916)
            Me.Controls.SetChildIndex(Me.RadChartView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents RadChartView1 As Telerik.WinControls.UI.RadChartView
    End Class
End Namespace
