using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EveryThingClass.Models;

namespace EveryThingClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person);

            Person person1 = new Person("Jane", "Doe");
            person1.Address = "1234 Main St";
            Console.WriteLine(person1);
        }
    }
}
