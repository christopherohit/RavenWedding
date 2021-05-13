Namespace Telerik.Examples.WinControls.Calendar.MultiMonthView
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
			Me.radGroupRenderDir = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioRows = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioCols = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupRenderDir, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupRenderDir.SuspendLayout()
			CType(Me.radRadioRows, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioCols, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupRenderDir)
			Me.settingsPanel.Location = New Point(729, 1)
			Me.settingsPanel.Size = New Size(250, 867)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupRenderDir, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radCalendar1.BackColor = Color.FromArgb((CInt((CByte(248)))), (CInt((CByte(248)))), (CInt((CByte(248)))))
			Me.radCalendar1.FocusedDate = New Date(2009, 3, 9, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = Color.Black
			Me.radCalendar1.Location = New Point(0, 0)
			Me.radCalendar1.MinimumSize = New Size(443, 406)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.Padding = New Padding(5)
			' 
			' 
			' 
			Me.radCalendar1.RootElement.MinSize = New Size(443, 406)
			Me.radCalendar1.Size = New Size(662, 579)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radGroupRenderDir
			' 
			Me.radGroupRenderDir.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupRenderDir.Anchor = AnchorStyles.Top
			Me.radGroupRenderDir.Controls.Add(Me.radRadioRows)
			Me.radGroupRenderDir.Controls.Add(Me.radRadioCols)
			Me.radGroupRenderDir.HeaderText = "Rendering Direction"
			Me.radGroupRenderDir.Location = New Point(10, 6)
			Me.radGroupRenderDir.Name = "radGroupRenderDir"
			Me.radGroupRenderDir.Size = New Size(230, 88)
			Me.radGroupRenderDir.TabIndex = 5
			Me.radGroupRenderDir.Text = "Rendering Direction"
			' 
			' radRadioRows
			' 
			Me.radRadioRows.Anchor = AnchorStyles.Top
			Me.radRadioRows.Location = New Point(5, 29)
			Me.radRadioRows.Name = "radRadioRows"
			Me.radRadioRows.Size = New Size(98, 18)
			Me.radRadioRows.TabIndex = 6
			Me.radRadioRows.Text = "Render In Rows"
			' 
			' radRadioCols
			' 
			Me.radRadioCols.Anchor = AnchorStyles.Top
			Me.radRadioCols.Location = New Point(5, 51)
			Me.radRadioCols.Name = "radRadioCols"
			Me.radRadioCols.Size = New Size(115, 18)
			Me.radRadioCols.TabIndex = 6
			Me.radRadioCols.Text = "Render In Columns"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New Size(1168, 694)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupRenderDir, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupRenderDir.ResumeLayout(False)
			Me.radGroupRenderDir.PerformLayout()
			CType(Me.radRadioRows, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioCols, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private radGroupRenderDir As Telerik.WinControls.UI.RadGroupBox
		Private radRadioRows As Telerik.WinControls.UI.RadRadioButton
		Private radRadioCols As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace