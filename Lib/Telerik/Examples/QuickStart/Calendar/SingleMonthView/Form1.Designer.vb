Namespace Telerik.Examples.WinControls.Calendar.SingleMonthView
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
			Me.radRadioRows = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioCols = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioRows, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioCols, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(729, 1)
			Me.settingsPanel.Size = New Size(250, 867)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.BackColor = Color.FromArgb((CInt((CByte(248)))), (CInt((CByte(248)))), (CInt((CByte(248)))))
			Me.radCalendar1.FocusedDate = New Date(2013, 3, 13, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = Color.Black
			Me.radCalendar1.Location = New Point(0, 0)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.Size = New Size(288, 229)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radRadioRows
			' 
			Me.radRadioRows.Location = New Point(22, 28)
			Me.radRadioRows.Name = "radRadioRows"
			Me.radRadioRows.Size = New Size(98, 18)
			Me.radRadioRows.TabIndex = 2
			Me.radRadioRows.Text = "Render In Rows"

			' 
			' radRadioCols
			' 
			Me.radRadioCols.Location = New Point(22, 50)
			Me.radRadioCols.Name = "radRadioCols"
			Me.radRadioCols.Size = New Size(115, 18)
			Me.radRadioCols.TabIndex = 2
			Me.radRadioCols.Text = "Render In Columns"

			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Controls.Add(Me.radRadioRows)
			Me.radGroupBox1.Controls.Add(Me.radRadioCols)
			Me.radGroupBox1.HeaderText = "Rendering Options"
			Me.radGroupBox1.Location = New Point(15, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(2, 18, 2, 2)
			Me.radGroupBox1.Size = New Size(162, 84)
			Me.radGroupBox1.TabIndex = 3
			Me.radGroupBox1.Text = "Rendering Options"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New Size(1203, 762)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioRows, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioCols, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private radRadioRows As Telerik.WinControls.UI.RadRadioButton
		Private radRadioCols As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace