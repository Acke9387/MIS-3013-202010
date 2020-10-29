using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Threading;

namespace Methods_SimpleMethodSpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a type of animal >>");
            string animal = Console.ReadLine();
            string sound = Speak(animal);
            Console.WriteLine(sound);

            Console.WriteLine(Speak("goat")); // chaining method calls

            Console.ReadKey();
        }

        static string Speak(string animalType)
        {
            string output;// = "";

            //switch (animalType.ToLower())
            //{
            //    case "dog":
            //        output = "ruff ruff";
            //        break;
            //    case "monkey":
            //        output = "oooo ahhh";
            //        break;
            //    case "goat":
            //        output = "<person yelling>";
            //        break;
            //    default:
            //        output = "Sorry I do not recognize the animal of " + animalType + ".";
            //        break;
            //}

            if (animalType.ToLower() == "dog")
            {
                output = "ruff ruff";
            }
            else if (animalType.ToLower() == "monkey")
            {
                output = "oooo ahhh";
            }
            else if (animalType.ToLower() == "goat")
            {
                output = "<person yelling>";
            }
            else
            {
                output = "Sorry I do not recognize the animal of " + animalType + ".";
            }

            return output;

        }

    }
}
