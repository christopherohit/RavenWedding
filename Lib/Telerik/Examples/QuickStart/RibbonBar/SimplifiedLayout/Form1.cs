using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.RibbonBar.SimplifiedLayout
{
    public partial class Form1 : RadForm, ISupportThemeName
    {

        public Form1()
        {
            InitializeComponent();

            this.AllowTheming = false;
            this.radRichTextEditor1.Document.LayoutMode = WinForms.Documents.Model.DocumentLayoutMode.Paged;
        }

        public void ApplyTheme(string themeName)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.richTextEditorRibbonBar1.LayoutMode = RibbonLayout.Simplified;
        }
    }
}