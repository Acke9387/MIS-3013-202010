using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesVsParallelCollections
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string FavoriteFood { get; set; }

        public double AccountBalance { get; set; }

        //public void SetAccountBalance (double val)
        //{
        //    AccountBalance = val;
        //}

        //public Double GetAccountBalance()
        //{
        //    return AccountBalance;
        //}

        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = string.Empty;
            FavoriteFood = string.Empty;
            AccountBalance = 0;
        }

        public Person (string fName, string lName, string dob, string food, double bal)
        {
            FirstName = fName;
            LastName = lName;
            DateOfBirth = dob;
            FavoriteFood = food;
            AccountBalance = bal;
        }

        public override string ToString()
        {
            string output = $"{FirstName} {LastName} {DateOfBirth} likes {FavoriteFood} and has {AccountBalance.ToString("C")}";
            return output;
        }
    }
}
