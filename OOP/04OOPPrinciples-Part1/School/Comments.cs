namespace School
{
    using System;
    using System.Collections.Generic;

    public class Comments
    {
        private List<string> comments = new List<string>();

        public void AddComment(string coment)
        {
            this.comments.Add(coment);
        }

        public void ShowComments()
        {
            int c = 1;
            foreach (var coment in comments)
            {
                Console.Write(c + ": ");
                Console.WriteLine(coment);
                c++;
            }
        }
    }
}
