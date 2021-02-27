
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public List<Product> GetProductByCategoryId(int id)
        {
            return _iProductDal.GetAll(x => x.CategoryId == id);
        }

        public List<Product> GetProductByUnitPrice(decimal min, decimal max)
        {
            return _iProductDal.GetAll(x => x.UnitPrice <= max && x.UnitPrice >= min);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _iProductDal.GetProductDetails();
        }
    }
}