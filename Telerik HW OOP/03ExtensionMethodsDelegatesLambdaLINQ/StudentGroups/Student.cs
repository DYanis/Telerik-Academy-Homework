namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Student(string FirstName, string LastName, int FN, string Tel, string Email, List<int> Marks, int GroupNumber)
        {
            // TODO: Complete member initialization
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FN = FN;
            this.Tel = Tel;
            this.Email = Email;
            this.Marks = Marks;
            this.GroupNumber = GroupNumber;
        }
    }
}
