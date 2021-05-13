Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Hierarchy.Hierarchy
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			ordersTableAdapter.Fill(nwindDataSet.Orders)
			customersTableAdapter.Fill(nwindDataSet.Customers)
			suppliersTableAdapter.Fill(nwindDataSet.Suppliers)
			productsTableAdapter.Fill(nwindDataSet.Products)
			order_DetailsTableAdapter.Fill(nwindDataSet.Order_Details)
			employeesTableAdapter.Fill(nwindDataSet.Employees)

			Me.radRadioManuallyUnbound.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub OnRadioScenarios_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
				Return
			End If

			If Me.radRadioHierarchyFromDataSet.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.CreateAutoGenerateHierarchy()
				SetupFiltering(radGridView1.MasterTemplate, True)
			ElseIf Me.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.CreateBoundHierarchy()
				SetupFiltering(radGridView1.MasterTemplate, True)
			ElseIf Me.radRadioManuallyUnbound.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.CreateUnboundHierarchy()
				SetupFiltering(radGridView1.MasterTemplate, False)
			End If
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.UseScrollbarsInHierarchy = True
			Else
				Me.radGridView1.UseScrollbarsInHierarchy = False
			End If
		End Sub

		Private Sub radCheckBox2_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				UpdateChildViewCaptionVisibility(True)
			Else
				UpdateChildViewCaptionVisibility(False)
			End If
		End Sub

		Private Sub UpdateChildViewCaptionVisibility(ByVal visible As Boolean)
			Dim template As GridViewTemplate = Me.radGridView1.MasterTemplate
			Do
				template.ShowChildViewCaptions = visible
				If template.Templates.Count = 0 Then
					Exit Do
				End If
				template = template.Templates(0)
			Loop
		End Sub

		#Region "Create Hierarchy"

		Private Sub CreateAutoGenerateHierarchy()
			Using Me.radGridView1.DeferRefresh()
				Me.radGridView1.MasterTemplate.Reset()

				Me.radGridView1.TableElement.RowHeight = 20
				Me.radGridView1.DataMember = "Customers"
				Me.radGridView1.DataSource = nwindDataSet
				Me.radGridView1.AutoGenerateHierarchy = True
				Me.SetupMasterForAutoGenerateHierarchy()
			End Using
		End Sub

		Private Sub CreateBoundHierarchy()
			Using Me.radGridView1.DeferRefresh()
				Me.radGridView1.MasterTemplate.Reset()

				Me.radGridView1.TableElement.RowHeight = 20
				Me.radGridView1.DataSource = nwindDataSet.Suppliers
				Me.radGridView1.MasterTemplate.Columns("CompanyName").HeaderText = "Company Name"
				Me.radGridView1.MasterTemplate.Columns("ContactName").HeaderText = "Contact Name"
				Me.radGridView1.MasterTemplate.Columns("SupplierID").IsVisible = False
				Me.radGridView1.MasterTemplate.Columns("Fax").IsVisible = False
				Me.radGridView1.MasterTemplate.Columns("ContactTitle").IsVisible = False
				Me.radGridView1.MasterTemplate.Columns("Region").IsVisible = False
				Me.radGridView1.MasterTemplate.Columns("City").IsVisible = False
				Me.radGridView1.MasterTemplate.Columns("PostalCode").IsVisible = False
				Me.radGridView1.MasterTemplate.Columns("HomePage").IsVisible = False
				Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

				Dim template As New GridViewTemplate()
				template.DataSource = nwindDataSet.Products
				Me.radGridView1.Templates.Add(template)
				template.Columns("ProductName").HeaderText = "Product Name"
				template.Columns("QuantityPerUnit").HeaderText = "Quantity Per Unit"
				template.Columns("QuantityPerUnit").TextAlignment = ContentAlignment.MiddleCenter
				template.Columns("UnitPrice").HeaderText = "Unit Price"
				template.Columns("UnitPrice").FormatString = "${0:F2}"
				template.Columns("ProductID").IsVisible = False
				template.Columns("SupplierID").IsVisible = False
				template.Columns("CategoryID").IsVisible = False
				template.Columns("UnitsInStock").IsVisible = False
				template.Columns("UnitsOnOrder").IsVisible = False
				template.Columns("ReorderLevel").IsVisible = False
				template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

				Dim relation As New GridViewRelation(radGridView1.MasterTemplate, template)
				relation.RelationName = "SuppliersProducts"
				relation.ParentColumnNames.Add("SupplierID")
				relation.ChildColumnNames.Add("SupplierID")
				Me.radGridView1.Relations.Add(relation)
			End Using
		End Sub

		Private Sub CreateUnboundHierarchy()
			Using Me.radGridView1.DeferRefresh()
				Me.radGridView1.MasterTemplate.Reset()

				SetupMasterForUnbound()

				Dim template As GridViewTemplate = SetupChildForUnbound()
				Dim relation As New GridViewRelation(Me.radGridView1.MasterTemplate, template)
				relation.RelationName = "EmployeesOrders"
				relation.ParentColumnNames.Add("Name")
				relation.ChildColumnNames.Add("Name")
				radGridView1.Relations.Add(relation)
			End Using

			Me.radGridView1.ChildRows(0).IsExpanded = True
		End Sub

		#End Region

		#Region "Setup Templates"

		Private Sub SetupFiltering(ByVal template As GridViewTemplate, ByVal enableFiltering As Boolean)
			template.EnableFiltering = enableFiltering

			For i As Integer = 0 To template.Templates.Count - 1
				SetupFiltering(template.Templates(i), enableFiltering)
			Next i
		End Sub

		Private Sub SetupMasterForAutoGenerateHierarchy()
			Me.radGridView1.MasterTemplate.Columns("CompanyName").HeaderText = "Company Name"
			Me.radGridView1.MasterTemplate.Columns("ContactName").HeaderText = "Contact Name"
			Me.radGridView1.MasterTemplate.Columns("CustomerID").IsVisible = False
			Me.radGridView1.MasterTemplate.Columns("ContactTitle").IsVisible = False
			Me.radGridView1.MasterTemplate.Columns("Region").IsVisible = False
			Me.radGridView1.MasterTemplate.Columns("PostalCode").IsVisible = False
			Me.radGridView1.MasterTemplate.Columns("Country").IsVisible = False
			Me.radGridView1.MasterTemplate.Columns("Fax").IsVisible = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Dim template As GridViewTemplate = Me.radGridView1.MasterTemplate.Templates(0)
			template.Columns("OrderID").HeaderText = "Order ID"
			template.Columns("ShipAddress").HeaderText = "Ship Address"
			template.Columns("OrderDate").HeaderText = "Order Date"
			template.Columns("OrderDate").TextAlignment = ContentAlignment.MiddleRight
			template.Columns("OrderDate").FormatString = "{0: ddd, MM/dd}"
			template.Columns("CustomerID").IsVisible = False
			template.Columns("EmployeeID").IsVisible = False
			template.Columns("RequiredDate").IsVisible = False
			template.Columns("ShippedDate").IsVisible = False
			template.Columns("ShipVia").IsVisible = False
			template.Columns("ShipName").IsVisible = False
			template.Columns("ShipCity").IsVisible = False
			template.Columns("ShipRegion").IsVisible = False
			template.Columns("ShipPostalCode").IsVisible = False
			template.Columns("ShipCity").IsVisible = False
			template.Columns("ShipName").IsVisible = False
			template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			template = Me.radGridView1.MasterTemplate.Templates(0).Templates(0)
			template.Columns("UnitPrice").FormatString = "${0:F2}"
			template.Columns("Discount").FormatString = "{0:0.00%;0.00%;none}"
			template.Columns("ProductID").IsVisible = False
			template.Columns("OrderID").HeaderText = "Order ID"
			template.Columns("UnitPrice").HeaderText = "Unit Price"
			template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
		End Sub

		Private Function SetupChildForUnbound() As GridViewTemplate
			Dim template As New GridViewTemplate()
			template.AllowAddNewRow = True

			Dim textBoxColumn As New GridViewTextBoxColumn("Name")
			textBoxColumn.HeaderText = "Name"
			template.Columns.Add(textBoxColumn)

			Dim productNumberColumn As New GridViewDecimalColumn("Product Number")
			productNumberColumn.HeaderText = "Product Number"
			productNumberColumn.DecimalPlaces = 0
			productNumberColumn.FormatString = "#{0}"
			template.Columns.Add(productNumberColumn)

			Dim decimalChildColumn1 As New GridViewDecimalColumn("Quantity")
			decimalChildColumn1.HeaderText = "Quantity"
			template.Columns.Add(decimalChildColumn1)

			Dim decimalChildColumn2 As New GridViewDecimalColumn("Discount")
			decimalChildColumn2.HeaderText = "Discount"
			decimalChildColumn2.FormatString = "{0:F2}%"
			template.Columns.Add(decimalChildColumn2)

			Dim decimalChildColumn3 As New GridViewDecimalColumn("Total")
			decimalChildColumn3.HeaderText = "Total"
			decimalChildColumn3.FormatString = "${0}"
			template.Columns.Add(decimalChildColumn3)
			Me.radGridView1.Templates.Add(template)

			LoadDataForUnbound()
			template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Return template
		End Function

		Private Sub SetupMasterForUnbound()
			Me.radGridView1.TableElement.RowHeight = 60

			Dim column As New GridViewImageColumn("Photo")
			column.ImageLayout = ImageLayout.Zoom
			column.HeaderText = "Photo"
			Me.radGridView1.MasterTemplate.Columns.Add(column)

			Dim textColumn1 As New GridViewTextBoxColumn("Name")
			textColumn1.Width = 150
			textColumn1.HeaderText = "Name"
			Me.radGridView1.MasterTemplate.Columns.Add(textColumn1)

			Dim decimalColumn As New GridViewDecimalColumn("Salary")
			decimalColumn.HeaderText = "Salary"
			decimalColumn.FormatString = "${0:#,###}"
			Me.radGridView1.MasterTemplate.Columns.Add(decimalColumn)

			Dim dateTimeColumn As New GridViewDateTimeColumn("Hire Date")
			dateTimeColumn.Width = 100
			dateTimeColumn.TextAlignment = ContentAlignment.MiddleRight
			dateTimeColumn.HeaderText = "Hire Date"
			Me.radGridView1.MasterTemplate.Columns.Add(dateTimeColumn)

			Dim textColumn2 As New GridViewTextBoxColumn("Title")
			textColumn2.Width = 150
			textColumn2.HeaderText = "Title"
			Me.radGridView1.MasterTemplate.Columns.Add(textColumn2)

			Me.radGridView1.MasterTemplate.Columns.Add(New GridViewCheckBoxColumn("Active"))
		End Sub

		Private Sub LoadDataForUnbound()
            Dim random As New Random(CInt(Fix(Date.Now.Second)))
			Dim template As GridViewTemplate = Me.radGridView1.MasterTemplate.Templates(0)

			For i As Integer = 0 To nwindDataSet.Employees.Count - 1
				Dim row As Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow = nwindDataSet.Employees(i)
				Dim name As String = row.FirstName & " " & row.LastName

				Me.radGridView1.MasterTemplate.Rows.Add(GetImageFromBytes(row.Photo), name, random.Next(45000), row.HireDate, row.Title, (random.Next(100) > 50))

				Dim rowCount As Integer = random.Next(20)
				Do While rowCount <= 0
					rowCount = random.Next(20)
				Loop

				For j As Integer = 0 To rowCount - 1
					template.Rows.Add(name, random.Next(1000), random.Next(50), random.Next(100), random.Next(10000))
				Next j
			Next i
		End Sub

		Private Function GetImageFromBytes(ByVal bytes() As Byte) As Image
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

		Protected Overrides Sub WireEvents()
			AddHandler radRadioHierarchyFromDataSet.ToggleStateChanged, AddressOf OnRadioScenarios_ToggleStateChanged
			AddHandler radRadioManuallyUnbound.ToggleStateChanged, AddressOf OnRadioScenarios_ToggleStateChanged
			AddHandler radRadioButton2.ToggleStateChanged, AddressOf OnRadioScenarios_ToggleStateChanged
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
			AddHandler radCheckBox2.ToggleStateChanged, AddressOf radCheckBox2_ToggleStateChanged
		End Sub
	End Class
End Namespace
