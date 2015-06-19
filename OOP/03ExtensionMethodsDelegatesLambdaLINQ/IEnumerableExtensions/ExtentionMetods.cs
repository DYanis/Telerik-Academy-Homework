namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public static class ExtentionMetods
    {
        public static T Sum<T>(this IEnumerable<T> list)
        {
            T sum = default(T);
            foreach (var item in list)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> list)
        {
            T sum = default(T);
            foreach (var item in list)
            {
                sum *= (dynamic)item;
            }
            return sum;
        }

        public static T Average<T>(this IEnumerable<T> list)
        {            
            return list.Sum() / (dynamic)list.Count();
        }

        public static T Min<T>(this IEnumerable<T> list)where T : IComparable
        {
            T min = list.ElementAt(0);
            foreach (var item in list)
            {
                if (min > (dynamic)item)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> list) where T : IComparable
        {
            T max = list.ElementAt(0);
            foreach (var item in list)
            {
                if (max < (dynamic)item)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
