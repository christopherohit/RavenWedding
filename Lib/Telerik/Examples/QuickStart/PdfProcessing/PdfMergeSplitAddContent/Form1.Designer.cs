namespace Telerik.Examples.WinControls.PdfProcessing.PdfMergeSplitAddContent
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
            this.doubleBufferedFlowLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel();
            this.mergePagesButton = new Telerik.WinControls.UI.RadButton();
            this.splitPagesButton = new Telerik.WinControls.UI.RadButton();
            this.appendContentButton = new Telerik.WinControls.UI.RadButton();
            this.prependContentButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            this.doubleBufferedFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mergePagesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPagesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appendContentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prependContentButton)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            // 
            // flowLayoutPanel1
            // 
            this.doubleBufferedFlowLayoutPanel1.Controls.Add(this.mergePagesButton);
            this.doubleBufferedFlowLayoutPanel1.Controls.Add(this.splitPagesButton);
            this.doubleBufferedFlowLayoutPanel1.Controls.Add(this.appendContentButton);
            this.doubleBufferedFlowLayoutPanel1.Controls.Add(this.prependContentButton);
            this.doubleBufferedFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleBufferedFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.doubleBufferedFlowLayoutPanel1.Name = "doubleBufferedFlowLayoutPanel1";
            this.doubleBufferedFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(17);
            this.doubleBufferedFlowLayoutPanel1.Size = new System.Drawing.Size(2011, 1157);
            this.doubleBufferedFlowLayoutPanel1.TabIndex = 0;
            // 
            // mergePagesButton
            // 
            this.mergePagesButton.Location = new System.Drawing.Point(20, 20);
            this.mergePagesButton.Name = "mergePagesButton";
            this.mergePagesButton.Size = new System.Drawing.Size(110, 24);
            this.mergePagesButton.TabIndex = 0;
            this.mergePagesButton.Text = "radButton1";
            this.mergePagesButton.Click += new System.EventHandler(this.MergePagesButton_Click);
            // 
            // splitPagesButton
            // 
            this.splitPagesButton.Location = new System.Drawing.Point(136, 20);
            this.splitPagesButton.Name = "splitPagesButton";
            this.splitPagesButton.Size = new System.Drawing.Size(110, 24);
            this.splitPagesButton.TabIndex = 1;
            this.splitPagesButton.Text = "radButton2";
            this.splitPagesButton.Click += new System.EventHandler(this.SplitPagesButton_Click);
            // 
            // appendContentButton
            // 
            this.appendContentButton.Location = new System.Drawing.Point(252, 20);
            this.appendContentButton.Name = "appendContentButton";
            this.appendContentButton.Size = new System.Drawing.Size(110, 24);
            this.appendContentButton.TabIndex = 2;
            this.appendContentButton.Text = "radButton3";
            this.appendContentButton.Click += new System.EventHandler(this.AppendContentButton_Click);
            // 
            // prependContentButton
            // 
            this.prependContentButton.Location = new System.Drawing.Point(368, 20);
            this.prependContentButton.Name = "prependContentButton";
            this.prependContentButton.Size = new System.Drawing.Size(110, 24);
            this.prependContentButton.TabIndex = 3;
            this.prependContentButton.Text = "radButton4";
            this.prependContentButton.Click += new System.EventHandler(this.PrependContentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doubleBufferedFlowLayoutPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2011, 1157);
            this.Controls.SetChildIndex(this.doubleBufferedFlowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            this.doubleBufferedFlowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mergePagesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPagesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appendContentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prependContentButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel doubleBufferedFlowLayoutPanel1;
        private Telerik.WinControls.UI.RadButton mergePagesButton;
        private Telerik.WinControls.UI.RadButton splitPagesButton;
        private Telerik.WinControls.UI.RadButton appendContentButton;
        private Telerik.WinControls.UI.RadButton prependContentButton;
    }
}