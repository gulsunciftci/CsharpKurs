using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdoNetDemo
{
    public class ProductDal //veri çekme,gönderme gibi işlemler bulunur
    {

        public List<Product> GetAll()
        {
            //bağlantı nesnesi oluşturalım
            SqlConnection connection = new SqlConnection(@"server=(localdb)\ProjectModels;initial catalog=ETrade;integrated security=true");
            //@=tamamen string olarak kabul et demek
            //initialcatalog=hangi veri tabanına bağlanacağını söyler
            //integrated security=false yaparsak uzaktaki veri tabanına bağlanırız

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

            }
            //"select * from Products" sorgusunu connection a göndeririz
            SqlCommand command = new SqlCommand("select * from Products",connection); //kodu çalıştırmak için SqlCommand sınıfından yararlanırız


            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount= Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice= Convert.ToDecimal(reader[" UnitPrice"])

                };
                products.Add(product);
                reader.Close();
                connection.Close();
                return products;
            }
        }
        public DataTable GetAll2()
        {
            //bağlantı nesnesi oluşturalım
            SqlConnection connection = new SqlConnection(@"server=(localdb)\ProjectModels;initial catalog=ETrade;integrated security=true");
            //@=tamamen string olarak kabul et demek
            //initialcatalog=hangi veri tabanına bağlanacağını söyler
            //integrated security=false yaparsak uzaktaki veri tabanına bağlanırız

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

            }
            //"select * from Products" sorgusunu connection a göndeririz
            SqlCommand command = new SqlCommand("select * from Products", connection); //kodu çalıştırmak için SqlCommand sınıfından yararlanırız


            SqlDataReader reader = command.ExecuteReader();

            //Datatable oluşturup içini readerla doldurduk
            DataTable dataTable = new DataTable(); //kullanılmaz çünkü pahalı bir nesnedir
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;


        }
    }
}
