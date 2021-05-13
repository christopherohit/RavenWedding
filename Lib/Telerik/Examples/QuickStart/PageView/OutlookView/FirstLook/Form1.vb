Imports Telerik.QuickStart.WinControls
Imports My

Namespace Telerik.Examples.WinControls.PageView.OutlookView.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radPageViewPage1.Image = Resources.OutlookViewNotes
			Me.radPageViewPage2.Image = Resources.OutlookViewTasks
			Me.radPageViewPage3.Image = Resources.OutlookViewContacts
			Me.radPageViewPage4.Image = Resources.OutlookViewCalendar
			Me.radPageViewPage6.Image = Resources.OutlookViewMail
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
