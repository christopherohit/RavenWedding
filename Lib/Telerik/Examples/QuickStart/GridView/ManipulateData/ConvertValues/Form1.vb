Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.CodeDom.Compiler
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.ConvertValues
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private changedColumn As GridViewDataColumn = Nothing
		Private screenTip As New RadOffice2007ScreenTipElement()

		#End Region

		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

			AddHandler radComboTimeZone.SelectedIndexChanged, AddressOf radComboTimeZone_SelectedIndexChanged
			AddHandler gridView.CellFormatting, AddressOf gridView_CellFormatting
			AddHandler radTextBox1.ScreenTipNeeded, AddressOf radTextBox1_ScreenTipNeeded
			AddHandler radComboTimeZone.ScreenTipNeeded, AddressOf radComboTimeZone_ScreenTipNeeded
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub gridView_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			Dim cellElement As GridCellElement = e.CellElement
			Dim columnInfo As GridViewDataColumn = TryCast(e.CellElement.ColumnInfo, GridViewDataColumn)

			If TypeOf cellElement Is GridCheckBoxCellElement Then
			End If

			If columnInfo IsNot Nothing AndAlso (Not cellElement.RowInfo.IsCurrent) AndAlso (Not cellElement.RowInfo.IsSelected) AndAlso cellElement.RowElement.RowVisualState <> GridRowElement.RowVisualStates.Hovered AndAlso (columnInfo.Name = "Category" AndAlso Object.Equals(cellElement.Text, columnInfo.NullValue) OrElse columnInfo Is changedColumn) Then

				e.CellElement.BackColor = If(columnInfo.Name = "Category", Color.Pink, Color.PaleGoldenrod)
				e.CellElement.GradientStyle = GradientStyles.Solid
				e.CellElement.DrawFill = True
			Else
				e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
			End If
		End Sub

		Private Sub radTextBox1_ScreenTipNeeded(ByVal sender As Object, ByVal e As ScreenTipNeededEventArgs)
			Me.screenTip.CaptionLabel.Text = "Unit Price Expression"
			Me.screenTip.MainTextLabel.Text = "UnitPriceConverter evaluates the equation for each Unit Price data cell and replace its display value with the result."
			e.Item.ScreenTip = screenTip
		End Sub


		Private Sub radComboTimeZone_ScreenTipNeeded(ByVal sender As Object, ByVal e As ScreenTipNeededEventArgs)
			Me.screenTip.CaptionLabel.Text = "DateTime Zone"
			Me.screenTip.MainTextLabel.Text = "DateTimeConverter converts OLE Automation date to DateTime date for concrete time zone."
			e.Item.ScreenTip = screenTip
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.screenTip.MainTextLabel.Padding = New Padding(2)
			Me.screenTip.CaptionLabel.Padding = New Padding(2)
			Me.screenTip.EnableCustomSize = True

			Me.gridView.ShowGroupPanel = False
			Me.gridView.MasterTemplate.AllowAddNewRow = False
			Me.gridView.DataSource = Product.Generate()

			Me.gridView.Columns("ProductID").IsVisible = False
			Me.gridView.Columns("ProductName").Width = 180
			Me.gridView.Columns("Category").NullValue = "Type product's category"
			Me.gridView.Columns("Category").DataSourceNullValue = "Beverages"
			Me.gridView.Columns("Category").Width = 130
			Me.gridView.Columns("UnitPrice").FormatString = "{0:c}"
			Me.gridView.Columns("UnitPrice").Width = 100
			Me.gridView.Columns("IsOrganic").Width = 80
			CType(Me.gridView.Columns("IsOrganic"), GridViewCheckBoxColumn).ThreeState = True
			Me.gridView.Columns("UnitsInStock").FormatString = "Quantity: {0}"
			Me.gridView.Columns("UnitsInStock").Width = 100
			Me.gridView.Columns("DeliveryDate").FormatString = "{0}"
			Me.gridView.Columns("DeliveryDate").Width = 150

			Me.radComboTimeZone.DataSource = Telerik.WinControls.UI.TimeZoneInfo.GetSystemTimeZones()
			Me.radComboTimeZone.DisplayMember = "DisplayName"
			Me.radComboTimeZone.ValueMember = "Id"
			Me.radComboTimeZone.SelectedValue = Telerik.WinControls.UI.TimeZoneInfo.Utc.Id
			Me.radComboTimeZone.DropDownMinSize = New Size(100, 400)

			Me.radTextBox1.Text = "price + price * 0.20 + Math.Pow(price, 2)"
			Me.SetUnitPriceExpression(Me.radTextBox1.Text)
			Me.changedColumn = Nothing
		End Sub

		Private Sub radComboTimeZone_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim deliveryDateColumn As GridViewDataColumn = Me.gridView.Columns("DeliveryDate")
			Dim timeConverter As DateTimeConverter = TryCast(deliveryDateColumn.DataTypeConverter, DateTimeConverter)
			timeConverter.TimeZoneInfo = TryCast(Me.radComboTimeZone.SelectedItem.DataBoundItem, Telerik.WinControls.UI.TimeZoneInfo)
			changedColumn = deliveryDateColumn
			Me.gridView.TableElement.UpdateView()
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.SetUnitPriceExpression(Me.radTextBox1.Text)
			Me.gridView.TableElement.UpdateView()
		End Sub

		Private Sub SetUnitPriceExpression(ByVal expression As String)
			Dim unitPriceColumn As GridViewDataColumn = Me.gridView.Columns("UnitPrice")
			Dim unitPriceConverter As UnitPriceConverter = TryCast(unitPriceColumn.DataTypeConverter, UnitPriceConverter)
			Dim compilerErrors As CompilerErrorCollection = unitPriceConverter.SetExpression(expression)

			If Not compilerErrors.HasErrors Then
				changedColumn = unitPriceColumn
				Return
			End If

			Dim errorMessage As New StringBuilder()

			For Each [error] As CompilerError In compilerErrors
				errorMessage.AppendLine([error].ErrorText)
			Next [error]

			If errorMessage.Length > 0 Then
				RadMessageBox.Show(errorMessage.ToString(), "Expression Syntax Error", MessageBoxButtons.OK, RadMessageIcon.Error)
			End If
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler btnEvaluate.Click, AddressOf radButton1_Click
		End Sub
	End Class
End Namespace
