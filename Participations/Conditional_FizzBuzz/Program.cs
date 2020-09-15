using System;

namespace Conditional_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            //int remainder = number % 3;
            //bool hasRemainder = remainder == 0;

            //BOOLEAN OPERATORS:
            //      OR  = ||
            //      AND = &&
            //Assign a specific value in order to test
            number = 15;
            if (number % 3 == 0)                
            {
                Console.WriteLine("Fizz");
            }
            //else if ()
            //{

            //}

            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
