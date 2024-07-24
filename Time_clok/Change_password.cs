using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_clock;

namespace Time_clok
{
    public partial class Change_password : Form
    {
        public Change_password()
        {
            InitializeComponent();
        }

        private void boxold_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string result = EmployeeManger.ChangePassword(boxId.Text, boxoldPassword.Text, boxnewPassword.Text, boxokPassword.Text);
            MessageBox.Show(result);
        }
    }
}
