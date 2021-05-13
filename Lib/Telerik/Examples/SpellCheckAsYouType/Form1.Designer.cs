namespace SpellCheckAsYouType
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBox3 = new Telerik.WinControls.UI.RadCheckBox();
            this.radTextBoxControl1 = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radSpellChecker1 = new Telerik.WinControls.UI.RadSpellChecker();
            this.radSpellChecker2 = new Telerik.WinControls.UI.RadSpellChecker();
            this.radSpellChecker3 = new Telerik.WinControls.UI.RadSpellChecker();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(9, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(638, 146);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "The quick brown fox jamped voer the lazee dog";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radCheckBox1);
            this.radGroupBox1.Controls.Add(this.textBox1);
            this.radGroupBox1.HeaderText = "Microsoft TextBox";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(660, 223);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Microsoft TextBox";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox1.Location = new System.Drawing.Point(10, 188);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(196, 19);
            this.radCheckBox1.TabIndex = 0;
            this.radCheckBox1.Text = "Enable Spell Check As You Type";
            this.radCheckBox1.ThemeName = "TelerikMetro";
            this.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radToggleButton1_ToggleStateChanged);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.radCheckBox2);
            this.radGroupBox2.Controls.Add(this.radTextBox1);
            this.radGroupBox2.HeaderText = "RadTextBox";
            this.radGroupBox2.Location = new System.Drawing.Point(3, 252);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(660, 228);
            this.radGroupBox2.TabIndex = 3;
            this.radGroupBox2.Text = "RadTextBox";
            this.radGroupBox2.ThemeName = "TelerikMetro";
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox2.Location = new System.Drawing.Point(9, 193);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.Size = new System.Drawing.Size(196, 19);
            this.radCheckBox2.TabIndex = 1;
            this.radCheckBox2.Text = "Enable Spell Check As You Type";
            this.radCheckBox2.ThemeName = "TelerikMetro";
            this.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBox2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radToggleButton2_ToggleStateChanged);
            // 
            // radTextBox1
            // 
            this.radTextBox1.AcceptsReturn = true;
            this.radTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTextBox1.AutoSize = false;
            this.radTextBox1.Location = new System.Drawing.Point(9, 36);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(638, 146);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.Text = "The quick brown fox jamped voer the lazee dog";
            this.radTextBox1.ThemeName = "TelerikMetro";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.radCheckBox3);
            this.radGroupBox3.Controls.Add(this.radTextBoxControl1);
            this.radGroupBox3.HeaderText = "RadTextBoxControl";
            this.radGroupBox3.Location = new System.Drawing.Point(3, 498);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(660, 209);
            this.radGroupBox3.TabIndex = 4;
            this.radGroupBox3.Text = "RadTextBoxControl";
            this.radGroupBox3.ThemeName = "TelerikMetro";
            // 
            // radCheckBox3
            // 
            this.radCheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox3.Location = new System.Drawing.Point(10, 174);
            this.radCheckBox3.Name = "radCheckBox3";
            this.radCheckBox3.Size = new System.Drawing.Size(196, 19);
            this.radCheckBox3.TabIndex = 1;
            this.radCheckBox3.Text = "Enable Spell Check As You Type";
            this.radCheckBox3.ThemeName = "TelerikMetro";
            this.radCheckBox3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBox3.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox3_ToggleStateChanged);
            // 
            // radTextBoxControl1
            // 
            this.radTextBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTextBoxControl1.Location = new System.Drawing.Point(10, 22);
            this.radTextBoxControl1.Multiline = true;
            this.radTextBoxControl1.Name = "radTextBoxControl1";
            this.radTextBoxControl1.Size = new System.Drawing.Size(637, 146);
            this.radTextBoxControl1.TabIndex = 0;
            this.radTextBoxControl1.Text = "The quick brown fox jamped voer the lazee dog";
            this.radTextBoxControl1.ThemeName = "TelerikMetro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96, 96);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(675, 741);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadSpellChecker";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private Telerik.WinControls.UI.RadSpellChecker radSpellChecker1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadSpellChecker radSpellChecker2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox3;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl1;
        private Telerik.WinControls.UI.RadSpellChecker radSpellChecker3;
    }
}

