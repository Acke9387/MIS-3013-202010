using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        static List<int> values = new List<int>();

        static void Main(string[] args)
        {

            // Random rand = new Random(); // this is an instance

            //bool isSuccess = PossiblyAddStringToAList("cat");
            //if(isSuccess == false)
            //{
            //    Console.WriteLine("Cat wasn't a valid integer :(");
            //}

            //isSuccess = PossiblyAddStringToAList("5");
            string answer = "";
            OutputAllValuesFromList();

            values.AddRange(new List<int> { 5, 10, 11, 13, 17, 28, 48, 91 });

            OutputAllValuesFromList();
            do
            {
                Console.WriteLine("Please enter a integer >>");
                string intValue = Console.ReadLine();
                bool shouldIAskAgain = PossiblyAddStringToAList(intValue);

                while (shouldIAskAgain == false)
                {
                    Console.WriteLine("Enter a valid integer this time >>");
                    intValue = Console.ReadLine();
                    shouldIAskAgain = PossiblyAddStringToAList(intValue);
                }

                Console.WriteLine("Do you want to enter another number? >>");
                answer = Console.ReadLine();
            } while (answer == "yes");

            OutputAllValuesFromList();
            OutputEvenNumbersFromList();
            OutputOddNumbersFromList();
            Console.ReadKey();
        }

        /// <summary>
        /// Checks to make sure that a string is a valid Integer and if it is, will add it to the List
        /// </summary>
        /// <param name="inputFromWhoeverCalledMe">A string that holds an integer value (hopefully)</param>
        /// <returns>
        /// True if it was able to convert the value and add it to the list
        /// False if it was unable to convert the value
        /// </returns>
        static bool PossiblyAddStringToAList(string inputFromWhoeverCalledMe)
        {
            bool wasSuccess = true;
            int value;

            wasSuccess = int.TryParse(inputFromWhoeverCalledMe, out value);

            if (wasSuccess)
            {
                // we want to add it to the list
                values.Add(value);
            }
            else
            {
                // we want to tell them they had an invalid input
                Console.WriteLine($"{inputFromWhoeverCalledMe} was not a valid integer.  You must enter an integer");
            }

            return wasSuccess;
        }

        static void OutputAllValuesFromList()
        {
            Console.WriteLine("\nAll Values!!!\n");
            for (int i = 0; i < values.Count; i++)
            {
                int currentValueInList = values[i];

                Console.WriteLine(currentValueInList.ToString("N0"));
            }
        }

        static void OutputOddNumbersFromList()
        {
            Console.WriteLine("\nAll Odd Values!!!\n");
            for (int i = 0; i < values.Count; i++)
            {
                int currentValueInList = values[i];

                if (currentValueInList % 2 != 0)
                {
                    Console.WriteLine(currentValueInList.ToString("N0"));
                }
            }
        }
        static void OutputEvenNumbersFromList()
        {
            Console.WriteLine("\nAll Even Values!!!\n");
            for (int i = 0; i < values.Count; i++)
            {
                int currentValueInList = values[i];

                if (currentValueInList % 2 == 0)
                {
                    Console.WriteLine(currentValueInList.ToString("N0"));
                }
            }
        }
    }
}
