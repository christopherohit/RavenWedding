Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Charting
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Themes

Namespace DemoAppsHub.GridExample
	Public Partial Class GridExampleUserControl
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Event handlers"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radGridView1.ThemeName = "TelerikMetroBlue"
			AddHandler radGridView1.CreateRow, AddressOf radGridView1_CreateRow
			AddHandler radGridView1.MasterTemplate.CreateRowInfo, AddressOf MasterTemplate_CreateRowInfo

			Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)
			Me.radGridView1.TableElement.RowHeight = 45
		End Sub

		Private Sub MasterTemplate_CreateRowInfo(ByVal sender As Object, ByVal e As GridViewCreateRowInfoEventArgs)
			e.RowInfo.MinHeight = 45
		End Sub

		Private Sub radGridView1_CreateRow(ByVal sender As Object, ByVal e As GridViewCreateRowEventArgs)
			If e.RowType Is GetType(GridDataRowElement) Then
				e.RowType = GetType(GridCustomRowElement)
			End If
		End Sub

		#End Region
	End Class
End Namespace
