Namespace Telerik.Examples.WinControls.PdfProcessing.PdfProcessing
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
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.buttonSave = New Telerik.WinControls.UI.RadButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonSave, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.pictureBox1.Image = (CType((resources.GetObject("pictureBox1.Image")), System.Drawing.Image))
            Me.pictureBox1.Location = New System.Drawing.Point(20, 20)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(432, 572)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            Me.buttonSave.Location = New System.Drawing.Point(475, 20)
            Me.buttonSave.Name = "buttonSave"
            Me.buttonSave.Size = New System.Drawing.Size(179, 36)
            Me.buttonSave.TabIndex = 2
            Me.buttonSave.Text = "Save Document"
            AddHandler Me.buttonSave.Click, New System.EventHandler(AddressOf Me.buttonSave_Click)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(681, 633)
            Me.Controls.Add(Me.buttonSave)
            Me.Controls.Add(Me.pictureBox1)
            Me.Name = "Form1"
            Me.Text = "PDF Document Processing"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonSave, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private buttonSave As Telerik.WinControls.UI.RadButton
    End Class
End Namespace
