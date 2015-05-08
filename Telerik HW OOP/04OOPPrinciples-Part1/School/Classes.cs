namespace School
{
    using System;
    using System.Linq;

    public class Classes : Comments 
    {
        public Teachers[] teachers { get; private set; }

        public string TextIdentifier { get; private set; }

        public Classes(string textID, Teachers[] teachers)
        {
            this.TextIdentifier = textID;
            this.teachers = teachers;
        }
    }
}
