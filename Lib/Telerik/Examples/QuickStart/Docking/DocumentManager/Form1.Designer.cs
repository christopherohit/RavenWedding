namespace Telerik.Examples.WinControls.Docking.DocumentManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentWindow11 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow4 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentWindow8 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentWindow3 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentWindow5 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentWindow6 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.radSplitContainer2 = new Telerik.WinControls.UI.RadSplitContainer();
            this.documentTabStrip5 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow2 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentTabStrip6 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow10 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentTabStrip3 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow7 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentWindow9 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.sortNone = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.sortByActivation = new Telerik.WinControls.UI.RadRadioButton();
            this.sortByText = new Telerik.WinControls.UI.RadRadioButton();
            this.addDoc = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).BeginInit();
            this.radSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip5)).BeginInit();
            this.documentTabStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip6)).BeginInit();
            this.documentTabStrip6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip3)).BeginInit();
            this.documentTabStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortByActivation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortByText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.addDoc);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.radButton2);
            this.settingsPanel.Controls.Add(this.radButton1);
            this.settingsPanel.Location = new System.Drawing.Point(552, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 806);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radButton1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radButton2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.addDoc, 0);
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.documentWindow11;
            this.radDock1.CausesValidation = false;
            this.radDock1.Controls.Add(this.documentContainer1);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
            this.radDock1.Location = new System.Drawing.Point(0, 0);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.Size = new System.Drawing.Size(753, 808);
            this.radDock1.TabIndex = 1;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            // 
            // documentWindow11
            // 
            this.documentWindow11.Location = new System.Drawing.Point(5, 27);
            this.documentWindow11.Name = "documentWindow11";
            this.documentWindow11.Size = new System.Drawing.Size(743, 370);
            this.documentWindow11.Text = "documentWindow7";
            // 
            // documentContainer1
            // 
            this.documentContainer1.CausesValidation = false;
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Controls.Add(this.radSplitContainer1);
            this.documentContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.documentContainer1.Location = new System.Drawing.Point(0, 0);
            this.documentContainer1.Name = "documentContainer1";
            this.documentContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.Size = new System.Drawing.Size(753, 808);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.TabIndex = 0;
            this.documentContainer1.TabStop = false;
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CausesValidation = false;
            this.documentTabStrip1.Controls.Add(this.documentWindow11);
            this.documentTabStrip1.Controls.Add(this.documentWindow4);
            this.documentTabStrip1.Controls.Add(this.documentWindow8);
            this.documentTabStrip1.Controls.Add(this.documentWindow3);
            this.documentTabStrip1.Controls.Add(this.documentWindow5);
            this.documentTabStrip1.Controls.Add(this.documentWindow6);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(753, 402);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            // 
            // documentWindow4
            // 
            this.documentWindow4.Location = new System.Drawing.Point(5, 27);
            this.documentWindow4.Name = "documentWindow4";
            this.documentWindow4.Size = new System.Drawing.Size(831, 228);
            this.documentWindow4.Text = "documentWindow4";
            // 
            // documentWindow8
            // 
            this.documentWindow8.Location = new System.Drawing.Point(5, 27);
            this.documentWindow8.Name = "documentWindow8";
            this.documentWindow8.Size = new System.Drawing.Size(831, 228);
            this.documentWindow8.Text = "documentWindow10";
            // 
            // documentWindow3
            // 
            this.documentWindow3.Location = new System.Drawing.Point(5, 27);
            this.documentWindow3.Name = "documentWindow3";
            this.documentWindow3.Size = new System.Drawing.Size(831, 228);
            this.documentWindow3.Text = "documentWindow3";
            // 
            // documentWindow5
            // 
            this.documentWindow5.Location = new System.Drawing.Point(5, 27);
            this.documentWindow5.Name = "documentWindow5";
            this.documentWindow5.Size = new System.Drawing.Size(831, 228);
            this.documentWindow5.Text = "documentWindow9";
            // 
            // documentWindow6
            // 
            this.documentWindow6.Location = new System.Drawing.Point(5, 27);
            this.documentWindow6.Name = "documentWindow6";
            this.documentWindow6.Size = new System.Drawing.Size(1299, 252);
            this.documentWindow6.Text = "documentWindow8";
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.radSplitContainer2);
            this.radSplitContainer1.Controls.Add(this.documentTabStrip3);
            this.radSplitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radSplitContainer1.IsCleanUpTarget = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 405);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(753, 403);
            this.radSplitContainer1.TabIndex = 2;
            this.radSplitContainer1.TabStop = false;
            // 
            // radSplitContainer2
            // 
            this.radSplitContainer2.Controls.Add(this.documentTabStrip5);
            this.radSplitContainer2.Controls.Add(this.documentTabStrip6);
            this.radSplitContainer2.IsCleanUpTarget = true;
            this.radSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer2.Name = "radSplitContainer2";
            this.radSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer2.Size = new System.Drawing.Size(375, 403);
            this.radSplitContainer2.TabIndex = 4;
            this.radSplitContainer2.TabStop = false;
            // 
            // documentTabStrip5
            // 
            this.documentTabStrip5.Controls.Add(this.documentWindow2);
            this.documentTabStrip5.Controls.Add(this.documentWindow1);
            this.documentTabStrip5.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip5.Name = "documentTabStrip5";
            // 
            // 
            // 
            this.documentTabStrip5.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip5.SelectedIndex = 0;
            this.documentTabStrip5.Size = new System.Drawing.Size(375, 200);
            this.documentTabStrip5.TabIndex = 2;
            this.documentTabStrip5.TabStop = false;
            // 
            // documentWindow2
            // 
            this.documentWindow2.Location = new System.Drawing.Point(5, 27);
            this.documentWindow2.Name = "documentWindow2";
            this.documentWindow2.Size = new System.Drawing.Size(365, 168);
            this.documentWindow2.Text = "documentWindow2";
            // 
            // documentWindow1
            // 
            this.documentWindow1.Location = new System.Drawing.Point(5, 27);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.Size = new System.Drawing.Size(831, 227);
            this.documentWindow1.Text = "documentWindow1";
            // 
            // documentTabStrip6
            // 
            this.documentTabStrip6.Controls.Add(this.documentWindow10);
            this.documentTabStrip6.Location = new System.Drawing.Point(0, 203);
            this.documentTabStrip6.Name = "documentTabStrip6";
            // 
            // 
            // 
            this.documentTabStrip6.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip6.SelectedIndex = 0;
            this.documentTabStrip6.Size = new System.Drawing.Size(375, 200);
            this.documentTabStrip6.TabIndex = 3;
            this.documentTabStrip6.TabStop = false;
            // 
            // documentWindow10
            // 
            this.documentWindow10.Location = new System.Drawing.Point(5, 27);
            this.documentWindow10.Name = "documentWindow10";
            this.documentWindow10.Size = new System.Drawing.Size(365, 168);
            this.documentWindow10.Text = "documentWindow6";
            // 
            // documentTabStrip3
            // 
            this.documentTabStrip3.Controls.Add(this.documentWindow7);
            this.documentTabStrip3.Controls.Add(this.documentWindow9);
  
            this.documentTabStrip3.Location = new System.Drawing.Point(378, 0);
            this.documentTabStrip3.Name = "documentTabStrip3";
            // 
            // 
            // 
            this.documentTabStrip3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip3.SelectedIndex = 0;
            this.documentTabStrip3.Size = new System.Drawing.Size(375, 403);
            this.documentTabStrip3.TabIndex = 3;
            this.documentTabStrip3.TabStop = false;
            // 
            // documentWindow7
            // 
            this.documentWindow7.Location = new System.Drawing.Point(5, 27);
            this.documentWindow7.Name = "documentWindow7";
            this.documentWindow7.Size = new System.Drawing.Size(365, 371);
            this.documentWindow7.Text = "documentWindow5";
            // 
            // documentWindow9
            // 
            this.documentWindow9.Location = new System.Drawing.Point(5, 27);
            this.documentWindow9.Name = "documentWindow9";
            this.documentWindow9.Size = new System.Drawing.Size(643, 251);
            this.documentWindow9.Text = "documentWindow11";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton1.Location = new System.Drawing.Point(10, 90);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(180, 47);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Next Document (CTRL+F6)";
      
            // 
            // radButton2
            // 
            this.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton2.Location = new System.Drawing.Point(10, 143);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(180, 47);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "Prev. Document (CTRL+SHIFT+F6)";
            this.radButton2.TextWrap = true;
   
            // 
            // sortNone
            // 
            this.sortNone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortNone.AutoSize = true;
            this.sortNone.Location = new System.Drawing.Point(13, 23);
            this.sortNone.Name = "sortNone";
            this.sortNone.Size = new System.Drawing.Size(47, 16);
            this.sortNone.TabIndex = 3;
            this.sortNone.Text = "None";
       
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.sortByActivation);
            this.radGroupBox1.Controls.Add(this.sortByText);
            this.radGroupBox1.Controls.Add(this.sortNone);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Active Document Sort Order";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 203);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 100);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "Active Document Sort Order";
            // 
            // sortByActivation
            // 
            this.sortByActivation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortByActivation.AutoSize = true;
            this.sortByActivation.Location = new System.Drawing.Point(13, 67);
            this.sortByActivation.Name = "sortByActivation";
            this.sortByActivation.Size = new System.Drawing.Size(118, 16);
            this.sortByActivation.TabIndex = 5;
            this.sortByActivation.Text = "By Activation Order";
          
            // 
            // sortByText
            // 
            this.sortByText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortByText.AutoSize = true;
            this.sortByText.Location = new System.Drawing.Point(13, 45);
            this.sortByText.Name = "sortByText";
            this.sortByText.Size = new System.Drawing.Size(58, 16);
            this.sortByText.TabIndex = 4;
            this.sortByText.Text = "By Text";
            this.sortByText.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        
            // 
            // addDoc
            // 
            this.addDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addDoc.Location = new System.Drawing.Point(10, 37);
            this.addDoc.Name = "addDoc";
            this.addDoc.Size = new System.Drawing.Size(180, 47);
            this.addDoc.TabIndex = 5;
            this.addDoc.Text = "Add Document";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radDock1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(753, 808);
            this.Controls.SetChildIndex(this.radDock1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).EndInit();
            this.radSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip5)).EndInit();
            this.documentTabStrip5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip6)).EndInit();
            this.documentTabStrip6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip3)).EndInit();
            this.documentTabStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortByActivation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortByText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow4;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow3;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow2;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.RadRadioButton sortNone;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow6;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow5;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip3;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow7;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow8;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow9;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow10;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow11;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton sortByActivation;
        private Telerik.WinControls.UI.RadRadioButton sortByText;
        private Telerik.WinControls.UI.RadButton addDoc;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer2;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip5;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip6;
    }
}
