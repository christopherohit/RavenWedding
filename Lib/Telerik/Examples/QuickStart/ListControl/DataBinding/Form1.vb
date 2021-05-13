Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports System.IO
Imports Telerik.WinControls.UI
Imports System.Threading
Imports Telerik.WinControls
Imports My

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.ListControl.DataBinding
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radListBoxDemo
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.BindToArray()
			Me.radRadioArray.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			MyBase.OnLoad(e)
		End Sub

		Private Sub UnboundMode()
			Me.radListBoxDemo.DataSource = Nothing
			Me.radListBoxDemo.Items.Clear()
			Me.radListBoxDemo.Items.AddRange(Me.CreateListBoxItems())
			'this.radListBoxDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
		End Sub

		Private Function CreateListBoxItems() As RadListDataItem()
			Dim result(9) As RadListDataItem

			result(0) = New RadListDataItem("Belgium")
			result(0).Image = Resources.BE
			result(0).TextImageRelation = TextImageRelation.ImageBeforeText

			result(1) = New RadListDataItem("Germany")
			result(1).Image = Resources.DE
			result(1).TextImageRelation = TextImageRelation.ImageBeforeText

			result(2) = New RadListDataItem("India")
            result(2).Image = Resources._IN
			result(2).TextImageRelation = TextImageRelation.ImageBeforeText

			result(3) = New RadListDataItem("France")
			result(3).Image = Resources.FR
			result(3).TextImageRelation = TextImageRelation.ImageBeforeText

			result(4) = New RadListDataItem("USA")
			result(4).Image = Resources.US
			result(4).TextImageRelation = TextImageRelation.ImageBeforeText

			result(5) = New RadListDataItem("Russia")
			result(5).Image = Resources.RU
			result(5).TextImageRelation = TextImageRelation.ImageBeforeText

			result(6) = New RadListDataItem("Japan")
			result(6).Image = Resources.JP
			result(6).TextImageRelation = TextImageRelation.ImageBeforeText

			result(7) = New RadListDataItem("China")
			result(7).Image = Resources.CN
			result(7).TextImageRelation = TextImageRelation.ImageBeforeText

			result(8) = New RadListDataItem("Bulgaria")
			result(8).Image = Resources.BUL
			result(8).TextImageRelation = TextImageRelation.ImageBeforeText

			result(9) = New RadListDataItem("Switzerland")
			result(9).Image = Resources.CH
			result(9).TextImageRelation = TextImageRelation.ImageBeforeText

			Return result
		End Function

		Private Sub DataTable()
			Me.radListBoxDemo.DataSource = Nothing
			Me.radListBoxDemo.Items.Clear()
			Dim myDocumentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			Dim dt As DataTable = Me.FillFilesTable(myDocumentsPath)

			If dt.Rows.Count = 0 Then
				MessageBox.Show(String.Format("No files found in ""{0}"" ", myDocumentsPath), "No data in the table", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If

			Me.radListBoxDemo.DisplayMember = "FileName"
			Me.radListBoxDemo.ValueMember = "Length"
			Me.radListBoxDemo.DataSource = dt
		End Sub

		Private Sub Database()
			Me.LoadData()
			Me.radListBoxDemo.DataSource = Nothing
			Me.radListBoxDemo.Items.Clear()
			Me.radListBoxDemo.DisplayMember = "FirstName"
			Me.radListBoxDemo.ValueMember = "EmployeeID"
			Me.radListBoxDemo.DataSource = Me.nwindDataSet.Employees
			Me.radListBoxDemo.SelectedIndex = -1
		End Sub



		Private Sub BindToArray()
			Dim processes() As Process = Process.GetProcesses()

			Me.radListBoxDemo.DataSource = Nothing
			Me.radListBoxDemo.Items.Clear()
			Me.radListBoxDemo.DisplayMember = "ProcessName"
			Me.radListBoxDemo.DataSource = processes
		End Sub

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

		Private Sub LoadData()
			Try
				Me.employeesTableAdapter.Fill(Me.nwindDataSet.Employees)
			Catch exception1 As Exception
				Dim message As String = "To run this sample, you must have the Northwind database."
				Throw New DataException(message, exception1)
			End Try
		End Sub

		Private Sub OnRadioOptions_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
				Return
			End If

			If Me.radRadioArray.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.BindToArray()
			ElseIf Me.radRadioDataTable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.DataTable()
			ElseIf Me.radRadioDB.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.Database()
			ElseIf Me.radRadioUnbound.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.UnboundMode()
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radRadioArray.ToggleStateChanged, AddressOf OnRadioOptions_ToggleStateChanged
			AddHandler radRadioDB.ToggleStateChanged, AddressOf OnRadioOptions_ToggleStateChanged
			AddHandler radRadioDataTable.ToggleStateChanged, AddressOf OnRadioOptions_ToggleStateChanged
			AddHandler radRadioUnbound.ToggleStateChanged, AddressOf OnRadioOptions_ToggleStateChanged
		End Sub
	End Class

	Public Class Customer
		Public Sub New()
			Me.id_Renamed = -1
			Me.name_Renamed = String.Empty
		End Sub
		Public Sub New(ByVal id As Integer, ByVal name As String)
			Me.id_Renamed = id
			Me.name_Renamed = name
		End Sub
		'Fields
'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow class members with the same name:
		Private id_Renamed As Integer
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
		Private name_Renamed As String
		'Properties
		Public Property Id() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				id_Renamed = value
			End Set
		End Property

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property
	End Class
End Namespace