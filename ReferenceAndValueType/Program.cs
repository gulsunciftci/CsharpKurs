using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number1 = 10;
            int number2 = 20;

            //değer tipi
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            //referans tipi
            string[] cities = {"Ankara","Adana" }; //101
            string[] cities1 = { "Bursa", "Bolu" }; //101
            cities1 = cities; //cities in referansı citiec 1 e eşit olur
            cities[0] = "istanbul";
            Console.WriteLine(cities1[0]);//istanbul yazar

            ////performans sorunu oluşturur
            //DataTable dataTable = new DataTable();
            //DataTable dataTable1 = new DataTable();
            //dataTable1 = dataTable;

            DataTable dataTable;
            DataTable dataTable1 = new DataTable();
            dataTable = dataTable1;



        }
    }
}
