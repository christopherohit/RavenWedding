Namespace Telerik.Examples.WinControls.Integration.Magnifier
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radToggleButton1 = New Telerik.WinControls.UI.RadToggleButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.magnifier1 = New Telerik.Examples.WinControls.Integration.Magnifier.Magnifier()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.magnifier1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 818)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radToggleButton1
			' 
			Me.radToggleButton1.Location = New Point(16, 72)
			Me.radToggleButton1.Name = "radToggleButton1"
			Me.radToggleButton1.Size = New Size(135, 23)
			Me.radToggleButton1.TabIndex = 3
			Me.radToggleButton1.Text = "Toggle items' opacity"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditor1)
			Me.radGroupBox1.Controls.Add(Me.radToggleButton1)
			Me.radGroupBox1.FooterText = ""
			Me.radGroupBox1.HeaderText = "Magnifier Options"
			Me.radGroupBox1.Location = New Point(10, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 115)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = "Magnifier Options"
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.DecimalPlaces = 2
			Me.radSpinEditor1.Increment = New Decimal(New Integer() { 2, 0, 0, 65536})
			Me.radSpinEditor1.Location = New Point(116, 34)
			Me.radSpinEditor1.Maximum = New Decimal(New Integer() { 6, 0, 0, 0})
			Me.radSpinEditor1.Minimum = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.Size = New Size(44, 20)
			Me.radSpinEditor1.TabIndex = 1
			Me.radSpinEditor1.TabStop = False
			Me.radSpinEditor1.Tag = "Right"
			Me.radSpinEditor1.Value = New Decimal(New Integer() { 3, 0, 0, 0})
			' 
			' radPanel1
			' 
			Me.radPanel1.BackColor = SystemColors.Control
			Me.radPanel1.Controls.Add(Me.magnifier1)
			Me.radPanel1.Location = New Point(398, 31)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(482, 438)
			Me.radPanel1.TabIndex = 1
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(7, 36)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(103, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Magnification level:"
			' 
			' magnifier1
			' 
			Me.magnifier1.Columns = 7
			Me.magnifier1.DefaultCellSize = New Size(56, 56)
			Me.magnifier1.Location = New Point(26, 13)
			Me.magnifier1.Name = "magnifier1"
			Me.magnifier1.Size = New Size(429, 411)
			Me.magnifier1.TabIndex = 0
			Me.magnifier1.Text = "magnifier1"
			' 
			' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1308, 506)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.magnifier1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private magnifier1 As Magnifier
		Private radToggleButton1 As Telerik.WinControls.UI.RadToggleButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
