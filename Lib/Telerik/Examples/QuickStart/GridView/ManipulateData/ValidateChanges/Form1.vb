Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.ValidateChanges
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
		End Sub

		#Region "Event handlers"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radGridView1.TableElement.BeginUpdate()

			Me.order_DetailsTableAdapter.Fill(Me.northwindDataSet.Order_Details)
			Me.radGridView1.TableElement.RowHeaderColumnWidth = 40
			For Each column As GridViewDataColumn In Me.radGridView1.Columns
				column.Width = 100
			Next column
			Me.radGridView1.TableElement.EndUpdate()

			Me.radGridView1.EnableGrouping = False
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False

			Me.InitComboBoxes()

			Me.radSpinEditor1.DecimalPlaces = 2
			Me.radSpinEditor1.Step = 0.1D
			Me.radSpinEditor2.DecimalPlaces = 2
			Me.radSpinEditor2.Step = 0.1D
		End Sub

		Private Sub radComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim validationInfo As ColumnValidationInfo = CType(radComboBox1.SelectedValue, ColumnValidationInfo)
			Me.radComboBox2.SelectedIndex = validationInfo.Validator1
			Me.radComboBox3.SelectedIndex = validationInfo.Validator2
			Me.radSpinEditor1.Value = validationInfo.Value1
			Me.radSpinEditor2.Value = validationInfo.Value2
		End Sub

		Private Sub radComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim validationInfo As ColumnValidationInfo = CType(radComboBox1.SelectedValue, ColumnValidationInfo)
			validationInfo.Validator1 = radComboBox2.SelectedIndex
			radComboBox3.Visible = radComboBox2.SelectedIndex <> 4
			radSpinEditor2.Visible = radComboBox2.SelectedIndex <> 4
			radLabel1.Visible = radComboBox2.SelectedIndex <> 4
			radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
		End Sub

		Private Sub radComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim validationInfo As ColumnValidationInfo = CType(radComboBox1.SelectedValue, ColumnValidationInfo)
			validationInfo.Validator2 = radComboBox3.SelectedIndex
			radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim validationInfo As ColumnValidationInfo = CType(radComboBox1.SelectedValue, ColumnValidationInfo)
			validationInfo.Value1 = radSpinEditor1.Value
			radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
		End Sub

		Private Sub radSpinEditor2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim validationInfo As ColumnValidationInfo = CType(radComboBox1.SelectedValue, ColumnValidationInfo)
			validationInfo.Value2 = radSpinEditor2.Value
			radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
		End Sub

		Private Sub radGridView1_CellValidating(ByVal sender As Object, ByVal e As CellValidatingEventArgs)
			If radGridView1.IsInEditMode Then
				Dim validationInfo As ColumnValidationInfo = GetColumnValidationInfo(e.Column)
				If validationInfo IsNot Nothing AndAlso (Not validationInfo.Validate(Convert.ToDecimal(e.Value))) Then
					e.Cancel = True
					e.Row.ErrorText = "Validation Error!"
				End If
			End If
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			If TypeOf e.CellElement.RowElement Is GridDataRowElement Then
				Dim validationInfo As ColumnValidationInfo = GetColumnValidationInfo(e.CellElement.ColumnInfo)
				If validationInfo IsNot Nothing Then
					Dim value As Object = (CType(e.CellElement, GridDataCellElement)).Value

					If Convert.IsDBNull(value) Then
						value = Nothing
					End If

					If Not validationInfo.Validate(Convert.ToDecimal(value)) Then
						e.CellElement.DrawFill = True
						e.CellElement.GradientStyle = GradientStyles.Linear
						e.CellElement.GradientPercentage = 0.45f
						e.CellElement.GradientPercentage2 = 0.53f
						e.CellElement.NumberOfColors = 4
						e.CellElement.BackColor = Color.FromArgb(253, 141, 142)
						e.CellElement.BackColor2 = Color.FromArgb(254, 86, 86)
						e.CellElement.BackColor3 = Color.FromArgb(254, 55, 55)
						e.CellElement.BackColor4 = Color.FromArgb(254, 31, 32)
						e.CellElement.BorderGradientStyle = GradientStyles.Solid
						e.CellElement.BorderColor = Color.FromArgb(254, 31, 32)
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
						e.CellElement.ResetValue(LightVisualElement.BorderGradientStyleProperty)
						e.CellElement.ResetValue(LightVisualElement.BorderColorProperty)
						e.CellElement.ResetValue(RadElement.ZIndexProperty)
					End If
				End If
			End If
		End Sub

		Private Sub radGridView1_RowFormatting(ByVal sender As Object, ByVal e As RowFormattingEventArgs)
			SetRowErrorText(e.RowElement.RowInfo)
		End Sub

		Private Sub radGridView1_CellEndEdit(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
			SetRowErrorText(e.Row)
		End Sub

		#End Region

		#Region "Validators"

		Public Class ColumnValidationInfo
			Public Shared validators As New List(Of ICellValidator)()

			Public Column As GridViewColumn
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

			Public Sub New(ByVal column As GridViewColumn, ByVal validator1 As Integer, ByVal value1 As Decimal, ByVal validator2 As Integer, ByVal value2 As Decimal)
				Me.Column = column
				Me.Validator1 = validator1
				Me.Value1 = value1
				Me.Validator2 = validator2
				Me.Value2 = value2
			End Sub

			Public Function Validate(ByVal value As Decimal) As Boolean
				If Validator1 = 4 Then
					Return validators(Validator1).Validate(value, Value1)
				End If
				Return validators(Validator1).Validate(value, Value1) AndAlso validators(Validator2).Validate(value, Value2)
			End Function

			Public Function GetMessage(ByVal value As Decimal) As String
				If Validator1 = 4 Then
					Return validators(Validator1).ErrorMesssage & " " & Value1
				End If

				Dim s1 As String = String.Empty
				If Not validators(Validator1).Validate(value, Value1) Then
					s1 = validators(Validator1).ErrorMesssage & " " & Value1
				End If

				Dim s2 As String = String.Empty
				If Not validators(Validator2).Validate(value, Value2) Then
					s2 = validators(Validator2).ErrorMesssage & " " & Value2
				End If

				If String.IsNullOrEmpty(s1) Then
					Return s2
				End If
				If String.IsNullOrEmpty(s2) Then
					Return s1
				End If
				Return s1 & " and " & s2
			End Function
		End Class

		Public Interface ICellValidator
			ReadOnly Property Name() As String
			ReadOnly Property ErrorMesssage() As String
			Function Validate(ByVal value1 As Decimal, ByVal value2 As Decimal) As Boolean
		End Interface

		Public Class GreaterThanValidator
			Implements ICellValidator
			Public ReadOnly Property Name() As String Implements ICellValidator.Name
				Get
					Return "is greater than"
				End Get
			End Property
			Public ReadOnly Property ErrorMesssage() As String Implements ICellValidator.ErrorMesssage
				Get
					Return "should be greater than"
				End Get
			End Property
			Public Function Validate(ByVal value1 As Decimal, ByVal value2 As Decimal) As Boolean Implements ICellValidator.Validate
				Return value1 > value2
			End Function
		End Class

		Public Class GreaterThanOrEqualValidator
			Implements ICellValidator
			Public ReadOnly Property Name() As String Implements ICellValidator.Name
				Get
					Return "is greater than or equal"
				End Get
			End Property
			Public ReadOnly Property ErrorMesssage() As String Implements ICellValidator.ErrorMesssage
				Get
					Return "should be greater than or equal"
				End Get
			End Property
			Public Function Validate(ByVal value1 As Decimal, ByVal value2 As Decimal) As Boolean Implements ICellValidator.Validate
				Return value1 >= value2
			End Function
		End Class

		Public Class LessThanValidator
			Implements ICellValidator
			Public ReadOnly Property Name() As String Implements ICellValidator.Name
				Get
					Return "is less than"
				End Get
			End Property
			Public ReadOnly Property ErrorMesssage() As String Implements ICellValidator.ErrorMesssage
				Get
					Return "should be less than"
				End Get
			End Property
			Public Function Validate(ByVal value1 As Decimal, ByVal value2 As Decimal) As Boolean Implements ICellValidator.Validate
				Return value1 < value2
			End Function
		End Class

		Public Class LessThanOrEqualValidator
			Implements ICellValidator
			Public ReadOnly Property Name() As String Implements ICellValidator.Name
				Get
					Return "is less than or equal"
				End Get
			End Property
			Public ReadOnly Property ErrorMesssage() As String Implements ICellValidator.ErrorMesssage
				Get
					Return "should be less than or equal"
				End Get
			End Property
			Public Function Validate(ByVal value1 As Decimal, ByVal value2 As Decimal) As Boolean Implements ICellValidator.Validate
				Return value1 <= value2
			End Function
		End Class

		Public Class DoesNotEqualValidator
			Implements ICellValidator
			Public ReadOnly Property Name() As String Implements ICellValidator.Name
				Get
					Return "does not equal"
				End Get
			End Property
			Public ReadOnly Property ErrorMesssage() As String Implements ICellValidator.ErrorMesssage
				Get
					Return "should be not equal"
				End Get
			End Property
			Public Function Validate(ByVal value1 As Decimal, ByVal value2 As Decimal) As Boolean Implements ICellValidator.Validate
				Return value1 <> value2
			End Function
		End Class

		#End Region

		Private Sub InitComboBoxes()
			Me.radComboBox1.Items.Add(New RadListDataItem("UnitPrice", New ColumnValidationInfo(Me.radGridView1.Columns("UnitPrice"), 0, 1, 2, 50)))
			Me.radComboBox1.Items.Add(New RadListDataItem("Quantity", New ColumnValidationInfo(Me.radGridView1.Columns("Quantity"), 1, 1, 2, 41)))
			Me.radComboBox1.Items.Add(New RadListDataItem("Discount", New ColumnValidationInfo(Me.radGridView1.Columns("Discount"), 1, 0, 3, CDec(0.3))))

			For i As Integer = 0 To ColumnValidationInfo.validators.Count - 1
				Me.radComboBox2.Items.Add(New RadListDataItem(ColumnValidationInfo.validators(i).Name, ColumnValidationInfo.validators(i)))
				Me.radComboBox3.Items.Add(New RadListDataItem(ColumnValidationInfo.validators(i).Name, ColumnValidationInfo.validators(i)))
			Next i

			Me.radComboBox1.SelectedIndex = 0
		End Sub

		Private Sub SetRowErrorText(ByVal row As GridViewRowInfo)
			If row IsNot Nothing Then
				Dim validationFailed As Boolean = False
				Dim validationMessage As New StringBuilder()
				For Each item As RadListDataItem In radComboBox1.Items
					Dim validationInfo As ColumnValidationInfo = CType(item.Value, ColumnValidationInfo)
					Dim value As Object = row.Cells(validationInfo.Column.HeaderText).Value

					If Convert.IsDBNull(value) Then
						value = Nothing
					End If

					If Not validationInfo.Validate(Convert.ToDecimal(value)) Then
						validationFailed = True
						validationMessage.Append(validationInfo.Column.HeaderText & " " & validationInfo.GetMessage(Convert.ToDecimal(value)) & vbLf)
					End If
					If radGridView1.IsInEditMode AndAlso radGridView1.CurrentRow Is row AndAlso radGridView1.CurrentColumn Is validationInfo.Column Then
						Dim editorValue As Object = radGridView1.ActiveEditor.Value

						If Convert.IsDBNull(editorValue) Then
							editorValue = value
						End If

						If Not validationInfo.Validate(Convert.ToDecimal(editorValue)) Then
							validationFailed = True
							validationMessage.Append(validationInfo.Column.HeaderText & " " & validationInfo.GetMessage(Convert.ToDecimal(editorValue)) & vbLf)
						End If
					End If
				Next item

				row.ErrorText = If(validationFailed, validationMessage.ToString(), String.Empty)
			End If
		End Sub

		Private Function GetColumnValidationInfo(ByVal column As GridViewColumn) As ColumnValidationInfo
			For Each item As RadListDataItem In radComboBox1.Items
				Dim validationInfo As ColumnValidationInfo = CType(item.Value, ColumnValidationInfo)
				If validationInfo.Column Is column Then
					Return validationInfo
				End If
			Next item
			Return Nothing
		End Function

		Protected Overrides Sub WireEvents()
			AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
			AddHandler radGridView1.CellEndEdit, AddressOf radGridView1_CellEndEdit
			AddHandler radGridView1.RowFormatting, AddressOf radGridView1_RowFormatting
			AddHandler radGridView1.CellValidating, AddressOf radGridView1_CellValidating
			AddHandler radSpinEditor2.ValueChanged, AddressOf radSpinEditor2_ValueChanged
			AddHandler radSpinEditor1.ValueChanged, AddressOf radSpinEditor1_ValueChanged
			AddHandler radComboBox3.SelectedIndexChanged, AddressOf radComboBox3_SelectedIndexChanged
			AddHandler radComboBox2.SelectedIndexChanged, AddressOf radComboBox2_SelectedIndexChanged
			AddHandler radComboBox1.SelectedIndexChanged, AddressOf radComboBox1_SelectedIndexChanged
		End Sub
	End Class
End Namespace
