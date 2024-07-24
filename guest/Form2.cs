using Shabat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guest
{
    public partial class Form2 : Form
    {
        // רשימה של כל הטפסים מסוג Form2
        public List<Form2> Forms2;
        // משתנה לשמירת המיקום הנוכחי ברשימת הטפסים
        public int Position;

        // הבנאי של הטופס
        public Form2(List<Form2> form2, int position, string catagores)
        {
            InitializeComponent();
            // שמירת רשימת הטפסים והעמדה הנוכחית
            Forms2 = form2;
            Position = position;
            // הצגת שם הקטגוריה בלייבל
            lblguestname.Text = catagores;
        }

        // אירוע שמתבצע בעת טעינת הטופס
        private void Form2_Load(object sender, EventArgs e)
        {
            // הגדרת מקור הנתונים של DataGridView1 על פי הקטגוריה
            dataGridView1.DataSource = guostMeniger.GetFoodByCtgr(lblguestname.Text);
            // הגדרת מקור הנתונים של DataGridView2 על פי הקטגוריה
            dataGridView2.DataSource = guostMeniger.GetFoodByName(lblguestname.Text);
        }

        // אירוע שמתבצע בעת לחיצה על כפתור "הבא"
        private void btnNext_Click(object sender, EventArgs e)
        {
            // הסתרת הטופס הנוכחי
            Forms2[Position].Visible = false;

            // עדכון המיקום הנוכחי בטפסים בצורה מעגלית והצגת הטופס הבא
            Forms2[(Position + 1) % Forms2.Count].Visible = true;
        }

        // אירוע שמתבצע בעת לחיצה על כפתור "ראשון"
        private void btnFirst_Click(object sender, EventArgs e)
        {
            // הסתרת הטופס הנוכחי
            this.Visible = false;

            // אם המיקום הנוכחי הוא בטווח החוקי, הצגת הטופס הבא
            if (Position >= 0 && Position < Forms2.Count() - 1)
            {
                Forms2[Position + 1].Visible = true;
            }
            // אחרת, הצגת הטופס הראשון
            else
            {
                Forms2[0].Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
