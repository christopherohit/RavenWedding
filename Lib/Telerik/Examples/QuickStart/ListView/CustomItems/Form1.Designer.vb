Namespace Telerik.Examples.WinControls.ListView.CustomItems
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.radListView1 = New Telerik.WinControls.UI.RadListView()
            Me.albumsDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.musicCollectionDataSet = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet()
            Me.albumsDataTableTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsDataTableTableAdapter()
            Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType((Me.radListView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.albumsDataTableBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.musicCollectionDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Controls.Add(Me.radCheckBox1)
            Me.settingsPanel.Location = New System.Drawing.Point(1065, 1)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 747)
            Me.settingsPanel.ThemeName = "ControlDefault"
            Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox1, 0)
            Me.radListView1.AllowEdit = False
            Me.radListView1.AllowRemove = False
            Me.radListView1.DataSource = Me.albumsDataTableBindingSource
            Me.radListView1.FullRowSelect = False
            Me.radListView1.ItemSize = New System.Drawing.Size(64, 64)
            Me.radListView1.Location = New System.Drawing.Point(0, 0)
            Me.radListView1.Name = "radListView1"
            Me.radListView1.Size = New System.Drawing.Size(640, 329)
            Me.radListView1.TabIndex = 0
            Me.radListView1.Text = "radListView1"
            Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView
            AddHandler Me.radListView1.VisualItemCreating, AddressOf Me.radListView1_VisualItemCreating
            Me.albumsDataTableBindingSource.DataMember = "AlbumsDataTable"
            Me.albumsDataTableBindingSource.DataSource = Me.musicCollectionDataSet
            Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
            Me.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            Me.albumsDataTableTableAdapter.ClearBeforeFill = True
            Me.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBox1.Location = New System.Drawing.Point(10, 37)
            Me.radCheckBox1.Name = "radCheckBox1"
            Me.radCheckBox1.Size = New System.Drawing.Size(136, 18)
            Me.radCheckBox1.TabIndex = 1
            Me.radCheckBox1.Text = "Enable Kinetic Scrolling"
            Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBox1.ToggleStateChanged, AddressOf Me.radCheckBox1_ToggleStateChanged
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radListView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1432, 917)
            Me.Controls.SetChildIndex(Me.radListView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType((Me.radListView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.albumsDataTableBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.musicCollectionDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radListView1 As Telerik.WinControls.UI.RadListView
        Private musicCollectionDataSet As DataSources.MusicCollectionDataSet
        Private albumsDataTableBindingSource As System.Windows.Forms.BindingSource
        Private albumsDataTableTableAdapter As DataSources.MusicCollectionDataSetTableAdapters.AlbumsDataTableTableAdapter
        Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    End Class
End Namespace
