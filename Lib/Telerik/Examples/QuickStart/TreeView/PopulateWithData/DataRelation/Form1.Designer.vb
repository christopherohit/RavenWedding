Namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.DataRelation
	Partial Public Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.artistsBindingSource = New BindingSource(Me.components)
			Me.musicCollectionDataSet = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet()
			Me.albumsBindingSource = New BindingSource(Me.components)
			Me.songsBindingSource = New BindingSource(Me.components)
			Me.artistsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter()
			Me.albumsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter()
			Me.songsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter()
			Me.radListLevelOne = New Telerik.WinControls.UI.RadListControl()
			Me.radListLevelTwo = New Telerik.WinControls.UI.RadListControl()
			Me.radListLevelThree = New Telerik.WinControls.UI.RadListControl()
			Me.radGroupLevelThree = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupLevelTwo = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupLevelOne = New Telerik.WinControls.UI.RadGroupBox()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.imageList1 = New ImageList(Me.components)
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.songsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListLevelOne, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListLevelTwo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListLevelThree, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupLevelThree, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupLevelThree.SuspendLayout()
			CType(Me.radGroupLevelTwo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupLevelTwo.SuspendLayout()
			CType(Me.radGroupLevelOne, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupLevelOne.SuspendLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupLevelOne)
			Me.settingsPanel.Controls.Add(Me.radGroupLevelTwo)
			Me.settingsPanel.Controls.Add(Me.radGroupLevelThree)
			Me.settingsPanel.Location = New Point(1111, 1)
			Me.settingsPanel.Size = New Size(200, 747)

			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupLevelThree, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupLevelTwo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupLevelOne, 0)
			' 
			' artistsBindingSource
			' 
			Me.artistsBindingSource.DataMember = "Artists"
			Me.artistsBindingSource.DataSource = Me.musicCollectionDataSet
			' 
			' musicCollectionDataSet
			' 
			Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
			Me.musicCollectionDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
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
			' radListLevelOne
			' 
			Me.radListLevelOne.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radListLevelOne.DataSource = Me.artistsBindingSource
			Me.radListLevelOne.DisplayMember = "ArtistName"
			Me.radListLevelOne.Location = New Point(6, 20)
			Me.radListLevelOne.Name = "radListLevelOne"
			Me.radListLevelOne.Size = New Size(168, 85)
			Me.radListLevelOne.TabIndex = 7
			' 
			' radListLevelTwo
			' 
			Me.radListLevelTwo.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radListLevelTwo.Location = New Point(6, 20)
			Me.radListLevelTwo.Name = "radListLevelTwo"
			Me.radListLevelTwo.Size = New Size(168, 85)
			Me.radListLevelTwo.TabIndex = 7
			' 
			' radListLevelThree
			' 
			Me.radListLevelThree.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radListLevelThree.Location = New Point(6, 22)
			Me.radListLevelThree.Name = "radListLevelThree"
			Me.radListLevelThree.Size = New Size(168, 187)
			Me.radListLevelThree.TabIndex = 7
			' 
			' radGroupLevelThree
			' 
			Me.radGroupLevelThree.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupLevelThree.Anchor = AnchorStyles.Top
			Me.radGroupLevelThree.Controls.Add(Me.radListLevelThree)
			Me.radGroupLevelThree.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupLevelThree.HeaderText = " Third Level Items "
			Me.radGroupLevelThree.Location = New Point(10, 265)
			Me.radGroupLevelThree.Name = "radGroupLevelThree"
			Me.radGroupLevelThree.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupLevelThree.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupLevelThree.Size = New Size(180, 218)
			Me.radGroupLevelThree.TabIndex = 8
			Me.radGroupLevelThree.Text = " Third Level Items "
			' 
			' radGroupLevelTwo
			' 
			Me.radGroupLevelTwo.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupLevelTwo.Anchor = AnchorStyles.Top
			Me.radGroupLevelTwo.Controls.Add(Me.radListLevelTwo)
			Me.radGroupLevelTwo.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupLevelTwo.HeaderText = " Second Level Items "
			Me.radGroupLevelTwo.Location = New Point(10, 138)
			Me.radGroupLevelTwo.Name = "radGroupLevelTwo"
			Me.radGroupLevelTwo.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupLevelTwo.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupLevelTwo.Size = New Size(180, 116)
			Me.radGroupLevelTwo.TabIndex = 8
			Me.radGroupLevelTwo.Text = " Second Level Items "
			' 
			' radGroupLevelOne
			' 
			Me.radGroupLevelOne.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupLevelOne.Anchor = AnchorStyles.Top
			Me.radGroupLevelOne.Controls.Add(Me.radListLevelOne)
			Me.radGroupLevelOne.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupLevelOne.HeaderText = " First Level Items "
			Me.radGroupLevelOne.Location = New Point(10, 6)
			Me.radGroupLevelOne.Name = "radGroupLevelOne"
			Me.radGroupLevelOne.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupLevelOne.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupLevelOne.Size = New Size(180, 116)
			Me.radGroupLevelOne.TabIndex = 8
			Me.radGroupLevelOne.Text = " First Level Items "
			' 
			' radTreeView1
			' 
			Me.radTreeView1.ImageIndex = 0
			Me.radTreeView1.ImageList = Me.imageList1
			Me.radTreeView1.Location = New Point(0, 0)
			Me.radTreeView1.Name = "radTreeView1"
			Me.radTreeView1.Size = New Size(314, 475)
			Me.radTreeView1.SpacingBetweenNodes = -1
			Me.radTreeView1.TabIndex = 1
			Me.radTreeView1.Text = "radTreeView1"

			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "user_orange.png")
			Me.imageList1.Images.SetKeyName(1, "cd_16.png")
			Me.imageList1.Images.SetKeyName(2, "music_16.png")
			' 
			' radPanel1
			' 
			Me.radPanel1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radPanel1.BackColor = Color.Transparent
			Me.radPanel1.Controls.Add(Me.radLabel3)
			Me.radPanel1.Location = New Point(6, 8)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(368, 30)
			Me.radPanel1.TabIndex = 1
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(195))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 2
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.FromArgb((CInt(Fix((CByte(200))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(176))))), (CInt(Fix((CByte(233))))))
			' 
			' radLabel3
			' 
			Me.radLabel3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.radLabel3.Location = New Point(8, 2)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(120, 24)
			Me.radLabel3.TabIndex = 0
			Me.radLabel3.Text = "Music Collection"
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.radTreeView1)
			Me.Name = "Form1"
			Me.Size = New Size(1334, 671)

			Me.Controls.SetChildIndex(Me.radTreeView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()			
			CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.songsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListLevelOne, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListLevelTwo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListLevelThree, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupLevelThree, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupLevelThree.ResumeLayout(False)
			CType(Me.radGroupLevelTwo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupLevelTwo.ResumeLayout(False)
			CType(Me.radGroupLevelOne, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupLevelOne.ResumeLayout(False)
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private artistsBindingSource As BindingSource
		Private musicCollectionDataSet As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet
		Private artistsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter
		Private albumsBindingSource As BindingSource
		Private songsBindingSource As BindingSource
		Private albumsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
		Private songsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter
		Private radListLevelOne As Telerik.WinControls.UI.RadListControl
		Private radListLevelTwo As Telerik.WinControls.UI.RadListControl
		Private radListLevelThree As Telerik.WinControls.UI.RadListControl
		Private radGroupLevelThree As Telerik.WinControls.UI.RadGroupBox
		Private radGroupLevelTwo As Telerik.WinControls.UI.RadGroupBox
		Private radGroupLevelOne As Telerik.WinControls.UI.RadGroupBox
		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private imageList1 As ImageList
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
