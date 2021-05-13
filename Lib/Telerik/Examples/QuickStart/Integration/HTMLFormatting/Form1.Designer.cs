namespace Telerik.Examples.WinControls.Integration.HTMLFormatting
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.Paint.ShadowSettings shadowSettings1 = new Telerik.WinControls.Paint.ShadowSettings();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radToggleButton1 = new Telerik.WinControls.UI.RadToggleButton();
            this.radListBox1 = new Telerik.WinControls.UI.RadListControl();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Location = new System.Drawing.Point(37, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(182, 121);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "<html><size=12>This is RadLabel <br><b><font=Arial>Arial, Bold</b><br><i><font=Ti" +
    "mes New Roman>Times, Italic <u>Underline</u><br><size=9>Size = 9<br><color= 0, 0" +
    ", 255>Sample Text   \r\n";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).Text = "<html><size=12>This is RadLabel <br><b><font=Arial>Arial, Bold</b><br><i><font=Ti" +
    "mes New Roman>Times, Italic <u>Underline</u><br><size=9>Size = 9<br><color= 0, 0" +
    ", 255>Sample Text   \r\n";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radLabel1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).TextWrap = true;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radLabel1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            shadowSettings1.Depth = new System.Drawing.Point(1, 1);
            shadowSettings1.ShadowColor = System.Drawing.Color.Gainsboro;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radLabel1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Shadow = shadowSettings1;
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Location = new System.Drawing.Point(257, 23);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(106, 17);
            this.radCheckBox1.TabIndex = 1;
            this.radCheckBox1.Text = "<html><color=green>Sample  <b><i><u><font=Times New Roman><color=128,52,52,52>Che" +
    "ckbox";
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Location = new System.Drawing.Point(257, 46);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(145, 17);
            this.radRadioButton1.TabIndex = 2;
            this.radRadioButton1.Text = "<html><color=purple>Sample  <b><i><u><color=52,52,52>RadRadioButton";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(257, 69);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(75, 23);
            this.radButton1.TabIndex = 6;
            this.radButton1.Text = "<html><i><b><color=red>rad<u><color=green>Button";
            // 
            // radToggleButton1
            // 
            this.radToggleButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radToggleButton1.Location = new System.Drawing.Point(257, 98);
            this.radToggleButton1.Name = "radToggleButton1";
            this.radToggleButton1.Size = new System.Drawing.Size(100, 23);
            this.radToggleButton1.TabIndex = 8;
            this.radToggleButton1.Text = "<html>rad<b>Toggle</b>Button";
            // 
            // radListBox1
            // 
            this.radListBox1.FormatString = "{0}";
            radListDataItem1.Text = "<html><b>radListBox<i><color=blue> Item";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "<html><i>radListBox</i><color=red> Item";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "<html><u><font=Arial>radListBox</u><b> Item";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "<html><size=+1>radListBox</b><i> Item";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "<html><color=red>radListBox<color=128,255,0,0> Item";
            radListDataItem5.TextWrap = true;
            radListDataItem6.Text = "<html><size=-3>radListBoxItem";
            radListDataItem6.TextWrap = true;
            this.radListBox1.Items.Add(radListDataItem1);
            this.radListBox1.Items.Add(radListDataItem2);
            this.radListBox1.Items.Add(radListDataItem3);
            this.radListBox1.Items.Add(radListDataItem4);
            this.radListBox1.Items.Add(radListDataItem5);
            this.radListBox1.Items.Add(radListDataItem6);
            this.radListBox1.Location = new System.Drawing.Point(431, 23);
            this.radListBox1.Name = "radListBox1";
            this.radListBox1.Size = new System.Drawing.Size(189, 98);
            this.radListBox1.TabIndex = 7;
            this.radListBox1.Text = "<html><u><font=Arial>radListBox</u><b> Item";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radCheckBox1);
            this.radPanel1.Controls.Add(this.radRadioButton1);
            this.radPanel1.Controls.Add(this.radListBox1);
            this.radPanel1.Controls.Add(this.radToggleButton1);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.ForeColor = System.Drawing.Color.Black;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(644, 168);
            this.radPanel1.TabIndex = 9;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).NumberOfColors = 4;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).GradientPercentage = 0.3F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).GradientPercentage2 = 0.01F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            // 
            // roundRectShape1
            // 
            this.roundRectShape1.Radius = 10;
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.White;
            this.radLabel2.Location = new System.Drawing.Point(4, 208);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(332, 37);
            this.radLabel2.TabIndex = 10;
            this.radLabel2.Text = "HTML Like Formatting";
            this.radLabel2.TextWrap = false;
            // 
            // radTextBox1
            // 
            this.radTextBox1.AutoSize = false;
            this.radTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(0, 243);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(644, 91);
            this.radTextBox1.TabIndex = 11;
            this.radTextBox1.TabStop = false;
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(447, 207);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(197, 30);
            this.radButton2.TabIndex = 12;
            this.radButton2.Text = "Start RadMarkupEditor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radButton2);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1308, 631);
            this.Controls.SetChildIndex(this.radButton2, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.radTextBox1, 0);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadListControl radListBox1;
        private Telerik.WinControls.UI.RadToggleButton radToggleButton1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}