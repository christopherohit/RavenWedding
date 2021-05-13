
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.WebService
	Public Partial Class Form1
		Inherits ExamplesForm
		Private Const IMAGE_REQUEST_SIZE As Integer = 10
		Private initialLoader As BackgroundWorker
		Private imageLoader As BackgroundWorker
		Private data As List(Of Product)
		Private fieldNames As String() = New String() {"Image", "ProductName", "UnitPrice", "UnitsInStock", "Discontinued"}
		Private loadedRowCount As Integer = IMAGE_REQUEST_SIZE

		Public Sub New()
			InitializeComponent()

			Me.radVirtualGrid1.TableElement.RowHeight = 150
			Me.radVirtualGrid1.RowCount = 0
			Me.radVirtualGrid1.ColumnCount = 5

			Me.initialLoader = New BackgroundWorker()
			AddHandler Me.initialLoader.DoWork, AddressOf initialLoader_DoWork
			AddHandler Me.initialLoader.RunWorkerCompleted, AddressOf initialLoader_RunWorkerCompleted

			Me.imageLoader = New BackgroundWorker()
			AddHandler Me.imageLoader.DoWork, AddressOf imageLoader_DoWork
			AddHandler Me.imageLoader.RunWorkerCompleted, AddressOf imageLoader_RunWorkerCompleted
		End Sub

		#Region "VirtualGrid handling"

        Private Sub radButton1_Click(sender As Object, e As EventArgs) Handles radButton1.Click
            Me.radButton1.Visible = False
            Me.radVirtualGrid1.MasterViewInfo.IsWaiting = True
            Me.initialLoader.RunWorkerAsync()
        End Sub

        Private Sub radVirtualGrid1_CellValueNeeded(sender As Object, e As Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs) Handles radVirtualGrid1.CellValueNeeded
            If e.ColumnIndex < 0 OrElse Me.data Is Nothing Then
                Return
            End If

            If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
                e.Value = fieldNames(e.ColumnIndex)
            End If

            If e.RowIndex = e.ViewInfo.RowCount - 1 AndAlso e.ViewInfo.RowCount < Me.data.Count Then
                e.Value = Nothing
                e.ViewInfo.StartRowWaiting(e.RowIndex)
                If Not Me.imageLoader.IsBusy Then
                    Me.imageLoader.RunWorkerAsync()
                End If
            ElseIf e.RowIndex >= 0 Then
                e.Value = Me.data(e.RowIndex)(e.ColumnIndex)
            End If

        End Sub

        Private Sub radVirtualGrid1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.VirtualGridCellElementEventArgs) Handles radVirtualGrid1.CellFormatting
            If TypeOf e.CellElement.Value Is Image Then
                e.CellElement.Text = ""
                e.CellElement.Image = DirectCast(e.CellElement.Value, Image)
            ElseIf Not (TypeOf e.CellElement Is VirtualGridIndentCellElement) Then
                e.CellElement.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local)
            End If
        End Sub

		#End Region

		#Region "Background Workers"

		Private Sub initialLoader_DoWork(sender As Object, e As DoWorkEventArgs)
			Dim request As WebRequest = WebRequest.Create("http://demos.telerik.com/kendo-ui/service/Products")
			Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
				Using dataStream As Stream = response.GetResponseStream()
					Using reader As New StreamReader(dataStream)
						Dim responseFromServer As String = reader.ReadToEnd()
						Dim parsedData As List(Of Product) = ParseServerResponce(responseFromServer)
						e.Result = parsedData
						RequestImages(parsedData, 0, IMAGE_REQUEST_SIZE)
					End Using
				End Using
			End Using
		End Sub

		Private Sub imageLoader_DoWork(sender As Object, e As DoWorkEventArgs)
			Me.RequestImages(Me.data, loadedRowCount, loadedRowCount + IMAGE_REQUEST_SIZE)
		End Sub

		Private Sub initialLoader_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
			If Me.radVirtualGrid1.IsDisposed Then
				Return
			End If

			Dim parsedResult As List(Of Product) = TryCast(e.Result, List(Of Product))
			Me.data = parsedResult
			Me.radVirtualGrid1.RowCount = Math.Min(loadedRowCount + 1, Me.data.Count)
			Me.radVirtualGrid1.MasterViewInfo.IsWaiting = False
		End Sub

		Private Sub imageLoader_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
			If Me.radVirtualGrid1.IsDisposed Then
				Return
			End If

			Dim waitingRow As Integer = Me.radVirtualGrid1.RowCount - 1
			Me.radVirtualGrid1.RowCount = Math.Min(loadedRowCount + 1, Me.data.Count)
			Me.radVirtualGrid1.MasterViewInfo.StopRowWaiting(waitingRow)
		End Sub

		#End Region

		#Region "WebRequest handling"

		Private Sub RequestImages(data As List(Of Product), startIndex As Integer, endIndex As Integer)
			endIndex = Math.Min(endIndex, data.Count)
			For i As Integer = startIndex To endIndex - 1
				If data(i).Image Is Nothing Then
                    Dim request As WebRequest = WebRequest.Create("http://demos.telerik.com/kendo-ui/content/web/foods/" & data(i).ProductID & ".jpg")
					Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
						Using dataStream As Stream = response.GetResponseStream()
							data(i).Image = Image.FromStream(dataStream)
						End Using
					End Using
				End If
			Next

			Me.loadedRowCount = endIndex
		End Sub

		Private Function ParseServerResponce(responseFromServer As String) As List(Of Product)
			Dim openArrayBracket As Integer = responseFromServer.IndexOf("["C)
			Dim closeArrayBracket As Integer = responseFromServer.IndexOf("]"C)
			Dim json As String = responseFromServer.Substring(openArrayBracket + 1, closeArrayBracket - openArrayBracket - 1)
			Dim items As String() = json.Split(New String() {"},{"}, StringSplitOptions.RemoveEmptyEntries)

			Dim result As New List(Of Product)()
			For Each item As String In items
				Dim product As New Product()
				Dim fields As String() = item.Trim("{"C, "}"C).Split(","C)
				For Each field As String In fields
					Dim prop As String() = field.Split(":"C)
					prop(0) = prop(0).Trim(" "C, """"C)
					prop(1) = prop(1).Trim(" "C, """"C)

					Select Case prop(0)
						Case "ProductID"
							product.ProductID = Integer.Parse(prop(1))
							Exit Select
						Case "ProductName"
							product.ProductName = prop(1)
							Exit Select
						Case "UnitPrice"
                            product.UnitPrice = Decimal.Parse(prop(1), System.Globalization.CultureInfo.InvariantCulture)
							Exit Select
						Case "UnitsInStock"
							product.UnitsInStock = Integer.Parse(prop(1))
							Exit Select
						Case "Discontinued"
							product.Discontinued = Boolean.Parse(prop(1))
							Exit Select

					End Select
				Next

				result.Add(product)
			Next

			Return result
		End Function

		#End Region
	End Class
End Namespace

