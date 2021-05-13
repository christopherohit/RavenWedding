namespace Telerik.Examples.WinControls.VirtualGrid.FirstLook
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
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // radVirtualGrid1
            // 

            this.radVirtualGrid1.Location = new System.Drawing.Point(24, 22);
            this.radVirtualGrid1.Name = "radVirtualGrid1";
            this.radVirtualGrid1.RowCount = 1000;
            this.radVirtualGrid1.Size = new System.Drawing.Size(870, 512);
            this.radVirtualGrid1.StandardTab = false;
            this.radVirtualGrid1.TabIndex = 0;
            this.radVirtualGrid1.Text = "radVirtualGrid1";
            this.radVirtualGrid1.CellValueNeeded += new Telerik.WinControls.UI.VirtualGridCellValueNeededEventHandler(this.radVirtualGrid1_CellValueNeeded);
            this.radVirtualGrid1.CellFormatting += new Telerik.WinControls.UI.VirtualGridCellElementEventHandler(this.radVirtualGrid1_CellFormatting);
            this.radVirtualGrid1.SortChanged += new Telerik.WinControls.UI.VirtualGridEventHandler(this.radVirtualGrid1_SortChanged);
            this.radVirtualGrid1.FilterChanged += new Telerik.WinControls.UI.VirtualGridEventHandler(this.radVirtualGrid1_FilterChanged);
            this.radVirtualGrid1.UserDeletedRow += new Telerik.WinControls.UI.VirtualGridRowsEventHandler(this.radVirtualGrid1_UserDeletingRow);
            this.radVirtualGrid1.UserAddedRow += new Telerik.WinControls.UI.VirtualGridNewRowEventHandler(this.radVirtualGrid1_UserAddedRow);
            this.radVirtualGrid1.CellValuePushed += new Telerik.WinControls.UI.VirtualGridCellValuePushedEventHandler(this.radVirtualGrid1_CellValuePushed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 626);
            this.Controls.Add(this.radVirtualGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadVirtualGrid radVirtualGrid1;
    }
}