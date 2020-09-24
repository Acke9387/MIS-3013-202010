using System;

namespace ExitingOutOfApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "hello";

            if (s == "Hello" || s != "birdie")
            {
                if (s == "Hello")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("BIRDIE");
                }
            }
            else if(s.Contains("ell") == true)
            {
                Environment.Exit(-900);
            }
            else
            {
                /*
                 * Put block of code that only executes if the word is not Hello
                 * and it does not contain the string 'ell'
                 * 
                 */
            }


            Console.ReadKey();
        }
    }
}
