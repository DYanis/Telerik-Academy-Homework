namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    public class Dog : Animals
    {
        public Dog(int age, string name, bool isMale)
            : base(age, name, isMale)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("I'm a Doggy !! ");
        }
    }
}
