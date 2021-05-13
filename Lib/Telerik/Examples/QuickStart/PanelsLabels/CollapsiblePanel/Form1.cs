using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PanelsLabels.CollapsiblePanel
{
    public partial class Form1 : ExamplesForm
    {
        private Dictionary<string, RadDirection> expandDirectionMap = new Dictionary<string, RadDirection>();
        private Dictionary<string, CollapsiblePanelContentSizingMode> contentSizingModeMap = new Dictionary<string, CollapsiblePanelContentSizingMode>();
        private Dictionary<string, RadHorizontalAlignment> horizontalHeaderAlignmentMap = new Dictionary<string, RadHorizontalAlignment>();
        private Dictionary<string, RadVerticalAlignment> verticalHeaderAlignmentMap = new Dictionary<string, RadVerticalAlignment>();
        private Dictionary<string, CollapsiblePanelAnimationType> animationTypeMap = new Dictionary<string, CollapsiblePanelAnimationType>();
        private Dictionary<string, RadEasingType> animationEasingTypeMap = new Dictionary<string, RadEasingType>();

        private Size initialCollapsiblePanelSize;

        public Form1()
        {
            this.InitializeComponent();
            this.InitializeExpandDirection();
            this.InitializeContentSizingMode();
            this.InitializeAnimations();
            this.InitializeHorizontalHeaderAlignment();
            this.InitializeVerticalHeaderAlignment();
            this.InitializeAnimationTypes();
            this.InitializeAnimationEasingTypes();
            this.InitializePeopleInfo();

            this.radPanelDemoHolder.PanelElement.PanelBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radCollapsiblePanel1.HeaderText = "RadCollapsiblePanel Example";

            this.SizeChanged += Form1_SizeChanged;
        }

        void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width <= initialCollapsiblePanelSize.Width + 10 || this.Size.Height <= initialCollapsiblePanelSize.Height + 10)
            {
                this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            }
            else
            {
                this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
                this.radCollapsiblePanel1.Size = this.initialCollapsiblePanelSize;
                this.radCollapsiblePanel1.CollapsiblePanelElement.InvalidateMeasure(true);
            }
        }
        
        private void InitializePeopleInfo()
        {
            this.personInfoControl1.PersonName = "Bob Smiil";
            this.personInfoControl1.PersonEmail = "BobSmiil@mail.com";
            this.personInfoControl1.PersonPhone = "Phone: 33 2334";
            this.personInfoControl1.PersonImage = Properties.Resources.BobSmill;

            this.personInfoControl2.PersonName = "Andew Fuller";
            this.personInfoControl2.PersonEmail = "AndewFuller@mail.com";
            this.personInfoControl2.PersonPhone = "Phone: 55 1571";
            this.personInfoControl2.PersonImage = Properties.Resources.AndrewFuller;

            this.personInfoControl3.PersonName = "Anne Dodsworth";
            this.personInfoControl3.PersonEmail = "Dodsworth@mail.com";
            this.personInfoControl3.PersonPhone = "Phone: 32 1342";
            this.personInfoControl3.PersonImage = Properties.Resources.AnneDodsworth;

            this.personInfoControl4.PersonName = "Emily Smile";
            this.personInfoControl4.PersonEmail = "SmileEmily@mail.com";
            this.personInfoControl4.PersonPhone = "Phone: 95 2513";
            this.personInfoControl4.PersonImage = Properties.Resources.EmilySmile;
        }

        private void InitializeAnimationEasingTypes()
        {
            this.MapEnumToDictionary<RadEasingType>(this.animationEasingTypeMap);
            this.animationEasingTypeDropDownList.DataSource = this.animationEasingTypeMap.Keys;
        }

        private void InitializeAnimationTypes()
        {
            this.MapEnumToDictionary<CollapsiblePanelAnimationType>(this.animationTypeMap);
            this.animationTypeDropDownList.DataSource = this.animationTypeMap.Keys;
        }

        private void InitializeVerticalHeaderAlignment()
        {
            this.MapEnumToDictionary<RadVerticalAlignment>(this.verticalHeaderAlignmentMap);
            this.verticalHeaderAlignmentDropDownList.DataSource = this.verticalHeaderAlignmentMap.Keys;
        }

        private void InitializeHorizontalHeaderAlignment()
        {
            this.MapEnumToDictionary<RadHorizontalAlignment>(this.horizontalHeaderAlignmentMap);
            this.horizontalHeaderAlignmentDropDownList.DataSource = this.horizontalHeaderAlignmentMap.Keys;
        }
        
        private void InitializeAnimations()
        {
            this.enableAnimationCheckBox.Checked = true;

            this.animationFramesSpinEditor.Value = this.radCollapsiblePanel1.AnimationFrames;
            this.animationFramesSpinEditor.Maximum = int.MaxValue;
            this.animationFramesSpinEditor.Minimum = int.MinValue;

            this.animationIntervalSpinEditor.Value = this.radCollapsiblePanel1.AnimationInterval;
            this.animationIntervalSpinEditor.Maximum = int.MaxValue;
            this.animationIntervalSpinEditor.Minimum = int.MinValue;
        }

        void animationIntervalSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.radCollapsiblePanel1.AnimationInterval = (int)this.animationIntervalSpinEditor.Value;
        }

        void animationFramesSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.radCollapsiblePanel1.AnimationFrames = (int)this.animationFramesSpinEditor.Value;
        }

        private void InitializeContentSizingMode()
        {
            this.MapEnumToDictionary<CollapsiblePanelContentSizingMode>(this.contentSizingModeMap);
            this.contentSizingModeMap["Both"] = CollapsiblePanelContentSizingMode.FitToContentHeight | CollapsiblePanelContentSizingMode.FitToContentWidth;
            this.contentSizingModeDropDownList.DataSource = this.contentSizingModeMap.Keys;
        }
  
        private void InitializeExpandDirection()
        {
            this.MapEnumToDictionary<RadDirection>(this.expandDirectionMap);
            this.expandDirectionDropDownList.DataSource = this.expandDirectionMap.Keys;
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.expandDirectionDropDownList.SelectedValueChanged += expandDirectionDropDownList_SelectedValueChanged;
            this.contentSizingModeDropDownList.SelectedValueChanged += contentSizingModeDropDownList_SelectedValueChanged;
            this.enableAnimationCheckBox.ToggleStateChanged += enableAnimationCheckBox_ToggleStateChanged;
            this.showHeaderLineCheckBox.ToggleStateChanged += showHeaderLineCheckBox_ToggleStateChanged;
            this.animationFramesSpinEditor.ValueChanged += animationFramesSpinEditor_ValueChanged;
            this.animationIntervalSpinEditor.ValueChanged += animationIntervalSpinEditor_ValueChanged;
            this.horizontalHeaderAlignmentDropDownList.SelectedValueChanged += horizontalHeaderAlignmentDropDownList_SelectedValueChanged;
            this.verticalHeaderAlignmentDropDownList.SelectedValueChanged += verticalHeaderAlignmentDropDownList_SelectedValueChanged;
            this.rightToLeftCheckBox.ToggleStateChanged += rightToLeftCheckBox_ToggleStateChanged;
            this.animationTypeDropDownList.SelectedValueChanged += animationTypeDropDownList_SelectedValueChanged;
            this.animationEasingTypeDropDownList.SelectedValueChanged += animationEasingTypeDropDownList_SelectedValueChanged;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.expandDirectionDropDownList.SelectedValue = this.radCollapsiblePanel1.ExpandDirection.ToString();
            this.contentSizingModeDropDownList.SelectedValue = this.radCollapsiblePanel1.ContentSizingMode.ToString();
            this.horizontalHeaderAlignmentDropDownList.SelectedValue = this.radCollapsiblePanel1.HorizontalHeaderAlignment.ToString();
            this.verticalHeaderAlignmentDropDownList.SelectedValue = this.radCollapsiblePanel1.VerticalHeaderAlignment.ToString();
            this.animationTypeDropDownList.SelectedValue = this.radCollapsiblePanel1.AnimationType.ToString();
            this.animationEasingTypeDropDownList.SelectedValue = this.radCollapsiblePanel1.AnimationEasingType.ToString();

            this.initialCollapsiblePanelSize = this.radCollapsiblePanel1.Size;
        }

        void animationEasingTypeDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.animationEasingTypeMap.ContainsKey(this.animationEasingTypeDropDownList.SelectedItem.Text))
            {
                this.radCollapsiblePanel1.AnimationEasingType = this.animationEasingTypeMap[this.animationEasingTypeDropDownList.SelectedItem.Text];
            }
        }

        void animationTypeDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.animationTypeMap.ContainsKey(this.animationTypeDropDownList.SelectedItem.Text))
            {
                this.radCollapsiblePanel1.AnimationType = this.animationTypeMap[this.animationTypeDropDownList.SelectedItem.Text];
            }
        }

        private void rightToLeftCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radCollapsiblePanel1.CollapsiblePanelElement.RightToLeft = this.rightToLeftCheckBox.Checked;
        }

        private void verticalHeaderAlignmentDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.verticalHeaderAlignmentMap.ContainsKey(this.verticalHeaderAlignmentDropDownList.SelectedItem.Text))
            {
                this.radCollapsiblePanel1.VerticalHeaderAlignment = this.verticalHeaderAlignmentMap[this.verticalHeaderAlignmentDropDownList.SelectedItem.Text];
            }
        }

        private void horizontalHeaderAlignmentDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.horizontalHeaderAlignmentMap.ContainsKey(this.horizontalHeaderAlignmentDropDownList.SelectedItem.Text))
	        {
                this.radCollapsiblePanel1.HorizontalHeaderAlignment = this.horizontalHeaderAlignmentMap[this.horizontalHeaderAlignmentDropDownList.SelectedItem.Text];
	        }
        }

        private void showHeaderLineCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radCollapsiblePanel1.ShowHeaderLine = this.showHeaderLineCheckBox.Checked;
        }

        private void contentSizingModeDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.contentSizingModeMap.ContainsKey(this.contentSizingModeDropDownList.SelectedItem.Text))
            {
                this.radCollapsiblePanel1.ContentSizingMode = this.contentSizingModeMap[this.contentSizingModeDropDownList.SelectedItem.Text];
            }
        }

        private void enableAnimationCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            bool enableAnimation = this.enableAnimationCheckBox.Checked;
            this.radCollapsiblePanel1.EnableAnimation = enableAnimation;
            this.animationFramesSpinEditor.Enabled = enableAnimation;
            this.animationIntervalSpinEditor.Enabled = enableAnimation;
        }

        private void expandDirectionDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.expandDirectionMap.ContainsKey(this.expandDirectionDropDownList.SelectedItem.Text))
            {
                this.radCollapsiblePanel1.ExpandDirection = this.expandDirectionMap[this.expandDirectionDropDownList.SelectedItem.Text];
            }
        }

        private void MapEnumToDictionary<T>(Dictionary<string, T> map)
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException(string.Format("T must be of type {0}, it is of type {1} instead", typeof(Enum), typeof(T)));
            }

            Array enumItems = Enum.GetValues(typeof(T));
            foreach (T item in enumItems)
            {
                map[item.ToString()] = item;
            }
        }
    }
}
