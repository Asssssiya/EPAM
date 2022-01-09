using System;

namespace _1._1._8_No_positive
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int[,,] arr = new int[3, 3, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = rnd.Next(-100,100);
                    }
                }
            }

            Console.WriteLine("Элементы массива с положительными значениями:");
            Console.WriteLine("\n");
           
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(arr[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("                          ");
            }

            int positive = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i,j,k] > positive)
                        {
                            arr[i, j, k] = positive;
                        }
                    }
                }
            }

            Console.WriteLine("Элементы массива без положительных значений:");
            Console.WriteLine("\n");
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(arr[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("                          ");
            }
        }
    }
}
