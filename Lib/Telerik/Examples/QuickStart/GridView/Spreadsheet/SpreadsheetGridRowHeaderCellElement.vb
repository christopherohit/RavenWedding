Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Spreadsheet
	Public Class SpreadsheetGridRowHeaderCellElement
		Inherits GridRowHeaderCellElement
		#Region "Initialization"

		Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
			MyBase.New(column, row)

		End Sub

		Public Overrides Sub Initialize(ByVal column As GridViewColumn, ByVal row As GridRowElement)
			MyBase.Initialize(column, row)
		End Sub

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()

			MyBase.DrawFill = True
			MyBase.GradientStyle = Telerik.WinControls.GradientStyles.Linear
			MyBase.NumberOfColors = 4
			MyBase.BackColor = Color.FromArgb(231, 240, 252)
			MyBase.BackColor2 = Color.FromArgb(218, 233, 251)
			MyBase.BackColor3 = Color.FromArgb(216, 231, 251)
			MyBase.BackColor4 = Color.FromArgb(209, 226, 247)
			MyBase.DrawBorder = True
			MyBase.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
			MyBase.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders
			MyBase.BorderColor = Color.FromArgb(209, 225, 245)
			MyBase.BorderInnerColor = Color.White
		End Sub

		Public Overrides Sub SetContent()
			Dim rowNumber As Integer = Me.ViewTemplate.Rows.IndexOf(Me.RowInfo) + 1
			Me.Text = rowNumber.ToString()
		End Sub

		#End Region
	End Class
End Namespace
