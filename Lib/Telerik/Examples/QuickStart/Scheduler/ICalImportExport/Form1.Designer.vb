Namespace Telerik.Examples.WinControls.Scheduler.ICalImportExport
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
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.ForeColor = Color.Black
			Me.settingsPanel.Location = New Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = Color.Black
			Me.settingsPanel.Size = New Size(200, 818)

			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radScheduler1
			' 
			Me.radScheduler1.BackColor = Color.White
			Me.radScheduler1.DataSource = Nothing
			Me.radScheduler1.Dock = DockStyle.Fill
			Me.radScheduler1.ForeColor = Color.Black
			Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radScheduler1.HeaderFormat = "MMMM dd"
			Me.radScheduler1.Location = New Point(0, 0)
			Me.radScheduler1.Name = "radScheduler1"
			' 
			' 
			' 
			Me.radScheduler1.RootElement.ForeColor = Color.Black
			Me.radScheduler1.Size = New Size(1224, 820)
			Me.radScheduler1.TabIndex = 1
			Me.radScheduler1.Text = "radScheduler1"
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = AnchorStyles.Top
			Me.radButton1.Location = New Point(16, 30)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(140, 30)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "Export"
			' 
			' radButton2
			' 
			Me.radButton2.Anchor = AnchorStyles.Top
			Me.radButton2.Location = New Point(16, 75)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New Size(140, 30)
			Me.radButton2.TabIndex = 2
			Me.radButton2.Text = "Import"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radButton1)
			Me.radGroupBox1.Controls.Add(Me.radButton2)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(0)
			Me.radGroupBox1.HeaderText = "Settings"
			Me.radGroupBox1.Location = New Point(10, 8)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 120)
			Me.radGroupBox1.TabIndex = 3
			Me.radGroupBox1.Text = "Settings"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Name = "Form1"
			Me.Size = New Size(1224, 820)
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace