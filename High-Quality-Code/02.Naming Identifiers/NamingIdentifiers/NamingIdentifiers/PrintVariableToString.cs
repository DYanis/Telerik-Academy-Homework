namespace NamingIdentifiers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PrintVariableToString
    {
        const int max_count = 6;
        class InClass_class_123
        {
           internal void printToString(bool promenliva)
            {
                string promenlivaKatoString = promenliva.ToString();
                Console.WriteLine(promenlivaKatoString);
            }


        }
        public static void Метод_За_Вход()
        {
            PrintVariableToString.InClass_class_123 инстанция = new PrintVariableToString.InClass_class_123();

            инстанция.printToString(true);
        }
    }
}
