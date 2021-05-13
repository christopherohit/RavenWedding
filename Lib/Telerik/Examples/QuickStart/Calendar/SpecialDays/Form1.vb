Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls
Imports System.Data.SqlClient

Namespace Telerik.Examples.WinControls.Calendar.SpecialDays
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radCalendar1.SpecialDays(0).Image = Me.imageList1.Images(0)
			Me.radCalendar1.SpecialDays(1).Image = Me.imageList1.Images(1)
			Me.radCalendar1.ShowFastNavigationButtons = False
		End Sub

		'protected override void OnLoad(EventArgs e)
		'{
		'    ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, MainForm.DefaultTheme);
		'}

		'protected override void OnLoad(EventArgs e)
		'{
		'    base.OnLoad(e);

		'    this.radCalendar1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
		'}

		Protected Overrides Sub WireEvents()

		End Sub
	End Class
End Namespace