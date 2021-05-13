Namespace Telerik.Examples.WinControls.Calendar.ReadOnlyView
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
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.radCheckReadOnly = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckReadOnly, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckReadOnly)
			Me.settingsPanel.Location = New Point(895, 1)
			Me.settingsPanel.Size = New Size(200, 694)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckReadOnly, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.BackColor = Color.FromArgb((CInt((CByte(248)))), (CInt((CByte(248)))), (CInt((CByte(248)))))
			Me.radCalendar1.FocusedDate = New Date(2013, 3, 13, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = Color.Black
			Me.radCalendar1.Location = New Point(0, 0)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.ReadOnly = True
			Me.radCalendar1.Size = New Size(288, 229)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radCheckReadOnly
			' 
			Me.radCheckReadOnly.Anchor = AnchorStyles.Top
			Me.radCheckReadOnly.Location = New Point(10, 6)
			Me.radCheckReadOnly.Name = "radCheckReadOnly"
			Me.radCheckReadOnly.Size = New Size(117, 18)
			Me.radCheckReadOnly.TabIndex = 1
			Me.radCheckReadOnly.Text = "Read-only calendar"
			Me.radCheckReadOnly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New Size(1170, 754)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckReadOnly, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private radCheckReadOnly As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace