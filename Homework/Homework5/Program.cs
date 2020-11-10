using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines("Jane Eyre.txt");
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var line in lines)
            {
                char[] charsToTrim = { '.', ' ', '\'', '!', ',', '\"' };
                string[] words = line.Trim(charsToTrim).Split(' ');

                foreach (var word in words)
                {
                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word]++;
                    }
                    else
                    {
                        wordCount.Add(word, 1);
                    }
                    
                }
            }

            foreach (var key in wordCount.Keys)
            {

                Console.WriteLine($"{key.PadRight(25,' ')}\t{wordCount[key]}");

            }

            Console.WriteLine("The word, The, has " + wordCount["The"].ToString("N0") +
                "occurrences!");


            Console.ReadKey();
        }
    }
}
