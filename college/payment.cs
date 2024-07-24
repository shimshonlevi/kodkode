using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace college
{
    public partial class payment : Form
    {
        public List<payment> Forms3;
        public int Position;
        private string studentName;

        public payment(List<payment> forms3, int position, string studentName)
        {
            InitializeComponent();
            Forms3 = forms3;
            Position = position;
            this.studentName = studentName;
            label2.Text = studentName; 
        }

        private void payment_Load(object sender, EventArgs e)
        {
            List<string> courses = collegManiger.GetStudentCourses(label2.Text);
            listBox1.Items.Clear();
            foreach (var course in courses)
            {
                listBox1.Items.Add(course);
                label6.Text = 
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
