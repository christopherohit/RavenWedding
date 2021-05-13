Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.DataSources

Namespace Telerik.Examples.WinControls.MultiColumnComboBox.FirstLook
    Public Partial Class OrderInfoUserControl
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub PopulateData(ByVal order As NorthwindDataSet.OrdersRow)
            Me.firstNameLabel.Text = order.EmployeesRow.FirstName
            Me.lastNameLabel.Text = order.EmployeesRow.LastName
            Me.initialsLabel.Text = Me.firstNameLabel.Text.ToUpper()(0).ToString() + Me.lastNameLabel.Text.ToUpper()(0).ToString()
            Me.customerLabel.Text = order.CustomersRow.ContactName
            Me.productCountLabel.Text = order.GetOrder_DetailsRows().Count().ToString()
        End Sub
    End Class
End Namespace
