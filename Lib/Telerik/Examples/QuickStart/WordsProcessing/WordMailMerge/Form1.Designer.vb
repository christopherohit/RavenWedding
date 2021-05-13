Namespace Telerik.Examples.WinControls.WordsProcessing.WordMailMerge
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.mailMergeButton = New Telerik.WinControls.UI.RadButton()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mailMergeButton, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(631, 12)
            Me.pictureBox1.Location = New System.Drawing.Point(12, 12)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(530, 380)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            Me.radDropDownList1.DropDownAnimationEnabled = False
            Me.radDropDownList1.Location = New System.Drawing.Point(84, 445)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.Size = New System.Drawing.Size(125, 20)
            Me.radDropDownList1.TabIndex = 1
            Me.radDropDownList1.Text = "radDropDownList1"
            Me.radLabel1.Location = New System.Drawing.Point(12, 447)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(44, 18)
            Me.radLabel1.TabIndex = 2
            Me.radLabel1.Text = "Format:"
            Me.mailMergeButton.Location = New System.Drawing.Point(13, 496)
            Me.mailMergeButton.Name = "mailMergeButton"
            Me.mailMergeButton.Size = New System.Drawing.Size(529, 24)
            Me.mailMergeButton.TabIndex = 3
            Me.mailMergeButton.Text = "Mail Merge"
            AddHandler Me.mailMergeButton.Click, New System.EventHandler(AddressOf Me.mailMergeButton_Click)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mailMergeButton)
            Me.Controls.Add(Me.radLabel1)
            Me.Controls.Add(Me.radDropDownList1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1240, 796)
            Me.Controls.SetChildIndex(Me.pictureBox1, 0)
            Me.Controls.SetChildIndex(Me.radDropDownList1, 0)
            Me.Controls.SetChildIndex(Me.radLabel1, 0)
            Me.Controls.SetChildIndex(Me.mailMergeButton, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mailMergeButton, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private mailMergeButton As Telerik.WinControls.UI.RadButton
    End Class
End Namespace
