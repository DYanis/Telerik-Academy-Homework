namespace School
{
    using System;
    using System.Linq;    

    public class Disciplines : Comments
    {
        public string Name { get; private set; }

        public int NumberOfLectures { get; private set; }

        public int NumberOfExercises { get; private set; }

        public Disciplines(string name , int numOfLectures , int numOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numOfLectures;
            this.NumberOfExercises = numOfExercises;
        }
    }
}
