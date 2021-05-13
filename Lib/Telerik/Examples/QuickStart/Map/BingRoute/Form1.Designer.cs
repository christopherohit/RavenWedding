namespace Telerik.Examples.WinControls.Map.BingRoute
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
            this.radMap1 = new Telerik.WinControls.UI.RadMap();
            this.radGroupBoxSetup = new Telerik.WinControls.UI.RadGroupBox();
            this.radButtonCalculateRoute = new Telerik.WinControls.UI.RadButton();
            this.radLabelEndPoint = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxEndPoint = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxStartPoint = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBoxTurnByTurnDirections = new Telerik.WinControls.UI.RadGroupBox();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.radDropDownListMode = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownListOptimize = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabelOptimize = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownListAvoid = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabelAvoid = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownListUnits = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxSetup)).BeginInit();
            this.radGroupBoxSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCalculateRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelEndPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxEndPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxStartPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxTurnByTurnDirections)).BeginInit();
            this.radGroupBoxTurnByTurnDirections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListOptimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelOptimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListAvoid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelAvoid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBoxSetup);
            this.settingsPanel.Size = new System.Drawing.Size(230, 710);
            this.settingsPanel.TabStop = false;
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxSetup, 0);
            // 
            // radMap1
            // 
            this.radMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radMap1.Location = new System.Drawing.Point(0, 0);
            this.radMap1.Name = "radMap1";
            this.radMap1.ShowLegend = false;
            this.radMap1.ShowMiniMap = false;
            this.radMap1.ShowSearchBar = false;
            this.radMap1.Size = new System.Drawing.Size(1500, 1028);
            this.radMap1.TabIndex = 0;
            this.radMap1.TabStop = false;
            this.radMap1.Text = "radMap1";
            // 
            // radGroupBoxSetup
            // 
            this.radGroupBoxSetup.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxSetup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxSetup.Controls.Add(this.radLabelAvoid);
            this.radGroupBoxSetup.Controls.Add(this.radDropDownListAvoid);
            this.radGroupBoxSetup.Controls.Add(this.radLabelOptimize);
            this.radGroupBoxSetup.Controls.Add(this.radDropDownListOptimize);
            this.radGroupBoxSetup.Controls.Add(this.radLabel5);
            this.radGroupBoxSetup.Controls.Add(this.radDropDownListUnits);
            this.radGroupBoxSetup.Controls.Add(this.radLabel2);
            this.radGroupBoxSetup.Controls.Add(this.radDropDownListMode);
            this.radGroupBoxSetup.Controls.Add(this.radButtonCalculateRoute);
            this.radGroupBoxSetup.Controls.Add(this.radLabelEndPoint);
            this.radGroupBoxSetup.Controls.Add(this.radLabel1);
            this.radGroupBoxSetup.Controls.Add(this.radTextBoxEndPoint);
            this.radGroupBoxSetup.Controls.Add(this.radTextBoxStartPoint);
            this.radGroupBoxSetup.HeaderText = "Route calculation";
            this.radGroupBoxSetup.Location = new System.Drawing.Point(10, 33);
            this.radGroupBoxSetup.Name = "radGroupBoxSetup";
            this.radGroupBoxSetup.Size = new System.Drawing.Size(210, 390);
            this.radGroupBoxSetup.TabIndex = 1;
            this.radGroupBoxSetup.TabStop = false;
            this.radGroupBoxSetup.Text = "Route calculation";
            // 
            // radButtonCalculateRoute
            // 
            this.radButtonCalculateRoute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonCalculateRoute.Location = new System.Drawing.Point(5, 335);
            this.radButtonCalculateRoute.Name = "radButtonCalculateRoute";
            this.radButtonCalculateRoute.Size = new System.Drawing.Size(200, 42);
            this.radButtonCalculateRoute.TabIndex = 2;
            this.radButtonCalculateRoute.Text = "Calculate route";
            this.radButtonCalculateRoute.Click += new System.EventHandler(this.radButtonCalculateRoute_Click);
            // 
            // radLabelEndPoint
            // 
            this.radLabelEndPoint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelEndPoint.Location = new System.Drawing.Point(5, 80);
            this.radLabelEndPoint.Name = "radLabelEndPoint";
            this.radLabelEndPoint.Size = new System.Drawing.Size(53, 18);
            this.radLabelEndPoint.TabIndex = 1;
            this.radLabelEndPoint.Text = "End point";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 30);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(74, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Starting point";
            // 
            // radTextBoxEndPoint
            // 
            this.radTextBoxEndPoint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTextBoxEndPoint.Location = new System.Drawing.Point(5, 101);
            this.radTextBoxEndPoint.Name = "radTextBoxEndPoint";
            this.radTextBoxEndPoint.Size = new System.Drawing.Size(200, 20);
            this.radTextBoxEndPoint.TabIndex = 1;
            // 
            // radTextBoxStartPoint
            // 
            this.radTextBoxStartPoint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTextBoxStartPoint.Location = new System.Drawing.Point(5, 51);
            this.radTextBoxStartPoint.Name = "radTextBoxStartPoint";
            this.radTextBoxStartPoint.Size = new System.Drawing.Size(200, 20);
            this.radTextBoxStartPoint.TabIndex = 0;
            // 
            // radGroupBoxTurnByTurnDirections
            // 
            this.radGroupBoxTurnByTurnDirections.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxTurnByTurnDirections.Controls.Add(this.radListView1);
            this.radGroupBoxTurnByTurnDirections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBoxTurnByTurnDirections.HeaderText = "Turn by turn directions";
            this.radGroupBoxTurnByTurnDirections.Location = new System.Drawing.Point(0, 0);
            this.radGroupBoxTurnByTurnDirections.Name = "radGroupBoxTurnByTurnDirections";
            this.radGroupBoxTurnByTurnDirections.Padding = new System.Windows.Forms.Padding(2, 25, 2, 2);
            this.radGroupBoxTurnByTurnDirections.Size = new System.Drawing.Size(384, 1028);
            this.radGroupBoxTurnByTurnDirections.TabIndex = 2;
            this.radGroupBoxTurnByTurnDirections.TabStop = false;
            this.radGroupBoxTurnByTurnDirections.Text = "Turn by turn directions";
            // 
            // radListView1
            // 
            this.radListView1.AllowEdit = false;
            this.radListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListView1.Location = new System.Drawing.Point(2, 25);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(380, 1001);
            this.radListView1.TabIndex = 0;
            this.radListView1.TabStop = false;
            this.radListView1.Text = "radListView1";
            this.radListView1.SelectedIndexChanged += radListView1_SelectedIndexChanged;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radSplitContainer1.Size = new System.Drawing.Size(1500, 1028);
            this.radSplitContainer1.TabIndex = 3;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radMap1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel1.Size = new System.Drawing.Size(1500, 1028);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.2592477F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(291, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Collapsed = true;
            this.splitPanel2.Controls.Add(this.radGroupBoxTurnByTurnDirections);
            this.splitPanel2.Location = new System.Drawing.Point(1215, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel2.Size = new System.Drawing.Size(384, 1028);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.25F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(-291, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // radDropDownListMode
            // 
            this.radDropDownListMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownListMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListMode.Location = new System.Drawing.Point(5, 196);
            this.radDropDownListMode.Name = "radDropDownListMode";
            this.radDropDownListMode.Size = new System.Drawing.Size(200, 20);
            this.radDropDownListMode.TabIndex = 3;
            this.radDropDownListMode.Text = "radDropDownList1";
            this.radDropDownListMode.SelectedIndexChanged += radDropDownListMode_SelectedIndexChanged;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(5, 175);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(35, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Mode";
            // 
            // radDropDownListOptimize
            // 
            this.radDropDownListOptimize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownListOptimize.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListOptimize.Location = new System.Drawing.Point(5, 246);
            this.radDropDownListOptimize.Name = "radDropDownListOptimize";
            this.radDropDownListOptimize.Size = new System.Drawing.Size(200, 20);
            this.radDropDownListOptimize.TabIndex = 3;
            this.radDropDownListOptimize.Text = "radDropDownList1";
            // 
            // radLabel3
            // 
            this.radLabelOptimize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelOptimize.Location = new System.Drawing.Point(5, 225);
            this.radLabelOptimize.Name = "radLabel3";
            this.radLabelOptimize.Size = new System.Drawing.Size(70, 18);
            this.radLabelOptimize.TabIndex = 4;
            this.radLabelOptimize.Text = "Optimization";
            // 
            // radDropDownListAvoid
            // 
            this.radDropDownListAvoid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownListAvoid.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListAvoid.Location = new System.Drawing.Point(5, 296);
            this.radDropDownListAvoid.Name = "radDropDownListAvoid";
            this.radDropDownListAvoid.Size = new System.Drawing.Size(200, 20);
            this.radDropDownListAvoid.TabIndex = 3;
            this.radDropDownListAvoid.Text = "radDropDownList1";
            // 
            // radLabel4
            // 
            this.radLabelAvoid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelAvoid.Location = new System.Drawing.Point(5, 275);
            this.radLabelAvoid.Name = "radLabel4";
            this.radLabelAvoid.Size = new System.Drawing.Size(57, 18);
            this.radLabelAvoid.TabIndex = 4;
            this.radLabelAvoid.Text = "Avoidance";
            // 
            // radDropDownListUnits
            // 
            this.radDropDownListUnits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownListUnits.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListUnits.Location = new System.Drawing.Point(5, 149);
            this.radDropDownListUnits.Name = "radDropDownListUnits";
            this.radDropDownListUnits.Size = new System.Drawing.Size(200, 20);
            this.radDropDownListUnits.TabIndex = 3;
            this.radDropDownListUnits.Text = "radDropDownList1";
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel5.Location = new System.Drawing.Point(5, 130);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(75, 18);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "Distance units";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1510, 1038);
            this.Controls.SetChildIndex(this.radSplitContainer1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxSetup)).EndInit();
            this.radGroupBoxSetup.ResumeLayout(false);
            this.radGroupBoxSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCalculateRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelEndPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxEndPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxStartPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxTurnByTurnDirections)).EndInit();
            this.radGroupBoxTurnByTurnDirections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListOptimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelOptimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListAvoid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelAvoid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMap radMap1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxSetup;
        private Telerik.WinControls.UI.RadButton radButtonCalculateRoute;
        private Telerik.WinControls.UI.RadLabel radLabelEndPoint;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radTextBoxEndPoint;
        private Telerik.WinControls.UI.RadTextBox radTextBoxStartPoint;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxTurnByTurnDirections;
        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadLabel radLabelAvoid;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListAvoid;
        private Telerik.WinControls.UI.RadLabel radLabelOptimize;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListOptimize;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListMode;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListUnits;
    }
}