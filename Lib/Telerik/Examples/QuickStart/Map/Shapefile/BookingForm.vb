Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Map.Shapefile
	Partial Public Class BookingForm
		Inherits RadForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Function ShowForm(ByVal performance As String, ByVal numberOfTickets As Integer, ByVal totalPrice As Integer, ByVal isReservation As Boolean) As DialogResult
			Me.radLabelPerformance.Text = performance
			Me.radLabelTickets.Text = numberOfTickets.ToString()
			Me.radLabelTotalPrice.Text = String.Format("{0:C0}", totalPrice)
			Me.radButtonBuyReserve.Text = If(isReservation, "RESERVE", "BUY")

			Me.radTextBoxEmail.Text = "john.smith@gmail.com"
			Me.radTextBoxName.Text = "John Smith"
			Me.radTextBoxCardNumber.Text = "1234-5678-8765-4321"
			Me.radTextBoxExpirationDate.Text = "10/2030"

			Return Me.ShowDialog()
		End Function

		Private Sub radButtonBuyReserve_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonBuyReserve.Click
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub
	End Class
End Namespace
