using System;
using System.ComponentModel;
using Telerik.WinControls.UI;
using Telerik.WinForms.RichTextEditor.RichTextBoxUI.Dialogs.Styles;

namespace RichTextEditorRibbonUI
{
    public class StyleGalleryItem : RadGalleryItem
    {
        private StyleData style;

        public StyleData StyleData
        {
            get { return style; }
        }

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.Margin = new System.Windows.Forms.Padding(5);
            this.AutoToolTip = true;
        }

        public StyleGalleryItem(string text, Telerik.WinForms.RichTextEditor.RichTextBoxUI.Dialogs.Styles.StyleData style)
            : base(text, (style.Image != null) ? style.Image.Bitmap : null)
        {
            this.style = style;
            style.PropertyChanged += style_PropertyChanged;
        }

        public override string ToolTipText
        {
            get
            {
                if (this.StyleData != null)
                {
                    return this.StyleData.RealStyleDefinition.DisplayName;
                }

                return base.ToolTipText;
            }
            set
            {
                base.ToolTipText = value;
            }
        }

        private void style_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Image")
            {
                this.Image = this.style.Image.Bitmap;
            }
        }

        protected override void DisposeManagedResources()
        {
            this.style.PropertyChanged -= style_PropertyChanged;

            base.DisposeManagedResources();
        }

        protected override Type ThemeEffectiveType
        {
            get { return typeof(RadGalleryItem); }
        }
    }
}
