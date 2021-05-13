namespace Telerik.Examples.WinControls.VirtualKeyboard.Settings
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
            this.radCheckBoxScaleFont = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxSyncWithSystem = new Telerik.WinControls.UI.RadCheckBox();
            this.radButtonSaveLayout = new Telerik.WinControls.UI.RadButton();
            this.radListControlSentKeys = new Telerik.WinControls.UI.RadListControl();
            this.radButtonClear = new Telerik.WinControls.UI.RadButton();
            this.radLabelEvents = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBoxLayout = new Telerik.WinControls.UI.RadGroupBox();
            this.radButtonLoadLayout = new Telerik.WinControls.UI.RadButton();
            this.radRadioButtonNumpad = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonSimplified = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonExtended = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonColemak = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonDvorak = new Telerik.WinControls.UI.RadRadioButton();
            this.radVirtualKeyboard1 = new Telerik.WinControls.UI.RadVirtualKeyboard();
            this.radLabelLayoutType = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownListScaleFactor = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxScaleFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxSyncWithSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSaveLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlSentKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxLayout)).BeginInit();
            this.radGroupBoxLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLoadLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonNumpad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonSimplified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonExtended)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonColemak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonDvorak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualKeyboard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelLayoutType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListScaleFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radVirtualKeyboard1);
            this.radPanelDemoHolder.Controls.Add(this.radLabelLayoutType);
            this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(80, 31);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(1030, 389);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1130, 14);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radLabel1);
            this.settingsPanel.PanelContainer.Controls.Add(this.radDropDownListScaleFactor);
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBoxLayout);
            this.settingsPanel.PanelContainer.Controls.Add(this.radLabelEvents);
            this.settingsPanel.PanelContainer.Controls.Add(this.radButtonClear);
            this.settingsPanel.PanelContainer.Controls.Add(this.radListControlSentKeys);
            this.settingsPanel.PanelContainer.Controls.Add(this.radCheckBoxSyncWithSystem);
            this.settingsPanel.PanelContainer.Controls.Add(this.radCheckBoxScaleFont);
            // 
            // optionsLabel
            // 
            this.optionsLabel.Location = new System.Drawing.Point(122, 560);
            // 
            // radCheckBoxScaleFont
            // 
            this.radCheckBoxScaleFont.IsChecked = true;
            this.radCheckBoxScaleFont.Location = new System.Drawing.Point(5, 219);
            this.radCheckBoxScaleFont.Name = "radCheckBoxScaleFont";
            this.radCheckBoxScaleFont.Size = new System.Drawing.Size(122, 18);
            this.radCheckBoxScaleFont.TabIndex = 3;
            this.radCheckBoxScaleFont.Text = "Scale Font on Resize";
            this.radCheckBoxScaleFont.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RadCheckBoxScaleFont_ToggleStateChanged);
            // 
            // radCheckBoxSyncWithSystem
            // 
            this.radCheckBoxSyncWithSystem.IsChecked = true;
            this.radCheckBoxSyncWithSystem.Location = new System.Drawing.Point(5, 269);
            this.radCheckBoxSyncWithSystem.Name = "radCheckBoxSyncWithSystem";
            this.radCheckBoxSyncWithSystem.Size = new System.Drawing.Size(167, 18);
            this.radCheckBoxSyncWithSystem.TabIndex = 4;
            this.radCheckBoxSyncWithSystem.Text = "Use system language";
            this.radCheckBoxSyncWithSystem.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RadCheckBoxSyncWithSystem_ToggleStateChanged);
            // 
            // radButtonSaveLayout
            // 
            this.radButtonSaveLayout.Location = new System.Drawing.Point(5, 145);
            this.radButtonSaveLayout.Name = "radButtonSaveLayout";
            this.radButtonSaveLayout.Size = new System.Drawing.Size(182, 24);
            this.radButtonSaveLayout.TabIndex = 5;
            this.radButtonSaveLayout.Text = "Save Layout";
            this.radButtonSaveLayout.Click += new System.EventHandler(this.RadButtonSaveLayout_Click);
            // 
            // radListControlSentKeys
            // 
            this.radListControlSentKeys.Location = new System.Drawing.Point(5, 317);
            this.radListControlSentKeys.Name = "radListControlSentKeys";
            this.radListControlSentKeys.Size = new System.Drawing.Size(192, 207);
            this.radListControlSentKeys.TabIndex = 6;
            // 
            // radButtonClear
            // 
            this.radButtonClear.Location = new System.Drawing.Point(3, 530);
            this.radButtonClear.Name = "radButtonClear";
            this.radButtonClear.Size = new System.Drawing.Size(194, 24);
            this.radButtonClear.TabIndex = 6;
            this.radButtonClear.Text = "Clear";
            this.radButtonClear.Click += new System.EventHandler(this.RadButtonClear_Click);
            // 
            // radLabelEvents
            // 
            this.radLabelEvents.Location = new System.Drawing.Point(5, 293);
            this.radLabelEvents.Name = "radLabelEvents";
            this.radLabelEvents.Size = new System.Drawing.Size(62, 18);
            this.radLabelEvents.TabIndex = 7;
            this.radLabelEvents.Text = "Key events:";
            // 
            // radGroupBoxLayout
            // 
            this.radGroupBoxLayout.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxLayout.Controls.Add(this.radButtonLoadLayout);
            this.radGroupBoxLayout.Controls.Add(this.radRadioButtonNumpad);
            this.radGroupBoxLayout.Controls.Add(this.radRadioButtonSimplified);
            this.radGroupBoxLayout.Controls.Add(this.radRadioButtonExtended);
            this.radGroupBoxLayout.Controls.Add(this.radRadioButtonColemak);
            this.radGroupBoxLayout.Controls.Add(this.radRadioButtonDvorak);
            this.radGroupBoxLayout.Controls.Add(this.radButtonSaveLayout);
            this.radGroupBoxLayout.HeaderText = "Choose Layout:";
            this.radGroupBoxLayout.Location = new System.Drawing.Point(5, 3);
            this.radGroupBoxLayout.Name = "radGroupBoxLayout";
            this.radGroupBoxLayout.Size = new System.Drawing.Size(192, 210);
            this.radGroupBoxLayout.TabIndex = 8;
            this.radGroupBoxLayout.Text = "Choose Layout:";
            // 
            // radButtonLoadLayout
            // 
            this.radButtonLoadLayout.Location = new System.Drawing.Point(5, 175);
            this.radButtonLoadLayout.Name = "radButtonLoadLayout";
            this.radButtonLoadLayout.Size = new System.Drawing.Size(182, 24);
            this.radButtonLoadLayout.TabIndex = 6;
            this.radButtonLoadLayout.Text = "Load Layout";
            this.radButtonLoadLayout.Click += new System.EventHandler(this.RadButtonLoadLayout_Click);
            // 
            // radRadioButtonNumpad
            // 
            this.radRadioButtonNumpad.Location = new System.Drawing.Point(6, 121);
            this.radRadioButtonNumpad.Name = "radRadioButtonNumpad";
            this.radRadioButtonNumpad.Size = new System.Drawing.Size(64, 18);
            this.radRadioButtonNumpad.TabIndex = 10;
            this.radRadioButtonNumpad.Text = "Numpad";
            this.radRadioButtonNumpad.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RadRadioButtonNumpad_ToggleStateChanged);
            // 
            // radRadioButtonSimplified
            // 
            this.radRadioButtonSimplified.Location = new System.Drawing.Point(6, 97);
            this.radRadioButtonSimplified.Name = "radRadioButtonSimplified";
            this.radRadioButtonSimplified.Size = new System.Drawing.Size(117, 18);
            this.radRadioButtonSimplified.TabIndex = 9;
            this.radRadioButtonSimplified.Text = "QWERTY Simplified";
            this.radRadioButtonSimplified.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RadRadioButtonSimplified_ToggleStateChanged);
            // 
            // radRadioButtonExtended
            // 
            this.radRadioButtonExtended.Location = new System.Drawing.Point(6, 73);
            this.radRadioButtonExtended.Name = "radRadioButtonExtended";
            this.radRadioButtonExtended.Size = new System.Drawing.Size(113, 18);
            this.radRadioButtonExtended.TabIndex = 8;
            this.radRadioButtonExtended.Text = "QWERTY Extended";
            this.radRadioButtonExtended.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RadRadioButtonExtended_ToggleStateChanged);
            // 
            // radRadioButtonColemak
            // 
            this.radRadioButtonColemak.Location = new System.Drawing.Point(6, 49);
            this.radRadioButtonColemak.Name = "radRadioButtonColemak";
            this.radRadioButtonColemak.Size = new System.Drawing.Size(64, 18);
            this.radRadioButtonColemak.TabIndex = 7;
            this.radRadioButtonColemak.Text = "Colemak";
            this.radRadioButtonColemak.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RadRadioButtonColemak_ToggleStateChanged);
            // 
            // radRadioButtonDvorak
            // 
            this.radRadioButtonDvorak.Location = new System.Drawing.Point(6, 25);
            this.radRadioButtonDvorak.Name = "radRadioButtonDvorak";
            this.radRadioButtonDvorak.Size = new System.Drawing.Size(56, 18);
            this.radRadioButtonDvorak.TabIndex = 6;
            this.radRadioButtonDvorak.Text = "Dvorak";
            this.radRadioButtonDvorak.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RadRadioButtonDvorak_ToggleStateChanged);
            // 
            // radVirtualKeyboard1
            // 
            this.radVirtualKeyboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radVirtualKeyboard1.Location = new System.Drawing.Point(0, 55);
            this.radVirtualKeyboard1.Name = "radVirtualKeyboard1";
            this.radVirtualKeyboard1.Size = new System.Drawing.Size(1030, 334);
            this.radVirtualKeyboard1.TabIndex = 0;
            this.radVirtualKeyboard1.TabStop = false;
            this.radVirtualKeyboard1.Text = "radVirtualKeyboard1";
            this.radVirtualKeyboard1.KeySending += new Telerik.WinControls.VirtualKeyboard.VirtualKeyboardKeySendingEventHandler(this.RadVirtualKeyboard1_KeySending);
            this.radVirtualKeyboard1.KeySent += new Telerik.WinControls.VirtualKeyboard.VirtualKeyboardKeySentEventHandler(this.RadVirtualKeyboard1_KeySent);
            // 
            // radLabelLayoutType
            // 
            this.radLabelLayoutType.AutoSize = false;
            this.radLabelLayoutType.Dock = System.Windows.Forms.DockStyle.Top;
            this.radLabelLayoutType.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.radLabelLayoutType.Location = new System.Drawing.Point(0, 0);
            this.radLabelLayoutType.Name = "radLabelLayoutType";
            this.radLabelLayoutType.Size = new System.Drawing.Size(1030, 55);
            this.radLabelLayoutType.TabIndex = 1;
            this.radLabelLayoutType.Text = "radLabelLayoutType";
            this.radLabelLayoutType.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radDropDownListScaleFactor
            // 
            this.radDropDownListScaleFactor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListScaleFactor.Location = new System.Drawing.Point(97, 243);
            this.radDropDownListScaleFactor.Name = "radDropDownListScaleFactor";
            this.radDropDownListScaleFactor.Size = new System.Drawing.Size(100, 20);
            this.radDropDownListScaleFactor.TabIndex = 9;
            this.radDropDownListScaleFactor.Tag = "Right";
            this.radDropDownListScaleFactor.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.RadDropDownListScaleFactor_SelectedIndexChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(5, 243);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(66, 18);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "Scale factor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2046, 1156);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxScaleFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxSyncWithSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSaveLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlSentKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxLayout)).EndInit();
            this.radGroupBoxLayout.ResumeLayout(false);
            this.radGroupBoxLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLoadLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonNumpad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonSimplified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonExtended)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonColemak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonDvorak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualKeyboard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelLayoutType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListScaleFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxSyncWithSystem;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxScaleFont;
        private Telerik.WinControls.UI.RadButton radButtonSaveLayout;
        private Telerik.WinControls.UI.RadLabel radLabelEvents;
        private Telerik.WinControls.UI.RadButton radButtonClear;
        private Telerik.WinControls.UI.RadListControl radListControlSentKeys;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxLayout;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonNumpad;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonSimplified;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonExtended;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonColemak;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonDvorak;
        private Telerik.WinControls.UI.RadButton radButtonLoadLayout;
        private Telerik.WinControls.UI.RadLabel radLabelLayoutType;
        private Telerik.WinControls.UI.RadVirtualKeyboard radVirtualKeyboard1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListScaleFactor;
    }
}