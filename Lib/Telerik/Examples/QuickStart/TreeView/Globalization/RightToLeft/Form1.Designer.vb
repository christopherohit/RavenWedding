Namespace Telerik.Examples.WinControls.TreeView.Globalization.RightToLeft
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
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.radCheckBoxRightToLeft = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxRightToLeft, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckBoxRightToLeft)
			Me.settingsPanel.Location = New Point(1040, 1)
			Me.settingsPanel.Size = New Size(200, 830)

			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxRightToLeft, 0)
			' 
			' radTreeView1
			' 
			Me.radTreeView1.AccessibleName = "RadTreeView"
			Me.radTreeView1.AccessibleRole = AccessibleRole.List
			Me.radTreeView1.CheckBoxes = True
			Me.radTreeView1.Cursor = Cursors.Default
			Me.radTreeView1.Dock = DockStyle.Left
			Me.radTreeView1.Font = New Font("Tahoma", 8.6F)
			Me.radTreeView1.ItemHeight = 27
			Me.radTreeView1.Location = New Point(0, 0)
			Me.radTreeView1.Name = "radTreeView1"
			Me.radTreeView1.Size = New Size(246, 752)
			Me.radTreeView1.SpacingBetweenNodes = -1
			Me.radTreeView1.TabIndex = 0
			Me.radTreeView1.Text = "radTreeView1"
			' 
			' radCheckBoxRightToLeft
			' 
			Me.radCheckBoxRightToLeft.Anchor = AnchorStyles.Top
			Me.radCheckBoxRightToLeft.Location = New Point(10, 37)
			Me.radCheckBoxRightToLeft.Name = "radCheckBoxRightToLeft"
			Me.radCheckBoxRightToLeft.Size = New Size(82, 18)
			Me.radCheckBoxRightToLeft.TabIndex = 1
			Me.radCheckBoxRightToLeft.Text = "Right to Left"

			' 
			' Form1
			' 
			Me.Controls.Add(Me.radTreeView1)
			Me.Name = "Form1"
            Me.Size = New Size(1028, 762)
            AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.SetChildIndex(Me.radTreeView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxRightToLeft, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private radCheckBoxRightToLeft As Telerik.WinControls.UI.RadCheckBox


	End Class
End Namespace