namespace LongestString
{
    using System;
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            string[] stringArr = { "dasd", "das", "ewjhwej", "winn", "Redyyyyyyyy" };

            var result = from str in stringArr
                         orderby str.Length
                         select str;
             
            Console.WriteLine(result.ToArray()[result.Count()-1]);
            
        }
    }
}