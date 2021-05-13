namespace Telerik.Examples.WinControls.GridView.Customize.StyleCells
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radButtonRandom = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorRow = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorColumn = new Telerik.WinControls.UI.RadSpinEditor();
            this.radButtonBackColor = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.radButtonRandom);
            this.settingsPanel.Location = new System.Drawing.Point(1052, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 830);
            this.settingsPanel.Controls.SetChildIndex(this.radButtonRandom, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.AllowRowResize = false;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.radGridView1.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(502, 494);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            // 
            // radButtonRandom
            // 
            this.radButtonRandom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonRandom.Location = new System.Drawing.Point(10, 247);
            this.radButtonRandom.Name = "radButtonRandom";
            this.radButtonRandom.Size = new System.Drawing.Size(180, 24);
            this.radButtonRandom.TabIndex = 2;
            this.radButtonRandom.Text = "Apply Random Colors";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(29, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Row:";
            // 
            // radSpinEditorRow
            // 
            this.radSpinEditorRow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorRow.Location = new System.Drawing.Point(5, 43);
            this.radSpinEditorRow.Name = "radSpinEditorRow";
            // 
            // 
            // 
            this.radSpinEditorRow.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorRow.Size = new System.Drawing.Size(170, 20);
            this.radSpinEditorRow.TabIndex = 4;
            this.radSpinEditorRow.TabStop = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(5, 70);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(47, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Column:";
            // 
            // radSpinEditorColumn
            // 
            this.radSpinEditorColumn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorColumn.Location = new System.Drawing.Point(5, 91);
            this.radSpinEditorColumn.Name = "radSpinEditorColumn";
            // 
            // 
            // 
            this.radSpinEditorColumn.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorColumn.Size = new System.Drawing.Size(170, 20);
            this.radSpinEditorColumn.TabIndex = 6;
            this.radSpinEditorColumn.TabStop = false;
            // 
            // radButtonBackColor
            // 
            this.radButtonBackColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonBackColor.Location = new System.Drawing.Point(5, 146);
            this.radButtonBackColor.Name = "radButtonBackColor";
            this.radButtonBackColor.Size = new System.Drawing.Size(170, 24);
            this.radButtonBackColor.TabIndex = 7;
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel3.Location = new System.Drawing.Point(5, 117);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(79, 18);
            this.radLabel3.TabIndex = 8;
            this.radLabel3.Text = "Cell BackColor:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radSpinEditorRow);
            this.radGroupBox1.Controls.Add(this.radButtonBackColor);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radSpinEditorColumn);
            this.radGroupBox1.HeaderText = "Customize cell background:";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 53);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 188);
            this.radGroupBox1.TabIndex = 9;
            this.radGroupBox1.Text = "Customize cell background:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1282, 1000);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radButtonRandom;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorColumn;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorRow;
        private Telerik.WinControls.UI.RadButton radButtonBackColor;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
