namespace School
{
    using System;
    using System.Linq;

    public class Students : People
    {
        public int classNumber { get; private set; }

        public Students(string name, int classNum)
            : base(name)
        {
            this.classNumber = classNum;
        }
    }
}
