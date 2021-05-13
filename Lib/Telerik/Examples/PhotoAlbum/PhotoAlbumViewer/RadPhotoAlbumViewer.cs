using System.ComponentModel;
using Telerik.WinControls;

namespace PhotoAlbumCS
{
    public class RadPhotoAlbumViewer : RadControl
    {
        private PhotoAlbumViewerElement albumElement;

        public RadPhotoAlbumViewer()
        {
            this.ThemeName = "no theme";
        }

        protected override void OnLoad(System.Drawing.Size desiredSize)
        {
            base.OnLoad(desiredSize);
            this.EnableGesture(GestureType.All);
            this.EnableGesture(GestureType.Pan);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PhotoAlbumViewerElement AlbumElement
        {
            get
            {
                return albumElement;
            }
        }

        protected override void CreateChildItems(RadElement parent)
        {
            this.albumElement = new PhotoAlbumViewerElement();
            parent.Children.Add(this.albumElement);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(true), Category(RadDesignCategory.DataCategory)]
        [RadNewItem("Item", false)]
        public RadItemCollection Items
        {
            get
            {
                return this.AlbumElement.Items;
            }
        }
        protected override void OnSizeChanged( System.EventArgs e )
        {
            base.OnSizeChanged( e );
            this.albumElement.SelectedIndex = -1;
        }
    }
}
