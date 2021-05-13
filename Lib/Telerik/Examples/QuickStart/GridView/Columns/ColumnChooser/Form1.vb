Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Columns.ColumnChooser
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radGridView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radGridView1.TableElement.BeginUpdate()

			Me.BindGrid()
			Me.radGridView1.Columns(0).IsVisible = False

			Me.radGridView1.EnableHotTracking = True
			Me.radGridView1.TableElement.EndUpdate(True)
			Me.radGridView1.ShowColumnChooser()
		End Sub

		Private Sub BindGrid()
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)
		End Sub

		Private Sub btnOpenCondFormatting_Click(ByVal sender As Object, ByVal e As EventArgs)
			radGridView1.ShowColumnChooser()
		End Sub

		Protected Overrides Sub WireEvents()
            AddHandler radBtnLaunchColChooser.Click, AddressOf btnOpenCondFormatting_Click
            AddHandler radGridView1.ColumnChooserCreated, AddressOf RadGridView1_ColumnChooserCreated
            AddHandler RadCheckBoxEnableFiltering.CheckStateChanged, AddressOf RadCheckBoxEnableFiltering_CheckStateChanged
        End Sub

        Private Sub RadCheckBoxEnableFiltering_CheckStateChanged(sender As Object, e As EventArgs)
            Me.radGridView1.ColumnChooser.EnableFilter = Me.RadCheckBoxEnableFiltering.Checked
        End Sub

        Private Sub RadGridView1_ColumnChooserCreated(sender As Object, e As ColumnChooserCreatedEventArgs)
            e.ColumnChooser.EnableFilter = Me.RadCheckBoxEnableFiltering.Checked
        End Sub
    End Class
End Namespace