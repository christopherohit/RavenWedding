Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.Editors

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.DropDownResizing
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private showDropDownTimeout As Timer

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radComboDemo.ListElement.AutoSizeItems = True
			Me.showDropDownTimeout = New Timer(Me.components)
			AddHandler showDropDownTimeout.Tick, AddressOf showDropDownTimeout_Tick
			Me.showDropDownTimeout.Interval = 1000
			Me.SelectedControl = Me.radComboDemo
			Me.radComboDemo.DefaultItemsCountInDropDown = 20
			Me.radRadioNone.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			AddHandler radComboDemo.ItemDataBound, AddressOf radComboDemo_ItemDataBound

			Me.LoadData()
			Me.showDropDownTimeout.Start()
			Me.radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.None
		End Sub

		Private Sub radComboDemo_ItemDataBound(ByVal sender As Object, ByVal e As ListItemDataBoundEventArgs)
			Dim item As RadListDataItem = e.NewItem
            item.Text &= " " & (TryCast(item.DataBoundItem, DataRowView))("FirstName").ToString()

			Dim row As Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow = (TryCast((TryCast(item.DataBoundItem, DataRowView)).Row, Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow))

			item.TextImageRelation = TextImageRelation.ImageBeforeText
			item.Image = GetImageFromData(row.Photo)

			item.Font = New Font("Arial", 10, FontStyle.Bold)
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

		Protected Overrides Sub WireEvents()
			AddHandler radRadioUpDown.ToggleStateChanged, AddressOf OnRadioSizingMode_ToggleStateChanged
			AddHandler radRadioBottomUpDown.ToggleStateChanged, AddressOf OnRadioSizingMode_ToggleStateChanged
			AddHandler radRadioRightBottom.ToggleStateChanged, AddressOf OnRadioSizingMode_ToggleStateChanged
			AddHandler radRadioNone.ToggleStateChanged, AddressOf OnRadioSizingMode_ToggleStateChanged
		End Sub

		Private Function HasOleContainerHeader(ByVal imageByteArray() As Byte) As Boolean
			Const OleByte0 As Byte = 21
			Const OleByte1 As Byte = 28
			Return (imageByteArray(0) = OleByte0) AndAlso (imageByteArray(1) = OleByte1)
		End Function

		Private Sub LoadData()
			Try
				Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)
			Catch exception1 As Exception
				Dim message As String = "To run this sample, you must have SQL Server with the Northwind database installed."
				Throw New DataException(message, exception1)
			End Try
		End Sub

		Private Sub showDropDownTimeout_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radComboDemo.DropDownListElement.TextBox.TextBoxItem.Focus()
			Me.radComboDemo.ShowDropDown()
			Me.showDropDownTimeout.Stop()
		End Sub

		Private Sub OnRadioSizingMode_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If radRadioNone.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.None

			ElseIf radRadioRightBottom.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.RightBottom

			ElseIf radRadioUpDown.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown

			ElseIf radRadioBottomUpDown.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDownAndRightBottom
			End If
		End Sub
	End Class
End Namespace
