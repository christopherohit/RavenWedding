namespace Telerik.Examples.WinControls.PropertyGrid.Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radPropertyGrid1 = new Telerik.WinControls.UI.RadPropertyGrid();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownListPropertySort = new Telerik.WinControls.UI.RadDropDownList();
            this.radSpinEditorItemSpacing = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorItemIndent = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorItemHeight = new Telerik.WinControls.UI.RadSpinEditor();
            this.radCheckBoxAutoExpandGroups = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxReadOnly = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxSearchVisible = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxHelpVisible = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxKeyboardSearch = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListPropertySort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAutoExpandGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxSearchVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxHelpVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxKeyboardSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(1081, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 788);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radPropertyGrid1
            // 
            this.radPropertyGrid1.HelpVisible = false;
            this.radPropertyGrid1.Location = new System.Drawing.Point(350, 25);
            this.radPropertyGrid1.Name = "radPropertyGrid1";
            this.radPropertyGrid1.Size = new System.Drawing.Size(400, 600);
            this.radPropertyGrid1.TabIndex = 1;
            this.radPropertyGrid1.Text = "radPropertyGrid1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radCheckBoxKeyboardSearch);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radDropDownListPropertySort);
            this.radGroupBox1.Controls.Add(this.radSpinEditorItemSpacing);
            this.radGroupBox1.Controls.Add(this.radSpinEditorItemIndent);
            this.radGroupBox1.Controls.Add(this.radSpinEditorItemHeight);
            this.radGroupBox1.Controls.Add(this.radCheckBoxAutoExpandGroups);
            this.radGroupBox1.Controls.Add(this.radCheckBoxReadOnly);
            this.radGroupBox1.Controls.Add(this.radCheckBoxSearchVisible);
            this.radGroupBox1.Controls.Add(this.radCheckBoxHelpVisible);
            this.radGroupBox1.HeaderText = "UI Settings";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 72);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(180, 256);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "UI Settings";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(6, 224);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(70, 18);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "Property sort";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(6, 198);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(69, 18);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Item spacing";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(6, 172);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(63, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Item indent";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(6, 146);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(63, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Item height";
            // 
            // radDropDownListPropertySort
            // 
            this.radDropDownListPropertySort.Location = new System.Drawing.Point(84, 222);
            this.radDropDownListPropertySort.Name = "radDropDownListPropertySort";
            this.radDropDownListPropertySort.Size = new System.Drawing.Size(92, 20);
            this.radDropDownListPropertySort.TabIndex = 2;
            this.radDropDownListPropertySort.Tag = "Right";
            this.radDropDownListPropertySort.Text = "radDropDownList1";
            // 
            // radSpinEditorItemSpacing
            // 
            this.radSpinEditorItemSpacing.Location = new System.Drawing.Point(84, 196);
            this.radSpinEditorItemSpacing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.radSpinEditorItemSpacing.Name = "radSpinEditorItemSpacing";
            // 
            // 
            // 
            this.radSpinEditorItemSpacing.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorItemSpacing.Size = new System.Drawing.Size(92, 20);
            this.radSpinEditorItemSpacing.TabIndex = 1;
            this.radSpinEditorItemSpacing.TabStop = false;
            this.radSpinEditorItemSpacing.Tag = "Right";
            // 
            // radSpinEditorItemIndent
            // 
            this.radSpinEditorItemIndent.Location = new System.Drawing.Point(84, 170);
            this.radSpinEditorItemIndent.Name = "radSpinEditorItemIndent";
            // 
            // 
            // 
            this.radSpinEditorItemIndent.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorItemIndent.Size = new System.Drawing.Size(92, 20);
            this.radSpinEditorItemIndent.TabIndex = 1;
            this.radSpinEditorItemIndent.TabStop = false;
            this.radSpinEditorItemIndent.Tag = "Right";
            // 
            // radSpinEditorItemHeight
            // 
            this.radSpinEditorItemHeight.Location = new System.Drawing.Point(84, 144);
            this.radSpinEditorItemHeight.Name = "radSpinEditorItemHeight";
            // 
            // 
            // 
            this.radSpinEditorItemHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorItemHeight.Size = new System.Drawing.Size(92, 20);
            this.radSpinEditorItemHeight.TabIndex = 1;
            this.radSpinEditorItemHeight.TabStop = false;
            this.radSpinEditorItemHeight.Tag = "Right";
            // 
            // radCheckBoxAutoExpandGroups
            // 
            this.radCheckBoxAutoExpandGroups.Location = new System.Drawing.Point(5, 94);
            this.radCheckBoxAutoExpandGroups.Name = "radCheckBoxAutoExpandGroups";
            this.radCheckBoxAutoExpandGroups.Size = new System.Drawing.Size(122, 18);
            this.radCheckBoxAutoExpandGroups.TabIndex = 0;
            this.radCheckBoxAutoExpandGroups.Text = "Auto expand groups";
            // 
            // radCheckBoxReadOnly
            // 
            this.radCheckBoxReadOnly.Location = new System.Drawing.Point(5, 70);
            this.radCheckBoxReadOnly.Name = "radCheckBoxReadOnly";
            this.radCheckBoxReadOnly.Size = new System.Drawing.Size(70, 18);
            this.radCheckBoxReadOnly.TabIndex = 0;
            this.radCheckBoxReadOnly.Text = "Read only";
            // 
            // radCheckBoxSearchVisible
            // 
            this.radCheckBoxSearchVisible.Location = new System.Drawing.Point(5, 46);
            this.radCheckBoxSearchVisible.Name = "radCheckBoxSearchVisible";
            this.radCheckBoxSearchVisible.Size = new System.Drawing.Size(88, 18);
            this.radCheckBoxSearchVisible.TabIndex = 0;
            this.radCheckBoxSearchVisible.Text = "Search visible";
            // 
            // radCheckBoxHelpVisible
            // 
            this.radCheckBoxHelpVisible.Location = new System.Drawing.Point(5, 22);
            this.radCheckBoxHelpVisible.Name = "radCheckBoxHelpVisible";
            this.radCheckBoxHelpVisible.Size = new System.Drawing.Size(78, 18);
            this.radCheckBoxHelpVisible.TabIndex = 0;
            this.radCheckBoxHelpVisible.Text = "Help visible";
            // 
            // radCheckBoxKeyboardSearch
            // 
            this.radCheckBoxKeyboardSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxKeyboardSearch.Location = new System.Drawing.Point(5, 118);
            this.radCheckBoxKeyboardSearch.Name = "radCheckBoxKeyboardSearch";
            this.radCheckBoxKeyboardSearch.Size = new System.Drawing.Size(162, 18);
            this.radCheckBoxKeyboardSearch.TabIndex = 1;
            this.radCheckBoxKeyboardSearch.Text = "Enable Keyboard Navigation";
            this.radCheckBoxKeyboardSearch.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxKeyboardSearch.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxKeyboardSearch_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPropertyGrid1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1381, 1000);
            this.Controls.SetChildIndex(this.radPropertyGrid1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListPropertySort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAutoExpandGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxSearchVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxHelpVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxKeyboardSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPropertyGrid radPropertyGrid1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxHelpVisible;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorItemHeight;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorItemIndent;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxSearchVisible;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorItemSpacing;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListPropertySort;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxReadOnly;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxAutoExpandGroups;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxKeyboardSearch;
    }
}
