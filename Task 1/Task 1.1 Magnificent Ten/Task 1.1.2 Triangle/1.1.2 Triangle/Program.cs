using System;

namespace _1._1._2_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
           
            Console.WriteLine("Введите число:");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {

                    Console.Write("*");

                }

                Console.Write("\n");
            }
        }
    }
}
