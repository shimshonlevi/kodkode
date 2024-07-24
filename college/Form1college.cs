using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college
{
    public partial class Form1college : Form
    {
        public Form1college()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<payment> forms = new List<payment>();

            List<string> categories = collegManiger.Getcourses(textBox1.Text);

            for (int i = 0; i < categories.Count; i++)
            {
                forms.Add(new payment(forms, i, textBox1.Text)); // שם הסטודנט מועבר כאן
            }

            forms[0].ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string studentName = textBox1.Text;
            string courseName = textBox2.Text;

            // קריאה לפונקציה במנהל הקולג' להוספת הקורס לסטודנט
            bool success = collegManiger.AddCourseToStudent(studentName, courseName);

            if (success)
            {
                // עדכון מסך והודעה למשתמש
                MessageBox.Show($"הקורס '{courseName}' נוסף לסטודנט '{studentName}' בהצלחה.");
                // כאן תעדכן את המסך בהתאם, לדוגמה על ידי רענון טבלה או עדכון תצוגה
            }
            else
            {
                MessageBox.Show("אירעה שגיאה בעת הוספת הקורס לסטודנט.");
            }
        }


        //private void Form1college_Load(object sender, EventArgs e)
        //{
        //    List<string> catagores = collegManiger.GetCatagores();
        //    for (int i = 0; i < catagores.Count; i++)
        //    {
        //        listBox1.Items.Add(catagores[i]);
        //    }
        //    listBox1.DoubleClick += (Sender, E) =>
        //    {
        //        string selectedItem = listBox1.SelectedItem.ToString();
        //        if (selectedItem == "") return;
        //        textBox1.Text = selectedItem;

        //    };
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<Form2colleg> forms = new List<Form2colleg>();

           
            List<string> catagores = collegManiger.Getcourses(textBox1.Text);

         
            for (int i = 0; i < catagores.Count; i++)
            {
                forms.Add(new Form2colleg(forms, i, catagores[i]));
            }

           
            forms[0].ShowDialog();

        }

        private void Form1college_Load(object sender, EventArgs e)
        {
            List<string> catagores = collegManiger.Getcourses(textBox1.Text);
            for (int i = 0; i < catagores.Count; i++)
            {
                listBox1.Items.Add(catagores[i]);
            }
            listBox1.DoubleClick += (Sender, E) =>
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                if (selectedItem == "") return;
                textBox2.Text = selectedItem;

            };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = collegManiger.GetsobjectByCours(textBox2.Text);

            List<string> catagores = collegManiger.GetcoursesByString(textBox2.Text);
            listBox1.Items.Clear();
            for (int i = 0; i < catagores.Count; i++)
            {
                listBox1.Items.Add(catagores[i]);
            }

        }

        
    }
}
