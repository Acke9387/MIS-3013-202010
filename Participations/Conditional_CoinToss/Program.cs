using System;

namespace Conditional_CoinToss
{
    class Program
    {
        const string DEVELOPER = "Professor Ackerman";
        const int HEADS = 1; // Create a variable to hold the value we are assigning for heads
        const int TAILS = 0;
        static void Main(string[] args) // This is the start of our Main Method
        {

            Random rnd = new Random(); // Random is a class that was already created 
            // This is also referred to as creating an INSTANCE of the class Random
            int result = rnd.Next(0, 2); //Generates a number that can be 0 or 1

            //Console.WriteLine($"Random = {result}"); // string interpolation
            Console.WriteLine("Random = " + result);

            Console.WriteLine("Heads or Tails? >>");
            string answer = Console.ReadLine();

            // You can either have one if statement with multiple checks
            // or you can have two different if statements and either
            // convert their answer to an int or the random number (result)
            // to a string
            if (result == HEADS && answer.ToLower() == "heads")
            {
                Console.WriteLine("Congratulations you guessed correctly!");
            }
            else if (result == TAILS && answer.ToLower() == "tails")
            {
                Console.WriteLine("Congratulations you guessed correctly!");
            }
            else if (answer.ToLower() == "tails")
            {
                string rightAnswer = "Heads";
                Console.WriteLine($"Sorry you guessed {answer}, but the answer was {rightAnswer}.");
            }
            else
            {
                string rightAnswer = "Tails";
                Console.WriteLine($"Sorry you guessed {answer}, but the answer was {rightAnswer}.");
            }



            Console.WriteLine(DEVELOPER);
        }
    }
}
