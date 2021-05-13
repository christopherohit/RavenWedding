Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.UI
Imports System.Text.RegularExpressions
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.PropertyGrid.Validation
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		'protected override void OnSizeChanged(EventArgs e)
		'{
		'    base.OnSizeChanged(e);
		'    if (this.radPropertyGrid1 != null)
		'    {
		'        int width = this.ClientSize.Width;
		'        int height = this.ClientSize.Height;
		'        this.radPropertyGrid1.Location = new Point((width - radPropertyGrid1.Size.Width) / 2, (height - radPropertyGrid1.Size.Height) / 2);
		'    }
		'}

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.AutoScroll = False

			AddHandler radPropertyGrid1.PropertyValidating, AddressOf radPropertyGrid1_PropertyValidating
			AddHandler radPropertyGrid1.Edited, AddressOf radPropertyGrid1_Edited

			Dim person As New PersonInfo()
			person.Name = "John"
			person.Family = "Smith"
			person.Gender = Gender.Male
			person.Age = 34
			person.City = "London"
			person.Country = "England"
			person.Phone = "555-343-3456    "
			person.EMail = "john.smith@microsoft.com"

			radPropertyGrid1.SelectedObject = person
			radPropertyGrid1.PropertySort = PropertySort.CategorizedAlphabetical
			radPropertyGrid1.HelpVisible = True
			radPropertyGrid1.ToolbarVisible = True
			radPropertyGrid1.PropertyGridElement.SplitElement.HelpElementHeight = 110

			Dim timer As New Timer()
			timer.Interval = 200
			AddHandler timer.Tick, AddressOf timer_Tick
			timer.Start()
		End Sub

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Dim timer As Timer = CType(sender, Timer)
			timer.Stop()
			timer.Dispose()

			radPropertyGrid1.Items("Age").Select()
			radPropertyGrid1.Items("Age").BeginEdit()
			radPropertyGrid1.ActiveEditor.Value = 12
			radPropertyGrid1.EndEdit()
		End Sub

		Private Sub radPropertyGrid1_Edited(ByVal sender As Object, ByVal e As PropertyGridItemEditedEventArgs)
			Dim item As PropertyGridItem = TryCast(e.Item, PropertyGridItem)
			item.ErrorMessage = ""
		End Sub

		Private Sub radPropertyGrid1_PropertyValidating(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.PropertyValidatingEventArgs)
			Dim item As PropertyGridItem = CType(e.Item, PropertyGridItem)

			If e.Item.Name = "Age" AndAlso (CDec(e.NewValue) < 18 OrElse CDec(e.NewValue) > 56) Then
				item.ErrorMessage = "Age must be between 18 and 56!"
				e.Cancel = True
			End If

			If e.Item.Name = "Phone" Then
				Dim regex As New Regex("^(\(?[0-9]{3}\)?)?\-?[0-9]{3}\-?[0-9]{4}$")
				If e.NewValue Is Nothing OrElse (Not regex.IsMatch(e.NewValue.ToString())) Then
					item.ErrorMessage = "This is not a valid phone. Please enter valid phone to continue."
					e.Cancel = True
				End If
			End If

			If e.Item.Name = "EMail" Then
				Dim regex As New Regex("^[A-Za-z0-9_\-\.]+@(([A-Za-z0-9\-])+\.)+([A-Za-z\-])+$")
				If e.NewValue Is Nothing OrElse (Not regex.IsMatch(e.NewValue.ToString())) Then
					item.ErrorMessage = "This is not a valid email address. Please enter valid email address to continue."
					e.Cancel = True
				End If
			End If

			If e.Item.Name = "Country" OrElse e.Item.Name = "City" OrElse e.Item.Name = "Name" OrElse e.Item.Name = "Family" Then
				If String.IsNullOrEmpty(TryCast(e.NewValue, String)) Then
					item.ErrorMessage = "Please enter valid data!"
					e.Cancel = True
				End If
			End If
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
