Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace DemoAppsHub.MagnifierExample
	Public Partial Class MagnifierExampleUserControl
		Inherits UserControl
		Private magnifier As Magnifier

		Public Sub New()
			InitializeComponent()

			Me.Size = New Size(430, 430)
            ThemeResolutionService.LoadPackageResource("OfficeGlass.tssp")
			Me.magnifier = New Magnifier()

			Me.magnifier.BackColor = System.Drawing.Color.Transparent
			Me.magnifier.Columns = 7
			Me.magnifier.DefaultCellSize = New System.Drawing.Size(56, 56)
			Me.magnifier.ForeColor = System.Drawing.Color.Black
			Me.magnifier.Name = "magnifier1"
			Me.magnifier.RootElement.ForeColor = System.Drawing.Color.Black
			Me.magnifier.Size = New System.Drawing.Size(429 + 30, 411 + 30)
			Me.magnifier.TabIndex = 0
			Me.magnifier.Element.Layout.Margin = New Padding(30)
			Me.magnifier.Text = "magnifier1"
			CType(Me.magnifier.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.magnifier.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden

			FillMagnifierWithButtons()
			Me.magnifier.ThemeName = "OfficeGlass"
			Me.Controls.Add(magnifier)
		End Sub

		Private Sub FillMagnifierWithButtons()
			For i As Integer = 0 To 48
				Dim button As RadButtonElement = New RadButtonElement(i.ToString())

				button.StretchHorizontally = False
				button.StretchVertically = False
				button.Alignment = ContentAlignment.MiddleCenter
				button.TextAlignment = ContentAlignment.MiddleCenter
				button.TextElement.Parent.Alignment = ContentAlignment.MiddleCenter
				button.MinSize = New Size(33, 33)
				Me.magnifier.Items.Add(button)
			Next i
		End Sub

		Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
			MyBase.OnSizeChanged(e)
			If Not Me.magnifier Is Nothing Then
                Me.magnifier.Location = New Point(CType((Me.Width - Me.magnifier.Width) / 2, Integer) - 15, 0)
			End If
		End Sub

	End Class
End Namespace
