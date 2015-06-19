namespace Problem_01_Student_class
{
    using System;
    using System.Linq;

    public class Student : ICloneable
    //IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string address;
        private string mobilePhone;
        private string email;
        private int course;
        private Speciality speciality;
        private University university;
        private Faculty faculty;

        public Student(string fname, string mname, string lname, int ssnumber, string add, string phoneNum, string mail, int coursE, Speciality spec, University uni, Faculty fac)
        {
            this.firstName = fname;
            this.middleName = mname;
            this.lastName = lname;
            this.ssn = ssnumber;
            this.address = add;
            this.mobilePhone = phoneNum;
            this.email = mail;
            this.course = coursE;
            this.speciality = spec;
            this.university = uni;
            this.faculty = fac;
        }

        public override string ToString()
        {
            return firstName + " " + middleName + " " + lastName +
                "\n" + ssn + " " + address + " " + mobilePhone +
                "\n" + email + " " + course +
                "\n" + speciality + " " + university + " " + faculty;
        }

        public override bool Equals(System.Object student)
        {
            Student person = student as Student;
            if ((System.Object)person == null)
            {
                return false;
            }

            return (firstName == person.firstName) && (middleName == person.middleName) && (lastName == person.lastName);
        }

        public override int GetHashCode()
        {
            return ssn ^ course;
        }

        public static bool operator ==(Student a, Student b)
        {
            return object.Equals(a, b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !object.Equals(a, b);
        }

        public Student Clone()
        {
            Student newStudent = new Student(this.firstName, this.middleName, this.lastName, this.ssn, this.address, this.mobilePhone, this.email, this.course, this.speciality, this.university, this.faculty);
            return newStudent;
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            if (this.firstName.CompareTo((obj as Student).firstName) != 0)
            {
                return this.firstName.CompareTo((obj as Student).firstName);
            }

            if (this.middleName.CompareTo((obj as Student).middleName) != 0)
            {
                return this.middleName.CompareTo((obj as Student).middleName);
            }

            if (this.lastName.CompareTo((obj as Student).lastName) != 0)
            {
                return this.lastName.CompareTo((obj as Student).lastName);
            }

            if (this.ssn.CompareTo((obj as Student).ssn) != 0)
            {
                return this.ssn.CompareTo((obj as Student).ssn);
            }

            return 0;
        }
    }
}
