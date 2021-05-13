Imports System.Text
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.Customize.CustomNodes
	Public Class CustomTreeNodeElement
		Inherits TreeNodeElement
		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()
			Me.StretchHorizontally = False
		End Sub

		Protected Overrides Function CreateContentElement() As TreeNodeContentElement
			Return New CustomContentElement()
		End Function

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(TreeNodeElement)
			End Get
		End Property
	End Class
End Namespace
