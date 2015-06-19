namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public Student(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public Student(string fName, string lName, int age)
            : this(fName
                , lName)
        {
            this.Age = age;
        }

        static public List<Student> FindStudents(Student[] students)
        {
            var result = students.Where(x => x.FirstName.CompareTo(x.LastName) == 1).ToList();
            return result;
        }
    }
}
