Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.SplitContainer.FirstLook
	''' <summary>
	''' example form
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesRadForm
		Implements ISupportThemeName
		''' <summary>
		''' default constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()

			Dim outlookStyle As RadPageViewOutlookElement = TryCast(Me.radPanelBar1.ViewElement, RadPageViewOutlookElement)
			outlookStyle.HideItems(3)

			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radGridView2.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Dim formBehavior As New RadFormBehavior(Me)
			formBehavior.AllowTheming = True
			Me.FormBehavior = formBehavior

			Me.radRibbonBar1.RibbonBarElement.RibbonCaption.Visibility = ElementVisibility.Collapsed
			Me.radRibbonBar1.RibbonBarElement.QuickAccessToolBar.Visibility = ElementVisibility.Collapsed

			Me.carsTableAdapter.Fill(Me.northwindDataSet.Cars)
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler btnOpenDesigner.Click, AddressOf btnOpenDesigner_Click
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.OpenLayoutPropertiesForm()

			SetDefaultPanelBorderColors()
		End Sub

		Private Sub SetDefaultPanelBorderColors()
			Me.splitPanel_1.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255)
			Me.splitPanel_2.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255)
			Me.splitPanel_3.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255)
			Me.splitPanel_4.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255)
			Me.splitPanel_5.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255)
			CType(Me.radPanel1.PanelElement.Children(1), BorderPrimitive).ForeColor = Color.FromArgb(191, 225, 255)
			CType(Me.radPanel2.PanelElement.Children(1), BorderPrimitive).ForeColor = Color.FromArgb(191, 225, 255)
		End Sub

		#Region "Split Properties"

		Public ReadOnly Property RadSplitContainer1() As RadSplitContainer
			Get
				Return Me.radSplitContainer_1
			End Get
		End Property

		Public ReadOnly Property RadSplitContainer2() As RadSplitContainer
			Get
				Return Me.radSplitContainer_2
			End Get
		End Property

		Public ReadOnly Property SplitPanel1() As SplitPanel
			Get
				Return Me.splitPanel_1
			End Get
		End Property

		Public ReadOnly Property SplitPanel2() As SplitPanel
			Get
				Return Me.splitPanel_2
			End Get
		End Property

		Public ReadOnly Property SplitPanel3() As SplitPanel
			Get
				Return Me.splitPanel_3
			End Get
		End Property

		Public ReadOnly Property SplitPanel4() As SplitPanel
			Get
				Return Me.splitPanel_4
			End Get
		End Property

		Public ReadOnly Property SplitPanel5() As SplitPanel
			Get
				Return Me.splitPanel_5
			End Get
		End Property

		#End Region

		Private Sub btnOpenDesigner_Click(ByVal sender As Object, ByVal e As EventArgs)
			For Each OpenForm As Form In Application.OpenForms
				If TypeOf OpenForm Is LayoutProperties Then
					Return
				End If
			Next OpenForm

			Me.OpenLayoutPropertiesForm()
		End Sub

		Private Sub OpenLayoutPropertiesForm()
			Dim designerForm As New LayoutProperties()
			designerForm.Owner = Me
			designerForm.StartPosition = FormStartPosition.CenterScreen
			designerForm.Show()
			ThemeResolutionService.ApplyThemeToControlTree(designerForm, Me.ThemeName)
		End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            Me.ThemeName = themeName
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub
    End Class
End Namespace