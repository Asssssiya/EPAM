using System;

namespace _3._3._1_Super_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 4, 5, 2, 6, 5, 4, 3 };
                        
            int[] newArray = array.Apply(MultiplyBy2);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
           
        }

        static int MultiplyBy2(int number)
        {
            return number * 2;
        }
    }
}
