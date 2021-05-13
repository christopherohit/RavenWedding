Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls.UI

Namespace DemoAppsHub.TreeExample
	Public Partial Class TreeExampleUserControl
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.artistsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.musicCollectionDataSet = New Global.MusicCollectionDataSet()
			Me.albumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.songsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.artistsTableAdapter = New MusicCollectionDataSetTableAdapters.ArtistsTableAdapter()
            Me.albumsTableAdapter = New MusicCollectionDataSetTableAdapters.AlbumsTableAdapter()
            Me.songsTableAdapter = New MusicCollectionDataSetTableAdapters.SongsTableAdapter()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TreeExampleUserControl))
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
			Me.radDropDownButton1 = New Telerik.WinControls.UI.RadDropDownButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.songsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel3.SuspendLayout()
			CType(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' artistsBindingSource
			' 
			Me.artistsBindingSource.DataMember = "Artists"
			Me.artistsBindingSource.DataSource = Me.musicCollectionDataSet
			' 
			' musicCollectionDataSet
			' 
			Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
			Me.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' albumsBindingSource
			' 
			Me.albumsBindingSource.DataMember = "Albums"
			Me.albumsBindingSource.DataSource = Me.musicCollectionDataSet
			' 
			' songsBindingSource
			' 
			Me.songsBindingSource.DataMember = "Songs"
			Me.songsBindingSource.DataSource = Me.musicCollectionDataSet
			' 
			' artistsTableAdapter
			' 
			Me.artistsTableAdapter.ClearBeforeFill = True
			' 
			' albumsTableAdapter
			' 
			Me.albumsTableAdapter.ClearBeforeFill = True
			' 
			' songsTableAdapter
			' 
			Me.songsTableAdapter.ClearBeforeFill = True
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "folder_feed.png")
			Me.imageList1.Images.SetKeyName(1, "feed.png")
			' 
			' radTreeView1
			' 
			Me.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radTreeView1.ImageIndex = 0
			Me.radTreeView1.ImageList = Me.imageList1
			Me.radTreeView1.Location = New System.Drawing.Point(0, 82)
			Me.radTreeView1.Name = "radTreeView1"
			Me.radTreeView1.Size = New System.Drawing.Size(457, 343)
			Me.radTreeView1.SpacingBetweenNodes = -1
			Me.radTreeView1.TabIndex = 3
			Me.radTreeView1.Text = "radTreeView1"
'			Me.radTreeView1.NodeExpandedChanging += New RadTreeView.RadTreeViewCancelEventHandler(radTreeView1_NodeExpandedChanging);
			Me.radTreeView1.AllowEdit = False
			Me.radTreeView1.AllowAdd = False
			Me.radTreeView1.AllowRemove = False
			' 
			' radPanel1
			' 
			Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radPanel1.Location = New System.Drawing.Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New System.Drawing.Size(457, 44)
			Me.radPanel1.TabIndex = 1
			' 
			' radPanel3
			' 
			Me.radPanel3.Controls.Add(Me.radDropDownButton1)
			Me.radPanel3.Controls.Add(Me.radLabel1)
			Me.radPanel3.Controls.Add(Me.radTextBox1)
			Me.radPanel3.Dock = System.Windows.Forms.DockStyle.Top
			Me.radPanel3.Location = New System.Drawing.Point(0, 44)
			Me.radPanel3.Name = "radPanel3"
			Me.radPanel3.Size = New System.Drawing.Size(457, 38)
			Me.radPanel3.TabIndex = 2
			' 
			' radDropDownButton1
			' 
			Me.radDropDownButton1.Location = New System.Drawing.Point(38, 7)
			Me.radDropDownButton1.Name = "radDropDownButton1"
			Me.radDropDownButton1.Size = New System.Drawing.Size(140, 24)
			Me.radDropDownButton1.TabIndex = 4
			Me.radDropDownButton1.Text = "None"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(3, 10)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(29, 18)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "Sort:"
			' 
			' radTextBox1
			' 
			Me.radTextBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radTextBox1.Location = New System.Drawing.Point(184, 7)
			Me.radTextBox1.Name = "radTextBox1"
			Me.radTextBox1.NullText = "Type here to filter"
			Me.radTextBox1.Size = New System.Drawing.Size(270, 20)
			Me.radTextBox1.TabIndex = 0
			Me.radTextBox1.TabStop = False
'			Me.radTextBox1.TextChanged += New System.EventHandler(Me.radTextBox1_TextChanged);
			' 
			' TreeExampleUserControl
			' 
			Me.Controls.Add(Me.radTreeView1)
			Me.Controls.Add(Me.radPanel3)
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "TreeExampleUserControl"
			Me.Size = New System.Drawing.Size(457, 425)
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.songsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel3.ResumeLayout(False)
			Me.radPanel3.PerformLayout()
			CType(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As System.Windows.Forms.ImageList
		Private radPanel1 As RadPanel
		Private WithEvents radTreeView1 As RadTreeView
		Private radPanel3 As RadPanel
		Private radLabel1 As RadLabel
		Private WithEvents radTextBox1 As RadTextBox
		Private radDropDownButton1 As RadDropDownButton
		Private artistsBindingSource As System.Windows.Forms.BindingSource
		Private albumsBindingSource As System.Windows.Forms.BindingSource
		Private songsBindingSource As System.Windows.Forms.BindingSource
        Private musicCollectionDataSet As Global.MusicCollectionDataSet
        Private artistsTableAdapter As MusicCollectionDataSetTableAdapters.ArtistsTableAdapter
        Private albumsTableAdapter As MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
        Private songsTableAdapter As MusicCollectionDataSetTableAdapters.SongsTableAdapter
	End Class
End Namespace
