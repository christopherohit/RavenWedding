Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GanttView.Printing
	Public Partial Class Form1
		Inherits ExamplesForm
		Private radPrintDocument1 As RadPrintDocument

		Public Sub New()
			InitializeComponent()

			InitializeGanttView()

			Me.radPrintDocument1 = New RadPrintDocument()
			Me.radPrintDocument1.AssociatedObject = Me.radGanttView1
		End Sub

		Public Sub InitializeGanttView()
			Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Id"))
			Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("ParentId"))
			Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Title"))
			Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Start"))
			Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Finish"))

			Me.radGanttView1.GanttViewElement.Columns(0).Visible = False
			Me.radGanttView1.GanttViewElement.Columns(1).Visible = False
			Me.radGanttView1.GanttViewElement.Columns(2).Width = 350
			Me.radGanttView1.GanttViewElement.Columns(3).Width = 120
			Me.radGanttView1.GanttViewElement.Columns(4).Width = 120

			Me.radGanttView1.GanttViewElement.TaskDataMember = "Tasks"
			Me.radGanttView1.GanttViewElement.ChildMember = "Id"
			Me.radGanttView1.GanttViewElement.ParentMember = "ParentId"
			Me.radGanttView1.GanttViewElement.TitleMember = "Title"
			Me.radGanttView1.GanttViewElement.StartMember = "Start"
			Me.radGanttView1.GanttViewElement.EndMember = "Finish"
			Me.radGanttView1.GanttViewElement.ProgressMember = "Progress"
			Me.radGanttView1.GanttViewElement.LinkDataMember = "Links"
			Me.radGanttView1.GanttViewElement.LinkStartMember = "StartId"
			Me.radGanttView1.GanttViewElement.LinkEndMember = "EndId"
			Me.radGanttView1.GanttViewElement.LinkTypeMember = "LinkType"

            Dim telerikWeddingPlanner As New DataSet()
            Dim executingAssembly As Assembly = Assembly.GetExecutingAssembly()
            Dim resourceName As String = "TelerikWeddingPlanner.xml"

			Using resourceStream As Stream = executingAssembly.GetManifestResourceStream(resourceName)
				telerikWeddingPlanner.ReadXml(resourceStream)
			End Using

			Me.radGanttView1.DataSource = telerikWeddingPlanner

			Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Month
			Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = New DateTime(2006, 8, 21)
			Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = New DateTime(2007, 4, 3)
		End Sub

		Private Sub buttonPrint_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGanttView1.Print(True, Me.radPrintDocument1)
		End Sub

		Private Sub buttonPrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGanttView1.PrintPreview(Me.radPrintDocument1)
		End Sub

		Private Sub buttonPrintSettings_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dialog As GanttViewPrintSettingsDialog = DirectCast(Me.radGanttView1.GetSettingsDialog(Me.radPrintDocument1), GanttViewPrintSettingsDialog)
            dialog.ThemeName = Me.GetExampleDefaultTheme()

			If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Me.radGanttView1.PrintPreview(Me.radPrintDocument1)
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler Me.buttonPrint.Click, AddressOf buttonPrint_Click
			AddHandler Me.buttonPrintPreview.Click, AddressOf buttonPrintPreview_Click
			AddHandler Me.buttonPrintSettings.Click, AddressOf buttonPrintSettings_Click
		End Sub
	End Class
End Namespace
