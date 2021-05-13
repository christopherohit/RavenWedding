using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Editors.AutoCompleteBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radButtonSend = new Telerik.WinControls.UI.RadButton();
            this.radButtonTo = new Telerik.WinControls.UI.RadButton();
            this.radButtonCc = new Telerik.WinControls.UI.RadButton();
            this.radLabelSubject = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxControlSubject = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radAutoCompleteBox1 = new Telerik.WinControls.UI.RadAutoCompleteBox();
            this.radAutoCompleteBox2 = new Telerik.WinControls.UI.RadAutoCompleteBox();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.tableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.radListControlRecipients = new Telerik.WinControls.UI.RadListControl();
            this.radLabel1Recipients = new Telerik.WinControls.UI.RadLabel();
            this.radListControlCarbonCopy = new Telerik.WinControls.UI.RadListControl();
            this.radLabelCarbonCopy = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownListAutoCompleteMode = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabelAutoComplete = new Telerik.WinControls.UI.RadLabel();
            this.doubleBufferedTableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControlSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAutoCompleteBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAutoCompleteBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlRecipients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1Recipients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlCarbonCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCarbonCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListAutoCompleteMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelAutoComplete)).BeginInit();
            this.doubleBufferedTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(900, 125);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(8);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.doubleBufferedTableLayoutPanel1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(420, 998);
            this.settingsPanel.Size = new System.Drawing.Size(420, 998);
            // 
            // optionsLabel
            // 
            this.optionsLabel.Location = new System.Drawing.Point(5, 5);
            this.optionsLabel.Margin = new System.Windows.Forms.Padding(4);
            // 
            // radButtonSend
            // 
            this.radButtonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonSend.Image = global::Telerik.Examples.WinControls.Properties.Resources.send_email;
            this.radButtonSend.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButtonSend.Location = new System.Drawing.Point(15, 15);
            this.radButtonSend.Margin = new System.Windows.Forms.Padding(15);
            this.radButtonSend.Name = "radButtonSend";
            this.tableLayoutPanel1.SetRowSpan(this.radButtonSend, 3);
            this.radButtonSend.Size = new System.Drawing.Size(75, 174);
            this.radButtonSend.TabIndex = 1;
            this.radButtonSend.Text = "Send";
            this.radButtonSend.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButtonSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // radButtonTo
            // 
            this.radButtonTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonTo.Location = new System.Drawing.Point(113, 9);
            this.radButtonTo.Margin = new System.Windows.Forms.Padding(8);
            this.radButtonTo.Name = "radButtonTo";
            this.radButtonTo.Size = new System.Drawing.Size(82, 50);
            this.radButtonTo.TabIndex = 2;
            this.radButtonTo.Text = "To...";
            // 
            // radButtonCc
            // 
            this.radButtonCc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonCc.Location = new System.Drawing.Point(113, 77);
            this.radButtonCc.Margin = new System.Windows.Forms.Padding(8);
            this.radButtonCc.Name = "radButtonCc";
            this.radButtonCc.Size = new System.Drawing.Size(82, 50);
            this.radButtonCc.TabIndex = 3;
            this.radButtonCc.Text = "Cc...";
            // 
            // radLabelSubject
            // 
            this.radLabelSubject.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radLabelSubject.Location = new System.Drawing.Point(150, 163);
            this.radLabelSubject.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.radLabelSubject.Name = "radLabelSubject";
            this.radLabelSubject.Size = new System.Drawing.Size(45, 18);
            this.radLabelSubject.TabIndex = 4;
            this.radLabelSubject.Text = "Subject:";
            // 
            // radTextBoxControlSubject
            // 
            this.radTextBoxControlSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTextBoxControlSubject.Location = new System.Drawing.Point(211, 144);
            this.radTextBoxControlSubject.Margin = new System.Windows.Forms.Padding(8);
            this.radTextBoxControlSubject.Name = "radTextBoxControlSubject";
            // 
            // 
            // 
            this.radTextBoxControlSubject.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radTextBoxControlSubject.Size = new System.Drawing.Size(487, 52);
            this.radTextBoxControlSubject.TabIndex = 5;
            this.radTextBoxControlSubject.Text = "Re: Feedback";
            // 
            // radAutoCompleteBox1
            // 
            this.radAutoCompleteBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radAutoCompleteBox1.Location = new System.Drawing.Point(211, 77);
            this.radAutoCompleteBox1.Margin = new System.Windows.Forms.Padding(8);
            this.radAutoCompleteBox1.Name = "radAutoCompleteBox1";
            // 
            // 
            // 
            this.radAutoCompleteBox1.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.radAutoCompleteBox1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radAutoCompleteBox1.Size = new System.Drawing.Size(487, 50);
            this.radAutoCompleteBox1.TabIndex = 6;
            this.radAutoCompleteBox1.Text = "Samuel Jackson;";
            // 
            // radAutoCompleteBox2
            // 
            this.radAutoCompleteBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radAutoCompleteBox2.Location = new System.Drawing.Point(211, 9);
            this.radAutoCompleteBox2.Margin = new System.Windows.Forms.Padding(8);
            this.radAutoCompleteBox2.Name = "radAutoCompleteBox2";
            // 
            // 
            // 
            this.radAutoCompleteBox2.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.radAutoCompleteBox2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radAutoCompleteBox2.Size = new System.Drawing.Size(487, 50);
            this.radAutoCompleteBox2.TabIndex = 7;
            this.radAutoCompleteBox2.Text = "Joe Smith;";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radTextBox1);
            this.radPanel1.Controls.Add(this.tableLayoutPanel1);
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Margin = new System.Windows.Forms.Padding(8);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(872, 700);
            this.radPanel1.TabIndex = 8;
            // 
            // radTextBox1
            // 
            this.radTextBox1.AutoSize = false;
            this.radTextBox1.Font = new System.Drawing.Font("Calibri", 11F);
            this.radTextBox1.Location = new System.Drawing.Point(24, 266);
            this.radTextBox1.Margin = new System.Windows.Forms.Padding(8);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.ReadOnly = true;
            this.radTextBox1.Size = new System.Drawing.Size(698, 334);
            this.radTextBox1.TabIndex = 8;
            this.radTextBox1.Text = resources.GetString("radTextBox1.Text");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89521F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.99701F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.18263F));
            this.tableLayoutPanel1.Controls.Add(this.radButtonSend, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radTextBoxControlSubject, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.radLabelSubject, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.radButtonTo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radAutoCompleteBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.radButtonCc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radAutoCompleteBox2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 48);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(706, 204);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // radListControlRecipients
            // 
            this.radListControlRecipients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radListControlRecipients.ItemHeight = 45;
            this.radListControlRecipients.Location = new System.Drawing.Point(8, 69);
            this.radListControlRecipients.Margin = new System.Windows.Forms.Padding(8);
            this.radListControlRecipients.Name = "radListControlRecipients";
            this.radListControlRecipients.Size = new System.Drawing.Size(254, 291);
            this.radListControlRecipients.TabIndex = 1;
            // 
            // radLabel1Recipients
            // 
            this.radLabel1Recipients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel1Recipients.Location = new System.Drawing.Point(8, 35);
            this.radLabel1Recipients.Margin = new System.Windows.Forms.Padding(8);
            this.radLabel1Recipients.Name = "radLabel1Recipients";
            this.radLabel1Recipients.Size = new System.Drawing.Size(77, 18);
            this.radLabel1Recipients.TabIndex = 2;
            this.radLabel1Recipients.Text = "Recipients List";
            // 
            // radListControlCarbonCopy
            // 
            this.radListControlCarbonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radListControlCarbonCopy.ItemHeight = 45;
            this.radListControlCarbonCopy.Location = new System.Drawing.Point(8, 437);
            this.radListControlCarbonCopy.Margin = new System.Windows.Forms.Padding(8);
            this.radListControlCarbonCopy.Name = "radListControlCarbonCopy";
            this.radListControlCarbonCopy.Size = new System.Drawing.Size(254, 291);
            this.radListControlCarbonCopy.TabIndex = 3;
            // 
            // radLabelCarbonCopy
            // 
            this.radLabelCarbonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabelCarbonCopy.Location = new System.Drawing.Point(8, 403);
            this.radLabelCarbonCopy.Margin = new System.Windows.Forms.Padding(8);
            this.radLabelCarbonCopy.Name = "radLabelCarbonCopy";
            this.radLabelCarbonCopy.Size = new System.Drawing.Size(91, 18);
            this.radLabelCarbonCopy.TabIndex = 4;
            this.radLabelCarbonCopy.Text = "Carbon Copy List";
            // 
            // radDropDownListAutoCompleteMode
            // 
            this.radDropDownListAutoCompleteMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radDropDownListAutoCompleteMode.DropDownHeight = 260;
            this.radDropDownListAutoCompleteMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "Suggest";
            radListDataItem2.Text = "Append";
            radListDataItem3.Text = "SuggestAppend";
            this.radDropDownListAutoCompleteMode.Items.Add(radListDataItem1);
            this.radDropDownListAutoCompleteMode.Items.Add(radListDataItem2);
            this.radDropDownListAutoCompleteMode.Items.Add(radListDataItem3);
            this.radDropDownListAutoCompleteMode.Location = new System.Drawing.Point(8, 805);
            this.radDropDownListAutoCompleteMode.Margin = new System.Windows.Forms.Padding(8);
            this.radDropDownListAutoCompleteMode.Name = "radDropDownListAutoCompleteMode";
            this.radDropDownListAutoCompleteMode.Size = new System.Drawing.Size(254, 20);
            this.radDropDownListAutoCompleteMode.TabIndex = 5;
            // 
            // radLabelAutoComplete
            // 
            this.radLabelAutoComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabelAutoComplete.Location = new System.Drawing.Point(8, 771);
            this.radLabelAutoComplete.Margin = new System.Windows.Forms.Padding(8);
            this.radLabelAutoComplete.Name = "radLabelAutoComplete";
            this.radLabelAutoComplete.Size = new System.Drawing.Size(111, 18);
            this.radLabelAutoComplete.TabIndex = 6;
            this.radLabelAutoComplete.Text = "AutoComplete Mode";
            // 
            // doubleBufferedTableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel1.ColumnCount = 1;
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radListControlRecipients, 0, 1);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLabel1Recipients, 0, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radDropDownListAutoCompleteMode, 0, 5);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLabelAutoComplete, 0, 4);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLabelCarbonCopy, 0, 2);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radListControlCarbonCopy, 0, 3);
            this.doubleBufferedTableLayoutPanel1.Location = new System.Drawing.Point(82, 5);
            this.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1";
            this.doubleBufferedTableLayoutPanel1.RowCount = 6;
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.doubleBufferedTableLayoutPanel1.Size = new System.Drawing.Size(270, 861);
            this.doubleBufferedTableLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1963, 1146);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControlSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAutoCompleteBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAutoCompleteBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlRecipients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1Recipients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlCarbonCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCarbonCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListAutoCompleteMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelAutoComplete)).EndInit();
            this.doubleBufferedTableLayoutPanel1.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonSend;
        private Telerik.WinControls.UI.RadButton radButtonTo;
        private Telerik.WinControls.UI.RadButton radButtonCc;
        private Telerik.WinControls.UI.RadLabel radLabelSubject;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControlSubject;
        private Telerik.WinControls.UI.RadAutoCompleteBox radAutoCompleteBox1;
        private Telerik.WinControls.UI.RadAutoCompleteBox radAutoCompleteBox2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabelCarbonCopy;
        private Telerik.WinControls.UI.RadListControl radListControlCarbonCopy;
        private Telerik.WinControls.UI.RadLabel radLabel1Recipients;
        private Telerik.WinControls.UI.RadListControl radListControlRecipients;
        private Telerik.WinControls.UI.RadLabel radLabelAutoComplete;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListAutoCompleteMode;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel1;
    }
}