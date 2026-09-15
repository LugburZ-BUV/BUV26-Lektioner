using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Utility
{
    public class Customer
    {
        //public string Name { get; set; 
        public int id;
        public string firstName;
        public string lastName;
        public bool isActive;

        // Om new Customer lämnas tom så ges default som värden
        public Customer(): this(00,"No Data Provided","No Data", false)
        {

        }

        // Constructor
        public Customer(int ID,string FirstName,string LastName,bool IsActive) 
        {
            id = ID;
            firstName = FirstName;
            lastName = LastName;
            isActive = IsActive;
        }
        public void PrintData() 
        {
            Console.WriteLine($"Customer ID: {id}");
            Console.WriteLine($"Customer full name is: {firstName} {lastName}");

            if (isActive)
            {
                Console.WriteLine("The customer is active...");
            }
            else
            {
                Console.WriteLine("The cstomer is not active ...");
            }
        }
        ~Customer()
        {

        }
    }
}
