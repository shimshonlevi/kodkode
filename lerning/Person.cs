using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerning
{
    internal class Person
    {
        public Person()
        { 

        }
        
        private int _age;
        private string _name;

        public int Age
        

        {
            get { return _age; }
            set
            {
                if (value > 120 || value < 0)
                {
                    Console.WriteLine("Error Age must be brtween 0 and 120" + value);
                }
                else
                {
                    _age = value;
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    Console.WriteLine("Error must be upper" + value);
                }
                else
                {
                    _name = value;
                }
            }
        }

       




    }
}
