Namespace Telerik.Examples.WinControls.GridView.Rows.RowsReorder
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.btnMoveUp = New Telerik.WinControls.UI.RadButton()
			Me.btnMoveDown = New Telerik.WinControls.UI.RadButton()
			Me.imageList1 = New ImageList(Me.components)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnMoveUp, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnMoveDown, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.btnMoveUp)
			Me.settingsPanel.Controls.Add(Me.btnMoveDown)
			Me.settingsPanel.Location = New Point(911, 1)
			Me.settingsPanel.Size = New Size(200, 747)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.btnMoveDown, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.btnMoveUp, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.Location = New Point(0, 0)
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Padding = New Padding(0, 0, 0, 1)
			' 
			' 
			' 
			Me.radGridView1.RootElement.Padding = New Padding(0, 0, 0, 1)
			Me.radGridView1.Size = New Size(1112, 749)
			Me.radGridView1.TabIndex = 1
			Me.radGridView1.Text = "radGridView1"
			' 
			' btnMoveUp
			' 
			Me.btnMoveUp.Anchor = AnchorStyles.Top
			Me.btnMoveUp.Image = My.Resources.arrow_up2
			Me.btnMoveUp.ImageScalingSize = New Size(24, 24)
			Me.btnMoveUp.Location = New Point(10, 37)
			Me.btnMoveUp.Name = "btnMoveUp"
			Me.btnMoveUp.Padding = New Padding(5, 0, 0, 0)
			Me.btnMoveUp.Size = New Size(180, 30)
			Me.btnMoveUp.TabIndex = 1
			Me.btnMoveUp.Text = "Move Up"

			' 
			' btnMoveDown
			' 
			Me.btnMoveDown.Anchor = AnchorStyles.Top
			Me.btnMoveDown.Image = My.Resources.arrow_down1
			Me.btnMoveDown.ImageScalingSize = New Size(24, 24)
			Me.btnMoveDown.Location = New Point(10, 73)
			Me.btnMoveDown.Name = "btnMoveDown"
			Me.btnMoveDown.Padding = New Padding(5, 0, 0, 0)
			Me.btnMoveDown.Size = New Size(180, 30)
			Me.btnMoveDown.TabIndex = 2
			Me.btnMoveDown.Text = "Move Down"

			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "TaskCompleted.png")
			Me.imageList1.Images.SetKeyName(1, "TaskNotCompleted.png")
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Size(1112, 749)

			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnMoveUp, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnMoveDown, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private btnMoveUp As Telerik.WinControls.UI.RadButton
		Private btnMoveDown As Telerik.WinControls.UI.RadButton
		Private imageList1 As ImageList
	End Class
End Namespace
