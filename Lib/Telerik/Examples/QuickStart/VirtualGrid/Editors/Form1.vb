Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.VirtualGrid.Editors

Namespace Telerik.Examples.WinControls.VirtualGrid.Editors
	Public Partial Class Form1
		Inherits ExamplesForm
		Private [set] As NorthwindDataSet = New NorthwindDataSet()
		Private columns As String()
		Private fields As String()
		Private colors As Color()
		Private filePaths As String()
		Private opacities As Integer()

		Public Sub New()
			InitializeComponent()

			Me.radVirtualGrid1.TableElement.ColumnWidth = 150
			Me.radVirtualGrid1.TableElement.RowHeight = 80

			Dim employees As EmployeesTableAdapter = New EmployeesTableAdapter()
			employees.Fill([set].Employees)

			Me.columns = New String() { "Decimal", "Text", "Image", "LookUp", "Date", "Color", "Browse", "Custom" }
			Me.fields = New String() { "EmployeeID", "LastName", "Photo", "TitleOfCourtesy", "HireDate" }
			Me.colors = New Color() { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet, Color.White, Color.Black }
			Me.filePaths = New String() { "C:\Music\Sting\If You Love Somebody Set Them Free.wav", "C:\Music\Sting\Russians.wav", "C:\Music\Sting\Fortress Around Your Heart.wav", "C:\Music\Sting\Love Is the Seventh Wave.wav", "C:\Music\Sheryl Crow\Run, Baby, Run.wav", "C:\Music\Sheryl Crow\Leaving Las Vegas.wav", "C:\Music\Sheryl Crow\Strong Enough.wav", "C:\Music\Sheryl Crow\Maybe Angels.wav", "C:\Music\Sheryl Crow\A Change Would Do You Good.wav" }

			Me.opacities = New Integer() { 100, 75, 100, 75, 20, 50, 75, 10, 75 }

			Me.radVirtualGrid1.ColumnCount = Me.columns.Length
			Me.radVirtualGrid1.RowCount = [set].Employees.Rows.Count
            Me.radVirtualGrid1.VirtualGridElement.SetColumnWidth(75, 0, 1, 2)
			Me.radVirtualGrid1.AllowAddNewRow = False

			AddHandler Me.radVirtualGrid1.CellFormatting, AddressOf radVirtualGrid1_CellFormatting
			AddHandler Me.radVirtualGrid1.CellValueNeeded, AddressOf radVirtualGrid1_CellValueNeeded
			AddHandler Me.radVirtualGrid1.CellValuePushed, AddressOf radVirtualGrid1_CellValuePushed
			AddHandler Me.radVirtualGrid1.EditorRequired, AddressOf radVirtualGrid1_EditorRequired
		End Sub

		Private Sub radVirtualGrid1_EditorRequired(ByVal sender As Object, ByVal e As VirtualGridEditorRequiredEventArgs)
			Dim columnName As String = Me.columns(e.ColumnIndex)

			Select Case columnName
				Case "Decimal"
					e.Editor = New VirtualGridSpinEditor()
				Case "Text"
					e.Editor = New VirtualGridTextBoxEditor()
				Case "LookUp"
					Dim ddl As VirtualGridDropDownListEditor = New VirtualGridDropDownListEditor()
					Dim element As RadDropDownListEditorElement = TryCast(ddl.EditorElement, RadDropDownListEditorElement)
					element.DataSource = New String() { "Mr.", "Mrs.", "Ms.", "Dr." }
					e.Editor = ddl
				Case "Color"
					e.Editor = New VirtualGridColorPickerEditor()
				Case "Date"
					e.Editor = New VirtualGridDateTimeEditor()
				Case "Browse"
					e.Editor = New VirtualGridBrowseEditor()
				Case "Custom"
                    e.Editor = New VirtualGridTrackBarEditor()
				Case "Image"
					e.Cancel = True
			End Select
		End Sub

		Private Sub radVirtualGrid1_CellFormatting(ByVal sender As Object, ByVal e As VirtualGridCellElementEventArgs)
			If e.CellElement.RowIndex < 0 OrElse e.CellElement.ColumnIndex < 0 Then
				Return
			End If

			Dim columnName As String = Me.columns(e.CellElement.ColumnIndex)

			Select Case columnName
				Case "Date"
					If Not e.CellElement.Value Is Nothing AndAlso Not e.CellElement.Value Is DBNull.Value Then
						e.CellElement.Text = (CDate(e.CellElement.Value)).ToLongDateString()
					End If

					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
				Case "Image"
					Dim converter As ImageConverter = New ImageConverter()
					Dim result As Object = converter.ConvertFrom(e.CellElement.Value)
					e.CellElement.Image = TryCast(result, Image)
					e.CellElement.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
					e.CellElement.Text = String.Empty
					e.CellElement.ImageOpacity = (CDbl(Me.opacities(e.CellElement.RowIndex)) / 100.0)
				Case "Decimal"
					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
				Case "Custom"
					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
					e.CellElement.Text = String.Format("{0} %", e.CellElement.Value)
				Case "Text", "LookUp", "Color", "Browse"
					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            End Select

            If columnName <> "Image" Then
                e.CellElement.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local)
            End If
        End Sub

		Private Sub radVirtualGrid1_CellValueNeeded(ByVal sender As Object, ByVal e As VirtualGridCellValueNeededEventArgs)
			If e.ColumnIndex < 0 Then
				Return
			End If

			If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
				e.Value = Me.columns(e.ColumnIndex)
			End If

			If e.RowIndex < 0 Then
				Return
			End If

			If e.ColumnIndex < Me.fields.Length Then
				e.Value = Me.set.Employees.Rows(e.RowIndex)(Me.fields(e.ColumnIndex))
			ElseIf Me.columns(e.ColumnIndex) = "Color" Then
				e.Value = Me.colors(e.RowIndex)
			ElseIf Me.columns(e.ColumnIndex) = "Browse" Then
				e.Value = Me.filePaths(e.RowIndex)
			ElseIf Me.columns(e.ColumnIndex) = "Custom" Then
				e.Value = Me.opacities(e.RowIndex)
			End If
		End Sub

		Private Sub radVirtualGrid1_CellValuePushed(ByVal sender As Object, ByVal e As VirtualGridCellValuePushedEventArgs)
			Try
				If e.ColumnIndex < Me.fields.Length Then
					Me.set.Employees.Rows(e.RowIndex)(Me.fields(e.ColumnIndex)) = e.Value
				ElseIf Me.columns(e.ColumnIndex) = "Color" Then
					Me.colors(e.RowIndex) = CType(e.Value, Color)
				ElseIf Me.columns(e.ColumnIndex) = "Browse" Then
					Me.filePaths(e.RowIndex) = Convert.ToString(e.Value)
				ElseIf Me.columns(e.ColumnIndex) = "Custom" Then
					Me.opacities(e.RowIndex) = Convert.ToInt32(e.Value)
				End If
			Catch e1 As Exception
				'Indicate error
			End Try
		End Sub
	End Class
End Namespace
