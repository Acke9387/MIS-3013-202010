using System;

namespace Loops_GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an INSTANCE of Random
            // or create an OBJECT of type Random
            // so we can eventually generate a random number
            Random rand = new Random();

            //Console.WriteLine("Please enter the minimum value for the random number >>");
            string minimumString;// = Console.ReadLine();
            //int minimum = Convert.ToInt32(minimumString);
            int minimum, maximum, guess;
            bool success;


            do
            {
                Console.WriteLine("Please enter the minimum value for the random number >>");
                minimumString = Console.ReadLine();
                success = Int32.TryParse(minimumString, out minimum);
            } while (success == false);

            do
            {
                Console.WriteLine("Please enter the maximum value for the random number >>");
                //success = Int32.TryParse(minimumString, out maximum);
            } while (Int32.TryParse(Console.ReadLine(), out maximum) == false);

            // Create a random integer between minimum and maximum + 1
            // Since the upper bound is EXCLUSIVE
            int randomNumber = rand.Next(minimum, maximum + 1);

            Console.WriteLine(randomNumber);
            //int guess;

            do
            {
                do
                {
                    Console.WriteLine($"Guess the random number between {minimum} - {maximum} >>");

                } while (Int32.TryParse(Console.ReadLine(), out guess) == false);

            } while (guess != randomNumber);

            Console.WriteLine("Congratulations you got it right!");



            Console.ReadKey();
        }
    }
}
