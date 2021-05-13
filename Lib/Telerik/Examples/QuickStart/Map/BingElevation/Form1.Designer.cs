namespace Telerik.Examples.WinControls.Map.BingElevation
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
            this.radGroupBoxSetup = new Telerik.WinControls.UI.RadGroupBox();
            this.radButtonCalculateElevations = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radSpinEditorColumns = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorRows = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabelColumns = new Telerik.WinControls.UI.RadLabel();
            this.radLabelRows = new Telerik.WinControls.UI.RadLabel();
            this.radMap1 = new Telerik.WinControls.UI.RadMap();
            this.radGroupBoxBoundsSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBoxPolylineSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabelNumberOfSamples = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorSamples = new Telerik.WinControls.UI.RadSpinEditor();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxSetup)).BeginInit();
            this.radGroupBoxSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCalculateElevations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxBoundsSettings)).BeginInit();
            this.radGroupBoxBoundsSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxPolylineSettings)).BeginInit();
            this.radGroupBoxPolylineSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNumberOfSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorSamples)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBoxPolylineSettings);
            this.settingsPanel.Controls.Add(this.radGroupBoxBoundsSettings);
            this.settingsPanel.Controls.Add(this.radGroupBoxSetup);
            this.settingsPanel.Size = new System.Drawing.Size(230, 710);
            this.settingsPanel.TabStop = false;
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxSetup, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxBoundsSettings, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxPolylineSettings, 0);
            // 
            // radGroupBoxSetup
            // 
            this.radGroupBoxSetup.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxSetup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxSetup.Controls.Add(this.radButtonCalculateElevations);
            this.radGroupBoxSetup.Controls.Add(this.radLabel1);
            this.radGroupBoxSetup.Controls.Add(this.radDropDownList1);
            this.radGroupBoxSetup.HeaderText = "Elevation options";
            this.radGroupBoxSetup.Location = new System.Drawing.Point(10, 33);
            this.radGroupBoxSetup.Name = "radGroupBoxSetup";
            this.radGroupBoxSetup.Size = new System.Drawing.Size(210, 131);
            this.radGroupBoxSetup.TabIndex = 1;
            this.radGroupBoxSetup.TabStop = false;
            this.radGroupBoxSetup.Text = "Elevation options";
            // 
            // radButtonCalculateElevations
            // 
            this.radButtonCalculateElevations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonCalculateElevations.Location = new System.Drawing.Point(5, 86);
            this.radButtonCalculateElevations.Name = "radButtonCalculateElevations";
            this.radButtonCalculateElevations.Size = new System.Drawing.Size(200, 40);
            this.radButtonCalculateElevations.TabIndex = 2;
            this.radButtonCalculateElevations.Text = "Calculate elevation(s)";
            this.radButtonCalculateElevations.Click += new System.EventHandler(this.radButtonCalculateElevations_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 30);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(35, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Mode";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList1.Location = new System.Drawing.Point(5, 51);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(200, 20);
            this.radDropDownList1.TabIndex = 0;
            this.radDropDownList1.Text = "radDropDownList1";
            // 
            // radSpinEditorColumns
            // 
            this.radSpinEditorColumns.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorColumns.Location = new System.Drawing.Point(5, 101);
            this.radSpinEditorColumns.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.radSpinEditorColumns.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.radSpinEditorColumns.Name = "radSpinEditorColumns";
            this.radSpinEditorColumns.Size = new System.Drawing.Size(200, 20);
            this.radSpinEditorColumns.TabIndex = 3;
            this.radSpinEditorColumns.TabStop = false;
            this.radSpinEditorColumns.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // radSpinEditorRows
            // 
            this.radSpinEditorRows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorRows.Location = new System.Drawing.Point(5, 51);
            this.radSpinEditorRows.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.radSpinEditorRows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.radSpinEditorRows.Name = "radSpinEditorRows";
            this.radSpinEditorRows.Size = new System.Drawing.Size(200, 20);
            this.radSpinEditorRows.TabIndex = 3;
            this.radSpinEditorRows.TabStop = false;
            this.radSpinEditorRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // radLabelColumns
            // 
            this.radLabelColumns.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelColumns.Location = new System.Drawing.Point(5, 80);
            this.radLabelColumns.Name = "radLabelColumns";
            this.radLabelColumns.Size = new System.Drawing.Size(49, 18);
            this.radLabelColumns.TabIndex = 2;
            this.radLabelColumns.Text = "Columns";
            // 
            // radLabelRows
            // 
            this.radLabelRows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelRows.Location = new System.Drawing.Point(5, 30);
            this.radLabelRows.Name = "radLabelRows";
            this.radLabelRows.Size = new System.Drawing.Size(32, 18);
            this.radLabelRows.TabIndex = 2;
            this.radLabelRows.Text = "Rows";
            // 
            // radMap1
            // 
            this.radMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radMap1.Location = new System.Drawing.Point(0, 0);
            this.radMap1.Name = "radMap1";
            this.radMap1.ShowLegend = false;
            this.radMap1.ShowSearchBar = false;
            this.radMap1.Size = new System.Drawing.Size(1495, 1028);
            this.radMap1.TabIndex = 2;
            this.radMap1.Text = "radMap1";
            // 
            // radGroupBoxBoundsSettings
            // 
            this.radGroupBoxBoundsSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxBoundsSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxBoundsSettings.Controls.Add(this.radSpinEditorColumns);
            this.radGroupBoxBoundsSettings.Controls.Add(this.radLabelRows);
            this.radGroupBoxBoundsSettings.Controls.Add(this.radSpinEditorRows);
            this.radGroupBoxBoundsSettings.Controls.Add(this.radLabelColumns);
            this.radGroupBoxBoundsSettings.HeaderText = "Bounds settings";
            this.radGroupBoxBoundsSettings.Location = new System.Drawing.Point(10, 168);
            this.radGroupBoxBoundsSettings.Name = "radGroupBoxBoundsSettings";
            this.radGroupBoxBoundsSettings.Size = new System.Drawing.Size(210, 131);
            this.radGroupBoxBoundsSettings.TabIndex = 1;
            this.radGroupBoxBoundsSettings.Text = "Bounds settings";
            this.radGroupBoxBoundsSettings.Visible = false;
            // 
            // radGroupBoxPolylineSettings
            // 
            this.radGroupBoxPolylineSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxPolylineSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxPolylineSettings.Controls.Add(this.radLabelNumberOfSamples);
            this.radGroupBoxPolylineSettings.Controls.Add(this.radSpinEditorSamples);
            this.radGroupBoxPolylineSettings.HeaderText = "Polyline settings";
            this.radGroupBoxPolylineSettings.Location = new System.Drawing.Point(10, 168);
            this.radGroupBoxPolylineSettings.Name = "radGroupBoxPolylineSettings";
            this.radGroupBoxPolylineSettings.Size = new System.Drawing.Size(210, 80);
            this.radGroupBoxPolylineSettings.TabIndex = 1;
            this.radGroupBoxPolylineSettings.Text = "Polyline settings";
            this.radGroupBoxPolylineSettings.Visible = false;
            // 
            // radLabelNumberOfSamples
            // 
            this.radLabelNumberOfSamples.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelNumberOfSamples.Location = new System.Drawing.Point(5, 30);
            this.radLabelNumberOfSamples.Name = "radLabelNumberOfSamples";
            this.radLabelNumberOfSamples.Size = new System.Drawing.Size(103, 18);
            this.radLabelNumberOfSamples.TabIndex = 2;
            this.radLabelNumberOfSamples.Text = "Number of samples";
            // 
            // radSpinEditorSamples
            // 
            this.radSpinEditorSamples.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorSamples.Location = new System.Drawing.Point(5, 51);
            this.radSpinEditorSamples.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.radSpinEditorSamples.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.radSpinEditorSamples.Name = "radSpinEditorSamples";
            this.radSpinEditorSamples.Size = new System.Drawing.Size(200, 20);
            this.radSpinEditorSamples.TabIndex = 3;
            this.radSpinEditorSamples.TabStop = false;
            this.radSpinEditorSamples.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radMap1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1505, 1038);
            this.Controls.SetChildIndex(this.radMap1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxSetup)).EndInit();
            this.radGroupBoxSetup.ResumeLayout(false);
            this.radGroupBoxSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCalculateElevations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxBoundsSettings)).EndInit();
            this.radGroupBoxBoundsSettings.ResumeLayout(false);
            this.radGroupBoxBoundsSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxPolylineSettings)).EndInit();
            this.radGroupBoxPolylineSettings.ResumeLayout(false);
            this.radGroupBoxPolylineSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNumberOfSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorSamples)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBoxSetup;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorColumns;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorRows;
        private Telerik.WinControls.UI.RadLabel radLabelColumns;
        private Telerik.WinControls.UI.RadLabel radLabelRows;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadMap radMap1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxBoundsSettings;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxPolylineSettings;
        private Telerik.WinControls.UI.RadLabel radLabelNumberOfSamples;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorSamples;
        private Telerik.WinControls.UI.RadButton radButtonCalculateElevations;
    }
}