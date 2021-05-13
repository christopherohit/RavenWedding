Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.ControllingBasicStates
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub disableItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadMenuItem = CType(sender, RadMenuItem)
			item.Enabled = False
		End Sub

		Private Sub removeItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As IHierarchicalItem = CType(sender, IHierarchicalItem)
			Dim parentItem As RadMenuItem = CType(item.HierarchyParent, RadMenuItem)
			parentItem.Items.Remove(CType(sender, RadMenuItem))
		End Sub

		Private Sub addItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As New RadMenuItem()
			item.Text = "New " & (TryCast(sender, RadMenuItem)).Text

			Dim hItem As IHierarchicalItem = CType(sender, IHierarchicalItem)
			Dim parentItem As RadMenuItemBase = CType(hItem.HierarchyParent, RadMenuItemBase)
			parentItem.Items.Add(item)
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radMenuItem4.Click, AddressOf addItem_Click
			AddHandler radMenuItem5.Click, AddressOf addItem_Click
			AddHandler radMenuItem6.Click, AddressOf addItem_Click
			AddHandler radMenuItem7.Click, AddressOf addItem_Click
			AddHandler radMenuItem8.Click, AddressOf removeItem_Click
			AddHandler radMenuItem10.Click, AddressOf removeItem_Click
			AddHandler radMenuItem9.Click, AddressOf removeItem_Click
			AddHandler radMenuItem11.Click, AddressOf removeItem_Click
			AddHandler radMenuItem12.Click, AddressOf disableItem_Click
			AddHandler radMenuItem13.Click, AddressOf disableItem_Click
			AddHandler radMenuItem14.Click, AddressOf disableItem_Click
			AddHandler radMenuItem15.Click, AddressOf disableItem_Click
		End Sub
	End Class
End Namespace