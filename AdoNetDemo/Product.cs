using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class Product //tablonun class karşılığı tekildir
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int StockAmount { get; set; }
    }
}
