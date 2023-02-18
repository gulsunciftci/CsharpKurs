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
                                 
                               //COLLECTİONLAR
            //ArrayList
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add('T');
            cities.Add(1);
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
