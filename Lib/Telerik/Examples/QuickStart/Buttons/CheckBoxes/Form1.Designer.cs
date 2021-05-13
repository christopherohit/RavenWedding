using System.ComponentModel;
namespace Telerik.Examples.WinControls.Buttons.CheckBoxes
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
            this.radCheckBox3 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupEvents = new Telerik.WinControls.UI.RadGroupBox();
            this.radTextBoxEvents = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).BeginInit();
            this.radGroupEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radCheckBox1);
            this.radPanelDemoHolder.Controls.Add(this.radCheckBox3);
            this.radPanelDemoHolder.Controls.Add(this.radCheckBox2);
            this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(350, 235);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(800, 600);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(973, 1);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupEvents);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(250, 534);
            this.settingsPanel.Size = new System.Drawing.Size(250, 534);
            // 
            // radCheckBox3
            // 
            this.radCheckBox3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckBox3.Location = new System.Drawing.Point(310, 313);
            this.radCheckBox3.Name = "radCheckBox3";
            this.radCheckBox3.Size = new System.Drawing.Size(109, 25);
            this.radCheckBox3.TabIndex = 2;
            this.radCheckBox3.Text = "Arial, 14pt";
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckBox2.Location = new System.Drawing.Point(310, 282);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.Size = new System.Drawing.Size(96, 22);
            this.radCheckBox2.TabIndex = 1;
            this.radCheckBox2.Text = "Arial, 12pt";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radCheckBox1.Location = new System.Drawing.Point(310, 251);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(83, 19);
            this.radCheckBox1.TabIndex = 0;
            this.radCheckBox1.Text = "Arial, 10pt";
            // 
            // radGroupEvents
            // 
            this.radGroupEvents.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupEvents.Controls.Add(this.radTextBoxEvents);
            this.radGroupEvents.FooterText = "";
            this.radGroupEvents.HeaderText = " Events ";
            this.radGroupEvents.Location = new System.Drawing.Point(15, 6);
            this.radGroupEvents.Name = "radGroupEvents";
            this.radGroupEvents.Size = new System.Drawing.Size(162, 188);
            this.radGroupEvents.TabIndex = 0;
            this.radGroupEvents.Text = " Events ";
            // 
            // radTextBoxEvents
            // 
            this.radTextBoxEvents.AutoSize = false;
            this.radTextBoxEvents.Location = new System.Drawing.Point(13, 23);
            this.radTextBoxEvents.Multiline = true;
            this.radTextBoxEvents.Name = "radTextBoxEvents";
            this.radTextBoxEvents.Size = new System.Drawing.Size(138, 154);
            this.radTextBoxEvents.TabIndex = 0;
            this.radTextBoxEvents.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1831, 1148);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).EndInit();
            this.radGroupEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox3;
        private Telerik.WinControls.UI.RadGroupBox radGroupEvents;
        private Telerik.WinControls.UI.RadTextBox radTextBoxEvents;
    }
}