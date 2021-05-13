namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
{
    partial class AdvanceFilterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radPageView = new Telerik.WinControls.UI.RadPageView();
            this.radSearchPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabelSearch = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxSearch = new Telerik.WinControls.UI.RadTextBox();
            this.radAdvancedPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radBtnAdvanceApply = new Telerik.WinControls.UI.RadButton();
            this.rtbValue1 = new Telerik.WinControls.UI.RadTextBox();
            this.radDdlColumns = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownButtonOperator = new Telerik.WinControls.UI.RadDropDownButton();
            this.radLabelFilter = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView)).BeginInit();
            this.radPageView.SuspendLayout();
            this.radSearchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSearch)).BeginInit();
            this.radAdvancedPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnAdvanceApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDdlColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButtonOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView
            // 
            this.radPageView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.radPageView.Controls.Add(this.radSearchPage);
            this.radPageView.Controls.Add(this.radAdvancedPage);
            this.radPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView.Location = new System.Drawing.Point(0, 0);
            this.radPageView.Name = "radPageView";
            this.radPageView.SelectedPage = this.radAdvancedPage;
            this.radPageView.Size = new System.Drawing.Size(496, 103);
            this.radPageView.TabIndex = 0;
            this.radPageView.Text = "PageView";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // radSearchPage
            // 
            this.radSearchPage.Controls.Add(this.radLabelSearch);
            this.radSearchPage.Controls.Add(this.radTextBoxSearch);
            this.radSearchPage.ItemSize = new System.Drawing.SizeF(49F, 28F);
            this.radSearchPage.Location = new System.Drawing.Point(10, 37);
            this.radSearchPage.Name = "radSearchPage";
            this.radSearchPage.Size = new System.Drawing.Size(475, 55);
            this.radSearchPage.Text = "Search";
            // 
            // radLabelSearch
            // 
            this.radLabelSearch.Location = new System.Drawing.Point(3, 3);
            this.radLabelSearch.Name = "radLabelSearch";
            this.radLabelSearch.Size = new System.Drawing.Size(128, 18);
            this.radLabelSearch.TabIndex = 1;
            this.radLabelSearch.Text = "Type your search criteria";
            // 
            // radTextBoxSearch
            // 
            this.radTextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTextBoxSearch.Location = new System.Drawing.Point(3, 28);
            this.radTextBoxSearch.Name = "radTextBoxSearch";
            this.radTextBoxSearch.Size = new System.Drawing.Size(469, 20);
            this.radTextBoxSearch.TabIndex = 0;
            this.radTextBoxSearch.TabStop = false;
            // 
            // radAdvancedPage
            // 
            this.radAdvancedPage.Controls.Add(this.radBtnAdvanceApply);
            this.radAdvancedPage.Controls.Add(this.rtbValue1);
            this.radAdvancedPage.Controls.Add(this.radDdlColumns);
            this.radAdvancedPage.Controls.Add(this.radDropDownButtonOperator);
            this.radAdvancedPage.Controls.Add(this.radLabelFilter);
            this.radAdvancedPage.ItemSize = new System.Drawing.SizeF(66F, 28F);
            this.radAdvancedPage.Location = new System.Drawing.Point(10, 37);
            this.radAdvancedPage.Name = "radAdvancedPage";
            this.radAdvancedPage.Size = new System.Drawing.Size(475, 55);
            this.radAdvancedPage.Text = "Advanced";
            // 
            // radBtnAdvanceApply
            // 
            this.radBtnAdvanceApply.Location = new System.Drawing.Point(390, 28);
            this.radBtnAdvanceApply.Name = "radBtnAdvanceApply";
            this.radBtnAdvanceApply.Size = new System.Drawing.Size(78, 21);
            this.radBtnAdvanceApply.TabIndex = 10;
            this.radBtnAdvanceApply.Text = "Apply";
            // 
            // rtbValue1
            // 
            this.rtbValue1.Enabled = false;
            this.rtbValue1.Location = new System.Drawing.Point(246, 28);
            this.rtbValue1.Name = "rtbValue1";
            // 
            // 
            // 
            this.rtbValue1.RootElement.Enabled = false;
            this.rtbValue1.Size = new System.Drawing.Size(135, 21);
            this.rtbValue1.TabIndex = 8;
            this.rtbValue1.TabStop = false;
            // 
            // radDdlColumns
            // 
            this.radDdlColumns.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDdlColumns.Location = new System.Drawing.Point(3, 28);
            this.radDdlColumns.Name = "radDdlColumns";
            this.radDdlColumns.Size = new System.Drawing.Size(123, 21);
            this.radDdlColumns.TabIndex = 6;
            // 
            // radDropDownButtonOperator
            // 
            this.radDropDownButtonOperator.Location = new System.Drawing.Point(132, 28);
            this.radDropDownButtonOperator.Name = "radDropDownButtonOperator";
            this.radDropDownButtonOperator.Size = new System.Drawing.Size(106, 21);
            this.radDropDownButtonOperator.TabIndex = 4;
            this.radDropDownButtonOperator.Text = "Equals";
            // 
            // radLabelFilter
            // 
            this.radLabelFilter.Location = new System.Drawing.Point(3, 3);
            this.radLabelFilter.Name = "radLabelFilter";
            this.radLabelFilter.Size = new System.Drawing.Size(75, 18);
            this.radLabelFilter.TabIndex = 1;
            this.radLabelFilter.Text = "Filter rows by:";
            // 
            // AdvanceFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPageView);
            this.Name = "AdvanceFilterControl";
            this.Size = new System.Drawing.Size(496, 103);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView)).EndInit();
            this.radPageView.ResumeLayout(false);
            this.radSearchPage.ResumeLayout(false);
            this.radSearchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSearch)).EndInit();
            this.radAdvancedPage.ResumeLayout(false);
            this.radAdvancedPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnAdvanceApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDdlColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButtonOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView;
        private Telerik.WinControls.UI.RadPageViewPage radSearchPage;
        private Telerik.WinControls.UI.RadTextBox radTextBoxSearch;
        private Telerik.WinControls.UI.RadPageViewPage radAdvancedPage;
        private Telerik.WinControls.UI.RadButton radBtnAdvanceApply;
        private Telerik.WinControls.UI.RadTextBox rtbValue1;
        private Telerik.WinControls.UI.RadDropDownList radDdlColumns;
        private Telerik.WinControls.UI.RadDropDownButton radDropDownButtonOperator;
        private Telerik.WinControls.UI.RadLabel radLabelFilter;
        private Telerik.WinControls.UI.RadLabel radLabelSearch;
    }
}
