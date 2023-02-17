using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id=1, Name="ahmet", Adress="erzurum" });
            manager.Add(new Student { Id = 1, Name = "gulsun", Departmant = "Computer sciences" });
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
            customerManager.Add(new SqlServerCustomerDal());
        }
    }
    interface IPerson //hiçbir zaman tek başına newlenemez.
    {
        int Id { get; set; }
        string Name { get; set; }
        
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Departmant { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
    }
    class PersonManager
    {

        public void Add(IPerson Person)
        {
            Console.WriteLine(Person.Name);
           
        }

    }
}
   










