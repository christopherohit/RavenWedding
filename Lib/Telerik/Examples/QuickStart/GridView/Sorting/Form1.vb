Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Sorting
	Partial Public Class Form1
		Inherits ExamplesForm
		Private sortOrder As ListSortDirection = ListSortDirection.Ascending

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub BindGrid()
			Me.radGridView1.TableElement.BeginUpdate()

			Me.SelectedControl = Me.radGridView1
			Me.radGridView1.EnableHotTracking = True

			' Populate and bind the datasource.
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)
			Me.radGridView1.DataSource = customersBindingSource

			' Hide some columns, reduce clutter since columns are autogenerated.
			Me.radGridView1.Columns("CustomerID").IsVisible = False
			Me.radGridView1.Columns("Region").IsVisible = False
			Me.radGridView1.Columns("Fax").IsVisible = False
			Me.radGridView1.Columns("CompanyName").IsVisible = False
			Me.radGridView1.Columns("Phone").IsVisible = False
			Me.radGridView1.Columns("Address").IsVisible = False

			' Change header text to look normal.
			Me.radGridView1.Columns("PostalCode").HeaderText = "Postal Code"
			Me.radGridView1.Columns("ContactName").HeaderText = "Contact Name"
			Me.radGridView1.Columns("ContactTitle").HeaderText = "Contact Title"

			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Me.radGridView1.TableElement.EndUpdate(True)

			' Add grid sort expression.
			Me.radGridView1.MasterTemplate.SortDescriptors.Add("ContactName", sortOrder)
		End Sub

		Private Sub InitializeSorting()
			Me.radRadioButtonContactName.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioButtonAsc.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			BindGrid()
			Me.radLabelCol.ForeColor = Color.White
			InitializeSorting()
		End Sub

		Private Sub radRadioButtonAsc_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButtonTitleCountryCity.ToggleStateChanged, radRadioButtonContactTitleCity.ToggleStateChanged, radRadioButtonCountry.ToggleStateChanged, radRadioButtonCity.ToggleStateChanged, radRadioButtonContactTitle.ToggleStateChanged, radRadioButtonContactName.ToggleStateChanged, radRadioButtonPostalCode.ToggleStateChanged, radRadioButtonDesc.ToggleStateChanged, radRadioButtonAsc.ToggleStateChanged
			If Me.radRadioButtonAsc.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.sortOrder = ListSortDirection.Ascending
			End If
			If Me.radRadioButtonDesc.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.sortOrder = ListSortDirection.Descending
			End If

			radGridView1.MasterTemplate.SortDescriptors.Clear()

			If Me.radRadioButtonNone.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Return
			End If

			If Me.radRadioButtonContactName.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radLabelCol.Text = "Contact Name"
				Me.radGridView1.MasterTemplate.SortDescriptors.Add("ContactName", sortOrder)
			End If

			If Me.radRadioButtonContactTitle.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radLabelCol.Text = "Contact Title"
				Me.radGridView1.MasterTemplate.SortDescriptors.Add("ContactTitle", sortOrder)
			End If

			If Me.radRadioButtonCity.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radLabelCol.Text = "City"
				Me.radGridView1.MasterTemplate.SortDescriptors.Add("City", sortOrder)
			End If

			If Me.radRadioButtonPostalCode.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radLabelCol.Text = "Postal Code"
				Me.radGridView1.MasterTemplate.SortDescriptors.Add("PostalCode", sortOrder)
			End If

			If Me.radRadioButtonCountry.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radLabelCol.Text = "Country"
				Me.radGridView1.MasterTemplate.SortDescriptors.Add("Country", sortOrder)
			End If

			If Me.radRadioButtonContactTitleCity.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radLabelCol.Text = "Contact Title and City"
				Me.radGridView1.MasterTemplate.SortDescriptors.Add("ContactTitle", sortOrder)
				Me.radGridView1.MasterTemplate.SortDescriptors.Add("City", sortOrder)
			End If

			If Me.radRadioButtonTitleCountryCity.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radLabelCol.Text = "Contact Title, Country and City"
				Me.radGridView1.MasterTemplate.SortDescriptors.Add("ContactTitle", sortOrder)
				Me.radGridView1.MasterTemplate.SortDescriptors.Add("Country", sortOrder)
				Me.radGridView1.MasterTemplate.SortDescriptors.Add("City", sortOrder)
			End If
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
