using Business.Abstract;
using DataAccessLayer.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager product = new ProductManager(new InMemoryProductDal());
            Console.WriteLine("Hello World!");
        }
    }
}
