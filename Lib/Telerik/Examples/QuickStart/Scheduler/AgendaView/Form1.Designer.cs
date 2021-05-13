using System.Drawing;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.Scheduler.AgendaView
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
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("All Categories");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem2 = new Telerik.WinControls.UI.ListViewDataItem("Important");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem3 = new Telerik.WinControls.UI.ListViewDataItem("Business");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem4 = new Telerik.WinControls.UI.ListViewDataItem("Personal");
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            this.leftSettingsPanel = new Telerik.WinControls.UI.RadScrollablePanel();
            this.noGroupRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.groupRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.resourceToggleButton3 = new Telerik.WinControls.UI.RadToggleButton();
            this.resourceToggleButton2 = new Telerik.WinControls.UI.RadToggleButton();
            this.resourceToggleButton1 = new Telerik.WinControls.UI.RadToggleButton();
            this.speakersLabel = new Telerik.WinControls.UI.RadLabel();
            this.radCheckedListBox1 = new Telerik.WinControls.UI.RadCheckedListBox();
            this.backgroundsLabel = new Telerik.WinControls.UI.RadLabel();
            this.daysCountSpinEditor = new Telerik.WinControls.UI.RadSpinEditor();
            this.daysCountLabel = new Telerik.WinControls.UI.RadLabel();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.startDateLabel = new Telerik.WinControls.UI.RadLabel();
            this.leftPanelHeaderLabel = new Telerik.WinControls.UI.RadLabel();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            ((System.ComponentModel.ISupportInitialize)(this.leftSettingsPanel)).BeginInit();
            this.leftSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noGroupRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceToggleButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceToggleButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceToggleButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakersLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCountSpinEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCountLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanelHeaderLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftSettingsPanel
            // 
            this.leftSettingsPanel.Controls.Add(this.noGroupRadioButton);
            this.leftSettingsPanel.Controls.Add(this.groupRadioButton);
            this.leftSettingsPanel.Controls.Add(this.radLabel2);
            this.leftSettingsPanel.Controls.Add(this.resourceToggleButton3);
            this.leftSettingsPanel.Controls.Add(this.resourceToggleButton2);
            this.leftSettingsPanel.Controls.Add(this.resourceToggleButton1);
            this.leftSettingsPanel.Controls.Add(this.speakersLabel);
            this.leftSettingsPanel.Controls.Add(this.radCheckedListBox1);
            this.leftSettingsPanel.Controls.Add(this.backgroundsLabel);
            this.leftSettingsPanel.Controls.Add(this.daysCountSpinEditor);
            this.leftSettingsPanel.Controls.Add(this.daysCountLabel);
            this.leftSettingsPanel.Controls.Add(this.radCalendar1);
            this.leftSettingsPanel.Controls.Add(this.radLabel1);
            this.leftSettingsPanel.Controls.Add(this.startDateLabel);
            this.leftSettingsPanel.Controls.Add(this.leftPanelHeaderLabel);
            this.leftSettingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.leftSettingsPanel.Name = "leftSettingsPanel";
            this.leftSettingsPanel.Size = new System.Drawing.Size(278, 836);
            this.leftSettingsPanel.TabIndex = 0;
            // 
            // noGroupRadioButton
            // 
            this.noGroupRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.noGroupRadioButton.Location = new System.Drawing.Point(0, 729);
            this.noGroupRadioButton.Name = "noGroupRadioButton";
            this.noGroupRadioButton.Size = new System.Drawing.Size(70, 20);
            this.noGroupRadioButton.MinimumSize = new Size(180, 28);
            this.noGroupRadioButton.TabIndex = 14;
            this.noGroupRadioButton.Text = "No Group";
            // 
            // groupRadioButton
            // 
            this.groupRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupRadioButton.Location = new System.Drawing.Point(0, 711);
            this.groupRadioButton.Name = "groupRadioButton";
            this.groupRadioButton.Size = new System.Drawing.Size(93, 20);
            this.groupRadioButton.MinimumSize = new Size(180, 28);
            this.groupRadioButton.TabIndex = 13;
            this.groupRadioButton.Text = "Group by Date";
            // 
            // radLabel2
            // 
            this.radLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radLabel2.Location = new System.Drawing.Point(0, 693);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(72, 18);

            this.radLabel2.TabIndex = 17;
            this.radLabel2.Text = "Agenda View";

            // 
            // resourceToggleButton3
            // 
            this.resourceToggleButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.resourceToggleButton3.Image = Properties.Resources.bob45x45;
            this.resourceToggleButton3.Location = new System.Drawing.Point(0, 624);
            this.resourceToggleButton3.Name = "resourceToggleButton3";
            this.resourceToggleButton3.Size = new System.Drawing.Size(231, 65);
            this.resourceToggleButton3.TabIndex = 10;
            this.resourceToggleButton3.Text = "Robert King";
            this.resourceToggleButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.resourceToggleButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton3.GetChildAt(0))).Image = Properties.Resources.bob45x45;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton3.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton3.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton3.GetChildAt(0))).Text = "Robert King";
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton3.GetChildAt(0))).Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            // 
            // resourceToggleButton2
            // 
            this.resourceToggleButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.resourceToggleButton2.Image = Properties.Resources.andrew45x45;
            this.resourceToggleButton2.Location = new System.Drawing.Point(0, 559);
            this.resourceToggleButton2.Name = "resourceToggleButton2";
            this.resourceToggleButton2.Size = new System.Drawing.Size(231, 65);
            this.resourceToggleButton2.TabIndex = 9;
            this.resourceToggleButton2.Text = "Andrew Fuller";
            this.resourceToggleButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.resourceToggleButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton2.GetChildAt(0))).Image = Properties.Resources.andrew45x45;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton2.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton2.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton2.GetChildAt(0))).Text = "Andrew Fuller";
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton2.GetChildAt(0))).Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            // 
            // resourceToggleButton1
            // 
            this.resourceToggleButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.resourceToggleButton1.Image = Properties.Resources.nancy45x45;
            this.resourceToggleButton1.Location = new System.Drawing.Point(0, 494);
            this.resourceToggleButton1.Name = "resourceToggleButton1";
            this.resourceToggleButton1.Size = new System.Drawing.Size(231, 65);
            this.resourceToggleButton1.TabIndex = 8;
            this.resourceToggleButton1.Text = "Nancy Davolio";
            this.resourceToggleButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.resourceToggleButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton1.GetChildAt(0))).Image = Properties.Resources.nancy45x45;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton1.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton1.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton1.GetChildAt(0))).Text = "Nancy Davolio";
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.resourceToggleButton1.GetChildAt(0))).Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            // 
            // speakersLabel
            // 
            this.speakersLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.speakersLabel.Location = new System.Drawing.Point(0, 476);
            this.speakersLabel.Name = "speakersLabel";
            this.speakersLabel.Size = new System.Drawing.Size(111, 18);
            this.speakersLabel.TabIndex = 7;
            this.speakersLabel.Text = "Conference Speakers";
            // 
            // radCheckedListBox1
            // 
            this.radCheckedListBox1.Dock = System.Windows.Forms.DockStyle.Top;
            listViewDataItem1.Text = "All Categories";
            listViewDataItem1.Tag = 0;
            listViewDataItem2.Text = "Important";
            listViewDataItem2.Tag = 2;
            listViewDataItem3.Text = "Business";
            listViewDataItem3.Tag = 3;
            listViewDataItem4.Text = "Personal";
            listViewDataItem4.Tag = 4;
            this.radCheckedListBox1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[]
            {
                listViewDataItem1,
                listViewDataItem2,
                listViewDataItem3,
                listViewDataItem4
            });
            this.radCheckedListBox1.Location = new System.Drawing.Point(0, 336);
            this.radCheckedListBox1.Name = "radCheckedListBox1";
            this.radCheckedListBox1.Size = new System.Drawing.Size(231, 140);
            this.radCheckedListBox1.TabIndex = 5;
            // 
            // backgroundsLabel
            // 
            this.backgroundsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.backgroundsLabel.Location = new System.Drawing.Point(0, 318);
            this.backgroundsLabel.Name = "backgroundsLabel";
            this.backgroundsLabel.Size = new System.Drawing.Size(74, 18);
            this.backgroundsLabel.TabIndex = 16;
            this.backgroundsLabel.Text = "All categories";
            // 
            // daysCountSpinEditor
            // 
            this.daysCountSpinEditor.AutoSize = false;
            this.daysCountSpinEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.daysCountSpinEditor.Location = new System.Drawing.Point(0, 298);
            this.daysCountSpinEditor.Name = "daysCountSpinEditor";
            this.daysCountSpinEditor.Size = new System.Drawing.Size(231, 24);
            this.daysCountSpinEditor.TabIndex = 15;
            this.daysCountSpinEditor.TabStop = false;
            // 
            // daysCountLabel
            // 
            this.daysCountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.daysCountLabel.Location = new System.Drawing.Point(0, 280);
            this.daysCountLabel.Name = "daysCountLabel";
            this.daysCountLabel.Size = new System.Drawing.Size(66, 18);
            this.daysCountLabel.TabIndex = 4;
            this.daysCountLabel.Text = "Days Count:";
            // 
            // radCalendar1
            // 
            this.radCalendar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCalendar1.Location = new System.Drawing.Point(0, 53);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.Size = new System.Drawing.Size(231, 227);
            this.radCalendar1.TabIndex = 3;
            // 
            // radLabel1
            // 
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radLabel1.Location = new System.Drawing.Point(0, 35);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(129, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Pick your event start day";
            // 
            // startDateLabel
            // 
            this.startDateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.startDateLabel.Location = new System.Drawing.Point(0, 18);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(60, 17);
            this.startDateLabel.TabIndex = 1;
            this.startDateLabel.Text = "<html><b>Start Date:";
            // 
            // leftPanelHeaderLabel
            // 
            this.leftPanelHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftPanelHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.leftPanelHeaderLabel.Name = "leftPanelHeaderLabel";
            this.leftPanelHeaderLabel.Size = new System.Drawing.Size(150, 18);
            this.leftPanelHeaderLabel.TabIndex = 0;
            this.leftPanelHeaderLabel.Text = "2018 CONFERENCE AGENDA";
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
            this.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(231, 0);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(851, 77);
            this.radSchedulerNavigator1.TabIndex = 1;
            // 
            // radScheduler1
            // 
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.Location = new System.Drawing.Point(231, 77);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2018, 8, 19, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2018, 8, 14, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(851, 759);
            this.radScheduler1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 836);
            this.Controls.Add(this.radScheduler1);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Controls.Add(this.leftSettingsPanel);
            this.Name = "Form1";
            this.Text = "RadForm2";
            ((System.ComponentModel.ISupportInitialize)(this.leftSettingsPanel)).EndInit();
            this.leftSettingsPanel.ResumeLayout(false);
            this.leftSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noGroupRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceToggleButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceToggleButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceToggleButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakersLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCountSpinEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCountLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanelHeaderLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            AdjustFontsAndMargins();
        }

        private void AdjustFontsAndMargins()
        {
            this.leftPanelHeaderLabel.Font = defaultFontHeader;
            this.startDateLabel.Font = defaultFontBold;
            this.radLabel1.Font = defaultFont;
            this.radLabel2.Font = defaultFontBold;
            this.speakersLabel.Font = defaultFontBold;
            this.daysCountLabel.Font = defaultFontBold;
            this.backgroundsLabel.Font = defaultFontBold;

            this.resourceToggleButton1.Image = Properties.Resources.nancy45x45;
            this.resourceToggleButton1.Height = 65;
            this.resourceToggleButton1.ButtonElement.Margin = new System.Windows.Forms.Padding(12, 5, 10, 5);
            this.resourceToggleButton1.Font = defaultFont;

            this.resourceToggleButton1.ButtonElement.ImagePrimitive.Margin = new Padding(0, 0, 3, 0);
            this.resourceToggleButton2.ButtonElement.ImagePrimitive.Margin = new Padding(0, 0, 3, 0);
            this.resourceToggleButton3.ButtonElement.ImagePrimitive.Margin = new Padding(0, 0, 3, 0);

            this.resourceToggleButton2.Height = 65;
            this.resourceToggleButton2.ButtonElement.Margin = new System.Windows.Forms.Padding(12, 5, 10, 5);
            this.resourceToggleButton2.Font = defaultFont;

            this.resourceToggleButton3.Height = 65;
            this.resourceToggleButton3.ButtonElement.Margin = new System.Windows.Forms.Padding(12, 5, 10, 5);
            this.resourceToggleButton3.Font = defaultFont;
            
            this.leftPanelHeaderLabel.LabelElement.Margin = new Padding(8, 10, 0, 0);
            this.startDateLabel.LabelElement.Margin = new Padding(10, 20, 0, 0);

            this.daysCountLabel.LabelElement.Margin = new Padding(10, 10, 0,5);
            
            this.radLabel1.LabelElement.Margin = new Padding(8, 10, 0, 5);
            this.radLabel2.LabelElement.Margin = new Padding(8, 10, 0, 0);
            this.speakersLabel.LabelElement.Margin = defaultPadding;
            this.backgroundsLabel.LabelElement.Margin = defaultPadding;
            this.radCalendar1.CalendarElement.DrawBorder = false;
            this.radCalendar1.CalendarElement.Margin = new Padding(12, 0, 10, 0);

            this.radCheckedListBox1.ListViewElement.DrawBorder = false;
            this.radCheckedListBox1.ListViewElement.ViewElement.DrawBorder = false;
            this.groupRadioButton.ButtonElement.Margin = new Padding(10, 5, 0, 0);
            this.noGroupRadioButton.ButtonElement.Margin = new Padding(10, 5, 0, 0);
            this.groupRadioButton.ButtonElement.TextElement.Font = defaultFont;
            this.noGroupRadioButton.ButtonElement.TextElement.Font = defaultFont;
            this.groupRadioButton.ButtonElement.CheckMarkPrimitive.Margin = new Padding(0, 0, 8, 0);
            this.noGroupRadioButton.ButtonElement.CheckMarkPrimitive.Margin = new Padding(0, 0, 8, 0);
            this.daysCountSpinEditor.SpinElement.Margin = new Padding(12, 0, 10, 0);
            this.daysCountSpinEditor.SpinElement.TextBoxItem.Margin = new Padding(0);

            this.radCheckedListBox1.ListViewElement.ViewElement.BackColor = Color.Transparent;
        }

        #endregion

        private Telerik.WinControls.UI.RadScrollablePanel leftSettingsPanel;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadLabel leftPanelHeaderLabel;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel startDateLabel;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadLabel daysCountLabel;
        private Telerik.WinControls.UI.RadCheckedListBox radCheckedListBox1;
        private Telerik.WinControls.UI.RadToggleButton resourceToggleButton3;
        private Telerik.WinControls.UI.RadToggleButton resourceToggleButton2;
        private Telerik.WinControls.UI.RadToggleButton resourceToggleButton1;
        private Telerik.WinControls.UI.RadLabel speakersLabel;
        private Telerik.WinControls.UI.RadRadioButton noGroupRadioButton;
        private Telerik.WinControls.UI.RadRadioButton groupRadioButton;
        private Telerik.WinControls.UI.RadSpinEditor daysCountSpinEditor;
        private Telerik.WinControls.UI.RadLabel backgroundsLabel;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}