using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.Globalization.Localization
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
            TreeViewLocalizationProvider.CurrentProvider = oldProvider;
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
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radGroupBoxEnglish = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButtonGerman = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonEnglish = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxEnglish)).BeginInit();
            this.radGroupBoxEnglish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonGerman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonEnglish)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBoxEnglish);
            this.settingsPanel.Location = new System.Drawing.Point(814, 1);
            this.settingsPanel.Size = new System.Drawing.Size(952, 1202);
  
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxEnglish, 0);
            // 
            // radTreeView1
            // 
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radTreeView1.ItemHeight = 27;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(246, 752);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            // 
            // radGroupBoxEnglish
            // 
            this.radGroupBoxEnglish.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxEnglish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxEnglish.Controls.Add(this.radRadioButtonGerman);
            this.radGroupBoxEnglish.Controls.Add(this.radRadioButtonEnglish);
            this.radGroupBoxEnglish.HeaderText = "Choose language:";
            this.radGroupBoxEnglish.Location = new System.Drawing.Point(10, 37);
            this.radGroupBoxEnglish.Name = "radGroupBoxEnglish";
            this.radGroupBoxEnglish.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBoxEnglish.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBoxEnglish.Size = new System.Drawing.Size(932, 96);
            this.radGroupBoxEnglish.TabIndex = 1;
            this.radGroupBoxEnglish.Text = "Choose language:";
            // 
            // radRadioButtonGerman
            // 
            this.radRadioButtonGerman.Location = new System.Drawing.Point(13, 65);
            this.radRadioButtonGerman.Name = "radRadioButtonGerman";
            this.radRadioButtonGerman.Size = new System.Drawing.Size(60, 18);
            this.radRadioButtonGerman.TabIndex = 1;
            this.radRadioButtonGerman.TabStop = true;
            this.radRadioButtonGerman.Text = "German";
            this.radRadioButtonGerman.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
          
            // 
            // radRadioButtonEnglish
            // 
            this.radRadioButtonEnglish.Location = new System.Drawing.Point(13, 41);
            this.radRadioButtonEnglish.Name = "radRadioButtonEnglish";
            this.radRadioButtonEnglish.Size = new System.Drawing.Size(56, 18);
            this.radRadioButtonEnglish.TabIndex = 0;
            this.radRadioButtonEnglish.Text = "English";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radTreeView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1028, 762);
            this.Controls.SetChildIndex(this.radTreeView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxEnglish)).EndInit();
            this.radGroupBoxEnglish.ResumeLayout(false);
            this.radGroupBoxEnglish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonGerman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonEnglish)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxEnglish;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonGerman;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonEnglish;
	}
}