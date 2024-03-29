﻿
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _iProductDal;

        public ProductManager(IProductDal iProductDal)
        {
            _iProductDal = iProductDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            //ValidationTool.Validate(new ProductValidator(), product);
            _iProductDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Product>>(Messages.MeintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(), "");
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_iProductDal.Get(p => p.ProductId == id));
        }

        public IDataResult<List<Product>> GetProductByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(x => x.CategoryId == id));
        }

        public IDataResult<List<Product>> GetProductByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(x => x.UnitPrice <= max && x.UnitPrice >= min));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_iProductDal.GetProductDetails());
        }
    }
}