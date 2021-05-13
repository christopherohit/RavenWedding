Namespace Telerik.Examples.WinControls.Calendar.SpecialDays
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim radCalendarDay1 As New Telerik.WinControls.UI.RadCalendarDay()
			Dim radCalendarDay2 As New Telerik.WinControls.UI.RadCalendarDay()
			Me.imageList1 = New ImageList(Me.components)
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 735)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "boss.png")
			Me.imageList1.Images.SetKeyName(1, "AnnsBirthday.PNG")
			' 
			' radCalendar1
			' 
			Me.radCalendar1.BackColor = Color.FromArgb((CInt((CByte(248)))), (CInt((CByte(248)))), (CInt((CByte(248)))))
			Me.radCalendar1.Dock = DockStyle.Top
			Me.radCalendar1.FocusedDate = New Date(2013, 3, 15, 0, 0, 0, 0)
			Me.radCalendar1.Location = New Point(0, 0)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.Size = New Size(1134, 486)
			radCalendarDay1.Date = New Date(2013, 3, 10, 0, 0, 0, 0)
			radCalendarDay1.Selectable = False
			radCalendarDay2.Date = New Date(2013, 3, 26, 0, 0, 0, 0)
			radCalendarDay2.Selectable = False
			Me.radCalendar1.SpecialDays.Add(radCalendarDay1)
			Me.radCalendar1.SpecialDays.Add(radCalendarDay2)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New Size(1144, 489)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private imageList1 As ImageList
	End Class
End Namespace