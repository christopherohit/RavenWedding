using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raven
{
    public partial class LoadingSignUp : Form
    {
        public LoadingSignUp()
        {
            InitializeComponent();
            Endless();
        }
        private void Endless()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                switch (i)
                {
                    case 20:
                        panel2.Hide();
                        break;
                    case 40:
                        panel8.Hide();
                        break;
                    case 60:
                        panel6.Hide();
                        break;
                    case 70:
                        panel3.Hide();
                        break;
                    case 80:
                        panel7.Hide();
                        break;
                    case 100:
                        panel5.Hide();
                        break;
                }
            }
            Thread.Sleep(200);
            SignUp ui = new SignUp();
            ui.Show();
            this..Hide();
        }
    }
}
