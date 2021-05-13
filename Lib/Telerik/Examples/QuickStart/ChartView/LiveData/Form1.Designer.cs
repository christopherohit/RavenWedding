//using Telerik.Examples.WinControls.ChartView.FirstLook;
using System.Windows.Forms;
namespace Telerik.Examples.WinControls.ChartView.LiveData
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.exampleCustomShapeControl4 = new Telerik.Examples.WinControls.ChartView.LiveData.ExampleCustomShapeControl();
            this.radChartView2 = new Telerik.WinControls.UI.RadChartView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.exampleCustomShapeControl1 = new Telerik.Examples.WinControls.ChartView.LiveData.ExampleCustomShapeControl();
            this.exampleCustomShapeControl2 = new Telerik.Examples.WinControls.ChartView.LiveData.ExampleCustomShapeControl();
            this.exampleCustomShapeControl3 = new Telerik.Examples.WinControls.ChartView.LiveData.ExampleCustomShapeControl();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            this.radChartView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleCustomShapeControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleCustomShapeControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleCustomShapeControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleCustomShapeControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 19);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radRadioButton2);
            this.settingsPanel.PanelContainer.Controls.Add(this.radRadioButton1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(164, 360);
            this.settingsPanel.Size = new System.Drawing.Size(164, 360);
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            this.radChartView1.Controls.Add(this.exampleCustomShapeControl4);
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.Name = "radChartView1";
            // 
            // 
            // 
            this.radChartView1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radChartView1.ShowGrid = false;
            this.radChartView1.ShowTitle = true;
            this.radChartView1.Size = new System.Drawing.Size(1217, 552);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.Title = "Messages Sent/Received";
            // 
            // exampleCustomShapeControl4
            // 
            this.exampleCustomShapeControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exampleCustomShapeControl4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleCustomShapeControl4.LeftText = "...";
            this.exampleCustomShapeControl4.Location = new System.Drawing.Point(557, 49);
            this.exampleCustomShapeControl4.Name = "exampleCustomShapeControl4";
            this.exampleCustomShapeControl4.RightText = "  FPS";
            this.exampleCustomShapeControl4.Size = new System.Drawing.Size(144, 45);
            this.exampleCustomShapeControl4.TabIndex = 0;
            this.exampleCustomShapeControl4.Text = "exampleCustomShapeControl1";
            ((Telerik.WinControls.UI.LightVisualElement)(this.exampleCustomShapeControl4.GetChildAt(0).GetChildAt(1))).Text = "  FPS";
            ((Telerik.WinControls.UI.LightVisualElement)(this.exampleCustomShapeControl4.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            // 
            // radChartView2
            // 
            this.radChartView2.AreaDesign = cartesianArea2;
            this.radChartView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChartView2.Location = new System.Drawing.Point(0, 0);
            this.radChartView2.Name = "radChartView2";
            this.radChartView2.ShowGrid = false;
            this.radChartView2.ShowTitle = true;
            this.radChartView2.Size = new System.Drawing.Size(938, 234);
            this.radChartView2.TabIndex = 2;
            this.radChartView2.Title = "Site Activity by Time of Day";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radChartView1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1217, 552);
            this.radPanel1.TabIndex = 3;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radPanel4);
            this.radPanel2.Controls.Add(this.radPanel3);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel2.Location = new System.Drawing.Point(0, 552);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1217, 234);
            this.radPanel2.TabIndex = 4;
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.radChartView2);
            this.radPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel4.Location = new System.Drawing.Point(0, 0);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(938, 234);
            this.radPanel4.TabIndex = 1;
            // 
            // radPanel3
            // 
            this.radPanel3.BackColor = System.Drawing.Color.White;
            this.radPanel3.Controls.Add(this.exampleCustomShapeControl1);
            this.radPanel3.Controls.Add(this.exampleCustomShapeControl2);
            this.radPanel3.Controls.Add(this.exampleCustomShapeControl3);
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel3.Location = new System.Drawing.Point(938, 0);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(279, 234);
            this.radPanel3.TabIndex = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            // 
            // exampleCustomShapeControl1
            // 
            this.exampleCustomShapeControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.exampleCustomShapeControl1.LeftText = "1,200";
            this.exampleCustomShapeControl1.Location = new System.Drawing.Point(90, 45);
            this.exampleCustomShapeControl1.Name = "exampleCustomShapeControl1";
            this.exampleCustomShapeControl1.RightText = "AVG Messages per second";
            this.exampleCustomShapeControl1.Size = new System.Drawing.Size(190, 45);
            this.exampleCustomShapeControl1.TabIndex = 0;
            this.exampleCustomShapeControl1.Text = "exampleCustomShapeControl1";
            // 
            // exampleCustomShapeControl2
            // 
            this.exampleCustomShapeControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.exampleCustomShapeControl2.LeftText = "53,210";
            this.exampleCustomShapeControl2.Location = new System.Drawing.Point(65, 100);
            this.exampleCustomShapeControl2.Name = "exampleCustomShapeControl2";
            this.exampleCustomShapeControl2.RightText = "AVG Messages per minute";
            this.exampleCustomShapeControl2.Size = new System.Drawing.Size(215, 45);
            this.exampleCustomShapeControl2.TabIndex = 0;
            this.exampleCustomShapeControl2.Text = "exampleCustomShapeControl2";
            // 
            // exampleCustomShapeControl3
            // 
            this.exampleCustomShapeControl3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.exampleCustomShapeControl3.LeftText = "3,729,600";
            this.exampleCustomShapeControl3.Location = new System.Drawing.Point(40, 155);
            this.exampleCustomShapeControl3.Name = "exampleCustomShapeControl3";
            this.exampleCustomShapeControl3.RightText = "AVG Messages per hour";
            this.exampleCustomShapeControl3.Size = new System.Drawing.Size(240, 45);
            this.exampleCustomShapeControl3.TabIndex = 0;
            this.exampleCustomShapeControl3.Text = "exampleCustomShapeControl3";
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton1.Location = new System.Drawing.Point(5, 33);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(73, 18);
            this.radRadioButton1.TabIndex = 1;
            this.radRadioButton1.TabStop = false;
            this.radRadioButton1.Text = "Line Series";
            this.radRadioButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radRadioButton2.Location = new System.Drawing.Point(5, 57);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(96, 18);
            this.radRadioButton2.TabIndex = 1;
            this.radRadioButton2.Text = "Fast Line Series";
            this.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButton2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton2_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(600, 240);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radPanel2);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1227, 796);
            this.Controls.SetChildIndex(this.radPanel2, 0);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            this.radChartView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exampleCustomShapeControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exampleCustomShapeControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleCustomShapeControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleCustomShapeControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadChartView radChartView2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private ExampleCustomShapeControl exampleCustomShapeControl1;
        private ExampleCustomShapeControl exampleCustomShapeControl2;
        private ExampleCustomShapeControl exampleCustomShapeControl3;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        private ExampleCustomShapeControl exampleCustomShapeControl4;
    }
}