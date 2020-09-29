using System;

namespace StringManipulation
{
    class Program
    {
        static string MESSAGE = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.WriteLine(MESSAGE);

            Console.WriteLine("What word would you like to look for? >>");
            string lookup = Console.ReadLine();

            Console.WriteLine($"What would you like to replace {lookup} with? >>");
            string replace = Console.ReadLine();

            if (MESSAGE.Contains(lookup) == true)
            {
                string newMessage = MESSAGE.Replace(lookup, replace);

                Console.WriteLine(newMessage);                
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {lookup}.");

                for (int i = lookup.Length - 1; i >= 0; i--)
                {
                    Console.Write(lookup[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
