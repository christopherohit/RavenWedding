namespace Telerik.Examples.WinControls.Editors.ButtonTextBox
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
            this.radButtonTextBox1 = new Telerik.WinControls.UI.RadButtonTextBox();
            this.doubleBufferedTableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.doubleBufferedFlowLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTextBox1)).BeginInit();
            this.doubleBufferedTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(985, 98);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(230, 190);
            this.settingsPanel.Size = new System.Drawing.Size(230, 190);
            // 
            // radButtonTextBox1
            // 
            this.radButtonTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonTextBox1.Location = new System.Drawing.Point(81, 1);
            this.radButtonTextBox1.Margin = new System.Windows.Forms.Padding(1);
            this.radButtonTextBox1.Name = "radButtonTextBox1";
            this.radButtonTextBox1.Size = new System.Drawing.Size(298, 38);
            this.radButtonTextBox1.TabIndex = 1;
            this.radButtonTextBox1.Text = "radButtonTextBox1";
            // 
            // doubleBufferedTableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel1.ColumnCount = 5;
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695955F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695955F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.21967F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695955F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.692477F));
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radButtonTextBox1, 2, 0);
            this.doubleBufferedTableLayoutPanel1.Location = new System.Drawing.Point(183, 98);
            this.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1";
            this.doubleBufferedTableLayoutPanel1.RowCount = 1;
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.doubleBufferedTableLayoutPanel1.Size = new System.Drawing.Size(460, 40);
            this.doubleBufferedTableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.doubleBufferedFlowLayoutPanel1.Location = new System.Drawing.Point(252, 165);
            this.doubleBufferedFlowLayoutPanel1.Name = "doubleBufferedFlowLayoutPanel1";
            this.doubleBufferedFlowLayoutPanel1.Size = new System.Drawing.Size(485, 306);
            this.doubleBufferedFlowLayoutPanel1.TabIndex = 3;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.radRadioButton2);
            this.radGroupBox1.Controls.Add(this.radRadioButton1);
            this.radGroupBox1.HeaderText = "Add buttons to:";
            this.radGroupBox1.Location = new System.Drawing.Point(15, 33);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(200, 154);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Add buttons to:";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(15, 110);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "Clear buttons";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Location = new System.Drawing.Point(15, 72);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(130, 18);
            this.radRadioButton2.TabIndex = 1;
            this.radRadioButton2.TabStop = false;
            this.radRadioButton2.Text = "Add button to the left";
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radRadioButton1.Location = new System.Drawing.Point(15, 34);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(137, 18);
            this.radRadioButton1.TabIndex = 0;
            this.radRadioButton1.Text = "Add button to the right";
            this.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.doubleBufferedFlowLayoutPanel1);
            this.Controls.Add(this.doubleBufferedTableLayoutPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1036, 411);
            this.Controls.SetChildIndex(this.doubleBufferedTableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.doubleBufferedFlowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTextBox1)).EndInit();
            this.doubleBufferedTableLayoutPanel1.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButtonTextBox radButtonTextBox1; 
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel1;
        private Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel doubleBufferedFlowLayoutPanel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}