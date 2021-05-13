Namespace Telerik.Examples.WinControls.GanttView.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.radGanttView1 = New Telerik.WinControls.UI.RadGanttView()
            CType(Me.radGanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radGanttView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGanttView1.Location = New System.Drawing.Point(0, 0)
            Me.radGanttView1.Name = "radGanttView1"
            Me.radGanttView1.Size = New System.Drawing.Size(1004, 600)
            Me.radGanttView1.TabIndex = 0
            Me.radGanttView1.Text = "radGanttView1"
            Me.radGanttView1.ThemeName = "TelerikMetroBlue"
            Me.radGanttView1.Ratio = 0.3970588F
            Me.radGanttView1.GanttViewElement.AllowDefaultContextMenu = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1016, 651)
            Me.Controls.Add(Me.radGanttView1)
            Me.Name = "Form1"
            Me.Text = "RadGanttViewExample"
            CType(Me.radGanttView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radGanttView1 As Telerik.WinControls.UI.RadGanttView
    End Class
End Namespace
