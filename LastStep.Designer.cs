namespace Raven
{
    partial class LastStep
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tileLayout1 = new Syncfusion.Windows.Forms.Tools.TileLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1.MainLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tileLayout1
            // 
            this.tileLayout1.AllowNewGroup = false;
            this.tileLayout1.AutoScroll = true;
            this.tileLayout1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tileLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLayout1.ExitButtonImage = null;
            this.tileLayout1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLayout1.Items = 0;
            this.tileLayout1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.tileLayout1.MainLayout.ContainerControl = this.tileLayout1;
            this.tileLayout1.MainLayout.HGap = 75;
            this.tileLayout1.MainLayout.HorzNearMargin = 100;
            this.tileLayout1.MainLayout.TopMargin = 100;
            this.tileLayout1.MainLayout.VGap = 75;
            this.tileLayout1.Name = "tileLayout1";
            this.tileLayout1.NewGroupButtonImage = null;
            this.tileLayout1.NewGroupIndicatorColor = System.Drawing.Color.Black;
            this.tileLayout1.SetParentFormFlat = false;
            this.tileLayout1.ShowGroupTitle = false;
            this.tileLayout1.ShowItemPreview = false;
            this.tileLayout1.ShowPreviewButtonImage = null;
            this.tileLayout1.Size = new System.Drawing.Size(820, 388);
            this.tileLayout1.TabIndex = 0;
            this.tileLayout1.TextAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.tileLayout1.TitleFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLayout1.Transparency = 10;
            // 
            // LastStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 388);
            this.Controls.Add(this.tileLayout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LastStep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LastStep";
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1.MainLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Syncfusion.Windows.Forms.Tools.TileLayout tileLayout1;
    }
}