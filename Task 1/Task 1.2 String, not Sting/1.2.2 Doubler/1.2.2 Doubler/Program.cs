using System;

namespace _1._2._2_Doubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, которую будем изменять:");
            string first = Console.ReadLine();

            Console.WriteLine("Введите вторую строку:");
            string second = Console.ReadLine();

            string third = DoubleCharsString(first, second);
                
                Console.WriteLine($"Модифицированнная строка: {third}");
        }

        public static string DoubleCharsString(string firststring, string secondstring)
        {

            System.Text.StringBuilder doublestring = new System.Text.StringBuilder();

            foreach (char charfromfirststring in firststring)
            {

                if (secondstring.Contains(charfromfirststring))
                {
                    doublestring.Append(charfromfirststring);
                    doublestring.Append(charfromfirststring);
                }

                 else   
                {
                    doublestring.Append(charfromfirststring);
                }
                               
                
            }

            return doublestring.ToString();
        }
    }
}
