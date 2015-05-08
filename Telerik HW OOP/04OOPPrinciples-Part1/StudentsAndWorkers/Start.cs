namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Georgi", "Krirov", 4));
            students.Add(new Student("Maikyl", "Stoyanov", 3));
            students.Add(new Student("Gush", "Kririlov", 5));
            students.Add(new Student("Doncho", "Borisov", 6));
            students.Add(new Student("Daniel", "Vladimirov", 2));
            students.Add(new Student("Acho", "Boyadjiev", 3));
            students.Add(new Student("Filip", "Hristoforov", 4));
            students.Add(new Student("Asen", "Nikiforov", 5));
            students.Add(new Student("Maikul", "Petrov", 6));
            students.Add(new Student("Kaloyan", "Stoykov", 2));

            var sordetStudents = students.OrderBy(x => x.Grade);

            foreach (var item in sordetStudents)
            {
               // Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Teodor","Nikolov",425,8));
            workers.Add(new Worker("Sotitir", "Petrov", 300, 8));
            workers.Add(new Worker("Zara", "Georgie", 200, 8));
            workers.Add(new Worker("Petar", "Ivanov", 100, 8));
            workers.Add(new Worker("Hristo", "Sotirov", 200, 8));
            workers.Add(new Worker("Niki", "Smirnenkski", 333, 8));
            workers.Add(new Worker("Eli", "Mancheva", 111, 8));
            workers.Add(new Worker("Hristo", "Asparuhov", 222, 8));
            workers.Add(new Worker("Chocho", "Chocov", 321, 8));
            workers.Add(new Worker("Qvor", "Bobev", 899, 8));

            var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());

            foreach (var item in orderedWorkers)
            {
              //  Console.WriteLine(item.FirstName);
            }

            var mergedList = new List<Human>();
            foreach (var item in students)
            {
                mergedList.Add(item);
            }

            foreach (var item in workers)
            {
                mergedList.Add(item);
            }

            var ordereHumans = mergedList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var item in ordereHumans)
            {
                Console.WriteLine(item.FirstName + " "+ item.LastName);
            }
        }
    }
}