using System; 
using System.Text;

namespace _1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string lowletterstring = Console.ReadLine();
            string modifiedtext = Modify(lowletterstring);
            Console.WriteLine($"Модифицированный текст:\n{modifiedtext}"); ;
        }

      
        private static string Modify(string str)
        {
            StringBuilder builder = new StringBuilder();
            bool nextuppercase = true;

            foreach (char letter in str)
            {
                if (char.IsLetter(letter) == true && nextuppercase)
                {
                    char big = Char.ToUpper(letter);
                    builder.Append(big);
                    nextuppercase = false;
                }
                else
                {
                    builder.Append(letter);
                }

                if(letter == '.'|| letter == '!'|| letter == '?')
                {
                    nextuppercase = true;

                }
            }

            return builder.ToString();
        }





    } 
}
