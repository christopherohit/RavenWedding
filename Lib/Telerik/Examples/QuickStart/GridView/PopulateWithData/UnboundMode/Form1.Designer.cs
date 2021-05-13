namespace Telerik.Examples.WinControls.GridView.PopulateWithData.UnboundMode
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radBtnRmRows = new Telerik.WinControls.UI.RadButton();
            this.radBtnAddRow = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radBtnRmCol = new Telerik.WinControls.UI.RadButton();
            this.radComboBox1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radBtnAddCol = new Telerik.WinControls.UI.RadButton();
            this.radCheckShowNewRow = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupCols = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupAddCol = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupRmCol = new Telerik.WinControls.UI.RadGroupBox();
            this.radComboColumnsRemove = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupRows = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnRmRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnAddRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnRmCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnAddCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckShowNewRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupCols)).BeginInit();
            this.radGroupCols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupAddCol)).BeginInit();
            this.radGroupAddCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRmCol)).BeginInit();
            this.radGroupRmCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboColumnsRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRows)).BeginInit();
            this.radGroupRows.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupCols);
            this.settingsPanel.Controls.Add(this.radGroupRows);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 818);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupRows, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupCols, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowColumnChooser = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.Caption = null;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
            this.radGridView1.MultiSelect = true;
            this.radGridView1.Name = "radGridView1";
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Size = new System.Drawing.Size(1224, 820);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.Text = "radGridView1";         
            // 
            // radBtnRmRows
            // 
            this.radBtnRmRows.Location = new System.Drawing.Point(12, 58);
            this.radBtnRmRows.Name = "radBtnRmRows";
            this.radBtnRmRows.Size = new System.Drawing.Size(156, 23);
            this.radBtnRmRows.TabIndex = 6;
            this.radBtnRmRows.Text = "Remove Selected Rows";

            // 
            // radBtnAddRow
            // 
            this.radBtnAddRow.Location = new System.Drawing.Point(12, 29);
            this.radBtnAddRow.Name = "radBtnAddRow";
            this.radBtnAddRow.Size = new System.Drawing.Size(156, 23);
            this.radBtnAddRow.TabIndex = 5;
            this.radBtnAddRow.Text = "Add Row";
          
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(15, 22);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(37, 16);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "Index:";
            // 
            // radBtnRmCol
            // 
            this.radBtnRmCol.Location = new System.Drawing.Point(15, 48);
            this.radBtnRmCol.Name = "radBtnRmCol";
            this.radBtnRmCol.Size = new System.Drawing.Size(130, 23);
            this.radBtnRmCol.TabIndex = 3;
            this.radBtnRmCol.Text = "Remove Column";
  
            // 
            // radComboBox1
            // 
            this.radComboBox1.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboBox1.Location = new System.Drawing.Point(54, 19);
            this.radComboBox1.Name = "radComboBox1";
            // 
            // 
            // 
            this.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBox1.Size = new System.Drawing.Size(91, 20);
            this.radComboBox1.TabIndex = 0;
            this.radComboBox1.TabStop = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(15, 22);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(35, 16);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Type:";
            // 
            // radBtnAddCol
            // 
            this.radBtnAddCol.Location = new System.Drawing.Point(15, 56);
            this.radBtnAddCol.Name = "radBtnAddCol";
            this.radBtnAddCol.Size = new System.Drawing.Size(130, 23);
            this.radBtnAddCol.TabIndex = 1;
            this.radBtnAddCol.Text = "Add Column";
            // 
            // radCheckShowNewRow
            // 
            this.radCheckShowNewRow.AutoSize = true;
            this.radCheckShowNewRow.Location = new System.Drawing.Point(12, 93);
            this.radCheckShowNewRow.Name = "radCheckShowNewRow";
            this.radCheckShowNewRow.Size = new System.Drawing.Size(129, 14);
            this.radCheckShowNewRow.TabIndex = 7;
            this.radCheckShowNewRow.Text = "Show \"Add New Row\"";
            this.radCheckShowNewRow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radGroupCols
            // 
            this.radGroupCols.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupCols.Controls.Add(this.radGroupAddCol);
            this.radGroupCols.Controls.Add(this.radGroupRmCol);
            this.radGroupCols.FooterImageIndex = -1;
            this.radGroupCols.FooterImageKey = "";
            this.radGroupCols.HeaderImageIndex = -1;
            this.radGroupCols.HeaderImageKey = "";
            this.radGroupCols.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupCols.HeaderText = "Columns";
            this.radGroupCols.Location = new System.Drawing.Point(10, 6);
            this.radGroupCols.Name = "radGroupCols";
            this.radGroupCols.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupCols.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupCols.Size = new System.Drawing.Size(180, 222);
            this.radGroupCols.TabIndex = 8;
            this.radGroupCols.Text = "Columns";
            // 
            // radGroupAddCol
            // 
            this.radGroupAddCol.Controls.Add(this.radLabel2);
            this.radGroupAddCol.Controls.Add(this.radComboBox1);
            this.radGroupAddCol.Controls.Add(this.radBtnAddCol);
            this.radGroupAddCol.FooterImageIndex = -1;
            this.radGroupAddCol.FooterImageKey = "";
            this.radGroupAddCol.HeaderImageIndex = -1;
            this.radGroupAddCol.HeaderImageKey = "";
            this.radGroupAddCol.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupAddCol.HeaderText = "Add";
            this.radGroupAddCol.Location = new System.Drawing.Point(10, 119);
            this.radGroupAddCol.Name = "radGroupAddCol";
            this.radGroupAddCol.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupAddCol.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupAddCol.Size = new System.Drawing.Size(161, 91);
            this.radGroupAddCol.TabIndex = 8;
            this.radGroupAddCol.Text = "Add";
            // 
            // radGroupRmCol
            // 
            this.radGroupRmCol.Controls.Add(this.radLabel4);
            this.radGroupRmCol.Controls.Add(this.radComboColumnsRemove);
            this.radGroupRmCol.Controls.Add(this.radBtnRmCol);
            this.radGroupRmCol.FooterImageIndex = -1;
            this.radGroupRmCol.FooterImageKey = "";
            this.radGroupRmCol.HeaderImageIndex = -1;
            this.radGroupRmCol.HeaderImageKey = "";
            this.radGroupRmCol.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupRmCol.HeaderText = "Remove";
            this.radGroupRmCol.Location = new System.Drawing.Point(10, 22);
            this.radGroupRmCol.Name = "radGroupRmCol";
            this.radGroupRmCol.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupRmCol.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupRmCol.Size = new System.Drawing.Size(161, 91);
            this.radGroupRmCol.TabIndex = 8;
            this.radGroupRmCol.Text = "Remove";
            // 
            // radComboColumnsRemove
            // 
            this.radComboColumnsRemove.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboColumnsRemove.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboColumnsRemove.Location = new System.Drawing.Point(56, 22);
            this.radComboColumnsRemove.Name = "radComboColumnsRemove";
            // 
            // 
            // 
            this.radComboColumnsRemove.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboColumnsRemove.Size = new System.Drawing.Size(91, 20);
            this.radComboColumnsRemove.TabIndex = 0;
            this.radComboColumnsRemove.TabStop = false;
            // 
            // radGroupRows
            // 
            this.radGroupRows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupRows.Controls.Add(this.radBtnAddRow);
            this.radGroupRows.Controls.Add(this.radBtnRmRows);
            this.radGroupRows.Controls.Add(this.radCheckShowNewRow);
            this.radGroupRows.FooterImageIndex = -1;
            this.radGroupRows.FooterImageKey = "";
            this.radGroupRows.HeaderImageIndex = -1;
            this.radGroupRows.HeaderImageKey = "";
            this.radGroupRows.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupRows.HeaderText = "Rows";
            this.radGroupRows.Location = new System.Drawing.Point(10, 234);
            this.radGroupRows.Name = "radGroupRows";
            this.radGroupRows.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupRows.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupRows.Size = new System.Drawing.Size(180, 128);
            this.radGroupRows.TabIndex = 9;
            this.radGroupRows.Text = "Rows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 820);

            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnRmRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnAddRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnRmCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnAddCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckShowNewRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupCols)).EndInit();
            this.radGroupCols.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupAddCol)).EndInit();
            this.radGroupAddCol.ResumeLayout(false);
            this.radGroupAddCol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRmCol)).EndInit();
            this.radGroupRmCol.ResumeLayout(false);
            this.radGroupRmCol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboColumnsRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRows)).EndInit();
            this.radGroupRows.ResumeLayout(false);
            this.radGroupRows.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radBtnRmCol;
        private Telerik.WinControls.UI.RadButton radBtnAddCol;
        private Telerik.WinControls.UI.RadDropDownList radComboBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckShowNewRow;
        private Telerik.WinControls.UI.RadButton radBtnRmRows;
        private Telerik.WinControls.UI.RadButton radBtnAddRow;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadGroupBox radGroupRows;
        private Telerik.WinControls.UI.RadGroupBox radGroupCols;
        private Telerik.WinControls.UI.RadGroupBox radGroupAddCol;
        private Telerik.WinControls.UI.RadGroupBox radGroupRmCol;
        private Telerik.WinControls.UI.RadDropDownList radComboColumnsRemove;
    }
}