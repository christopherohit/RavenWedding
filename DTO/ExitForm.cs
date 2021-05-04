using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raven.DTO
{
    public class ExitForm
    {
        public void Message()
        {
            var mess = MessageBox.Show("Do you want to exit ?", "Warning" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
            if (mess == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
            else
            {

            }
        }
    }
}
