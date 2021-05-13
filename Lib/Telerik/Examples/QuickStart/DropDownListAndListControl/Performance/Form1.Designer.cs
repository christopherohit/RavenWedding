namespace Telerik.Examples.WinControls.DropDownListAndListControl.Performance
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
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.button_Bind = new Telerik.WinControls.UI.RadButton();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabelElapsed = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabelElapsedDropDownList = new Telerik.WinControls.UI.RadLabel();
            this.radLabelElapsedListControl = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Bind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelElapsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelElapsedDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelElapsedListControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            this.radGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1096, 1);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.button_Bind);
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox3);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(200, 832);
            this.settingsPanel.Size = new System.Drawing.Size(200, 832);
            // 
            // radListControl1
            // 
            this.radListControl1.Location = new System.Drawing.Point(13, 36);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(133, 370);
            this.radListControl1.TabIndex = 1;
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownAnimationEnabled = false;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList1.Location = new System.Drawing.Point(13, 38);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(133, 20);
            this.radDropDownList1.TabIndex = 2;
            // 
            // button_Bind
            // 
            this.button_Bind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Bind.Location = new System.Drawing.Point(-5, 110);
            this.button_Bind.Name = "button_Bind";
            this.button_Bind.Size = new System.Drawing.Size(180, 24);
            this.button_Bind.TabIndex = 1;
            this.button_Bind.Text = "Bind";
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditor1.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.radSpinEditor1.Location = new System.Drawing.Point(13, 23);
            this.radSpinEditor1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.radSpinEditor1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditor1.Name = "radSpinEditor1";
            this.radSpinEditor1.NullableValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // 
            // 
            this.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditor1.Size = new System.Drawing.Size(154, 20);
            this.radSpinEditor1.TabIndex = 2;
            this.radSpinEditor1.TabStop = false;
            this.radSpinEditor1.ThousandsSeparator = true;
            this.radSpinEditor1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radLabelElapsed
            // 
            this.radLabelElapsed.Location = new System.Drawing.Point(13, 36);
            this.radLabelElapsed.MaximumSize = new System.Drawing.Size(230, 0);
            this.radLabelElapsed.Name = "radLabelElapsed";
            // 
            // 
            // 
            this.radLabelElapsed.RootElement.MaxSize = new System.Drawing.Size(230, 0);
            this.radLabelElapsed.Size = new System.Drawing.Size(195, 32);
            this.radLabelElapsed.TabIndex = 3;
            this.radLabelElapsed.Text = "<html>Press the <strong>Bind</strong> button to measure the binding time with</ht" +
    "ml>";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radListControl1);
            this.radGroupBox1.HeaderText = "ListControl";
            this.radGroupBox1.Location = new System.Drawing.Point(20, 20);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(159, 419);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "ListControl";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radLabelElapsedDropDownList);
            this.radGroupBox2.Controls.Add(this.radLabelElapsedListControl);
            this.radGroupBox2.Controls.Add(this.radLabelElapsed);
            this.radGroupBox2.HeaderText = "Test Results";
            this.radGroupBox2.Location = new System.Drawing.Point(380, 20);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox2.Size = new System.Drawing.Size(246, 419);
            this.radGroupBox2.TabIndex = 5;
            this.radGroupBox2.Text = "Test Results";
            // 
            // radLabelElapsedDropDownList
            // 
            this.radLabelElapsedDropDownList.Location = new System.Drawing.Point(14, 107);
            this.radLabelElapsedDropDownList.MaximumSize = new System.Drawing.Size(230, 0);
            this.radLabelElapsedDropDownList.Name = "radLabelElapsedDropDownList";
            // 
            // 
            // 
            this.radLabelElapsedDropDownList.RootElement.MaxSize = new System.Drawing.Size(230, 0);
            this.radLabelElapsedDropDownList.Size = new System.Drawing.Size(2, 2);
            this.radLabelElapsedDropDownList.TabIndex = 5;
            // 
            // radLabelElapsedListControl
            // 
            this.radLabelElapsedListControl.Location = new System.Drawing.Point(14, 72);
            this.radLabelElapsedListControl.MaximumSize = new System.Drawing.Size(230, 0);
            this.radLabelElapsedListControl.Name = "radLabelElapsedListControl";
            // 
            // 
            // 
            this.radLabelElapsedListControl.RootElement.MaxSize = new System.Drawing.Size(230, 0);
            this.radLabelElapsedListControl.Size = new System.Drawing.Size(2, 2);
            this.radLabelElapsedListControl.TabIndex = 4;
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox3.Controls.Add(this.radSpinEditor1);
            this.radGroupBox3.HeaderText = "Items Count";
            this.radGroupBox3.Location = new System.Drawing.Point(-5, 41);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox3.Size = new System.Drawing.Size(180, 53);
            this.radGroupBox3.TabIndex = 3;
            this.radGroupBox3.Text = "Items Count";
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox4.Controls.Add(this.radDropDownList1);
            this.radGroupBox4.HeaderText = "DropDownList";
            this.radGroupBox4.Location = new System.Drawing.Point(200, 20);
            this.radGroupBox4.Name = "radGroupBox4";
            this.radGroupBox4.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox4.Size = new System.Drawing.Size(159, 419);
            this.radGroupBox4.TabIndex = 6;
            this.radGroupBox4.Text = "DropDownList";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox4);
            this.Controls.Add(this.radGroupBox2);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2011, 1157);
            this.Controls.SetChildIndex(this.radGroupBox2, 0);
            this.Controls.SetChildIndex(this.radGroupBox4, 0);
            this.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Bind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelElapsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelElapsedDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelElapsedListControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            this.radGroupBox4.ResumeLayout(false);
            this.radGroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private Telerik.WinControls.UI.RadButton button_Bind;
        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private Telerik.WinControls.UI.RadLabel radLabelElapsed;        
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private Telerik.WinControls.UI.RadLabel radLabelElapsedDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabelElapsedListControl;
    }
}