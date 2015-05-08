//Problem 1. Student class

//Define a class Student, which contains data about a student – first, middle and last name,
//SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an 
//enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

namespace Problem_01_Student_class
{
    using System;
    using System.Linq;
    
    class StartMain
    {
        static void Main()
        {
            var goshko = new Student("gogo","tenchev","petrov", 85,
                "Sofia,Bulgaria", "0887552211", "example@abv.bg", 3,
                Speciality.computarScience,University.BostonUniversity,Faculty.FF);
            var toshko = new Student("toshko", "tenchev", "milenov", 85,
                "Sofia,Bulgaria", "0887552211", "example@abv.bg", 3,
                Speciality.computarScience, University.BostonUniversity, Faculty.FF);
            var moshko = new Student("moshko", "nennchev", "mladenov", 85,
                "Sofia,Bulgaria", "0887552211", "example@abv.bg", 3,
                Speciality.computarScience, University.BostonUniversity, Faculty.FF);

            //Console.WriteLine(goshko.ToString());
            //Console.WriteLine(goshko.Equals(goshko));
            //Console.WriteLine(moshko.Equals(toshko));
            //Console.WriteLine(goshko.GetHashCode());
            //Console.WriteLine(goshko == toshko);

            Student ss = goshko.Clone() ;
            Console.WriteLine(ss != goshko);      
            Console.WriteLine(ss.CompareTo(goshko));   
        }
    }
}
