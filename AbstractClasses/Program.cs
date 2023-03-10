using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
   class Program
    {
        static void Main(string[] args)
        {
            //Database database = new Database(); //Kızar
            Database database = new Oracle();
            database.Add();
            database.Delete();
            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();
        }
    }
    abstract class Database //newleyemeyiz. //Birer inheritance tır.
    {
        public void Add() //Add herkeste aynı
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete(); //delete farklı implemente edilmeli
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
        }

    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle");
        }
    }

}
