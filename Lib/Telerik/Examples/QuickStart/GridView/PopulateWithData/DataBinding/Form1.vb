Imports System.Collections
Imports System.ComponentModel
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.OleDb
Imports Telerik.WinControls
Imports Telerik.Examples.WinControls.DataSources
Imports System.Threading

Namespace Telerik.Examples.WinControls.GridView.PopulateWithData.DataBinding
	Partial Public Class Form1
		Inherits ExamplesForm
		Private list1 As New ArrayList()
		Private list2 As New BindingList(Of StudentObject)()
		Private list3 As New ArrayList()
		Private [set] As NorthwindDataSet
		Private adapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter

		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			SetPreferences()
			BindToDataReader()
		End Sub

		Private Sub SetPreferences()
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.MasterTemplate.EnableGrouping = False
			Me.radGridView1.EnableHotTracking = True
			Me.radRadioDataReader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub BindToDataReader()
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = True

			Me.radGridView1.TableElement.BeginUpdate()

			Using command As New OleDbCommand("SELECT CompanyName, ContactName, ContactTitle, Address, PostalCode FROM Customers")
                command.Connection = New OleDbConnection(Settings.Default.NwindConnectionString)
				command.Connection.Open()
				Me.radGridView1.MasterTemplate.LoadFrom(command.ExecuteReader())
				command.Connection.Close()
			End Using

			For i As Integer = 0 To radGridView1.MasterTemplate.Columns.Count - 1
				Me.radGridView1.MasterTemplate.Columns(i).Width = 102
			Next i

			Me.radGridView1.Columns("ContactName").HeaderText = "Contact Name"
			Me.radGridView1.Columns("CompanyName").HeaderText = "Company Name"
			Me.radGridView1.Columns("ContactTitle").HeaderText = "Contact Title"
			Me.radGridView1.Columns("PostalCode").HeaderText = "Postal Code"

			Me.radGridView1.TableElement.EndUpdate()
		End Sub

		Private Sub BindToArrayList()
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = True

			If list1.Count = 0 Then
				list1.Add(New ValueType(Of String)("Asparagus"))
				list1.Add(New ValueType(Of String)("Broccoli"))
				list1.Add(New ValueType(Of String)("Cabbage"))
				list1.Add(New ValueType(Of String)("Carrots"))
				list1.Add(New ValueType(Of String)("Corn, yellow"))
				list1.Add(New ValueType(Of String)("Cucumbers"))
				list1.Add(New ValueType(Of String)("Eggplant"))
				list1.Add(New ValueType(Of String)("Garlic"))
				list1.Add(New ValueType(Of String)("Green peas"))
				list1.Add(New ValueType(Of String)("Mushrooms"))
				list1.Add(New ValueType(Of String)("Onions"))
				list1.Add(New ValueType(Of String)("Olives"))
				list1.Add(New ValueType(Of String)("Potatoes"))
				list1.Add(New ValueType(Of String)("Spinach"))
				list1.Add(New ValueType(Of String)("Tomatoes"))
				list1.Add(New ValueType(Of String)("Yams"))
			End If

			Me.radGridView1.DataSource = list1

			If Me.radGridView1.Columns.Count > 0 Then
				Me.radGridView1.Columns(0).Width = 200
				Me.radGridView1.Columns(0).HeaderText = "Vegetables"
			End If
		End Sub

		Private Sub BindToCustomObjects()
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = True

			If list2.Count = 0 Then
				list2.Add(New StudentObject("Brent", "Allen", 175.4f, 72.0f, 16))
				list2.Add(New StudentObject("Carolina", "Bailey", 160.7f, 46.0f, 18))
				list2.Add(New StudentObject("Whitney", "Barnebey", 157.0f, 40.0f, 15))
				list2.Add(New StudentObject("Sarah", "Beckham", 165.1f, 48.0f, 16))
				list2.Add(New StudentObject("Dun", "Deng", 173.4f, 70.5f, Nothing))
				list2.Add(New StudentObject("Tu-Lin", "Chiu", 150.4f, 40.5f, 12))
				list2.Add(New StudentObject("Alexandra", "Galambos", 152.4f, 42.0f, Nothing))
				list2.Add(New StudentObject("Tammy", "Goss", 175.4f, 75.3f, 18))
				list2.Add(New StudentObject("Iljo", "Ha", 178.4f, 74.0f, 17))
				list2.Add(New StudentObject("Merdith", "Johnson", 180.4f, 68.0f, 17))
				list2.Add(New StudentObject("Yoon", "Jeon", 182.4f, 80.0f, 18))
				list2.Add(New StudentObject("Blake", "Rodgers", 154.4f, 46.0f, 12))
				list2.Add(New StudentObject("Rebecca", "Shields", 175.4f, 60.0f, Nothing))
				list2.Add(New StudentObject("Erica", "Sim", 175.8f, 72.6f, 18))
				list2.Add(New StudentObject("Xiaoyi", "Sun", 167.4f, 53.0f, 16))
			End If

			Me.radGridView1.DataSource = list2

			Me.radGridView1.Columns("FirstName").HeaderText = "First Name"
			Me.radGridView1.Columns("LastName").HeaderText = "Last Name"
			Me.radGridView1.Columns("Age").TextAlignment = ContentAlignment.MiddleRight
			Me.radGridView1.Columns("Age").FormatString = "{0} y/o"
			Me.radGridView1.Columns("Weight").TextAlignment = ContentAlignment.MiddleRight
			Me.radGridView1.Columns("Weight").FormatString = "{0} kg."


		End Sub

		Private Sub BindToSubObjects()
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = False

			Me.radGridView1.DataSource = Nothing

			Me.radGridView1.TableElement.BeginUpdate()
			Me.radGridView1.MasterTemplate.Columns.Clear()
			Me.radGridView1.MasterTemplate.Columns.Add(New GridViewTextBoxColumn("Name", "CustomerName"))
			Me.radGridView1.MasterTemplate.Columns.Add(New GridViewTextBoxColumn("Address.City", "Address.City"))
			Me.radGridView1.MasterTemplate.Columns.Add(New GridViewTextBoxColumn("Address.Country", "Address.Country"))
			Me.radGridView1.MasterTemplate.Columns.Add(New GridViewTextBoxColumn("Address.ContactDetails.Phone", "Address.ContactDetails.Phone"))

			For i As Integer = 0 To radGridView1.MasterTemplate.Columns.Count - 1
				Me.radGridView1.MasterTemplate.Columns(i).Width = 150
			Next i
			Me.radGridView1.TableElement.EndUpdate(False)

			If list3.Count = 0 Then
				list3.Add(New Customer(1, "Maria Anders", "Alfreds Futterkiste", "Germany", "Berlin", "12209", "030-0074321"))
				list3.Add(New Customer(2, "Roland Mendel", "Ernst Handel", "Austria", "Graz", "8010", "7675-3425"))
				list3.Add(New Customer(3, "Thomas Hardy", "Around the Horn", "UK", "London", "WA1 1DP", "(171) 555-7788"))
				list3.Add(New Customer(4, "Laurence Lebihan", "Bon app'", "France", "Marseille", "13008", "91.24.45.40"))
				list3.Add(New Customer(5, "Carine Schmitt", "France restauration", "France", "Nantes", "44000", "40.32.21.21"))
			End If

			Me.radGridView1.DataSource = list3

			Me.radGridView1.Columns(3).Width = 200
		End Sub

		Private Sub BindToDataSet()
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = True

			If [set] Is Nothing Then
				[set] = New NorthwindDataSet()
				adapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
				adapter.Fill([set].Employees)
			End If
			radGridView1.DataSource = [set].Employees

			radGridView1.Columns("EmployeeID").IsVisible = False
			radGridView1.Columns("TitleOfCourtesy").IsVisible = False
			radGridView1.Columns("BirthDate").IsVisible = False
			radGridView1.Columns("HireDate").IsVisible = False
			radGridView1.Columns("Address").IsVisible = False
			radGridView1.Columns("Region").IsVisible = False
			radGridView1.Columns("HomePhone").IsVisible = False
			radGridView1.Columns("Extension").IsVisible = False
			radGridView1.Columns("Photo").IsVisible = False
			radGridView1.Columns("Notes").IsVisible = False
			radGridView1.Columns("ReportsTo").IsVisible = False

			radGridView1.Columns("LastName").HeaderText = "Last Name"
			radGridView1.Columns("FirstName").HeaderText = "First Name"
			radGridView1.Columns("PostalCode").HeaderText = "Postal Code"
		End Sub

		Public Class StudentObject
			Implements INotifyPropertyChanged
'INSTANT VB NOTE: The variable firstName was renamed since Visual Basic does not allow class members with the same name:
			Private firstName_Renamed As String
'INSTANT VB NOTE: The variable lastName was renamed since Visual Basic does not allow class members with the same name:
			Private lastName_Renamed As String
'INSTANT VB NOTE: The variable height was renamed since Visual Basic does not allow class members with the same name:
			Private height_Renamed As Single
'INSTANT VB NOTE: The variable weight was renamed since Visual Basic does not allow class members with the same name:
			Private weight_Renamed As Single
'INSTANT VB NOTE: The variable age was renamed since Visual Basic does not allow class members with the same name:
			Private age_Renamed? As Integer

			Public Sub New(ByVal iFname As String, ByVal iLname As String, ByVal iHeight As Single, ByVal iWeight As Single, ByVal iAge? As Integer)
				Me.firstName_Renamed = iFname
				Me.lastName_Renamed = iLname
				Me.height_Renamed = iHeight
				Me.weight_Renamed = iWeight
				Me.age_Renamed = iAge
			End Sub

			Public Property FirstName() As String
				Get
					Return Me.firstName_Renamed
				End Get
				Set(ByVal value As String)
					If Me.firstName_Renamed <> value Then
						Me.firstName_Renamed = value
						OnPropertyChanged("FirstName")
					End If
				End Set
			End Property

			Public Property LastName() As String
				Get
					Return Me.lastName_Renamed
				End Get
				Set(ByVal value As String)
					If Me.lastName_Renamed <> value Then
						Me.lastName_Renamed = value
						OnPropertyChanged("LastName")
					End If
				End Set
			End Property

			Public Property Age() As Integer?
				Get
					Return Me.age_Renamed
				End Get
				Set(ByVal value? As Integer)
					If Me.age_Renamed <> value Then
						Me.age_Renamed = value
						OnPropertyChanged("Age")
					End If
				End Set
			End Property

			Public Property Height() As Single
				Get
					Return Me.height_Renamed
				End Get
				Set(ByVal value As Single)
					If Me.height_Renamed <> value Then
						Me.height_Renamed = value
						OnPropertyChanged("Height")
					End If
				End Set
			End Property

			Public Property Weight() As Single
				Get
					Return Me.weight_Renamed
				End Get
				Set(ByVal value As Single)
					If Me.weight_Renamed <> value Then
						Me.weight_Renamed = value
						OnPropertyChanged("Weight")
					End If
				End Set
			End Property

			#Region "INotifyPropertyChanged Members"

			Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

			Protected Sub OnPropertyChanged(ByVal propertyName As String)
				OnPropertyChanged(New PropertyChangedEventArgs(propertyName))
			End Sub

			Protected Overridable Sub OnPropertyChanged(ByVal e As PropertyChangedEventArgs)
				RaiseEvent PropertyChanged(Me, e)
			End Sub

			#End Region
		End Class

		Public Class ValueType(Of T)
'INSTANT VB NOTE: The variable item was renamed since Visual Basic does not allow class members with the same name:
			Private item_Renamed As T

			Public Sub New()

			End Sub

			Public Sub New(ByVal item As T)
				Me.item_Renamed = item
			End Sub

			Public Property Item() As T
				Get
					Return Me.item_Renamed
				End Get
				Set(ByVal value As T)
					Me.item_Renamed = value
				End Set
			End Property
		End Class

		Public Class ContactDetails
'INSTANT VB NOTE: The variable postalCode was renamed since Visual Basic does not allow class members with the same name:
			Private postalCode_Renamed As String
'INSTANT VB NOTE: The variable phone was renamed since Visual Basic does not allow class members with the same name:
			Private phone_Renamed As String

			Public Property PostalCode() As String
				Get
					Return postalCode_Renamed
				End Get
				Set(ByVal value As String)
					postalCode_Renamed = value
				End Set
			End Property

			Public Property Phone() As String
				Get
					Return phone_Renamed
				End Get
				Set(ByVal value As String)
					phone_Renamed = value
				End Set
			End Property

			Public Sub New()
			End Sub

			Public Sub New(ByVal postalCode As String, ByVal phone As String)
				Me.postalCode_Renamed = postalCode
				Me.phone_Renamed = phone
			End Sub
		End Class

		Public Class Address
'INSTANT VB NOTE: The variable country was renamed since Visual Basic does not allow class members with the same name:
			Private country_Renamed As String
'INSTANT VB NOTE: The variable city was renamed since Visual Basic does not allow class members with the same name:
			Private city_Renamed As String
'INSTANT VB NOTE: The variable contactDetails was renamed since Visual Basic does not allow class members with the same name:
			Private contactDetails_Renamed As ContactDetails

			Public Property Country() As String
				Get
					Return country_Renamed
				End Get
				Set(ByVal value As String)
					country_Renamed = value
				End Set
			End Property

			Public Property City() As String
				Get
					Return city_Renamed
				End Get
				Set(ByVal value As String)
					city_Renamed = value
				End Set
			End Property

			Public ReadOnly Property ContactDetails() As ContactDetails
				Get
					Return Me.contactDetails_Renamed
				End Get
			End Property

			Public Sub New()
				Me.contactDetails_Renamed = New ContactDetails()
			End Sub

			Public Sub New(ByVal country As String, ByVal city As String, ByVal postalCode As String, ByVal phone As String)
				Me.country_Renamed = country
				Me.city_Renamed = city
				Me.contactDetails_Renamed = New ContactDetails(postalCode, phone)
			End Sub
		End Class

		Public Class Customer
'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow class members with the same name:
			Private id_Renamed As Integer
'INSTANT VB NOTE: The variable customerName was renamed since Visual Basic does not allow class members with the same name:
			Private customerName_Renamed As String
'INSTANT VB NOTE: The variable companyName was renamed since Visual Basic does not allow class members with the same name:
			Private companyName_Renamed As String
'INSTANT VB NOTE: The variable address was renamed since Visual Basic does not allow class members with the same name:
			Private address_Renamed As Address

			Public Property ID() As Integer
				Get
					Return Me.id_Renamed
				End Get
				Set(ByVal value As Integer)
					Me.id_Renamed = value
				End Set
			End Property

			Public Property CustomerName() As String
				Get
					Return Me.customerName_Renamed
				End Get
				Set(ByVal value As String)
					Me.customerName_Renamed = value
				End Set
			End Property

			Public Property CompanyName() As String
				Get
					Return Me.companyName_Renamed
				End Get
				Set(ByVal value As String)
					Me.companyName_Renamed = value
				End Set
			End Property

			Public ReadOnly Property Address() As Address
				Get
					Return Me.address_Renamed
				End Get
			End Property

			Public Sub New()
				Me.address_Renamed = New Address()
			End Sub

			Public Sub New(ByVal id As Integer, ByVal customerName As String, ByVal companyName As String, ByVal country As String, ByVal city As String, ByVal postalCode As String, ByVal phone As String)
				Me.id_Renamed = id
				Me.customerName_Renamed = customerName
				Me.companyName_Renamed = companyName
				Me.address_Renamed = New Address(country, city, postalCode, phone)
			End Sub
		End Class

		Private Sub radRadio_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radGridView1.MasterTemplate.Columns.Clear()
			Me.radGridView1.GroupDescriptors.Clear()
			Me.radGridView1.SortDescriptors.Clear()
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = False
			Me.radGridView1.DataSource = Nothing

			If radRadioDataReader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				BindToDataReader()
			End If

			If radRadioObjects.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				BindToCustomObjects()
			End If

			If radRadioSubObj.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				BindToSubObjects()
			End If

			If radRadioArrLst.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				BindToArrayList()
			End If

			If radRadioDataSet.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				BindToDataSet()
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radRadioArrLst.ToggleStateChanged, AddressOf radRadio_ToggleStateChanged
			AddHandler radRadioSubObj.ToggleStateChanged, AddressOf radRadio_ToggleStateChanged
			AddHandler radRadioObjects.ToggleStateChanged, AddressOf radRadio_ToggleStateChanged
			AddHandler radRadioDataReader.ToggleStateChanged, AddressOf radRadio_ToggleStateChanged
		End Sub
	End Class
End Namespace
