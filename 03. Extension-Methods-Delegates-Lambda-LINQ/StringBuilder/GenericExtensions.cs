using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericExtensions
{
    public static class GenericExtensions
    {
        public static double Sum<T>(this IEnumerable<T> list)
        {
            dynamic sum = 0;
            foreach (dynamic item in list)
                {
                sum += item;
                }
            return sum;
        }

        public static double Product<T>(this IEnumerable<T> list)
        {
            dynamic product = 1;
            foreach (dynamic item in list)
            {
                product *= item;
            }
            return product;
        }

        public static double Min<T>(this IEnumerable<T> list)
        {
            dynamic min = list.First();
            foreach (dynamic item in list)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        public static double Max<T>(this IEnumerable<T> list)
        {
            dynamic max = list.First();
            foreach (dynamic item in list)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static double Average<T>(this IEnumerable<T> list)
        {
            dynamic average = 0;
            int count = 0;
            foreach (dynamic item in list)
            {
                average += item;
                count++;
            }
            return average/count;
        }
    }
}
