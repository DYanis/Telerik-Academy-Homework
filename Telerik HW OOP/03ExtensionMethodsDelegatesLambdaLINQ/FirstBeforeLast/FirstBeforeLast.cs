namespace FirstBeforeLast
{
    using System;
    using System.Linq;

    class FirstBeforeLast
    {
        static void Main()
        {
            var students = new Student[]
            { 
              new Student  ("Asparuh","Boyan",18),
              new Student("Borqna","Asenova",20),
              new Student ("Carle","Davids",30),
            };
            
            Console.WriteLine(Student.FindStudents(students));
        }
    }
}
