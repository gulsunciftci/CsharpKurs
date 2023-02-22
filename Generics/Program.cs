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
