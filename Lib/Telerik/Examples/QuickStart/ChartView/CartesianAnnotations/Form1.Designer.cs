using Telerik.WinControls.UI;
namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton4 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton3 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBoxAveragePrice = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxCompanyEvents = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBoxPriceRange = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAveragePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCompanyEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxPriceRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 3);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox3);
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox2);
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(230, 832);
            this.settingsPanel.Size = new System.Drawing.Size(230, 832);
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(1473, 786);
            this.radChartView1.TabIndex = 2;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radRadioButton2);
            this.radGroupBox1.Controls.Add(this.radRadioButton4);
            this.radGroupBox1.Controls.Add(this.radRadioButton3);
            this.radGroupBox1.Controls.Add(this.radRadioButton1);
            this.radGroupBox1.HeaderText = "Top companies in the market";
            this.radGroupBox1.Location = new System.Drawing.Point(5, 32);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(220, 130);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Top companies in the market";
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radRadioButton2.Location = new System.Drawing.Point(5, 21);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(77, 18);
            this.radRadioButton2.TabIndex = 1;
            this.radRadioButton2.Text = "Google Inc.";
            this.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radRadioButton4
            // 
            this.radRadioButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton4.Location = new System.Drawing.Point(5, 93);
            this.radRadioButton4.Name = "radRadioButton4";
            this.radRadioButton4.Size = new System.Drawing.Size(117, 18);
            this.radRadioButton4.TabIndex = 0;
            this.radRadioButton4.TabStop = false;
            this.radRadioButton4.Text = "Adobe Systems Inc.";
            // 
            // radRadioButton3
            // 
            this.radRadioButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton3.Location = new System.Drawing.Point(5, 69);
            this.radRadioButton3.Name = "radRadioButton3";
            this.radRadioButton3.Size = new System.Drawing.Size(70, 18);
            this.radRadioButton3.TabIndex = 0;
            this.radRadioButton3.TabStop = false;
            this.radRadioButton3.Text = "Apple Inc.";
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton1.Location = new System.Drawing.Point(5, 45);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(131, 18);
            this.radRadioButton1.TabIndex = 0;
            this.radRadioButton1.TabStop = false;
            this.radRadioButton1.Text = "Microsoft Corporation";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox2.Controls.Add(this.radCheckBoxAveragePrice);
            this.radGroupBox2.Controls.Add(this.radCheckBoxCompanyEvents);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.HeaderText = "Company events";
            this.radGroupBox2.Location = new System.Drawing.Point(5, 180);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(220, 100);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Company events";
            // 
            // radCheckBoxAveragePrice
            // 
            this.radCheckBoxAveragePrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxAveragePrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxAveragePrice.Location = new System.Drawing.Point(5, 72);
            this.radCheckBoxAveragePrice.Name = "radCheckBoxAveragePrice";
            this.radCheckBoxAveragePrice.Size = new System.Drawing.Size(118, 18);
            this.radCheckBoxAveragePrice.TabIndex = 2;
            this.radCheckBoxAveragePrice.Text = "Average stock price";
            this.radCheckBoxAveragePrice.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radCheckBoxCompanyEvents
            // 
            this.radCheckBoxCompanyEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxCompanyEvents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxCompanyEvents.Location = new System.Drawing.Point(5, 47);
            this.radCheckBoxCompanyEvents.Name = "radCheckBoxCompanyEvents";
            this.radCheckBoxCompanyEvents.Size = new System.Drawing.Size(103, 18);
            this.radCheckBoxCompanyEvents.TabIndex = 1;
            this.radCheckBoxCompanyEvents.Text = "Company events";
            this.radCheckBoxCompanyEvents.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(153, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Cartesian grid line annotation";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox3.Controls.Add(this.radCheckBoxPriceRange);
            this.radGroupBox3.Controls.Add(this.radLabel2);
            this.radGroupBox3.HeaderText = "Stock price range";
            this.radGroupBox3.Location = new System.Drawing.Point(5, 311);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(220, 76);
            this.radGroupBox3.TabIndex = 1;
            this.radGroupBox3.Text = "Stock price range";
            // 
            // radCheckBoxPriceRange
            // 
            this.radCheckBoxPriceRange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxPriceRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxPriceRange.Location = new System.Drawing.Point(5, 47);
            this.radCheckBoxPriceRange.Name = "radCheckBoxPriceRange";
            this.radCheckBoxPriceRange.Size = new System.Drawing.Size(124, 18);
            this.radCheckBoxPriceRange.TabIndex = 1;
            this.radCheckBoxPriceRange.Text = "Min-max price range";
            this.radCheckBoxPriceRange.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(5, 22);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(161, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Cartesian plot band annotation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1483, 796);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAveragePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCompanyEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxPriceRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadGroupBox radGroupBox1;
        private RadChartView radChartView1;
        private RadRadioButton radRadioButton2;
        private RadRadioButton radRadioButton4;
        private RadRadioButton radRadioButton3;
        private RadRadioButton radRadioButton1;
        private RadGroupBox radGroupBox3;
        private RadCheckBox radCheckBoxPriceRange;
        private RadLabel radLabel2;
        private RadGroupBox radGroupBox2;
        private RadCheckBox radCheckBoxAveragePrice;
        private RadCheckBox radCheckBoxCompanyEvents;
        private RadLabel radLabel1;

    }
}