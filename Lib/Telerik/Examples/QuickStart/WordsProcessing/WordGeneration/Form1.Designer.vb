Namespace Telerik.Examples.WinControls.WordsProcessing.WordGeneration
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
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.exportFormatDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.exportButton = New Telerik.WinControls.UI.RadButton()
            Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportFormatDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radLabel1.Location = New System.Drawing.Point(418, 42)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(44, 18)
            Me.radLabel1.TabIndex = 1
            Me.radLabel1.Text = "Format:"
            Me.exportFormatDropDownList.DropDownAnimationEnabled = False
            Me.exportFormatDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.exportFormatDropDownList.Location = New System.Drawing.Point(511, 40)
            Me.exportFormatDropDownList.Name = "exportFormatDropDownList"
            Me.exportFormatDropDownList.Size = New System.Drawing.Size(125, 20)
            Me.exportFormatDropDownList.TabIndex = 2
            Me.exportFormatDropDownList.Text = "radDropDownList1"
            Me.exportButton.Location = New System.Drawing.Point(422, 210)
            Me.exportButton.Name = "exportButton"
            Me.exportButton.Size = New System.Drawing.Size(105, 24)
            Me.exportButton.TabIndex = 3
            Me.exportButton.Text = "Generate"
            AddHandler Me.exportButton.Click, New System.EventHandler(AddressOf Me.exportButton_Click)
            Me.radCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBox1.Location = New System.Drawing.Point(422, 98)
            Me.radCheckBox1.Name = "radCheckBox1"
            Me.radCheckBox1.Size = New System.Drawing.Size(96, 18)
            Me.radCheckBox1.TabIndex = 4
            Me.radCheckBox1.Text = "Include Header"
            Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBox1.CheckStateChanged, New System.EventHandler(AddressOf Me.radCheckBox1_CheckStateChanged)
            Me.radCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBox2.Location = New System.Drawing.Point(422, 151)
            Me.radCheckBox2.Name = "radCheckBox2"
            Me.radCheckBox2.Size = New System.Drawing.Size(92, 18)
            Me.radCheckBox2.TabIndex = 5
            Me.radCheckBox2.Text = "Include Footer"
            Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBox2.CheckStateChanged, New System.EventHandler(AddressOf Me.radCheckBox2_CheckStateChanged)
            Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pictureBox1.Image = (CType((resources.GetObject("pictureBox1.Image")), System.Drawing.Image))
            Me.pictureBox1.Location = New System.Drawing.Point(24, 42)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(388, 492)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 6
            Me.pictureBox1.TabStop = False
            Me.radLabel2.Location = New System.Drawing.Point(20, 20)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(83, 18)
            Me.radLabel2.TabIndex = 7
            Me.radLabel2.Text = "Email Template"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(720, 566)
            Me.Controls.Add(Me.radLabel2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.radCheckBox2)
            Me.Controls.Add(Me.radCheckBox1)
            Me.Controls.Add(Me.exportButton)
            Me.Controls.Add(Me.exportFormatDropDownList)
            Me.Controls.Add(Me.radLabel1)
            Me.Name = "Form1"
            Me.Text = "Generate Documents"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportFormatDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private exportFormatDropDownList As Telerik.WinControls.UI.RadDropDownList
        Private exportButton As Telerik.WinControls.UI.RadButton
        Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
