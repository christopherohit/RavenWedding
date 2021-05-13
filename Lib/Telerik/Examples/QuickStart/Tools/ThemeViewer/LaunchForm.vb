Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Tools.ThemeViewer
	Partial Public Class LaunchForm
		Inherits ExamplesLauncherForm
		Implements ICustomThemeExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.pictureBoxLaunchExample.ButtonImage = My.Resources.launch
		End Sub
	End Class
End Namespace
