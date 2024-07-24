using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lerning
{
    public partial class Form1 : Form
    {
        public DOG[] Dogs = new DOG[10];

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            float y;
            string z;
            x = 2;
            y = 2.4f;
            z = "a";

            Console.WriteLine((x + y + z).GetType());
            Console.WriteLine((y + z).GetType());
            Console.WriteLine((z + x).GetType());
            Console.WriteLine((x + y).GetType());
            Console.WriteLine((x + z + y).GetType());
            Console.WriteLine((z + y + x).GetType());
            Console.WriteLine((z + y).GetType());
            Console.WriteLine((x + z).GetType());
            Console.WriteLine((x + y).GetType());

            char d = 'a';
            int h = d;
            Console.WriteLine(h);
            Console.WriteLine(d);
            Console.WriteLine(h + d);
            
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DOG d1 = new DOG();
            DOG d2 = new DOG("chuppy");
            DOG d3 = new DOG("Doggy", 24.4f, 44.2f, "supper food");
            DOG d4 = new DOG();

            d4.Name = "Pitzi";
            d4.Height = 4.5f;
            Console.WriteLine(d3.Name);
            Console.WriteLine(d4.Food);
            Console.WriteLine(d4);

            d3.Size();
            d3.Run();
            d3.Pley();
            d3.Eite();
            d3.Chengename("gfdgddgd");
            Console.WriteLine(d4.Name);

        }

        private void btnrun_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dogs[0] = new DOG("hgf", 56, 656, "hfghgf");
        }

        private void btnage_Click(object sender, EventArgs e)
        {
            Person person1 = new Person();
            person1.Age = int.Parse(boxage.Text);
            
            
            
        }

        private void btnname_Click(object sender, EventArgs e)
        {
            Person person1 = new Person();
            person1.Name = boxrename.Text;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
             int[] ints = { 32,5,4,6,5,4};
            Array.Sort(ints);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            int[] MyArray = { 97, 95, 51, 67, 41, 87 };

            int evenNum = Array.Find(MyArray, n => n % 2 == 0);
            Console.WriteLine(evenNum);


        }
    }
}
