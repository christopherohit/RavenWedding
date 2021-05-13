Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
	Public Class GridFilterExpandableCellElement
		Inherits GridRowHeaderCellElement
		#Region "Fields"

		Private expander As GridExpanderItem

		#End Region

		#Region "Initialization"

		Public Sub New(ByVal col As GridViewColumn, ByVal row As GridRowElement)
			MyBase.New(col, row)

		End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			Me.expander = New GridExpanderItem()
			Me.expander.SignStyle = SignStyles.Image
			Me.expander.DrawSignBorder = False
			AddHandler expander.PropertyChanged, AddressOf Expander_PropertyChanged
			Me.Children.Add(expander)
		End Sub

		Public Overrides Sub Initialize(ByVal column As GridViewColumn, ByVal row As GridRowElement)
			MyBase.Initialize(column, row)
			Me.expander.Expanded = Me.RowInfo.IsExpanded
			SetExpanderImageOrientation(Me.expander.Expanded)
		End Sub

		#End Region

		#Region "Properties"

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(GridGroupExpanderCellElement)
			End Get
		End Property

		#End Region

		#Region "Methods"

		Protected Overrides Sub UpdateImage()
			Me.Image = Nothing
		End Sub

		#End Region

		#Region "Layout"

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			MyBase.ArrangeOverride(finalSize)

			Dim clientRect As RectangleF = Me.GetClientRectangle(finalSize)

			Dim expanderWidth As Single = Me.expander.DesiredSize.Width
			Dim imgLeftPos As Single = clientRect.X + (clientRect.Width - expanderWidth) / 2

			Dim expanderHeight As Single = Me.expander.DesiredSize.Height
			Dim imgTopPos As Single = clientRect.Y + (clientRect.Height - expanderHeight) / 2

			Dim imgArea As New RectangleF(imgLeftPos, imgTopPos, expanderWidth, expanderHeight)
			Me.expander.Arrange(imgArea)

			Return finalSize
		End Function

		#End Region

		#Region "Event Handlers"

		Private Sub Expander_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
			If Me.RowInfo IsNot Nothing Then
				Me.RowInfo.IsExpanded = expander.Expanded
			End If
		End Sub

		Protected Overrides Sub OnRowPropertyChanged(ByVal e As System.ComponentModel.PropertyChangedEventArgs)
			MyBase.OnRowPropertyChanged(e)
			Me.expander.Expanded = Me.RowInfo.IsExpanded
			SetExpanderImageOrientation(Me.expander.Expanded)
		End Sub

		Private Sub SetExpanderImageOrientation(ByVal isExpanded As Boolean)
			If isExpanded Then
				Me.expander.SignImage = My.Resources.chevron_up
			Else
				Me.expander.SignImage = My.Resources.chevron_down
			End If
		End Sub

		#End Region
	End Class
End Namespace
