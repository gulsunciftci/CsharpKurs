using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
               new Customer{FirstName="Gulsun",LastName="Ciftci",Id=1},new Student{FirstName="Ahmet",LastName="Ciftci",Id=2}
            };

            foreach(var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
    }
    class Student:Person
    {
        public string Department { get; set; }
       
    }
    class Customer : Person
    {
        public string City { get; set; }

    }
}
