using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo { 

    public class Product //tablonun class karşılığı tekildir.
                         //Entity frameworkte en önemlisi tabloya karşılık gelen classın olmasıdır
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int StockAmount { get; set; }

       

    }
}
