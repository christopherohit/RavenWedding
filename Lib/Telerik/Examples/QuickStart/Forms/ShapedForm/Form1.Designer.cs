namespace Telerik.Examples.WinControls.Forms.ShapedForm
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
            this.radGroupShapeOpts = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioCD = new Telerik.WinControls.UI.RadRadioButton();
            this.radButtonCreate = new Telerik.WinControls.UI.RadButton();
            this.radRadioRound = new Telerik.WinControls.UI.RadRadioButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButtonPop = new Telerik.WinControls.UI.RadButton();
            this.object_6529839b_d73e_4e3a_9de1_163a623271ad = new Telerik.WinControls.RootRadElement();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupShapeOpts)).BeginInit();
            this.radGroupShapeOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPop)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radButtonPop);
            this.settingsPanel.Controls.Add(this.radGroupShapeOpts);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 818);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupShapeOpts, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radButtonPop, 0);
            // 
            // radGroupShapeOpts
            // 
            this.radGroupShapeOpts.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupShapeOpts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupShapeOpts.Controls.Add(this.radRadioCD);
            this.radGroupShapeOpts.Controls.Add(this.radButtonCreate);
            this.radGroupShapeOpts.Controls.Add(this.radRadioRound);
            this.radGroupShapeOpts.FooterText = "";
            this.radGroupShapeOpts.HeaderText = "Shape Options";
            this.radGroupShapeOpts.Location = new System.Drawing.Point(10, 6);
            this.radGroupShapeOpts.Name = "radGroupShapeOpts";
            this.radGroupShapeOpts.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupShapeOpts.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupShapeOpts.Size = new System.Drawing.Size(180, 117);
            this.radGroupShapeOpts.TabIndex = 0;
            this.radGroupShapeOpts.Text = "Shape Options";
            // 
            // radRadioCD
            // 
            this.radRadioCD.Location = new System.Drawing.Point(20, 54);
            this.radRadioCD.Name = "radRadioCD";
            this.radRadioCD.Size = new System.Drawing.Size(35, 18);
            this.radRadioCD.TabIndex = 0;
            this.radRadioCD.Text = "CD";
            // 
            // radButtonCreate
            // 
            this.radButtonCreate.Location = new System.Drawing.Point(20, 76);
            this.radButtonCreate.Name = "radButtonCreate";
            this.radButtonCreate.Size = new System.Drawing.Size(108, 23);
            this.radButtonCreate.TabIndex = 2;
            this.radButtonCreate.Text = "Create New Shape";
            // 
            // radRadioRound
            // 
            this.radRadioRound.Location = new System.Drawing.Point(20, 32);
            this.radRadioRound.Name = "radRadioRound";
            this.radRadioRound.Size = new System.Drawing.Size(105, 18);
            this.radRadioRound.TabIndex = 0;
            this.radRadioRound.Text = "Round Rectangle";
            // 
            // radPanel1
            // 
            this.radPanel1.ForeColor = System.Drawing.Color.Black;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(402, 304);
            this.radPanel1.TabIndex = 1;
            // 
            // radButtonPop
            // 
            this.radButtonPop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonPop.Location = new System.Drawing.Point(10, 129);
            this.radButtonPop.Name = "radButtonPop";
            this.radButtonPop.Size = new System.Drawing.Size(180, 23);
            this.radButtonPop.TabIndex = 1;
            this.radButtonPop.Text = "Pop Form Out";
            // 
            // object_6529839b_d73e_4e3a_9de1_163a623271ad
            // 
            this.object_6529839b_d73e_4e3a_9de1_163a623271ad.Name = "object_6529839b_d73e_4e3a_9de1_163a623271ad";
            this.object_6529839b_d73e_4e3a_9de1_163a623271ad.StretchHorizontally = true;
            this.object_6529839b_d73e_4e3a_9de1_163a623271ad.StretchVertically = true;
            this.object_6529839b_d73e_4e3a_9de1_163a623271ad.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1142, 599);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupShapeOpts)).EndInit();
            this.radGroupShapeOpts.ResumeLayout(false);
            this.radGroupShapeOpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupShapeOpts;
        private Telerik.WinControls.UI.RadRadioButton radRadioCD;
        private Telerik.WinControls.UI.RadRadioButton radRadioRound;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton radButtonPop;
        private Telerik.WinControls.RootRadElement object_6529839b_d73e_4e3a_9de1_163a623271ad;
        private Telerik.WinControls.UI.RadButton radButtonCreate;
    }
}