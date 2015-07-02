namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    internal class Frog : Animals
    {
        public Frog(int age, string name, bool isMale)
            : base(age, name, isMale)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("I'm a Frogg !! ");
        }
    }
}
