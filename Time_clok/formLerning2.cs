using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_clok
{
    public partial class formLerning2 : Form
    {
        public formLerning2()
        {
            InitializeComponent();
        }

        private void formLerning2_Load(object sender, EventArgs e)
        {
            string sql = "select count(*) from Clock_Time";
            string result = DBConnction.runSQL(sql);
            MessageBox.Show(result);
        }
    }
}
