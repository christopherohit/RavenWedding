Namespace RadChatExamples.Healthcare

    Partial Class Form1

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radChat1 = New Telerik.WinControls.UI.RadChat
            Me.radButton1 = New Telerik.WinControls.UI.RadButton
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
            CType(Me.radChat1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' 
            ' 
            Me.radChat1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChat1.Location = New System.Drawing.Point(0, 41)
            Me.radChat1.Name = "radChat1"
            Me.radChat1.Size = New System.Drawing.Size(371, 533)
            Me.radChat1.TabIndex = 0
            Me.radChat1.Text = "radChat1"
            Me.radChat1.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00")
            ' 
            ' 
            ' 
            Me.radButton1.BackColor = System.Drawing.Color.Transparent
            Me.radButton1.ForeColor = System.Drawing.Color.White
            Me.radButton1.Image = My.Resources.arrow
            Me.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.radButton1.Location = New System.Drawing.Point(217, 540)
            Me.radButton1.Name = "radButton1"
            Me.radButton1.Padding = New System.Windows.Forms.Padding(1)
            ' 
            ' 
            ' 
            Me.radButton1.RootElement.EnableElementShadow = False
            Me.radButton1.Size = New System.Drawing.Size(233, 42)
            Me.radButton1.TabIndex = 2
            Me.radButton1.Text = "Chat with our agent "
            CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = My.Resources.arrow
            CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
            CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Chat with our agent "
            CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ShadowDepth = 0
            CType(Me.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
            CType(Me.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.radButton1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            AddHandler Me.radButton1.Click, AddressOf RadButton1_Click
            ' 
            ' 
            ' 
            Me.radPanel1.Controls.Add(Me.radChat1)
            Me.radPanel1.Controls.Add(Me.radLabel1)
            Me.radPanel1.Location = New System.Drawing.Point(527, 70)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(371, 574)
            Me.radPanel1.TabIndex = 0
            ' 
            ' 
            ' 
            Me.radLabel1.AutoSize = False
            Me.radLabel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radLabel1.Font = New System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((17)))))), (CInt(((CByte((35)))))))
            Me.radLabel1.Image = My.Resources.HealthCareBot_32x32
            Me.radLabel1.Location = New System.Drawing.Point(0, 0)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.radLabel1.Size = New System.Drawing.Size(371, 41)
            Me.radLabel1.TabIndex = 0
            Me.radLabel1.Text = "  Health Care Assistant"
            Me.radLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            ' 
            ' 
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1060, 700)
            Me.Controls.Add(Me.radPanel1)
            Me.Controls.Add(Me.radButton1)
            Me.Name = "Form1"
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "First Look"
            CType(Me.radChat1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radChat1 As Telerik.WinControls.UI.RadChat

        Private radButton1 As Telerik.WinControls.UI.RadButton

        Private radPanel1 As Telerik.WinControls.UI.RadPanel

        Private radLabel1 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace