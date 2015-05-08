namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    class DivisibleBy7And3
    {
        static void Main()
        {
            int[] numbers = { 4, 7, 21, 35, 45, 99, 49, 56, 63 };
            //var targets = numbers.Where(x => x % 3 == 0 && x % 7 == 0).ToList();
            //targets.ForEach(Console.WriteLine);


            var result = from number in numbers
                         where number % 3 == 0 && number % 7 == 0
                         select number;
            var res = result.ToArray();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
