using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    public class user
    {
        // Fields
        //public string _firstName;
        //public string _lastName;


        // Properties med kontroll/logik
        //public string Name
        //{
        //    get { return _firstName; }
        //    set { _firstName = value; }
        //}

        // Auto Properties
        public string firstName { get; set;  }
        public string lastName { get; set; }
        public int age { get; set; }


        // Behavior/Beteende
        public void PrintInfo() 
        {
            Console.WriteLine($"Name: {firstName} {lastName}" +
                $"\nAge: {age}");
        }
    }
}
