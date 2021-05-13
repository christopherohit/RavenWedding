namespace Telerik.Examples.WinControls.DropDownListAndListControl.CreatingNewItems
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radio_CreateCheckBox = new Telerik.WinControls.UI.RadRadioButton();
            this.radio_CreateRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            this.radGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radio_CreateCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_CreateRadioButton)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radListControl1);
            this.radGroupBox1.HeaderText = "ListControl";
            this.radGroupBox1.Location = new System.Drawing.Point(20, 20);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(270, 438);
            this.radGroupBox1.TabIndex = 7;
            this.radGroupBox1.Text = "ListControl";
            // 
            // radListControl1
            // 
            this.radListControl1.Location = new System.Drawing.Point(13, 23);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(244, 402);
            this.radListControl1.TabIndex = 1;
            this.radListControl1.Text = "radListControl1";
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox4.Controls.Add(this.radDropDownList1);
            this.radGroupBox4.HeaderText = "DropDownList";
            this.radGroupBox4.Location = new System.Drawing.Point(370, 20);
            this.radGroupBox4.Name = "radGroupBox4";
            this.radGroupBox4.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox4.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox4.Size = new System.Drawing.Size(270, 438);
            this.radGroupBox4.TabIndex = 9;
            this.radGroupBox4.Text = "DropDownList";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownAnimationEnabled = false;            
            this.radDropDownList1.Location = new System.Drawing.Point(13, 25);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(244, 20);
            this.radDropDownList1.TabIndex = 2;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox2.Controls.Add(this.radio_CreateCheckBox);
            this.radGroupBox2.Controls.Add(this.radio_CreateRadioButton);
            this.radGroupBox2.HeaderText = "Custom object type:";
            this.radGroupBox2.Location = new System.Drawing.Point(10, 54);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox2.Size = new System.Drawing.Size(163, 100);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Custom object type:";
            // 
            // radio_CreateCheckBox
            // 
            this.radio_CreateCheckBox.Location = new System.Drawing.Point(36, 67);
            this.radio_CreateCheckBox.Name = "radio_CreateCheckBox";
            this.radio_CreateCheckBox.Size = new System.Drawing.Size(69, 18);
            this.radio_CreateCheckBox.TabIndex = 0;
            this.radio_CreateCheckBox.Text = "CheckBox";
            // 
            // radio_CreateRadioButton
            // 
            this.radio_CreateRadioButton.Location = new System.Drawing.Point(36, 36);
            this.radio_CreateRadioButton.Name = "radio_CreateRadioButton";
            this.radio_CreateRadioButton.Size = new System.Drawing.Size(86, 18);
            this.radio_CreateRadioButton.TabIndex = 0;
            this.radio_CreateRadioButton.TabStop = true;
            this.radio_CreateRadioButton.Text = "Radio Button";
            this.radio_CreateRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox4);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1142, 599);
            this.Controls.SetChildIndex(this.radGroupBox4, 0);
            this.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            this.radGroupBox4.ResumeLayout(false);
            this.radGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radio_CreateCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_CreateRadioButton)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadRadioButton radio_CreateRadioButton;
        private Telerik.WinControls.UI.RadRadioButton radio_CreateCheckBox;
    }
}