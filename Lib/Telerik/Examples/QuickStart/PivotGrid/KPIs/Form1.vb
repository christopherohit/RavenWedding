Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.Pivot.Adomd

Namespace Telerik.Examples.WinControls.PivotGrid.KPIs
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			radPivotGrid1.Dock = DockStyle.Fill
		End Sub

		Private Sub SetupAdomdProvider()
			Dim provider As New AdomdDataProvider()
			Dim settings As New AdomdConnectionSettings()

			settings.Cube = "Adventure Works"
			settings.Database = "Adventure Works DW 2008R2"
			settings.ConnectionString = "Data Source=https://demos.telerik.com/olap/msmdpump.dll;Catalog=Adventure Works DW 2008R2"

			provider.ConnectionSettings = settings
			provider.AggregatesPosition = Pivot.Core.PivotAxis.Rows

			provider.RowGroupDescriptions.Add(New AdomdGroupDescription() With {.MemberName = "[Product].[Category]"})
			provider.ColumnGroupDescriptions.Add(New AdomdGroupDescription() With {.MemberName = "[Date].[Fiscal Year]"})

			provider.AggregateDescriptions.Add(New AdomdAggregateDescription() With {.MemberName = "[Measures].[Internet Sales Amount]"})
			provider.AggregateDescriptions.Add(New AdomdAggregateDescription() With {.MemberName = "[Measures].[Internet Revenue Goal]"})
			provider.AggregateDescriptions.Add(New AdomdAggregateDescription() With {.MemberName = "[Measures].[Internet Revenue Status]"})
			provider.AggregateDescriptions.Add(New AdomdAggregateDescription() With {.MemberName = "[Measures].[Internet Revenue Trend]"})

			Me.radPivotGrid1.PivotGridElement.DataProvider = provider

			provider.DeferUpdates = False

			provider.Refresh()
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radButton1.Parent.Controls.Remove(Me.radButton1)
			Me.SetupAdomdProvider()
		End Sub

		Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
			MyBase.OnSizeChanged(e)
			If Me.radButton1 IsNot Nothing AndAlso Me.radPivotGrid1 IsNot Nothing Then
                Me.radButton1.Location = New Point(CInt((Me.radPivotGrid1.Width - Me.radButton1.Width) / 2), CInt((Me.radPivotGrid1.Height - Me.radButton1.Height) / 2))
            End If
        End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radButton1.Click, AddressOf radButton1_Click
		End Sub
	End Class
End Namespace
