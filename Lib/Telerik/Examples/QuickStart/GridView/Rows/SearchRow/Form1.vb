Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Rows.SearchRow
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()

            Dim nwindDataSet As New NorthwindDataSet()
            Dim customersTableAdapter As New CustomersTableAdapter()
            Dim customersBindingSource As New BindingSource()
            customersTableAdapter.Fill(nwindDataSet.Customers)
            customersBindingSource.DataSource = nwindDataSet.Customers
            radGridView1.DataSource = customersBindingSource
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.radGridView1.Columns("Region").IsVisible = False
            Me.radGridView1.Columns("Phone").IsVisible = False
            Me.radGridView1.Columns("Fax").IsVisible = False
        End Sub

        Private Sub radCheckBoxShowClearButton_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.MasterView.TableSearchRow.ShowClearButton = Me.radCheckBoxShowClearButton.IsChecked
        End Sub

        Private Sub radCheckBoxShowCloseButton_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.MasterView.TableSearchRow.ShowCloseButton = Me.radCheckBoxShowCloseButton.IsChecked
        End Sub

        Private Sub radCheckBoxCloseOnEscape_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.MasterView.TableSearchRow.CloseOnEscape = Me.radCheckBoxCloseOnEscape.IsChecked
        End Sub

        Private Sub radCheckBoxDeferredSearch_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.MasterView.TableSearchRow.DeferredSearch = Me.radCheckBoxDeferredSearch.IsChecked
        End Sub
    End Class
End Namespace