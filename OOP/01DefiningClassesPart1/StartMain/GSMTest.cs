namespace StartMain
{
    using System;
    using System.Linq;

    public class GSMTest
    {
        static public void Test()
        {
            GSM[] gsms = new GSM[5];
            gsms[0] = new GSM("Iphone6S", "Apple", 1700, "Acho");
            gsms[1] = new GSM("Galaxy", "Samsung",800);
            gsms[2] = new GSM("Xperia", "Sony", 900, "Asparuh");
            gsms[3] = new GSM("One", "HTC", 270);
            gsms[4] = new GSM("Lumia", "Microsoft", 1300, "Doncho");

            foreach (var item in gsms)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine(GSM.Iphone4S);
        }
    }
}
