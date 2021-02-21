
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public class ProductManager : IProductService
    {
        IProductDal _iProductDal;

        public ProductManager(IProductDal iProductDal)
        {
            _iProductDal = iProductDal;
        }
        public List<Product> GetAll()
        {
            return _iProductDal.GetAll();
        }
    }
}