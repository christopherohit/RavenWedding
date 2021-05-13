Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports System.IO
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.CustomViews
	Public Class GridViewDetailElement
		Inherits GridVisualElement
		Implements IGridView
		#Region "Fields"

		Private gridElement As RadGridViewElement
'INSTANT VB NOTE: The variable viewInfo was renamed since Visual Basic does not allow class members with the same name:
		Private viewInfo_Renamed As GridViewInfo

		Private imagePrimitive As ReflectiveImagePrimitive
		Private groupBoxElement As RadGroupBoxElement

		Private labelPosition As RadLabelElement
		Private labelHireDate As RadLabelElement
		Private labelBirthDate As RadLabelElement
		Private labelNotes As LightVisualElement

		Private groupBoxStackLayout As StackLayoutElement
		Private groupBoxStackLayoutFirstColumn As StackLayoutElement

		#End Region

		#Region "Initialization"

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()

			Me.Padding = New Padding(10)
			Me.StretchHorizontally = True
			Me.MinSize = New Size(0, 190)
			Me.MaxSize = New Size(0, 190)
			Me.DrawFill = True
			Me.Class = "RowFill"
        End Sub

        Private Sub SetElementStyles()
            Me.DrawFill = True
            Me.BackColor = Color.Gray
            Me.GradientStyle = GradientStyles.Solid
            Me.groupBoxElement.BackColor = Color.White
            Me.groupBoxElement.ForeColor = Color.Black
            Me.groupBoxElement.Header.BackColor = Color.White
            Me.groupBoxElement.Header.ForeColor = Color.Black
            Me.groupBoxElement.Content.BackColor = Color.White
            Me.groupBoxElement.Content.ForeColor = Color.Black
            Me.labelPosition.BackColor = Color.White
            Me.labelPosition.ForeColor = Color.Black
            Me.labelBirthDate.BackColor = Color.White
            Me.labelBirthDate.ForeColor = Color.Black
            Me.labelHireDate.BackColor = Color.White
            Me.labelHireDate.ForeColor = Color.Black
            Me.labelNotes.BackColor = Color.White
            Me.labelNotes.ForeColor = Color.Black
        End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			Dim stack As New StackLayoutElement()
			stack.StretchVertically = True
			stack.StretchHorizontally = True
			stack.Orientation = Orientation.Horizontal
			stack.ElementSpacing = 10
			Me.Children.Add(stack)

			Me.imagePrimitive = New ReflectiveImagePrimitive()
			Me.imagePrimitive.StretchVertically = True
			stack.Children.Add(Me.imagePrimitive)

			Me.groupBoxElement = New RadGroupBoxElement()
			Me.groupBoxElement.Header.Font = New Font(Me.groupBoxElement.Header.Font.FontFamily, 10, FontStyle.Bold)
			Me.groupBoxElement.Content.Padding = New Padding(20)
			Me.groupBoxElement.StretchHorizontally = True
			Me.groupBoxElement.StretchVertically = True
			stack.Children.Add(Me.groupBoxElement)

			Me.groupBoxStackLayout = New StackLayoutElement()
			Me.groupBoxStackLayout.StretchHorizontally = True
			Me.groupBoxStackLayout.StretchVertically = True
			Me.groupBoxElement.Content.Children.Add(Me.groupBoxStackLayout)

			Me.groupBoxStackLayoutFirstColumn = New StackLayoutElement()
			Me.groupBoxStackLayoutFirstColumn.Orientation = Orientation.Vertical
			Me.groupBoxStackLayout.Children.Add(Me.groupBoxStackLayoutFirstColumn)

			Me.labelPosition = New RadLabelElement()
			Me.groupBoxStackLayoutFirstColumn.Children.Add(labelPosition)

			Me.labelBirthDate = New RadLabelElement()
			Me.groupBoxStackLayoutFirstColumn.Children.Add(labelBirthDate)

			Me.labelHireDate = New RadLabelElement()
			Me.groupBoxStackLayoutFirstColumn.Children.Add(labelHireDate)

			Me.labelNotes = New NoteElement()
			Me.groupBoxStackLayout.Children.Add(labelNotes)
		End Sub

		#End Region

		#Region "Properties"

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(GridTableHeaderRowElement)
			End Get
		End Property

		#End Region

		#Region "IGridView Members"

		Public Sub Initialize(ByVal gridElement As RadGridViewElement, ByVal viewInfo As GridViewInfo) Implements IGridView.Initialize
			Me.gridElement = gridElement
			Me.viewInfo_Renamed = viewInfo

            AddHandler gridElement.GridControl.CurrentRowChanged, AddressOf GridControl_CurrentRowChanged

            Me.SetElementStyles()
		End Sub

		Public Sub Detach() Implements IGridView.Detach
			RemoveHandler gridElement.GridControl.CurrentRowChanged, AddressOf GridControl_CurrentRowChanged
			Me.gridElement = Nothing
			Me.viewInfo_Renamed = Nothing
		End Sub

		Public Sub UpdateView() Implements IGridView.UpdateView
			Dim dataRow As GridViewDataRowInfo = TryCast(Me.GridViewElement.GridControl.CurrentRow, GridViewDataRowInfo)

			If dataRow IsNot Nothing Then
				Dim photo() As Byte = TryCast(dataRow.Cells("Photo").Value, Byte())
				Using originalImage As Image = ImageHelper.GetImageFromBytes(photo)
				Using bitmap2 As New Bitmap(originalImage)
					imagePrimitive.Image = bitmap2.GetThumbnailImage(100, 100, Nothing, IntPtr.Zero)
				End Using
				End Using

				Dim name As String = String.Format("{0} {1} {2}", dataRow.Cells("TitleOfCourtesy").Value, dataRow.Cells("FirstName").Value, dataRow.Cells("LastName").Value)
				Dim position As String = String.Format("<html><b>Position:</b><br/> {0} ", dataRow.Cells("Title").Value)
				Dim dateOfBirth As String = String.Format("<html><b>Date of Birth:</b><br/> {0:D}", dataRow.Cells("BirthDate").Value)
				Dim hiredDate As String = String.Format("<html><b>Date of Hire:</b><br/> {0:D}", dataRow.Cells("HireDate").Value)
				Dim notes As String = String.Format("<html><b>Notes: </b><br/> {0}", dataRow.Cells("Notes").Value)

				Me.groupBoxElement.HeaderText = name

				Me.labelPosition.Text = position
				Me.labelBirthDate.Text = dateOfBirth
				Me.labelHireDate.Text = hiredDate
				Me.labelNotes.Text = notes
			End If
		End Sub

		Public ReadOnly Property GridViewElement() As RadGridViewElement Implements IGridView.GridViewElement
			Get
				Return Me.gridElement
			End Get
		End Property

		Public ReadOnly Property ViewInfo() As GridViewInfo Implements IGridView.ViewInfo
			Get
				Return Me.viewInfo_Renamed
			End Get
		End Property

		#End Region

		#Region "Event Handlers"

		Private Sub GridControl_CurrentRowChanged(ByVal sender As Object, ByVal e As CurrentRowChangedEventArgs)
			Me.UpdateView()
		End Sub

		#End Region
	End Class
End Namespace
