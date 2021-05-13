Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.Settings
	Public Partial Class Form1
		Inherits ExamplesForm
		#Region "Initialization"

		Private data As New List(Of Employee)()

		Public Sub New()
			InitializeComponent()

			LoadData()
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.radSpinEditorRowSpacing.ValueChanged, AddressOf radSpinEditorRowSpacing_ValueChanged
			AddHandler Me.radSpinEditorCellSpacing.ValueChanged, AddressOf radSpinEditorCellSpacing_ValueChanged
			AddHandler Me.radSpinEditorColumnWidth.ValueChanged, AddressOf radSpinEditorColumnWidth_ValueChanged
			AddHandler Me.radSpinEditorDataRowHeight.ValueChanged, AddressOf radSpinEditorDataRowHeight_ValueChanged
			AddHandler Me.radSpinEditorFilterRowHeight.ValueChanged, AddressOf radSpinEditorFilterRowHeight_ValueChanged
			AddHandler Me.radSpinEditorNewRowHeight.ValueChanged, AddressOf radSpinEditorNewRowHeight_ValueChanged
			AddHandler Me.radSpinEditorHeaderRowHeight.ValueChanged, AddressOf radSpinEditorHeaderRowHeight_ValueChanged
			AddHandler Me.radCheckBoxShowFilterRow.ToggleStateChanged, AddressOf radCheckBoxShowFilterRow_ToggleStateChanged
			AddHandler Me.radCheckBoxShowNewRow.ToggleStateChanged, AddressOf radCheckBoxShowNewRow_ToggleStateChanged
			AddHandler Me.radCheckBoxShowHeaderRow.ToggleStateChanged, AddressOf radCheckBoxShowHeaderRow_ToggleStateChanged
			AddHandler Me.radCheckBoxHotTracking.ToggleStateChanged, AddressOf radCheckBoxHotTracking_ToggleStateChanged
			AddHandler Me.radCheckBoxAlternatingRowColors.ToggleStateChanged, AddressOf radCheckBoxAlternatingRowColors_ToggleStateChanged
			AddHandler Me.radCheckBoxFitColumns.ToggleStateChanged, AddressOf radCheckBoxFitColumns_ToggleStateChanged

		End Sub

		#End Region

		#Region "Settings"

		Private Sub radSpinEditorRowSpacing_ValueChanged(sender As Object, e As EventArgs)
			Me.radVirtualGrid1.TableElement.RowSpacing = CInt(Me.radSpinEditorRowSpacing.Value)
		End Sub

		Private Sub radSpinEditorCellSpacing_ValueChanged(sender As Object, e As EventArgs)
			Me.radVirtualGrid1.TableElement.CellSpacing = CInt(Me.radSpinEditorCellSpacing.Value)
		End Sub

		Private Sub radSpinEditorColumnWidth_ValueChanged(sender As Object, e As EventArgs)
            Me.radVirtualGrid1.TableElement.SetColumnWidth(CInt(Me.radSpinEditorColumnWidth.Value), 0, 1, 2, 3, 4)
		End Sub

		Private Sub radSpinEditorDataRowHeight_ValueChanged(sender As Object, e As EventArgs)
			Me.radVirtualGrid1.TableElement.RowHeight = CInt(Me.radSpinEditorDataRowHeight.Value)
		End Sub

		Private Sub radSpinEditorFilterRowHeight_ValueChanged(sender As Object, e As EventArgs)
			Me.radVirtualGrid1.TableElement.FilterRowHeight = CInt(Me.radSpinEditorFilterRowHeight.Value)
		End Sub

		Private Sub radSpinEditorNewRowHeight_ValueChanged(sender As Object, e As EventArgs)
			Me.radVirtualGrid1.TableElement.NewRowHeight = CInt(Me.radSpinEditorNewRowHeight.Value)
		End Sub

		Private Sub radSpinEditorHeaderRowHeight_ValueChanged(sender As Object, e As EventArgs)
			Me.radVirtualGrid1.TableElement.HeaderRowHeight = CInt(Me.radSpinEditorHeaderRowHeight.Value)
		End Sub

		Private Sub radCheckBoxShowFilterRow_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radVirtualGrid1.AllowFiltering = args.ToggleState = ToggleState.[On]
		End Sub

		Private Sub radCheckBoxShowNewRow_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radVirtualGrid1.AllowAddNewRow = args.ToggleState = ToggleState.[On]
		End Sub

		Private Sub radCheckBoxShowHeaderRow_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radVirtualGrid1.ShowHeaderRow = args.ToggleState = ToggleState.[On]
		End Sub

		Private Sub radCheckBoxHotTracking_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radVirtualGrid1.EnableHotTracking = args.ToggleState = ToggleState.[On]
		End Sub

		Private Sub radCheckBoxAlternatingRowColors_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radVirtualGrid1.EnableAlternatingRowColor = args.ToggleState = ToggleState.[On]
		End Sub

		Private Sub radCheckBoxFitColumns_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.[On] Then
                Me.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill
			Else
				Me.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.None
			End If
		End Sub

		#End Region

		#Region "Populate Data"

		Private Sub LoadData()
			employeesTableAdapter.Fill(northwindDataSet.Employees)
			Dim random As New Random()

			For i As Integer = 0 To northwindDataSet.Employees.Count - 1
				Dim row As Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow = northwindDataSet.Employees(i)
				Dim employee__1 As New Employee()
				employee__1.Name = row.FirstName + " " + row.LastName
				employee__1.Photo = GetImageFromBytes(row.Photo)
				employee__1.Salary = random.[Next](45000, 90000)
				employee__1.HireDate = row.HireDate
				employee__1.Title = row.Title

				data.Add(employee__1)
			Next

			Me.radVirtualGrid1.RowCount = data.Count
			Me.radVirtualGrid1.ColumnCount = Employee.FieldNames.Length
		End Sub

        Private Sub radVirtualGrid1_CellValueNeeded(sender As Object, e As Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs) Handles radVirtualGrid1.CellValueNeeded
            If e.ViewInfo.Equals(Me.radVirtualGrid1.MasterViewInfo) Then
                If e.ColumnIndex < 0 Then
                    Return
                End If

                e.FieldName = Employee.FieldNames(e.ColumnIndex)

                If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
                    e.Value = e.FieldName
                ElseIf e.RowIndex >= 0 Then
                    e.Value = data(e.RowIndex)(e.ColumnIndex)
                    If e.ColumnIndex = 2 Then
                        e.FormatString = "${0:#,###}"
                    ElseIf e.ColumnIndex = 3 Then
                        e.FormatString = "{0:MM/dd/yy}"
                    End If
                End If
            End If
        End Sub

        Private Sub radVirtualGrid1_CellFormatting(sender As Object, e As VirtualGridCellElementEventArgs) Handles radVirtualGrid1.CellFormatting
            If e.CellElement.ColumnIndex < 0 Then
                Return
            End If

            If TypeOf e.CellElement.Value Is Image Then
                e.CellElement.Image = DirectCast(e.CellElement.Value, Image)
                e.CellElement.ImageLayout = ImageLayout.Zoom
                e.CellElement.Text = ""
            Else
                e.CellElement.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local)
            End If
        End Sub

#End Region

#Region "Helper Methods"

        Private Function GetImageFromBytes(bytes As Byte()) As Image
			Dim result As Image = Nothing
			Dim stream As MemoryStream = Nothing

			Try
				stream = New MemoryStream(bytes, 78, bytes.Length - 78)
				result = Image.FromStream(stream)
			Catch
				Try
					stream = New MemoryStream(bytes, 0, bytes.Length)
					result = Image.FromStream(stream)
				Catch
					result = Nothing
				End Try
			Finally
				If stream IsNot Nothing Then
					stream.Close()
				End If
			End Try

			Return result
		End Function

		#End Region
	End Class
End Namespace