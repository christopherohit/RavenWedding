Namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.Performance
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
			Me.radTreeViewDemo = New Telerik.WinControls.UI.RadTreeView()
			Me.radBtnLoad = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTreeViewDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnLoad, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radBtnLoad)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Controls.Add(Me.radProgressBar1)
			Me.settingsPanel.Location = New Point(982, 1)
			Me.settingsPanel.Size = New Size(200, 830)

			Me.settingsPanel.Controls.SetChildIndex(Me.radProgressBar1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radBtnLoad, 0)
			' 
			' radTreeViewDemo
			' 
			Me.radTreeViewDemo.Dock = DockStyle.Left
			Me.radTreeViewDemo.Location = New Point(0, 0)
			Me.radTreeViewDemo.Name = "radTreeViewDemo"
			Me.radTreeViewDemo.Size = New Size(246, 762)
			Me.radTreeViewDemo.SpacingBetweenNodes = -1
			Me.radTreeViewDemo.TabIndex = 0
			Me.radTreeViewDemo.Text = "radTreeView1"
			' 
			' radBtnLoad
			' 
			Me.radBtnLoad.Anchor = AnchorStyles.Top
			Me.radBtnLoad.Location = New Point(10, 37)
			Me.radBtnLoad.Name = "radBtnLoad"
			Me.radBtnLoad.Size = New Size(180, 26)
			Me.radBtnLoad.TabIndex = 2
			Me.radBtnLoad.Text = "Load 50,000 nodes"

			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(10, 87)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(74, 18)
			Me.radLabel1.TabIndex = 3
			Me.radLabel1.Text = "Time Elapsed:"
			' 
			' radProgressBar1
			' 
			Me.radProgressBar1.Anchor = AnchorStyles.Top
			Me.radProgressBar1.Location = New Point(10, 69)
			Me.radProgressBar1.Maximum = 50000
			Me.radProgressBar1.Name = "radProgressBar1"
			Me.radProgressBar1.Size = New Size(180, 12)
			Me.radProgressBar1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radTreeViewDemo)
			Me.Name = "Form1"
			Me.Size = New Size(1028, 762)
			Me.Controls.SetChildIndex(Me.radTreeViewDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radTreeViewDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnLoad, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTreeViewDemo As Telerik.WinControls.UI.RadTreeView
		Private radBtnLoad As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radProgressBar1 As Telerik.WinControls.UI.RadProgressBar
	End Class
End Namespace