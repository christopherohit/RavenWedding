namespace Telerik.Examples.WinControls.Map.OpenStreetMaps
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
            this.radMap1 = new Telerik.WinControls.UI.RadMap();
            this.radGroupBoxClusterStrategy = new Telerik.WinControls.UI.RadGroupBox();
            this.radDropDownListClusterStrategy = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabelClusterStrategy = new Telerik.WinControls.UI.RadLabel();
            this.radLabelDistance = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorDistance = new Telerik.WinControls.UI.RadSpinEditor();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxClusterStrategy)).BeginInit();
            this.radGroupBoxClusterStrategy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListClusterStrategy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelClusterStrategy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBoxClusterStrategy);
            this.settingsPanel.Size = new System.Drawing.Size(230, 348);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxClusterStrategy, 0);
            // 
            // radMap1
            // 
            this.radMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radMap1.Location = new System.Drawing.Point(0, 0);
            this.radMap1.Name = "radMap1";
            this.radMap1.ShowLegend = false;
            this.radMap1.ShowMiniMap = false;
            this.radMap1.ShowSearchBar = false;
            this.radMap1.Size = new System.Drawing.Size(1624, 1028);
            this.radMap1.TabIndex = 0;
            this.radMap1.Text = "radMap1";
            // 
            // radGroupBoxClusterStrategy
            // 
            this.radGroupBoxClusterStrategy.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxClusterStrategy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxClusterStrategy.Controls.Add(this.radSpinEditorDistance);
            this.radGroupBoxClusterStrategy.Controls.Add(this.radLabelDistance);
            this.radGroupBoxClusterStrategy.Controls.Add(this.radLabelClusterStrategy);
            this.radGroupBoxClusterStrategy.Controls.Add(this.radDropDownListClusterStrategy);
            this.radGroupBoxClusterStrategy.HeaderText = "Cluster Settings";
            this.radGroupBoxClusterStrategy.Location = new System.Drawing.Point(10, 32);
            this.radGroupBoxClusterStrategy.Name = "radGroupBoxClusterStrategy";
            this.radGroupBoxClusterStrategy.Size = new System.Drawing.Size(210, 129);
            this.radGroupBoxClusterStrategy.TabIndex = 1;
            this.radGroupBoxClusterStrategy.Text = "Cluster Settings";
            // 
            // radDropDownListClusterStrategy
            // 
            this.radDropDownListClusterStrategy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownListClusterStrategy.Location = new System.Drawing.Point(5, 50);
            this.radDropDownListClusterStrategy.Name = "radDropDownListClusterStrategy";
            this.radDropDownListClusterStrategy.Size = new System.Drawing.Size(200, 20);
            this.radDropDownListClusterStrategy.TabIndex = 0;
            this.radDropDownListClusterStrategy.Text = "Cluster Strategy";
            this.radDropDownListClusterStrategy.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownListClusterStrategy_SelectedIndexChanged);
            this.radDropDownListClusterStrategy.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radLabelClusterStrategy
            // 
            this.radLabelClusterStrategy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelClusterStrategy.Location = new System.Drawing.Point(5, 29);
            this.radLabelClusterStrategy.Name = "radLabelClusterStrategy";
            this.radLabelClusterStrategy.Size = new System.Drawing.Size(84, 18);
            this.radLabelClusterStrategy.TabIndex = 1;
            this.radLabelClusterStrategy.Text = "Cluster Strategy";
            // 
            // radLabelDistance
            // 
            this.radLabelDistance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelDistance.Location = new System.Drawing.Point(5, 79);
            this.radLabelDistance.Name = "radLabelDistance";
            this.radLabelDistance.Size = new System.Drawing.Size(48, 18);
            this.radLabelDistance.TabIndex = 2;
            this.radLabelDistance.Text = "Distance (px)";
            // 
            // radSpinEditorDistance
            // 
            this.radSpinEditorDistance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorDistance.Location = new System.Drawing.Point(5, 100);
            this.radSpinEditorDistance.Name = "radSpinEditorDistance";
            this.radSpinEditorDistance.Size = new System.Drawing.Size(200, 20);
            this.radSpinEditorDistance.TabIndex = 3;
            this.radSpinEditorDistance.TabStop = false;
            this.radSpinEditorDistance.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.radSpinEditorDistance.ValueChanged += new System.EventHandler(this.radSpinEditorDistance_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radMap1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1634, 1038);
            this.Controls.SetChildIndex(this.radMap1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxClusterStrategy)).EndInit();
            this.radGroupBoxClusterStrategy.ResumeLayout(false);
            this.radGroupBoxClusterStrategy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListClusterStrategy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelClusterStrategy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorDistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMap radMap1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxClusterStrategy;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorDistance;
        private Telerik.WinControls.UI.RadLabel radLabelDistance;
        private Telerik.WinControls.UI.RadLabel radLabelClusterStrategy;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListClusterStrategy;
    }
}