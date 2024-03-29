﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager()
        {
        }

        public ProductManager(IProductDal productDal)
        { 
            _productDal = productDal; 
        }
        public List<Product> GetAllById()   
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllById(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId == id);   
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);

        }
    }
}
 