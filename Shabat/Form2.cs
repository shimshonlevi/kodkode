using Shabatst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace host
{
    public partial class Form2 : Form
    {
        public List<Form2> Forms2;
        public int Position;

        //
        
        //
        public Form2(List<Form2> form2, int position,string catagores)
        {
            InitializeComponent();
            Forms2 = form2;
            Position = position;
            lblCatagory.Text = catagores;


        }

        private void dgvOrtherList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvOrtherList.DataSource = HostMenger.GetFoodByCtgr(lblCatagory.Text);
         



            

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // הסתר את הטופס הנוכחי
            Forms2[Position].Visible = false;

            // עדכן את המיקום הנוכחי (Position) בצורה מעגלית

            // הצג את הטופס הבא ברשימה
            Forms2[(Position + 1) % Forms2.Count].Visible = true;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (Position >= 0 && Position < Forms2.Count() - 1)
            {
                Forms2[Position + 1].Visible = true;
            }
            else
            {
                Forms2[0].Visible = true;

            }

        }
    }
}
