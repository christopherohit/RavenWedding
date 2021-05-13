
Namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.Localization
	Partial Class Form1
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
			Me.radVirtualGrid1 = New Telerik.WinControls.UI.RadVirtualGrid()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButtonGerman = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			DirectCast(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			DirectCast(Me.radRadioButtonGerman, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radVirtualGrid1
			' 
			Me.radVirtualGrid1.Location = New System.Drawing.Point(24, 22)
			Me.radVirtualGrid1.MasterViewInfo.RowCount = 1000
			Me.radVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radVirtualGrid1.Name = "radVirtualGrid1"
			Me.radVirtualGrid1.Size = New System.Drawing.Size(870, 512)
			Me.radVirtualGrid1.TabIndex = 0
			Me.radVirtualGrid1.Text = "radVirtualGrid1"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radRadioButton2)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonGerman)
			Me.radGroupBox1.HeaderText = "Choose Language"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 33)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New System.Drawing.Size(210, 83)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Choose Language"
			Me.radGroupBox1.UseMnemonic = False
			' 
			' radRadioButton1
			' 
			Me.radRadioButtonGerman.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radRadioButtonGerman.CheckState = System.Windows.Forms.CheckState.Checked
			Me.radRadioButtonGerman.Location = New System.Drawing.Point(5, 45)
			Me.radRadioButtonGerman.Name = "radRadioButton1"
			Me.radRadioButtonGerman.Size = New System.Drawing.Size(60, 18)
			Me.radRadioButtonGerman.TabIndex = 0
			Me.radRadioButtonGerman.Text = "German"
			Me.radRadioButtonGerman.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radRadioButton2.Location = New System.Drawing.Point(5, 21)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.Size = New System.Drawing.Size(56, 18)
			Me.radRadioButton2.TabIndex = 0
			Me.radRadioButton2.TabStop = False
			Me.radRadioButton2.Text = "English"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radVirtualGrid1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1881, 1096)
			Me.Controls.SetChildIndex(Me.radVirtualGrid1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			DirectCast(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			DirectCast(Me.radRadioButtonGerman, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButtonGerman As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace