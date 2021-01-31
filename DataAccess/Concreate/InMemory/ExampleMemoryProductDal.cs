using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.InMemory
{
    public class ExampleMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public ExampleMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductID =1 ,CategoryID=1 , ProductName="Masa", UnitPrice=15,UnitInStock=15},
                new Product{ProductID =2 ,CategoryID=1 , ProductName="Tabure", UnitPrice=500,UnitInStock=3},
                new Product{ProductID =3 ,CategoryID=2 , ProductName="Sandalye", UnitPrice=1500,UnitInStock=2},
                new Product{ProductID =4 ,CategoryID=2 , ProductName="Oklava", UnitPrice=150,UnitInStock=65},
                new Product{ProductID =1 ,CategoryID=2 , ProductName="Merdane", UnitPrice=85,UnitInStock=1}

            };
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
