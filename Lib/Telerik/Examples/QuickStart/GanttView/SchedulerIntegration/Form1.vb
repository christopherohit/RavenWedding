Imports Microsoft.VisualBasic
Imports Telerik.QuickStart.WinControls
Imports System.ComponentModel
Imports Telerik.WinControls.UI
Imports System
Imports System.Drawing
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GanttView.SchedulerIntegration
	Public Partial Class Form1
		Inherits ExamplesForm
		Private contextMenuItem As GanttViewDataItem
		Private rnd As Random = New Random()

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.InitializeScheduler()

			Me.radGanttView1.DataProvider = New GanttViewIntegrationProvider(Me.radScheduler1)

			Me.InitializeGanttView()
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.radGanttView1.GraphicalViewItemFormatting, AddressOf radGanttView1_GraphicalViewItemFormatting
			AddHandler Me.radGanttView1.ItemChildIdNeeded, AddressOf radGanttView1_ItemChildIdNeeded
			AddHandler Me.radGanttView1.ScreenTipNeeded, AddressOf radGanttView1_ScreenTipNeeded
			AddHandler Me.radGanttView1.TextViewItemFormatting, AddressOf radGanttView1_TextViewItemFormatting
			AddHandler Me.radGanttView1.ContextMenuOpening, AddressOf radGanttView1_ContextMenuOpening
			AddHandler Me.radGanttView1.GanttViewElement.ItemEdited, AddressOf GanttViewElement_ItemEdited
			Me.radGanttView1.GanttViewElement.Update(RadGanttViewElement.UpdateActions.Reset)
		End Sub

		Private Sub InitializeScheduler()
			Dim baseDate As DateTime = DateTime.Today
			Dim summaries As String(,) = New String(, ) { { "Mr. Brown", "Mr. White", "Mrs. Green" }, { "Mr. Pink", "Mr. Green", "Mrs. Yellow" }, { "Mr. Cyan", "Mr. Purple", "Mrs. Blue" }, { "Mr. Magenta", "Mr. Violet", "Mrs. Silver" }, { "Mr. Black", "Mr. Azure", "Mrs. Maroon" } }
			Dim descriptions As String() = New String() { "", "", "" }
			Dim locations As String() = New String() { "City", "Out of town", "Service Center" }
			Dim backgrounds As AppointmentBackground() = New AppointmentBackground() { AppointmentBackground.Business, AppointmentBackground.MustAttend, AppointmentBackground.Personal }
			Dim names As String() = New String() { "Alan Smith", "Anne Dodsworth", "Boyan Mastoni", "Richard Duncan", "Maria Shnaider" }
			Dim colors As Color() = New Color() { Color.LightBlue, Color.LightGreen, Color.LightYellow, Color.Red, Color.Orange }

			Dim i As Integer = 0
			Do While i < names.Length
				Dim resource As Resource = New Resource()
				resource.Id = New EventId(i)
				resource.Name = names(i)
				resource.Color = colors(i)
				resource.Image = Me.imageList1.Images(i)

				Me.radScheduler1.Resources.Add(resource)
				i += 1
			Loop

			Me.radScheduler1.GetDayView().ResourcesPerView = 3
			Me.radScheduler1.GroupType = GroupType.Resource
			Dim headerElement As SchedulerDayViewGroupedByResourceElement = TryCast(Me.radScheduler1.SchedulerElement.ViewElement, SchedulerDayViewGroupedByResourceElement)
			headerElement.ResourceHeaderHeight = 135

			i = 0
			Do While i < summaries.GetLength(0)
				Dim j As Integer = 0
				Do While j < summaries.GetLength(1)
					Dim start As DateTime = baseDate.AddDays(j).AddHours(Me.rnd.Next(1, 7))
					Dim appointment As Appointment = New Appointment(start, start.AddHours(Me.rnd.Next(12, 15)), summaries(i, j), descriptions(j), locations(j))
					appointment.ResourceId = Me.radScheduler1.Resources(i).Id
					appointment.BackgroundId = CInt(Fix(backgrounds((i + j) Mod backgrounds.Length)))
					Me.radScheduler1.Appointments.Add(appointment)
					j += 1
				Loop
				i += 1
			Loop

			Me.radScheduler1.SchedulerElement.SetResourceHeaderAngleTransform(SchedulerViewType.Timeline, 0)
		End Sub

		Private Sub InitializeGanttView()
			Me.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = New TimeSpan(0, 5, 0)

			For Each col As GanttViewTextViewColumn In Me.radGanttView1.Columns
				col.Width = 150
			Next col

			Me.radGanttView1.Ratio = 0.3102f
		End Sub

		Private Sub GanttViewElement_ItemEdited(ByVal sender As Object, ByVal e As GanttViewItemEditedEventArgs)
			If e.Item.Start = e.Item.End Then
				e.Item.End = e.Item.Start.AddHours(1)
			End If
		End Sub

		Private Sub radGanttView1_ContextMenuOpening(ByVal sender As Object, ByVal e As GanttViewContextMenuOpeningEventArgs)
			Me.contextMenuItem = e.Item

			Dim menu As GanttViewDefaultContextMenu = TryCast(e.Menu, GanttViewDefaultContextMenu)
			menu.ShowProgress = False
			menu.AddChildMenuItem.Visibility = ElementVisibility.Collapsed
		End Sub

		Private Sub radGanttView1_TextViewItemFormatting(ByVal sender As Object, ByVal e As GanttViewTextViewItemFormattingEventArgs)
			Dim app As Appointment = TryCast(e.Item.DataBoundItem, Appointment)
			Dim resource As IResource = Me.radScheduler1.Resources.GetById(app.ResourceId)
			e.ItemElement.BackColor = resource.Color
			e.ItemElement.DrawFill = True
		End Sub

		Private Sub radGanttView1_ScreenTipNeeded(ByVal sender As Object, ByVal e As ScreenTipNeededEventArgs)
			Dim taskElement As GanttViewTaskElement = TryCast(e.Item, GanttViewTaskElement)

			If Not taskElement Is Nothing Then
				Dim screenTip As RadOffice2007ScreenTipElement = New RadOffice2007ScreenTipElement()
				Dim app As Appointment = TryCast((CType(taskElement.Parent, GanttGraphicalViewBaseItemElement)).Data.DataBoundItem, Appointment)
				Dim resource As IResource = Me.radScheduler1.Resources.GetById(app.ResourceId)
				screenTip.MainTextLabel.Image = resource.Image
				screenTip.CaptionLabel.Text = resource.Name
				screenTip.MainTextLabel.Text = String.Empty
				e.Item.ScreenTip = screenTip
			End If
		End Sub

		Private Sub radGanttView1_ItemChildIdNeeded(ByVal sender As Object, ByVal e As GanttViewItemChildIdNeededEventArgs)
			e.ChildId = New EventId(Guid.NewGuid())

			CType(e.Item.DataBoundItem, Appointment).ResourceId = (CType(Me.contextMenuItem.DataBoundItem, Appointment)).ResourceId
		End Sub

		Private Sub radGanttView1_GraphicalViewItemFormatting(ByVal sender As Object, ByVal e As GanttViewGraphicalViewItemFormattingEventArgs)
			Dim app As Appointment = TryCast(e.Item.DataBoundItem, Appointment)
			Dim backGroundStorage As ISchedulerStorage(Of IAppointmentBackgroundInfo) = Me.radScheduler1.GetBackgroundStorage()
			Dim backInfo As IAppointmentBackgroundInfo = backGroundStorage.GetById(app.BackgroundId)

			If Not backInfo Is Nothing Then
				e.ItemElement.TaskElement.BackColor = backInfo.BackColor
				e.ItemElement.TaskElement.BackColor2 = backInfo.BackColor2
				e.ItemElement.TaskElement.BackColor3 = backInfo.BackColor3
				e.ItemElement.TaskElement.BackColor4 = backInfo.BackColor4
				e.ItemElement.TaskElement.BorderColor = backInfo.BorderColor
				e.ItemElement.TaskElement.BorderColor2 = backInfo.BorderColor2
				e.ItemElement.TaskElement.BorderColor3 = backInfo.BorderColor3
				e.ItemElement.TaskElement.BorderColor4 = backInfo.BorderColor4
				e.ItemElement.TaskElement.BorderBoxStyle = backInfo.BorderBoxStyle
				e.ItemElement.TaskElement.BorderGradientStyle = backInfo.BorderGradientStyle
				e.ItemElement.TaskElement.ForeColor = backInfo.ForeColor
				e.ItemElement.TaskElement.GradientAngle = backInfo.GradientAngle
				e.ItemElement.TaskElement.GradientStyle = backInfo.GradientStyle
				e.ItemElement.TaskElement.GradientPercentage = backInfo.GradientPercentage
				e.ItemElement.TaskElement.GradientPercentage2 = backInfo.GradientPercentage2
				e.ItemElement.TaskElement.NumberOfColors = backInfo.NumberOfColors

				If Not backInfo.Font Is Nothing Then
					e.ItemElement.TaskElement.Font = backInfo.Font
				End If
			End If

			Dim resource As IResource = Me.radScheduler1.Resources.GetById(app.ResourceId)

			If Not resource Is Nothing Then
				e.ItemElement.BackColor = resource.Color
				e.ItemElement.DrawFill = True
			End If
		End Sub
	End Class
End Namespace
