﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete.EntityMemory
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();

            }
        }

        public void Update(Product entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var mdifiedEntity = context.Entry(entity);
                mdifiedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
