
Namespace RichTextEditor
    Partial Class SplashForm
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
            Me.radWaitingBar1 = New Telerik.WinControls.UI.RadWaitingBar()
            DirectCast(Me.radWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radWaitingBar1
            ' 
            Me.radWaitingBar1.Anchor = DirectCast((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radWaitingBar1.Location = New System.Drawing.Point(12, 12)
            Me.radWaitingBar1.Name = "radWaitingBar1"
            Me.radWaitingBar1.Size = New System.Drawing.Size(260, 30)
            Me.radWaitingBar1.TabIndex = 0
            Me.radWaitingBar1.Text = "radWaitingBar1"
            ' 
            ' SplashForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 54)
            Me.Controls.Add(Me.radWaitingBar1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SplashForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SplashForm"
            DirectCast(Me.radWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar
    End Class
End Namespace
