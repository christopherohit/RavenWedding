using System;
using System.Drawing;
using System.Windows.Forms;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.SplitContainer.FirstLook
{
    /// <summary>
    /// example form
    /// </summary>
    public partial class Form1 : ExamplesRadForm, ISupportThemeName
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            RadPageViewOutlookElement outlookStyle = this.radPanelBar1.ViewElement as RadPageViewOutlookElement;
            outlookStyle.HideItems(3);

            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView2.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            RadFormBehavior formBehavior = new RadFormBehavior(this);
            formBehavior.AllowTheming = true;
            this.FormBehavior = formBehavior;

            this.radRibbonBar1.RibbonBarElement.RibbonCaption.Visibility = ElementVisibility.Collapsed;
            this.radRibbonBar1.RibbonBarElement.QuickAccessToolBar.Visibility = ElementVisibility.Collapsed;

            this.carsTableAdapter.Fill(this.northwindDataSet.Cars);
        }

        protected override void WireEvents()
        {
            this.btnOpenDesigner.Click += new EventHandler(this.btnOpenDesigner_Click);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.OpenLayoutPropertiesForm();

            SetDefaultPanelBorderColors();
        }

        private void SetDefaultPanelBorderColors()
        {
            this.splitPanel_1.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255);
            this.splitPanel_2.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255);
            this.splitPanel_3.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255);
            this.splitPanel_4.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255);
            this.splitPanel_5.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255);
            ((BorderPrimitive)this.radPanel1.PanelElement.Children[1]).ForeColor = Color.FromArgb(191, 225, 255);
            ((BorderPrimitive)this.radPanel2.PanelElement.Children[1]).ForeColor = Color.FromArgb(191, 225, 255);
        }

        #region Split Properties

        public RadSplitContainer RadSplitContainer1
        {
            get
            {
                return this.radSplitContainer_1;
            }
        }

        public RadSplitContainer RadSplitContainer2
        {
            get
            {
                return this.radSplitContainer_2;
            }
        }

        public SplitPanel SplitPanel1
        {
            get
            {
                return this.splitPanel_1;
            }
        }

        public SplitPanel SplitPanel2
        {
            get
            {
                return this.splitPanel_2;
            }
        }

        public SplitPanel SplitPanel3
        {
            get
            {
                return this.splitPanel_3;
            }
        }

        public SplitPanel SplitPanel4
        {
            get
            {
                return this.splitPanel_4;
            }
        }

        public SplitPanel SplitPanel5
        {
            get
            {
                return this.splitPanel_5;
            }
        }

        #endregion

        private void btnOpenDesigner_Click(object sender, EventArgs e)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm is LayoutProperties)
                    return;                    
            }

            this.OpenLayoutPropertiesForm();
        }
 
        private void OpenLayoutPropertiesForm()
        {
            LayoutProperties designerForm = new LayoutProperties();
            designerForm.Owner = this;
            designerForm.StartPosition = FormStartPosition.CenterScreen;
            designerForm.Show();
            ThemeResolutionService.ApplyThemeToControlTree(designerForm, this.ThemeName);
        }

        public void ApplyTheme(string themeName)
        {
            this.ThemeName = themeName;
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }
    }
}