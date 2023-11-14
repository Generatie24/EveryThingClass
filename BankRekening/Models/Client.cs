using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRekening.Models
{
    public class Client
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public int Age;
       
        public Client(string firstName, string lastName, string address, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Age = age;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {Address} {Age}";
        }
    }
}
