namespace Telerik.Examples.WinControls.Editors.BrowseEditor.Settings
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
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.readOnlyCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.clearButtonCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.radBrowseEditor1 = new Telerik.WinControls.UI.RadBrowseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readOnlyCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButtonCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBrowseEditor1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radBrowseEditor1);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(1634, 1126);
            // 
            // settingsPanel
            // 
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.clearButtonCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.readOnlyCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.radDropDownList1);
            // 
            // optionsLabel
            // 
            this.optionsLabel.Location = new System.Drawing.Point(3, 306);
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Location = new System.Drawing.Point(3, 82);
            this.radDropDownList1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(125, 20);
            this.radDropDownList1.TabIndex = 1;
            this.radDropDownList1.Text = "radDropDownList1";
            // 
            // readOnlyCheckBox
            // 
            this.readOnlyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.readOnlyCheckBox.Location = new System.Drawing.Point(3, 20);
            this.readOnlyCheckBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.readOnlyCheckBox.Name = "readOnlyCheckBox";
            this.readOnlyCheckBox.Size = new System.Drawing.Size(72, 18);
            this.readOnlyCheckBox.TabIndex = 2;
            this.readOnlyCheckBox.Text = "Read Only";
            this.readOnlyCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.readOnlyCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ReadOnlyCheckBox_ToggleStateChanged);
            // 
            // clearButtonCheckBox
            // 
            this.clearButtonCheckBox.Location = new System.Drawing.Point(3, 51);
            this.clearButtonCheckBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.clearButtonCheckBox.Name = "clearButtonCheckBox";
            this.clearButtonCheckBox.Size = new System.Drawing.Size(113, 18);
            this.clearButtonCheckBox.TabIndex = 3;
            this.clearButtonCheckBox.Text = "Show Clear Button";
            this.clearButtonCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ClearButtonCheckBox_ToggleStateChanged);
            // 
            // radBrowseEditor1
            // 
            this.radBrowseEditor1.Location = new System.Drawing.Point(182, 579);
            this.radBrowseEditor1.Name = "radBrowseEditor1";
            this.radBrowseEditor1.Size = new System.Drawing.Size(394, 20);
            this.radBrowseEditor1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1634, 1126);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readOnlyCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButtonCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBrowseEditor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadCheckBox clearButtonCheckBox;
        private Telerik.WinControls.UI.RadCheckBox readOnlyCheckBox;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadBrowseEditor radBrowseEditor1;
    }
}