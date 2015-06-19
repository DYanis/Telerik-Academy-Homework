namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            Animals[] animals = {
                new Cat(5,"Myay",true),
                new Dog(4,"Bobcho",true),
                new Kitten (3,"nenka",true),
                new Frog (3,"penka",false),
                new Tomcat (6, "Ivan",false)
                                };

            var averageAge = Animals.AverageAge(animals);
            Console.WriteLine(averageAge);
        }
    }
}
