Namespace Telerik.Examples.WinControls.TrackStatusControls.WaitingBar.Conventional
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
            Me.radWaitingBar2 = New Telerik.WinControls.UI.RadWaitingBar()
            Me.radWaitingBar3 = New Telerik.WinControls.UI.RadWaitingBar()
            Me.radWaitingBar4 = New Telerik.WinControls.UI.RadWaitingBar()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.radToggleButton2 = New Telerik.WinControls.UI.RadToggleButton()
            Me.radToggleButton1 = New Telerik.WinControls.UI.RadToggleButton()
            Me.radSpinEditor2 = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radButton3 = New Telerik.WinControls.UI.RadButton()
            Me.radButton2 = New Telerik.WinControls.UI.RadButton()
            Me.radButton1 = New Telerik.WinControls.UI.RadButton()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radWaitingBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radWaitingBar3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radWaitingBar4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radToggleButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Location = New Point(789, 1)
            Me.settingsPanel.Size = New Size(590, 1251)

            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            ' 
            ' radWaitingBar1
            ' 
            Me.radWaitingBar1.Location = New Point(0, 89)
            Me.radWaitingBar1.Name = "radWaitingBar1"
            Me.radWaitingBar1.Size = New Size(250, 30)
            Me.radWaitingBar1.TabIndex = 1
            Me.radWaitingBar1.Text = "Waiting"
            Me.radWaitingBar1.WaitingIndicatorSize = New Size(50, 30)
            ' 
            ' radWaitingBar2
            ' 
            Me.radWaitingBar2.Location = New Point(0, 132)
            Me.radWaitingBar2.Name = "radWaitingBar2"
            Me.radWaitingBar2.Size = New Size(250, 30)
            Me.radWaitingBar2.TabIndex = 2
            Me.radWaitingBar2.Text = "Waiting"
            Me.radWaitingBar2.WaitingDirection = Telerik.WinControls.ProgressOrientation.Left
            Me.radWaitingBar2.WaitingIndicatorSize = New Size(50, 30)
            ' 
            ' radWaitingBar3
            ' 
            Me.radWaitingBar3.Location = New Point(265, 19)
            Me.radWaitingBar3.Name = "radWaitingBar3"
            Me.radWaitingBar3.Orientation = Orientation.Vertical
            Me.radWaitingBar3.Size = New Size(30, 250)
            Me.radWaitingBar3.StretchIndicatorsHorizontally = True
            Me.radWaitingBar3.StretchIndicatorsVertically = False
            Me.radWaitingBar3.TabIndex = 3
            Me.radWaitingBar3.Text = "Waiting"
            Me.radWaitingBar3.WaitingDirection = Telerik.WinControls.ProgressOrientation.Bottom
            Me.radWaitingBar3.WaitingIndicatorSize = New Size(30, 50)
            ' 
            ' radWaitingBar4
            ' 
            Me.radWaitingBar4.Location = New Point(310, 19)
            Me.radWaitingBar4.Name = "radWaitingBar4"
            Me.radWaitingBar4.Orientation = Orientation.Vertical
            Me.radWaitingBar4.Size = New Size(30, 250)
            Me.radWaitingBar4.StretchIndicatorsHorizontally = True
            Me.radWaitingBar4.StretchIndicatorsVertically = False
            Me.radWaitingBar4.TabIndex = 4
            Me.radWaitingBar4.Text = "Waiting"
            Me.radWaitingBar4.WaitingDirection = Telerik.WinControls.ProgressOrientation.Top
            Me.radWaitingBar4.WaitingIndicatorSize = New Size(30, 50)
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.radLabel5)
            Me.radGroupBox1.Controls.Add(Me.radDropDownList1)
            Me.radGroupBox1.Controls.Add(Me.radToggleButton2)
            Me.radGroupBox1.Controls.Add(Me.radToggleButton1)
            Me.radGroupBox1.Controls.Add(Me.radSpinEditor2)
            Me.radGroupBox1.Controls.Add(Me.radSpinEditor1)
            Me.radGroupBox1.Controls.Add(Me.radLabel2)
            Me.radGroupBox1.Controls.Add(Me.radLabel1)
            Me.radGroupBox1.Controls.Add(Me.radButton3)
            Me.radGroupBox1.Controls.Add(Me.radButton2)
            Me.radGroupBox1.Controls.Add(Me.radButton1)
            Me.radGroupBox1.HeaderText = "Settings"
            Me.radGroupBox1.Location = New Point(10, 38)
            Me.radGroupBox1.Name = "radGroupBox1"
            ' 
            ' 
            ' 
            Me.radGroupBox1.RootElement.Padding = New Padding(2, 18, 2, 2)
            Me.radGroupBox1.Size = New Size(570, 372)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Settings"
            ' 
            ' radLabel5
            ' 
            Me.radLabel5.Location = New Point(26, 222)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New Size(74, 18)
            Me.radLabel5.TabIndex = 10
            Me.radLabel5.Text = "Waiting Style:"
            ' 
            ' radDropDownList1
            ' 
            Me.radDropDownList1.Location = New Point(26, 246)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.Size = New Size(130, 20)
            Me.radDropDownList1.TabIndex = 9
            Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            ' 
            ' radToggleButton2
            ' 
            Me.radToggleButton2.Location = New Point(26, 311)
            Me.radToggleButton2.Name = "radToggleButton2"
            Me.radToggleButton2.Size = New Size(130, 23)
            Me.radToggleButton2.TabIndex = 8
            Me.radToggleButton2.Text = "Right to Left"
            ' 
            ' radToggleButton1
            ' 
            Me.radToggleButton1.Location = New Point(26, 282)
            Me.radToggleButton1.Name = "radToggleButton1"
            Me.radToggleButton1.Size = New Size(130, 23)
            Me.radToggleButton1.TabIndex = 7
            Me.radToggleButton1.Text = "Show Text"
            ' 
            ' radSpinEditor2
            ' 
            Me.radSpinEditor2.Location = New Point(26, 196)
            Me.radSpinEditor2.Name = "radSpinEditor2"
            ' 
            ' 
            ' 
            Me.radSpinEditor2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditor2.Size = New Size(130, 20)
            Me.radSpinEditor2.TabIndex = 6
            Me.radSpinEditor2.TabStop = False
            Me.radSpinEditor2.Value = New Decimal(New Integer() {90, 0, 0, 0})
            ' 
            ' radSpinEditor1
            ' 
            Me.radSpinEditor1.Location = New Point(26, 146)
            Me.radSpinEditor1.Name = "radSpinEditor1"
            ' 
            ' 
            ' 
            Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditor1.Size = New Size(130, 20)
            Me.radSpinEditor1.TabIndex = 5
            Me.radSpinEditor1.TabStop = False
            Me.radSpinEditor1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            ' 
            ' radLabel2
            ' 
            Me.radLabel2.Location = New Point(26, 172)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New Size(82, 18)
            Me.radLabel2.TabIndex = 4
            Me.radLabel2.Text = "Waiting Speed:"
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Location = New Point(26, 122)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New Size(73, 18)
            Me.radLabel1.TabIndex = 3
            Me.radLabel1.Text = "Waiting Step:"
            ' 
            ' radButton3
            ' 
            Me.radButton3.Location = New Point(26, 92)
            Me.radButton3.Name = "radButton3"
            Me.radButton3.Size = New Size(130, 24)
            Me.radButton3.TabIndex = 2
            Me.radButton3.Text = "Reset Waiting"
            ' 
            ' radButton2
            ' 
            Me.radButton2.Location = New Point(26, 61)
            Me.radButton2.Name = "radButton2"
            Me.radButton2.Size = New Size(130, 24)
            Me.radButton2.TabIndex = 1
            Me.radButton2.Text = "Stop Waiting"
            ' 
            ' radButton1
            ' 
            Me.radButton1.Location = New Point(26, 30)
            Me.radButton1.Name = "radButton1"
            Me.radButton1.Size = New Size(130, 24)
            Me.radButton1.TabIndex = 0
            Me.radButton1.Text = "Start Waiting"
            ' 
            ' radLabel3
            ' 
            Me.radLabel3.Location = New Point(0, 67)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New Size(58, 18)
            Me.radLabel3.TabIndex = 5
            Me.radLabel3.Text = "Horizontal"
            ' 
            ' radLabel4
            ' 
            Me.radLabel4.Location = New Point(265, -3)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New Size(43, 18)
            Me.radLabel4.TabIndex = 6
            Me.radLabel4.Text = "Vertical"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.radWaitingBar4)
            Me.Controls.Add(Me.radWaitingBar3)
            Me.Controls.Add(Me.radWaitingBar2)
            Me.Controls.Add(Me.radWaitingBar1)
            Me.Controls.Add(Me.radLabel4)
            Me.Controls.Add(Me.radLabel3)
            Me.Name = "Form1"
            Me.Size = New Size(1063, 599)
            Me.Controls.SetChildIndex(Me.radLabel3, 0)
            Me.Controls.SetChildIndex(Me.radLabel4, 0)
            Me.Controls.SetChildIndex(Me.radWaitingBar1, 0)
            Me.Controls.SetChildIndex(Me.radWaitingBar2, 0)
            Me.Controls.SetChildIndex(Me.radWaitingBar3, 0)
            Me.Controls.SetChildIndex(Me.radWaitingBar4, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType(Me.radWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radWaitingBar2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radWaitingBar3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radWaitingBar4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radToggleButton2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditor2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private radWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar
        Private radWaitingBar2 As Telerik.WinControls.UI.RadWaitingBar
        Private radWaitingBar3 As Telerik.WinControls.UI.RadWaitingBar
        Private radWaitingBar4 As Telerik.WinControls.UI.RadWaitingBar
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radButton1 As Telerik.WinControls.UI.RadButton
        Private radButton2 As Telerik.WinControls.UI.RadButton
        Private radButton3 As Telerik.WinControls.UI.RadButton
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditor2 As Telerik.WinControls.UI.RadSpinEditor
        Private radToggleButton1 As Telerik.WinControls.UI.RadToggleButton
        Private radToggleButton2 As Telerik.WinControls.UI.RadToggleButton
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    End Class
End Namespace