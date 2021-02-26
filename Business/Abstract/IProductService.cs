using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductByCategoryId(int id);
        List<Product> GetProductByUnitPrice(decimal min, decimal max);
    }
}
