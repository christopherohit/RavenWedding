Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Integration.BubbleBar
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Public Sub New()
            InitializeComponent()
            Me.CenteredControl = Me.bubbleBar1
		End Sub
	End Class
End Namespace