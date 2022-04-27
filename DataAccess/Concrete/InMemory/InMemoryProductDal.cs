using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{CategoryId =1 , ProductId = 1 , ProductName = "bardak",UnitsInStock=15,UnitPrice=15 },
                new Product{CategoryId =1 , ProductId = 2 , ProductName = "tabak",UnitsInStock=3,UnitPrice=500 },
                new Product{CategoryId =2 , ProductId = 3 , ProductName = "fare",UnitsInStock=2,UnitPrice=1500 },
                new Product{CategoryId =2 , ProductId = 4 , ProductName = "kamera",UnitsInStock=65,UnitPrice=150 },
                new Product{CategoryId =2 , ProductId = 5 , ProductName = "klavye",UnitsInStock=1,UnitPrice=85  }
            };    
                
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);

        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId  = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
