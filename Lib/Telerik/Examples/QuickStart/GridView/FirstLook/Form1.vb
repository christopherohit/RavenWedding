Imports System.ComponentModel
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.IO
Imports System.Reflection
Imports Telerik.WinControls.Primitives


Namespace Telerik.Examples.WinControls.GridView.FirstLook
	''' <summary>
	''' represent the busness grid form
	''' </summary>
	Partial Public Class Form1
		Inherits ShapedForm
		Private columnIDCounter As Integer = 0
		Private Const OleHeaderSize As Integer = 78
		Private segoeFont As New Font("Segoe UI", 8.25f, FontStyle.Regular)
		Private buttonFont As New Font("Segoe UI", 9f, FontStyle.Bold)

		Public Sub New()
			InitializeComponent()

			Me.Shape = New RoundRectShape(7)
			Me.BorderWidth = 1
			Me.radGridView1.TableElement.RowHeight = 80

			AddHandler radGridView1.RowsChanging, AddressOf radGridView1_RowsChanging
			AddHandler radGridView1.DefaultValuesNeeded, AddressOf radGridView1_DefaultValuesNeeded

			Me.deleteButton.ButtonElement.Font = buttonFont
			Me.newButton.ButtonElement.Font = buttonFont
		End Sub

		#Region "Events"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			' TODO: This line of code loads data into the 'furnitureDataSet2.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter1.Fill(Me.furnitureDataSet2.Products)

            Me.BackgroundImage = Me.LoadImage("bg.png")
			Me.BackgroundImageLayout = ImageLayout.Stretch

            Me.newButton.Image = Me.LoadImage("buttonNew.png")
            Me.deleteButton.Image = Me.LoadImage("buttonDelete.png")
            Me.radPanel2.BackgroundImage = Me.LoadImage("f1.PNG")
            Me.radTitleBar1.BackgroundImage = Me.LoadImage("logo.png")
			Me.radTitleBar1.BackgroundImageLayout = ImageLayout.Center
            CType(Me.radTitleBar1.TitleBarElement.Children(2).Children(2), TextPrimitive).Text = String.Empty
			CType(Me.radTitleBar1.TitleBarElement.Children(2).Children(0), ImagePrimitive).Image = Nothing

			Dim panelShapeTopRounded As New RoundRectShape(3)
			panelShapeTopRounded.BottomRightRounded = False
			panelShapeTopRounded.BottomLeftRounded = False
			radPanel4.PanelElement.Shape = panelShapeTopRounded

			Dim panelShapeBottomRounded As New RoundRectShape(3)
			panelShapeBottomRounded.TopLeftRounded = False
			panelShapeBottomRounded.TopRightRounded = False
			radPanel1.PanelElement.Shape = panelShapeBottomRounded

			radPanel3.PanelElement.Shape = panelShapeTopRounded

			radTextBoxDimension.Font = segoeFont
			radTextBoxManufacturer.Font = segoeFont
			radTextBoxMaterial.Font = segoeFont
			radTextBoxProductName.Font = segoeFont
			updateButton.Font = segoeFont
			cancelButton_Renamed.Font = segoeFont
			radLabel2.Font = segoeFont
			radLabel3.Font = segoeFont
			radLabel4.Font = segoeFont
			radLabel5.Font = segoeFont
			radLabel6.Font = segoeFont

			Me.radGridView1.TableElement.Padding = New Padding(0)
			Me.radGridView1.TableElement.DrawBorder = False
			Me.radGridView1.TableElement.CellSpacing = -1
			Me.radGridView1.TableElement.Text = ""

			Me.radGridView1.MasterTemplate.BestFitColumns()
			Me.radGridView1.Columns("Photo").Width = 106
			Me.radGridView1.Columns("ProductName").Width = 104

			Me.FillComboBox()
            Me.UpdatePanelInfo(Me.radGridView1.CurrentRow)

            Me.WireEvents()

		End Sub

		Private Sub radGridView1_DefaultValuesNeeded(ByVal sender As Object, ByVal e As GridViewRowEventArgs)
			e.Rows(0).Cells("Price").Value = 0
			e.Rows(0).Cells("Quantity").Value = 0
			e.Rows(0).Cells("ID").Value = Me.columnIDCounter
			Me.columnIDCounter += 1
		End Sub

		Private Sub radGridView1_RowsChanging(ByVal sender As Object, ByVal e As GridViewCollectionChangingEventArgs)
			If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
				Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this product?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

				If dialogResult <> DialogResult.OK Then
					e.Cancel = True
				End If
			End If
		End Sub

		Private Sub radGridView1_CurrentRowChanged(ByVal sender As Object, ByVal e As CurrentRowChangedEventArgs)
			UpdatePanelInfo(Me.radGridView1.CurrentRow)
		End Sub

		Private Sub updateButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			UpdateGridInfo(Me.radGridView1.CurrentRow)
		End Sub

		Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radGridView1.CurrentRow IsNot Nothing Then
				UpdatePanelInfo(Me.radGridView1.CurrentRow)
			End If
		End Sub

		Private Sub newButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.AllowAddNewRow = Not Me.radGridView1.AllowAddNewRow
		End Sub

		Private Sub deleteButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim dataRowInfo As GridViewDataRowInfo = TryCast(Me.radGridView1.CurrentRow, GridViewDataRowInfo)
			If dataRowInfo IsNot Nothing Then
				Me.radGridView1.Rows.Remove(dataRowInfo)
				Me.UpdatePanelInfo(Me.radGridView1.CurrentRow)
			End If
		End Sub

		#End Region

		Private Sub WireEvents()
			AddHandler cancelButton_Renamed.Click, AddressOf cancelButton_Click
			AddHandler updateButton.Click, AddressOf updateButton_Click
			AddHandler newButton.Click, AddressOf newButton_Click
			AddHandler radGridView1.CurrentRowChanged, AddressOf radGridView1_CurrentRowChanged
			AddHandler deleteButton.Click, AddressOf deleteButton_Click
		End Sub

		Private Sub UpdatePanelInfo(ByVal currentRow As GridViewRowInfo)
			If currentRow IsNot Nothing AndAlso Not(TypeOf currentRow Is GridViewNewRowInfo) Then
				Me.radTextBoxProductName.Text = Me.GetSafeString(currentRow.Cells("ProductName").Value)
				Me.radTextBoxManufacturer.Text = Me.GetSafeString(currentRow.Cells("Manufacturer").Value)
				Me.radTextBoxMaterial.Text = Me.GetSafeString(currentRow.Cells("Lining").Value)
				Me.radTextBoxDimension.Text = Me.GetSafeString(currentRow.Cells("Dimensions").Value)

				Dim photoValue As Object = currentRow.Cells("Photo").Value

				If (Not Convert.IsDBNull(photoValue)) AndAlso photoValue IsNot Nothing Then
					Dim image As Image = GetImageFromBytes(TryCast(currentRow.Cells("Photo").Value, Byte()))
					Me.radPanel2.BackgroundImage = New Bitmap(image)
				Else
					Me.radPanel2.BackgroundImage = New Bitmap(10, 10)
				End If

				Dim salesPerson As String = Me.GetSafeString(currentRow.Cells("SalesRepresentative").Value)

				If Not String.IsNullOrEmpty(salesPerson.Trim()) Then
					Me.radComboBox1.SelectedIndex = Me.radComboBox1.FindString(salesPerson)
				Else
					Me.radComboBox1.SelectedIndex = -1
					Me.radComboBox1.Text = String.Empty
				End If
			Else
				Me.radTextBoxProductName.Text = String.Empty
				Me.radTextBoxManufacturer.Text = String.Empty
				Me.radTextBoxMaterial.Text = String.Empty
				Me.radTextBoxDimension.Text = String.Empty
				Me.radPanel2.BackgroundImage = New Bitmap(10, 10)
				Me.radComboBox1.SelectedIndex = -1
				Me.radComboBox1.Text = String.Empty
			End If
		End Sub

		Private Sub UpdateGridInfo(ByVal currentRow As GridViewRowInfo)
			If currentRow Is Nothing Then
				Return
			End If

			Me.radGridView1.CloseEditor()

			currentRow.Cells("ProductName").Value = Me.radTextBoxProductName.Text
			currentRow.Cells("Manufacturer").Value = Me.radTextBoxManufacturer.Text
			currentRow.Cells("Lining").Value = Me.radTextBoxMaterial.Text
			currentRow.Cells("Dimensions").Value = Me.radTextBoxDimension.Text

			If Me.radComboBox1.SelectedIndex <> -1 Then
				currentRow.Cells("SalesRepresentative").Value = Me.radComboBox1.SelectedItem.Text
			End If

			Dim newRowInfo As GridViewNewRowInfo = TryCast(currentRow, GridViewNewRowInfo)
			If newRowInfo IsNot Nothing Then
				currentRow.InvalidateRow()
			Else
				CType(Me.radGridView1.CurrentRow.DataBoundItem, IEditableObject).EndEdit()
			End If
		End Sub

		Private Sub FillComboBox()
			Me.radComboBox1.Items.Clear()
			Dim basePath As String = Path.GetDirectoryName(Application.ExecutablePath)
			For Each fileName As String In Directory.GetFiles(Path.Combine(basePath, "..\GridView\FirstLook\Images\People"), "*.jpg")
				Dim image As Image = Image.FromFile(fileName)
				Dim comboboxItem As New RadListDataItem()
				comboboxItem.Font = Me.radComboBox1.Font
				comboboxItem.ForeColor = Color.Black
				comboboxItem.TextImageRelation = TextImageRelation.ImageBeforeText
				comboboxItem.Text = Path.GetFileNameWithoutExtension(fileName)
				comboboxItem.Image = image
				Me.radComboBox1.Items.Add(comboboxItem)
			Next fileName

			Me.radComboBox1.ShowImageInEditorArea = False
		End Sub

		Private Function GetSafeString(ByVal value As Object) As String
			If value Is Nothing Then
				Return String.Empty
			End If

			Return value.ToString()
		End Function

		Private Function LoadImage(ByVal name As String) As Image
			Dim stream As Stream = System.Reflection.Assembly.GetAssembly(Me.GetType()).GetManifestResourceStream(name)

			If stream Is Nothing Then
				Throw New NullReferenceException("Cannot find " & name)
			End If

			Return New Bitmap(stream)
		End Function

		Private Function GetImageFromBytes(ByVal bytes() As Byte) As Image
			If bytes Is Nothing OrElse bytes.Length = 0 Then
				Return Nothing
			End If

			Dim result As Image = Nothing
			Dim stream As MemoryStream = Nothing

			Try
				Dim count As Integer
				Dim start As Integer

				If IsOleContainer(bytes) Then
					count = bytes.Length - OleHeaderSize
					start = OleHeaderSize
				Else
					count = bytes.Length
					start = 0
				End If

				stream = New MemoryStream(bytes, start, count)
				result = Image.FromStream(stream)
			Catch
				result = Nothing
			Finally
				If stream IsNot Nothing Then
					stream.Close()
				End If
			End Try
			Return result
		End Function

		Private Function IsOleContainer(ByVal imageData() As Byte) As Boolean
			Return (imageData IsNot Nothing AndAlso imageData(0) = &H15 AndAlso imageData(1) = &H1C)
		End Function
	End Class
End Namespace
