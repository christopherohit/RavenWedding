namespace Telerik.Examples.WinControls.Map.Settings
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
            this.radGroupBoxElementSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBoxShowMiniMap = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxShowScaleIndicator = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxShowNavigationBar = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxShowLegend = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxShowSearchBar = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBoxLegendSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButtonHorizontal = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonVertical = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBoxNavigationBarSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radDropDownListNavBarLocation = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabelNavBarLocation = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBoxMinimapSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radSpinEditorZoomOffset = new Telerik.WinControls.UI.RadSpinEditor();
            this.radDropDownListMinimapMode = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabelMode = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxElementSettings)).BeginInit();
            this.radGroupBoxElementSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowMiniMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowScaleIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowNavigationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowLegend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowSearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxLegendSettings)).BeginInit();
            this.radGroupBoxLegendSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxNavigationBarSettings)).BeginInit();
            this.radGroupBoxNavigationBarSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListNavBarLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNavBarLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxMinimapSettings)).BeginInit();
            this.radGroupBoxMinimapSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorZoomOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListMinimapMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMode)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBoxMinimapSettings);
            this.settingsPanel.Controls.Add(this.radGroupBoxNavigationBarSettings);
            this.settingsPanel.Controls.Add(this.radGroupBoxLegendSettings);
            this.settingsPanel.Controls.Add(this.radGroupBoxElementSettings);
            this.settingsPanel.Size = new System.Drawing.Size(230, 786);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxElementSettings, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxLegendSettings, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxNavigationBarSettings, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxMinimapSettings, 0);
            // 
            // radMap1
            // 
            this.radMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radMap1.Location = new System.Drawing.Point(0, 0);
            this.radMap1.Name = "radMap1";
            this.radMap1.Size = new System.Drawing.Size(1282, 626);
            this.radMap1.TabIndex = 0;
            this.radMap1.Text = "radMap1";
            // 
            // radGroupBoxElementSettings
            // 
            this.radGroupBoxElementSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxElementSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxElementSettings.Controls.Add(this.radCheckBoxShowMiniMap);
            this.radGroupBoxElementSettings.Controls.Add(this.radCheckBoxShowScaleIndicator);
            this.radGroupBoxElementSettings.Controls.Add(this.radCheckBoxShowNavigationBar);
            this.radGroupBoxElementSettings.Controls.Add(this.radCheckBoxShowLegend);
            this.radGroupBoxElementSettings.Controls.Add(this.radCheckBoxShowSearchBar);
            this.radGroupBoxElementSettings.HeaderText = "Element settings";
            this.radGroupBoxElementSettings.Location = new System.Drawing.Point(10, 32);
            this.radGroupBoxElementSettings.Name = "radGroupBoxElementSettings";
            this.radGroupBoxElementSettings.Size = new System.Drawing.Size(210, 148);
            this.radGroupBoxElementSettings.TabIndex = 1;
            this.radGroupBoxElementSettings.Text = "Element settings";
            // 
            // radCheckBoxShowMiniMap
            // 
            this.radCheckBoxShowMiniMap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxShowMiniMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxShowMiniMap.Location = new System.Drawing.Point(5, 126);
            this.radCheckBoxShowMiniMap.Name = "radCheckBoxShowMiniMap";
            this.radCheckBoxShowMiniMap.Size = new System.Drawing.Size(97, 18);
            this.radCheckBoxShowMiniMap.TabIndex = 0;
            this.radCheckBoxShowMiniMap.Text = "Show mini map";
            this.radCheckBoxShowMiniMap.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxShowMiniMap.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowMiniMap_ToggleStateChanged);
            // 
            // radCheckBoxShowScaleIndicator
            // 
            this.radCheckBoxShowScaleIndicator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxShowScaleIndicator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxShowScaleIndicator.Location = new System.Drawing.Point(5, 102);
            this.radCheckBoxShowScaleIndicator.Name = "radCheckBoxShowScaleIndicator";
            this.radCheckBoxShowScaleIndicator.Size = new System.Drawing.Size(122, 18);
            this.radCheckBoxShowScaleIndicator.TabIndex = 0;
            this.radCheckBoxShowScaleIndicator.Text = "Show scale indicator";
            this.radCheckBoxShowScaleIndicator.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxShowScaleIndicator.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowScaleIndicator_ToggleStateChanged);
            // 
            // radCheckBoxShowNavigationBar
            // 
            this.radCheckBoxShowNavigationBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxShowNavigationBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxShowNavigationBar.Location = new System.Drawing.Point(5, 78);
            this.radCheckBoxShowNavigationBar.Name = "radCheckBoxShowNavigationBar";
            this.radCheckBoxShowNavigationBar.Size = new System.Drawing.Size(122, 18);
            this.radCheckBoxShowNavigationBar.TabIndex = 0;
            this.radCheckBoxShowNavigationBar.Text = "Show navigation bar";
            this.radCheckBoxShowNavigationBar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxShowNavigationBar.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowNavigationBar_ToggleStateChanged);
            // 
            // radCheckBoxShowLegend
            // 
            this.radCheckBoxShowLegend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxShowLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxShowLegend.Location = new System.Drawing.Point(5, 54);
            this.radCheckBoxShowLegend.Name = "radCheckBoxShowLegend";
            this.radCheckBoxShowLegend.Size = new System.Drawing.Size(85, 18);
            this.radCheckBoxShowLegend.TabIndex = 0;
            this.radCheckBoxShowLegend.Text = "Show legend";
            this.radCheckBoxShowLegend.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxShowLegend.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowLegend_ToggleStateChanged);
            // 
            // radCheckBoxShowSearchBar
            // 
            this.radCheckBoxShowSearchBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxShowSearchBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxShowSearchBar.Location = new System.Drawing.Point(5, 30);
            this.radCheckBoxShowSearchBar.Name = "radCheckBoxShowSearchBar";
            this.radCheckBoxShowSearchBar.Size = new System.Drawing.Size(102, 18);
            this.radCheckBoxShowSearchBar.TabIndex = 0;
            this.radCheckBoxShowSearchBar.Text = "Show search bar";
            this.radCheckBoxShowSearchBar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxShowSearchBar.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowSearchBar_ToggleStateChanged);
            // 
            // radGroupBoxLegendSettings
            // 
            this.radGroupBoxLegendSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxLegendSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxLegendSettings.Controls.Add(this.radRadioButtonHorizontal);
            this.radGroupBoxLegendSettings.Controls.Add(this.radRadioButtonVertical);
            this.radGroupBoxLegendSettings.HeaderText = "Legend settings";
            this.radGroupBoxLegendSettings.Location = new System.Drawing.Point(10, 184);
            this.radGroupBoxLegendSettings.Name = "radGroupBoxLegendSettings";
            this.radGroupBoxLegendSettings.Size = new System.Drawing.Size(210, 75);
            this.radGroupBoxLegendSettings.TabIndex = 2;
            this.radGroupBoxLegendSettings.Text = "Legend settings";
            // 
            // radRadioButtonHorizontal
            // 
            this.radRadioButtonHorizontal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButtonHorizontal.Location = new System.Drawing.Point(5, 53);
            this.radRadioButtonHorizontal.Name = "radRadioButtonHorizontal";
            this.radRadioButtonHorizontal.Size = new System.Drawing.Size(72, 18);
            this.radRadioButtonHorizontal.TabIndex = 0;
            this.radRadioButtonHorizontal.TabStop = false;
            this.radRadioButtonHorizontal.Text = "Horizontal";
            // 
            // radRadioButtonVertical
            // 
            this.radRadioButtonVertical.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButtonVertical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radRadioButtonVertical.Location = new System.Drawing.Point(5, 30);
            this.radRadioButtonVertical.Name = "radRadioButtonVertical";
            this.radRadioButtonVertical.Size = new System.Drawing.Size(57, 18);
            this.radRadioButtonVertical.TabIndex = 0;
            this.radRadioButtonVertical.Text = "Vertical";
            this.radRadioButtonVertical.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButtonVertical.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonVertical_ToggleStateChanged);
            // 
            // radGroupBoxNavigationBarSettings
            // 
            this.radGroupBoxNavigationBarSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxNavigationBarSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxNavigationBarSettings.Controls.Add(this.radDropDownListNavBarLocation);
            this.radGroupBoxNavigationBarSettings.Controls.Add(this.radLabelNavBarLocation);
            this.radGroupBoxNavigationBarSettings.HeaderText = "Navigation bar settings";
            this.radGroupBoxNavigationBarSettings.Location = new System.Drawing.Point(10, 263);
            this.radGroupBoxNavigationBarSettings.Name = "radGroupBoxNavigationBarSettings";
            this.radGroupBoxNavigationBarSettings.Size = new System.Drawing.Size(210, 80);
            this.radGroupBoxNavigationBarSettings.TabIndex = 2;
            this.radGroupBoxNavigationBarSettings.Text = "Navigation bar settings";
            // 
            // radDropDownListNavBarLocation
            // 
            this.radDropDownListNavBarLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownListNavBarLocation.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListNavBarLocation.Location = new System.Drawing.Point(5, 51);
            this.radDropDownListNavBarLocation.Name = "radDropDownListNavBarLocation";
            this.radDropDownListNavBarLocation.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownListNavBarLocation_SelectedIndexChanged);
            this.radDropDownListNavBarLocation.Size = new System.Drawing.Size(200, 20);
            this.radDropDownListNavBarLocation.TabIndex = 1;
            this.radDropDownListNavBarLocation.Text = "Location";
            // 
            // radLabelNavBarLocation
            // 
            this.radLabelNavBarLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelNavBarLocation.Location = new System.Drawing.Point(5, 30);
            this.radLabelNavBarLocation.Name = "radLabelNavBarLocation";
            this.radLabelNavBarLocation.Size = new System.Drawing.Size(48, 18);
            this.radLabelNavBarLocation.TabIndex = 0;
            this.radLabelNavBarLocation.Text = "Location";
            // 
            // radGroupBoxMinimapSettings
            // 
            this.radGroupBoxMinimapSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxMinimapSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxMinimapSettings.Controls.Add(this.radSpinEditorZoomOffset);
            this.radGroupBoxMinimapSettings.Controls.Add(this.radDropDownListMinimapMode);
            this.radGroupBoxMinimapSettings.Controls.Add(this.radLabel1);
            this.radGroupBoxMinimapSettings.Controls.Add(this.radLabelMode);
            this.radGroupBoxMinimapSettings.HeaderText = "Mini map settings";
            this.radGroupBoxMinimapSettings.Location = new System.Drawing.Point(10, 347);
            this.radGroupBoxMinimapSettings.Name = "radGroupBoxMinimapSettings";
            this.radGroupBoxMinimapSettings.Size = new System.Drawing.Size(210, 130);
            this.radGroupBoxMinimapSettings.TabIndex = 2;
            this.radGroupBoxMinimapSettings.Text = "Mini map settings";
            // 
            // radSpinEditorZoomOffset
            // 
            this.radSpinEditorZoomOffset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorZoomOffset.Enabled = false;
            this.radSpinEditorZoomOffset.Location = new System.Drawing.Point(5, 101);
            this.radSpinEditorZoomOffset.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.radSpinEditorZoomOffset.Name = "radSpinEditorZoomOffset";
            this.radSpinEditorZoomOffset.Size = new System.Drawing.Size(200, 20);
            this.radSpinEditorZoomOffset.TabIndex = 2;
            this.radSpinEditorZoomOffset.TabStop = false;
            this.radSpinEditorZoomOffset.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.radSpinEditorZoomOffset.ValueChanged += new System.EventHandler(this.radSpinEditorZoomOffset_ValueChanged);
            // 
            // radDropDownListMinimapMode
            // 
            this.radDropDownListMinimapMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownListMinimapMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListMinimapMode.Location = new System.Drawing.Point(5, 51);
            this.radDropDownListMinimapMode.Name = "radDropDownListMinimapMode";
            this.radDropDownListMinimapMode.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownListMinimapMode_SelectedIndexChanged);
            this.radDropDownListMinimapMode.Size = new System.Drawing.Size(200, 20);
            this.radDropDownListMinimapMode.TabIndex = 1;
            this.radDropDownListMinimapMode.Text = "Mode";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 80);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(66, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Zoom offset";
            // 
            // radLabelMode
            // 
            this.radLabelMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelMode.Location = new System.Drawing.Point(5, 30);
            this.radLabelMode.Name = "radLabelMode";
            this.radLabelMode.Size = new System.Drawing.Size(35, 18);
            this.radLabelMode.TabIndex = 0;
            this.radLabelMode.Text = "Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radMap1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1292, 636);
            this.Controls.SetChildIndex(this.radMap1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxElementSettings)).EndInit();
            this.radGroupBoxElementSettings.ResumeLayout(false);
            this.radGroupBoxElementSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowMiniMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowScaleIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowNavigationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowLegend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowSearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxLegendSettings)).EndInit();
            this.radGroupBoxLegendSettings.ResumeLayout(false);
            this.radGroupBoxLegendSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxNavigationBarSettings)).EndInit();
            this.radGroupBoxNavigationBarSettings.ResumeLayout(false);
            this.radGroupBoxNavigationBarSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListNavBarLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNavBarLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxMinimapSettings)).EndInit();
            this.radGroupBoxMinimapSettings.ResumeLayout(false);
            this.radGroupBoxMinimapSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorZoomOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListMinimapMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMap radMap1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxMinimapSettings;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxNavigationBarSettings;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListNavBarLocation;
        private Telerik.WinControls.UI.RadLabel radLabelNavBarLocation;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxLegendSettings;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonHorizontal;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonVertical;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxElementSettings;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowMiniMap;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowScaleIndicator;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowNavigationBar;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowLegend;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowSearchBar;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorZoomOffset;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListMinimapMode;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabelMode;
    }
}