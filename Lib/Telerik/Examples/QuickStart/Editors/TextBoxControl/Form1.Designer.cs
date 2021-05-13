namespace Telerik.Examples.WinControls.Editors.TextBoxControl
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
            this.radBtnSetBackgroundImage = new Telerik.WinControls.UI.RadButton();
            this.radTextBoxControl1 = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButtonSearch = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnSetBackgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1341, 24);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radBtnSetBackgroundImage);
            this.settingsPanel.PanelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(86, 759);
            this.settingsPanel.Size = new System.Drawing.Size(86, 780);
            // 
            // radBtnSetBackgroundImage
            // 
            this.radBtnSetBackgroundImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radBtnSetBackgroundImage.Location = new System.Drawing.Point(-76, 25);
            this.radBtnSetBackgroundImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radBtnSetBackgroundImage.Name = "radBtnSetBackgroundImage";
            this.radBtnSetBackgroundImage.Size = new System.Drawing.Size(61, 30);
            this.radBtnSetBackgroundImage.TabIndex = 1;
            this.radBtnSetBackgroundImage.Text = "Set Background Image";
            // 
            // radTextBoxControl1
            // 
            this.radTextBoxControl1.Location = new System.Drawing.Point(129, 171);
            this.radTextBoxControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTextBoxControl1.Name = "radTextBoxControl1";
            this.radTextBoxControl1.NullText = "Search in Bing";
            this.radTextBoxControl1.ShowClearButton = true;
            this.radTextBoxControl1.Size = new System.Drawing.Size(465, 35);
            this.radTextBoxControl1.TabIndex = 2;
            ((Telerik.WinControls.UI.RadTextBoxControlElement)(this.radTextBoxControl1.GetChildAt(0))).BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.textbox_bg;
            ((Telerik.WinControls.UI.TextBoxViewElement)(this.radTextBoxControl1.GetChildAt(0).GetChildAt(0))).Padding = new System.Windows.Forms.Padding(31, 8, 3, 0);
            ((Telerik.WinControls.UI.TextBoxWrapPanel)(this.radTextBoxControl1.GetChildAt(0).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(31, 8, 3, 0);
            // 
            // radPanel1
            // 
            this.radPanel1.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.ballons_image;
            this.radPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radPanel1.Controls.Add(this.radButtonSearch);
            this.radPanel1.Controls.Add(this.radTextBoxControl1);
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(752, 525);
            this.radPanel1.TabIndex = 3;
            // 
            // radButtonSearch
            // 
            this.radButtonSearch.Image = global::Telerik.Examples.WinControls.Properties.Resources.search;
            this.radButtonSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonSearch.Location = new System.Drawing.Point(601, 171);
            this.radButtonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radButtonSearch.Name = "radButtonSearch";
            this.radButtonSearch.Size = new System.Drawing.Size(40, 35);
            this.radButtonSearch.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96, 96);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2527, 1464);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radBtnSetBackgroundImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radBtnSetBackgroundImage;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton radButtonSearch;
    }
}