namespace Telerik.Examples.WinControls.GridView.ManipulateData.Expressions
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupPreDef = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupNumericText = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioAverage = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radRadioNumExpr2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioNumExpr1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupCheckBox = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radRadioCheckExpr2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioCheckExpr1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radButtonExprEditor = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupPreDef)).BeginInit();
            this.radGroupPreDef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupNumericText)).BeginInit();
            this.radGroupNumericText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNumExpr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNumExpr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupCheckBox)).BeginInit();
            this.radGroupCheckBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCheckExpr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCheckExpr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExprEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1252, 20);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupPreDef);
            this.settingsPanel.PanelContainer.Controls.Add(this.radButtonExprEditor);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(230, 806);
            this.settingsPanel.Size = new System.Drawing.Size(230, 806);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(0, 5);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowColumnChooser = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.Caption = null;
            this.radGridView1.MasterTemplate.MultiSelect = true;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(942, 409);
            this.radGridView1.TabIndex = 2;
            // 
            // radGroupPreDef
            // 
            this.radGroupPreDef.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupPreDef.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupPreDef.Controls.Add(this.radGroupNumericText);
            this.radGroupPreDef.Controls.Add(this.radGroupCheckBox);
            this.radGroupPreDef.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupPreDef.HeaderText = "Predefined Expressions";
            this.radGroupPreDef.Location = new System.Drawing.Point(10, 6);
            this.radGroupPreDef.Name = "radGroupPreDef";
            this.radGroupPreDef.Size = new System.Drawing.Size(210, 264);
            this.radGroupPreDef.TabIndex = 0;
            this.radGroupPreDef.Text = "Predefined Expressions";
            // 
            // radGroupNumericText
            // 
            this.radGroupNumericText.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupNumericText.Controls.Add(this.radRadioAverage);
            this.radGroupNumericText.Controls.Add(this.radLabel3);
            this.radGroupNumericText.Controls.Add(this.radRadioNumExpr2);
            this.radGroupNumericText.Controls.Add(this.radRadioNumExpr1);
            this.radGroupNumericText.HeaderText = "NumericText Column";
            this.radGroupNumericText.Location = new System.Drawing.Point(10, 24);
            this.radGroupNumericText.Name = "radGroupNumericText";
            this.radGroupNumericText.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupNumericText.Size = new System.Drawing.Size(190, 116);
            this.radGroupNumericText.TabIndex = 1;
            this.radGroupNumericText.Text = "NumericText Column";
            // 
            // radRadioAverage
            // 
            this.radRadioAverage.Location = new System.Drawing.Point(6, 91);
            this.radRadioAverage.Name = "radRadioAverage";
            this.radRadioAverage.Size = new System.Drawing.Size(87, 18);
            this.radRadioAverage.TabIndex = 2;
            this.radRadioAverage.Text = "Avg(Decimal)";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(6, 27);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(102, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Choose expression:";
            // 
            // radRadioNumExpr2
            // 
            this.radRadioNumExpr2.Location = new System.Drawing.Point(6, 69);
            this.radRadioNumExpr2.Name = "radRadioNumExpr2";
            this.radRadioNumExpr2.Size = new System.Drawing.Size(86, 18);
            this.radRadioNumExpr2.TabIndex = 5;
            this.radRadioNumExpr2.Text = "Decimal + 15";
            // 
            // radRadioNumExpr1
            // 
            this.radRadioNumExpr1.Location = new System.Drawing.Point(6, 47);
            this.radRadioNumExpr1.Name = "radRadioNumExpr1";
            this.radRadioNumExpr1.Size = new System.Drawing.Size(101, 18);
            this.radRadioNumExpr1.TabIndex = 3;
            this.radRadioNumExpr1.Text = "(Decimal - 3) * 2";
            // 
            // radGroupCheckBox
            // 
            this.radGroupCheckBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupCheckBox.Controls.Add(this.radLabel5);
            this.radGroupCheckBox.Controls.Add(this.radRadioCheckExpr2);
            this.radGroupCheckBox.Controls.Add(this.radRadioCheckExpr1);
            this.radGroupCheckBox.HeaderText = "CheckBox Column";
            this.radGroupCheckBox.Location = new System.Drawing.Point(10, 145);
            this.radGroupCheckBox.Name = "radGroupCheckBox";
            this.radGroupCheckBox.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupCheckBox.Size = new System.Drawing.Size(190, 109);
            this.radGroupCheckBox.TabIndex = 1;
            this.radGroupCheckBox.Text = "CheckBox Column";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(6, 26);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(102, 18);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "Choose expression:";
            // 
            // radRadioCheckExpr2
            // 
            this.radRadioCheckExpr2.Location = new System.Drawing.Point(7, 68);
            this.radRadioCheckExpr2.Name = "radRadioCheckExpr2";
            this.radRadioCheckExpr2.Size = new System.Drawing.Size(15, 15);
            this.radRadioCheckExpr2.TabIndex = 5;
            // 
            // radRadioCheckExpr1
            // 
            this.radRadioCheckExpr1.Location = new System.Drawing.Point(7, 46);
            this.radRadioCheckExpr1.Name = "radRadioCheckExpr1";
            this.radRadioCheckExpr1.Size = new System.Drawing.Size(93, 18);
            this.radRadioCheckExpr1.TabIndex = 3;
            this.radRadioCheckExpr1.Text = "Decimal < 600";
            // 
            // radButtonExprEditor
            // 
            this.radButtonExprEditor.Location = new System.Drawing.Point(0, 300);
            this.radButtonExprEditor.Name = "radButtonExprEditor";
            this.radButtonExprEditor.Size = new System.Drawing.Size(120, 28);
            this.radButtonExprEditor.TabIndex = 1;
            this.radButtonExprEditor.Text = "Show Expression Editor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2103, 1156);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupPreDef)).EndInit();
            this.radGroupPreDef.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupNumericText)).EndInit();
            this.radGroupNumericText.ResumeLayout(false);
            this.radGroupNumericText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNumExpr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNumExpr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupCheckBox)).EndInit();
            this.radGroupCheckBox.ResumeLayout(false);
            this.radGroupCheckBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCheckExpr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCheckExpr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExprEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupPreDef;
        private Telerik.WinControls.UI.RadRadioButton radRadioNumExpr1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadRadioButton radRadioNumExpr2;
        private Telerik.WinControls.UI.RadGroupBox radGroupNumericText;
        private Telerik.WinControls.UI.RadGroupBox radGroupCheckBox;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadRadioButton radRadioCheckExpr2;
        private Telerik.WinControls.UI.RadRadioButton radRadioCheckExpr1;
        private Telerik.WinControls.UI.RadRadioButton radRadioAverage;
        private Telerik.WinControls.UI.RadButton radButtonExprEditor;
    }
}