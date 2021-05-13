Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.Themes.Design
Imports Telerik.WinControls
Imports System.Xml.XPath
Imports System.Xml
Imports Telerik.QuickStart.WinControls
Namespace Telerik.Examples.WinControls.TrackStatusControls.ProgressBar
    ''' <summary>
    ''' Example beautifying 
    ''' </summary>
    Partial Public Class Form1
        Inherits ExamplesForm
        Private check As Boolean

        Public Sub New()
            InitializeComponent()

            Me.SelectedControl = Me.radProgressBar1
        End Sub

        Private Sub timer1_Tick(sender As Object, e As EventArgs)

            If Not check Then
                If radProgressBar1.Value1 < radProgressBar1.Maximum Then
                    radProgressBar1.Value1 += 1
                    radProgressBar2.Value1 += 1
                    radProgressBar4.Value1 += 1
                    radProgressBar6.Value1 += 1
                Else
                    check = True
                End If
            Else
                If radProgressBar1.Value1 > radProgressBar1.Minimum Then
                    radProgressBar1.Value1 -= 1
                    radProgressBar2.Value1 -= 1
                    radProgressBar4.Value1 -= 1

                    radProgressBar6.Value1 -= 1
                Else
                    check = False
                End If
            End If
        End Sub

        Private Sub radTrackBar1_Scroll(sender As Object, e As ScrollEventArgs)
            radProgressBar5.Value1 = CInt(Me.radTrackBar1.Value) * 10
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler Me.timer1.Tick, AddressOf Me.timer1_Tick
            AddHandler Me.radTrackBar1.Scroll, AddressOf Me.radTrackBar1_Scroll
        End Sub
    End Class
End Namespace