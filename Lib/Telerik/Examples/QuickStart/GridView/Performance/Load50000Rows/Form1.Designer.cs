namespace Telerik.Examples.WinControls.GridView.Performance.Load50000Rows
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
            this.dataTable = new System.Data.DataTable();
            this.dataSet1 = new System.Data.DataSet();
            this.radGridViewDemo = new Telerik.WinControls.UI.RadGridView();
            this.radBtnBind = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewDemo.MasterTemplate)).BeginInit();
            this.radGridViewDemo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnBind)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            this.settingsPanel.ThemeName = "ControlDefault";
            // 
            // dataTable
            // 
            this.dataTable.TableName = "Table1";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable});
            // 
            // radGridViewDemo
            // 
            this.radGridViewDemo.Controls.Add(this.radBtnBind);
            this.radGridViewDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridViewDemo.ForeColor = System.Drawing.Color.Black;
            this.radGridViewDemo.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridViewDemo.MasterTemplate.AllowAddNewRow = false;
            this.radGridViewDemo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridViewDemo.MasterTemplate.EnableFiltering = true;
            this.radGridViewDemo.Name = "radGridViewDemo";
            // 
            // 
            // 
            this.radGridViewDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridViewDemo.ShowNoDataText = false;
            this.radGridViewDemo.Size = new System.Drawing.Size(1224, 737);
            this.radGridViewDemo.TabIndex = 1;
            // 
            // radBtnBind
            // 
            this.radBtnBind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnBind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnBind.Location = new System.Drawing.Point(525, 342);
            this.radBtnBind.Name = "radBtnBind";
            this.radBtnBind.Size = new System.Drawing.Size(170, 52);
            this.radBtnBind.TabIndex = 0;
            this.radBtnBind.Text = "LOAD 50,000 ROWS";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridViewDemo);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 737);
            this.Controls.SetChildIndex(this.radGridViewDemo, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewDemo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewDemo)).EndInit();
            this.radGridViewDemo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radBtnBind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridViewDemo;
        private Telerik.WinControls.UI.RadButton radBtnBind;
        private System.Data.DataTable dataTable;
        private System.Data.DataSet dataSet1;
    }
}
