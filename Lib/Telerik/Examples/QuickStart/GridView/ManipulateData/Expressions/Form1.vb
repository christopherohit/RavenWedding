Imports System.Collections
Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Enumerations
Imports Telerik.Data.Expressions
Imports System.IO
Imports System.Reflection
Imports System.Globalization
Imports System.Threading
Imports My

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.Expressions
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"
		Private Const InitialRowsNum As Integer = 5
		Private bitmaps As New List(Of Bitmap)()

		Private columnNum As Integer
		Private columnTypes() As String = { "NumericText", "Decimal", "DateTime", "CheckBox", "CustomExpression" }
		#End Region

		Public Sub New()
            InitializeComponent()
            Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			ExpressionContext.Context = New CustomExpressionContext()
			LoadExpressionFunctionListFromExternalXML()
		End Sub

		Private Sub LoadExpressionFunctionListFromExternalXML()
			Dim path As String = "Telerik.Examples.WinControls.GridView.Expressions.ExpressionItemsListData.xml"
			Dim stream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(path)
			RadExpressionEditorForm.ExpressionItemsList.LoadFromXML(stream)
		End Sub

		Private Sub CreateBitmaps()
            Dim bmp As New Bitmap(Resources.msoffice_menu_blog)
			bmp.MakeTransparent(Color.Magenta)
			bitmaps.Add(bmp)

            bmp = New Bitmap(Resources.msoffice_menu_digitalsignature)
			bmp.MakeTransparent(Color.Magenta)
			bitmaps.Add(bmp)

            bmp = New Bitmap(Resources.msoffice_menu_documentworkspace)
			bmp.MakeTransparent(Color.Magenta)
			bitmaps.Add(bmp)

            bmp = New Bitmap(Resources.msoffice_menu_encryptdocument)
			bmp.MakeTransparent(Color.Magenta)
			bitmaps.Add(bmp)
		End Sub

		Private Sub SetPreferences()
			Me.radGridView1.MasterTemplate.EnableSorting = True
			Me.SelectedControl = Me.radGridView1
		End Sub

		Private Sub InitializeGrid()
			For i As Integer = 0 To Me.columnTypes.Length - 1
				AppendNewColumn(Me.columnTypes(i), False)
			Next i

			Dim radiusColumn As New GridViewDecimalColumn()
			radiusColumn.Name = "Radius"
			radiusColumn.HeaderText = "Radius"
			Me.radGridView1.Columns.Insert(4, radiusColumn)


			Me.radGridView1.Columns("DateTime").FormatString = "{0:d}"
			Me.radGridView1.Columns("DateTime").TextAlignment = ContentAlignment.MiddleRight
			CreateBitmaps()
			Dim rowInfo As GridViewRowInfo = Me.radGridView1.Rows.AddNew()
			rowInfo.Cells(0).Value = "7432"
			rowInfo.Cells(1).Value = 23
			rowInfo.Cells(2).Value = Date.Now
			rowInfo.Cells(3).Value = True
			rowInfo.Cells(4).Value = 12.37

			rowInfo = Me.radGridView1.Rows.AddNew()
			rowInfo.Cells(0).Value = "890"
			rowInfo.Cells(1).Value = 574
			rowInfo.Cells(2).Value = Date.Now.AddMonths(-10)
			rowInfo.Cells(3).Value = True
			rowInfo.Cells(4).Value = 5.63

			rowInfo = Me.radGridView1.Rows.AddNew()
			rowInfo.Cells(0).Value = "5435"
			rowInfo.Cells(1).Value = 23444
			rowInfo.Cells(2).Value = Date.Now.AddDays(45)
			rowInfo.Cells(3).Value = True
			rowInfo.Cells(4).Value = 37.12

			rowInfo = Me.radGridView1.Rows.AddNew()
			rowInfo.Cells(0).Value = "132323"
			rowInfo.Cells(1).Value = 3455
			rowInfo.Cells(2).Value = Date.Now.AddMonths(34)
			rowInfo.Cells(3).Value = True
			rowInfo.Cells(4).Value = 23.54

			Me.radGridView1.RowCount = 4
			Me.radGridView1.CurrentRow = Me.radGridView1.Rows(0)

			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.EnableGrouping = False
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False

			Me.radGridView1.Columns("CustomExpression").Expression = "ROUND(PI() * POWER(Radius, 2) + Decimal)"
		End Sub

		Private Function AppendNewColumn(ByVal columnType As String, ByVal numberInTheHeader As Boolean) As GridViewDataColumn
			Dim newColumn As GridViewDataColumn = Nothing
			Select Case columnType
				Case "NumericText"
					newColumn = New GridViewMaskBoxColumn()
					CType(newColumn, GridViewMaskBoxColumn).Mask = "f"
					newColumn.Name = "NumericText"
					newColumn.EnableExpressionEditor = True
				Case "Decimal"
					newColumn = New GridViewDecimalColumn()
					newColumn.Name = "Decimal"
					newColumn.DataType = GetType(Decimal)
				Case "DateTime"
					newColumn = New GridViewDateTimeColumn()
					newColumn.Name = "DateTime"
					newColumn.DataType = GetType(Date)
				Case "CheckBox"
					newColumn = New GridViewCheckBoxColumn()
					newColumn.Name = "CheckBox"
					newColumn.EnableExpressionEditor = True
				Case "CustomExpression"
					newColumn = New GridViewDecimalColumn()
					newColumn.EnableExpressionEditor = True
					newColumn.Name = "CustomExpression"
					newColumn.HeaderText = "Custom Expression"
					newColumn.Width = 80
			End Select

			If numberInTheHeader Then
				newColumn.HeaderText = (Me.columnNum).ToString() & " - " & columnType
				Me.columnNum += 1
			Else
				newColumn.HeaderText = columnType
			End If

			Me.radGridView1.Columns.Add(newColumn)

			Return newColumn
		End Function

		#Region "Event Handlers"

		Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
			For i As Integer = 0 To bitmaps.Count - 1
				bitmaps(i).Dispose()
			Next i

			bitmaps.Clear()

			MyBase.OnHandleDestroyed(e)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			SetPreferences()
			InitializeGrid()

			Me.radRadioCheckExpr1.ToggleState = ToggleState.On
			Me.radRadioNumExpr1.ToggleState = ToggleState.On

			Dim info As CultureInfo = Thread.CurrentThread.CurrentCulture
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture
			Me.radRadioCheckExpr2.Text = String.Format("DateTime > #{0}#", Date.Now.AddDays(60).ToShortDateString())
			Thread.CurrentThread.CurrentCulture = info
		End Sub

		Private Sub radButtonExprEditor_Click(ByVal sender As Object, ByVal e As EventArgs)
			RadExpressionEditorForm.Show(Me.radGridView1, Me.radGridView1.Columns(5))
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radGridView1.MasterTemplate.AllowAddNewRow = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radRadioNumExpr1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radGridView1.Columns.Contains("NumericText") Then
				If Me.radRadioNumExpr1.ToggleState = ToggleState.On Then
					Me.radGridView1.Columns("NumericText").Expression = Me.radRadioNumExpr1.Text
				End If

				If Me.radRadioNumExpr2.ToggleState = ToggleState.On Then
					Me.radGridView1.Columns("NumericText").Expression = Me.radRadioNumExpr2.Text
				End If

				If Me.radRadioAverage.ToggleState = ToggleState.On Then
					Me.radGridView1.Columns("NumericText").Expression = Me.radRadioAverage.Text
				End If
			End If
		End Sub

		Private Sub radRadioCheckExpr1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radGridView1.Columns.Contains("CheckBox") Then
				If Me.radRadioCheckExpr1.ToggleState = ToggleState.On Then
					Me.radGridView1.Columns("CheckBox").Expression = Me.radRadioCheckExpr1.Text
				End If

				If Me.radRadioCheckExpr2.ToggleState = ToggleState.On Then
					Me.radGridView1.Columns("CheckBox").Expression = Me.radRadioCheckExpr2.Text
				End If
			End If
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radRadioAverage.ToggleStateChanged, AddressOf radRadioNumExpr1_ToggleStateChanged
			AddHandler radRadioNumExpr2.ToggleStateChanged, AddressOf radRadioNumExpr1_ToggleStateChanged
			AddHandler radRadioNumExpr1.ToggleStateChanged, AddressOf radRadioNumExpr1_ToggleStateChanged
			AddHandler radRadioCheckExpr1.ToggleStateChanged, AddressOf radRadioCheckExpr1_ToggleStateChanged
			AddHandler radButtonExprEditor.Click, AddressOf radButtonExprEditor_Click
		End Sub
	End Class
End Namespace
