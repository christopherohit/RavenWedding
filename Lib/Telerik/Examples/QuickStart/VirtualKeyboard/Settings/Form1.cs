using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.VirtualKeyboard;

namespace Telerik.Examples.WinControls.VirtualKeyboard.Settings
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            this.InitializeComponent();
            this.AddDropDownItems();
            this.CenterPanel = true;
            this.radVirtualKeyboard1.Focusable = true;
            this.radRadioButtonDvorak.IsChecked = true;

            this.radCheckBoxScaleFont.ButtonElement.ToolTipText = "Determines whether the Font of keys will be scaled when the keyboard control is resized to a different from the default key size.";
        }

        private void AddDropDownItems()
        {
            for (float i = 0.75f; i <= 2f; i += 0.25f)
            {
                RadListDataItem item = new RadListDataItem(i.ToString(), i);
                this.radDropDownListScaleFactor.Items.Add(item);
            }

            this.radDropDownListScaleFactor.SelectedValue = 1f;
        }

        private void RadCheckBoxScaleFont_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualKeyboard1.ScaleFontOnResize = this.radCheckBoxScaleFont.IsChecked;
            this.AutoSizeKeyboard();
        }

        private void RadCheckBoxSyncWithSystem_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualKeyboard1.SynchronizeCultureWithSystem = this.radCheckBoxSyncWithSystem.IsChecked;
        }

        private void RadButtonClear_Click(object sender, EventArgs e)
        {
            this.radListControlSentKeys.Items.Clear();
        }

        private void RadVirtualKeyboard1_KeySending(object sender, VirtualKeyboardKeySendingEventArgs e)
        {
            RadListDataItem item = new RadListDataItem();
            string text = (e.Key as RadItem).Text;
            item.Text = string.Format("Key sending: Key: {0} | Code:{1}", text, e.VirtualKey);
            this.radListControlSentKeys.Items.Add(item);
            this.radListControlSentKeys.ScrollToItem(item);

            if (e.VirtualKey == (int)Keys.Enter)
            {
                e.Cancel = true;
                item = new RadListDataItem();
                item.Text = string.Format("Key {0} cancelled.", text);
                this.radListControlSentKeys.Items.Add(item);
                this.radListControlSentKeys.ScrollToItem(item);
            }
        }

        private void RadVirtualKeyboard1_KeySent(object sender, VirtualKeyboardKeySentEventArgs e)
        {
            RadListDataItem item = new RadListDataItem();
            item.Text = string.Format("Key sent: Key: {0} | Code:{1}", (e.Key as RadItem).Text, e.VirtualKey);
            this.radListControlSentKeys.Items.Add(item);
            this.radListControlSentKeys.ScrollToItem(item);
        }

        RadRadioButton checkedButton = null;
        private void RadRadioButtonDvorak_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (!this.radRadioButtonDvorak.IsChecked)
            {
                return;
            }

            string file = this.GetType().Namespace + ".dvorak-layout.xml";
            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream(file))
            {
                this.radVirtualKeyboard1.LoadLayout(stream);
                this.radVirtualKeyboard1.ScaleFontOnResize = this.radCheckBoxScaleFont.IsChecked;
                this.AutoSizeKeyboard();
            }

            this.radLabelLayoutType.Text = "Dvorak Layout";
            this.checkedButton = sender as RadRadioButton;
        }

        private void RadRadioButtonColemak_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (!this.radRadioButtonColemak.IsChecked)
            {
                return;
            }

            string file = this.GetType().Namespace + ".colemak-layout.xml";
            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream(file))
            {
                this.radVirtualKeyboard1.LoadLayout(stream);
                this.radVirtualKeyboard1.ScaleFontOnResize = this.radCheckBoxScaleFont.IsChecked;
                this.AutoSizeKeyboard();
            }

            this.radLabelLayoutType.Text = "Colemak Layout";
            this.checkedButton = sender as RadRadioButton;
        }

        private void RadRadioButtonExtended_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (!this.radRadioButtonExtended.IsChecked)
            {
                return;
            }

            this.radVirtualKeyboard1.LayoutType = KeyboardLayoutType.Extended;
            this.AutoSizeKeyboard();
            this.radLabelLayoutType.Text = "Extended Layout";
            this.checkedButton = sender as RadRadioButton;
        }

        private void RadRadioButtonSimplified_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (!this.radRadioButtonSimplified.IsChecked)
            {
                return;
            }

            this.radVirtualKeyboard1.LayoutType = KeyboardLayoutType.Simplified;
            this.AutoSizeKeyboard();
            this.radLabelLayoutType.Text = "Simplified Layout";

            this.checkedButton = sender as RadRadioButton;
        }

        private void RadRadioButtonNumpad_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (!this.radRadioButtonNumpad.IsChecked)
            {
                return;
            }

            this.radVirtualKeyboard1.LayoutType = KeyboardLayoutType.Numpad;
            this.AutoSizeKeyboard();
            this.radLabelLayoutType.Text = "Numpad Layout";
            this.checkedButton = sender as RadRadioButton;
        }

        private void RadButtonSaveLayout_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML Files | *.xml";
            dialog.DefaultExt = "xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radVirtualKeyboard1.SaveLayout(dialog.FileName);
            }
        }

        private void RadButtonLoadLayout_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML Files | *.xml";
            dialog.DefaultExt = "xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radVirtualKeyboard1.LoadLayout(dialog.FileName);
                this.radVirtualKeyboard1.ScaleFontOnResize = this.radCheckBoxScaleFont.IsChecked;
                this.AutoSizeKeyboard();
                if (this.checkedButton != null)
                {
                    this.checkedButton.IsChecked = false;
                    this.checkedButton = null;
                }

                this.radLabelLayoutType.Text = "Custom Layout";
            }
        }

        private void AutoSizeKeyboard()
        {
            Size newSize = this.radVirtualKeyboard1.CalculateDesiredSize().ToSize();
            float scaleFactor = (float)this.radDropDownListScaleFactor.SelectedValue;
            newSize = new SizeF(newSize.Width * scaleFactor, newSize.Height * scaleFactor).ToSize();

            newSize.Height += this.radLabelLayoutType.Height;
            this.radPanelDemoHolder.Size = newSize;
            this.CenterControl();
        }

        private void RadDropDownListScaleFactor_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.AutoSizeKeyboard();
        }
    }
}