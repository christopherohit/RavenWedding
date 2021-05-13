using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.UseCustomEditors
{
    public class BrowseEditor : BaseGridEditor
    {
        string filter;
        bool endEditOnLostFocus = true;

        public override object Value
        {
            get
            {
                BrowseEditorElement editor = (BrowseEditorElement)this.EditorElement;
                return editor.TextBox.Text;
            }
            set
            {
                BrowseEditorElement editor = (BrowseEditorElement)this.EditorElement;
                if (value != null && value != DBNull.Value)
                {
                    editor.TextBox.Text = value.ToString();
                }
                else
                {
                    editor.TextBox.Text = "";
                }
            }
        }

        public override bool EndEditOnLostFocus
        {
            get { return endEditOnLostFocus; }
        }

        public string Filter
        {
            get { return filter; }
            set { filter = value; }
        }

        public override void Initialize(object owner, object value)
        {
            base.Initialize(owner, value);

            this.Filter = "JPEG files|*.jpg|All files|*.*";
        }

        public override void BeginEdit()
        {
            base.BeginEdit();
            BrowseEditorElement editor = (BrowseEditorElement)this.EditorElement;
            editor.TextBox.SelectAll();
            editor.TextBox.HostedControl.Focus();
            editor.TextBox.TextChanging += new TextChangingEventHandler(TextBox_TextChanging);
            editor.TextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            editor.TextBox.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            editor.Button.Click += new EventHandler(Button_Click);
            
        }

        public override bool EndEdit()
        {
            BrowseEditorElement editor = (BrowseEditorElement)this.EditorElement;
            editor.TextBox.TextChanging -= new TextChangingEventHandler(TextBox_TextChanging);
            editor.TextBox.TextChanged -= new EventHandler(TextBox_TextChanged);
            editor.TextBox.KeyDown -= new KeyEventHandler(TextBox_KeyDown);
            editor.Button.Click -= new EventHandler(Button_Click);
            return base.EndEdit();
        }

        protected override RadElement CreateEditorElement()
        {
            return new BrowseEditorElement();
        }

        void TextBox_TextChanging(object sender, TextChangingEventArgs e)
        {
            ValueChangingEventArgs args = new ValueChangingEventArgs(e.NewValue);
            args.OldValue = e.OldValue;
            OnValueChanging(args);
            e.Cancel = args.Cancel;
        }

        void TextBox_TextChanged(object sender, EventArgs e)
        {
            OnValueChanged();
        }

        void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            RadGridView grid = ((RadElement)sender).ElementTree.Control as RadGridView;
            if (grid != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                    case Keys.Enter:
                    case Keys.Up:
                    case Keys.Down:
                        grid.GridBehavior.ProcessKeyDown(e);
                        break;
                }
            }
        }

        void Button_Click(object sender, EventArgs e)
        {
            endEditOnLostFocus = false;
            BrowseEditorElement editor = (BrowseEditorElement)this.EditorElement;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = filter;
            dialog.FileName = editor.TextBox.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                editor.TextBox.Text = dialog.FileName;
            }
            //editor.TextBox.SelectAll();
            //editor.TextBox.Focus();
            endEditOnLostFocus = true;
            ((RadGridView)editor.ElementTree.Control).EndEdit();
        }

        public override Type DataType
        {
            get
            {
                return typeof(string);
            }
        }       
    }
}
