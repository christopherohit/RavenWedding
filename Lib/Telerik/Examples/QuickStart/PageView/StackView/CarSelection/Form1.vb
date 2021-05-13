Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PageView.StackView.CarSelection
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

			Me.AddPriceText()
			Me.AttachEvents()

			Dim item As New RadListDataItem("Base MSRP " & vbTab & "$29, 400")
			item.Font = New Font(New FontFamily("Arial"), 8.25F, FontStyle.Bold)
			Me.radListOptions.Items.Add(item)
		End Sub

		Private Sub AddPriceText()
		End Sub

		Private Sub AttachEvents()
			For Each child As Control In ControlHelper.EnumChildControls(Me.radPageView1, True)
				Dim check As RadCheckBox = TryCast(child, RadCheckBox)
				If check IsNot Nothing Then
					AddHandler check.ToggleStateChanged, AddressOf OnCheck_ToggleStateChanged
				End If
			Next child
		End Sub

		#End Region

		#Region "Events Handlers"

		Private Sub OnCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Dim check As RadCheckBox = TryCast(sender, RadCheckBox)

			If check.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Dim item As New RadListDataItem(check.Text)
				check.Tag = item
				Me.radListOptions.Items.Add(item)
			Else
				Me.radListOptions.Items.Remove(TryCast(check.Tag, RadListDataItem))
			End If
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace