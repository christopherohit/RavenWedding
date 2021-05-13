Imports System.Linq
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PanelsLabels.CollapsiblePanel
	Public Class PersonInfoElement
		Inherits LightVisualElement
		Private mainContainer As New DockLayoutPanel()

'INSTANT VB NOTE: The variable imageElement was renamed since Visual Basic does not allow class members with the same name:
		Private imageElement_Renamed As LightVisualElement

'INSTANT VB NOTE: The variable nameElement was renamed since Visual Basic does not allow class members with the same name:
		Private nameElement_Renamed As RadLabelElement
'INSTANT VB NOTE: The variable emailElement was renamed since Visual Basic does not allow class members with the same name:
		Private emailElement_Renamed As RadLabelElement
'INSTANT VB NOTE: The variable phoneElement was renamed since Visual Basic does not allow class members with the same name:
		Private phoneElement_Renamed As RadLabelElement
		Private infoStack As StackLayoutPanel

		Public ReadOnly Property ImageElement() As LightVisualElement
			Get
				Return Me.imageElement_Renamed
			End Get
		End Property

		Public ReadOnly Property NameElement() As RadLabelElement
			Get
				Return Me.nameElement_Renamed
			End Get
		End Property

		Public ReadOnly Property EmailElement() As RadLabelElement
			Get
				Return Me.emailElement_Renamed
			End Get
		End Property

		Public ReadOnly Property PhoneElement() As RadLabelElement
			Get
				Return Me.phoneElement_Renamed
			End Get
		End Property

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()

			Me.Shape = New RoundRectShape(5)
			Me.DrawBorder = True
			Me.BorderColor = Color.FromArgb(197, 208, 222)
			Me.Padding = New Padding(10)

		End Sub



		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			Me.mainContainer = New DockLayoutPanel()
			Me.mainContainer.LastChildFill = True
			Me.Children.Add(Me.mainContainer)

			Me.imageElement_Renamed = New LightVisualElement()
			Me.imageElement_Renamed.DrawBorder = True
			Me.imageElement_Renamed.BorderColor = Color.FromArgb(224, 224, 224)
			Me.mainContainer.Children.Add(imageElement_Renamed)
			DockLayoutPanel.SetDock(Me.imageElement_Renamed, Dock.Left)

			Me.infoStack = New StackLayoutPanel()
			Me.infoStack.Orientation = Orientation.Vertical
			Me.mainContainer.Children.Add(Me.infoStack)

			Me.nameElement_Renamed = New RadLabelElement()
			Me.nameElement_Renamed.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
			Me.nameElement_Renamed.Text = "Name: "
			Me.infoStack.Children.Add(Me.nameElement_Renamed)

			Me.emailElement_Renamed = New RadLabelElement()
			Me.emailElement_Renamed.Text = "Email: "
			Me.infoStack.Children.Add(Me.emailElement_Renamed)

			Me.phoneElement_Renamed = New RadLabelElement()
			Me.phoneElement_Renamed.Text = "Phone: "
			Me.infoStack.Children.Add(Me.phoneElement_Renamed)
		End Sub
	End Class
End Namespace
