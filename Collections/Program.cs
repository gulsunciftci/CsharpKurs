using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Array
            //string[] cities = new string[] { "Ankara", "İstanbul" }; x
            //cities[2] = "Adana"; //kızar
                                 
                               //COLLECTİONS
            //ArrayList
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add('T');
            cities.Add(1);
            //Tip güvenli çalışamadık
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }



            Console.WriteLine("********************************************************");



            //Tip güvenli collectionlar
            List<string> citiess = new List<string>();
            citiess.Add("Ankara");
            citiess.Add("İstanbul");
            //citiess.Add(2); //kızdı
            foreach (var city in citiess)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("********************************************************");


            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { FirstName = "gulsun", Id = 1 });
            //customers.Add(new Customer { FirstName = "didem", Id = 2 });


            List<Customer> customers = new List<Customer>() {
                 new Customer { FirstName = "gulsun", Id = 1 },
                 new Customer { FirstName = "didem", Id = 2 }
            };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }



            Console.WriteLine("********************************************************");


            //COLLECTİONS ÖZELLİKLERİ

            
            customers.Add(new Customer { FirstName="ahmet",Id=3 });
            var customer2 = new Customer
            {
                Id=4,FirstName="haktan"
            };
            customers.Add(customer2); 
            customers.AddRange(new Customer[2]
            {
                new Customer{FirstName="melek",Id=5},
                new Customer{FirstName="zeynep",Id=6}
            });
            Console.WriteLine(customers.Contains(customer2));
            Console.WriteLine("İndex:{0}",customers.IndexOf(customer2));
            Console.WriteLine("İndex Sondan:{0}", customers.LastIndexOf(customer2));

            customers.Insert(0,customer2);
            customers.Remove(customer2); //bulduğu ilk değeri siler
            customers.RemoveAll(C=>C.FirstName=="gulsun"); //ismi gulsun olanların hepsini siler


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine("count:{0}", count);
            customers.Clear();
            count = customers.Count;
            Console.WriteLine("count:{0}",count);



        }
    }

    

    class Customer { 
    
        public string FirstName { get; set; }
        public int Id { get; set; }
    } 
}
