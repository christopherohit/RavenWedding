Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports System.Xml.Serialization
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.Threading
Imports Telerik.WinControls.Data

Namespace Telerik.Examples.WinControls.GridView.Grouping

	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub BindGrid()
			Me.SelectedControl = Me.radGridView1
			Me.radGridView1.Size = New Size(Me.radGridView1.Width, 690)

			Me.radGridView1.TableElement.BeginUpdate()

			Me.customersTableAdapter.Fill(Me.northwindDataSet.Customers)

			radGridView1.MasterTemplate.AutoExpandGroups = True
			radGridView1.MasterTemplate.EnableFiltering = True
			radGridView1.ShowGroupPanel = True
			radGridView1.EnableHotTracking = True


			Me.radGridView1.TableElement.EndUpdate(False)

			radGridView1.TableElement.CellSpacing = -1
			radGridView1.TableElement.TableHeaderHeight = 35
			radGridView1.TableElement.GroupHeaderHeight = 30
			radGridView1.TableElement.RowHeight = 25
		End Sub



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.BindGrid()
			Me.InitializeGrouping()
			Me.InitializePreferences()
		End Sub

		Private Sub InitializeGrouping()
			Me.radRadioCityCountry.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.GroupByCountryCity()
		End Sub

		Private Sub InitializePreferences()
			Me.radCheckBoxShowGroupPanel.Checked = Me.radGridView1.ShowGroupPanel
			Me.radRadioAnimSlide.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.Slide
		End Sub

		Private Sub GroupByCountryCity()
			Me.ClearGrouping()

			Me.radGridView1.GroupDescriptors.Add(New GridGroupByExpression("Country as Country format ""{0}: {1}"" Group By Country"))
			Me.radGridView1.GroupDescriptors.Add(New GridGroupByExpression("City as City format ""{0}: {1}"" Group By City"))

		End Sub


		Private Sub GroupByCountry()
			Me.ClearGrouping()
			Me.radGridView1.GroupDescriptors.Add(New GridGroupByExpression("Country as Country format ""{0}: {1}"" Group By Country"))

		End Sub

		Private Sub ClearGrouping()
			Me.radGridView1.GroupDescriptors.Clear()
		End Sub

		Private Sub GroupByCity()
			Me.ClearGrouping()
			Me.radGridView1.GroupDescriptors.Add(New GridGroupByExpression("City as City format ""{0}: {1}"" Group By City"))
		End Sub

		#Region "Expand/Collapse methods"

		Private Sub Collapse(ByVal row As GridViewGroupRowInfo)
			For Each childRow As GridViewRowInfo In row.ChildRows
				Dim groupRow As GridViewGroupRowInfo = TryCast(childRow, GridViewGroupRowInfo)

				If groupRow IsNot Nothing Then
					groupRow.IsExpanded = False
					Collapse(groupRow)
				End If
			Next childRow
		End Sub

		#End Region

		#Region "Event handlers"

		Private Sub OnBtnExpand_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radBtnExpandAll.Click
			Me.radGridView1.MasterTemplate.ExpandAllGroups()
		End Sub

		Private Sub OnBtnCollapse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radBtnCollapseAll.Click
			Me.radGridView1.MasterTemplate.CollapseAllGroups()
		End Sub

		Private Sub OnCheckBoxShowGroupPanel_StateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxShowGroupPanel.ToggleStateChanged
			Me.radGridView1.ShowGroupPanel = Me.radCheckBoxShowGroupPanel.Checked
		End Sub

		Private Sub OnRadioAnimation_StateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioAnimNone.ToggleStateChanged, radRadioAnimSlide.ToggleStateChanged, radRadioAnimFade.ToggleStateChanged, radRadioAnimWipe.ToggleStateChanged, radRadioAnimAccordion.ToggleStateChanged
			If Me.radRadioAnimWipe.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.GradientWipe
			ElseIf Me.radRadioAnimSlide.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.Slide
			ElseIf Me.radRadioAnimAccordion.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.Accordion
			ElseIf Me.radRadioAnimFade.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.Fade
			Else
				Me.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.None
			End If

		End Sub

		#End Region

		Private Sub OnRadioGroupType_StateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioCityCountry.ToggleStateChanged, radRadioDisable.ToggleStateChanged, radRadioNone.ToggleStateChanged, radRadioCountry.ToggleStateChanged, radRadioCity.ToggleStateChanged
			If (Not Me.radGridView1.MasterTemplate.AllowDragToGroup) AndAlso Me.radRadioDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
				Me.radGridView1.MasterTemplate.AllowDragToGroup = True
				Me.radGridView1.EnableGrouping = True
			End If

			If Me.radRadioCity.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.GroupByCity()
			ElseIf Me.radRadioCityCountry.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.GroupByCountryCity()
			ElseIf Me.radRadioCountry.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.GroupByCountry()
			ElseIf Me.radRadioNone.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.ClearGrouping()
			Else
				Me.ClearGrouping()
				Me.radGridView1.MasterTemplate.AllowDragToGroup = False
				Me.radGridView1.MasterTemplate.EnableGrouping = False
			End If
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
