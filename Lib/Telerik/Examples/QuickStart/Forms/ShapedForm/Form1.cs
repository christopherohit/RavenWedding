using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Tests;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Forms.ShapedForm
{
    public partial class Form1 : ExamplesForm
    {
        private CustomShapedForm shapedForm = null;
        private RadTitleBar titleBar = new RadTitleBar();

        public Form1()
        {
            InitializeComponent();

            CreateShapedForm();

            this.radRadioRound.ToggleState = ToggleState.On;
            this.Disposed += new EventHandler(Form1_Disposed);
        }

        void Form1_Disposed(object sender, EventArgs e)
        {
            this.shapedForm.Dispose();
        }

        private void CenterFormInPanel()
        {
            this.shapedForm.Location = new Point(this.radPanel1.Width / 2 - this.shapedForm.Width / 2, this.radPanel1.Height / 2 - this.shapedForm.Height / 2);
        }

        private void CenterFormOnScreen()
        {
            this.shapedForm.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.shapedForm.Width / 2,
                                                 Screen.PrimaryScreen.Bounds.Height / 2 - this.shapedForm.Height / 2);
        }

        private Image LoadImage(string name)
        {
            Stream stream = Assembly.GetAssembly(this.GetType()).GetManifestResourceStream(name);
            if (stream == null)
            {
                throw new NullReferenceException("Cannot find " + name);
            }
            return new Bitmap(stream);
        }

        private void CreateShapedForm()
        {
            this.shapedForm = new CustomShapedForm();
            
            this.shapedForm.FormClosing += new FormClosingEventHandler(shapedForm_FormClosing);
            this.shapedForm.Name = "InnerForm";
            this.shapedForm.Width = 200;
            this.shapedForm.Height = 100;
            this.shapedForm.TopLevel = false;
            this.shapedForm.BackColor = Color.LightGray;
            this.shapedForm.BorderColor = Color.DarkGray;
            this.shapedForm.Controls.Add(this.titleBar);
            this.titleBar.Dock = DockStyle.Top;
            this.titleBar.AutoSize = true;
            this.titleBar.RootElement.StretchHorizontally = true;
            this.titleBar.RootElement.StretchVertically = false;
            this.titleBar.RootElement.SaveCurrentStretchModeAsDefault();
            this.radPanel1.Controls.Add(shapedForm);

            CenterFormInPanel();

            this.shapedForm.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        void shapedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        #region Event Handlers

        private void radRadioButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.shapedForm.Hide();
            this.shapedForm.Controls.Clear();
            if (this.radRadioRound.ToggleState == ToggleState.On)
            {
                this.shapedForm.BackgroundImage = null;
                this.shapedForm.Shape = new RoundRectShape();
                this.shapedForm.Size = new Size(200, 100);
                
                this.shapedForm.Controls.Add(titleBar);
                this.titleBar.Dock = DockStyle.Top;
                this.titleBar.AutoSize = true;
                this.titleBar.RootElement.StretchHorizontally = true;
                this.titleBar.RootElement.StretchVertically = false; 
                this.titleBar.RootElement.SaveCurrentStretchModeAsDefault();
            }

            if (this.radRadioCD.ToggleState == ToggleState.On)
            {
                this.shapedForm.SuspendLayout();
                DonutShape s = new DonutShape();
                s.Thickness += 85; // Magic, makes the form look like a CD.
                this.shapedForm.Shape = s;
                this.shapedForm.Size = new Size(280, 280);
                this.shapedForm.BackgroundImage = LoadImage("Telerik.Examples.WinControls.Forms.ShapedForm.label.png");
                CenterFormInPanel();
            }

            if (this.shapedForm.Parent == null)
            {
                CenterFormOnScreen();
            }
            else
            {
                CenterFormInPanel();
            }

            this.shapedForm.Invalidate();
            this.shapedForm.Show();
        }

        private void radButtonPop_Click(object sender, EventArgs e)
        {
            if (this.shapedForm.TopLevel)
            {
                this.shapedForm.TopLevel = false;
                this.shapedForm.Parent = this.radPanel1;
                this.radButtonPop.Text = "Pop Form Out";
                CenterFormInPanel();
            }
            else
            {
                this.shapedForm.WindowState = FormWindowState.Normal;
                this.shapedForm.Parent = null;
                this.shapedForm.TopLevel = true;
                this.radButtonPop.Text = "Push Form In";
                CenterFormOnScreen();
            }
        }

        private void radButtonCreate_Click(object sender, EventArgs e)
        {
            CustomShapeEditorForm shapeEditor = new CustomShapeEditorForm();
            CustomShape s = shapeEditor.CreateShape();

            if (s != null)
            {
                this.shapedForm.Controls.Clear();
                this.shapedForm.Shape = s;
            }

            this.shapedForm.Invalidate();
        }
        #endregion

        protected override void WireEvents()
        {
            this.radRadioCD.ToggleStateChanged += new StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            this.radButtonCreate.Click += new EventHandler(this.radButtonCreate_Click);
            this.radRadioRound.ToggleStateChanged += new StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            this.radButtonPop.Click += new EventHandler(this.radButtonPop_Click);
        }
    }

    class CustomShapedForm : Telerik.WinControls.UI.ShapedForm
    {
        public CustomShapedForm()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint , true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
