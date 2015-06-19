//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and /<//upcase> to upper-case.
//The tags cannot be nested.

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace ParseTags
{
    class ParseTags
    {
        static string ModifyString(string text)
        {
            string tag = "<upcase>(.*?)</upcase>";
            string modified = Regex.Replace(text, tag, (word => word.ToString().ToUpper()));
            modified = modified.Replace("<UPCASE>", "");
            modified = modified.Replace("</UPCASE>", "");
            return modified;
        }
        
        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            Console.WriteLine(ModifyString(text));
            
            //string text = Console.ReadLine();
            //var result = new StringBuilder();
            //var words = new StringBuilder();
            //string startTag = "<upcase>";
            //string finishTag = "</upcase>";
            //
            //int resultAddPosition = 0;
            //int searchIndex = 0;
            //while (true)
            //{
            //    int indexStartTag = text.IndexOf(startTag, searchIndex);
            //    int indexFinishTag = text.IndexOf(finishTag, searchIndex);
            //
            //    if (indexStartTag < 0 || indexFinishTag < 0)
            //    {
            //        for (int i = resultAddPosition + (startTag.Length + finishTag.Length); /i /< text.Length; i++)
            //        {
            //            result.Append(text[i]);
            //        }
            //        break;
            //    }
            //
            //    for (int i = resultAddPosition; i < indexStartTag; i++)
            //    {
            //        result.Append(text[i]);
            //    }
            //
            //    for (int i = indexStartTag + startTag.Length; i < indexFinishTag; i++)
            //    {
            //        words.Append(text[i]);
            //    }
            //
            //    result.Append(words.ToString().ToUpper());
            //    searchIndex = result.Length + (startTag.Length + finishTag.Length);
            //    words.Clear();
            //    resultAddPosition = searchIndex;
            //}
            //Console.WriteLine(result.ToString());
        }
    }
}
