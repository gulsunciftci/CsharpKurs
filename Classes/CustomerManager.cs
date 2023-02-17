using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class CustomerManager //class
    {
        //public string FirstName; //field
        public int Id { get; set; } //property
        public string LastName { get; set; }

        private string _firsName;
        public string FirstName {
            get { return "Mrs."+_firsName; }
            set { _firsName = value; }
         }

        public void Add() //metot
        {
            Console.WriteLine("customer added");
        }
    }
}
