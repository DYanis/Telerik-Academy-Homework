using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Person
    {
        string name;
        int? age;

        public Person(string n , int? age = null)
        {
            this.name = n;
            this.age = age;
        }

        public override string ToString()
        {
            if (this.age == null)
            {
                return this.name + " " + name + " years are not specified";
            }
            else
            {
                return this.name + " " + this.age;
            }
        }

        
    }
}
