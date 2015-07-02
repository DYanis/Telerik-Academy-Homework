namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    internal class Start
    {
        internal static void Main()
        {
            Animals[] animals = {
            new Cat(5,"Myay",true), 
            new Cat(3,"Myay",true), 
            new Cat(17,"Myay",true), 
            new Dog(4,"Bobcho",true), 
            new Kitten (3,"nenka",true), 
            new Frog (3,"penka",false), 
            new Tomcat (6, "Ivan",false)
                                };

            Animals.AverageAge(animals);
        }
    }
}
