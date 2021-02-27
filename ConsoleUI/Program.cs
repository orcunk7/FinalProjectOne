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
            ProductTest();
            //CategoryTest();
            Console.WriteLine("Hello World!");
        }

        private static void CategoryTest()
        {
            CategoryManager cat = new CategoryManager(new EfCategoryDal());
            foreach (var item in cat.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager product = new ProductManager(new EfProductDal());
            foreach (var item in product.GetProductDetails())
            {
                Console.WriteLine(item.ProductName + "- " + item.CategoryName);
            }
        }
    }
}
