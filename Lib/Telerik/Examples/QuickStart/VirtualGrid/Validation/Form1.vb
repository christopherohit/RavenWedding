
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.Validation
	Public Partial Class Form1
		Inherits ExamplesForm
		Private ReadOnly selectCommand As String = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]"
		Private columnNames As String() = New String() {"Order Id", "Product Id", "UnitPrice", "Quantity", "Discount"}
		Private data As New List(Of OrderDetails)()

		Public Sub New()
			InitializeComponent()

			Me.radVirtualGrid1.ColumnCount = columnNames.Length
			Me.radVirtualGrid1.AllowAddNewRow = False
			Me.radVirtualGrid1.AllowDelete = False

			Me.SelectData()
			Me.InitializeDropDowns()

			Me.radSpinEditorFirstCondition.DecimalPlaces = 2
			Me.radSpinEditorFirstCondition.[Step] = 0.1D
			Me.radSpinEditorSecondCondition.DecimalPlaces = 2
			Me.radSpinEditorSecondCondition.[Step] = 0.1D
		End Sub

		Private Sub InitializeDropDowns()
			Me.radDropDownListColumnName.Items.Add(New RadListDataItem("UnitPrice", New ColumnValidationInfo(2, 0, 1, 2, 50)))
			Me.radDropDownListColumnName.Items.Add(New RadListDataItem("Quantity", New ColumnValidationInfo(3, 1, 1, 2, 41)))
			Me.radDropDownListColumnName.Items.Add(New RadListDataItem("Discount", New ColumnValidationInfo(4, 1, 0, 3, CDec(0.3))))

			For i As Integer = 0 To ColumnValidationInfo.validators.Count - 1
				Me.radDropDownListFirstCondition.Items.Add(New RadListDataItem(ColumnValidationInfo.validators(i).Name, ColumnValidationInfo.validators(i)))
				Me.radDropDownListSecondCondition.Items.Add(New RadListDataItem(ColumnValidationInfo.validators(i).Name, ColumnValidationInfo.validators(i)))
			Next
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.radDropDownListColumnName.SelectedIndexChanged, AddressOf radDropDownListColumnName_SelectedIndexChanged
			AddHandler Me.radDropDownListFirstCondition.SelectedIndexChanged, AddressOf radDropDownListFirstCondition_SelectedIndexChanged
			AddHandler Me.radDropDownListSecondCondition.SelectedIndexChanged, AddressOf radDropDownListSecondCondition_SelectedIndexChanged
			AddHandler Me.radSpinEditorFirstCondition.ValueChanged, AddressOf radSpinEditorFirstCondition_ValueChanged
			AddHandler Me.radSpinEditorSecondCondition.ValueChanged, AddressOf radSpinEditorSecondCondition_ValueChanged
			AddHandler Me.radVirtualGrid1.CellValidating, AddressOf radVirtualGrid1_CellValidating
			AddHandler Me.radVirtualGrid1.CellFormatting, AddressOf radVirtualGrid1_CellFormatting
			AddHandler Me.radVirtualGrid1.RowFormatting, AddressOf radVirtualGrid1_RowFormatting
			AddHandler Me.radVirtualGrid1.CellValuePushed, AddressOf radVirtualGrid1_CellValuePushed
			AddHandler Me.radVirtualGrid1.EditorRequired, AddressOf radVirtualGrid1_EditorRequired

			Me.radDropDownListColumnName.SelectedIndex = 0
		End Sub

		Private Sub radVirtualGrid1_EditorRequired(sender As Object, e As VirtualGridEditorRequiredEventArgs)
			e.Editor = New VirtualGridSpinEditor()
		End Sub

		Private Sub radDropDownListColumnName_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim validationInfo As ColumnValidationInfo = DirectCast(Me.radDropDownListColumnName.SelectedValue, ColumnValidationInfo)
			Me.radDropDownListFirstCondition.SelectedIndex = validationInfo.Validator1
			Me.radDropDownListSecondCondition.SelectedIndex = validationInfo.Validator2
			Me.radSpinEditorFirstCondition.Value = validationInfo.Value1
			Me.radSpinEditorSecondCondition.Value = validationInfo.Value2
		End Sub

		Private Sub radDropDownListFirstCondition_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim validationInfo As ColumnValidationInfo = DirectCast(Me.radDropDownListColumnName.SelectedValue, ColumnValidationInfo)
			validationInfo.Validator1 = radDropDownListFirstCondition.SelectedIndex
			radDropDownListSecondCondition.Visible = radDropDownListFirstCondition.SelectedIndex <> 4
			radSpinEditorSecondCondition.Visible = radDropDownListFirstCondition.SelectedIndex <> 4
			radLabel1.Visible = radDropDownListFirstCondition.SelectedIndex <> 4
			Me.radVirtualGrid1.TableElement.SynchronizeRows()
		End Sub

		Private Sub radDropDownListSecondCondition_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim validationInfo As ColumnValidationInfo = DirectCast(Me.radDropDownListColumnName.SelectedValue, ColumnValidationInfo)
			validationInfo.Validator2 = radDropDownListSecondCondition.SelectedIndex
			Me.radVirtualGrid1.TableElement.SynchronizeRows()
		End Sub

		Private Sub radSpinEditorFirstCondition_ValueChanged(sender As Object, e As EventArgs)
			Dim validationInfo As ColumnValidationInfo = DirectCast(Me.radDropDownListColumnName.SelectedValue, ColumnValidationInfo)
			validationInfo.Value1 = radSpinEditorFirstCondition.Value
			Me.radVirtualGrid1.TableElement.SynchronizeRows()
		End Sub

		Private Sub radSpinEditorSecondCondition_ValueChanged(sender As Object, e As EventArgs)
			Dim validationInfo As ColumnValidationInfo = DirectCast(Me.radDropDownListColumnName.SelectedValue, ColumnValidationInfo)
			validationInfo.Value2 = radSpinEditorSecondCondition.Value
			Me.radVirtualGrid1.TableElement.SynchronizeRows()
		End Sub

        Private Sub radVirtualGrid1_CellValidating(sender As Object, e As VirtualGridCellValidatingEventArgs)
            If Me.radVirtualGrid1.IsInEditMode Then
                Dim validationInfo As ColumnValidationInfo = GetColumnValidationInfo(e.ColumnIndex)

                If validationInfo IsNot Nothing AndAlso Not validationInfo.Validate(Convert.ToDecimal(Me.radVirtualGrid1.ActiveEditor.Value)) Then
                    e.Cancel = True
                    e.ViewInfo.SetRowErrorText(e.RowIndex, "Validation Error!")
                End If
            End If
        End Sub

		Private Sub radVirtualGrid1_CellFormatting(sender As Object, e As VirtualGridCellElementEventArgs)
			If e.CellElement.RowIndex < 0 Then
				Return
			End If

			Dim validationInfo As ColumnValidationInfo = GetColumnValidationInfo(e.CellElement.ColumnIndex)

			If validationInfo Is Nothing Then
				Return
			End If

			Dim value As Object = e.CellElement.Value

			If Convert.IsDBNull(value) Then
				value = Nothing
			End If

			If Not validationInfo.Validate(Convert.ToDecimal(value)) Then
				e.CellElement.DrawFill = True
				e.CellElement.GradientStyle = GradientStyles.Linear
				e.CellElement.GradientPercentage = 0.45F
				e.CellElement.GradientPercentage2 = 0.53F
				e.CellElement.NumberOfColors = 4
				e.CellElement.BackColor = Color.FromArgb(253, 141, 142)
				e.CellElement.BackColor2 = Color.FromArgb(254, 86, 86)
				e.CellElement.BackColor3 = Color.FromArgb(254, 55, 55)
				e.CellElement.BackColor4 = Color.FromArgb(254, 31, 32)
				e.CellElement.ZIndex = 100
			ElseIf e.CellElement.BackColor = Color.FromArgb(253, 141, 142) Then
				e.CellElement.ResetValue(RadItem.BackColorProperty)
				e.CellElement.ResetValue(LightVisualElement.DrawFillProperty)
				e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty)
				e.CellElement.ResetValue(LightVisualElement.GradientPercentageProperty)
				e.CellElement.ResetValue(LightVisualElement.GradientPercentage2Property)
				e.CellElement.ResetValue(LightVisualElement.NumberOfColorsProperty)
				e.CellElement.ResetValue(LightVisualElement.BackColor2Property)
				e.CellElement.ResetValue(LightVisualElement.BackColor3Property)
				e.CellElement.ResetValue(LightVisualElement.BackColor4Property)
				e.CellElement.ResetValue(RadElement.ZIndexProperty)
			End If
		End Sub

		Private Sub radVirtualGrid1_RowFormatting(sender As Object, e As VirtualGridRowElementEventArgs)
			If e.RowElement.RowIndex >= 0 Then
				SetRowErrorText(e.RowElement.RowIndex)
			End If
		End Sub

        Private Sub radVirtualGrid1_CellValueNeeded(sender As Object, e As Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs) Handles radVirtualGrid1.CellValueNeeded
            If e.ColumnIndex < 0 Then
                Return
            End If

            If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
                e.Value = columnNames(e.ColumnIndex)
            End If

            If e.RowIndex < 0 Then
                e.FieldName = columnNames(e.ColumnIndex).Replace(" ", "")
            End If

            If e.RowIndex >= 0 AndAlso e.RowIndex < data.Count Then
                e.Value = data(e.RowIndex)(e.ColumnIndex)
            End If
        End Sub

        Private Sub radVirtualGrid1_SortChanged(sender As Object, e As VirtualGridEventArgs) Handles radVirtualGrid1.SortChanged
            SelectData()
        End Sub

        Private Sub radVirtualGrid1_FilterChanged(sender As Object, e As VirtualGridEventArgs) Handles radVirtualGrid1.FilterChanged
            SelectData()
        End Sub

		Private Sub radVirtualGrid1_CellValuePushed(sender As Object, e As VirtualGridCellValuePushedEventArgs)
			If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
				Me.data(e.RowIndex)(e.ColumnIndex) = Convert.ToString(e.Value)
			End If

			SetRowErrorText(e.RowIndex)
		End Sub

		Private Function GetColumnValidationInfo(columnIndex As Integer) As ColumnValidationInfo
			For Each item As RadListDataItem In Me.radDropDownListColumnName.Items
				Dim validationInfo As ColumnValidationInfo = DirectCast(item.Value, ColumnValidationInfo)

				If validationInfo.ColumnIndex = columnIndex Then
					Return validationInfo
				End If
			Next

			Return Nothing
		End Function

		Private Sub SetRowErrorText(rowIndex As Integer)
			Dim validationFailed As Boolean = False
			Dim validationMessage As New StringBuilder()

			For Each item As RadListDataItem In Me.radDropDownListColumnName.Items
				Dim validationInfo As ColumnValidationInfo = DirectCast(item.Value, ColumnValidationInfo)
				Dim value As Object = Me.data(rowIndex)(validationInfo.ColumnIndex)

				If Convert.IsDBNull(value) Then
					value = Nothing
				End If

				If Not validationInfo.Validate(Convert.ToDecimal(value)) Then
					validationFailed = True
					validationMessage.Append((Convert.ToString(Me.columnNames(validationInfo.ColumnIndex) + " ") & validationInfo.GetMessage(Convert.ToDecimal(value))) + vbLf)
				End If

				If Me.radVirtualGrid1.IsInEditMode AndAlso Me.radVirtualGrid1.CurrentCell.RowIndex = rowIndex AndAlso Me.radVirtualGrid1.CurrentCell.ColumnIndex = validationInfo.ColumnIndex Then
					Dim editorValue As Object = Me.radVirtualGrid1.ActiveEditor.Value

					If Convert.IsDBNull(editorValue) Then
						editorValue = value
					End If

					If Not validationInfo.Validate(Convert.ToDecimal(editorValue)) Then
						validationFailed = True
						validationMessage.Append((Convert.ToString(Me.columnNames(validationInfo.ColumnIndex) + " ") & validationInfo.GetMessage(Convert.ToDecimal(editorValue))) + vbLf)
					End If
				End If
			Next

			Me.radVirtualGrid1.MasterViewInfo.SetRowErrorText(rowIndex, If(validationFailed, validationMessage.ToString(), String.Empty))
		End Sub

		#Region "OleDb CRUD"

		Private Sub SelectData()
			Dim sortExpression As String = Me.radVirtualGrid1.SortDescriptors.Expression
			Dim filterExpression As String = Me.radVirtualGrid1.FilterDescriptors.Expression

			If Not String.IsNullOrEmpty(sortExpression) Then
				sortExpression = Convert.ToString("ORDER BY ") & sortExpression
			End If

			If Not String.IsNullOrEmpty(filterExpression) Then
				filterExpression = Convert.ToString("WHERE ") & filterExpression
			End If

			Dim commandString As String = [String].Format("{0} {1} {2}", selectCommand, filterExpression, sortExpression)

			Using command As New OleDbCommand(commandString)
                command.Connection = New OleDbConnection(My.Settings.NwindConnectionString)
				command.Connection.Open()
				Dim reader As IDataReader = command.ExecuteReader()
				data.Clear()

				While reader.Read()
					Dim customer As New OrderDetails(Convert.ToString(reader(0)), Convert.ToString(reader(1)), Convert.ToString(reader(2)), Convert.ToString(reader(3)), Convert.ToString(reader(4)))
					data.Add(customer)
				End While

				command.Connection.Close()
			End Using

			Me.radVirtualGrid1.RowCount = data.Count
		End Sub

		#End Region

    End Class

	#Region "Validators"

	Public Class ColumnValidationInfo
		Public Shared validators As New List(Of ICellValidator)()

		Public ColumnIndex As Integer
		Public Validator1 As Integer
		Public Validator2 As Integer
		Public Value1 As Decimal
		Public Value2 As Decimal

		Shared Sub New()
			validators.Add(New GreaterThanValidator())
			validators.Add(New GreaterThanOrEqualValidator())
			validators.Add(New LessThanValidator())
			validators.Add(New LessThanOrEqualValidator())
			validators.Add(New DoesNotEqualValidator())
		End Sub

		Public Sub New(columnIndex As Integer, validator1 As Integer, value1 As Decimal, validator2 As Integer, value2 As Decimal)
			Me.ColumnIndex = columnIndex
			Me.Validator1 = validator1
			Me.Value1 = value1
			Me.Validator2 = validator2
			Me.Value2 = value2
		End Sub

		Public Function Validate(value As Decimal) As Boolean
			If Validator1 = 4 Then
				Return validators(Validator1).Validate(value, Value1)
			End If

			Return validators(Validator1).Validate(value, Value1) AndAlso validators(Validator2).Validate(value, Value2)
		End Function

		Public Function GetMessage(value As Decimal) As String
			If Validator1 = 4 Then
                Return validators(Validator1).ErrorMesssage & " " & Value1.ToString()
			End If

			Dim s1 As String = String.Empty

			If Not validators(Validator1).Validate(value, Value1) Then
                s1 = validators(Validator1).ErrorMesssage & " " & Value1.ToString()
			End If

			Dim s2 As String = String.Empty
			If Not validators(Validator2).Validate(value, Value2) Then
                s2 = validators(Validator2).ErrorMesssage & " " & Value2.ToString()
			End If

			If String.IsNullOrEmpty(s1) Then
				Return s2
			End If

			If String.IsNullOrEmpty(s2) Then
				Return s1
			End If

			Return Convert.ToString(s1 & Convert.ToString(" and ")) & s2
		End Function
	End Class

	Public Interface ICellValidator
		ReadOnly Property Name() As String
		ReadOnly Property ErrorMesssage() As String
		Function Validate(value1 As Decimal, value2 As Decimal) As Boolean
	End Interface

	Public Class GreaterThanValidator
		Implements ICellValidator
        Public ReadOnly Property Name As String Implements ICellValidator.Name
            Get
                Return "is greater than"
            End Get
        End Property

		Public ReadOnly Property ErrorMesssage() As String Implements ICellValidator.ErrorMesssage
			Get
				Return "should be greater than"
			End Get
		End Property

        Public Function Validate(value1 As Decimal, value2 As Decimal) As Boolean Implements ICellValidator.Validate
            Return value1 > value2
        End Function
	End Class

	Public Class GreaterThanOrEqualValidator
		Implements ICellValidator
        Public ReadOnly Property Name As String Implements ICellValidator.Name
            Get
                Return "is greater than or equal"
            End Get
        End Property

		Public ReadOnly Property ErrorMesssage() As String Implements ICellValidator.ErrorMesssage
			Get
				Return "should be greater than or equal"
			End Get
		End Property

        Public Function Validate(value1 As Decimal, value2 As Decimal) As Boolean Implements ICellValidator.Validate
            Return value1 >= value2
        End Function
	End Class

	Public Class LessThanValidator
		Implements ICellValidator
        Public ReadOnly Property Name As String Implements ICellValidator.Name
            Get
                Return "is less than"
            End Get
        End Property

		Public ReadOnly Property ErrorMesssage() As String Implements ICellValidator.ErrorMesssage
			Get
				Return "should be less than"
			End Get
		End Property

        Public Function Validate(value1 As Decimal, value2 As Decimal) As Boolean Implements ICellValidator.Validate
            Return value1 < value2
        End Function
	End Class

	Public Class LessThanOrEqualValidator
		Implements ICellValidator
        Public ReadOnly Property Name As String Implements ICellValidator.Name
            Get
                Return "is less than or equal"
            End Get
        End Property

		Public ReadOnly Property ErrorMesssage() As String Implements ICellValidator.ErrorMesssage
			Get
				Return "should be less than or equal"
			End Get
		End Property

        Public Function Validate(value1 As Decimal, value2 As Decimal) As Boolean Implements ICellValidator.Validate
            Return value1 <= value2
        End Function
	End Class

	Public Class DoesNotEqualValidator
		Implements ICellValidator
        Public ReadOnly Property Name As String Implements ICellValidator.Name
            Get
                Return "does not equal"
            End Get
        End Property

		Public ReadOnly Property ErrorMesssage() As String Implements ICellValidator.ErrorMesssage
			Get
				Return "should be not equal"
			End Get
		End Property

        Public Function Validate(value1 As Decimal, value2 As Decimal) As Boolean Implements ICellValidator.Validate
            Return value1 <> value2
        End Function
    End Class
#End Region
End Namespace