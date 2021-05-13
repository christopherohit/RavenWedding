namespace PhotoAlbumCS
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
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.radRadPhotoAlbumViewer1 = new PhotoAlbumCS.RadPhotoAlbumViewer();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRadPhotoAlbumViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "ribbon_minimize.png");
            this.imageList2.Images.SetKeyName(1, "ribbon_maximize.png");
            this.imageList2.Images.SetKeyName(2, "ribbon_close.png");
            // 
            // radRadPhotoAlbumViewer1
            // 
            // 
            // 
            // 
            this.radRadPhotoAlbumViewer1.AlbumElement.OriginalItemSize = new System.Drawing.Size(250, 150);
            this.radRadPhotoAlbumViewer1.BackColor = System.Drawing.Color.Transparent;
            this.radRadPhotoAlbumViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRadPhotoAlbumViewer1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radButtonElement2});
            this.radRadPhotoAlbumViewer1.Location = new System.Drawing.Point(0, 0);
            this.radRadPhotoAlbumViewer1.Name = "radRadPhotoAlbumViewer1";
            this.radRadPhotoAlbumViewer1.Size = new System.Drawing.Size(792, 573);
            this.radRadPhotoAlbumViewer1.TabIndex = 0;
            this.radRadPhotoAlbumViewer1.Text = "radButton1";
            this.radRadPhotoAlbumViewer1.ThemeName = "no theme";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(222)))), ((int)(((byte)(183)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0))).NumberOfColors = 3;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Radial;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "radButtonElement1";
            this.radButtonElement1.AccessibleName = "radButtonElement1";
            this.radButtonElement1.AngleTransform = 35F;
            this.radButtonElement1.AutoSize = false;
            this.radButtonElement1.Bounds = new System.Drawing.Rectangle(376, 401, 250, 150);
            this.radButtonElement1.CanFocus = true;
            this.radButtonElement1.ClipDrawing = true;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.ShowBorder = false;
            this.radButtonElement1.Text = "radButtonElement1";
            this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radButtonElement1.ZIndex = 0;
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.AccessibleDescription = "radButtonElement2";
            this.radButtonElement2.AccessibleName = "radButtonElement2";
            this.radButtonElement2.AngleTransform = 15F;
            this.radButtonElement2.AutoSize = false;
            this.radButtonElement2.Bounds = new System.Drawing.Rectangle(373, 21, 250, 150);
            this.radButtonElement2.CanFocus = true;
            this.radButtonElement2.ClipDrawing = true;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.ShowBorder = false;
            this.radButtonElement2.Text = "radButtonElement2";
            this.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radButtonElement2.ZIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(960, 680);
            this.Controls.Add(this.radRadPhotoAlbumViewer1);
            this.Name = "Form1";
            this.Text = "Photo album viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.radRadPhotoAlbumViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadPhotoAlbumViewer radRadPhotoAlbumViewer1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private System.Windows.Forms.ImageList imageList2;
    }
}