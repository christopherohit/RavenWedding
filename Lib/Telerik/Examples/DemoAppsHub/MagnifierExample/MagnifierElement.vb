Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

Namespace DemoAppsHub.MagnifierExample
	Public Class MagnifierElement
		Inherits RadScrollViewer
		Private layout_Renamed As MagnifierLayout
		Private items_Renamed As RadItemOwnerCollection

		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property Layout() As MagnifierLayout
			Get
				Return layout_Renamed
			End Get
		End Property

		Public Sub New()
		   ' this.LayoutUpdated += new EventHandler(MagnifierElement_LayoutUpdated);
		End Sub

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()

			Me.items_Renamed = New RadItemOwnerCollection()
			Me.items_Renamed.ItemTypes = New Type() { GetType(RadButtonElement) }
		End Sub

		Protected Overrides Sub DisposeManagedResources()
		   ' this.LayoutUpdated -= new EventHandler(MagnifierElement_LayoutUpdated);

			MyBase.DisposeManagedResources()
		End Sub

		Private Sub MagnifierElement_LayoutUpdated(ByVal sender As Object, ByVal e As EventArgs)
			Me.Invalidate()
		End Sub

		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property Items() As RadItemOwnerCollection
			Get
				Return items_Renamed
			End Get
		End Property

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			Me.layout_Renamed = New MagnifierLayout()
			Me.Viewport = layout_Renamed
			Me.items_Renamed.Owner = layout_Renamed
		End Sub
	End Class
End Namespace
