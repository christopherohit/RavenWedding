Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.LayoutControl.FirstLook
    Partial Public Class Form1
        Inherits RadForm
        Implements ISupportThemeName
        Public Sub New(themeName As String)
            Me.New()
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
            ' TODO: This line of code loads data into the 'northwindDataSet.EmployeeOrders' table. You can move, or remove it, as needed.
            Me.employeeOrdersTableAdapter.Fill(Me.northwindDataSet.EmployeeOrders)
        End Sub

        Public Sub ApplyTheme(themeName As String) Implements ISupportThemeName.ApplyTheme
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub
    End Class
End Namespace
