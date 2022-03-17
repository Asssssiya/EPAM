using System;
using System.Linq;

namespace _3._3._1_Super_array
{
    public static class IntArrayExtentions
    {
        public static int Sum(this int[] numbers)
        {
            return numbers.Sum(number => number);
        }

        public static double Average(this int[] numbers)
        {           
            return (double)numbers.Sum(number => number) / numbers.Length;            
        }

        public static int MostFrequentElement(this int[] numbers)
        {
            return numbers
                .GroupBy(number => number)
                .OrderByDescending(group => group.Count())
                .First()
                .Key;
        }

        public static int[] Apply(this int[] numbers, Func<int, int> function)
        {
            return numbers.Select(function).ToArray();
        }
    }

   
}
