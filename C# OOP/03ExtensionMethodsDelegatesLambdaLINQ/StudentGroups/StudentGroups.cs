namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentGroups
    {
        static void Main()
        {
            // Problem 9 
            var students = new List<Student>();
            students.Add(new Student("Angel", "Stefanov", 76324, "0895847625", "hgdashgd@abv.bg", new List<int>() { 4, 2, 3, 4, 3, 2, 4, 3, 2 }, 2));

            students.Add(new Student("Sotir", "Donkov", 322264, "0287456345", "jhjjja@yahoo.bg", new List<int>() { 4, 2, 2, 6, 3, 2, 5, 3, 2 }, 1));

            students.Add(new Student("Doli", "Box", 43206, "02894547625", "jhfsjas@abv.bg", new List<int>() { 5, 2, 6, 4, 2, 2, 3, 3, 5 }, 3));

            students.Add(new Student("Ivan", "Kolev", 76324, "02893423432", "sfdfsd@abssv.bg", new List<int>() { 3, 6 }, 2));


            var studentsFromGroupTwo =
                from student in students
                orderby student.FirstName
                group student by student.GroupNumber;

            foreach (var item in studentsFromGroupTwo.ToArray()[0])
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine();
            // Problem 10 

            var extractedStudents = students.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName).ToArray();

            foreach (var item in extractedStudents)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine();
            // Problem 11

            var y = students.ToList().Where(x => x.Email.Contains("abv.bg")).Select(x => x.FirstName).ToArray();
            foreach (var item in y)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Problem 12

            var extractedByPhone = students.Where(x => x.Tel.ToString().StartsWith("02")).Select(x => x.FirstName).ToArray();
            foreach (var item in extractedByPhone)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Problem 13

            var the = students.Where(s => s.Marks.Contains(6)).Select(x => new { FullName = x.FirstName + " " + x.LastName, Marks = toString(x.Marks) }).ToArray(); foreach (var item in the)
            {
                Console.WriteLine(item);

            }

            // Problem 14 

            var meaningles = students.Where(x => x.Marks.Count == 2).Select(x => x.FirstName + " " + x.LastName);

            foreach (var item in meaningles)
            {
                Console.WriteLine(item);
            }


            // Problem 15 

            var lessMeaningless = students.Where(x => x.FN.ToString().Substring(3, 2) == "06").Select(x => x.FirstName + " " + x.LastName);
            foreach (var item in lessMeaningless)
            {
                Console.WriteLine(item);
            }

            // Problem 18

            var extractedAll =
              from student in students
              orderby student.FirstName
              group student by student.GroupNumber;

            foreach (var group in studentsFromGroupTwo.ToArray())
            {
                Console.WriteLine("Group number: " + group.Key);
                foreach (var item1 in group)
                {
                    Console.WriteLine(item1.FirstName + " " + item1.LastName);
                }
            }

            // Problem 19 

            var extractByGroupe = students.GroupBy(x => x.GroupNumber);

            foreach (var group in studentsFromGroupTwo.ToArray())
            {
                Console.WriteLine("Group number: " + group.Key);
                foreach (var item1 in group)
                {
                    Console.WriteLine(item1.FirstName + " " + item1.LastName);
                }
            }
        }










        public static string toString(List<int> list)
        {
            string text = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                text += list[i] + ", ";
            }
            return text;
        }
    }
}
