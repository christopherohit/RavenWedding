using Telerik.WinControls.UI;
namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Events
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem11 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem12 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem13 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem14 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem15 = new Telerik.WinControls.UI.RadListDataItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radComboDemo = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radComboSort = new Telerik.WinControls.UI.RadDropDownList();
            this.radCheckCase = new Telerik.WinControls.UI.RadCheckBox();
            this.radLblSort = new Telerik.WinControls.UI.RadLabel();
            this.radLblDropDownStyle = new Telerik.WinControls.UI.RadLabel();
            this.radComboDropDownStyle = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupEvents = new Telerik.WinControls.UI.RadGroupBox();
            this.radTxtEvents = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).BeginInit();
            this.radGroupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblDropDownStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDropDownStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).BeginInit();
            this.radGroupEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radComboDemo);
            this.radPanelDemoHolder.ForeColor = System.Drawing.Color.Black;
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
            this.settingsPanel.Controls.Add(this.radGroupEvents);
            this.settingsPanel.Controls.Add(this.radGroupSettings);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 486);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupSettings, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupEvents, 0);
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
            this.radComboDemo.Size = new System.Drawing.Size(306, 18);
            this.radComboDemo.TabIndex = 0;
            // 
            // radGroupSettings
            // 
            this.radGroupSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupSettings.Controls.Add(this.radComboSort);
            this.radGroupSettings.Controls.Add(this.radCheckCase);
            this.radGroupSettings.Controls.Add(this.radLblSort);
            this.radGroupSettings.Controls.Add(this.radLblDropDownStyle);
            this.radGroupSettings.Controls.Add(this.radComboDropDownStyle);
            this.radGroupSettings.FooterText = "";
            this.radGroupSettings.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupSettings.HeaderText = "Settings";
            this.radGroupSettings.Location = new System.Drawing.Point(1, 6);
            this.radGroupSettings.Name = "radGroupSettings";
            this.radGroupSettings.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupSettings.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupSettings.Size = new System.Drawing.Size(163, 160);
            this.radGroupSettings.TabIndex = 0;
            this.radGroupSettings.Text = "Settings";
            // 
            // radComboSort
            // 
            this.radComboSort.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            radListDataItem11.Text = "Ascending";
            radListDataItem11.TextWrap = true;
            radListDataItem12.Text = "Descending";
            radListDataItem12.TextWrap = true;
            radListDataItem13.Text = "None";
            radListDataItem13.TextWrap = true;
            this.radComboSort.Items.Add(radListDataItem11);
            this.radComboSort.Items.Add(radListDataItem12);
            this.radComboSort.Items.Add(radListDataItem13);
            this.radComboSort.Location = new System.Drawing.Point(18, 96);
            this.radComboSort.Name = "radComboSort";
            // 
            // 
            // 
            this.radComboSort.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboSort.Size = new System.Drawing.Size(122, 20);
            this.radComboSort.TabIndex = 1;
            this.radComboDemo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radCheckCase
            // 
            this.radCheckCase.Location = new System.Drawing.Point(18, 125);
            this.radCheckCase.Name = "radCheckCase";
            this.radCheckCase.Size = new System.Drawing.Size(89, 18);
            this.radCheckCase.TabIndex = 4;
            this.radCheckCase.Text = "Case sensitive";

            // 
            // radLblSort
            // 
            this.radLblSort.Location = new System.Drawing.Point(18, 72);
            this.radLblSort.Name = "radLblSort";
            this.radLblSort.Size = new System.Drawing.Size(76, 18);
            this.radLblSort.TabIndex = 3;
            this.radLblSort.Text = "Sort direction:";
            // 
            // radLblDropDownStyle
            // 
            this.radLblDropDownStyle.Location = new System.Drawing.Point(18, 19);
            this.radLblDropDownStyle.Name = "radLblDropDownStyle";
            this.radLblDropDownStyle.Size = new System.Drawing.Size(92, 18);
            this.radLblDropDownStyle.TabIndex = 2;
            this.radLblDropDownStyle.Text = "Drop-down style:";
            // 
            // radComboDropDownStyle
            // 
            this.radComboDropDownStyle.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            radListDataItem14.Text = "DropDown";
            radListDataItem14.TextWrap = true;
            radListDataItem15.Text = "DropDownList";
            radListDataItem15.TextWrap = true;
            this.radComboDropDownStyle.Items.Add(radListDataItem14);
            this.radComboDropDownStyle.Items.Add(radListDataItem15);
            this.radComboDropDownStyle.Location = new System.Drawing.Point(18, 43);
            this.radComboDropDownStyle.Name = "radComboDropDownStyle";
            // 
            // 
            // 
            this.radComboDropDownStyle.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboDropDownStyle.Size = new System.Drawing.Size(122, 20);
            this.radComboDropDownStyle.TabIndex = 0;
            this.radComboDropDownStyle.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radGroupEvents
            // 
            this.radGroupEvents.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupEvents.Controls.Add(this.radTxtEvents);
            this.radGroupEvents.FooterText = "";
            this.radGroupEvents.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupEvents.HeaderText = " Events ";
            this.radGroupEvents.Location = new System.Drawing.Point(1, 172);
            this.radGroupEvents.Name = "radGroupEvents";
            this.radGroupEvents.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupEvents.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupEvents.Size = new System.Drawing.Size(163, 322);
            this.radGroupEvents.TabIndex = 1;
            this.radGroupEvents.Text = " Events ";
            // 
            // radTxtEvents
            // 
            this.radTxtEvents.AutoSize = false;
            this.radTxtEvents.Location = new System.Drawing.Point(22, 26);
            this.radTxtEvents.Multiline = true;
            this.radTxtEvents.Name = "radTxtEvents";
            this.radTxtEvents.Size = new System.Drawing.Size(136, 283);
            this.radTxtEvents.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).EndInit();
            this.radGroupSettings.ResumeLayout(false);
            this.radGroupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblDropDownStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDropDownStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).EndInit();
            this.radGroupEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTxtEvents)).EndInit();
            this.ResumeLayout(false);

		}        

		#endregion

        private Telerik.WinControls.UI.RadDropDownList radComboDemo;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadGroupBox radGroupSettings;
        private Telerik.WinControls.UI.RadGroupBox radGroupEvents;
        private Telerik.WinControls.UI.RadCheckBox radCheckCase;
        private Telerik.WinControls.UI.RadLabel radLblSort;
        private Telerik.WinControls.UI.RadLabel radLblDropDownStyle;
        private Telerik.WinControls.UI.RadDropDownList radComboSort;
        private Telerik.WinControls.UI.RadDropDownList radComboDropDownStyle;
        private Telerik.WinControls.UI.RadTextBox radTxtEvents;
	}
}