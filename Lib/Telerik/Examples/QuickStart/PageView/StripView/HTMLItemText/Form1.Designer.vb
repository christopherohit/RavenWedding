Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls

Namespace Telerik.Examples.WinControls.PageView.StripView.HTMLItemText
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
			Me.toolStripComboBox3 = New ToolStripComboBox()
			Me.openFileDialog1 = New OpenFileDialog()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1097, 1)
			Me.settingsPanel.Size = New Size(200, 490)

			' 
			' toolStripComboBox3
			' 
			Me.toolStripComboBox3.Name = "toolStripComboBox3"
			Me.toolStripComboBox3.Size = New Size(121, 21)
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.FileName = "openFileDialog1"
			' 
			' radPageView1
			' 
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage3)
            Me.radPageView1.Location = New Point(20, 20)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New Size(400, 300)
			Me.radPageView1.TabIndex = 9
			Me.radPageView1.Text = "radPageView1"
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Location = New Point(10, 51)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New Size(379, 238)
			Me.radPageViewPage1.Text = "<html><b><color=Red>Purchases</b><br><i><color=Blue>(By Ship Date)"
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.Location = New Point(10, 51)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New Size(379, 238)
			Me.radPageViewPage2.Text = "<html><b><color=Navy>Purchases</b><br><i><color=Violet>(By Order Date)"
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.Location = New Point(10, 51)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New Size(379, 238)
			Me.radPageViewPage3.Text = "<html><b><color=Brown>Purchases</b><br><i><color=Green>(By Client ID)"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Size = New Size(1298, 492)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Protected toolStripComboBox3 As ToolStripComboBox
		Protected openFileDialog1 As OpenFileDialog
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As RadPageViewPage
		Private radPageViewPage2 As RadPageViewPage
		Private radPageViewPage3 As RadPageViewPage
	End Class
End Namespace