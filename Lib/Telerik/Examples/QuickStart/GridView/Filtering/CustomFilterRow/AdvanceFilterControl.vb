Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
	Partial Public Class AdvanceFilterControl
		Inherits UserControl
		#Region "Fields"

'INSTANT VB NOTE: The variable gridView was renamed since Visual Basic does not allow class members with the same name:
		Private gridView_Renamed As RadGridView
		Private advancedFilterDescriptor As New FilterDescriptor(String.Empty, FilterOperator.None, Nothing)

		#End Region

		#Region "Constructors"

		Public Sub New()
            InitializeComponent()
            WireEvents()
			AddHandler radDdlColumns.SelectedIndexChanged, AddressOf radDdlColumns_SelectedIndexChanged

		End Sub

		Public Sub New(ByVal template As RadGridView)
			Me.New()
			Me.gridView_Renamed = template
		End Sub

		#End Region

		#Region "Properties"

		Public Property GridView() As RadGridView
			Get
				Return Me.gridView_Renamed
			End Get
			Set(ByVal value As RadGridView)
				If Me.gridView_Renamed IsNot value Then
					If Me.gridView_Renamed IsNot Nothing Then
						RemoveHandler gridView_Renamed.CustomFiltering, AddressOf GridView_CustomFiltering
					End If

					Me.gridView_Renamed = value

					If Me.gridView_Renamed IsNot Nothing Then
						AddHandler gridView_Renamed.CustomFiltering, AddressOf GridView_CustomFiltering
						Me.UpdateTheme(Me.Controls)
					End If

					Me.InitializeAdvanceView()
				End If
			End Set
		End Property

		Private Sub UpdateTheme(ByVal controls As ControlCollection)
			For Each currentControl As Control In controls
				Dim current As RadControl = TryCast(currentControl, RadControl)
				If current IsNot Nothing Then
					current.ThemeName = Me.gridView_Renamed.ThemeName
                    Dim pageView As RadPageView = TryCast(current, RadPageView)
					If pageView IsNot Nothing Then
						For Each page As RadPageViewPage In pageView.Pages
							Me.UpdateTheme(page.Controls)
						Next page
                    End If
                    Dim dropDown As RadDropDownButton = TryCast(current, RadDropDownButton)
                    If dropDown IsNot Nothing Then
                        dropDown.DropDownButtonElement.BorderThickness = New Padding(0)
                    End If

				End If
			Next currentControl
		End Sub

		#End Region

		#Region "Methods"

		Private Sub InitializeAdvanceView()
			Me.radDdlColumns.DataSource = Me.gridView_Renamed.Columns
			Me.radDdlColumns.ValueMember = "Name"
			Me.radDdlColumns.DisplayMember = "Name"
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub radDdlColumns_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radDropDownButtonOperator.Items.Clear()
			Me.rtbValue1.Text = String.Empty
			Me.rtbValue1.Enabled = False

			If Me.radDdlColumns.SelectedItem IsNot Nothing Then
				Dim dataColumn As GridViewDataColumn = TryCast(Me.radDdlColumns.SelectedItem.DataBoundItem, GridViewDataColumn)

				Me.radDropDownButtonOperator.Enabled = True
				Me.radDropDownButtonOperator.Text = "No Filter"

				Me.advancedFilterDescriptor.Operator = FilterOperator.None
				Me.advancedFilterDescriptor.PropertyName = dataColumn.Name

				Dim listContext As List(Of FilterOperationContext) = FilterOperationContext.GetFilterOperations(dataColumn.DataType)
				For Each context As FilterOperationContext In listContext
					Dim menuItem As New RadMenuItem(context.Name, context.Operator)
					AddHandler menuItem.Click, AddressOf menuItem_Click
					Me.radDropDownButtonOperator.Items.Add(menuItem)
				Next context
			Else
				Me.radDropDownButtonOperator.Enabled = False
				Me.radDropDownButtonOperator.Text = String.Empty
			End If
		End Sub

		Private Sub menuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim menuItem As RadMenuItem = TryCast(sender, RadMenuItem)
			Me.radDropDownButtonOperator.Text = menuItem.Text

			Dim filterOperator As FilterOperator = CType(menuItem.Tag, FilterOperator)
			Me.advancedFilterDescriptor.Operator = filterOperator

			Me.rtbValue1.Enabled = filterOperator <> FilterOperator.None AndAlso filterOperator <> FilterOperator.IsNull AndAlso filterOperator <> FilterOperator.IsNotNull
		End Sub

        Private Sub radBtnAdvanceApply_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.gridView.EndEdit()

            Dim tableElement As GridTableElement = Me.gridView.TableElement
            Dim masterTemplate As MasterGridViewTemplate = Me.gridView.MasterTemplate
            tableElement.BeginUpdate()
            Me.gridView.EnableCustomFiltering = False
            masterTemplate.DataView.Refresh()
            tableElement.EndUpdate(False)

            For Each row As GridViewRowInfo In Me.gridView.Rows
                For Each cell As GridViewCellInfo In row.Cells
                    cell.Style.Reset()
                Next cell
            Next row

            If Me.radDdlColumns.SelectedItem IsNot Nothing Then
                Dim value As Object = Nothing

                If Not String.IsNullOrEmpty(Me.rtbValue1.Text) Then
                    Dim dataColumn As GridViewDataColumn = TryCast(Me.radDdlColumns.SelectedItem.DataBoundItem, GridViewDataColumn)

                    If TypeOf dataColumn Is GridViewDateTimeColumn Then
                        Dim dateTimeValue As Date = Nothing
                        If Date.TryParse(Me.rtbValue1.Text, dateTimeValue) Then
                            value = dateTimeValue
                        Else
                            RadMessageBox.SetThemeName(Me.gridView.ThemeName)
                            RadMessageBox.Show("The entered value is not valid. Please enter valid date", "Error", MessageBoxButtons.OK)
                        End If
                    ElseIf TypeOf dataColumn Is GridViewDecimalColumn Then
                        Dim decimalValue As Decimal = Nothing
                        If Decimal.TryParse(Me.rtbValue1.Text, decimalValue) Then
                            value = decimalValue
                        Else
                            RadMessageBox.SetThemeName(Me.gridView.ThemeName)
                            RadMessageBox.Show("The entered value is not valid. Please enter valid decimal value", "Error", MessageBoxButtons.OK)
                        End If
                    Else
                        value = RadDataConverter.Instance.Parse(dataColumn, rtbValue1.Text)
                    End If
                End If

                Me.advancedFilterDescriptor.Value = value
            End If

            Me.gridView_Renamed.FilterDescriptors.BeginUpdate()
            Me.gridView_Renamed.FilterDescriptors.Clear()
            Dim descriptor As FilterDescriptor = TryCast(Me.advancedFilterDescriptor.Clone(), FilterDescriptor)
            Me.gridView_Renamed.FilterDescriptors.Add(descriptor)
            Me.gridView_Renamed.FilterDescriptors.EndUpdate()
        End Sub

		Private Sub radTextBoxSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.gridView_Renamed.EndEdit()

			Dim tableElement As GridTableElement = Me.gridView_Renamed.TableElement
			Dim masterTemplate As MasterGridViewTemplate = Me.gridView_Renamed.MasterTemplate

			tableElement.BeginUpdate()
			Me.gridView_Renamed.FilterDescriptors.Clear()
			Me.gridView_Renamed.EnableCustomFiltering = True
			masterTemplate.DataView.Refresh()
			tableElement.EndUpdate(False)

			Me.gridView_Renamed.TableElement.ViewElement.UpdateRows(True)
		End Sub

		Private Sub GridView_CustomFiltering(ByVal sender As Object, ByVal e As GridViewCustomFilteringEventArgs)
			Dim searchPattern As String = Me.radTextBoxSearch.Text

			Dim isEmptyPattern As Boolean = String.IsNullOrEmpty(searchPattern)
			e.Visible = isEmptyPattern

			For Each cell As GridViewCellInfo In e.Row.Cells
				Dim value As String = String.Empty
				Dim cellValue As Object = cell.Value

				If cellValue IsNot Nothing AndAlso (Not Convert.IsDBNull(cellValue)) Then
					value = Convert.ToString(cellValue)
				End If

				Dim contains As Boolean = False

				If Not isEmptyPattern Then
					contains = value.Contains(searchPattern)
					e.Visible = e.Visible Or contains
				End If

				gridView_Renamed.MasterTemplate.SynchronizationService.SuspendEvent(KnownEvents.RowInvalidated)
				If contains Then
					cell.Style.CustomizeFill = True
					cell.Style.BackColor = Color.FromArgb(201, 252, 254)
				Else
					cell.Style.Reset()
				End If
				gridView_Renamed.MasterTemplate.SynchronizationService.ResumeEvent(KnownEvents.RowInvalidated)
			Next cell
		End Sub

		#End Region

		Private Sub WireEvents()
			AddHandler radTextBoxSearch.TextChanged, AddressOf radTextBoxSearch_TextChanged
			AddHandler radBtnAdvanceApply.Click, AddressOf radBtnAdvanceApply_Click

		End Sub
	End Class
End Namespace
