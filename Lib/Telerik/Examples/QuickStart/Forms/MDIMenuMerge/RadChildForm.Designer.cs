namespace Telerik.Examples.WinControls.Forms.MDIMenuMerge
{
    partial class RadChildForm
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
            this.radStatusBar1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.CommandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelElement3 = new Telerik.WinControls.UI.RadLabelElement();
            this.CommandBarSeparator4 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelElement2 = new Telerik.WinControls.UI.RadLabelElement();
            this.radProgressBarElement1 = new Telerik.WinControls.UI.RadProgressBarElement();
            this.CommandBarSeparator5 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radCheckBoxElement1 = new Telerik.WinControls.UI.RadCheckBoxElement();
            this.CommandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.CommandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusBar1
            // 
            this.radStatusBar1.AutoSize = true;
            this.radStatusBar1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.CommandBarSeparator3,
            this.radLabelElement3,
            this.CommandBarSeparator4,
            this.radLabelElement2,
            this.radProgressBarElement1,
            this.CommandBarSeparator5,
            this.radCheckBoxElement1,
            this.CommandBarSeparator1,
            this.radLabelElement1,
            this.CommandBarSeparator2});
            this.radStatusBar1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusBar1.Location = new System.Drawing.Point(0, 317);
            this.radStatusBar1.Margin = new System.Windows.Forms.Padding(5);
            this.radStatusBar1.Name = "radStatusBar1";
            this.radStatusBar1.Size = new System.Drawing.Size(567, 25);
            this.radStatusBar1.SizingGrip = true;
            this.radStatusBar1.TabIndex = 0;
            this.radStatusBar1.Text = "radStatusBar1";
            ((Telerik.WinControls.UI.RadStatusBarElement)(this.radStatusBar1.GetChildAt(0))).Text = "radStatusBar1";
            ((Telerik.WinControls.UI.RadStatusBarElement)(this.radStatusBar1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(2);
            ((Telerik.WinControls.UI.RadStatusBarElement)(this.radStatusBar1.GetChildAt(0))).MinSize = new System.Drawing.Size(0, 19);
            ((Telerik.WinControls.UI.StatusBarBoxLayout)(this.radStatusBar1.GetChildAt(0).GetChildAt(3))).Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.CanFocus = true;
            this.radButtonElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radButtonElement1.Name = "radButtonElement1";
            this.radStatusBar1.SetSpring(this.radButtonElement1, false);
            this.radButtonElement1.Text = "Page 1 of 1";
    
            // 
            // CommandBarSeparator3
            // 
            this.CommandBarSeparator3.Margin = new System.Windows.Forms.Padding(1);
            this.CommandBarSeparator3.MinSize = new System.Drawing.Size(2, 17);
            this.CommandBarSeparator3.Name = "CommandBarSeparator3";
            this.radStatusBar1.SetSpring(this.CommandBarSeparator3, false);
            this.CommandBarSeparator3.Text = "CommandBarSeparator3";
            // 
            // radLabelElement3
            // 
            this.radLabelElement3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.radLabelElement3.Margin = new System.Windows.Forms.Padding(1);
            this.radLabelElement3.Name = "radLabelElement3";
            this.radStatusBar1.SetSpring(this.radLabelElement3, false);
            this.radLabelElement3.Text = "Words: 2";
            // 
            // CommandBarSeparator4
            // 
            this.CommandBarSeparator4.Margin = new System.Windows.Forms.Padding(1);
            this.CommandBarSeparator4.MinSize = new System.Drawing.Size(2, 17);
            this.CommandBarSeparator4.Name = "CommandBarSeparator4";
            this.radStatusBar1.SetSpring(this.CommandBarSeparator4, false);
            this.CommandBarSeparator4.Text = "CommandBarSeparator4";
            // 
            // radLabelElement2
            // 
            this.radLabelElement2.Margin = new System.Windows.Forms.Padding(1);
            this.radLabelElement2.Name = "radLabelElement2";
            this.radStatusBar1.SetSpring(this.radLabelElement2, false);
            this.radLabelElement2.Text = "Saving...";
            // 
            // radProgressBarElement1
            // 
          
            this.radProgressBarElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.radProgressBarElement1.Bounds = new System.Drawing.Rectangle(0, 0, 80, 16);
            this.radProgressBarElement1.ClipDrawing = true;
            this.radProgressBarElement1.DefaultSize = new System.Drawing.Size(80, 16);
            this.radProgressBarElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radProgressBarElement1.Name = "radProgressBarElement1";
            this.radStatusBar1.SetSpring(this.radProgressBarElement1, false);
            this.radProgressBarElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommandBarSeparator5
            // 
            this.CommandBarSeparator5.Margin = new System.Windows.Forms.Padding(1);
            this.CommandBarSeparator5.MinSize = new System.Drawing.Size(2, 17);
            this.CommandBarSeparator5.Name = "CommandBarSeparator5";
            this.radStatusBar1.SetSpring(this.CommandBarSeparator5, false);
            this.CommandBarSeparator5.Text = "CommandBarSeparator5";
            // 
            // radCheckBoxElement1
            // 
            this.radCheckBoxElement1.CanFocus = true;
            this.radCheckBoxElement1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            this.radCheckBoxElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radCheckBoxElement1.Name = "radCheckBoxElement1";
            this.radCheckBoxElement1.ShowBorder = false;
            this.radStatusBar1.SetSpring(this.radCheckBoxElement1, false);
            this.radCheckBoxElement1.Text = "Check for errors";
            // 
            // CommandBarSeparator1
            // 
            this.CommandBarSeparator1.Margin = new System.Windows.Forms.Padding(1);
            this.CommandBarSeparator1.MinSize = new System.Drawing.Size(2, 17);
            this.CommandBarSeparator1.Name = "CommandBarSeparator1";
            this.radStatusBar1.SetSpring(this.CommandBarSeparator1, false);
            this.CommandBarSeparator1.Text = "CommandBarSeparator1";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusBar1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "English (US)";
            // 
            // CommandBarSeparator2
            // 
            this.CommandBarSeparator2.Margin = new System.Windows.Forms.Padding(1);
            this.CommandBarSeparator2.MinSize = new System.Drawing.Size(2, 17);
            this.CommandBarSeparator2.Name = "CommandBarSeparator2";
            this.radStatusBar1.SetSpring(this.CommandBarSeparator2, false);
            this.CommandBarSeparator2.Text = "CommandBarSeparator2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
        
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(567, 27);
            this.radMenu1.TabIndex = 1;
            this.radMenu1.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem3});
            this.radMenuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "File";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Print";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Tools";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTextBox1.Location = new System.Drawing.Point(0, 27);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            // 
            // 
            // 
            this.radTextBox1.RootElement.StretchVertically = true;
            this.radTextBox1.Size = new System.Drawing.Size(567, 290);
            this.radTextBox1.TabIndex = 2;
            // 
            // RadChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(567, 342);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radStatusBar1);
            this.Name = "RadChildForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MinSize = new System.Drawing.Size(150, 36);
            this.Text = "RadChildForm";
            ((System.ComponentModel.ISupportInitialize)(this.radStatusBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip radStatusBar1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadProgressBarElement radProgressBarElement1;
        private Telerik.WinControls.UI.CommandBarSeparator CommandBarSeparator2;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.CommandBarSeparator CommandBarSeparator5;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement2;
        private Telerik.WinControls.UI.CommandBarSeparator CommandBarSeparator3;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement3;
        private Telerik.WinControls.UI.CommandBarSeparator CommandBarSeparator4;
        private Telerik.WinControls.UI.RadCheckBoxElement radCheckBoxElement1;
        private Telerik.WinControls.UI.CommandBarSeparator CommandBarSeparator1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
    }
}