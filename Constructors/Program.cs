using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();
            CustomerManager customerManager1 = new CustomerManager();
            Product product = new Product();
            Product product1 = new Product { Id = 1, name = "melek" };
            Product product2 = new Product(2, "zeliha");
            Console.WriteLine(product.name);
            Console.WriteLine(product1.name);
            Console.WriteLine(product2.name);

            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Logger = new DatabaseLogger();
            employeeManager.Add();

            EmployeeManager1 employeeManager1 = new EmployeeManager1(new DatabaseLogger());
            employeeManager1.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            //Teachers teachers = new Teachers(); //Kızar
            Teachers.Number = 10; //static nesneye direct erişim vardır


        }
    }
    class CustomerManager
    {
        private int _count; //private fieldlar alt çizgi ile başlatılır
        public CustomerManager(int conunt) //override edilebilirler
        {
            _count = conunt;
        }
        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
    class Product
    {
        private int _id;
        private string _name;
        public Product(int id, string name) {
            _id = id;
            _name = name;
        }
        public Product()
        {
        }
        public string name { get; set; }
        public int Id { get; set; }
    }
    interface ILogger{

        void Log();

    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
       }
    }

    //interface ile
    class EmployeeManager
    {
        public ILogger Logger { get; set; } //property

        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Added");
        }
    }
    //constructorlar ile
    class EmployeeManager1
    {
        private ILogger _logger;
        public EmployeeManager1(ILogger logger) //Constructor
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity) //Constructor
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity) //Constructor
        { 

        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }
    static class Teachers
    {
        //public int Number { get; set; } //kızar
        public static int Number { get; set; }

    }
    static class Utilities
    {
        
        public static void Validate()
        {
            Console.WriteLine("validation done");
        }
    }
    class Manager //bir classın kendisi olmasada fieldları veya methotları statik olabilir
    {
        public static void DoSomething()
        {
            Console.WriteLine("done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("done 2");
        }
    }
}

