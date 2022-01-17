using System;

namespace _1._2._1_Averages
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Введите текст:");
            string s = Console.ReadLine();
            
            int amount = GetWordsCount(s);
            int amountofletter = GetLettersCount(s);
            int average = GetAverageAmount(amountofletter, amount); // значение переменной округляется в меньшую сторону
            Console.WriteLine($"Среднее слово строки состоит из: {average} букв!");
        }

        private static int GetWordsCount(string s)
        {
            string[] words = s.Split(' ');

            int wordscount = 0;

            foreach ( string word in words )
            {
                int letterscount = GetLettersCount(word);
                                               
                if (letterscount > 0)
                {
                    wordscount += 1;
                }
            }
                        
            return wordscount;
        }

        private static int GetLettersCount(string s)
        {

            int count = 0;
                        
            foreach (  char letter in s)
            {
                                
                if (char.IsLetter(letter))
                {
                    count += 1;
                }
               
            }

            return count;
        }

        private static int GetAverageAmount(int letterscount, int wordscount)
        {
            int average = letterscount / wordscount;

            return average;
        }

    }
}
