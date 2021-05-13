using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Docking;
using System.Drawing;

namespace Telerik.Examples.WinControls.Docking.Programming
{
	class ProgrammableToolWnd : DockWindow
	{
        private GroupBox groupBox;
		private Button buttonUnpin;
		private Button buttonPin;
		private Button buttonFloat;
		private Button buttonClose;
		private Button buttonDock;

        private Dictionary<string, Button> actionButtons = new Dictionary<string, Button>();

		

		public ProgrammableToolWnd()
		{
			InitializeComponent();
            //this.Activated += new EventHandler(ProgrammableToolWnd_Activated);

            actionButtons.Add("Unpin", buttonUnpin);
            actionButtons.Add("Pin", buttonPin);
            actionButtons.Add("Float", buttonFloat);
            actionButtons.Add("Close", buttonClose);
            actionButtons.Add("Dock", buttonDock);
		}

        void ProgrammableToolWnd_Activated(object sender, EventArgs e)
        {
            //if (this.DockingSite != null && this.DockingSite.DockingSiteType == DockingSiteType.FloatingContainerSite)
            //{
            //    this.buttonFloat.Enabled = false;
            //    this.buttonDock.Enabled = true;
            //    this.buttonPin.Enabled = false;
            //    this.buttonUnpin.Enabled = false;
            //}
        }

		private void InitializeComponent()
		{
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonUnpin = new System.Windows.Forms.Button();
			this.buttonPin = new System.Windows.Forms.Button();
			this.buttonFloat = new System.Windows.Forms.Button();
			this.buttonDock = new System.Windows.Forms.Button();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox
			// 
			this.groupBox.Controls.Add(this.buttonClose);
			this.groupBox.Controls.Add(this.buttonUnpin);
			this.groupBox.Controls.Add(this.buttonPin);
			this.groupBox.Controls.Add(this.buttonFloat);
			this.groupBox.Controls.Add(this.buttonDock);
			this.groupBox.Location = new System.Drawing.Point(18, 16);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(140, 170);
			this.groupBox.TabIndex = 0;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "Select an action:";
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(30, 141);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 4;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonUnpin
			// 
			this.buttonUnpin.Location = new System.Drawing.Point(30, 111);
			this.buttonUnpin.Name = "buttonUnpin";
			this.buttonUnpin.Size = new System.Drawing.Size(75, 23);
			this.buttonUnpin.TabIndex = 3;
			this.buttonUnpin.Text = "Unpin";
			this.buttonUnpin.UseVisualStyleBackColor = true;
			this.buttonUnpin.Click += new System.EventHandler(this.buttonUnpin_Click);
			// 
			// buttonPin
			// 
			this.buttonPin.Enabled = false;
			this.buttonPin.Location = new System.Drawing.Point(30, 81);
			this.buttonPin.Name = "buttonPin";
			this.buttonPin.Size = new System.Drawing.Size(75, 23);
			this.buttonPin.TabIndex = 2;
			this.buttonPin.Text = "Pin";
			this.buttonPin.UseVisualStyleBackColor = true;
			this.buttonPin.Click += new System.EventHandler(this.buttonPin_Click);
			// 
			// buttonFloat
			// 
			this.buttonFloat.Location = new System.Drawing.Point(30, 51);
			this.buttonFloat.Name = "buttonFloat";
			this.buttonFloat.Size = new System.Drawing.Size(75, 23);
			this.buttonFloat.TabIndex = 1;
			this.buttonFloat.Text = "Float";
			this.buttonFloat.UseVisualStyleBackColor = true;
			this.buttonFloat.Click += new System.EventHandler(this.buttonFloat_Click);
			// 
			// buttonDock
			// 
			this.buttonDock.Enabled = false;
			this.buttonDock.Location = new System.Drawing.Point(30, 21);
			this.buttonDock.Name = "buttonDock";
			this.buttonDock.Size = new System.Drawing.Size(75, 23);
			this.buttonDock.TabIndex = 0;
			this.buttonDock.Text = "Dock";
			this.buttonDock.UseVisualStyleBackColor = true;
			this.buttonDock.Click += new System.EventHandler(this.buttonDock_Click);
			// 
			// ProgrammableToolWnd
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox);
			this.Location = new System.Drawing.Point(0, 26);
			this.Name = "ProgrammableToolWnd";
			this.Size = new System.Drawing.Size(184, 201);
			this.groupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private void buttonDock_Click(object sender, EventArgs e)
		{
			this.buttonFloat.Enabled = true;
			this.buttonDock.Enabled = false;
			this.buttonUnpin.Enabled = true;
		}

        private void buttonFloat_Click(object sender, EventArgs e)
        {
            this.buttonFloat.Enabled = false;
            this.buttonDock.Enabled = true;
            this.buttonPin.Enabled = false;
            this.buttonUnpin.Enabled = false;

            Rectangle rect = new Rectangle(Control.MousePosition, this.Size);
        }

		private void buttonPin_Click(object sender, EventArgs e)
		{
			this.buttonPin.Enabled = false;
			this.buttonUnpin.Enabled = true;
		}

		private void buttonUnpin_Click(object sender, EventArgs e)
		{
			this.buttonPin.Enabled = true;
			this.buttonUnpin.Enabled = false;
            this.buttonFloat.Enabled = false;
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{

		}

        public Button this[string buttonName]
        {
            get { return actionButtons[buttonName]; }
        }
	}
}
