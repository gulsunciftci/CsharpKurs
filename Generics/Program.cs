using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            List<CustomerDal> result2 = utilities.BuildList<CustomerDal>(new CustomerDal { FirstName="Derin"},new CustomerDal { FirstName="melek"});
            foreach(var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }


            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T>  BuildList<T>(params T[] items){ //generic metod
            
            
            return new List<T>(items);
        }
    }

    class ProductDal : IProductDal // IProductDal implemente edildi
    {
        public void Add(ProductDal product)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductDal product)
        {
            throw new NotImplementedException();
        }

        public ProductDal Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDal> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductDal product)
        {
           throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {

        public string FirstName { get; set; }


        public void Add(CustomerDal product)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomerDal product)
        {
            throw new NotImplementedException();
        }

        public CustomerDal Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerDal> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerDal product)
        {
            throw new NotImplementedException();
        }
    }

    interface IProductDal
    {
        List<ProductDal> GetAll();
        ProductDal Get(int id);
        void Add(ProductDal product);
        void Delete(ProductDal product);
        void Update(ProductDal product);
    }

    interface ICustomerDal:IRepository<CustomerDal> //customerDala özel bir işlem yaparken kullanılabilir
    {
        void Custom();
    }

    interface IRepository<T> //generic repository
                             //Artık product ve customer için çalışabilir
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity); //entity genel bir isim,varlık
        void Delete(T entity);
        void Update(T entity);
    }

}
