using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RemoveWords
{
    class RemoveWords
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\ForbiddenWords.txt");
            string readed = reader.ReadToEnd();
            var y = readed.Replace("\n", string.Empty);
            List<string> forbidenWords = new List<string>(y.Trim().Split());
            reader.Close();

            StreamReader achoLike = new StreamReader(@"..\..\SS.txt");
            string acho = achoLike.ReadLine();

            acho = acho.Replace("s", "9");





            StreamWriter currenText = new StreamWriter(@"..\..\SS.txt");
            currenText.Write(acho);
            currenText.Close();
        }
    }
}
