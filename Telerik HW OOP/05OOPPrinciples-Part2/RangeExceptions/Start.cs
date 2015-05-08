namespace RangeExceptions
{
    using System;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            int start = 1;
            int end = 100;
            int myNumber = 150;
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);
            DateTime myDate = new DateTime(1912, 3, 8);
            if (myNumber < start || myNumber > end)
            {
                throw new InvalidRangeException<int>("Your number is not in the range [1...100]");
            }
            if (myDate < startDate || myDate > endDate)
            {
                throw new InvalidRangeException<DateTime>("Your date is not in the proper range");
            }
        }
    }
}
