
namespace Telerik.Examples.WinControls.GridView.SplitView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridView = new Telerik.WinControls.UI.RadGridView();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.order_DetailsTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.radRadioButtonNone = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonVertical = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonHorizontal = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBox1);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(703, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 745);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBox1, 0);
            // 
            // gridView
            // 
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = "gridView";
            this.gridView.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.gridView.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridView.Size = new System.Drawing.Size(904, 747);
            this.gridView.TabIndex = 0;
            this.gridView.Text = "gridView";
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "Order Details";
            this.orderDetailsBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // radRadioButtonNone
            // 
            this.radRadioButtonNone.Location = new System.Drawing.Point(14, 34);
            this.radRadioButtonNone.Name = "radRadioButtonNone";
            this.radRadioButtonNone.Size = new System.Drawing.Size(110, 18);
            this.radRadioButtonNone.TabIndex = 1;
            this.radRadioButtonNone.Text = "None";
           
            // 
            // radRadioButtonVertical
            // 
            this.radRadioButtonVertical.Location = new System.Drawing.Point(14, 58);
            this.radRadioButtonVertical.Name = "radRadioButtonVertical";
            this.radRadioButtonVertical.Size = new System.Drawing.Size(110, 18);
            this.radRadioButtonVertical.TabIndex = 2;
            this.radRadioButtonVertical.Text = "Vertical";
         
            // 
            // radRadioButtonHorizontal
            // 
            this.radRadioButtonHorizontal.Location = new System.Drawing.Point(14, 82);
            this.radRadioButtonHorizontal.Name = "radRadioButtonHorizontal";
            this.radRadioButtonHorizontal.Size = new System.Drawing.Size(110, 18);
            this.radRadioButtonHorizontal.TabIndex = 3;
            this.radRadioButtonHorizontal.Text = "Horizontal";
         
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radRadioButtonHorizontal);
            this.radGroupBox1.Controls.Add(this.radRadioButtonVertical);
            this.radGroupBox1.Controls.Add(this.radRadioButtonNone);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Split Mode";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 37);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 112);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Split Mode";
            this.radGroupBox1.ThemeName = "ControlDefault";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBox1.Location = new System.Drawing.Point(10, 176);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(146, 18);
            this.radCheckBox1.TabIndex = 2;
            this.radCheckBox1.Text = "Synchronize Current Row";
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridView);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(904, 747);
           
            this.Controls.SetChildIndex(this.gridView, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridView;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet northwindDataSet;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonHorizontal;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonVertical;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonNone;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
    }
}
