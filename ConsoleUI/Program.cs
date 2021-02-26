using Business.Abstract;
using DataAccessLayer.Concrete.EntityMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager product = new ProductManager(new EfProductDal());
            foreach (var item in product.GetProductByCategoryId(2))
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
