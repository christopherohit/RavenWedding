namespace Telerik.Examples.WinControls.Forms.TabbedForm.FirstLook
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
            this.radTabbedFormControl1 = new Telerik.WinControls.UI.RadTabbedFormControl();
            this.radTabbedFormControlTab1 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.radTabbedFormControlTab2 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.radTabbedFormControlTab3 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radToggleButtonElement1 = new Telerik.WinControls.UI.RadToggleButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).BeginInit();
            this.radTabbedFormControl1.SuspendLayout();
            this.radTabbedFormControlTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTabbedFormControl1
            // 
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab1);
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab2);
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab3);
            this.radTabbedFormControl1.LeftItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radToggleButtonElement1});
            this.radTabbedFormControl1.Location = new System.Drawing.Point(0, 0);
            this.radTabbedFormControl1.Name = "radTabbedFormControl1";
            this.radTabbedFormControl1.SelectedTab = this.radTabbedFormControlTab1;
            this.radTabbedFormControl1.Size = new System.Drawing.Size(1592, 1044);
            this.radTabbedFormControl1.TabIndex = 0;
            this.radTabbedFormControl1.Text = "RadTabbedForm";
            this.radTabbedFormControl1.TabAdded += new System.EventHandler<Telerik.WinControls.UI.RadTabbedFormControlEventArgs>(this.radTabbedFormControl1_TabAdded);
            this.radTabbedFormControl1.SelectedTabChanged += new System.EventHandler(this.radTabbedFormControl1_SelectedTabChanged);
            //
            // radTabbedFormControlTab1
            // 
            this.radTabbedFormControlTab1.Location = new System.Drawing.Point(1, 31);
            this.radTabbedFormControlTab1.Name = "radTabbedFormControlTab1";
            this.radTabbedFormControlTab1.Size = new System.Drawing.Size(1590, 1012);
            this.radTabbedFormControlTab1.Text = "Google";
            // 
            // radTabbedFormControlTab2
            // 
            this.radTabbedFormControlTab2.Location = new System.Drawing.Point(1, 31);
            this.radTabbedFormControlTab2.Name = "radTabbedFormControlTab2";
            this.radTabbedFormControlTab2.Size = new System.Drawing.Size(1590, 1012);
            this.radTabbedFormControlTab2.Text = "Tab 2";
            // 
            // radTabbedFormControlTab3
            // 
            this.radTabbedFormControlTab3.Location = new System.Drawing.Point(1, 31);
            this.radTabbedFormControlTab3.Name = "radTabbedFormControlTab3";
            this.radTabbedFormControlTab3.Size = new System.Drawing.Size(1590, 1012);
            this.radTabbedFormControlTab3.Text = "Tab 3";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Enabled = true;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.StretchHorizontally = false;
            this.radButtonElement1.StretchVertically = false;
            this.radButtonElement1.Text = "Btn";
            // 
            // radToggleButtonElement1
            // 
            this.radToggleButtonElement1.Enabled = true;
            this.radToggleButtonElement1.Name = "radToggleButtonElement1";
            this.radToggleButtonElement1.ReadOnly = false;
            this.radToggleButtonElement1.Text = "RadForm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.radTabbedFormControl1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "RadTabbedForm";
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).EndInit();
            this.radTabbedFormControl1.ResumeLayout(false);
            this.radTabbedFormControlTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTabbedFormControl radTabbedFormControl1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab2;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadToggleButtonElement radToggleButtonElement1;
    }
}