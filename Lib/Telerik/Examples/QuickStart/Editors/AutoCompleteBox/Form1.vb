Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Editors.AutoCompleteBox
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SetupAutoComplete(Me.radAutoCompleteBox1)
			Me.SetupAutoComplete(Me.radAutoCompleteBox2)

			Me.radDropDownListAutoCompleteMode.DropDownStyle = RadDropDownStyle.DropDownList
			Me.radDropDownListAutoCompleteMode.SelectedIndex = 0
			AddHandler Me.radDropDownListAutoCompleteMode.SelectedIndexChanged, AddressOf OnRadDropDownListAutoCompleteModeSelectedIndexChanged
		End Sub


		'protected override void OnResize(EventArgs e)
		'{
		'    base.OnResize(e);

		'    if (this.radPanel1 != null)
		'    {
		'        float xCoord = ((float)(this.Width - this.radPanel1.Width)) / 2;
		'        float yCoord = ((float)(this.Height - this.radPanel1.Height)) / 2;
		'        this.radPanel1.Location = Point.Round(new PointF(xCoord, yCoord));
		'    }
		'}

		Private Sub SetupAutoComplete(ByVal radAutoCompleteBox As RadAutoCompleteBox)
			AddHandler radAutoCompleteBox.Items.CollectionChanged, AddressOf OnItemsCollectionChanged
			radAutoCompleteBox.AutoCompleteDisplayMember = "Name"
			radAutoCompleteBox.AutoCompleteValueMember = "Email"
			AddHandler radAutoCompleteBox.ListElement.VisualItemFormatting, AddressOf OnListElementVisualItemFormatting
			radAutoCompleteBox.AutoCompleteDataSource = New BindingSource(Me.GetAutoCompleteDataSource(), String.Empty)
			radAutoCompleteBox.DropDownMaxSize = New Size(200, 0)
			Me.FillList(radAutoCompleteBox.Items)
		End Sub

		Private Sub OnListElementVisualItemFormatting(ByVal sender As Object, ByVal e As VisualItemFormattingEventArgs)
			Dim dataItem As RadListDataItem = e.VisualItem.Data
			e.VisualItem.Text = String.Format("{0} <{1}>", dataItem.Text, dataItem.Value)
		End Sub

		Private Function GetAutoCompleteDataSource() As DataTable
			Dim table As New DataTable("Contacts")
			table.Columns.Add("Name", GetType(String))
			table.Columns.Add("Email", GetType(String))

			table.Rows.Add("Joe Smith", "joe@fakecompany.com")
			table.Rows.Add("Adam Petersen", "adam@qwerty.com")
			table.Rows.Add("Jack Russel", "jack@russel.nocom")
			table.Rows.Add("Daniel Finger", "daniel.pinger@gmail.com")
			table.Rows.Add("Richard Vail", "rvail@richardvail.com")
			table.Rows.Add("Sebastian Jonnson", "s.jonnson@sjonnson.com")
			table.Rows.Add("Lee Cooper", "lee.cooper@coopercoorp.com")
			table.Rows.Add("Kelvin Clain", "kclain@clainkevin.com")
			table.Rows.Add("Maria Jenson", "mjenson@mariajenson.com")
			table.Rows.Add("Chelsea Maarten", "chelsea@maarten.com")
			table.Rows.Add("Jenson Chew", "jenson.chew@nospam.com")
			table.Rows.Add("Martin Williams", "m.williams@martinandwilliams.com")
			table.Rows.Add("Telerik", "clientservice@telerik.com")
			table.Rows.Add("James Stone", "james.stone@manystones.com")
			table.Rows.Add("Samuel Jackson", "samuel.jackson@nojackson.com")

			Return table
		End Function


		Private Sub OnRadDropDownListAutoCompleteModeSelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			If Me.radDropDownListAutoCompleteMode.SelectedItem IsNot Nothing Then
				Dim text As String = Me.radDropDownListAutoCompleteMode.SelectedItem.Text
				Dim mode As AutoCompleteMode = CType(System.Enum.Parse(GetType(AutoCompleteMode), text), AutoCompleteMode)
				Me.radAutoCompleteBox1.AutoCompleteMode = mode
				Me.radAutoCompleteBox2.AutoCompleteMode = mode
			End If
		End Sub

		Private Sub OnItemsCollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
			Dim items As RadTokenizedTextItemCollection = TryCast(sender, RadTokenizedTextItemCollection)
			Me.FillList(items)
		End Sub

		Private Sub FillList(ByVal items As RadTokenizedTextItemCollection)
			Dim control As RadListControl = If(Me.radAutoCompleteBox1.Items IsNot items, Me.radListControlRecipients, Me.radListControlCarbonCopy)

			control.Items.Clear()

			For Each item As RadTokenizedTextItem In items
				Dim text As String = item.Text

				If item.Value IsNot Nothing Then
					text = String.Format("{0} <{1}>", text, item.Value)
				End If

				control.Items.Add(New RadListDataItem(text))
			Next item
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
