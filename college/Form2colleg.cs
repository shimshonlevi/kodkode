using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace college
{
    public partial class Form2colleg : Form
    {
        public List<Form2colleg> Forms2;
        public int Position;

        // קונסטרקטור שמקבל רשימה, מיקום וקטגוריה
        public Form2colleg(List<Form2colleg> form2, int position, string category)
        {
            InitializeComponent();
            Forms2 = form2;
            Position = position;
            /*lblCategory.Text = category; */// הנחת העבודה היא שיש תווית בשם 
        }
    }
}
