namespace AgeRange
{
    using System;
    using System.Linq;
    using FirstBeforeLast;

    class AgeRange
    {
        static void Main()
        {
            Student[] students = 
            {
              new Student ("Asparuh","Boyan",18),
              new Student ("Borqna","Asenova",20),
              new Student ("Carle","Davids",30),
              new Student ("Gus","Hansen", 24)
            };
            
            var targetSudents = students.Where(x => x.Age >= 18 && x.Age <= 24).ToArray();
            
            foreach (var item in targetSudents)
            {
                Console.Write(item.FirstName+ " ");
                Console.WriteLine(item.LastName);
            }
        }   
    }
}
