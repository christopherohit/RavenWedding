namespace Telerik.Examples.WinControls.ListView.CustomItems
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.albumsDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSet = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet();
            this.albumsDataTableTableAdapter = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsDataTableTableAdapter();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableAlbumsDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableSongsDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBox1);
            this.settingsPanel.Location = new System.Drawing.Point(1065, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 747);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBox1, 0);
            // 
            // radListView1
            // 
            this.radListView1.AllowEdit = false;
            this.radListView1.AllowRemove = false;
            this.radListView1.DataSource = this.albumsDataTableBindingSource;
            this.radListView1.FullRowSelect = false;
            this.radListView1.ItemSize = new System.Drawing.Size(64, 64);
            this.radListView1.Location = new System.Drawing.Point(0, 0);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(640, 329);
            this.radListView1.TabIndex = 0;
            this.radListView1.Text = "radListView1";
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            this.radListView1.VisualItemCreating += new Telerik.WinControls.UI.ListViewVisualItemCreatingEventHandler(this.radListView1_VisualItemCreating);
            // 
            // albumsDataTableBindingSource
            // 
            this.albumsDataTableBindingSource.DataMember = "AlbumsDataTable";
            this.albumsDataTableBindingSource.DataSource = this.musicCollectionDataSet;
            // 
            // musicCollectionDataSet
            // 
            this.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet";
            this.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 
            // 
            this.musicCollectionDataSet.TableAlbumsDataTable.TableName = "AlbumsDataTable";
            // 
            // 
            // 
            this.musicCollectionDataSet.TableSongsDataTable.TableName = "SongsDataTable";
            // 
            // albumsDataTableTableAdapter
            // 
            this.albumsDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox1.Location = new System.Drawing.Point(10, 37);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(136, 18);
            this.radCheckBox1.TabIndex = 1;
            this.radCheckBox1.Text = "Enable Kinetic Scrolling";
            this.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radListView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1432, 917);
            this.Controls.SetChildIndex(this.radListView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableAlbumsDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableSongsDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private DataSources.MusicCollectionDataSet musicCollectionDataSet;
        private System.Windows.Forms.BindingSource albumsDataTableBindingSource;
        private DataSources.MusicCollectionDataSetTableAdapters.AlbumsDataTableTableAdapter albumsDataTableTableAdapter;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
    }
}