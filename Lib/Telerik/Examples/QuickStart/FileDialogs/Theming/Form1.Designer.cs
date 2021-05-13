namespace Telerik.Examples.WinControls.FileDialogs.Theming
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
            this.openFileDialogButton = new Telerik.WinControls.UI.RadButton();
            this.openFolderDialogButton = new Telerik.WinControls.UI.RadButton();
            this.saveFileDialogButton = new Telerik.WinControls.UI.RadButton();
            this.radOpenFileDialog1 = new Telerik.WinControls.UI.RadOpenFileDialog();
            this.radSaveFileDialog1 = new Telerik.WinControls.UI.RadSaveFileDialog();
            this.radOpenFolderDialog1 = new Telerik.WinControls.UI.RadOpenFolderDialog();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileDialogButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolderDialogButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveFileDialogButton)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.saveFileDialogButton);
            this.radPanelDemoHolder.Controls.Add(this.openFolderDialogButton);
            this.radPanelDemoHolder.Controls.Add(this.openFileDialogButton);
            this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(185, 165);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(419, 220);
            // 
            // settingsPanel
            // 
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(83, 46);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(250, 28);
            this.openFileDialogButton.TabIndex = 0;
            this.openFileDialogButton.Text = "Open RadOpenFileDialog";
            this.openFileDialogButton.Click += new System.EventHandler(this.OpenFileDialogButton_Click);
            // 
            // openFolderDialogButton
            // 
            this.openFolderDialogButton.Location = new System.Drawing.Point(83, 90);
            this.openFolderDialogButton.Name = "openFolderDialogButton";
            this.openFolderDialogButton.Size = new System.Drawing.Size(250, 28);
            this.openFolderDialogButton.TabIndex = 1;
            this.openFolderDialogButton.Text = "Open RadOpenFolderDialog";
            this.openFolderDialogButton.Click += new System.EventHandler(this.OpenFolderDialogButton_Click);
            // 
            // saveFileDialogButton
            // 
            this.saveFileDialogButton.Location = new System.Drawing.Point(83, 135);
            this.saveFileDialogButton.Name = "saveFileDialogButton";
            this.saveFileDialogButton.Size = new System.Drawing.Size(250, 28);
            this.saveFileDialogButton.TabIndex = 1;
            this.saveFileDialogButton.Text = "Open RadSaveFileDialog";
            this.saveFileDialogButton.Click += new System.EventHandler(this.SaveFileDialogButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2142, 1156);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileDialogButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolderDialogButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveFileDialogButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton saveFileDialogButton;
        private Telerik.WinControls.UI.RadButton openFolderDialogButton;
        private Telerik.WinControls.UI.RadButton openFileDialogButton;
        private Telerik.WinControls.UI.RadOpenFileDialog radOpenFileDialog1;
        private Telerik.WinControls.UI.RadSaveFileDialog radSaveFileDialog1;
        private Telerik.WinControls.UI.RadOpenFolderDialog radOpenFolderDialog1;
    }
}