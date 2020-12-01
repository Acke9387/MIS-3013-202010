using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_SqlClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=tcp:s13.winhost.com;Initial Catalog=DB_128040_practice;User ID=student;Password=AdamTheGreat2020;Integrated Security=False;";
            string queryString = " SELECT CustomerID, FirstName, LastName, Email, Gender, Address, City, State, ZipCode " +
                                 " FROM   CUSTOMER ";

            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int customerId = reader.GetInt32(0); // this is at position 0 because we listed it first in our SELECT statement
                        string firstName = reader.GetString(1);
                        string lastName = reader.GetString(2);
                        string email = reader.GetString(3);
                        string gender = reader.GetString(4);
                        string address = reader.GetString(5);
                        string city = reader.GetString(6);
                        string state = reader.GetString(7);
                        string zipCode = reader.GetString(8);

                        Customer newCustomer = new Customer(customerId, firstName, lastName, email, gender, address, city, state, zipCode);
                        customers.Add(newCustomer);
                        //Console.WriteLine($"{firstName} {lastName} ({customerId}) - {email} {gender} \n{address} \n{city}, {state} {zipCode}\n");
                    }
                }

            }

            Console.WriteLine("All of our customers");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("All customers from the state Oklahoma we have customers: ");
            foreach (var customer in customers)
            {
                if (customer.State.ToLower() == "oklahoma")
                {
                    Console.WriteLine(customer); 
                }
            }


            Console.ReadKey();
        }
    }
}
