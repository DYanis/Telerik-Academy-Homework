namespace _11.VersionAttribute
{
    using System;

    [Version("v. 2.10")]
   public class Sample
    {
        static void Main()
        {
            Type type = typeof(Sample);
            object[] attr = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}