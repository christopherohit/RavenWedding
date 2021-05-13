using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Map.Shapefile
{
    public partial class BookingForm : RadForm
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowForm(string performance, int numberOfTickets, int totalPrice, bool isReservation)
        {
            this.radLabelPerformance.Text = performance;
            this.radLabelTickets.Text = numberOfTickets.ToString();
            this.radLabelTotalPrice.Text = string.Format("{0:C0}", totalPrice);
            this.radButtonBuyReserve.Text = isReservation ? "RESERVE" : "BUY";

            this.radTextBoxEmail.Text = "john.smith@gmail.com";
            this.radTextBoxName.Text = "John Smith";
            this.radTextBoxCardNumber.Text = "1234-5678-8765-4321";
            this.radTextBoxExpirationDate.Text = "10/2030";

            return this.ShowDialog();
        }

        private void radButtonBuyReserve_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
