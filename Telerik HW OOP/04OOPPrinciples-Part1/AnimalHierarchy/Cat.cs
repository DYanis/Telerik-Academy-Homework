namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    class Cat : Animals
    {
        public Cat(int age, string name, bool isMale)
            : base(age, name, isMale)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("I'm a Cat !! ");
        }
    }
}
