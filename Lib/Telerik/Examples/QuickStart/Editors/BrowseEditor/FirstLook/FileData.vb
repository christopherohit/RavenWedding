Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Linq
Imports System.Text

Namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
    Public Enum FileDataState
        Added
        Deleted
    End Enum

    Public Class FileData
        Implements INotifyPropertyChanged

        Private _filePath As String
        Private _fileName As String
        Private _fileSize As Long
        Private _state As FileDataState
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Property FilePath As String
            Get
                Return Me._filePath
            End Get
            Set(ByVal value As String)

                If Me._filePath <> value Then
                    Me._filePath = value

                    If Not String.IsNullOrEmpty(Me.FilePath) Then
                        Dim fileInfo As FileInfo = New FileInfo(Me.FilePath)

                        If fileInfo IsNot Nothing Then
                            Me._fileName = fileInfo.Name
                            Me._fileSize = fileInfo.Length
                        End If
                    End If

                    Me.OnPropertyChanged("FilePath")
                End If
            End Set
        End Property

        Public Property State As FileDataState
            Get
                Return Me._state
            End Get
            Set(ByVal value As FileDataState)

                If Me._state <> value Then
                    Me._state = value
                    Me.OnPropertyChanged("State")
                End If
            End Set
        End Property

        Public Property FileName As String
            Get
                Return Me._fileName
            End Get
            Set(ByVal value As String)

                If Me._fileName <> value Then
                    Me._fileName = value
                    Me.OnPropertyChanged("FileName")
                End If
            End Set
        End Property

        Public Property FileSize As Long
            Get
                Return Me._fileSize
            End Get
            Set(ByVal value As Long)

                If Me._fileSize <> value Then
                    Me._fileSize = value
                    Me.OnPropertyChanged("FileSize")
                End If
            End Set
        End Property

        Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace
