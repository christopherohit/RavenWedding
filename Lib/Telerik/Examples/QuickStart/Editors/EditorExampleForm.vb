Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Editors
    Partial Public Class EditorExampleBaseForm
        Inherits ExamplesForm

        Private centerPanel_Field As Boolean = False

        Public Sub New()
            InitializeComponent()
            Me.radPanelDemoHolder.PanelElement.PanelFill.Visibility = ElementVisibility.Collapsed
            Me.radPanelDemoHolder.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Dock = DockStyle.Fill
            Me.radPanelDemoHolder.Padding = New Padding(0)
            Me.Padding = New Padding(0)
        End Sub

        Public Property CenterPanel As Boolean
            Get
                Return Me.centerPanel_Field
            End Get
            Set(ByVal value As Boolean)
                Me.centerPanel_Field = value

                If Me.centerPanel_Field Then
                    Me.CenteredControl = Me.radPanelDemoHolder
                    Me.CenterControl()
                Else
                    Me.CenteredControl = Nothing
                    Me.radPanelDemoHolder.Location = Point.Empty
                End If
            End Set
        End Property
    End Class
End Namespace
