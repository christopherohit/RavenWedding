Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.UI
Imports System.Threading

Namespace FileExplorer
	Partial Public Class WaitingForm
		Inherits RadForm
		Private Shared waitingThread As Thread
'INSTANT VB NOTE: The variable waitingForm was renamed since Visual Basic does not allow class members with the same name:
		Private Shared waitingForm_Renamed As WaitingForm

		Public Sub New()
			InitializeComponent()
			Me.radWaitingBar1.StartWaiting()
		End Sub

		Public Shared Sub ShowForm(ByVal owner As Form)
			waitingThread = New Thread(New ParameterizedThreadStart(AddressOf ThreadTask))
			waitingThread.IsBackground = False
			waitingThread.Start(owner)
		End Sub

		Private Shared Sub ThreadTask(ByVal owner As Object)
			'initialize the form
			waitingForm_Renamed = New WaitingForm()
			waitingForm_Renamed.ShowInTaskbar = False
			waitingForm_Renamed.Owner = CType(owner, Form)
            waitingForm_Renamed.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			waitingForm_Renamed.ControlBox = False
			waitingForm_Renamed.TopMost = True
			waitingForm_Renamed.StartPosition = FormStartPosition.CenterScreen
			Application.Run(waitingForm_Renamed)
		End Sub

		Public Shared Sub CloseDialogDown()
			Application.ExitThread()
		End Sub

		Public Shared Sub CloseForm()
            While waitingForm_Renamed Is Nothing OrElse Not waitingForm_Renamed.IsHandleCreated
                Thread.Sleep(10)
            End While
            Dim mi As New MethodInvoker(AddressOf CloseDialogDown)
            waitingForm_Renamed.Invoke(mi)
		End Sub
	End Class
End Namespace
