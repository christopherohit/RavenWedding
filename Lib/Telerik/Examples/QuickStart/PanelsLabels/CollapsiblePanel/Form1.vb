Imports System.Linq
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PanelsLabels.CollapsiblePanel
	Partial Public Class Form1
		Inherits ExamplesForm
		Private expandDirectionMap As New Dictionary(Of String, RadDirection)()
		Private contentSizingModeMap As New Dictionary(Of String, CollapsiblePanelContentSizingMode)()
		Private horizontalHeaderAlignmentMap As New Dictionary(Of String, RadHorizontalAlignment)()
		Private verticalHeaderAlignmentMap As New Dictionary(Of String, RadVerticalAlignment)()
		Private animationTypeMap As New Dictionary(Of String, CollapsiblePanelAnimationType)()
		Private animationEasingTypeMap As New Dictionary(Of String, RadEasingType)()

		Private initialCollapsiblePanelSize As Size

		Public Sub New()
			Me.InitializeComponent()
			Me.InitializeExpandDirection()
			Me.InitializeContentSizingMode()
			Me.InitializeAnimations()
			Me.InitializeHorizontalHeaderAlignment()
			Me.InitializeVerticalHeaderAlignment()
			Me.InitializeAnimationTypes()
			Me.InitializeAnimationEasingTypes()
			Me.InitializePeopleInfo()

			Me.radPanelDemoHolder.PanelElement.PanelBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			Me.radCollapsiblePanel1.HeaderText = "RadCollapsiblePanel Example"

			AddHandler Me.SizeChanged, AddressOf Form1_SizeChanged
		End Sub

		Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.Size.Width <= initialCollapsiblePanelSize.Width + 10 OrElse Me.Size.Height <= initialCollapsiblePanelSize.Height + 10 Then
				Me.radPanelDemoHolder.Dock = DockStyle.Fill
			Else
				Me.radPanelDemoHolder.Dock = DockStyle.None
				Me.radCollapsiblePanel1.Size = Me.initialCollapsiblePanelSize
				Me.radCollapsiblePanel1.CollapsiblePanelElement.InvalidateMeasure(True)
			End If
		End Sub

		Private Sub InitializePeopleInfo()
			Me.personInfoControl1.PersonName = "Bob Smiil"
			Me.personInfoControl1.PersonEmail = "BobSmiil@mail.com"
			Me.personInfoControl1.PersonPhone = "Phone: 33 2334"
			Me.personInfoControl1.PersonImage = My.Resources.BobSmill

			Me.personInfoControl2.PersonName = "Andew Fuller"
			Me.personInfoControl2.PersonEmail = "AndewFuller@mail.com"
			Me.personInfoControl2.PersonPhone = "Phone: 55 1571"
			Me.personInfoControl2.PersonImage = My.Resources.AndrewFuller

			Me.personInfoControl3.PersonName = "Anne Dodsworth"
			Me.personInfoControl3.PersonEmail = "Dodsworth@mail.com"
			Me.personInfoControl3.PersonPhone = "Phone: 32 1342"
			Me.personInfoControl3.PersonImage = My.Resources.AnneDodsworth

			Me.personInfoControl4.PersonName = "Emily Smile"
			Me.personInfoControl4.PersonEmail = "SmileEmily@mail.com"
			Me.personInfoControl4.PersonPhone = "Phone: 95 2513"
			Me.personInfoControl4.PersonImage = My.Resources.EmilySmile
		End Sub

		Private Sub InitializeAnimationEasingTypes()
			Me.MapEnumToDictionary(Of RadEasingType)(Me.animationEasingTypeMap)
			Me.animationEasingTypeDropDownList.DataSource = Me.animationEasingTypeMap.Keys
		End Sub

		Private Sub InitializeAnimationTypes()
			Me.MapEnumToDictionary(Of CollapsiblePanelAnimationType)(Me.animationTypeMap)
			Me.animationTypeDropDownList.DataSource = Me.animationTypeMap.Keys
		End Sub

		Private Sub InitializeVerticalHeaderAlignment()
			Me.MapEnumToDictionary(Of RadVerticalAlignment)(Me.verticalHeaderAlignmentMap)
			Me.verticalHeaderAlignmentDropDownList.DataSource = Me.verticalHeaderAlignmentMap.Keys
		End Sub

		Private Sub InitializeHorizontalHeaderAlignment()
			Me.MapEnumToDictionary(Of RadHorizontalAlignment)(Me.horizontalHeaderAlignmentMap)
			Me.horizontalHeaderAlignmentDropDownList.DataSource = Me.horizontalHeaderAlignmentMap.Keys
		End Sub

		Private Sub InitializeAnimations()
			Me.enableAnimationCheckBox.Checked = True

			Me.animationFramesSpinEditor.Value = Me.radCollapsiblePanel1.AnimationFrames
			Me.animationFramesSpinEditor.Maximum = Integer.MaxValue
			Me.animationFramesSpinEditor.Minimum = Integer.MinValue

			Me.animationIntervalSpinEditor.Value = Me.radCollapsiblePanel1.AnimationInterval
			Me.animationIntervalSpinEditor.Maximum = Integer.MaxValue
			Me.animationIntervalSpinEditor.Minimum = Integer.MinValue
		End Sub

		Private Sub animationIntervalSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCollapsiblePanel1.AnimationInterval = CInt(Fix(Me.animationIntervalSpinEditor.Value))
		End Sub

		Private Sub animationFramesSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCollapsiblePanel1.AnimationFrames = CInt(Fix(Me.animationFramesSpinEditor.Value))
		End Sub

		Private Sub InitializeContentSizingMode()
			Me.MapEnumToDictionary(Of CollapsiblePanelContentSizingMode)(Me.contentSizingModeMap)
			Me.contentSizingModeMap("Both") = CollapsiblePanelContentSizingMode.FitToContentHeight Or CollapsiblePanelContentSizingMode.FitToContentWidth
			Me.contentSizingModeDropDownList.DataSource = Me.contentSizingModeMap.Keys
		End Sub

		Private Sub InitializeExpandDirection()
			Me.MapEnumToDictionary(Of RadDirection)(Me.expandDirectionMap)
			Me.expandDirectionDropDownList.DataSource = Me.expandDirectionMap.Keys
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.expandDirectionDropDownList.SelectedValueChanged, AddressOf expandDirectionDropDownList_SelectedValueChanged
			AddHandler Me.contentSizingModeDropDownList.SelectedValueChanged, AddressOf contentSizingModeDropDownList_SelectedValueChanged
			AddHandler Me.enableAnimationCheckBox.ToggleStateChanged, AddressOf enableAnimationCheckBox_ToggleStateChanged
			AddHandler Me.showHeaderLineCheckBox.ToggleStateChanged, AddressOf showHeaderLineCheckBox_ToggleStateChanged
			AddHandler Me.animationFramesSpinEditor.ValueChanged, AddressOf animationFramesSpinEditor_ValueChanged
			AddHandler Me.animationIntervalSpinEditor.ValueChanged, AddressOf animationIntervalSpinEditor_ValueChanged
			AddHandler Me.horizontalHeaderAlignmentDropDownList.SelectedValueChanged, AddressOf horizontalHeaderAlignmentDropDownList_SelectedValueChanged
			AddHandler Me.verticalHeaderAlignmentDropDownList.SelectedValueChanged, AddressOf verticalHeaderAlignmentDropDownList_SelectedValueChanged
			AddHandler Me.rightToLeftCheckBox.ToggleStateChanged, AddressOf rightToLeftCheckBox_ToggleStateChanged
			AddHandler Me.animationTypeDropDownList.SelectedValueChanged, AddressOf animationTypeDropDownList_SelectedValueChanged
			AddHandler Me.animationEasingTypeDropDownList.SelectedValueChanged, AddressOf animationEasingTypeDropDownList_SelectedValueChanged
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.expandDirectionDropDownList.SelectedValue = Me.radCollapsiblePanel1.ExpandDirection.ToString()
			Me.contentSizingModeDropDownList.SelectedValue = Me.radCollapsiblePanel1.ContentSizingMode.ToString()
			Me.horizontalHeaderAlignmentDropDownList.SelectedValue = Me.radCollapsiblePanel1.HorizontalHeaderAlignment.ToString()
			Me.verticalHeaderAlignmentDropDownList.SelectedValue = Me.radCollapsiblePanel1.VerticalHeaderAlignment.ToString()
			Me.animationTypeDropDownList.SelectedValue = Me.radCollapsiblePanel1.AnimationType.ToString()
			Me.animationEasingTypeDropDownList.SelectedValue = Me.radCollapsiblePanel1.AnimationEasingType.ToString()

			Me.initialCollapsiblePanelSize = Me.radCollapsiblePanel1.Size
		End Sub

		Private Sub animationEasingTypeDropDownList_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.animationEasingTypeMap.ContainsKey(Me.animationEasingTypeDropDownList.SelectedItem.Text) Then
				Me.radCollapsiblePanel1.AnimationEasingType = Me.animationEasingTypeMap(Me.animationEasingTypeDropDownList.SelectedItem.Text)
			End If
		End Sub

		Private Sub animationTypeDropDownList_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.animationTypeMap.ContainsKey(Me.animationTypeDropDownList.SelectedItem.Text) Then
				Me.radCollapsiblePanel1.AnimationType = Me.animationTypeMap(Me.animationTypeDropDownList.SelectedItem.Text)
			End If
		End Sub

		Private Sub rightToLeftCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radCollapsiblePanel1.CollapsiblePanelElement.RightToLeft = Me.rightToLeftCheckBox.Checked
		End Sub

		Private Sub verticalHeaderAlignmentDropDownList_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.verticalHeaderAlignmentMap.ContainsKey(Me.verticalHeaderAlignmentDropDownList.SelectedItem.Text) Then
				Me.radCollapsiblePanel1.VerticalHeaderAlignment = Me.verticalHeaderAlignmentMap(Me.verticalHeaderAlignmentDropDownList.SelectedItem.Text)
			End If
		End Sub

		Private Sub horizontalHeaderAlignmentDropDownList_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.horizontalHeaderAlignmentMap.ContainsKey(Me.horizontalHeaderAlignmentDropDownList.SelectedItem.Text) Then
				Me.radCollapsiblePanel1.HorizontalHeaderAlignment = Me.horizontalHeaderAlignmentMap(Me.horizontalHeaderAlignmentDropDownList.SelectedItem.Text)
			End If
		End Sub

		Private Sub showHeaderLineCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radCollapsiblePanel1.ShowHeaderLine = Me.showHeaderLineCheckBox.Checked
		End Sub

		Private Sub contentSizingModeDropDownList_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.contentSizingModeMap.ContainsKey(Me.contentSizingModeDropDownList.SelectedItem.Text) Then
				Me.radCollapsiblePanel1.ContentSizingMode = Me.contentSizingModeMap(Me.contentSizingModeDropDownList.SelectedItem.Text)
			End If
		End Sub

		Private Sub enableAnimationCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Dim enableAnimation As Boolean = Me.enableAnimationCheckBox.Checked
			Me.radCollapsiblePanel1.EnableAnimation = enableAnimation
			Me.animationFramesSpinEditor.Enabled = enableAnimation
			Me.animationIntervalSpinEditor.Enabled = enableAnimation
		End Sub

		Private Sub expandDirectionDropDownList_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.expandDirectionMap.ContainsKey(Me.expandDirectionDropDownList.SelectedItem.Text) Then
				Me.radCollapsiblePanel1.ExpandDirection = Me.expandDirectionMap(Me.expandDirectionDropDownList.SelectedItem.Text)
			End If
		End Sub

		Private Sub MapEnumToDictionary(Of T)(ByVal map As Dictionary(Of String, T))
			If Not GetType(T).IsEnum Then
				Throw New ArgumentException(String.Format("T must be of type {0}, it is of type {1} instead", GetType(System.Enum), GetType(T)))
			End If

			Dim enumItems As Array = System.Enum.GetValues(GetType(T))
			For Each item As T In enumItems
				map(item.ToString()) = item
			Next item
		End Sub
	End Class
End Namespace
