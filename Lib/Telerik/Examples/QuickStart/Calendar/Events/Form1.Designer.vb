Namespace Telerik.Examples.WinControls.Calendar.Events
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
			Me.radListBoxEvents = New Telerik.WinControls.UI.RadListControl()
			Me.radButtonClear = New Telerik.WinControls.UI.RadButton()
			Me.radGroupEvents = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListBoxEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupEvents.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupEvents)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 818)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupEvents, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full
			Me.radCalendar1.FocusedDate = New Date(2009, 3, 15, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = Color.Black
			Me.radCalendar1.Location = New Point(0, 0)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.Size = New Size(496, 246)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radListBoxEvents
			' 
			Me.radListBoxEvents.AutoScroll = True
			Me.radListBoxEvents.Font = New Font("Verdana", 8F)
			Me.radListBoxEvents.Location = New Point(23, 21)
			Me.radListBoxEvents.Margin = New Padding(4, 3, 4, 3)
			Me.radListBoxEvents.Name = "radListBoxEvents"
			Me.radListBoxEvents.Size = New Size(135, 200)
			Me.radListBoxEvents.TabIndex = 6
			' 
			' radButtonClear
			' 
			Me.radButtonClear.Location = New Point(23, 227)
			Me.radButtonClear.Name = "radButtonClear"
			Me.radButtonClear.Size = New Size(135, 23)
			Me.radButtonClear.TabIndex = 8
			Me.radButtonClear.Text = "Clear"

			' 
			' radGroupEvents
			' 
			Me.radGroupEvents.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupEvents.Anchor = AnchorStyles.Top
			Me.radGroupEvents.Controls.Add(Me.radButtonClear)
			Me.radGroupEvents.Controls.Add(Me.radListBoxEvents)
			Me.radGroupEvents.HeaderText = "Events"
			Me.radGroupEvents.Location = New Point(10, 6)
			Me.radGroupEvents.Name = "radGroupEvents"
			Me.radGroupEvents.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupEvents.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupEvents.Size = New Size(180, 263)
			Me.radGroupEvents.TabIndex = 6
			Me.radGroupEvents.Text = "Events"
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
			CType(Me.radListBoxEvents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupEvents.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private radButtonClear As Telerik.WinControls.UI.RadButton
		Private radListBoxEvents As Telerik.WinControls.UI.RadListControl
		Private radGroupEvents As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace