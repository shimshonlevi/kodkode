using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerning
{
    public class DOG
    {
        public string Name;
        public float Weight;
        public float Height;
        public string Food;


        public DOG() { }
        public DOG(string name)
        {
            Name = name;
        }
        public DOG(string name, float weight, float height, string food)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Food = food;
        }

        public void Size()
        {
            Console.WriteLine("Height" + Height + "Weight" + Weight);
        }
        public void Run()
        {
            Console.WriteLine(Name + "is ruinge");
        }
        public void Pley()
        {
            Console.WriteLine(Name + "is pleinge");
        }
        public void Eite()
        {
            Console.WriteLine(Name + "is eiting" + Food);
        }
        public void Chengename(string name)
        {
            Name = name;
        }
        public string GetValus()
        {
            return Name + ";" + Height + ";" + Weight;
        }
        

        
    }

}
