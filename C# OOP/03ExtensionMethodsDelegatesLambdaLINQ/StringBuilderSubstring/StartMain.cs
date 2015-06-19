// Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace StringBuilderSubstring
{
    using System;
    using System.Linq;
    using System.Text;

   static class StartMain
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            text.Append("dajsghdashjdasjdasghdas");
            string result = text.Substring(2, 4);
            Console.WriteLine(result);
        } 
    }
}
