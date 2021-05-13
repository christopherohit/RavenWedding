Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.RichTextEditor.UI
Imports Telerik.WinForms.RichTextEditor.RichTextBoxUI.Dialogs.StyleFormattingProperties

Namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
    Public Class ViewModel
        Implements INotifyPropertyChanged

        Private _files As ObservableCollection(Of FileData)
        Private _addNewFileCommand As DelegateCommand
        Private _uploadFilesCommand As DelegateCommand
        Private _filePathChangedCommand As DelegateCommand
        Private _removeFileCommand As DelegateCommand
        Private _isBusy As Boolean
        Private _progressTimer As DispatcherTimer
        Private _progressValue As Integer

        Public Sub New()
            Me._addNewFileCommand = New DelegateCommand(AddressOf Me.OnAddNewFile, AddressOf Me.OnCanAddNewFile)
            Me._uploadFilesCommand = New DelegateCommand(AddressOf Me.OnUploadFiles, AddressOf Me.OnCanUploadFiles)
            Me._filePathChangedCommand = New DelegateCommand(AddressOf Me.OnFilePathChanged)
            Me.removeFileCommand = New DelegateCommand(AddressOf Me.OnRemoveFile, AddressOf Me.OnCanRemoveFile)
            Me._progressTimer = New DispatcherTimer()
            AddHandler Me._progressTimer.Tick, New EventHandler(AddressOf Me.OnTimerTick)
            Me._files = Me.CreateEmptyFiles()
            AddHandler Me.files.CollectionChanged, AddressOf Files_CollectionChanged
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Property Files As ObservableCollection(Of FileData)
            Get
                Return _files
            End Get
            Set(ByVal value As ObservableCollection(Of FileData))

                If Not (Me._files Is value) Then
                    Me._files = value
                    Me.OnPropertyChanged("Files")
                End If
            End Set
        End Property

        Public Property AddNewFileCommand As DelegateCommand
            Get
                Return Me._addNewFileCommand
            End Get
            Set(ByVal value As DelegateCommand)

                If Not (Me._addNewFileCommand Is value) Then
                    Me._addNewFileCommand = value
                    Me.OnPropertyChanged("AddNewFileCommand")
                End If
            End Set
        End Property

        Public Property UploadFilesCommand As DelegateCommand
            Get
                Return _uploadFilesCommand
            End Get
            Set(ByVal value As DelegateCommand)

                If Not (Me._uploadFilesCommand Is value) Then
                    Me._uploadFilesCommand = value
                    Me.OnPropertyChanged("UploadFilesCommand")
                End If
            End Set
        End Property

        Public Property FilePathChangedCommand As DelegateCommand
            Get
                Return _filePathChangedCommand
            End Get
            Set(ByVal value As DelegateCommand)

                If Not (Me._filePathChangedCommand Is value) Then
                    Me._filePathChangedCommand = value
                    Me.OnPropertyChanged("FilePathChangedCommand")
                End If
            End Set
        End Property

        Public Property RemoveFileCommand As DelegateCommand
            Get
                Return _removeFileCommand
            End Get
            Set(ByVal value As DelegateCommand)

                If Not (Me._removeFileCommand Is value) Then
                    Me._removeFileCommand = value
                    Me.OnPropertyChanged("RemoveFileCommand")
                End If
            End Set
        End Property

        Public Property IsBusy As Boolean
            Get
                Return Me._isBusy
            End Get
            Set(ByVal value As Boolean)

                If Me._isBusy <> value Then
                    Me._isBusy = value
                    Me.OnPropertyChanged("IsBusy")
                End If
            End Set
        End Property

        Public Property ProgressValue As Integer
            Get
                Return Me._progressValue
            End Get
            Set(ByVal value As Integer)

                If Me._progressValue <> value Then
                    Me._progressValue = value
                    Me.OnPropertyChanged("ProgressValue")
                End If
            End Set
        End Property

        Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Private Sub Files_CollectionChanged(ByVal sender As Object, ByVal e As System.Collections.Specialized.NotifyCollectionChangedEventArgs)
            Me.InvalidateCommands()
        End Sub

        Private Sub OnAddNewFile(ByVal obj As Object)
            Dim fileData As FileData = TryCast(obj, FileData)

            If fileData Is Nothing Then
                fileData = New FileData()
            End If

            Me.files.Add(fileData)
        End Sub

        Private Function OnCanAddNewFile(ByVal obj As Object) As Boolean
            Return Me.files.Count < 5
        End Function

        Private Sub OnUploadFiles(ByVal obj As Object)
            Me._progressTimer.Interval = TimeSpan.FromMilliseconds(10)
            Me._progressValue = 0
            Me._progressTimer.Start()
            Me.isBusy = True
        End Sub

        Private Function OnCanUploadFiles(ByVal obj As Object) As Boolean
            Dim canUploadFile As Boolean = False

            For Each fileData As FileData In Me.files

                If Not String.IsNullOrEmpty(fileData.FilePath) Then
                    canUploadFile = True
                    Exit For
                End If
            Next

            Return canUploadFile
        End Function

        Public Sub OnFilePathChanged(ByVal obj As Object)
            Me.uploadFilesCommand.InvalidateCanExecute()
        End Sub

        Private Sub OnRemoveFile(ByVal obj As Object)
            Dim fileData As FileData = TryCast(obj, FileData)

            If fileData IsNot Nothing Then
                Me.files.Remove(fileData)
            End If
        End Sub

        Private Function OnCanRemoveFile(ByVal obj As Object) As Boolean
            Return Me.files.Count > 1
        End Function

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            Me.progressValue += 1

            If Me.progressValue = 100 Then
                Me._progressTimer.[Stop]()
                Me.isBusy = False
                Me.files.Clear()
                Me.InvalidateCommands()
            End If
        End Sub

        Private Function CreateEmptyFiles() As ObservableCollection(Of FileData)
            Dim files As ObservableCollection(Of FileData) = New ObservableCollection(Of FileData)()
            Dim fileData As FileData = New FileData()
            files.Add(fileData)
            fileData = New FileData()
            files.Add(fileData)
            fileData = New FileData()
            files.Add(fileData)
            Return files
        End Function

        Private Sub InvalidateCommands()
            Me.addNewFileCommand.InvalidateCanExecute()
            Me.removeFileCommand.InvalidateCanExecute()
            Me.uploadFilesCommand.InvalidateCanExecute()
        End Sub
    End Class
End Namespace
