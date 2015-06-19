namespace OrderStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FirstBeforeLast;

    class OrderStudents
    {
        static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Botev", "Botev", 65));
            students.Add(new Student("Asparuh", "Georgiev", 42));
            students.Add(new Student("Asparuh", "Asenov", 42)); 
            students.Add(new Student("Tervel", "Pulev", 25));
            students.Add(new Student("Kaloyan", "Hristov", 18));

            var orderedStudents = students.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        }
    }
}
