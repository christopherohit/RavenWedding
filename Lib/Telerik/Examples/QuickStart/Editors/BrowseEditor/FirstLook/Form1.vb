Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Private viewModel As ViewModel
        Private waitingBar As RadWaitingBar
        Private isInTouchTheme As Boolean

        Public Sub New()
            InitializeComponent()
            Me.waitingBar = New RadWaitingBar()
            Me.waitingBar.Parent = Me
            Me.waitingBar.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsLine
            Me.CenterPanel = True
            Me.CenteredControl = Me.filesHolderPanel
            Me.DataContext = New ViewModel()
            AddHandler Me.DataContext.Files.CollectionChanged, AddressOf Me.Files_CollectionChanged
            Me.BindInitialFileDataViewModels()
        End Sub

        Private Sub Files_CollectionChanged(ByVal sender As Object, ByVal e As System.Collections.Specialized.NotifyCollectionChangedEventArgs)
            If e.Action = System.Collections.Specialized.NotifyCollectionChangedAction.Remove AndAlso e.OldItems IsNot Nothing AndAlso e.OldItems.Count = 1 Then
                Dim filePathUserControl As FilePathUserControl = Nothing

                For Each child As Control In Me.filesHolderPanel.Controls
                    filePathUserControl = TryCast(child, FilePathUserControl)

                    If filePathUserControl Is Nothing Then
                        Continue For
                    End If

                    If e.OldItems(0) Is filePathUserControl.FileViewModel Then
                        Exit For
                    End If

                    filePathUserControl = Nothing
                Next

                If filePathUserControl IsNot Nothing Then
                    Me.filesHolderPanel.Controls.Remove(filePathUserControl)
                End If
            ElseIf e.Action = System.Collections.Specialized.NotifyCollectionChangedAction.Reset Then

                If Me.waitingBar.IsWaiting Then
                    Me.waitingBar.StopWaiting()
                    Me.waitingBar.AssociatedControl = Nothing
                End If

                For i As Integer = Me.filesHolderPanel.Controls.Count - 1 To 0 Step -1

                    If TypeOf Me.filesHolderPanel.Controls(i) Is FilePathUserControl Then
                        Me.filesHolderPanel.Controls.RemoveAt(i)
                    End If
                Next

                Me.BeginInvoke(New Action(AddressOf Me.AddNewFile))
            End If

            If Me.DataContext.RemoveFileCommand.CanExecute(Nothing) Then

                For Each child As Control In Me.filesHolderPanel.Controls
                    Dim filePathUserControl As FilePathUserControl = TryCast(child, FilePathUserControl)

                    If filePathUserControl Is Nothing Then
                        Continue For
                    End If

                    filePathUserControl.DeleteButton.Enabled = True
                Next
            Else

                For Each child As Control In Me.filesHolderPanel.Controls
                    Dim filePathUserControl As FilePathUserControl = TryCast(child, FilePathUserControl)

                    If filePathUserControl Is Nothing Then
                        Continue For
                    End If

                    filePathUserControl.DeleteButton.Enabled = False
                Next
            End If

            If Me.DataContext.UploadFilesCommand.CanExecute(Nothing) Then
                Me.uploadFilesBtn.Enabled = True
            Else
                Me.uploadFilesBtn.Enabled = False
            End If

            If Me.DataContext.AddNewFileCommand.CanExecute(Nothing) Then
                Me.addNewBtn.Enabled = True
            Else
                Me.addNewBtn.Enabled = False
            End If
        End Sub

        Public Property DataContext As ViewModel
            Get
                Return Me.viewModel
            End Get
            Friend Set(ByVal value As ViewModel)
                Me.viewModel = value
            End Set
        End Property

        Private Sub AddNewBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.AddNewFile()
        End Sub

        Private Sub AddNewFile()
            If Me.DataContext.AddNewFileCommand.CanExecute(Nothing) Then
                Dim data As FileData = New FileData()
                AddHandler data.PropertyChanged, AddressOf Me.Data_PropertyChanged
                Dim filePathUserControl As FilePathUserControl = New FilePathUserControl(data)
                ThemeResolutionService.ApplyThemeToControlTree(filePathUserControl, Me.CurrentThemeName)

                If Me.isInTouchTheme Then
                    filePathUserControl.Height += TelerikDpiHelper.ScaleInt(10, Me.filesHolderPanel.RootElement.DpiScaleFactor)
                End If

                Me.filesHolderPanel.Controls.Add(filePathUserControl)
                filePathUserControl.Scale(Me.filesHolderPanel.RootElement.DpiScaleFactor)
                Me.filesHolderPanel.Controls.SetChildIndex(filePathUserControl, 0)
                filePathUserControl.Dock = DockStyle.Top

                Me.DataContext.AddNewFileCommand.Execute(data)
            End If
        End Sub

        Private Sub UploadFilesBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.DataContext.UploadFilesCommand.CanExecute(Nothing) Then
                Me.DataContext.UploadFilesCommand.Execute(Nothing)
                Me.waitingBar.AssociatedControl = Me.filesHolderPanel
                Me.waitingBar.StartWaiting()
            End If
        End Sub

        Private Sub Data_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
            Dim data As FileData = TryCast(sender, FileData)

            If e.PropertyName = "State" AndAlso data IsNot Nothing AndAlso data.State = FileDataState.Deleted Then

                If Me.DataContext.RemoveFileCommand.CanExecute(Nothing) Then
                    Me.DataContext.RemoveFileCommand.Execute(data)
                Else
                    data.State = FileDataState.Added
                End If
            ElseIf e.PropertyName = "FilePath" Then
                Me.DataContext.FilePathChangedCommand.Execute(data)

                If Me.DataContext.UploadFilesCommand.CanExecute(Nothing) Then
                    Me.uploadFilesBtn.Enabled = True
                Else
                    Me.uploadFilesBtn.Enabled = False
                End If
            End If
        End Sub

        Private Sub BindInitialFileDataViewModels()
            Me.filePathUserControl1.FileViewModel = Me.DataContext.Files(0)
            AddHandler Me.filePathUserControl1.FileViewModel.PropertyChanged, AddressOf Data_PropertyChanged
            Me.filePathUserControl2.FileViewModel = Me.DataContext.Files(1)
            AddHandler Me.filePathUserControl2.FileViewModel.PropertyChanged, AddressOf Data_PropertyChanged
            Me.filePathUserControl3.FileViewModel = Me.DataContext.Files(2)
            AddHandler Me.filePathUserControl3.FileViewModel.PropertyChanged, AddressOf Data_PropertyChanged
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            If Not Me.isInTouchTheme AndAlso (TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) OrElse TelerikHelper.IsMetroTouchTheme(Me.CurrentThemeName)) Then
                Me.isInTouchTheme = True
                Dim xOffset As Integer = TelerikDpiHelper.ScaleInt(50, Me.addNewBtn.RootElement.DpiScaleFactor)
                Dim yOffset As Integer = TelerikDpiHelper.ScaleInt(10, Me.addNewBtn.RootElement.DpiScaleFactor)
                Me.headerLabel.Font = New Font(Me.headerLabel.Font.Name, 20, Me.headerLabel.Font.Style)

                For Each child As Control In Me.filesHolderPanel.Controls
                    Dim filePathUserControl As FilePathUserControl = TryCast(child, FilePathUserControl)

                    If filePathUserControl Is Nothing Then
                        Continue For
                    End If

                    filePathUserControl.Height += yOffset
                Next

                Me.addNewBtn.Location = New Point(Me.addNewBtn.Location.X - xOffset, Me.addNewBtn.Location.Y + yOffset * 4)
                Me.addNewBtn.Width += CInt(xOffset / 2)
                Me.uploadFilesBtn.Location = New Point(CInt(Me.uploadFilesBtn.Location.X - xOffset / 2), Me.uploadFilesBtn.Location.Y + yOffset * 4)
                Me.uploadFilesBtn.Width += CInt(xOffset / 2)
                Me.headerLabel.Height += yOffset * 2
                Me.filesHolderPanel.Height += yOffset * 4
            ElseIf Not Me.isInTouchTheme Then
                Me.headerLabel.Font = New Font(Me.headerLabel.Font.Name, 16, Me.headerLabel.Font.Style)
            End If
        End Sub
    End Class
End Namespace
