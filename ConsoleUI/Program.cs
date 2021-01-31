using Business.Concreate;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager1 = new ProductManager(new InMemoryProductDal());
            ProductManager productManager2 = new ProductManager(new ExampleMemoryProductDal());

            Console.WriteLine("InMemoryProductDal");
            Show(productManager1);
            Console.WriteLine("---------------------");
            Console.WriteLine("ExampleMemoryProductDal");
            Show(productManager2);
            
        }

        private static void Show(ProductManager productManager2)
        {
            foreach (var product in productManager2.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
