using System;

namespace _1._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            public static void FontAdjustment()
            {
                Console.WriteLine("Введите:");
                var input = int.Parse(Console.ReadLine());
                FontStyle currentStyle = FontStyle.None;
                switch (input)
                FontStyle currentStyle = new FontStyle();
                byte input;
                do
                {
                case 1:
                    currentStyle = FontStyle.Bold;
            break;
                case 2:
                    currentStyle = FontStyle.Italic;
            break;
                case 3:
                    currentStyle = FontStyle.Underline;
            break;
            default: 
                    currentStyle = FontStyle.None;
            break;
            Console.WriteLine("Параметры надписи: " + currentStyle);
            Console.WriteLine("Введите:");
            Console.WriteLine("\t1: bold");
            Console.WriteLine("\t2: italic");
            Console.WriteLine("\t3: underline");
            Console.WriteLine("\t0: exit");
            if (Byte.TryParse(Console.ReadLine(), out input))
            {
                if (input > 3)
                {
                    Console.WriteLine("Incorrect number.");
                    continue;
                }
                if (currentStyle.HasFlag((FontStyle)Math.Pow(2, input - 1)))
                    currentStyle ^= (FontStyle)Math.Pow(2, input - 1);
                else
                    currentStyle ^= (FontStyle)Math.Pow(2, input - 1);
            }
            else
                Console.WriteLine("Error");
        }
        Console.WriteLine(currentStyle);
            while (input != 0);
        }
    [Flags]
    public enum FontStyle : byte
    {
        None = 0,
        Bold = 1,
        Italic = 2,
        Underline = 3
            None = 0,
        Bold = 1,
        Italic = 2,
        Underline = 4
    }
}
}
        }
    }
}
