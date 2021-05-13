Namespace Telerik.Examples.WinControls.ImageEditor.FirstLook
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
            Me.radImageEditor1 = New Telerik.WinControls.UI.RadImageEditor()
            CType(Me.radImageEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radImageEditor1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radImageEditor1.Location = New System.Drawing.Point(0, 0)
            Me.radImageEditor1.Name = "radImageEditor1"
            Me.radImageEditor1.Size = New System.Drawing.Size(1004, 600)
            Me.radImageEditor1.TabIndex = 0
            Me.radImageEditor1.Text = "radImageEditor1"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(1016, 651)
            Me.Controls.Add(Me.radImageEditor1)
            Me.Name = "Form1"
            Me.Text = "ImageEditor"
            CType(Me.radImageEditor1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout()
        End Sub

        Private radImageEditor1 As Telerik.WinControls.UI.RadImageEditor
    End Class
End Namespace