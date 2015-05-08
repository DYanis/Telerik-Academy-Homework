// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Linq;

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string text = Console.ReadLine();
        Console.WriteLine();
        text = text.Replace("<a href=\"", "[URL=");
        text = text.Replace("com\">our site</a>", "com]our site[/URL]");
        text = text.Replace("visit <a href=\"", "Also visit [URL=");
        text = text.Replace("\">our forum</a>", "]our forum[/URL]");

        Console.WriteLine(text);
    }
}
