Imports System.Text
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.Globalization.Localization
	Public Class GermanTreeViewLocalizationProvider
		Inherits TreeViewLocalizationProvider
		Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case id
                Case TreeViewStringId.ContextMenuCollapse
                    Return "Zusammenklappen"
                Case TreeViewStringId.ContextMenuDelete
                    Return "Löschen"
                Case TreeViewStringId.ContextMenuEdit
                    Return "Edieren"
                Case TreeViewStringId.ContextMenuExpand
                    Return "Expandieren"
                Case TreeViewStringId.ContextMenuNew
                    Return "Neu"
                Case TreeViewStringId.ContextMenuCopy
                    Return "Kopie"
                Case TreeViewStringId.ContextMenuPaste
                    Return "Shpacieren"
                Case TreeViewStringId.ContextMenuCut
                    Return "Schneiden"
            End Select

			Return ""
		End Function
	End Class
End Namespace
