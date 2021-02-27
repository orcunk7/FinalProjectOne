using Business.Abstract;
using Business.Concrete;
using DataAccessLayer.Concrete.EntityMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            CategoryManager cat = new CategoryManager(new EfCategoryDal());
            foreach (var item in cat.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
            Console.WriteLine("Hello World!");
        }

        private static void ProductTest()
        {
            ProductManager product = new ProductManager(new EfProductDal());
            foreach (var item in product.GetProductByCategoryId(2))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
