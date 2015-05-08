// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts  from it the [protocol], [server] and [resource] elements.

using System;
using System.Linq;
using System.Text;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            var server = new StringBuilder();
            var resource = new StringBuilder();
            int indexDotCom = text.IndexOf(".com") + 4;

            for (int i = 7; i < indexDotCom; i++)
            {
                server.Append(text[i]);
            }

            for (int i = indexDotCom; i < text.Length; i++)
            {
                resource.Append(text[i]);
            }
            Console.WriteLine("[protocol] = http");
            Console.WriteLine("[server] = {0}", server.ToString());
            Console.WriteLine("[resource] = {0}", resource.ToString());
        }
    }
}
