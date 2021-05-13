Namespace Telerik.Examples.WinControls.Scheduler.Reminder
	Partial Public Class CustomAlarmForm
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
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton4 = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radListBox1
			' 
			Me.radListBox1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radListBox1.Location = New Point(12, 38)
			Me.radListBox1.Name = "radListBox1"
			Me.radListBox1.SelectionMode = SelectionMode.MultiExtended
			Me.radListBox1.Size = New Size(188, 323)
			Me.radListBox1.TabIndex = 0
			Me.radListBox1.Text = "Click to add new item"

			' 
			' radButton1
			' 
			Me.radButton1.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.radButton1.Location = New Point(207, 38)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(130, 24)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "Open Item"

			' 
			' radButton2
			' 
			Me.radButton2.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.radButton2.Location = New Point(207, 68)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New Size(130, 24)
			Me.radButton2.TabIndex = 2
			Me.radButton2.Text = "Snooze with a minute"

			' 
			' radButton3
			' 
			Me.radButton3.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.radButton3.Location = New Point(207, 98)
			Me.radButton3.Name = "radButton3"
			Me.radButton3.Size = New Size(130, 24)
			Me.radButton3.TabIndex = 3
			Me.radButton3.Text = "Dismiss"

			' 
			' radButton4
			' 
			Me.radButton4.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.radButton4.Location = New Point(207, 128)
			Me.radButton4.Name = "radButton4"
			Me.radButton4.Size = New Size(130, 24)
			Me.radButton4.TabIndex = 4
			Me.radButton4.Text = "Dismiss All"

			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(13, 13)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(41, 16)
			Me.radLabel1.TabIndex = 5
			Me.radLabel1.Text = "Events"
			' 
			' CustomAlarmForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(349, 387)
			Me.Controls.Add(Me.radLabel1)
			Me.Controls.Add(Me.radButton4)
			Me.Controls.Add(Me.radButton3)
			Me.Controls.Add(Me.radButton2)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.radListBox1)
			Me.Name = "CustomAlarmForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "CustomAlarmForm"

			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radListBox1 As Telerik.WinControls.UI.RadListControl
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radButton3 As Telerik.WinControls.UI.RadButton
		Private radButton4 As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace