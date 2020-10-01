using System;
using System.Collections.Generic;
using System.IO;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\acke9387\Downloads\Frankenstein.txt";

            string[] linesOfFile = File.ReadAllLines(filePath);
            int i = 0;

            foreach (var line in linesOfFile)
            {
                // break the sentence up into words
                string[] pieces = line.Split(' ');
                if (i % 15 == 0 && i != 0)
                {
                    Console.ReadKey();
                }
                Console.WriteLine(line);
                i++;
            }

            Console.ReadKey();
        }

        private static void ListExample()
        {
            List<string> favoriteThings = new List<string>();
            string answer;

            do
            {
                Console.WriteLine("Please enter one of your favorite things >>");
                string favoriteThing = Console.ReadLine();

                favoriteThings.Add(favoriteThing);

                Console.WriteLine("Do you have another favorite thing to tell me? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            Random rand = new Random();
            int index = rand.Next(0, favoriteThings.Count);

            Console.WriteLine(favoriteThings[index]);

            //Output all of the strings
            foreach (var ft in favoriteThings)
            {
                if (ft == "sheepadoodle")
                {
                    Console.WriteLine("You're the coolest!");
                }
                Console.WriteLine(ft);
            }
        }

        private static void DictionaryExample()
        {
            Dictionary<int, double> studentGpas = new Dictionary<int, double>();

            if (studentGpas.ContainsKey(1) == true)
            {
                studentGpas[1] = 1.7;
            }
            else
            {
                studentGpas.Add(1, 1.7);
            }

            studentGpas.Add(2, 3.5);
            studentGpas.Add(3, 4.0);

            foreach (var studentID in studentGpas.Keys)
            {
                Console.WriteLine(studentID);
            }


            Console.WriteLine("Please pick an ID to display the GPA of >>");
            int id = Convert.ToInt32(Console.ReadLine());
            if (studentGpas.ContainsKey(id) == true)
            {
                double gpa = studentGpas[id];
                Console.WriteLine($"Student with id {id} has a gpa of {gpa}");
            }
            else
            {
                Console.WriteLine("INVALID ID. GOODBYE.");
            }
        }

        static void ArrayExample()
        {
            int[] studentIds = new int[3];
            double[] gpas = new double[3];

            //Assign values to the studentid's array
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;

            //Assign values to the gpas's array
            gpas[0] = 1.75;
            gpas[1] = 2.99;
            gpas[2] = 4.0;

            //for (int i = 0; i < studentIds.Length; i++)
            //{
            //    // creating a temp variable to hold the current students id
            //    int studentId = studentIds[i]; 
            //    Console.WriteLine(studentId);
            //}

            foreach (int studentId in studentIds)
            {
                Console.WriteLine(studentId);
            }

            Console.WriteLine("Please pick an ID to display the GPA of >>");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentIds.Length; i++)
            {
                int studentId = studentIds[i];
                if (studentId == id)
                {
                    double gpa = gpas[i];
                    Console.WriteLine($"Student with id {id} has a gpa of {gpa}");
                    break;
                }
            }

        }
    }
}
