Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
    Partial Public Class FilePathUserControl
        Inherits UserControl

        Private _fileViewModel As FileData

        Public Sub New()
            InitializeComponent()
            Me.deleteBtn.ButtonElement.Padding = New Padding(0, 2, 0, 0)
            Me.deleteBtn.ButtonElement.TextElement.CustomFont = "TelerikWebUI"
            Me.deleteBtn.Text = ""
            Me.radBrowseEditor1.DialogType = Telerik.WinControls.UI.BrowseEditorDialogType.OpenFileDialog
            AddHandler Me.radBrowseEditor1.ValueChanged, AddressOf Me.RadBrowseEditor1_ValueChanged
        End Sub

        Public Sub New(ByVal fileData As FileData)
            Me.New()
            Me._fileViewModel = fileData
        End Sub

        Public Property FileViewModel As FileData
            Get
                Return Me._fileViewModel
            End Get
            Friend Set(ByVal value As FileData)

                If Not (Me._fileViewModel Is value) Then
                    Me._fileViewModel = value
                    Me._fileViewModel.State = FileDataState.Added
                    AddHandler Me._fileViewModel.PropertyChanged, AddressOf Me.FileViewModel_PropertyChanged
                End If
            End Set
        End Property

        Public ReadOnly Property DeleteButton As RadButton
            Get
                Return Me.deleteBtn
            End Get
        End Property

        Private Sub RadBrowseEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.fileViewModel IsNot Nothing Then
                Me.fileViewModel.FilePath = Me.radBrowseEditor1.Value
            End If
        End Sub

        Private Sub FileViewModel_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
            If e.PropertyName = "FilePath" AndAlso Not String.IsNullOrEmpty(Me.fileViewModel.FileName) AndAlso Not String.IsNullOrEmpty(Me.fileViewModel.FilePath) Then
                Me.fileLabel.Text = String.Format("Name: {0}, {1} bytes", Me.fileViewModel.FileName, Me.fileViewModel.FileSize)

                If Not Me.fileLabel.Visible Then
                    Dim heightStep As Integer = TelerikDpiHelper.ScaleInt(20, Me.fileLabel.RootElement.DpiScaleFactor)
                    Me.labelHolderPanel.Height += heightStep
                    Me.Height += heightStep
                End If

                Me.fileLabel.Visible = True
            End If
        End Sub

        Private Sub deleteBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.fileViewModel.State = FileDataState.Deleted
        End Sub
    End Class
End Namespace
