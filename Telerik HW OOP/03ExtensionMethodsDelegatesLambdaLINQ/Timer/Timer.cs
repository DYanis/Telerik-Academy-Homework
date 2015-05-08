namespace Timer
{
    using System;
    using System.Linq;

    public delegate void SimpleDelegate(int param);
    public class DelegatesExample
    {
        static void TestMethod(int param)
        {
            System.Threading.Thread.Sleep(param * 1000);
            int pSecond = 0; 
            Console.WriteLine("Ready");
            TestMethod(param);
        }
        static void Main()
        {
            SimpleDelegate d = new SimpleDelegate(TestMethod);
            d(5);
        }
    }
}
