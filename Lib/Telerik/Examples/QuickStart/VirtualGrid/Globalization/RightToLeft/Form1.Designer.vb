
Namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.RightToLeft
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
			Me.radToggleButtonUseRTL = New Telerik.WinControls.UI.RadToggleButton()
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			DirectCast(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radToggleButtonUseRTL, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radToggleButtonUseRTL)
			Me.settingsPanel.Controls.SetChildIndex(Me.radToggleButtonUseRTL, 0)
			' 
			' radVirtualGrid1
			' 
			Me.radVirtualGrid1.Location = New System.Drawing.Point(24, 22)
			Me.radVirtualGrid1.MasterViewInfo.RowCount = 1000
			Me.radVirtualGrid1.Name = "radVirtualGrid1"
			Me.radVirtualGrid1.Size = New System.Drawing.Size(870, 512)
			Me.radVirtualGrid1.TabIndex = 0
			Me.radVirtualGrid1.Text = "radVirtualGrid1"
			' 
			' radToggleButtonUseRTL
			' 
			Me.radToggleButtonUseRTL.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radToggleButtonUseRTL.CheckState = System.Windows.Forms.CheckState.Checked
			Me.radToggleButtonUseRTL.Location = New System.Drawing.Point(10, 33)
			Me.radToggleButtonUseRTL.Name = "radToggleButtonUseRTL"
			Me.radToggleButtonUseRTL.Size = New System.Drawing.Size(210, 24)
			Me.radToggleButtonUseRTL.TabIndex = 1
			Me.radToggleButtonUseRTL.Text = "Use RTL"
			Me.radToggleButtonUseRTL.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
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
			DirectCast(Me.radToggleButtonUseRTL, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

        Private WithEvents radVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
		Private radToggleButtonUseRTL As Telerik.WinControls.UI.RadToggleButton
	End Class
End Namespace