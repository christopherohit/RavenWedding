Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI


Namespace Telerik.Examples.WinControls.TreeView.ManipulateData.Editing
	''' <summary>
	''' Form code
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radTreeView1
		End Sub

		Private Sub LoadData()
			Dim table As New DataTable()
			table.Columns.Add("ID", GetType(Integer))
			table.Columns.Add("ParentID", GetType(Integer))
			table.Columns.Add("PropertyName", GetType(String))
			table.Columns.Add("PropertyValue", GetType(PropertyHelper))

			Me.radPanel1.PanelElement.PanelText.ForeColor = Color.White

			table.Rows.Add(0, Nothing, "Panel", Nothing)
			table.Rows.Add(1, 0, "Text", New PropertyHelper(radPanel1, "Text"))
			table.Rows.Add(2, 0, "Appearance", Nothing)
			table.Rows.Add(3, 0, "Shape", Nothing)
			table.Rows.Add(4, 2, "Fore color", New PropertyHelper(radPanel1.PanelElement.PanelText, "ForeColor"))
			table.Rows.Add(5, 2, "Back color", New PropertyHelper(radPanel1.PanelElement.PanelFill, "BackColor"))
			table.Rows.Add(6, 2, "Border color", New PropertyHelper(radPanel1.PanelElement.PanelBorder, "ForeColor"))
			table.Rows.Add(7, 2, "Border width", New PropertyHelper(radPanel1.PanelElement.PanelBorder, "Width"))
			table.Rows.Add(8, 3, "Corner radius", New PropertyHelper(radPanel1.PanelElement, "Shape"))

			Me.radTreeView1.ChildMember = "ID"
			Me.radTreeView1.ParentMember = "ParentID"
			Me.radTreeView1.DisplayMember = "PropertyValue"
			Me.radTreeView1.DataSource = table
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.AutoScroll = False

			MyBase.OnLoad(e)
			LoadData()
			AddHandler radTreeView1.NodeFormatting, AddressOf radTreeView1_NodeFormatting
			AddHandler radTreeView1.ValueChanging, AddressOf radTreeView1_ValueChanging
			AddHandler radTreeView1.Editing, AddressOf radTreeView1_Editing
			AddHandler radTreeView1.EditorInitialized, AddressOf radTreeView1_EditorInitialized
			AddHandler radTreeView1.EditorRequired, AddressOf radTreeView1_EditorRequired
			Me.radTreeView1.ItemHeight = 27
			Me.radTreeView1.AllowAdd = False
			Me.radTreeView1.AllowRemove = False
			Me.radTreeView1.ExpandAnimation = ExpandAnimation.None
			Me.radTreeView1.AllowDefaultContextMenu = True
			Me.radTreeView1.ExpandAll()
		End Sub

		Private Sub radTreeView1_Editing(ByVal sender As Object, ByVal e As TreeNodeEditingEventArgs)
			Dim helper As PropertyHelper = TryCast(e.Node.Value, PropertyHelper)
			If helper Is Nothing Then
				e.Cancel = True
			End If
		End Sub

		Private Sub radCheckBoxAllowEdit_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTreeView1.AllowEdit = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radTreeView1_NodeFormatting(ByVal sender As Object, ByVal args As TreeNodeFormattingEventArgs)
			Dim rowView As DataRowView = CType(args.Node.DataBoundItem, DataRowView)
			Dim propertyName As String = CStr(rowView("PropertyName"))
			Dim propertyValue As Object = rowView("PropertyValue")

			If propertyValue IsNot DBNull.Value Then
				If args.NodeElement.Children.Count = 4 Then
					Dim descriptionElement As New LightVisualElement()
					descriptionElement.StretchHorizontally = False
					descriptionElement.Font = (CType(args.NodeElement.Children(3), LightVisualElement)).Font
					descriptionElement.TextAlignment = ContentAlignment.MiddleLeft
					args.NodeElement.Children.Insert(3, descriptionElement)
				End If

				CType(args.NodeElement.Children(3), LightVisualElement).Text = propertyName & ":  "
				args.NodeElement.ContentElement.ForeColor = Color.Blue
				args.NodeElement.ContentElement.Text = propertyValue.ToString()
			Else
				If args.NodeElement.Children.Count = 5 Then
					args.NodeElement.Children.RemoveAt(3)
				End If
				args.NodeElement.ContentElement.Text = "<html><b>" & propertyName
				args.NodeElement.ContentElement.ForeColor = Color.Black
			End If
		End Sub

		Private Sub radTreeView1_ValueChanging(ByVal sender As Object, ByVal e As TreeNodeValueChangingEventArgs)
			Dim helper As PropertyHelper = CType(e.OldValue, PropertyHelper)

			If helper.ValueType Is GetType(Single) Then
				helper.Value = Convert.ToSingle(e.NewValue)
			ElseIf helper.ValueType Is GetType(Color) Then
				helper.Value = Color.FromName(Convert.ToString(e.NewValue))
			ElseIf helper.ValueType Is GetType(ElementShape) Then
				helper.Value = New RoundRectShape(Convert.ToInt32(e.NewValue))
			Else
				helper.Value = e.NewValue
			End If

			e.NewValue = helper
		End Sub

		Private Sub radTreeView1_EditorInitialized(ByVal sender As Object, ByVal e As TreeNodeEditorInitializedEventArgs)
			Dim editor As TreeViewDropDownListEditor = TryCast(e.Editor, TreeViewDropDownListEditor)
			If editor IsNot Nothing Then
				Dim listElement As RadDropDownListElement = CType(editor.EditorElement, RadDropDownListElement)
				listElement.DropDownStyle = RadDropDownStyle.DropDownList
				If listElement.Items.Count = 0 Then
					listElement.Items.Add(New RadListDataItem("White", "White"))
					listElement.Items.Add(New RadListDataItem("Black", "Black"))
					listElement.Items.Add(New RadListDataItem("Gray", "Gray"))
					listElement.Items.Add(New RadListDataItem("Red", "Red"))
					listElement.Items.Add(New RadListDataItem("Blue", "Blue"))
					listElement.Items.Add(New RadListDataItem("Green", "Green"))
					listElement.Items.Add(New RadListDataItem("Yellow", "Yellow"))
				End If
				listElement.SelectedValue = (CType(e.Node.Value, PropertyHelper)).ToString()
			End If
		End Sub

		Private Sub radTreeView1_EditorRequired(ByVal sender As Object, ByVal e As TreeNodeEditorRequiredEventArgs)
			If e.Node.Value Is DBNull.Value Then
				Return
			End If

			Dim helper As PropertyHelper = CType(e.Node.Value, PropertyHelper)
			If helper IsNot Nothing Then
				If helper.ValueType Is GetType(Single) OrElse helper.ValueType Is GetType(ElementShape) Then
					e.EditorType = GetType(TreeViewSpinEditor)
				ElseIf helper.ValueType Is GetType(String) Then
					e.EditorType = GetType(TreeViewTextBoxEditor)
				ElseIf helper.ValueType Is GetType(Color) Then
					e.EditorType = GetType(TreeViewDropDownListEditor)
				End If
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckBoxAllowEdit.ToggleStateChanged, AddressOf radCheckBoxAllowEdit_ToggleStateChanged
		End Sub
	End Class
End Namespace
