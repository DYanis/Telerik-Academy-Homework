using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name, bool isMale)
            : base(age, name, isMale)
        {
            this.IsMale = true;
        }

        public override void MakeSound()
        {
            Console.WriteLine("I'm a Tomcat !! ");
        }
    }
}
