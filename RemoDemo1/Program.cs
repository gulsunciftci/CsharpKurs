using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoDemo1
{
    internal class Program //bir classın defaultu internaldır internalları bu proje içinden istediğimiz noktadan çağırabiliriz
    {
        //bir class private veya protected olamaz.içiçe classlarda bu mümkündür
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new FileLogger();
            customerManager.Add();
            customerManager.Logger = new DatabaseLogger();
            customerManager.Add();

        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; } //property injection
        public void Add()
        {
       
            Logger.Log();
            Console.WriteLine("Customer added");
                
        }
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
            Console.WriteLine("Logged to file");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
