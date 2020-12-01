using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_SqlClient
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Customer()
        {
            CustomerID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Gender = string.Empty;
            Address = string.Empty;
            City = string.Empty;
            State = string.Empty;
            ZipCode = string.Empty;
        }

        public Customer(int customerId, string firstName, string lastName, string email, string gender, string address, string city, string state, string zipCode)
        {
            CustomerID = customerId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({CustomerID}) - {Email} {Gender} \n{Address} \n{City}, {State} {ZipCode}\n";
        }
    }
}
