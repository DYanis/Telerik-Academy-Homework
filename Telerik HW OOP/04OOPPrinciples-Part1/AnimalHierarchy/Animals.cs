namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    public abstract class Animals : ISound
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public bool IsMale { get; protected set; }

        public Animals(int age, string name, bool isMale)
        {
            this.Age = age;
            this.Name = name;
            this.IsMale = isMale;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("I'm a anymal");
        }

        public static double AverageAge(Animals[] arr)
        {
            double totalAge = 0;
            foreach (var item in arr)
            {
                totalAge += item.Age;
            }
            return totalAge / arr.Length;
        }
    }
}
