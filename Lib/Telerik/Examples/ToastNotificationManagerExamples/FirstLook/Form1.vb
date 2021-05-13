Imports System
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.RadToastNotificationManager
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls
Imports System.ComponentModel
Imports System.IO
Imports My.Resources

Namespace ToastNotificationManagerExamples.FirstLook
    Partial Public Class Form1
        Inherits RadForm

        Private manager As RadToastNotificationManager

        Public Sub New()
            InitializeComponent()
            AddHandler Disposed, New EventHandler(AddressOf Form1_Disposed)
            manager = New RadToastNotificationManager(components)
            manager.Register()
            AddHandler RadToastNotificationManager.RadToastActivated, New RadToastActivatedEventHandler(AddressOf RadToastNotificationManager_RadToastActivated)
            CType(Me, ISupportInitialize).BeginInit()
            Dim tabIndedx As Integer = 1
            Dim stepSize As Integer = 40
            Dim buttonLocationX As Integer = Width / 2 - 95
            Dim buttonLocationY As Integer = 80
            Dim buttonWidth As Integer = 190
            Dim buttonHeight As Integer = 26
            Dim imageSize As Integer = 32
            Dim smallFix As Integer = 0
            Dim templateTypes As IEnumerable(Of RadToastTemplateType) = [Enum].GetValues(GetType(RadToastTemplateType)).Cast(Of RadToastTemplateType)()

            For Each type As RadToastTemplateType In templateTypes

                If type = RadToastTemplateType.ToastGeneric OrElse type = RadToastTemplateType.ToastLegacy Then
                    Continue For
                End If

                Dim button As RadButton = New RadButton With {
                    .Location = New System.Drawing.Point(buttonLocationX, buttonLocationY),
                    .Size = New System.Drawing.Size(buttonWidth, buttonHeight),
                    .TabIndex = Math.Min(System.Threading.Interlocked.Increment(tabIndedx), tabIndedx - 1),
                    .Text = "Show " & type.ToString().Replace("Toast", "") & " Toast",
                    .Tag = type,
                    .Anchor = AnchorStyles.None
                }
                AddHandler button.Click, New EventHandler(AddressOf Button_Click)
                Controls.Add(button)
                Dim svgImage As RadSvgImage = Nothing

                Try
                    Dim svgBytes As Byte() = CType(ResourceManager.GetObject(type.ToString()), Byte())
                    svgImage = RadSvgImage.FromByteArray(svgBytes)
                Catch
                End Try

                Select Case type
                    Case RadToastTemplateType.ToastNews, RadToastTemplateType.ToastAlarm, RadToastTemplateType.ToastCall
                        smallFix = 1
                    Case Else
                        smallFix = 0
                End Select

                If svgImage IsNot Nothing Then
                    Dim pictureBox As RadPictureBox = New RadPictureBox With {
                        .SvgImage = svgImage,
                        .Location = New System.Drawing.Point(buttonLocationX - imageSize - 25 - smallFix, buttonLocationY - 3),
                        .Size = New System.Drawing.Size(imageSize, imageSize),
                        .Anchor = AnchorStyles.None,
                        .ContextMenuEnabled = False,
                        .ShowBorder = False,
                        .ShowScrollBars = False
                    }
                    pictureBox.ZoomProperties.AllowZoom = False
                    pictureBox.RootElement.EnableElementShadow = False
                    Controls.Add(pictureBox)
                End If

                buttonLocationY += stepSize + buttonHeight
            Next

            CType(Me, ISupportInitialize).EndInit()
            Dim worker As BackgroundWorker = New BackgroundWorker()
            AddHandler worker.DoWork, AddressOf Worker_DoWork
            worker.RunWorkerAsync()
        End Sub

        Private Sub Worker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
            Dim tempDir As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp\Telerik\Toast\"
            Directory.CreateDirectory(tempDir)
            Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetAssembly(GetType(RadToastNotificationManager))
            Dim resourceNames As String() = myAssembly.GetManifestResourceNames()

            For Each resourceName As String In resourceNames
                If resourceName.EndsWith(".tssp") OrElse Not resourceName.Contains("TA_") Then Continue For
                Dim fileName As String = resourceName.Substring(resourceName.IndexOf("TA_"))
                Dim rStream As Stream = myAssembly.GetManifestResourceStream(resourceName)
                Dim fs As FileStream = New FileStream(tempDir & fileName, FileMode.Create)
                rStream.CopyTo(fs)
                fs.Flush()
                fs.Close()
                rStream.Close()
            Next
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim type As RadToastTemplateType = CType((TryCast(sender, RadButton)).Tag, RadToastTemplateType)
            manager.ShowNotification(New RadToastNotification(type, type.ToString()))
        End Sub

        Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As EventArgs)
            Try
                RemoveHandler RadToastNotificationManager.RadToastActivated, New RadToastActivatedEventHandler(AddressOf RadToastNotificationManager_RadToastActivated)
                manager.Unregister()
            Catch
            End Try
        End Sub

        Private Sub RadToastNotificationManager_RadToastActivated(ByVal e As RadToastActivatedEventArgs)
            Dim sb As StringBuilder = New StringBuilder()
            sb.Append("arguments: " & (If(String.IsNullOrEmpty(e.Arguments), "{null}", e.Arguments)))

            If e.UserInput IsNot Nothing AndAlso e.UserInput.Count > 0 Then

                For Each pair In e.UserInput
                    sb.AppendLine()
                    sb.Append("key: {")
                    sb.Append(pair.Key)
                    sb.Append("} value: {")
                    sb.Append(pair.Value)
                    sb.Append("}")
                Next
            End If

            RadMessageBox.SetThemeName(ThemeName)

            If InvokeRequired Then
                Dim a As Action = Sub()
                                      RadMessageBox.Show(Me, sb.ToString(), "RadToastActivated", MessageBoxButtons.OK, RadMessageIcon.Info)
                                  End Sub

                Invoke(a)
            Else
                RadMessageBox.Show(Me, sb.ToString(), "RadToastActivated", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End Sub
    End Class
End Namespace
