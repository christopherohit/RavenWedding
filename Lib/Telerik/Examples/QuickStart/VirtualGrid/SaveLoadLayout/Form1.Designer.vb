
Namespace Telerik.Examples.WinControls.VirtualGrid.SaveLoadLayout
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
			Me.radButtonSaveLayout = New Telerik.WinControls.UI.RadButton()
			Me.radButtonLoadLayout = New Telerik.WinControls.UI.RadButton()
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			DirectCast(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radButtonSaveLayout, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radButtonLoadLayout, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radButtonSaveLayout)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButtonSaveLayout, 0)
			Me.settingsPanel.Controls.Add(Me.radButtonLoadLayout)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButtonLoadLayout, 1)
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
			' radToggleButtonUseRTL
			' 
			Me.radButtonSaveLayout.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButtonSaveLayout.Location = New System.Drawing.Point(10, 33)
			Me.radButtonSaveLayout.Name = "radButtonSaveLayout"
			Me.radButtonSaveLayout.Size = New System.Drawing.Size(210, 24)
			Me.radButtonSaveLayout.TabIndex = 1
			Me.radButtonSaveLayout.Text = "Save Layout"
			' 
			' radToggleButtonUseRTL
			' 
			Me.radButtonLoadLayout.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButtonLoadLayout.Location = New System.Drawing.Point(10, 63)
			Me.radButtonLoadLayout.Name = "radButtonLoadLayout"
			Me.radButtonLoadLayout.Size = New System.Drawing.Size(210, 24)
			Me.radButtonLoadLayout.TabIndex = 1
			Me.radButtonLoadLayout.Text = "Load Layout"
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
			DirectCast(Me.radButtonSaveLayout, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radButtonLoadLayout, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

        Private WithEvents radVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
		Private radButtonSaveLayout As Telerik.WinControls.UI.RadButton
		Private radButtonLoadLayout As Telerik.WinControls.UI.RadButton
	End Class
End Namespace