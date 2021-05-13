Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Docking

Namespace Telerik.Examples.WinControls.Docking.DocumentManager
	Partial Public Class Form1
		Inherits ExamplesForm
		Private docCounter As Integer = 11

		Public Sub New()
			InitializeComponent()

			Me.radDock1.ShowDocumentCloseButton = True
			Me.radDock1.DocumentManager.DocumentCloseActivation = DocumentCloseActivation.FirstInZOrder
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radDock1.DocumentManager.ActivateNextDocument()
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radDock1.DocumentManager.ActivatePreviousDocument()
		End Sub

		Private Sub sortNone_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.None
		End Sub

		Private Sub sortByName_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.ByText
		End Sub

		Private Sub sortByActivation_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.ZOrdered
		End Sub

		Private Sub addDoc_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim docWindow As New DocumentWindow("documentWindow" & docCounter)
			docCounter += 1
			Me.radDock1.AddDocument(docWindow)
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radButton2.Click, AddressOf radButton2_Click
			AddHandler radButton1.Click, AddressOf radButton1_Click
			AddHandler sortNone.ToggleStateChanged, AddressOf sortNone_ToggleStateChanged
			AddHandler sortByActivation.ToggleStateChanged, AddressOf sortByActivation_ToggleStateChanged
			AddHandler sortByText.ToggleStateChanged, AddressOf sortByName_ToggleStateChanged
			AddHandler addDoc.Click, AddressOf addDoc_Click
		End Sub
	End Class
End Namespace
