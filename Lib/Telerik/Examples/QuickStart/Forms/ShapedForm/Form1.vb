Imports System.IO
Imports System.Reflection
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.Tests
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Forms.ShapedForm
	Partial Public Class Form1
		Inherits ExamplesForm
		Private shapedForm As CustomShapedForm = Nothing
		Private titleBar As New RadTitleBar()

		Public Sub New()
			InitializeComponent()

			CreateShapedForm()

			Me.radRadioRound.ToggleState = ToggleState.On
			AddHandler Disposed, AddressOf Form1_Disposed
		End Sub

		Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As EventArgs)
			Me.shapedForm.Dispose()
		End Sub

		Private Sub CenterFormInPanel()
			Me.shapedForm.Location = New Point(Me.radPanel1.Width \ 2 - Me.shapedForm.Width \ 2, Me.radPanel1.Height \ 2 - Me.shapedForm.Height \ 2)
		End Sub

		Private Sub CenterFormOnScreen()
			Me.shapedForm.Location = New Point(Screen.PrimaryScreen.Bounds.Width \ 2 - Me.shapedForm.Width \ 2, Screen.PrimaryScreen.Bounds.Height \ 2 - Me.shapedForm.Height \ 2)
		End Sub

		Private Function LoadImage(ByVal name As String) As Image
			Dim stream As Stream = System.Reflection.Assembly.GetAssembly(Me.GetType()).GetManifestResourceStream(name)
			If stream Is Nothing Then
				Throw New NullReferenceException("Cannot find " & name)
			End If
			Return New Bitmap(stream)
		End Function

		Private Sub CreateShapedForm()
			Me.shapedForm = New CustomShapedForm()

			AddHandler shapedForm.FormClosing, AddressOf shapedForm_FormClosing
			Me.shapedForm.Name = "InnerForm"
			Me.shapedForm.Width = 200
			Me.shapedForm.Height = 100
			Me.shapedForm.TopLevel = False
			Me.shapedForm.BackColor = Color.LightGray
			Me.shapedForm.BorderColor = Color.DarkGray
			Me.shapedForm.Controls.Add(Me.titleBar)
			Me.titleBar.Dock = DockStyle.Top
			Me.titleBar.AutoSize = True
			Me.titleBar.RootElement.StretchHorizontally = True
			Me.titleBar.RootElement.StretchVertically = False
			Me.titleBar.RootElement.SaveCurrentStretchModeAsDefault()
			Me.radPanel1.Controls.Add(shapedForm)

			CenterFormInPanel()

			Me.shapedForm.Show()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
		End Sub

		Private Sub shapedForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			e.Cancel = True
		End Sub

		#Region "Event Handlers"

		Private Sub radRadioButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.shapedForm.Hide()
			Me.shapedForm.Controls.Clear()
			If Me.radRadioRound.ToggleState = ToggleState.On Then
				Me.shapedForm.BackgroundImage = Nothing
				Me.shapedForm.Shape = New RoundRectShape()
				Me.shapedForm.Size = New Size(200, 100)

				Me.shapedForm.Controls.Add(titleBar)
				Me.titleBar.Dock = DockStyle.Top
				Me.titleBar.AutoSize = True
				Me.titleBar.RootElement.StretchHorizontally = True
				Me.titleBar.RootElement.StretchVertically = False
				Me.titleBar.RootElement.SaveCurrentStretchModeAsDefault()
			End If

			If Me.radRadioCD.ToggleState = ToggleState.On Then
				Me.shapedForm.SuspendLayout()
				Dim s As New DonutShape()
				s.Thickness += 85 ' Magic, makes the form look like a CD.
				Me.shapedForm.Shape = s
				Me.shapedForm.Size = New Size(280, 280)
                Me.shapedForm.BackgroundImage = LoadImage("label.png")
				CenterFormInPanel()
			End If

			If Me.shapedForm.Parent Is Nothing Then
				CenterFormOnScreen()
			Else
				CenterFormInPanel()
			End If

			Me.shapedForm.Invalidate()
			Me.shapedForm.Show()
		End Sub

		Private Sub radButtonPop_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.shapedForm.TopLevel Then
				Me.shapedForm.TopLevel = False
				Me.shapedForm.Parent = Me.radPanel1
				Me.radButtonPop.Text = "Pop Form Out"
				CenterFormInPanel()
			Else
				Me.shapedForm.WindowState = FormWindowState.Normal
				Me.shapedForm.Parent = Nothing
				Me.shapedForm.TopLevel = True
				Me.radButtonPop.Text = "Push Form In"
				CenterFormOnScreen()
			End If
		End Sub

		Private Sub radButtonCreate_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim shapeEditor As New CustomShapeEditorForm()
			Dim s As CustomShape = shapeEditor.CreateShape()

			If s IsNot Nothing Then
				Me.shapedForm.Controls.Clear()
				Me.shapedForm.Shape = s
			End If

			Me.shapedForm.Invalidate()
		End Sub
		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radRadioCD.ToggleStateChanged, AddressOf radRadioButton1_ToggleStateChanged
			AddHandler radButtonCreate.Click, AddressOf radButtonCreate_Click
			AddHandler radRadioRound.ToggleStateChanged, AddressOf radRadioButton1_ToggleStateChanged
			AddHandler radButtonPop.Click, AddressOf radButtonPop_Click
		End Sub
	End Class

	Friend Class CustomShapedForm
		Inherits Telerik.WinControls.UI.ShapedForm
		Public Sub New()
			Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
			Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
		End Sub
	End Class
End Namespace
