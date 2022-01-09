using System;

namespace _1._1._1_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
         
            double p;

            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Необходимо найти площадь прямоугольника!");
                Console.WriteLine("Введите длину первой стороны:");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите длину второй стороны:");
                b = double.Parse(Console.ReadLine());

                if (a <= 0 || b <= 0)
                {
                    Console.WriteLine("Ошибка!");

                }
                else
                {
                    p = (a + b) * 2;
                    Console.WriteLine("Периметр прямоугольника составляет:");
                    Console.WriteLine(p);
                    repeat = false;
                }
            }
        }
    }
}
