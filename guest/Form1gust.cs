using guest;
using Shabat;
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

namespace guest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // אירוע שמתרחש כאשר לוחצים על התווית (כרגע אין בו פעולות)
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // אירוע שמתרחש כאשר לוחצים על הכפתור להוספת אורח
        private void btnGuestAdd_Click(object sender, EventArgs e)
        {
            // מוסיף את הטקסט מהטקסטבוקס לרשימת הפריטים ב-ListBox
            string addtolist = textBox1.Text;
            listBox1.Items.Add(addtolist);
        }

        // אירוע שמתרחש כאשר נבחר פריט ב-ListBox (כרגע אין בו פעולות)
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // אירוע שמתרחש כאשר הטופס נטען
        private void Form1_Load(object sender, EventArgs e)
        {
            // מקבל את רשימת הקטגוריות ומוסיף אותן ל-ListBox
            List<string> catagores = guostMeniger.GetCatagores();
            for (int i = 0; i < catagores.Count; i++)
            {
                listBox1.Items.Add(catagores[i]);
            }

            // אירוע שמתרחש כאשר לוחצים פעמיים על פריט ב-ListBox
            listBox1.DoubleClick += (Sender, E) =>
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                if (selectedItem == "") return;
                textBox1.Text = selectedItem; // מעביר את הטקסט של הפריט שנבחר ל-TextBox
            };
        }

        // אירוע שמתרחש כאשר הטקסט בטקסטבוקס משתנה
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // מקבל את רשימת הקטגוריות שמכילות את הטקסט הנוכחי בטקסטבוקס ומעדכן את ה-ListBox
            List<string> catagores = guostMeniger.GetCatogoryByString(textBox1.Text);
            listBox1.Items.Clear();
            for (int i = 0; i < catagores.Count; i++)
            {
                listBox1.Items.Add(catagores[i]);
            }
        }

        // אירוע שמתרחש כאשר לוחצים על הכפתור להוספת אורח (גרסה שנייה)
        private void btnGuestAdd_Click_1(object sender, EventArgs e)
        {
            // יוצר רשימה של טפסים מסוג Form2 לכל קטגוריה
            List<Form2> forms = new List<Form2>();
            List<string> catagores = guostMeniger.GetCatagores();
            for (int i = 0; i < catagores.Count; i++)
            {
                forms.Add(new Form2(forms, i, catagores[i]));
            }
            forms[0].ShowDialog(); // מציג את הטופס הראשון ברשימה
        }

        // אירוע שמתרחש כאשר נבחר פריט ב-ListBox (גרסה שנייה, כרגע אין בו פעולות)
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        /////////////////////////////////////////////////////////
    }
}
