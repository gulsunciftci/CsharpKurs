using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                //ETradeContext pahalı bir nesnedir çok yer kaplar
                //using= blok bittiği anda nesneyi zorla bellekten atar buna dispos denir

                return context.Products.ToList();
                //tabloya erişme kodu budur


                //connection stringi App.config içine <configurationString tagının altına yazmalıyız "server=(localdb)\ProjectModels;initial catalog=ETrade;integrated security=true"
                //Aşağıdaki kodu ekle
                // < connectionStrings >
                //< add name = "ETradeContext"
                //   connectionString = "server=(localdb)\ProjectModels;initial catalog=ETrade;integrated security=true"
                //    providerName = "System.Data.SqlClient" />
                //</ connectionStrings >

            }
        }
        public void Add(Product product)
        {

            using (ETradeContext context = new ETradeContext())
            {
                //context.Products.Add(product);
                //context.SaveChanges(); //yapılan işlemleri veri tabanına yazdırıyoruz

                var entity = context.Entry(product); //gönderilen productı veri tabanındakiyle ilişkilendirir
                entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges(); //yapılan işlemleri veri tabanına yazdırıyoruz
            }
        }
        public void Update(Product product)
        {

            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); //gönderilen productı veri tabanındakiyle ilişkilendirir
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges(); //yapılan işlemleri veri tabanına yazdırıyoruz
            }
        }
        public void Delete(Product product)
        {

            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); //gönderilen productı veri tabanındakiyle ilişkilendirir
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges(); //yapılan işlemleri veri tabanına yazdırıyoruz
            }
        }
    }
}
