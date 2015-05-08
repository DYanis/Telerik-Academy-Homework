using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student : Human
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            private set { }
        }

        public Student(string fName, string lName, int grade)
            : base(fName, lName)
        {
            this.grade = grade;
        }
    }
}
