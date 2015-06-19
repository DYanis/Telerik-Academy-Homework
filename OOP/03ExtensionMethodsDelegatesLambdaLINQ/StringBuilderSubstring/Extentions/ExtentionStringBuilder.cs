namespace StringBuilderSubstring
{
    using System;
    using System.Linq;
    using System.Text;

   static class ExtentionStringBuilder
    {
       public static string Substring(this StringBuilder text, int index, int lenght)
       {
           var substring = new StringBuilder();
           for (int i = index; i < index + lenght; i++)
           {
               substring.Append(text[i]);
           }
           return substring.ToString();
       }
    }
}
