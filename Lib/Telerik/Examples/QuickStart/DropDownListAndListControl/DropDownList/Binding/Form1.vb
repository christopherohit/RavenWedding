Imports System.ComponentModel
Imports System.Text
Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.Examples.WinControls.Editors
Imports My

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Binding
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private showDropDownTimeout As Timer

		Public Sub New()
			InitializeComponent()
			Me.showDropDownTimeout = New Timer(Me.components)
			AddHandler showDropDownTimeout.Tick, AddressOf showDropDownTimeout_Tick
			Me.showDropDownTimeout.Interval = 1000

			Me.SelectedControl = Me.radComboDemo
		End Sub

		Private Sub showDropDownTimeout_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radComboDemo.ShowDropDown()
			Me.showDropDownTimeout.Stop()
			Me.radComboDemo.Focus()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.radRadioArray.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.BindToArray()
			Me.showDropDownTimeout.Start()
			MyBase.OnLoad(e)
		End Sub

		#Region "OLD LOGIC"

		Private Sub LoadData()
			Try
				employeesTableAdapter2.Fill(Me.NorthwindDataSetAccess.Employees)
			Catch exception1 As Exception
				Dim message As String = "To run this sample, you must have SQL Server with the Northwind database installed."
				Throw New DataException(message, exception1)
			End Try
		End Sub


		Private Sub UnboundMode()
			Me.radComboDemo.DataSource = Nothing
			Me.radComboDemo.Items.Clear()
			Dim processes() As Process = Process.GetProcesses()

			Dim comboItems(processes.Length - 1) As RadListDataItem
			For i As Integer = 0 To processes.Length - 1
				comboItems(i) = New RadListDataItem(processes(i).ProcessName)
			Next i

			Me.radComboDemo.Items.AddRange(comboItems)
			Me.radComboDemo.SortStyle= Telerik.WinControls.Enumerations.SortStyle.Ascending
		End Sub

		Private Sub BindToArray()
			Me.radComboDemo.DataSource = Nothing
			Me.radComboDemo.Items.Clear()

			Dim result(9) As DataItem

			result(0) = New DataItem("Belgium", Resources.BE)
			result(1) = New DataItem("Germany", Resources.DE)
            result(2) = New DataItem("India", Resources._IN)
			result(3) = New DataItem("France", Resources.FR)
			result(4) = New DataItem("USA", Resources.US)
			result(5) = New DataItem("Russia", Resources.RU)
			result(6) = New DataItem("Japan", Resources.JP)
			result(7) = New DataItem("China", Resources.CN)
			result(8) = New DataItem("Bulgaria", Resources.BUL)
			result(9) = New DataItem("Switzerland", Resources.CH)

			AddHandler Me.radComboDemo.ItemDataBound, AddressOf radComboDemo_ItemDataBound
			Me.radComboDemo.DisplayMember = "Text"
			Me.radComboDemo.DataSource = result
			RemoveHandler Me.radComboDemo.ItemDataBound, AddressOf radComboDemo_ItemDataBound
		End Sub

		Private Sub radComboDemo_ItemDataBound(ByVal sender As Object, ByVal args As ListItemDataBoundEventArgs)
			args.NewItem.Image = (CType(args.NewItem.DataBoundItem, DataItem)).Image
			args.NewItem.TextImageRelation = TextImageRelation.ImageBeforeText
		End Sub

		Private Sub BindToDataTable()
			Dim myDocumentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

			Dim dt As DataTable = Me.FillFilesTable(myDocumentsPath)

			If dt.Rows.Count = 0 Then
				MessageBox.Show(String.Format("No files found in ""{0}"" ", myDocumentsPath), "No data in the table", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If

			Me.radComboDemo.DataSource = Nothing
			Me.radComboDemo.Items.Clear()
			Me.radComboDemo.DataSource = dt
			Me.radComboDemo.DisplayMember = "FileName"
			Me.radComboDemo.ValueMember = "Length"
		End Sub


		Private Sub BindToDataSet()
			Me.radComboDemo.DataSource = Nothing
			Me.radComboDemo.Items.Clear()
			Me.LoadData()
			Me.radComboDemo.DataSource = Me.NorthwindDataSetAccess.Employees
			Me.radComboDemo.DisplayMember = "LastName"
			Me.radComboDemo.ValueMember = "EmployeeID"

		End Sub

		Private Function GetImageFromData(ByVal imageData() As Byte) As Image
			Const OleHeaderLength As Integer = 78
			Dim memoryStream As New MemoryStream()
			If HasOleContainerHeader(imageData) Then
				memoryStream.Write(imageData, OleHeaderLength, imageData.Length - OleHeaderLength)
			Else
				memoryStream.Write(imageData, 0, imageData.Length)
			End If
			Dim bitmap As New Bitmap(memoryStream)
			Return bitmap.GetThumbnailImage(55, 65, Nothing, New IntPtr())
		End Function

		Private Function HasOleContainerHeader(ByVal imageByteArray() As Byte) As Boolean
			Const OleByte0 As Byte = 21
			Const OleByte1 As Byte = 28
			Return (imageByteArray(0) = OleByte0) AndAlso (imageByteArray(1) = OleByte1)
		End Function

		Private Function FillFilesTable(ByVal path As String) As DataTable
			Dim dt As New DataTable()
			dt.Columns.Add("FileName", GetType(String))
			dt.Columns.Add("Length", GetType(Long))
			dt.Columns.Add("IsReadOnly", GetType(Boolean))
			dt.Columns.Add("LastAccessTime", GetType(Date))
			For Each filePath As String In Directory.GetFiles(path)
				Dim dr As DataRow = dt.NewRow()
				Dim fileInfo As New FileInfo(filePath)
				dr("FileName") = fileInfo.Name
				dr("Length") = fileInfo.Length
				dr("IsReadOnly") = fileInfo.IsReadOnly
				dr("LastAccessTime") = fileInfo.LastAccessTime
				dt.Rows.Add(dr)
			Next filePath
			Return dt
		End Function

		''' <summary>
		''' Gets a collection of typed Customers. This demonstrates binding to a list of custom objects.
		''' </summary>
		''' <returns>Return a typed list of Customer objects</returns>
		''' <remarks>You could use List(Of T) as well.  BindingList(Of T) provides additional events that may be useful</remarks>
		Private Function GetCustomerList() As BindingList(Of Customer)
			Dim customerList As New BindingList(Of Customer)()
			customerList.Add(New Customer(1, "Alfreds Futterkiste"))
			customerList.Add(New Customer(2, "Ana Trujillo Emparedados y helados"))
			customerList.Add(New Customer(3, "Antonio Moreno Taquera"))
			customerList.Add(New Customer(4, "Around the Horn"))
			customerList.Add(New Customer(5, "Cactus Comidas para llevar"))
			Dim newCustomer As New Customer()
			newCustomer.Id = 6
			newCustomer.Name = "Ernst Handel"
			customerList.Add(newCustomer)
			Return customerList
		End Function

		Private Sub CustomerBindingSource_AddingNew(ByVal sender As Object, ByVal e As AddingNewEventArgs)
			Dim newCustomer As New Customer()
			newCustomer.Id = Me.CustomerBindingSource.Count + 1
			newCustomer.Name = "New customer " & newCustomer.Id.ToString()
			e.NewObject = newCustomer
		End Sub

		#End Region

		Private Sub OnRadioBinding_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioArray.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.BindToArray()
			ElseIf Me.radRadioDataTable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.BindToDataTable()
			ElseIf Me.radRadioDB.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.BindToDataSet()
			ElseIf Me.radRadioUnbound.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.UnboundMode()
			End If
			Me.showDropDownTimeout.Start()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler CustomerBindingSource.AddingNew, AddressOf CustomerBindingSource_AddingNew
			AddHandler radRadioDB.ToggleStateChanged, AddressOf OnRadioBinding_ToggleStateChanged
			AddHandler radRadioArray.ToggleStateChanged, AddressOf OnRadioBinding_ToggleStateChanged
			AddHandler radRadioDataTable.ToggleStateChanged, AddressOf OnRadioBinding_ToggleStateChanged
			AddHandler radRadioUnbound.ToggleStateChanged, AddressOf OnRadioBinding_ToggleStateChanged
		End Sub
	End Class

	Public Class DataItem
'INSTANT VB NOTE: The variable image was renamed since Visual Basic does not allow class members with the same name:
		Private image_Renamed As Image = Nothing
'INSTANT VB NOTE: The variable text was renamed since Visual Basic does not allow class members with the same name:
		Private text_Renamed As String = ""

		Public Sub New(ByVal text As String, ByVal image As Image)
			Me.text_Renamed = text
			Me.image_Renamed = image
		End Sub

		Public ReadOnly Property Image() As Image
			Get
				Return Me.image_Renamed
			End Get
		End Property

		Public ReadOnly Property Text() As String
			Get
				Return Me.text_Renamed
			End Get
		End Property
	End Class
End Namespace