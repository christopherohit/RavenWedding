namespace Telerik.Examples.WinControls.VirtualGrid.WebService
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
            this.radVirtualGrid1 = new Telerik.WinControls.UI.RadVirtualGrid();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).BeginInit();
            this.radVirtualGrid1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // radVirtualGrid1
            // 
            this.radVirtualGrid1.AllowAddNewRow = false;
            this.radVirtualGrid1.AllowFiltering = false;
            this.radVirtualGrid1.ColumnCount = 100;
            this.radVirtualGrid1.Controls.Add(this.radButton1);
            this.radVirtualGrid1.Location = new System.Drawing.Point(0, 0);
            this.radVirtualGrid1.Name = "radVirtualGrid1";
            this.radVirtualGrid1.RowCount = 1000;
            this.radVirtualGrid1.Size = new System.Drawing.Size(685, 544);
            this.radVirtualGrid1.StandardTab = false;
            this.radVirtualGrid1.TabIndex = 0;
            this.radVirtualGrid1.Text = "radVirtualGrid1";
            this.radVirtualGrid1.CellValueNeeded += new Telerik.WinControls.UI.VirtualGridCellValueNeededEventHandler(this.radVirtualGrid1_CellValueNeeded);
            this.radVirtualGrid1.CellFormatting += new Telerik.WinControls.UI.VirtualGridCellElementEventHandler(this.radVirtualGrid1_CellFormatting);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(254, 260);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(176, 35);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Load Data from JSON service";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radVirtualGrid1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1533, 1000);
            this.Controls.SetChildIndex(this.radVirtualGrid1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).EndInit();
            this.radVirtualGrid1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadVirtualGrid radVirtualGrid1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}