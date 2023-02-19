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

        public DataTable GetAll()
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

            //Datatable oluşturup içini readerla doldurduk
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;


        }

    }
}
