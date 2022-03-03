using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._1._2_Text_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");

            Console.WriteLine(Environment.NewLine);
                        
            string text = Console.ReadLine();

            Console.WriteLine(Environment.NewLine);

            var counts = CountWords(text);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Результат:");

            Console.WriteLine(Environment.NewLine);

            foreach (var item in counts)
            {
                Console.WriteLine($"Слово:  {item.Key}   \t Количество в тексте: {item.Value}");                
            }           
        }

        public static Dictionary<string, int> CountWords(string text)
        {
            text = text.Trim();

            List<string> words = new List<string>();

            words.AddRange(text.Split(' ',',','-'));

            words = words.Select(word => word.ToLower()).ToList();

            Dictionary<string, int> counts = new Dictionary<string, int>();   
            
            foreach (var word in words)
            {               
                if (word.Length == 0)
                {
                    continue;
                }

                if(counts.ContainsKey(word))
                {                    
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            return counts;            
        }
    }
}
