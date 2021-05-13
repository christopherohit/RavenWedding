Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.FileDialogs.FirstLook
    Partial Public Class UploadedFileUserControl
        Inherits UserControl

        Public Event RemoveRequested As EventHandler(Of EventArgs)
        Public Event DownloadRequested As EventHandler(Of EventArgs)
        Private _storageModel As StorageFile
        Private _themeName As String

        Public Sub New(ByVal storageModel As StorageFile)
            InitializeComponent()
            Me.SetCustomFonts("TelerikWebUI", 9)
            Me._storageModel = storageModel
            Me.labelFileName.Text = ChrW(&HE906).ToString() & " " & Me._storageModel.Name
        End Sub

        Public Property StorageModel As StorageFile
            Get
                Return Me._storageModel
            End Get
            Set(ByVal value As StorageFile)

                If Me._storageModel Is value Then
                    Return
                End If

                Me._storageModel = value
                Me.BindControls()
            End Set
        End Property

        Public Property ThemeName As String
            Get
                Return Me._themeName
            End Get
            Set(ByVal value As String)

                If Me.ThemeName = value Then
                    Return
                End If

                Me._themeName = value
                Me.UpdateControlsTheme(Me)
            End Set
        End Property

        Private Sub SetCustomFonts(ByVal fontName As String, ByVal fontSize As Integer)
            Me.labelFileName.LabelElement.CustomFont = fontName
            Me.labelFileName.LabelElement.CustomFontSize = fontSize
            Me.btnRemove.ButtonElement.TextElement.CustomFont = fontName
            Me.btnRemove.ButtonElement.TextElement.CustomFontSize = fontSize
            Me.btnRemove.Text = ChrW(&HE11B).ToString()
        End Sub

        Private Sub UpdateControlsTheme(ByVal control As Control)
            Dim themableControl As IComponentTreeHandler = TryCast(control, IComponentTreeHandler)

            If themableControl IsNot Nothing Then
                themableControl.ThemeName = Me.ThemeName
            End If

            For Each c As Control In control.Controls
                Me.UpdateControlsTheme(c)
            Next
        End Sub

        Private Sub BindControls()
            Me.labelFileType.DataBindings.Clear()
            Me.labelFileType.DataBindings.Add("Text", Me.StorageModel, "FileSystemInfoType", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.labelUploadDate.DataBindings.Clear()
            Me.labelUploadDate.DataBindings.Add("Text", Me.StorageModel, "UploadedTime", False, DataSourceUpdateMode.OnPropertyChanged)
        End Sub

        Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent RemoveRequested(Me, e)
        End Sub

        Private Sub btnDownload_Click(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent DownloadRequested(Me, e)
        End Sub
    End Class
End Namespace
