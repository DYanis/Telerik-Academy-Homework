//Problem 1. School classes
//
//    We are given a school. In the school there are classes of students. Each class has a set of teachers. /ach //teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique /ext //identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. /oth //teachers and students are people. Students, classes, teachers and disciplines could have optional /omments //(free text block).
//    Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate //heir/ fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class School
    {
        static void Main()
        {
            Teachers Iva = new Teachers("Iva", new Disciplines[] { new Disciplines("History", 2, 13), new Disciplines("Math", 3, 30) });

            Teachers Georgi = new Teachers("Georgi", new Disciplines[] { new Disciplines("Biology", 1, 9) });

            Teachers Asparuh = new Teachers("Asparuh", new Disciplines[] { new Disciplines("French", 2, 18), new Disciplines("Bulgarian", 3, 20) });

            Classes class12A = new Classes("class12A", new Teachers[] { Iva, Georgi, Asparuh });

            List<Students> students = new List<Students>();
            students.Add(new Students("Angel", 1));
            students.Add(new Students("Boya", 3));
            students.Add(new Students("Kristina", 5));
            students.Add(new Students("Viktoriya", 4));            
        }
    }
}
