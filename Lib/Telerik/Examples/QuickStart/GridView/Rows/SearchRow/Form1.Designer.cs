namespace Telerik.Examples.WinControls.GridView.Rows.SearchRow
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radCheckBoxShowClearButton = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxShowCloseButton = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxCloseOnEscape = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxDeferredSearch = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowClearButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCloseOnEscape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxDeferredSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBoxCloseOnEscape);
            this.settingsPanel.Controls.Add(this.radCheckBoxShowCloseButton);
            this.settingsPanel.Controls.Add(this.radCheckBoxShowClearButton);
            this.settingsPanel.Controls.Add(this.radCheckBoxDeferredSearch);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxShowClearButton, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxShowCloseButton, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxCloseOnEscape, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxDeferredSearch, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1185, 990);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // radCheckBoxShowClearButton
            // 
            this.radCheckBoxShowClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxShowClearButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxShowClearButton.Location = new System.Drawing.Point(10, 33);
            this.radCheckBoxShowClearButton.Name = "radCheckBoxShowClearButton";
            this.radCheckBoxShowClearButton.Size = new System.Drawing.Size(111, 18);
            this.radCheckBoxShowClearButton.TabIndex = 1;
            this.radCheckBoxShowClearButton.Text = "Show clear button";
            this.radCheckBoxShowClearButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxShowClearButton.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowClearButton_ToggleStateChanged);
            // 
            // radCheckBoxShowCloseButton
            // 
            this.radCheckBoxShowCloseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxShowCloseButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxShowCloseButton.Location = new System.Drawing.Point(10, 58);
            this.radCheckBoxShowCloseButton.Name = "radCheckBoxShowCloseButton";
            this.radCheckBoxShowCloseButton.Size = new System.Drawing.Size(113, 18);
            this.radCheckBoxShowCloseButton.TabIndex = 2;
            this.radCheckBoxShowCloseButton.Text = "Show close button";
            this.radCheckBoxShowCloseButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxShowCloseButton.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowCloseButton_ToggleStateChanged);
            // 
            // radCheckBoxCloseOnEscape
            // 
            this.radCheckBoxCloseOnEscape.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxCloseOnEscape.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxCloseOnEscape.Location = new System.Drawing.Point(10, 83);
            this.radCheckBoxCloseOnEscape.Name = "radCheckBoxCloseOnEscape";
            this.radCheckBoxCloseOnEscape.Size = new System.Drawing.Size(101, 18);
            this.radCheckBoxCloseOnEscape.TabIndex = 3;
            this.radCheckBoxCloseOnEscape.Text = "Close on escape";
            this.radCheckBoxCloseOnEscape.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxCloseOnEscape.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxCloseOnEscape_ToggleStateChanged);
            // 
            // radCheckBoxDeferredSearch
            // 
            this.radCheckBoxDeferredSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxDeferredSearch.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.radCheckBoxDeferredSearch.Location = new System.Drawing.Point(10, 108);
            this.radCheckBoxDeferredSearch.Name = "radCheckBoxDeferredSearch";
            this.radCheckBoxDeferredSearch.Size = new System.Drawing.Size(101, 18);
            this.radCheckBoxDeferredSearch.TabIndex = 3;
            this.radCheckBoxDeferredSearch.Text = "Deferred search";
            this.radCheckBoxDeferredSearch.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            this.radCheckBoxDeferredSearch.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxDeferredSearch_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1195, 1000);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowClearButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCloseOnEscape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxDeferredSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxCloseOnEscape;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowCloseButton;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowClearButton;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxDeferredSearch;
    }
}