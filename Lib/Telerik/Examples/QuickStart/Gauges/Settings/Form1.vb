Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI.Gauges
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Gauges.Settings
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm
        Private [step] As Single = 0.18F

        Public Sub New()
            Me.InitializeComponent()
            Me.radDropDownList1.SelectedIndex = 0
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.timer1.Interval = 100
            AddHandler Me.timer1.Tick, AddressOf timer1_Tick
            Me.timer1.Start()
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.radialGaugeNeedle1.Value + Me.step >= Me.radRadialGauge1.RangeEnd OrElse Me.radialGaugeNeedle1.Value + Me.step <= Me.radRadialGauge1.RangeStart Then
                Me.step = -Me.step
            End If
            Me.radialGaugeNeedle1.Value += Me.step
        End Sub

        Private Sub spinNeedleLenght_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinNeedleLenght.ValueChanged
            Me.radialGaugeNeedle1.LenghtPercentage = CDbl(Me.spinNeedleLenght.Value)
        End Sub

        Private Sub spinNeedleThickness_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinNeedleThickness.ValueChanged
            Me.radialGaugeNeedle1.Thickness = CDbl(Me.spinNeedleThickness.Value)
        End Sub

        Private Sub spinInnerPointRadiusPercentage_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinInnerPointRadiusPercentage.ValueChanged
            Me.radialGaugeNeedle1.InnerPointRadiusPercentage = CDbl(Me.spinInnerPointRadiusPercentage.Value)
        End Sub

        Private Sub spinPointRadiusPercentage_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinPointRadiusPercentage.ValueChanged
            Me.radialGaugeNeedle1.PointRadiusPercentage = CDbl(Me.spinPointRadiusPercentage.Value)
        End Sub

        Private Sub spinTicksCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinTicksCount.ValueChanged
            Me.radialGaugeTicks1.TicksCount = CInt(Fix(Me.spinTicksCount.Value - 1))
        End Sub

        Private Sub spinTickTickness_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinTickTickness.ValueChanged
            Me.radialGaugeTicks1.TickThickness = CSng(Me.spinTickTickness.Value)
        End Sub

        Private Sub spinTicksLenght_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinTicksLenght.ValueChanged
            Me.radialGaugeTicks1.TicksLenghtPercentage = CSng(Me.spinTicksLenght.Value)
        End Sub

        Private Sub radLabelCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinLabelCount.ValueChanged
            Me.radialGaugeLabels1.LabelsCount = CInt(Fix(Me.spinLabelCount.Value - 1))
        End Sub

        Private Sub spinLabelRadius_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinLabelRadius.ValueChanged
            Me.radialGaugeLabels1.LabelRadiusPercentage = CSng(Me.spinLabelRadius.Value)
        End Sub

        Private Sub spinArc1Width_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinArc1Width.ValueChanged
            Select Case Me.radDropDownList1.SelectedIndex
                Case 0
                    Me.radialGaugeArc1.Width = CDbl(Me.spinArc1Width.Value)
                Case 1
                    Me.radialGaugeArc2.Width = CDbl(Me.spinArc1Width.Value)
                Case 2
                    Me.radialGaugeArc3.Width = CDbl(Me.spinArc1Width.Value)
            End Select
        End Sub

        Private Sub spinArc1Radius_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinArc1Radius.ValueChanged
            Select Case Me.radDropDownList1.SelectedIndex
                Case 0
                    Me.radialGaugeArc1.Radius = CDbl(Me.spinArc1Radius.Value)
                Case 1
                    Me.radialGaugeArc2.Radius = CDbl(Me.spinArc1Radius.Value)
                Case 2
                    Me.radialGaugeArc3.Radius = CDbl(Me.spinArc1Radius.Value)
            End Select
        End Sub

        Private Sub colorBoxTicks_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorBoxTicks.ValueChanged
            Me.radialGaugeTicks1.TickColor = Me.colorBoxTicks.Value

        End Sub

        Private Sub colorBoxArc_ValueChanged(sender As Object, e As EventArgs) Handles colorBoxArc.ValueChanged
            Select Case Me.radDropDownList1.SelectedIndex
                Case 0
                    Me.radialGaugeArc1.BackColor = Me.colorBoxArc.Value
                    Me.radialGaugeArc1.BackColor2 = Me.radialGaugeArc1.BackColor
                Case 1
                    Me.radialGaugeArc2.BackColor = Me.colorBoxArc.Value
                    Me.radialGaugeArc2.BackColor2 = Me.radialGaugeArc2.BackColor
                Case 2
                    Me.radialGaugeArc3.BackColor = Me.colorBoxArc.Value
                    Me.radialGaugeArc3.BackColor2 = Me.radialGaugeArc3.BackColor
            End Select
        End Sub

        Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownList1.SelectedIndexChanged
            Select Case Me.radDropDownList1.SelectedIndex
                Case 0
                    Me.colorBoxArc.Value = Me.radialGaugeArc1.BackColor
                    Me.spinArc1Radius.Value = CDec(Me.radialGaugeArc1.Radius)
                    Me.spinArc1Width.Value = CDec(Me.radialGaugeArc1.Width)
                Case 1
                    Me.colorBoxArc.Value = Me.radialGaugeArc2.BackColor
                    Me.spinArc1Radius.Value = CDec(Me.radialGaugeArc2.Radius)
                    Me.spinArc1Width.Value = CDec(Me.radialGaugeArc2.Width)
                Case 2
                    Me.colorBoxArc.Value = Me.radialGaugeArc3.BackColor
                    Me.spinArc1Radius.Value = CDec(Me.radialGaugeArc3.Radius)
                    Me.spinArc1Width.Value = CDec(Me.radialGaugeArc3.Width)
            End Select
        End Sub

        Public Sub SaveLayout(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()

            saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
            saveFileDialog.RestoreDirectory = True

            If saveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.radRadialGauge1.SaveLayout(saveFileDialog.FileName)
            End If
        End Sub

        Public Sub LoadLayout(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()

            openFileDialog.InitialDirectory = "c:\"
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
            openFileDialog.RestoreDirectory = True
            If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.radRadialGauge1.LoadLayout(openFileDialog.FileName)
                DisableEditors()
            End If
        End Sub

        Private Sub DisableEditors()
            For Each cnt As Control In Me.radRadialGauge1.Parent.Controls
                If TypeOf cnt Is RadRadialGauge OrElse TypeOf cnt Is RadButton OrElse TypeOf cnt Is RadLabel Then
                    Continue For
                End If

                cnt.Enabled = False
            Next
        End Sub
    End Class
End Namespace