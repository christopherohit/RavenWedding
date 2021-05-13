namespace Telerik.Examples.WinControls.GridView.Rows.RowsReorder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.btnMoveUp = new Telerik.WinControls.UI.RadButton();
            this.btnMoveDown = new Telerik.WinControls.UI.RadButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMoveUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMoveDown)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.btnMoveUp);
            this.settingsPanel.Controls.Add(this.btnMoveDown);
            this.settingsPanel.Location = new System.Drawing.Point(911, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 747);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.btnMoveDown, 0);
            this.settingsPanel.Controls.SetChildIndex(this.btnMoveUp, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(1112, 749);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMoveUp.Image = global::Telerik.Examples.WinControls.Properties.Resources.arrow_up2;
            this.btnMoveUp.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.btnMoveUp.Location = new System.Drawing.Point(10, 37);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMoveUp.Size = new System.Drawing.Size(180, 30);
            this.btnMoveUp.TabIndex = 1;
            this.btnMoveUp.Text = "Move Up";
        
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMoveDown.Image = global::Telerik.Examples.WinControls.Properties.Resources.arrow_down1;
            this.btnMoveDown.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.btnMoveDown.Location = new System.Drawing.Point(10, 73);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMoveDown.Size = new System.Drawing.Size(180, 30);
            this.btnMoveDown.TabIndex = 2;
            this.btnMoveDown.Text = "Move Down";
      
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "TaskCompleted.png");
            this.imageList1.Images.SetKeyName(1, "TaskNotCompleted.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1112, 749);
 
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMoveUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMoveDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton btnMoveUp;
        private Telerik.WinControls.UI.RadButton btnMoveDown;
        private System.Windows.Forms.ImageList imageList1;
    }
}
