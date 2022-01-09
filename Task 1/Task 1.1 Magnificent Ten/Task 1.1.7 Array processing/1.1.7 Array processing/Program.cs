using System;

namespace _1._1._7_Array_processing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Случайные элементы массива:");

            int[] arr = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-5,5);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }

            int Max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (Max < arr[i])
                {
                    Max = arr[i];
                }

            }

            Console.WriteLine($"Максимальное значение:{Max}");

            int Min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (Min > arr[i])
                {
                    Min = arr[i];
                }
            }
            Console.WriteLine($"Минимальное значение:{Min}");

            int sort;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        sort = arr[i];
                        arr[i] = arr[j];
                        arr[j] = sort;
                    }
                }
            }

            Console.WriteLine("Упорядоченные элементы массива:");

            for (int i = 0; i < arr.Length; i++)
            {                
                Console.Write($"{arr[i]}, ");
            }

        }
    }
}
