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

        //bağlantı nesnesi oluşturalım
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\ProjectModels;initial catalog=ETrade;integrated security=true"); //NOT: classın içinde ama metodların dışında tanımlandığı için alt çizgi ile tanımlanır
        //@=tamamen string olarak kabul et demek
        //initialcatalog=hangi veri tabanına bağlanacağını söyler
        //integrated security=false yaparsak uzaktaki veri tabanına bağlanırız

        public List<Product> GetAll()
        {

            ConnectionControl();
            //"select * from Products" sorgusunu connection a göndeririz
            SqlCommand command = new SqlCommand("select * from Products",_connection); //kodu çalıştırmak için SqlCommand sınıfından yararlanırız


            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount= Convert.ToInt32(reader["StockAmount"]),
           

                };
               
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }

        

        public DataTable GetAll2()
        {

            ConnectionControl();
            //"select * from Products" sorgusunu connection a göndeririz
            SqlCommand command = new SqlCommand("select * from Products", _connection); //kodu çalıştırmak için SqlCommand sınıfından yararlanırız


            SqlDataReader reader = command.ExecuteReader();

            //Datatable oluşturup içini readerla doldurduk
            DataTable dataTable = new DataTable(); //kullanılmaz çünkü pahalı bir nesnedir
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;


        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }


       // ürün ekleme metodu
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        //güncelleme metodu
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name=@name,StockAmount=@stockAmount where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        //silme metodu
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Products where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
