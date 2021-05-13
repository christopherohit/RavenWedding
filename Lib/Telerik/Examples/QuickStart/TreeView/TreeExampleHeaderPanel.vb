Imports System.Text
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView
	Public Class TreeExampleHeaderPanel
		Inherits RadPanel
		Protected Overrides Sub OnLoad(ByVal desiredSize As Size)
            MyBase.OnLoad(desiredSize)

			Me.PanelElement.Font = New Font("Segoe UI", 10, FontStyle.Bold)
			Me.PanelElement.Padding = New Padding(8, 4, 2, 2)
		End Sub

        Public Overrides Property ThemeClassName() As String
            Get
                Return GetType(RadPanel).FullName
            End Get

            Set(value As String)

            End Set
        End Property

	End Class
End Namespace
