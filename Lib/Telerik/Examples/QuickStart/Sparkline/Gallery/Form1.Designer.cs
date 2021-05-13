namespace Telerik.Examples.WinControls.Sparkline.Gallery
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition8 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition7 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridLineSpark = new Telerik.WinControls.UI.RadGridView();
            this.gridAreaSpark = new Telerik.WinControls.UI.RadGridView();
            this.gridBarSpark = new Telerik.WinControls.UI.RadGridView();
            this.gridWinLossSpark = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLineSpark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLineSpark.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAreaSpark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAreaSpark.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarSpark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarSpark.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWinLossSpark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWinLossSpark.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.gridWinLossSpark);
            this.radPanelDemoHolder.Controls.Add(this.gridBarSpark);
            this.radPanelDemoHolder.Controls.Add(this.gridAreaSpark);
            this.radPanelDemoHolder.Controls.Add(this.gridLineSpark);
            this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(136, 172);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(1300, 470);
            // 
            // settingsPanel
            // 
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(230, 170);
            this.settingsPanel.Size = new System.Drawing.Size(230, 170);
            // 
            // radGridView1
            // 
            this.gridLineSpark.AllowRowResize = false;
            this.gridLineSpark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLineSpark.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridLineSpark.MasterTemplate.ViewDefinition = tableViewDefinition8;
            this.gridLineSpark.Name = "radGridView1";
            this.gridLineSpark.Size = new System.Drawing.Size(1300, 110);
            this.gridLineSpark.TabIndex = 0;
            // 
            // radGridView2
            // 
            this.gridAreaSpark.AllowRowResize = false;
            this.gridAreaSpark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAreaSpark.Location = new System.Drawing.Point(0, 120);
            // 
            // 
            // 
            this.gridAreaSpark.MasterTemplate.ViewDefinition = tableViewDefinition7;
            this.gridAreaSpark.Name = "radGridView2";
            this.gridAreaSpark.Size = new System.Drawing.Size(1300, 110);
            this.gridAreaSpark.TabIndex = 1;
            // 
            // radGridView3
            // 
            this.gridBarSpark.AllowRowResize = false;
            this.gridBarSpark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBarSpark.Location = new System.Drawing.Point(0, 240);
            // 
            // 
            // 
            this.gridBarSpark.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.gridBarSpark.Name = "radGridView3";
            this.gridBarSpark.Size = new System.Drawing.Size(1300, 110);
            this.gridBarSpark.TabIndex = 2;
            // 
            // radGridView4
            // 
            this.gridWinLossSpark.AllowRowResize = false;
            this.gridWinLossSpark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridWinLossSpark.Location = new System.Drawing.Point(0, 360);
            // 
            // 
            // 
            this.gridWinLossSpark.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.gridWinLossSpark.Name = "radGridView4";
            this.gridWinLossSpark.Size = new System.Drawing.Size(1300, 110);
            this.gridWinLossSpark.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1045, 916);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLineSpark.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLineSpark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAreaSpark.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAreaSpark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarSpark.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarSpark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWinLossSpark.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWinLossSpark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridWinLossSpark;
        private Telerik.WinControls.UI.RadGridView gridBarSpark;
        private Telerik.WinControls.UI.RadGridView gridAreaSpark;
        private Telerik.WinControls.UI.RadGridView gridLineSpark;
    }
}