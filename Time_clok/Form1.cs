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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void boxname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                boxpassword.Focus();
                // הקוד שיופעל כאשר נלחץ ENTER
                //string result = EmployeeManger.Login(boxname.Text, boxpassword.Text);
                //MessageBox.Show(result);

            }

        }

        private void boxpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                string result = EmployeeManger.Login(boxId.Text, boxpassword.Text);
                MessageBox.Show(result);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change_password form2 = new Change_password(); // יצירת מופע של Change_password
            form2.ShowDialog(); // הצגת הטופס Change_password
            // הסתרת Form1
        }

        private void boxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
