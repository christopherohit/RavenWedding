using Telerik.WinControls.UI;
namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.DropDownAnimation
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components != null)
                {
                    this.components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem8 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem9 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem10 = new Telerik.WinControls.UI.RadListDataItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radComboDemo = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupAnimSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radSpinFrames = new Telerik.WinControls.UI.RadSpinEditor();
            this.radCheckEnableAnim = new Telerik.WinControls.UI.RadCheckBox();
            this.radComboAnimType = new Telerik.WinControls.UI.RadDropDownList();
            this.radLblFrames = new Telerik.WinControls.UI.RadLabel();
            this.radLblDropDownAnim = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupAnimSettings)).BeginInit();
            this.radGroupAnimSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckEnableAnim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboAnimType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblDropDownAnim)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radComboDemo);
            this.radPanelDemoHolder.MaximumSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.MinimumSize = new System.Drawing.Size(362, 100);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.MaxSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.RootElement.MinSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.Size = new System.Drawing.Size(362, 100);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupAnimSettings);
            this.settingsPanel.Location = new System.Drawing.Point(973, 1);
            this.settingsPanel.Size = new System.Drawing.Size(250, 534);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupAnimSettings, 0);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "WizardPicture.bmp");
            this.imageList1.Images.SetKeyName(1, "bulb_on.GIF");
            this.imageList1.Images.SetKeyName(2, "CLSDFOLD.BMP");
            this.imageList1.Images.SetKeyName(3, "test.bmp");
            this.imageList1.Images.SetKeyName(4, "untitled.bmp");
            // 
            // radComboDemo
            // 
            this.radComboDemo.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboDemo.ImageList = this.imageList1;
            radListDataItem1.Text = "Amsterdam";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Barcelona";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Bonn";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "Brussels";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "New York";
            radListDataItem5.TextWrap = true;
            radListDataItem6.Text = "London";
            radListDataItem6.TextWrap = true;
            radListDataItem7.Text = "Paris";
            radListDataItem7.TextWrap = true;
            radListDataItem8.Text = "Sofia";
            radListDataItem8.TextWrap = true;
            radListDataItem9.Text = "Prague";
            radListDataItem9.TextWrap = true;
            radListDataItem10.Text = "Hamburg";
            radListDataItem10.TextWrap = true;
            this.radComboDemo.Items.Add(radListDataItem1);
            this.radComboDemo.Items.Add(radListDataItem2);
            this.radComboDemo.Items.Add(radListDataItem3);
            this.radComboDemo.Items.Add(radListDataItem4);
            this.radComboDemo.Items.Add(radListDataItem5);
            this.radComboDemo.Items.Add(radListDataItem6);
            this.radComboDemo.Items.Add(radListDataItem7);
            this.radComboDemo.Items.Add(radListDataItem8);
            this.radComboDemo.Items.Add(radListDataItem9);
            this.radComboDemo.Items.Add(radListDataItem10);
            this.radComboDemo.Location = new System.Drawing.Point(20, 20);
            this.radComboDemo.Name = "radComboDemo";
            this.radComboDemo.NullText = "Choose City...";
            // 
            // 
            // 
            this.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboDemo.Size = new System.Drawing.Size(306, 20);
            this.radComboDemo.TabIndex = 0;
            // 
            // radGroupAnimSettings
            // 
            this.radGroupAnimSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupAnimSettings.Controls.Add(this.radSpinFrames);
            this.radGroupAnimSettings.Controls.Add(this.radCheckEnableAnim);
            this.radGroupAnimSettings.Controls.Add(this.radComboAnimType);
            this.radGroupAnimSettings.Controls.Add(this.radLblFrames);
            this.radGroupAnimSettings.Controls.Add(this.radLblDropDownAnim);
            this.radGroupAnimSettings.FooterText = "";
            this.radGroupAnimSettings.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupAnimSettings.HeaderText = " Animation settings ";
            this.radGroupAnimSettings.Location = new System.Drawing.Point(15, 6);
            this.radGroupAnimSettings.Name = "radGroupAnimSettings";
            // 
            // 
            // 
            this.radGroupAnimSettings.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupAnimSettings.Size = new System.Drawing.Size(162, 156);
            this.radGroupAnimSettings.TabIndex = 0;
            this.radGroupAnimSettings.Text = " Animation settings ";
            // 
            // radSpinFrames
            // 
            this.radSpinFrames.Location = new System.Drawing.Point(64, 119);
            this.radSpinFrames.Name = "radSpinFrames";
            // 
            // 
            // 
            this.radSpinFrames.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinFrames.Size = new System.Drawing.Size(80, 20);
            this.radSpinFrames.TabIndex = 3;
            this.radSpinFrames.TabStop = false;
            this.radSpinFrames.Tag = "Right";
            // 
            // radCheckEnableAnim
            // 
            this.radCheckEnableAnim.Location = new System.Drawing.Point(12, 39);
            this.radCheckEnableAnim.Name = "radCheckEnableAnim";
            this.radCheckEnableAnim.Size = new System.Drawing.Size(108, 18);
            this.radCheckEnableAnim.TabIndex = 2;
            this.radCheckEnableAnim.Text = "Enable Animation";
            // 
            // radComboAnimType
            // 
            this.radComboAnimType.Location = new System.Drawing.Point(12, 90);
            this.radComboAnimType.Name = "radComboAnimType";
            // 
            // 
            // 
            this.radComboAnimType.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboAnimType.Size = new System.Drawing.Size(132, 20);
            this.radComboAnimType.TabIndex = 1;
            this.radComboAnimType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radLblFrames
            // 
            this.radLblFrames.Location = new System.Drawing.Point(12, 121);
            this.radLblFrames.Name = "radLblFrames";
            this.radLblFrames.Size = new System.Drawing.Size(44, 18);
            this.radLblFrames.TabIndex = 0;
            this.radLblFrames.Text = "Frames:";
            // 
            // radLblDropDownAnim
            // 
            this.radLblDropDownAnim.Location = new System.Drawing.Point(12, 66);
            this.radLblDropDownAnim.Name = "radLblDropDownAnim";
            this.radLblDropDownAnim.Size = new System.Drawing.Size(85, 18);
            this.radLblDropDownAnim.TabIndex = 0;
            this.radLblDropDownAnim.Text = "Animation type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1142, 516);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupAnimSettings)).EndInit();
            this.radGroupAnimSettings.ResumeLayout(false);
            this.radGroupAnimSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckEnableAnim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboAnimType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblDropDownAnim)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList imageList1;
		private Telerik.WinControls.UI.RadDropDownList radComboDemo;
        private Telerik.WinControls.UI.RadGroupBox radGroupAnimSettings;
        private Telerik.WinControls.UI.RadLabel radLblDropDownAnim;
        private Telerik.WinControls.UI.RadDropDownList radComboAnimType;
        private Telerik.WinControls.UI.RadSpinEditor radSpinFrames;
        private Telerik.WinControls.UI.RadCheckBox radCheckEnableAnim;
        private Telerik.WinControls.UI.RadLabel radLblFrames;
	}
}