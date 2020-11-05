using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ClassesVsParallelCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>();
            List<string> lastNames = new List<string>();
            List<string> dobs = new List<string>();
            List<string> favoriteFood = new List<string>();
            List<double> accountBalances = new List<double>();

            firstNames.Add("Adam");
            lastNames.Add("Ackerman");
            dobs.Add("11/5/2020");
            favoriteFood.Add("Pizza");
            accountBalances.Add(500);

            firstNames.Add("Micah");
            lastNames.Add("Tison");
            dobs.Add("6/5/2020");
            favoriteFood.Add("French Cuisine");
            accountBalances.Add(55500);

            for (int i = 0; i < firstNames.Count; i++)
            {
                Console.WriteLine($"{firstNames[i]} {lastNames[i]} {dobs[i]} likes {favoriteFood[i]} and has {accountBalances[i].ToString("C")}. ");
            }

            // SAME BUT USE CLASSES NOW !!!!!
            Person adam = new Person();
            adam.FirstName = "Adam";
            adam.LastName = "Ackerman";
            adam.DateOfBirth = "11/5/2020";
            adam.FavoriteFood = "Pizza";
            adam.AccountBalance = 500;
            //adam.SetAccountBalance(500);

            Person micah = new Person("Micah", "Tison", 
                                      "6/4/2020", "French Cuisine", 
                                      55000);
            Console.WriteLine(adam.ToString());
            Console.WriteLine(micah);

            List<Person> peeps = new List<Person>();
            peeps.Add(micah);
            peeps.Add(adam);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
