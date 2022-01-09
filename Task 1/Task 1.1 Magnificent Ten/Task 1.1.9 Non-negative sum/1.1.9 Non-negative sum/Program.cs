using System;

namespace _1._1._9_Non_negative_sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5];

            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-5, 5);
            }

            Console.WriteLine("Элементы массива:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"  {arr[i]}\n");
            }

            Console.WriteLine("\n");

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum = sum + arr[i];
                }
            }

            Console.WriteLine($"Сумма неотрицательных элементов:{sum}");
        }
    }
}
