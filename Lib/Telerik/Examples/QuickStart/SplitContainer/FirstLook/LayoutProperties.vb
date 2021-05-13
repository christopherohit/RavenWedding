Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.SplitContainer.FirstLook
	Partial Public Class LayoutProperties
		Inherits ExamplesRadForm
		Private previouslySelectedNode As RadTreeNode = Nothing

		Public Sub New()
			InitializeComponent()

			AddHandler FormClosing, AddressOf AdvancedLayoutDesiger_FormClosing
			AddHandler radioHorizontal.ToggleStateChanged, AddressOf radioHorizontal_ToggleStateChanged
			AddHandler radioVertical.ToggleStateChanged, AddressOf radioVertical_ToggleStateChanged
			AddHandler checkSplitterFixed.ToggleStateChanged, AddressOf checkSplitterFixed_ToggleStateChanged
			AddHandler checkFixed.ToggleStateChanged, AddressOf checkFixed_ToggleStateChanged
			AddHandler checkCollapsed.ToggleStateChanged, AddressOf checkCollapsed_ToggleStateChanged
		End Sub

		Private Sub checkCollapsed_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			CType(Me.radTreeView1.SelectedNode.Tag, SplitPanel).Collapsed = Me.checkCollapsed.ToggleState = ToggleState.On

			Dim splitContNode As RadTreeNode = Me.radTreeView1.SelectedNode.Parent

			Dim splitContainer As Telerik.WinControls.UI.RadSplitContainer = CType(splitContNode.Tag, Telerik.WinControls.UI.RadSplitContainer)

			Dim canRemoveNode As Boolean = True

			Do While canRemoveNode
				If TypeOf splitContNode.Nodes(splitContNode.Nodes.Count - 1).Tag Is SplitterElement Then
					splitContNode.Nodes.RemoveAt(splitContNode.Nodes.Count - 1)
				Else
					canRemoveNode = False
				End If
			Loop

			For i As Integer = 0 To splitContainer.Splitters.Count - 1
				Dim node As New RadTreeNode(String.Format("Splitter{0}", i + 1))
				node.Tag = splitContainer.Splitters(i)
				splitContNode.Nodes.Add(node)
			Next i
		End Sub

		Private Sub checkFixed_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				CType(Me.radTreeView1.SelectedNode.Tag, SplitPanel).SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute
			Else
				CType(Me.radTreeView1.SelectedNode.Tag, SplitPanel).SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Auto
			End If
		End Sub

		Private Sub checkSplitterFixed_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			CType(Me.radTreeView1.SelectedNode.Tag, SplitterElement).Fixed = Me.checkSplitterFixed.ToggleState = ToggleState.On
		End Sub

		Private Sub radioVertical_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				CType(Me.radTreeView1.SelectedNode.Tag, Telerik.WinControls.UI.RadSplitContainer).Orientation = Orientation.Vertical
			End If
		End Sub

		Private Sub radioHorizontal_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				CType(Me.radTreeView1.SelectedNode.Tag, Telerik.WinControls.UI.RadSplitContainer).Orientation = Orientation.Horizontal
			End If
		End Sub

		Private Sub AdvancedLayoutDesiger_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			SetDefaultColors()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			AddHandler radTreeView1.SelectedNodeChanged, AddressOf radTreeView1_SelectedNodeChanged

			Me.radTreeView1.TreeViewElement.DrawBorder = True

			SetTreeNodeReferences()

		End Sub

		Private Sub SetTreeNodeReferences()
			Dim ownerForm As Telerik.Examples.WinControls.SplitContainer.FirstLook.Form1 = CType(Me.Owner, Telerik.Examples.WinControls.SplitContainer.FirstLook.Form1)

			Me.radTreeView1.Nodes(0).Tag = ownerForm.RadSplitContainer1
			Me.radTreeView1.Nodes(0).Nodes(0).Tag = ownerForm.SplitPanel1
			Me.radTreeView1.Nodes(0).Nodes(1).Tag = ownerForm.SplitPanel2
			Me.radTreeView1.Nodes(0).Nodes(2).Tag = ownerForm.SplitPanel3

			For i As Integer = 0 To ownerForm.RadSplitContainer1.Splitters.Count - 1
				Dim node As New RadTreeNode(String.Format("Splitter{0}", i + 1))
				node.Tag = ownerForm.RadSplitContainer1.Splitters(i)
				Me.radTreeView1.Nodes(0).Nodes.Add(node)
			Next i

			Me.radTreeView1.Nodes(0).Nodes(2).Nodes(0).Tag = ownerForm.RadSplitContainer2
			Me.radTreeView1.Nodes(0).Nodes(2).Nodes(0).Nodes(0).Tag = ownerForm.SplitPanel4
			Me.radTreeView1.Nodes(0).Nodes(2).Nodes(0).Nodes(1).Tag = ownerForm.SplitPanel5

			For i As Integer = 0 To ownerForm.RadSplitContainer2.Splitters.Count - 1
				Dim node As New RadTreeNode(String.Format("Splitter{0}", i + 1))
				node.Tag = ownerForm.RadSplitContainer2.Splitters(i)
				Me.radTreeView1.Nodes(0).Nodes(2).Nodes(0).Nodes.Add(node)
			Next i
		End Sub

		Private Sub radTreeView1_SelectedNodeChanged(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
			Dim type As String = e.Node.Tag.ToString()
			Select Case type
				Case "Telerik.WinControls.UI.RadSplitContainer"
					LoadSplitContainerProperties(CType(e.Node.Tag, Telerik.WinControls.UI.RadSplitContainer))
					splitContainerLayout.BringToFront()
				Case "Telerik.WinControls.UI.SplitterElement"
					LoadSplitterProperties(CType(e.Node.Tag, SplitterElement))
					splitterLayout.BringToFront()
				Case "Telerik.WinControls.UI.SplitPanel"
					LoadSplitPanelProperties(CType(e.Node.Tag, SplitPanel))
					splitPanelLayout.BringToFront()
			End Select

			SetDefaultColors()

			previouslySelectedNode = e.Node
		End Sub

		Private Sub SetDefaultColors()
			If previouslySelectedNode IsNot Nothing Then
				Dim previousType As String = previouslySelectedNode.Tag.ToString()
				Select Case previousType
					Case "Telerik.WinControls.UI.RadSplitContainer"
						CType((CType((CType(previouslySelectedNode.Tag, Telerik.WinControls.UI.RadSplitContainer)).Parent, RadPanel)).PanelElement.Children(1), BorderPrimitive).ResetValue(VisualElement.ForeColorProperty, ValueResetFlags.Local)
					Case "Telerik.WinControls.UI.SplitterElement"
						Dim fillP As FillPrimitive = CType((CType(previouslySelectedNode.Tag, SplitterElement)).Children(0), FillPrimitive)
						fillP.ResetValue(VisualElement.BackColorProperty, ValueResetFlags.Local)
						fillP.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local)
						fillP.ResetValue(FillPrimitive.GradientStyleProperty, ValueResetFlags.Local)
						fillP.ResetValue(RadElement.ShouldPaintProperty, ValueResetFlags.Local)
					Case "Telerik.WinControls.UI.SplitPanel"
						CType(previouslySelectedNode.Tag, SplitPanel).SplitPanelElement.Border.ResetValue(VisualElement.ForeColorProperty, ValueResetFlags.Local)
				End Select
			End If
		End Sub

		Private Sub LoadSplitPanelProperties(ByVal panel As SplitPanel)
			Me.checkFixed.ToggleState = If(panel.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute, ToggleState.On, ToggleState.Off)
			Me.checkCollapsed.ToggleState = If(panel.Collapsed, ToggleState.On, ToggleState.Off)

			panel.SplitPanelElement.Border.ForeColor = Color.Red
		End Sub

		Private Sub LoadSplitterProperties(ByVal splitter As SplitterElement)
			Me.checkSplitterFixed.ToggleState = If(splitter.Fixed, ToggleState.On, ToggleState.Off)

			Dim fillP As FillPrimitive = CType(splitter.Children(0), FillPrimitive)
			fillP.BackColor = Color.Red
			fillP.GradientStyle = Telerik.WinControls.GradientStyles.Solid
			fillP.Visibility = ElementVisibility.Visible
			fillP.ShouldPaint = True
		End Sub

		Private Sub LoadSplitContainerProperties(ByVal splitContainer As Telerik.WinControls.UI.RadSplitContainer)
			If splitContainer.Orientation = Orientation.Horizontal Then
				Me.radioHorizontal.ToggleState = ToggleState.On
			Else
				Me.radioVertical.ToggleState = ToggleState.On
			End If

			CType((CType(splitContainer.Parent, RadPanel)).PanelElement.Children(1), BorderPrimitive).ForeColor = Color.Red
		End Sub
	End Class
End Namespace
