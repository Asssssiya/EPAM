using System;

namespace _1._2._3_Lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string inputString = Console.ReadLine();
            int wordsWithLowLetter = GetWordsWithLowLetterCount(inputString);
            Console.WriteLine("Количество словс маленькой буквы: " + wordsWithLowLetter);
        }

        private static int GetWordsWithLowLetterCount(string insertedText)
        {
            int wordsWithLowLetterCount = 0;

            string[] words = insertedText.Split(' ');


            foreach (string word in words)
            {
                if (word.Length == 0)
                {
                    continue;
                }

                char firstLetter = word[0];

                
                if (char.IsLower(firstLetter))
                {
                    wordsWithLowLetterCount += 1;
                }

            }


            return wordsWithLowLetterCount;

        }

    }
}
