
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System

Namespace RichTextEditor
    Partial Public Class SplashForm
        Inherits Form
        Public Sub New()
            InitializeComponent()
            Me.radWaitingBar1.ThemeName = Program.ThemeName
        End Sub

        Protected Overrides Sub OnShown(e As EventArgs)
            MyBase.OnShown(e)
            Me.radWaitingBar1.StartWaiting()
        End Sub

        Protected Overrides Sub OnClosing(e As CancelEventArgs)
            MyBase.OnClosing(e)
            Me.radWaitingBar1.StopWaiting()
        End Sub

    End Class
End Namespace


