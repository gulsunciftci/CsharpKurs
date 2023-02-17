using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            CustomerManager manager = new CustomerManager();
            manager.Add();
            manager.Id = 1;
            manager.FirstName = "gulsun";

            CustomerManager manager1 = new CustomerManager
            {
                Id = 2,
                FirstName = "merve"
            };
            Console.WriteLine(manager.FirstName);
            Console.WriteLine(manager1.FirstName);
        }
    }

}
