Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Docking.DragDrop
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

			Me.WireServiceEvents()
		End Sub

		#End Region

		#Region "Implementation"

		'protected override void OnLoad(EventArgs e)
		'{
		'    ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, MainForm.DefaultTheme);
		'}

		Private Sub WireServiceEvents()
			Dim service As DragDropService = Me.radDock1.GetService(Of DragDropService)()
			AddHandler service.Starting, AddressOf OnDragDropService_Starting
			AddHandler service.PreviewDropTarget, AddressOf OnDragDropService_PreviewDropTarget
			AddHandler service.PreviewDockPosition, AddressOf OnDragDropService_PreviewDockPosition
		End Sub

		Private Sub OnDragDropService_PreviewDockPosition(ByVal sender As Object, ByVal e As DragDropDockPositionEventArgs)
			If Me.allowDockBottom.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				e.AllowedDockPosition = AllowedDockPosition.Bottom
			End If
		End Sub

		Private Sub OnDragDropService_PreviewDropTarget(ByVal sender As Object, ByVal e As DragDropTargetEventArgs)
            If Me.tool3Drop.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                If e.DropTarget IsNot Me.toolWindow3.TabStrip Then
                    e.DropTarget = Nothing
                End If
            End If
		End Sub

		Private Sub OnDragDropService_Starting(ByVal sender As Object, ByVal e As StateServiceStartingEventArgs)
			Dim context As Control = TryCast(e.Context, Control)
			If context Is Nothing Then
				Return
			End If

			If context Is Me.toolWindow1 OrElse ControlHelper.IsDescendant(context, Me.toolWindow1) Then
				e.Cancel = Me.tool1Drag.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			ElseIf context Is Me.toolWindow2 OrElse ControlHelper.IsDescendant(context, Me.toolWindow2) Then
				e.Cancel = Me.tool2Drag.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			End If
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radDock1.DragDropMode = DragDropMode.Preview
			Else
				Me.radDock1.DragDropMode = DragDropMode.Auto
			End If
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
		End Sub
	End Class
End Namespace
