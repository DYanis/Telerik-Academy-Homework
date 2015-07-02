namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    public abstract class Animals : ISound
    {
        public Animals(int age, string name, bool isMale)
        {
            this.Age = age;
            this.Name = name;
            this.IsMale = isMale;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public bool IsMale { get; protected set; }

        public static void AverageAge(Animals[] arr)
        {
            var groupedAnimalsByType = arr.GroupBy(x => x.GetType());
            foreach (var group in groupedAnimalsByType)
            {
                Console.Write(group.Key.Name + "-");
                int averageForGroupAge = 0;
                foreach (var animal in group)
                {
                    averageForGroupAge += animal.Age;
                }

                Console.WriteLine(averageForGroupAge / group.Count());
            }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("I'm a animal");
        }
    }
}
