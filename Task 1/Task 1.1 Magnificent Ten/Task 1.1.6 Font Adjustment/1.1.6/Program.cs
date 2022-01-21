using System;

namespace _1._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            FontType fontType = FontType.None;

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine($"Параметры надписи:{fontType}");

                Console.WriteLine("Введите:");
                Console.WriteLine("1. Bold");
                Console.WriteLine("2. Italic");
                Console.WriteLine("3. Underline");
                string chosenFont = Console.ReadLine();

                if (chosenFont == "1")
                {
                    fontType = fontType ^  FontType.Bold;
                }
                else if (chosenFont == "2")
                {
                    fontType = fontType ^ FontType.Italic;
                }
                else if (chosenFont == "3")
                {
                    fontType = fontType ^ FontType.Underline;
                }

                else
                {
                    isRunning = false;
                }
            }
        }

    }
}
