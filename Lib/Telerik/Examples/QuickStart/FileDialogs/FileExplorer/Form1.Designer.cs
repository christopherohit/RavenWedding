namespace Telerik.Examples.WinControls.FileDialogs.FileExplorer
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
            this.explorerControl1 = new Telerik.WinControls.UI.ExplorerControl();
            this.multiSelectCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.dragdropCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.expandToCurrDirCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.showHiddenFilesCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.filterDescriptorsDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.safeFileNamesListControl = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiSelectCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragdropCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expandToCurrDirCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHiddenFilesCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterDescriptorsDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeFileNamesListControl)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.explorerControl1);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(2142, 1156);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1250, 93);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.multiSelectCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.dragdropCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.expandToCurrDirCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.showHiddenFilesCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.radSeparator1);
            this.settingsPanel.PanelContainer.Controls.Add(this.radLabel1);
            this.settingsPanel.PanelContainer.Controls.Add(this.filterDescriptorsDropDownList);
            this.settingsPanel.PanelContainer.Controls.Add(this.radLabel2);
            this.settingsPanel.PanelContainer.Controls.Add(this.safeFileNamesListControl);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(253, 598);
            this.settingsPanel.Size = new System.Drawing.Size(253, 598);
            // 
            // optionsLabel
            // 
            this.optionsLabel.Location = new System.Drawing.Point(63, 573);
            // 
            // explorerControl1
            // 
            this.explorerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerControl1.Location = new System.Drawing.Point(0, 0);
            this.explorerControl1.Name = "explorerControl1";
            this.explorerControl1.Size = new System.Drawing.Size(2142, 1156);
            this.explorerControl1.TabIndex = 0;
            // 
            // multiselectCheckBox
            // 
            this.multiSelectCheckBox.Location = new System.Drawing.Point(3, 3);
            this.multiSelectCheckBox.Name = "multiSelectCheckBox";
            this.multiSelectCheckBox.Size = new System.Drawing.Size(75, 18);
            this.multiSelectCheckBox.TabIndex = 1;
            this.multiSelectCheckBox.Text = "MultiSelect";
            this.multiSelectCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.MultiSelectCheckBox_ToggleStateChanged);
            // 
            // dragdropCheckBox
            // 
            this.dragdropCheckBox.Location = new System.Drawing.Point(3, 32);
            this.dragdropCheckBox.Name = "dragdropCheckBox";
            this.dragdropCheckBox.Size = new System.Drawing.Size(117, 18);
            this.dragdropCheckBox.TabIndex = 2;
            this.dragdropCheckBox.Text = "IsDragDropEnabled";
            this.dragdropCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.DragdropCheckBox_ToggleStateChanged);
            // 
            // expandToCurrDirCheckBox
            // 
            this.expandToCurrDirCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.expandToCurrDirCheckBox.Location = new System.Drawing.Point(3, 61);
            this.expandToCurrDirCheckBox.Name = "expandToCurrDirCheckBox";
            this.expandToCurrDirCheckBox.Size = new System.Drawing.Size(152, 18);
            this.expandToCurrDirCheckBox.TabIndex = 3;
            this.expandToCurrDirCheckBox.Text = "ExpandToCurrentDirectory";
            this.expandToCurrDirCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.expandToCurrDirCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ExpandToCurrDirCheckBox_ToggleStateChanged);
            // 
            // showHiddenFilesCheckBox
            // 
            this.showHiddenFilesCheckBox.Location = new System.Drawing.Point(3, 90);
            this.showHiddenFilesCheckBox.Name = "showHiddenFilesCheckBox";
            this.showHiddenFilesCheckBox.Size = new System.Drawing.Size(106, 18);
            this.showHiddenFilesCheckBox.TabIndex = 4;
            this.showHiddenFilesCheckBox.Text = "ShowHiddenFiles";
            this.showHiddenFilesCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ShowHiddenFilesCheckBox_ToggleStateChanged);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(3, 114);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(194, 14);
            this.radSeparator1.TabIndex = 5;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 134);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(33, 18);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Filter:";
            // 
            // filterDescriptorsDropDownList
            // 
            this.filterDescriptorsDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.filterDescriptorsDropDownList.Location = new System.Drawing.Point(3, 158);
            this.filterDescriptorsDropDownList.Name = "filterDescriptorsDropDownList";
            this.filterDescriptorsDropDownList.Size = new System.Drawing.Size(194, 20);
            this.filterDescriptorsDropDownList.TabIndex = 7;
            this.filterDescriptorsDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.FilterDescriptorsDropDownList_SelectedIndexChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(3, 190);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(133, 18);
            this.radLabel2.TabIndex = 8;
            this.radLabel2.Text = "Selected Safe File Names:";
            // 
            // safeFileNamesListControl
            // 
            this.safeFileNamesListControl.Location = new System.Drawing.Point(3, 214);
            this.safeFileNamesListControl.Name = "safeFileNamesListControl";
            this.safeFileNamesListControl.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.safeFileNamesListControl.Size = new System.Drawing.Size(194, 277);
            this.safeFileNamesListControl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2142, 1156);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiSelectCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragdropCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expandToCurrDirCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHiddenFilesCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterDescriptorsDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeFileNamesListControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.ExplorerControl explorerControl1;
        private Telerik.WinControls.UI.RadDropDownList filterDescriptorsDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadCheckBox showHiddenFilesCheckBox;
        private Telerik.WinControls.UI.RadCheckBox expandToCurrDirCheckBox;
        private Telerik.WinControls.UI.RadCheckBox dragdropCheckBox;
        private Telerik.WinControls.UI.RadCheckBox multiSelectCheckBox;
        private Telerik.WinControls.UI.RadListControl safeFileNamesListControl;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}