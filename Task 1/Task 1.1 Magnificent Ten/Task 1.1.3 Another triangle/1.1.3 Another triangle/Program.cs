using System;

namespace _1._1._3_Another_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                            
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int g = 0; g <= i * 2; g++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
        }
    }
}
