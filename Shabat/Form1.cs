using Shabatst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnAddHost_Click(object sender, EventArgs e)
        {
            string addtolist = tbHost.Text;
            listBox1.Items.Add(addtolist);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> catagores = HostMenger.GetCatagores();
            for (int i = 0; i < catagores.Count; i++)
            {
                listBox1.Items.Add(catagores[i]);
            }
            listBox1.DoubleClick += (Sender, E) =>
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                if (selectedItem == "") return;
                tbHost.Text = selectedItem;

            };
        }

        private void tbHost_TextChanged(object sender, EventArgs e)
        {
            List<string> catagores = HostMenger.GetCatogoryByString(tbHost.Text);
            listBox1.Items.Clear();
            for (int i = 0; i < catagores.Count; i++)
            {
                listBox1.Items.Add(catagores[i]);
            }
           
        }

      
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            HostMenger.AddCatagory(tbHost.Text);
               List<string> categores = HostMenger.GetCatagores();
            int i = 0;
            listBox1.Items.Clear();
            while (i < categores.Count())
            {
                listBox1.Items.Add(i + 1 + ")" + categores[i]);
                i++;
            }
            tbHost.Text = null;
            

        }

        private void btnVieuHost_Click(object sender, EventArgs e)
        {
            List<Form2> forms = new List<Form2>();
            List<string> catagores = HostMenger.GetCatagores();
            for(int i = 0; i< catagores.Count; i++)
            {
                forms.Add(new Form2(forms,i,catagores[i]));
                
            }
            forms[0].ShowDialog();

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        /////////////////////////////////////////////////////////
    }
}
