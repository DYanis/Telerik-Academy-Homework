namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    class Kitten : Cat
    {
        public Kitten(int age, string name, bool isMale)
            : base(age, name, isMale)
        {
            this.IsMale = false;
        }

        public override void MakeSound()
        {
            Console.WriteLine("I'm a Kitten !! ");
        }
    }
}
