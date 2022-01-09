using System;

namespace _1._1._10_2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] arr = new int[3, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {                    
                        arr[i, j] = rnd.Next(-10,10);                    
                }
            }

            Console.WriteLine("Элементы массива:");
           
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }

                Console.Write("\n");
            }

            int sum = 0; 

            for (int i = 0; i < arr.GetLength(0); i++)
            {                
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            sum += arr[i,j];
                        }
                    }                
            }
            Console.WriteLine("Сумма элементов, стоящих на четных позициях:");
            Console.Write(sum);
        }
    }
}
