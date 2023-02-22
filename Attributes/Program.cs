using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id=1,
                FirstName="Gulsun",
                LastName="Ciftci",
                Age=24
             };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();


        }
        
    }

    [ToTable("Customers")] //Customer nesnesi veritabanında Customers tablosuna denk gelir demek
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }

        [RequiredProperty] //FirstName zorunlu demek
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Dont use Add, instead AddNew Method")] //Bu Attribute bu metonun eski olduğunu ve onun yerine başka metod yazıldığını söyler
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute: Attribute //Attributeların sonuna Attribute kelimesi eklenir
    {
        //AttributeTargets.All bu Attribute ı her yerde kullanabilirsin demek
        //AttributeTargets.Class bu Attribute ı sadece classların üzerine ekleyebilirsin demek


    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple =true )]
    class ToTableAttribute : Attribute //Attributeların sonuna Attribute kelimesi eklenir
    {
        //AllowMultiple =true  birden fazla kullanılabilir demek
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
    
}
